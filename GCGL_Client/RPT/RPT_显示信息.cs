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
    public partial class RPT_显示信息 : Form
    {
        public string FShowstr;
        public RPT_显示信息()
        {
            InitializeComponent();
            
        }
        
        private void btn确定_Click(object sender, EventArgs e)
        {
            FShowstr = string.Empty;
           for (int i = 1; i < 21; i++)
           {
               if (((CheckBox)this.Controls.Find("checkBox" + i, true)[0]).Checked)
               {
                   FShowstr += ((CheckBox)this.Controls.Find("checkBox" + i, true)[0]).Text + ",";
               }
           }
           if (FShowstr == string.Empty)
           {
               for (int i = 1; i < 21; i++)
               {
                   FShowstr += ((CheckBox)this.Controls.Find("checkBox" + i, true)[0]).Text + ",";
               }
           }
           this.DialogResult = DialogResult.OK;
        }
    }
}
