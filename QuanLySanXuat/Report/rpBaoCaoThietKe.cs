using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Object;
using System.Data;
using System.Windows.Forms;

namespace QuanLySanXuat
{
    public partial class rpBaoCaoThietKe : DevExpress.XtraReports.UI.XtraReport
    {
        public NhanVienObj NvObj = new NhanVienObj();
        public rpBaoCaoThietKe(NhanVienObj nvobj)
        {
            InitializeComponent();
            NvObj = nvobj;
            xrTenNhanVien.Text = nvobj.Tennhanvien;
            xrMSNV.Text = nvobj.Manhanvien;
        }

        public void databingding()
        {
            xrTenKhachHang.DataBindings.Add("Text", DataSource, "TenKhachHang");
            xrMaSanPham.DataBindings.Add("Text", DataSource, "MaDonHang");
            xrSoDonHang.DataBindings.Add("Text", DataSource, "SCD");
            xrChatLieu.DataBindings.Add("Text", DataSource, "Vatlieu");
            xrBanIn.DataBindings.Add("Text", DataSource, "BanIn");
            xrSanPham.DataBindings.Add("Text", DataSource, "SanPham");
            xrLayout.DataBindings.Add("Text", DataSource, "Layout");
            xrNetChu.DataBindings.Add("Text", DataSource, "NetChu");
            xrNetChu.DataBindings.Add("Text", DataSource, "CoChu");
            xrViTriCatGap.DataBindings.Add("Text", DataSource, "VitriCatGap");
            xrKyHieu.DataBindings.Add("Text", DataSource, "KyHieu");
            xrSize.DataBindings.Add("Text", DataSource, "Size");
            xrSpSize.DataBindings.Add("Text", DataSource, "SpSize");
            xrDanhGia.DataBindings.Add("Text", DataSource, "DanhGia");
            xrGhiChu.DataBindings.Add("Text", DataSource, "Ghichu");
            xrNgayKiem.DataBindings.Add("Text", DataSource, "NgayXuongDon", "{0:dd/MM/yyyy}");
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            databingding();
        }
    }
}
