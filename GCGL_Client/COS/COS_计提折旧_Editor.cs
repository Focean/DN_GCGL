using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.OCC;
namespace GCGL_Client.COS
{
    public partial class COS_计提折旧_Editor : Form
    {
        public COS_计提折旧_Editor()
        {
            InitializeComponent();
        }

        private void COS_计提折旧_Editor_Load(object sender, EventArgs e)
        {

        }
        public void GetCode()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var dtm = new Ref_WS_GCGL.DataType_COS_计提折旧();
                dtm.ExAction = "GetCode";
                AppServer.wcfClient.COS_计提折旧_List(ref dtm);
                this.txt编号.Text = dtm.编号;
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

      //  private DataRow FUnitCode;
        private string ZCBH;
        private string[] ZCstr = new string[10];
        //增加状态
        public void Editor_Add()
        {
            this.Text = "新建车辆计提折旧";
            this.Tag = "Add";
            GetCode();
        }
        string DCode;
        //修改状态
        public void Editor_Mod(DataRow row)
        {
            this.Text = "修改车辆计提折旧";
            this.Tag = "Mod";
            //
            DCode = row["编码"].ToString();
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
        }
        private void btn资产编号_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_公车库存_Select())
            {
                form.Select_查询单位资产(ZCstr);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ZCBH = form.SelectPropertyName;
                   // this.txt资产编号.Text = form.SelectPropertyName;
                    this.txt资产编号.Tag = form.SelectPropertyCode;
                    try
                    {
                        if (!AppServer.WcfService_Open()) return;
                        var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                        model.资产编号 = form.SelectPropertyCode.ToString();
                        DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                        DataTable table = db.Tables[0];
                        this.txt资产编号.Text = table.Rows[0]["车牌号"].ToString();
                        this.nud价值.Value=Convert.ToDecimal(table.Rows[0]["价值"].ToString());                     
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
        }


        private void btn提交_Click(object sender, EventArgs e)
        {

        }
    }
}
