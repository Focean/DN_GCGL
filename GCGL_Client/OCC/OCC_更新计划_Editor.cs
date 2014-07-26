using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GLG.Common;
using GCGL_Client.Ref_WS_GCGL;
namespace GCGL_Client.OCC
{
    public partial class OCC_更新计划_Editor : Form
    {
        public OCC_更新计划_Editor()
        {
            InitializeComponent();
            this.txt申请单位.Text = AppServer.LoginUnitName;
            this.txt申请单位.Tag = AppServer.LoginUnitCode;
        }

        private string  FDataRow;
        private string  Ucode;
        //提取当前预算单位的公车编制与实有数
        public void GetNum(string code)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //计算单位的剩余编制数（目前先不把冻结数计算在内）
                var mdl = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                mdl.ExAction = "All";
                mdl.单位编码 = code;
                DataSet db = AppServer.wcfClient.CMN_单位_编制_List(ref mdl);
                DataTable table = db.Tables[0];
                if (table.Rows.Count ==0) return;
                else
                {
                    this.txt公务用车实有数.Text = table.Rows[0][0].ToString();
                    this.txt一般执法执勤用车实有数.Text = table.Rows[0][1].ToString();
                    this.txt特种专业技术用车实有数.Text = table.Rows[0][2].ToString();

                    this.txt公务用车编制数.Text = table.Rows[0][3].ToString();
                    this.txt一般执法执勤用车编制数.Text = table.Rows[0][4].ToString();
                    this.txt特种专业技术用车编制数.Text = table.Rows[0][5].ToString();
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

        public void Editor_Add()
        {
            this.Text = "年度更新计划(新增)";
            this.Tag = "Add";
            //           
            this.GetNum(AppServer.LoginUnitCode);
        }

          public void Editor_Mod(DataRow row)
          {
              this.Text = "年度更新计划(修改)";
              this.Tag = "Mod";
              //
              TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
              FDataRow = row["申请编号"].ToString();
              Ucode = row["单位编码"].ToString();
              this.txt申请单位.Text = row["单位名称"].ToString();
              this.txt申请单位.Tag = row["单位编码"].ToString();
              this.GetNum(Ucode);
          }

          public void Editor_View(DataRow row)
          {
              this.Text = "年度更新计划(查看)";
              this.Tag = "查看";
              //
              Ucode = row["单位编码"].ToString();
              TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);             
              this.btn取消.Text = "返回(&X)";
              this.btn提交.Visible = false;
              this.txt申请单位.Text = row["单位名称"].ToString();
              this.GetNum(Ucode);
              //
              this.nud公务用车预报废数.Enabled = false;
              this.nud公务用车预配置数.Enabled = false;
              this.nud特种专业技术用车预报废数.Enabled = false;
              this.nud特种专业技术用车预配置数.Enabled = false;
              this.nud一般执法执勤用车预报废数.Enabled = false;
              this.nud一般执法执勤用车预配置数.Enabled = false;
              this.txt备注.ReadOnly = true;
          }

       


          private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          private void btn提交_Click(object sender, EventArgs e)
          {
              try
              {   
                  var dtm = new Ref_WS_GCGL.DataType_OCC_更新计划();
                  TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, dtm);
                  dtm.单位编码 = AppServer.LoginUnitCode;
                  dtm.创建人编码 = AppServer.LoginUserCode;
                  dtm.创建时间 = DateTime.Now;
                  dtm.计划年度 = Convert.ToInt32(this.txt计划年度.Text.ToString());
                  dtm.ExAction = this.Tag.ToString();
                  if (dtm.ExAction == "Mod" )
                  {
                      dtm.申请编号 = FDataRow;
                  }

                  if (!AppServer.WcfService_Open()) return;
                  AppServer.wcfClient.OCC_更新计划_Edit(ref dtm);
                  if (dtm.ExResult != 0)
                  {
                      AppServer.ShowMsg(dtm.ErrorMsg);

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
              //提交成功了
              this.DialogResult = DialogResult.OK;
          }


          internal void Editor_View()
          {
              throw new NotImplementedException();
          }

          private void SP_年度计划_Editor_Load(object sender, EventArgs e)
          {

          }

          private void txt计划年度_TextChanged(object sender, EventArgs e)
          {
              GetNum(AppServer.LoginUnitCode);
          }
    }
}
