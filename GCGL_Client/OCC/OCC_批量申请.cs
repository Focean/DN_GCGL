using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace GCGL_Client.OCC
{
    public partial class OCC_批量申请 : Form
    {
        public OCC_批量申请()
        {
            InitializeComponent();
            //
            this.dtp开始时间.Value = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);
            this.dtp结束时间.Value = DateTime.Today;
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            //
        }

        private void OCC_批量配置申请_Load(object sender, EventArgs e)
        {
            if (AppServer.LoginUnitIsYSDW())
            {
                this.btn申请.Visible = false;
                this.btn提交.Visible = false;
                this.btn分发.Visible = false;
                this.btn修改.Visible = false;
                this.btn删除.Visible = false;
                string str = "{ro=1,rno=1}"
                    + "[配置编号,wh=100,al=mc,vi=0]"
                    + "[序号,wh=90,al=mc,vi=0]"
                    + "[单位编码,wh=100,al=mc,vi=0]"
                    + "[车辆类型名称,tc=车辆类型,wh=120,al=mc,sm=1]"
                    + "[车辆类型编码,wh=100,al=mc,vi=0]"
                    + "[单位名称,tc=单位名称,wh=160,al=mc,sm1]"                 
                    + "[资产类别名称,tc=资产类别,wh=140,al=mc,sm=1]"
                    + "[资产类别编码,wh=100,al= mc,vi=0]"
                    + "[接收原因,wh=200,al= ml]"
                    + "[分配数量,wh=80,al=mc]"
                    + "[接收数量,wh=80,al=mc]"
                    + "[价格,tc=价值(万元),wh=100,al=mr,fmt=n4]"
                    + "[排气量,wh=80,al=mc,sm=1]"
                    + "[型号,wh=100,al=mc]"
                    + "[接收状态,wh=80,al=mc]";
                //wh是宽度，al是对齐方式,sm是否排序（1真),vi是是否显示     
                this.dgvList.GridStr(str);
            }
            if (AppServer.LoginUnitIsZGDW())
            {
                this.btn接收.Visible = false;
                string str = "{ro=1,rno=1}"
                    + "[配置编号,wh=100,al=mc,vi=0]"
                    + "[车辆类型名称,tc=车辆类型,wh=120,al=mc,sm=1]"
                    + "[资产类别名称,tc=资产类别,wh=140,al=mc,sm=1]"
                    + "[资产类别编码,wh=100,al= mc,vi=0]"
                    + "[配置总数,wh=100,al=mc]"
                    + "[配置总金额,tc=价值(万元),wh=100,al=mr,fmt=n4]"
                    + "[配置原因,wh=200,al= ml]"
                    + "[创建时间,tc=申请日期,wh=100,al=mc,fmt=d]"
                    + "[分发状态,wh=100,al=mc]"
                    + "[接收状态,wh=100,al=mc]"
                    + "[提交状态,wh=100,al=mc]"
                    + "[备注,wh=200,al=ml]"
                    + "[分发次数,wh=100,al= mc,vi=0]";
                //wh是宽度，al是对齐方式,sm是否排序（1真),vi是是否显示     
                this.dgvList.GridStr(str);
            }
            this.DataBinding_GridView(0);
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_批量申请();
                model.ExAction = "List";
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                model.单位编码 = AppServer.LoginUnitCode;
                DataSet db = AppServer.wcfClient.OCC_批量申请_List(ref model);
                DataTable table = db.Tables[0];
                this.dgvList.DataSource = table;
                this.dgvList.GoToRowByIndex(ACurrRowIndex);
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

        #region 功能按钮
        private void btn申请_Click(object sender, EventArgs e)
        {
            using(var From = new OCC_批量申请_Editor())
            {
                From.Editor_Add();
                if (From.ShowDialog() == DialogResult.OK)
                {
                    //更新数据     
                    this.DataBinding_GridView(this.dgvList.Rows.Count);
                }
            }
        }
        //
        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["分发状态"].ToString() == "等待分发" || row["提交状态"].ToString() != "等待提交")
            {
                using (var form = new OCC_批量申请_Editor())
                {
                    form.Editor_Mod(row["配置编号"].ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //更新数据
                        this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                    }
                }
            }
            else
            {
                AppServer.ShowMsg_Warn("该申请已经分发或提交，无法修改！", "警告");
                return;
            }
        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            if (AppServer.LoginUnitIsZGDW())
            {
                using (var From = new OCC_批量申请_Editor())
                {
                    From.Editor_See(row["配置编号"].ToString());
                    if (From.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
            else if (AppServer.LoginUnitIsYSDW())
            {
                using (var From = new OCC_批量申请_接收())
                {
                    From.Editor_See(row);
                    if(From.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["提交状态"].ToString()=="已提交")
            {
                AppServer.ShowMsg_Warn("该申请已经提交，无法删除！", "警告");
                return;
            }
            if (row["分发状态"].ToString() == "已分发")
            {
                AppServer.ShowMsg_Warn("该申请已经分发，无法删除！", "警告");
                return;   
            }
            if (AppServer.DialogMsg("是否确认删除？", " "))
            {
                var model = new Ref_WS_GCGL.DataType_OCC_批量申请();
                model.ExAction = "Del";
                model.配置编号 = row["配置编号"].ToString();
                if (!AppServer.WcfService_Open()) return;
                AppServer.wcfClient.OCC_批量申请_Edit(ref model);
                if (model.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
                }
                else
                    AppServer.ShowMsg_Error(model.ErrorMsg, "错误");
            }
            else return;
        }

        private void btn分发_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;         
            //二次分发时，使用的界面
            if (row["分发状态"].ToString() == "已分发" && row["分发次数"].ToString() == "1" && row["接收状态"].ToString() == "接收完毕")
            {
                if (AppServer.DialogMsg("是否确认进行二次分发？", "提示"))
                {
                    using (var From = new OCC_批量申请_Editor())
                    {
                        From.Editor_Distribute(row);
                        if (From.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据     
                            this.DataBinding_GridView(this.dgvList.Rows.Count);
                        }
                    }
                }
                return;
            }
            if (AppServer.DialogMsg("是否确认分发？", " "))
            {
                var dtm = new Ref_WS_GCGL.DataType_OCC_批量申请();
                dtm.ExAction = "Distribute";
                dtm.配置编号 = row["配置编号"].ToString();
                if (!AppServer.WcfService_Open()) return;
                AppServer.wcfClient.OCC_批量申请_Edit(ref dtm);
                if (dtm.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
                else
                    AppServer.ShowMsg_Error(dtm.ErrorMsg, "错误");
            }
            else return;
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //if (row["提交状态"].ToString() != "等待提交")
            //{
            //    AppServer.ShowMsg_Warn("该申请已经提交，无法提交操作！", "警告");
            //    return;
            //}
            if (AppServer.DialogMsg("是否确认提交？", " "))
            {
                var dtm = new Ref_WS_GCGL.DataType_OCC_批量申请();
                dtm.ExAction = "Submit";
                dtm.配置编号 = row["配置编号"].ToString();
                if (!AppServer.WcfService_Open()) return;
                AppServer.wcfClient.OCC_批量申请_Edit(ref dtm);
                if (dtm.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
                else
                    AppServer.ShowMsg(dtm.ErrorMsg, "提示");
            }
            else return;
        }

        private void btn接收_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["接收状态"].ToString() != "未接收")
            {
                AppServer.ShowMsg_Warn("该申请已经接收，无法接收操作！", "警告");
                return;
            }
            using (var From = new OCC_批量申请_接收())
            {
                From.Editor_Add(row);
                if ( From.ShowDialog() == DialogResult.OK )
                {
                    DataBinding_GridView(0);
                }
            }
        }
        #endregion

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["提交状态"].ToString() == "等待提交" && row["分发状态"].ToString() == "等待分发")
            {
                this.btn修改.PerformClick();
            }
            else
            {
                this.btn查看.PerformClick();
            }
        }
    }
}
