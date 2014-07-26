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
    public partial class RPT_查询方案_重命名 : Form
    {
        public RPT_查询方案_重命名()
        {
            InitializeComponent();
        }
        public string FAname=string.Empty;
        private void btn确定_Click(object sender, EventArgs e)
        {
            FAname = this.txt方案名称.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void RPT_查询方案_重命名_Load(object sender, EventArgs e)
        {
            this.txt方案名称.Text = FAname;
            this.btn确定.Focus();
        }
    }
}
