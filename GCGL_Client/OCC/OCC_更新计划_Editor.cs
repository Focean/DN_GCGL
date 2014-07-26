using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Common;
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
        //
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
            this.btn保存.Tag = "";
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
              this.btn保存.Tag = row["申请编号"].ToString();
          }

          public void Editor_View(string ACardCode = null, bool AEmebMode = false)
          {
              this.Text = "年度更新计划(查看)";
              this.Tag = "查看";
              
              //
              if (!AppServer.WcfService_Open()) return;
              var model = new Ref_WS_GCGL.DataType_OCC_更新计划();
              model.ExAction = "GetV";
              model.申请编号 = ACardCode;
              DataSet db = AppServer.wcfClient.OCC_更新计划_List(ref model);
              DataTable table = db.Tables[0];
              DataRow row = table.Rows[0];
              TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
              this.btn取消.Text = "返回(&X)";
              this.btn提交.Visible = false;
              this.txt申请单位.Text = row["单位名称"].ToString();
              Ucode = row["单位编码"].ToString();
              this.GetNum(Ucode);
              //
              this.nud公务用车预报废数.Enabled = false;
              this.nud公务用车预配置数.Enabled = false;
              this.nud特种专业技术用车预报废数.Enabled = false;
              this.nud特种专业技术用车预配置数.Enabled = false;
              this.nud一般执法执勤用车预报废数.Enabled = false;
              this.nud一般执法执勤用车预配置数.Enabled = false;
              this.txt备注.ReadOnly = true;

              this.btn保存.Visible = false;
              this.btn提交.Visible = false;

              this.btn取消.Text = "返回";
              //嵌入式状态不显示工具栏
              this.pnlTool.Visible = !AEmebMode;
          }
          private void PostData(Boolean ASubmit)
          {
              base.Cursor = Cursors.WaitCursor;
              try
               {
                  if (!AppServer.WcfService_Open()) return;
                  var dtm = new Ref_WS_GCGL.DataType_OCC_更新计划();
                  TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, dtm);
                  dtm.LoginUserCode = AppServer.LoginUserCode;
                  dtm.申请编号 = this.btn保存.Tag.ToString();
                  dtm.单位编码 = AppServer.LoginUnitCode;
                  dtm.创建人编码 = AppServer.LoginUserCode;
                  dtm.创建时间 = DateTime.Now;
                  dtm.计划年度 = Convert.ToInt32(this.nud计划年度.Value.ToString());
                  dtm.ExAction = this.Tag.ToString();
                  AppServer.ShowWaitForm();
                  AppServer.DataImport("正在保存数据，请稍等...", 20, 100, true);
                  AppServer.wcfClient.OCC_更新计划_Edit(ref dtm);
                  //
                  if (dtm.ExResult != 0)
                  {
                      AppServer.HideWaitForm();
                      AppServer.ShowMsg_SubmitError(dtm.ErrorMsg);
                      return;
                  }
                  //此时记住已保存成功了，如果是新增状态可变为修改状态了，防止提交不成功后重复新增数据
                  if (this.Tag.ToString() == "Add")
                  {
                      this.Tag = "Mod";
                      this.btn保存.Tag = dtm.申请编号;
                  }
                  //
                  if (ASubmit)
                  {
                      dtm.ExAction = "Submit";
                      dtm.申请编号 = this.btn保存.Tag.ToString();
                      AppServer.wcfClient.OCC_更新计划_Edit(ref dtm);
                      if (dtm.ExResult != 0)
                      {
                          AppServer.HideWaitForm();
                          AppServer.ShowMsg_SubmitError(dtm.ErrorMsg);
                          return;
                      }
                  }
                  AppServer.DataImport("数据保存已成功完成！", 100, 100, false);
                  AppServer.HideWaitForm();
                  //提交成功了
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
        


          internal void Editor_View()
          {
              throw new NotImplementedException();
          }

          private void txt计划年度_TextChanged(object sender, EventArgs e)
          {
              GetNum(AppServer.LoginUnitCode);
          }

          private void txt公务用车实有数_MouseDoubleClick(object sender, MouseEventArgs e)
          {
              using (var form = new OCC_公车库存_List())
              {
                  if(txt申请单位.Tag!=null)
                  form.Property_List(txt申请单位.Tag.ToString(),"01");
                  if (form.ShowDialog() == DialogResult.OK)
                  {

                  }
              }
          }

          private void txt一般执法执勤用车实有数_MouseDoubleClick(object sender, MouseEventArgs e)
          {
              using (var form = new OCC_公车库存_List())
              {
                  if (txt申请单位.Tag != null)
                      form.Property_List(txt申请单位.Tag.ToString(), "0301");
                  if (form.ShowDialog() == DialogResult.OK)
                  {

                  }
              }
          }

          private void txt特种专业技术用车实有数_MouseDoubleClick(object sender, MouseEventArgs e)
          {
              using (var form = new OCC_公车库存_List())
              {
                  if (txt申请单位.Tag != null)
                      form.Property_List(txt申请单位.Tag.ToString(), "0302");
                  if (form.ShowDialog() == DialogResult.OK)
                  {

                  }
              }
          }

          private void OCC_更新计划_Editor_KeyDown(object sender, KeyEventArgs e)
          {
              if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //
              {
                  this.btn提交_Click(this, EventArgs.Empty);
              }
          }
          private void btn提交_Click(object sender, EventArgs e)
          {
              this.PostData(true);
          }
          private void btn保存_Click(object sender, EventArgs e)
          {
              this.PostData(false);
          }
    }
}
