﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GLG.Common;
using TY.Helper;
using DingnuoControlLibrary;
namespace GCGL_Client.FZB
{
    public partial class FZB_车辆类型 : Form
    {
        public FZB_车辆类型()
        {
            InitializeComponent();
            
        }


        private void dbGridView_DataBinding()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                dtvTreeView.CheckBoxs = false;
                dtvTreeView.MultiSelect = false;
                var model = new Ref_WS_GCGL.DataType_FZB_编码();
                dtvTreeView.DataSource = AppServer.wcfClient.FZB_编码_List("车辆类型1").Tables[0];
                dtvTreeView.BuildTrees();
                dtvTreeView.ExpandAll();
                //选中首节点
                if (dtvTreeView.Nodes.Count > 0)
                {
                    dtvTreeView.Nodes[0].Expand();
                    dtvTreeView.SelectedNode = (DBTreeNode)dtvTreeView.Nodes[0];
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

        private void BZ_资产分类_Load(object sender, EventArgs e)
        {
            dbGridView_DataBinding();
        }

        private void Btn增加_Click(object sender, EventArgs e)
        {
            string APCode;
            if (dtvTreeView.SelectedNode == null)
            {
                if (dtvTreeView.Nodes.Count > 0)
                {
                    AppServer.ShowMsg_Error("请选择一个树结点再创建型号！");
                    return;
                }
                APCode = "";
            }
            else
            {
                APCode = dtvTreeView.SelectedNode.ID;
            }
            using (var form = new FZB_车辆类型_Editor())
            {
                form.Editor_Add(APCode);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    dbGridView_DataBinding();

                }
            }
        }

        private void Btn刷新_Click(object sender, EventArgs e)
        {
            dbGridView_DataBinding();
        }

        private void Btn删除_Click(object sender, EventArgs e)
        {
            if (dtvTreeView.SelectedNode == null) return;
            if (dtvTreeView.SelectedNode.Nodes.Count > 0)
            {
                AppServer.ShowMsg_Warn("当前车辆类型存在下级，请先删除下级！");
                return;
            }
            //
            if (!AppServer.DialogMsg("注意：当您执行删除操作时，会同时把它的下级编码同时删除，确认要删除当前车辆类型吗？", "删除确认")) return;

            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_FZB_编码();
                model.ExAction = "Del";
                model.车辆类型编码 = dtvTreeView.SelectedNode.ID;
                AppServer.wcfClient.FZB_车辆类型_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //提交成功了
                dbGridView_DataBinding();
            }
            catch (Exception ex)
            {
                AppServer.HideWaitForm();
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }

        }

        private void Btn修改_Click(object sender, EventArgs e)
        {
            if (dtvTreeView.SelectedNode == null) return;
            DataRow Dr = (dtvTreeView.DataSource as DataTable).NewRow();
            foreach (DataRow r in (dtvTreeView.DataSource as DataTable).Rows)
            {
                if (r["编码"].ToString() == dtvTreeView.SelectedNode.ID)
                {
                    Dr = r;
                    break;
                }
            }
            using (var form = new FZB_车辆类型_Editor())
            {
                form.Editor_Mod(Dr);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    dbGridView_DataBinding();
                }
            }
        }

        private void Btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
