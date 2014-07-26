using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace GCGL_Client.NET
{
    public partial class NET_附件管理 : Form
    {
        int WorkState = 0; // 1-上传 2-下载

        WcfFileTransfer.FileTransferClient client;

        //附件编码
        public string FileCode { get; set; }
        public string FileInfo { get; set; }


        private DataTable filetable;

        public DataTable Files { get { return filetable; } }
        
        public NET_附件管理()
        {
            InitializeComponent();

            client = new WcfFileTransfer.FileTransferClient();
            client.UploadFileCompleted += client_UploadFileCompleted; // 怎么支持多线程 ?       
            client.DownloadFileCompleted += client_DownloadFileCompleted;
        }

        public void Editor_Mod(string AFJCode)
        {
            FileCode = AFJCode;
            WorkState = 1;
            this.ReadFileList(AFJCode);
            this.Text = "附件管理";
            if (!string.IsNullOrEmpty(AFJCode)) this.Text = string.Format("附件管理({0})", AFJCode);

            this.btnSendFile.Text = "上传文件(&U)";
            //this.btnOK.Enabled = true;
            this.pnlDownPath.Visible = false;
        }

        public void Editor_See(string AFJCode)
        {
            FileCode = AFJCode;
            WorkState = 2;
            this.ReadFileList(AFJCode);
            this.Text = "附件查看";
            if (!string.IsNullOrEmpty(AFJCode)) this.Text = string.Format("附件查看({0})", AFJCode);

            this.btnSendFile.Text = "下载文件(&D)";
            this.btnOK.Text = "返回(&X)";
            this.btnChooseFile.Enabled = false;
            this.btnClearList.Enabled = false;
            this.btnRemoveFile.Enabled = false;
        }

        private void ReadFileList(string AFJCode)
        {
            filetable = new DataTable();
            filetable.Columns.Add(new DataColumn("序号", typeof(Int32)));
            filetable.Columns.Add(new DataColumn("文件", typeof(string)));
            filetable.Columns.Add(new DataColumn("文件标识", typeof(string)));
            filetable.Columns.Add(new DataColumn("文件路径", typeof(string)));
            filetable.Columns.Add(new DataColumn("路径", typeof(string)));
            filetable.Columns.Add(new DataColumn("大小", typeof(long)));
            filetable.Columns.Add(new DataColumn("进度", typeof(Int32)));
            filetable.Columns.Add(new DataColumn("状态", typeof(Int32)));     // 1-等待上传 2-正在上传 3-传输成功 4-传输失败
            filetable.Columns.Add(new DataColumn("操作", typeof(Int32)));     // 1-等待上传 2-正在上传 3-传输成功 4-传输失败
            filetable.PrimaryKey = new DataColumn[] { filetable.Columns["文件标识"] };

            //AppServer.ShowMsg(AFJCode);
            if (!string.IsNullOrEmpty(AFJCode))
            {
                base.Cursor = Cursors.WaitCursor;
                try
                {
                    if (!AppServer.WcfService_Open()) return;
                    //
                    var model = new Ref_WS_GCGL.DataType_NET_附件管理();
                    model.ExAction = "List";
                    model.附件编码 = AFJCode;

                    DataTable file = AppServer.wcfClient.NET_附件管理_List(ref model).Tables[0];
                    //AppServer.ShowMsg(string.Format("RC={0}", file.Rows.Count));
                    //
                    int index = 0;
                    foreach (DataRow dr in file.Rows)
                    {
                        if (WorkState == 1)
                        {
                            filetable.Rows.Add(new object[] { ++index, 
                                dr["文件名称"].ToString(), 
                                dr["文件标识"].ToString(),
                                dr["文件路径"].ToString(),
                                dr["路径"].ToString(),
                                (long)dr["文件大小"] , 100, 3, 3 });
                        }
                        else
                        {
                            filetable.Rows.Add(new object[] { ++index, 
                                dr["文件名称"].ToString(), 
                                dr["文件标识"].ToString(),
                                dr["文件路径"].ToString(),
                                dr["路径"].ToString(),
                                (long)dr["文件大小"] , 0, 1, 1 });
                        }
                    }
                }
                catch (Exception ex)
                {
                    AppServer.ShowMsg_ExceptError(ex.Message);
                    return;
                }
                finally
                {
                    AppServer.WcfService_Close();
                    base.Cursor = Cursors.Arrow;
                }
            }
            this.dataGridView1.DataSource = filetable;
        }

        // 此函数被线程执行
        public void SaveFile(object p)
        {

            WcfFileTransfer.DownloadFileCompletedEventArgs e = p as WcfFileTransfer.DownloadFileCompletedEventArgs;

            Stream sourceStream = e.FileData;

            long fileSize = e.Result;
            long copySize = 0;

            //如何更新主线程中的组件
            this.dataGridView1.Rows[e.Index].Cells["进度"].Value = 0;

            try
            {
                //文件流传输
                string fileName = this.txtSavePath.Text + this.dataGridView1.Rows[e.Index].Cells["文件"].Value;
                using (FileStream targetStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {


                    //定义文件缓冲区
                    const int bufferLen = 4096;
                    byte[] buffer = new byte[bufferLen];
                    int count = 0;

                    // 为什么每次实际读取的是255而不是4096
                    while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
                    {
                        targetStream.Write(buffer, 0, count);
                        copySize += count;

                        // 进度条
                        float f = (((float)copySize / (float)fileSize)) * 100;
                        int i = Convert.ToInt32(f);

                        if ((Int32)this.dataGridView1.Rows[e.Index].Cells["进度"].Value != i)
                        {
                            this.dataGridView1.Rows[e.Index].Cells["进度"].Value = i;
                            //this.dataGridView1.Refresh();
                        }
                    }

                    //下面的语句简单，但不能显示进度
                    //sourceStream.CopyTo(targetStream);
                    //targetStream.Flush();

                    targetStream.Close();
                    sourceStream.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //log.Info("错误：" + ex.Message);
                //Program.Get_ILog().Log(logInfo + ex.Message);
            }

            this.dataGridView1.Rows[e.Index].Cells["状态"].Value = 3;
        }

        public void client_DownloadFileCompleted(object sender, WcfFileTransfer.DownloadFileCompletedEventArgs e)
        {
            // 下面的代码应该放在线程里去做 否则 就得排队
            if (e.FileData.CanRead)
            {

                Thread t = new Thread(this.SaveFile);
                t.Start(e);
            }
        }

        private void DownloadFiles()
        {
            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
                DownloadFile(dr);
        }

        private void DownloadFile(DataGridViewRow dr)
        {
            string fileName = dr.Cells["文件"].Value.ToString();
            string Path = dr.Cells["路径"].Value.ToString();
            string filePath = dr.Cells["文件路径"].Value.ToString();
            dr.Cells["状态"].Value = 2;

            client.DownloadFileAsync(fileName, filePath, dr.Index, Path);
        }

        // 保证线程安全访问DataGridView1
        private void FileTransTimer_Tick(object sender, EventArgs e)
        {
            FileTransTimer t = sender as FileTransTimer;

            float f = (((float)t.CopySize / (float)t.FileSize)) * 100;
            int i = Convert.ToInt32(f);

            // 线程安全
            //if ((Int32)this.dataGridView1.Rows[t.Index].Cells["进度"].Value != i)
            //    this.dataGridView1.Rows[t.Index].Cells["进度"].Value = i;
            UpdateDataGridView(t.Index, i);

            if (i < 100)
                t.ReStart();
            else
            {
                t.StopAndClose();
                t.WaitHandler.Set();
            }
        }

        delegate void UpdateDataGridViewStateCallback(int index, int state);
        private void UpdateDataGridViewState(int index, int state)
        { 
            if (this.dataGridView1.InvokeRequired)  
            {
                UpdateDataGridViewStateCallback d = new UpdateDataGridViewStateCallback(UpdateDataGridViewState);
                this.Invoke(d, new object[] { index, state });
            }
            else
                this.dataGridView1.Rows[index].Cells["状态"].Value = state;
        }

        delegate void UpdateDataGridViewCallback(int index, int progress);   
 
        private void UpdateDataGridView(int index, int progress)
        {
            // 奇怪，一致没有执行这个，难道是线程安全？？？
            if (this.dataGridView1.InvokeRequired)  
            {
                UpdateDataGridViewCallback d = new UpdateDataGridViewCallback(UpdateDataGridView);
                this.Invoke(d, new object[] { index, progress });
            }
            else
            {
                if ((Int32)this.dataGridView1.Rows[index].Cells["进度"].Value != progress)
                    this.dataGridView1.Rows[index].Cells["进度"].Value = progress;

                if (progress == 100)
                    this.dataGridView1.Rows[index].Cells["状态"].Value = 3;
            }         
        }

        private void UploadFiles()
        {
            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {
                if (dr.Cells["状态"].Value.ToString() != "3") this.UploadFile(dr);
            }
        }

        private void UploadFile(DataGridViewRow dr)
        {
            string fileName = dr.Cells["文件"].Value.ToString();

            UpdateDataGridViewState(dr.Index, 2);

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            FileTransTimer timerFileTrans = new FileTransTimer(fs, 100, dr.Index);
            dr.Tag = timerFileTrans;
            timerFileTrans.Tick += FileTransTimer_Tick;
            timerFileTrans.Start();

            client.UploadFileAsync(Path.GetFileName(fileName), dr.Index, this.FileCode, fs);
        }

        // 要保证线程安全：因为是异步调用，这个函数就是在一个独立的线程调用这个函数的。

        delegate void DoUploadFileCompletedCallback(int Index, string FilePath, string Path, string Stream_ID);
        private void DoUploadFileCompleted(int Index, string FilePath, string Path, string Stream_ID)
        {
            if (this.dataGridView1.InvokeRequired)
            {
                DoUploadFileCompletedCallback d = new DoUploadFileCompletedCallback(DoUploadFileCompleted);
                this.Invoke(d, new object[] { Index,  FilePath, Path, Stream_ID });
            }
            else
            {
                this.dataGridView1.Rows[Index].Tag = null;
                this.dataGridView1.Rows[Index].Cells["路径"].Value = Path;
                this.dataGridView1.Rows[Index].Cells["文件路径"].Value = FilePath;
                this.dataGridView1.Rows[Index].Cells["文件标识"].Value = Stream_ID;
            }          
        }

        private void client_UploadFileCompleted(object sender, WcfFileTransfer.UploadFileCompletedEventArgs e)
        {
            // 线程安全
            DoUploadFileCompleted(e.Index, e.Result, e.Path, e.Stream_ID);
        }


        private void btnSelDir_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtSavePath.Text = this.folderBrowserDialog.SelectedPath;
                if (!this.txtSavePath.Text.EndsWith("\\")) this.txtSavePath.Text += "\\";
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "操作")
                if (this.WorkState == 1)
                    e.Value = "上传";
                else
                    e.Value = "下载";
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "状态")
                if (this.WorkState == 1)
                    switch ((Int32)e.Value)
                    {
                        case 1:
                            e.Value = "等待上传";
                            break;
                        case 2:
                            e.Value = "正在上传";
                            break;
                        case 3:
                            e.Value = "上传成功";
                            break;
                        case 4:
                            e.Value = "上传失败";
                            break;
                        default:
                            e.Value = null;
                            break;
                    }
                else if (this.WorkState == 2)
                    switch ((Int32)e.Value)
                    {
                        case 1:
                            e.Value = "等待下载";
                            break;
                        case 2:
                            e.Value = "正在下载";
                            break;
                        case 3:
                            e.Value = "下载成功";
                            break;
                        case 4:
                            e.Value = "下载失败";
                            break;
                        default:
                            e.Value = null;
                            break;
                    }
                else
                    e.Value = null;

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            // this.WorkState = 1;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        DataRow type = filetable.NewRow();
                        type["序号"] = 1;
                        type["文件标识"] = Guid.NewGuid().ToString();
                        type["文件"] = dialog.FileNames[i];
                        type["进度"] = 0;
                        System.IO.FileInfo fi = new System.IO.FileInfo(dialog.FileNames[i]);
                        fi.OpenRead();
                        type["大小"] = fi.Length;
                        type["状态"] = 1;
                        try
                        {
                            filetable.Rows.Add(type);
                        }
                        catch { continue; }
                    }
                }
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            (this.dataGridView1.DataSource as DataTable).Rows.Clear();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (this.WorkState == 1)
            {
                if (string.IsNullOrEmpty(this.FileCode))
                {
                    base.Cursor = Cursors.WaitCursor;
                    try
                    {
                        if (!AppServer.WcfService_Open()) return;
                        //
                        var model = new Ref_WS_GCGL.DataType_NET_附件管理();
                        model.ExAction = "Add";
                        model.LoginUserCode = AppServer.LoginUnitCode;

                        AppServer.wcfClient.NET_附件管理_Edit(ref model);
                        //
                        if (model.ExResult != 0)
                        {
                            AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                            return;
                        }
                        //
                        this.FileCode = model.附件编码;
                    }
                    catch (Exception ex)
                    {
                        AppServer.ShowMsg_ExceptError(ex.Message);
                        return;
                    }
                    finally
                    {
                        AppServer.WcfService_Close();
                        base.Cursor = Cursors.Arrow;
                    }
                }
                //
                this.UploadFiles();
            }
            else
            {
                this.DownloadFiles();
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in this.dataGridView1.SelectedRows)
            {
                if (dr.Cells["状态"].Value.ToString() == "3")
                {
                    // 从服务器删除
                    client.DeleteFile(dr.Cells["文件路径"].Value.ToString());
                };

                this.label1.Text = dr.Cells["状态"].Value.ToString();

                if (dr.Cells["状态"].Value.ToString() == "1" || dr.Cells["状态"].Value.ToString() == "3")
                     this.dataGridView1.Rows.Remove(dr);
            }
        }

        public int FileCount { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (WorkState == 2)
            {
                this.Close();
                return;
            }
            //
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_NET_附件管理();
                model.ExAction = "AddFile";
                model.附件编码 = this.FileCode;
                model.LoginUserCode = AppServer.LoginUnitCode;
                this.FileInfo = "";

                foreach (DataRow dr in filetable.Rows)
                {
                    if ((int)dr["状态"] == 3)
                    {
                        model.文件标识 = dr["文件标识"].ToString();

                        if (this.FileInfo != "") this.FileInfo = this.FileInfo + "、";
                        this.FileInfo = this.FileInfo + Path.GetFileName(dr["文件"].ToString());
                        //
                        AppServer.wcfClient.NET_附件管理_Edit(ref model);
                        //
                        if (model.ExResult != 0)
                        {
                            AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                            return;
                        }
                    }
                }
                //
                model.ExAction = "Mod";
                model.附件编码 = this.FileCode;
                //AppServer.ShowMsg("aaaa");
                //if (this.FileInfo.Length > 75) this.FileInfo = this.FileInfo.Substring(1, 70) + "...";
                //AppServer.ShowMsg("bbbb");
                this.FileInfo = string.Format("共 {0} 个文件：{1}", filetable.Rows.Count, this.FileInfo);
                model.附件摘要 = this.FileInfo;
                model.附件备注 = "";
                model.LoginUserCode = AppServer.LoginUnitCode;
                //
                AppServer.wcfClient.NET_附件管理_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //
                this.FileCount = filetable.Rows.Count;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
        }
    }

    #region 基础类定义

    class FileTransTimer : System.Windows.Forms.Timer
    {
        private FileStream fs;
        private int interval;
        private int index;
        private AutoResetEvent waithandler;
        private bool closed;

        public FileTransTimer(FileStream fileStream, int interval, int index)
        {
            fs = fileStream;
            this.interval = interval;
            this.Interval = interval;
            this.index = index;
            this.waithandler = new AutoResetEvent(false);
        }

        public void ReStart()
        {
            this.Interval = this.interval;
            //this.Start();
        }

        public void StopAndClose()
        {
            //this.fs.Close();
            this.Stop();
            this.closed = true;
        }

        public long CopySize { get { return fs.Position; } }
        public long FileSize { get { return fs.Length; } }
        public int Index { get { return index; } }
        public AutoResetEvent WaitHandler { get { return this.waithandler; } }
        public bool Closed { get { return closed; } }
    }

    class DataGridViewProgressColumn : DataGridViewImageColumn
    {
        public DataGridViewProgressColumn()
        {
            CellTemplate = new DataGridViewProgressCell();
        }
    }

    class DataGridViewProgressCell : DataGridViewImageCell
    {
        // Used to make custom cell consistent with a DataGridViewImageCell
        static Image emptyImage;
        static DataGridViewProgressCell()
        {
            emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        public DataGridViewProgressCell()
        {
            this.ValueType = typeof(int);
        }
        // Method required to make the Progress Cell consistent with the default Image Cell. 
        // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an int.
        protected override object GetFormattedValue(object value,
                            int rowIndex, ref DataGridViewCellStyle cellStyle,
                            TypeConverter valueTypeConverter,
                            TypeConverter formattedValueTypeConverter,
                            DataGridViewDataErrorContexts context)
        {
            return emptyImage;
        }

        protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            int progressVal;

            if (value != null)
                progressVal = (int)value; // 如果不是整数 将出错
            else
                progressVal = 0;


            float percentage = ((float)progressVal / 100.0f); // Need to convert to float before division; otherwise C# returns int which is 0 for anything but 100%.
            Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
            Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);
            // Draws the cell grid
            base.Paint(g, clipBounds, cellBounds,
             rowIndex, cellState, value, formattedValue, errorText,
             cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));

            string s = string.Format("{0}%", progressVal);
            SizeF size = g.MeasureString(s, this.DataGridView.Font);
            float x = (cellBounds.Width - size.Width) / 2;
            float y = (cellBounds.Height - size.Height) / 2;


            if (percentage > 0.0 || percentage - 0.0 < float.Epsilon)
            {
                // Draw the progress bar and the text
                g.FillRectangle(new SolidBrush(Color.FromArgb(163, 189, 242)), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((percentage * cellBounds.Width - 4)), cellBounds.Height - 4);
                if (progressVal != 0)
                    g.DrawString(s, cellStyle.Font, foreColorBrush, cellBounds.X + x, cellBounds.Y + y);
            }
            else // ?????
            {
                // draw the text
                if (this.DataGridView.CurrentRow.Index == rowIndex)
                    g.DrawString(s, cellStyle.Font, new SolidBrush(cellStyle.SelectionForeColor), cellBounds.X + 6, cellBounds.Y + 2);
                else
                    g.DrawString(s, cellStyle.Font, foreColorBrush, cellBounds.X + x, cellBounds.Y + y);
            }
        }
    }

    #endregion

}
