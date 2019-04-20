using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Object;

namespace QuanLySanXuat
{
    public partial class rptBaoCaoNghiepVu : DevExpress.XtraReports.UI.XtraReport
    {
        public readonly NhanVienObj NvObj = new NhanVienObj();
        public rptBaoCaoNghiepVu(NhanVienObj obj)
        {
            InitializeComponent();
            NvObj = obj;
            xrTenNhanVien.Text = NvObj.Tennhanvien;
            xrMSNV.Text = NvObj.Manhanvien;
        }

        public void databingding()
        {
            xrTenKhachHang.DataBindings.Add("Text", DataSource, "TenKhachHang");
            xrMaSanPham.DataBindings.Add("Text", DataSource, "MaDonHang");
            xrSoDonHang.DataBindings.Add("Text", DataSource, "SCD");
            xrNgayXuongDon.DataBindings.Add("Text", DataSource, "NgayXuongDon", "{0:dd/MM/yyyy}");
            xrNgayGiaoHang.DataBindings.Add("Text", DataSource, "NgayGiaoHang", "{0:dd/MM/yyyy}");
            xrVatLieu.DataBindings.Add("Text", DataSource, "VatLieu");
            xrNoiDung.DataBindings.Add("Text", DataSource, "PhuongPhapIn");
            xrQuyCach.DataBindings.Add("Text", DataSource, "KichThuoc");
            xrTong.DataBindings.Add("Text", DataSource, "SoLuong");
            xrSize.DataBindings.Add("Text", DataSource, "Size");
            xrSpSize.DataBindings.Add("Text", DataSource, "SpSize");
            xrDanhGia.DataBindings.Add("Text", DataSource, "DanhGia");
            xrGhiChu.DataBindings.Add("Text", DataSource, "Ghichu");
            xrNgayKiem.DataBindings.Add("Text", DataSource, "NgayXuongDon", "{0:dd/MM/yyyy}");
        }

    }
}
