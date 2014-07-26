﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.FZB
{
    public partial class FZB_采购形式_Editor : Form
    {
        public FZB_采购形式_Editor()
        {
            InitializeComponent();
        }

        private string FDataRow = null;
        public void Editor_Add()
        {
            this.Text = "采购形式设置(新增)";
            this.Tag = "Add";
            //   
        }

        public void Editor_Mod(DataRow row)
        {
            this.Text = "采购形式设置(修改)";
            this.Tag = "Mod";
            //
            FDataRow = row["采购形式编码"].ToString();
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            this.txt采购形式编码.ReadOnly = true;
        }

        public void Editor_View(DataRow row)
        {
            this.Text = "采购形式设置(查看)";
            this.Tag = "View";
            //
            FDataRow = row["采购形式编码"].ToString();
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            this.btn提交.Enabled = false;
            this.btn取消.Text = "返回(&X)";
        }
        private void btn提交_Click(object sender, EventArgs e)
        {
            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_FZB_编码();

                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                AppServer.wcfClient.FZB_采购形式_Edit(ref model);
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
            //
            this.DialogResult = DialogResult.OK;
        }
    }
}
