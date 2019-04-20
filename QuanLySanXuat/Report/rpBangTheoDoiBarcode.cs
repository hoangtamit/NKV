using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat
{
    public partial class rpBangTheoDoiBarcode : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBangTheoDoiBarcode()
        {
            InitializeComponent();
            xrNgay.Text = DateTime.Now.ToShortDateString();

        }

        public void databingding()
        {
            xrSCD.DataBindings.Add("Text", DataSource, "SCD");
            xrBarcoder.DataBindings.Add("Text", DataSource, "Barcode");
            //xrNgayNhap.DataBindings.Add("Text", DataSource, "NgayNhap", "{0:dd/MM/yyyy}");
            xrSoLuongCanIn.DataBindings.Add("Text", DataSource, "SoLuongCanIn");
            xrSoLuongSKU.DataBindings.Add("Text", DataSource, "SoLuongSKU");
            xrSoLuongSheet_Goi.DataBindings.Add("Text", DataSource, "SoLuongSheet_Goi");
            xrSoLuongPcs_Sheet.DataBindings.Add("Text", DataSource, "SoLuongPcs_Sheet");
            xrNhanVien.DataBindings.Add("Text", DataSource, "NhanVien");
            xrCount.DataBindings.Add("Text", DataSource, "TongSoLuong");
        }

    }
}
