using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
            
        }

        public void databingding()
        {
            xrSO.DataBindings.Add("Text", DataSource, "SO");
            xrSize.DataBindings.Add("Text", DataSource, "Size");
            xrSoLuong.DataBindings.Add("Text", DataSource, "QTY");
        }

    }
}
