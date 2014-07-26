using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GCGL_Client
{
    class Cmn_DataFill
    {
        public static void FillDropDownList(DataTable DT , string TableField,ComboBox CBX)
        {
            CBX.Items.Clear();
            foreach (DataRow dr in DT.Rows)
            { 
               StringBuilder sb = new StringBuilder(dr[TableField].ToString());
               CBX.Items.Add(sb); 
            }
        }
    }
}
