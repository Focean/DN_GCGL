using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GemBox.ExcelLite;
using System.Collections;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
namespace GCGL_Client.OCC
{
    public partial class EXCELtoSQL : Form
    {
        public EXCELtoSQL()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind()
        {
            dataGridView1.DataSource = AppServer.wcfClient.FZB_编码_List("处置形式").Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        txtPath.Text = dialog.FileName;
                    }
                    catch { }
                }
            }

        }

        /// <summary>
        /// 将Excel中的数据导入到SQL数据库中
        /// </summary>
        private void btnExcelout_Click(object sender, EventArgs e)
        {
            DataSet ds = ImportFromExcel(txtPath.Text.Trim());
            DataTable dt = ds.Tables[0];

            #region 提交数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                    base.Cursor = Cursors.WaitCursor;
                    try
                    {
                        if (!AppServer.WcfService_Open()) return;
                        var model = new Ref_WS_GCGL.DataType_FZB_编码();

                        TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                        model.ExAction = "Add";
                        model.处置形式编码 = dt.Rows[i][0].ToString().Trim();
                        model.处置形式名称 = dt.Rows[i][1].ToString().Trim();
                        AppServer.wcfClient.FZB_处置形式_Edit(ref model);
                        if (model.ExResult != 0)
                        {
                            AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                            return;
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
            #endregion
               
            }
        }


        #region Excel导入SQL数据库
        /// <summary>
        /// 获取Excel数据表列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetExcelTables(string FilePath)
        {
            //将Excel架构存入数据里
            System.Data.DataTable dt = new System.Data.DataTable();
            ArrayList TablesList = new ArrayList();

            if (File.Exists(FilePath))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet." +
                     "OLEDB.4.0;Extended Properties=\"Excel 8.0\";Data Source=" + FilePath))
                {
                    try
                    {
                        conn.Open();
                        dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }

                    //获取数据表个数
                    int tablecount = dt.Rows.Count;
                    for (int i = 0; i < tablecount; i = i + 2)
                    {
                        string tablename = dt.Rows[i][2].ToString().Trim().TrimEnd('$');
                        if (TablesList.IndexOf(tablename) < 0)
                        {
                            TablesList.Add(tablename);
                        }

                    }
                }
            }
            return TablesList;
        }

        /// <summary>
        /// 导入Excel数据表至DataTable（第一行作为表头）
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataSet FillDataSet(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                throw new Exception("Excel文件不存在！");
            }

            ArrayList TableList = new ArrayList();
            TableList = GetExcelTables(FilePath);
            if (TableList.Count <= 0)
            {
                return null;
            }


            System.Data.DataTable table;
            System.Data.DataSet ds = new DataSet();
            OleDbConnection dbcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties=Excel 8.0");
            try
            {
                if (dbcon.State == ConnectionState.Closed)
                {
                    dbcon.Open();
                }
                for (int i = 0; i < TableList.Count; i++)
                {
                    string dtname = TableList[i].ToString();
                    try
                    {
                        OleDbCommand cmd = new OleDbCommand("select * from [" + dtname + "$]", dbcon);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        table = new DataTable(dtname);
                        adapter.Fill(table);
                        ds.Tables.Add(table);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }
            finally
            {
                if (dbcon.State == ConnectionState.Open)
                {
                    dbcon.Close();
                }
            }
            return ds;
        }

        /// <summary>
        /// Excel导入数据库
        /// </summary>
        /// <returns></returns>
        public static DataSet ImportFromExcel(string FilePath)
        {
            return FillDataSet(FilePath);
        }

        #endregion 

        //读取Excel的方法
        //private void OpenExcel(string strFileName)
        //{
        //    object missing =System.Reflection.Missing.Value;
        //    Application excel = new Application();
        //    if (excel == null)
        //    {
        //        MessageBox.Show("Can't access excel");

        //    }
        //    else
        //    {
        //        excel.
        //    }
        //}


    }
}
