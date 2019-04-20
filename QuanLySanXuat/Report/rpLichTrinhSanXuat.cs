using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat
{
    public partial class rpLichTrinhSanXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public rpLichTrinhSanXuat(string bophan)
        {
            InitializeComponent();
            if (bophan != "TEM VẢI")
            {
                xrNgayCap1.Text = DateTime.Now.ToShortDateString();
            }
        }

        public void databingding()
        {
            xrTenKhachHang.DataBindings.Add("Text", DataSource, "TenKhachHang");
            xrTenSanPham.DataBindings.Add("Text", DataSource, "TenSanPham");
            xSoLuongXuat.DataBindings.Add("Text", DataSource, "SoLuong", "{0:#,#}");
            xrSCD.DataBindings.Add("Text", DataSource, "SCD");
            xrMaDonHang.DataBindings.Add("Text", DataSource, "MaDonHang");
            xrNgayXuat.DataBindings.Add("Text", DataSource, "Ngay", "{0:dd/MM/yyyy}");
            xrNguyenLieu.DataBindings.Add("Text", DataSource, "TenHangHoa");
            xrQuyCach.DataBindings.Add("Text", DataSource, "QuyCach");
            xrMuc.DataBindings.Add("Text", DataSource, "MucIn");
            xrMau.DataBindings.Add("Text", DataSource, "Mau");
            xrLotHang1.DataBindings.Add("Text", DataSource, "Lo");
            
        }

    }
}
