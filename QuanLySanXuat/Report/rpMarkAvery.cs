using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat
{
    public partial class rpMarkAvery : XtraReport
    {
        public rpMarkAvery()
        {
            InitializeComponent();
        }

        private void tableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //var a = tbSO.Text;
            //var b = tbQty.Text.Replace(",","").Trim();
            //tbReMark.Text = "*" + a + "/" + b + "*";
            //MessageBox.Show(tbReMark.Text);
        }
    }
}
