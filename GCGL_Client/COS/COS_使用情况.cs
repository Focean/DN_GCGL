using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GLG.Common;
using TY.Helper;
namespace GCGL_Client.COS
{
    public partial class COS_使用情况 : Form
    {
        public COS_使用情况()
        {
            InitializeComponent();
            if (!AppServer.WcfService_Open()) return;
            var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
            model.ExAction = "License";
            model.单位编码 = AppServer.LoginUnitCode;
            DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
            this.cbx车牌号.DataSource = db.Tables[1];
            this.cbx车牌号.DisplayMember = "车牌号";
            this.cbx车牌号.ValueMember = "车牌号";
           
            DataBinding_GridView(0);
            this.dtp开始时间.Value = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);
            this.dtp结束时间.Value = DateTime.Today;     
        }
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = null;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_COS_使用申请();
                if (this.rb加油记录.Checked == true)
                {
                    model.ExAction = "List_J";
                    str1 = "[加油日期,wh=90,al=mc,fmt=d]"
                     + "[加油行驶里程,tc=加油行驶里程(公里),wh=120,al=mr]"
                     + "[加油量,tc=加油量(L),wh=100,al=mr,fmt=n2]"
                     + "[油价,tc=单价(元/L),wh=100,al=mr,fmt=n2]"
                     + "[加油费用,tc=加油费用(元),wh=100,al=mr,fmt=n2]";
                }
                else if (this.rb保养记录.Checked == true)
                {
                    model.ExAction = "List_B";
                    str2 = "[保养日期,wh=90,al=mc,fmt=d]"
                     + "[预约日期,tc=预约保养日期,wh=90,al=mc,sm=1,fmt=d]"
                     + "[保养行驶里程,tc=保养行驶里程(公里),wh=120,al=mr]"
                     + "[预约里程,tc=预约保养里程(公里),wh=120,al=mr]"
                     + "[保养项目,wh=200,al=ml]"
                     + "[保养费用,tc=保养费用(元),wh=100,al=mr,fmt=n2]"
                     + "[保养经办人,wh=150,al=mc]";
                }
                else if (this.rb维修记录.Checked == true)
                {
                    model.ExAction = "List_W";
                    str3 = "[维修日期,wh=90,al=mc,fmt=d]"
                     + "[维修费用,tc=维修费用(元),wh=100,al=mr,fmt=n2]"
                     + "[维修项目,wh=200,al=mc]"
                     + "[维修经办人,wh=100,al=mc]";
                }
                else if (this.rb出车记录.Checked == true)
                {
                    model.ExAction = "List_C";
                    str4 = "[出车日期,wh=90,al=mc,fmt=d]"
                     + "[还车日期,wh=90,al=mc,fmt=d]"
                     + "[出车行驶里程,tc=出车行驶里程(公里),wh=120,al=mr]"
                     + "[出车事由,wh=200,al=ml]"
                     + "[出车目的地,wh=150,al=ml]"
                     + "[出车人,wh=100,al=mc]"
                     + "[出车批示人,wh=100,al=mc]"
                     + "[出车目的地,wh=200,al=ml]";
                }
                model.单位编码 = AppServer.LoginUnitCode;
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                if (!string.IsNullOrEmpty(this.cbx车牌号.SelectedValue.ToString()))
                {
                    model.车牌号 = this.cbx车牌号.SelectedValue.ToString();
                }
                
                DataSet db = AppServer.wcfClient.COS_使用情况_List(ref model);
                DataTable table = db.Tables[0];
                this.dgvList.DataSource = table;
                string gridstr = "{ro=1,rno=1}"
                  + "[车牌号,wh=100,al=mc,sm=1]"
                  +str1+str2+str3+str4
                  + "[创建人,wh=100,al=mc]";
                //wh是宽度，al是对齐方式,sm是否排序（1真)
                this.dgvList.GridStr(gridstr);
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
            }
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new COS_使用情况_Editor())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DataBinding_GridView(0);
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new COS_使用情况_Editor())
            {
                 if (this.rb加油记录.Checked == true)
                {
                       form.Editor_Mod(row,1);
                 }
                 else if (this.rb保养记录.Checked == true)
                {
                     form.Editor_Mod(row,2);
                }
                else if (this.rb维修记录.Checked == true)
                {
                     form.Editor_Mod(row,3);
                }
                else if (this.rb出车记录.Checked == true)
                {
                     form.Editor_Mod(row,4);
                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
            }
        }
        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;

            if (AppServer.DialogMsg("是否确认删除？", " "))
            {
                var model = new Ref_WS_GCGL.DataType_COS_使用申请();
                model.ExAction = "Del";
                model.ID=Convert.ToInt32(row["ID"].ToString());
                if (!AppServer.WcfService_Open()) return;
                AppServer.wcfClient.COS_使用情况_Edit(ref model);
                if (model.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
                }
                else
                    AppServer.ShowMsg_Error(model.ErrorMsg, "错误");
            }
            else
                return;
        }
        private void rb加油记录_CheckedChanged(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void rb保养记录_CheckedChanged(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void rb维修记录_CheckedChanged(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void rb出车记录_CheckedChanged(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void cbx车牌号_SelectedValueChanged(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lbl使用情况列表.Text);
        }
        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
