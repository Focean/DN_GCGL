using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.OCC
{
    public partial class OCC_处置申请_Select : Form
    {
        public OCC_处置申请_Select()
        {
            InitializeComponent();
            this.dtp开始时间.Value = this.dtp结束时间.Value.AddMonths(-1);         
        }

        #region 处置形式窗体定义
        public static string Ucode=null;
        public void Select_DB(string Code)
        {
            this.Text = "调拨处置申请选择";
            this.Tag = "DB";
            Ucode = Code;           
        }
        public void Select_BF(string ACardCode)
        {
            this.Text = "报废处置申请选择";
            this.Tag = "BF";
        }
        public void Select_CS(string ACardCode)
        {
            this.Text = "出售处置申请选择";
            this.Tag = "CS";
        }
        #endregion

        #region 数据绑定自定义方法
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_处置申请();
                model.ExAction = "Search";
                if (AppServer.LoginUnitType == 1)
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else
                {
                    model.单位编码 = Ucode;
                }
                model.开始时间 = dtp开始时间.Value;
                model.结束时间 = dtp结束时间.Value;
                DataSet db = AppServer.wcfClient.OCC_处置申请_List(ref model);
                if (this.Tag.ToString() == "DB")//查询出来的第一个数据表
                {
                    this.dgvList.DataSource = db.Tables[0];//调拨
                }
                else if (this.Tag.ToString() == "BF")
                {
                    this.dgvList.DataSource = db.Tables[1];//第二个数据表(报废)
                }
                else if (this.Tag.ToString() == "CS")
                {
                    this.dgvList.DataSource = db.Tables[2];//第三个数据表(出售)
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
        #endregion

        private void btn查找_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        public string RequestCode { get; set; }
        public int RequestIndex { get; set; }
        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btn确定.PerformClick();
        }

        private void OCC_处置申请_Select_Load(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            else
            {
                RequestCode = row["申请编号"].ToString();
                RequestIndex = Convert.ToInt16(row["申请序号"].ToString());
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
