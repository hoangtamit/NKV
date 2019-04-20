using System;
using System.Linq;

namespace QuanLySanXuat.Object
{
    class KhoBTP_TPObj
    {
        public string IDKhoBTP_TP { get; set; }
        public string MaPhieu { get; set; }
        public string Lo { get; set; }
        public string NhapXuat { get; set; }
        public string SCD { get; set; }
        public string Kho { get; set; }
        public DateTime Ngay { get; set; }
        public string LoaiSanPham { get; set; }
        public string MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuongNhapKhachHang { get; set; }
        public int SoLuongXuatKhachHang { get; set; }
        public int SoLuongNhapCongTy { get; set; }
        public int SoLuongXuatCongTy { get; set; }
        public string DonViTinh { get; set; }
        public string KichThuoc { get; set; }
        public string KhoGiayIn { get; set; }
        public string BoPhan { get; set; }
        public string GhiChu { get; set; }
        public string NhanVien { get; set; }
        public int XacNhan { get; set; }

        public KhoBTP_TPObj(string _IDKhoBTP_TP, string _MaPhieu, string _Lo, string _NhapXuat, string _SCD, string _Kho, DateTime _Ngay, string _LoaiSanPham, string _MaDonHang, string _TenKhachHang, string _TenSanPham, int _SoLuongNhapKhachHang, int _SoLuongXuatKhachHang, int _SoLuongNhapCongTy, int _SoLuongXuatCongTy, string _DonViTinh, string _KichThuoc, string _KhoGiayIn, string _BoPhan, string _GhiChu, string _NhanVien, int _XacNhan)
        {
            IDKhoBTP_TP = _IDKhoBTP_TP;
            MaPhieu = _MaPhieu;
            Lo = _Lo;
            NhapXuat = _NhapXuat;
            SCD = _SCD;
            Kho = _Kho;
            Ngay = _Ngay;
            LoaiSanPham = _LoaiSanPham;
            MaDonHang = _MaDonHang;
            TenKhachHang = _TenKhachHang;
            TenSanPham = _TenSanPham;
            SoLuongNhapKhachHang = _SoLuongNhapKhachHang;
            SoLuongXuatKhachHang = _SoLuongXuatKhachHang;
            SoLuongNhapCongTy = _SoLuongNhapCongTy;
            SoLuongXuatCongTy = _SoLuongXuatCongTy;
            DonViTinh = _DonViTinh;
            KichThuoc = _KichThuoc;
            KhoGiayIn = _KhoGiayIn;
            BoPhan = _BoPhan;
            GhiChu = _GhiChu;
            NhanVien = _NhanVien;
            XacNhan = _XacNhan;
        }
        public KhoBTP_TPObj()
        {

        }
    }
}
