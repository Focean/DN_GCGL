using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.RPT
{
    public partial class RPT_查询方案 : Form
    {
        public RPT_查询方案()
        {
            InitializeComponent();
            DataCheck();
            ImageList il = new ImageList();
            il.ImageSize = new Size(1, 20);
            lv方案.SmallImageList = il;
            lv方案.Columns.Add("方案名称",145);
            lv方案.Columns.Add("内容",0);

        }
        private void RPT_查询方案_Load(object sender, EventArgs e)
        {
            this.lv方案.Items.Clear();
            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_FZB_查询方案();
                model.ExAction = "List";
                model.创建人 = AppServer.LoginUserCode;
                model.类型 = "单位编制统计";
                DataTable table=AppServer.wcfClient.FZB_查询方案_List(ref model).Tables[0];
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        string str_nr = table.Rows[i]["内容"].ToString();
                        string str_mc = table.Rows[i]["名称"].ToString();
                        //添加数据
                        ListViewItem item = new ListViewItem(str_mc);
                        item.SubItems.Add(str_nr);
                        this.lv方案.Items.Add(item);
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
            #endregion
        }
        private void DataCheck()
        {
            this.clb单位.DataSource = AppServer.UdataTable;
            this.clb单位.ValueMember = "单位编码";
            this.clb单位.DisplayMember = "单位名称";
        }

        private void cb全选_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb全选.Checked)
            {
                for (int i = 0; i < clb单位.Items.Count; i++)
                {
                    clb单位.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else
            {
                for (int i = 0; i < clb单位.Items.Count; i++)
                {
                    clb单位.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        public string CheckList = string.Empty;
        private void label1_Click(object sender, EventArgs e)
        {
            int j = this.lv方案.Items.Count;
            for (int i = 0; i < clb单位.CheckedItems.Count; i++)
            {
                DataRowView dv = ((DataRowView)clb单位.CheckedItems[i]);
                CheckList += dv["单位编码"].ToString() + ",";
            }

            //添加数据
            ListViewItem item = new ListViewItem("方案" + j);
            item.SubItems.Add(CheckList);          
            this.lv方案.Items.Add(item);
        }     

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lv方案.SelectedItems)
            {   
                using (var form = new RPT_查询方案_重命名())
                {
                    form.FAname = item.SubItems[0].Text;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.FAname != null && form.FAname != "" && form.FAname != string.Empty)
                        {
                            item.SubItems[0].Text = form.FAname;
                        }
                    }
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppServer.DialogMsg("你确定要删除选中的方案吗？", "提示"))
            {
                foreach (ListViewItem item in this.lv方案.SelectedItems)
                {
                    item.Remove();
                }
            }
        }
        private string[] arrstr = null;
        private void lv方案_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空被选中的项
            for (int i = 0; i < clb单位.Items.Count; i++)
            {
                clb单位.SetItemCheckState(i, CheckState.Unchecked);
            }
            CheckList = string.Empty;
            foreach (ListViewItem item in this.lv方案.SelectedItems)
            {
                //获取选中方案的选择单位编码
                CheckList = item.SubItems[1].Text;
            }

            //根据获取的单位编码选中clb单位
             arrstr = CheckList.Split(new char[]{','});
             for (int i = 0; i < this.arrstr.Length; i++)
             {
                 for (int j = 0; j < clb单位.Items.Count; j++)
                 {
                     DataRowView dv = ((DataRowView)clb单位.Items[j]);
                     if (dv["单位编码"].ToString() == arrstr[i])
                     {
                         this.clb单位.SetItemCheckState(j, CheckState.Checked);
                     }
                 }
             }
        }
        private void btn确定_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection SelectItem =
            this.lv方案.SelectedItems;
            CheckList = string.Empty;
            foreach (ListViewItem item in SelectItem)
            {
                CheckList = item.SubItems[1].Text;
            }
            if (CheckList == string.Empty)
            {
                for (int i = 0; i < clb单位.CheckedItems.Count; i++)
                {
                    DataRowView dv = ((DataRowView)clb单位.CheckedItems[i]);
                    CheckList += dv["单位编码"].ToString() + ",";
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn保存方案_Click(object sender, EventArgs e)
        {
            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_FZB_查询方案();
                model.ExAction = "Del";
                model.创建人 = AppServer.LoginUserCode;
                model.类型 = "单位编制统计";
                AppServer.wcfClient.FZB_查询方案_Edit(ref model);

                foreach (ListViewItem item in lv方案.Items)
                {
                    CheckList = item.SubItems[1].Text;
                    model.ExAction = "Add";
                    model.创建人 = AppServer.LoginUserCode;
                    model.类型 = "单位编制统计";
                    model.名称 = item.SubItems[0].Text;
                    model.内容 = item.SubItems[1].Text;
                    AppServer.wcfClient.FZB_查询方案_Edit(ref model);
                }
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
}
