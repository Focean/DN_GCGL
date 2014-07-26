using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.COS
{
    public partial class COS_使用情况_Editor : Form
    {
        public COS_使用情况_Editor()
        {
            InitializeComponent();
            if (!AppServer.WcfService_Open()) return;
            var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
            model.单位编码 = AppServer.LoginUnitCode;
            DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
            this.cbx车牌号.DataSource = db.Tables[0];
            this.cbx车牌号.DisplayMember = "车牌号";
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 12, this.btn提交, true);

        }
        private bool PostData()
        {
            //
            this.DialogResult = DialogResult.None;
            try
            {
                string strCollected = string.Empty;
                for (int i = 0; i < this.clb保养项目.Items.Count; i++)
                {
                    if (this.clb保养项目.GetItemChecked(i))
                    {
                        if (strCollected == string.Empty)
                        {
                            strCollected = this.clb保养项目.GetItemText(
                             this.clb保养项目.Items[i]);
                        }
                        else
                        {
                            strCollected = strCollected + "/" + this.clb保养项目.
                             GetItemText(this.clb保养项目.Items[i]);
                        }
                    }
                }
                if (!AppServer.WcfService_Open()) return false;
                var dtm = new Ref_WS_GCGL.DataType_COS_使用申请();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, dtm);
                dtm.ExAction = this.Tag.ToString();
                dtm.车牌号 = this.cbx车牌号.Text;
                dtm.ID = ID;
                dtm.创建人编码 = AppServer.LoginUserCode;
                dtm.单位编码 = AppServer.LoginUnitCode;
                dtm.保养项目 = strCollected;
                dtm.保养记录 = this.rb保养记录.Checked;
                dtm.出车记录 = this.rb出车记录.Checked;
                dtm.加油记录 = this.rb加油记录.Checked;
                dtm.维修记录 = this.rb维修记录.Checked;
                AppServer.wcfClient.COS_使用情况_Edit(ref dtm);
                //
                if (dtm.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(dtm.ErrorMsg);
                   
                    return false;
                }
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return false;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
            //
            return true;
        }
        //增加状态
        public void Editor_Add()
        {
            this.Text = "新建车辆使用情况";
            this.Tag = "Add";
        }
        int ID; string[] arrID = null;

        //修改状态
        public void Editor_Mod(DataRow row,int a)
        {
            this.Text = "修改车辆使用情况";
            this.Tag = "Mod";
            //
            
            ID =Convert.ToInt32(row["ID"].ToString());
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            if (a==1)
            {
                this.rb加油记录.Checked = true;
            }
           else if (a==2)
            {
                this.rb保养记录.Checked = true;
                arrID = row["保养项目"].ToString().Split(new char[] { '/' });
                for (int j = 0; j < this.clb保养项目.Items.Count; j++)
                {
                    for (int i = 0; i < arrID.Length; i++)
                    {

                        if (this.clb保养项目.GetItemText(this.clb保养项目.Items[j]) == arrID[i])
                        {
                            this.clb保养项目.SetItemChecked(j, true);
                        }
                    }
                }
            }
            else if (a==3)
            {
                this.rb维修记录.Checked = true;
            }
            else if (a==4)
            {
                this.rb出车记录.Checked = true;
            }
           
        }
        private void btn提交_Click(object sender, EventArgs e)
        {
            if (!this.PostData()) return;
            //提交成功了
            this.DialogResult = DialogResult.OK;
        }
        private void nud加油量_ValueChanged(object sender, EventArgs e)
        {
            this.txt加油费用.Text = Convert.ToString(this.nud加油量.Value*this.nud油价.Value);
        }

        private void nud油价_ValueChanged(object sender, EventArgs e)
        {
            this.txt加油费用.Text = Convert.ToString(this.nud加油量.Value * this.nud油价.Value);
        }

        private void rb加油记录_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb加油记录.Checked == true) this.pnl加油.Enabled = true;
            else this.pnl加油.Enabled = false;
        }

        private void rb保养记录_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb保养记录.Checked == true) this.pnl保养记录.Enabled = true;
            else this.pnl保养记录.Enabled = false;
        }
        private void rb维修记录_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb维修记录.Checked == true) this.pnl维修记录.Enabled = true;
            else this.pnl维修记录.Enabled = false;
        }
        private void rb出车记录_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb出车记录.Checked == true) this.pnl出车记录.Enabled = true;
            else this.pnl出车记录.Enabled = false;
        }
    }
}
