using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat.Avery_Dennison
{
    public partial class rpThongTinGopDonAD : DevExpress.XtraReports.UI.XtraReport
    {
        public rpThongTinGopDonAD()
        {
            InitializeComponent();
        }

        public void databing()
        {
            //xrSCD.DataBindings.Add("Text", DataSource, "SCD");
            xrMaDonHang.DataBindings.Add("Text", DataSource, "MaDonHang");
            //xrSoLuongDonGop.DataBindings.Add("Text", DataSource, "SoLuongDonGop");
            //xrSCD.DataBindings.Add("Text", DataSource, "SCD");
            //xrSCD.DataBindings.Add("Text", DataSource, "SCD");
        }

    }
}
