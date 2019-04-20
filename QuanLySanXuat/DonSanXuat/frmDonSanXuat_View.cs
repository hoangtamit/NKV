using System;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmDonSanXuat_View : XtraForm
    {
        private NhanVienObj nvObj = new NhanVienObj();
        private readonly string _scd;
        private readonly string _masanpham;

        public frmDonSanXuat_View(string scd,string masanpham,NhanVienObj obj)
        {
            InitializeComponent();
            _scd = scd;
            _masanpham = masanpham;
            nvObj = obj;
        }

        public frmDonSanXuat_View()
        {
            InitializeComponent();
        }
        private void frmDonSanXuat_View_Load(object sender, EventArgs e)
        {
            NhanData();
        }

        public void NhanData()
        {
            if (_scd == "0")
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == _masanpham select s).Single();
                tenKhachHangTextEdit.Text = lst.TenKhachHang;
                tenSanPhamTextEdit.Text = lst.TenSanPham;
                loaiSanPhamTextEdit.Text = lst.LoaiSanPham;
                giaCongMatPhaiTextEdit.Text = lst.GiaCongMatPhai;
                giaCongMatTraiTextEdit.Text = lst.GiaCongMatTrai;
                mauMatPhaiTextEdit.Text = lst.MauMatPhai;
                mauMatTraiTextEdit.Text = lst.MauMatTrai;
                boGocTextEdit.Text = lst.BoGoc;
                phuongPhapCatTextEdit.Text = lst.PhuongPhapCat;
                phuongPhapInTextEdit.Text = lst.PhuongPhapIn;
                kichThuocTextEdit.Text = lst.KichThuoc;
            }
            else
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == _scd select s).Single();
                sCDTextEdit.Text = _scd;
                maDonHangTextEdit.Text = lst.MaDonHang;
                phienBanTextEdit.Text = lst.PhienBan;
                tenKhachHangTextEdit.Text = lst.TenKhachHang;
                tenSanPhamTextEdit.Text = lst.TenSanPham;
                if (lst.NgayGiaoHang != null) ngayGiaoHangDateEdit.DateTime = (DateTime) lst.NgayGiaoHang;
                if (lst.NgayXuongDon != null) ngayXuongDonDateEdit.DateTime = (DateTime) lst.NgayXuongDon;
                loaiSanPhamTextEdit.Text = lst.LoaiSanPham;
                vatLieuComboBox.Text = lst.VatLieu;
                chuYTextEdit.Text = lst.ChuY;
                giaCongMatPhaiTextEdit.Text = lst.GiaCongMatPhai;
                giaCongMatTraiTextEdit.Text = lst.GiaCongMatTrai;
                mauMatPhaiTextEdit.Text = lst.MauMatPhai;
                mauMatTraiTextEdit.Text = lst.MauMatTrai;
                boGocTextEdit.Text = lst.BoGoc;
                ducLoTextEdit.Text = lst.DucLo;
                loaiChiTextEdit.Text = lst.LoaiChi;
                phuongPhapCatTextEdit.Text = lst.PhuongPhapCat;
                phuongPhapInTextEdit.Text = lst.PhuongPhapIn;
                soLuongSpinEdit.Text = lst.SoLuong.ToString();
                txtbophan.Text = lst.BoPhan;
                chamCatDapHopTextEdit.Text = lst.ChamCatDapHop; 
                khacTextEdit.Text = lst.Khac;
                doDaiTextEdit.Text = lst.DoDai;
                giaCongSauTextEdit.Text = lst.GiaCongSau;
                khoTextEdit.Text = lst.Kho;
                kichThuocTextEdit.Text = lst.KichThuoc;
                inChu_MaVachTextEdit.Text = lst.InChu_MaVach;
                lblnhanvien.Text = lst.NhanVienNghiepVu;
                lblThoiGianXuongDon.Text = lst.ThoiGianXuongDon.ToString();
                ptbHinhMatPhai.Image = Image.FromFile(lst.HinhMatPhai);
                ptbHinhMatTrai.Image = Image.FromFile(lst.HinhMatTrai);
                ptbHinhKhuon.Image = Image.FromFile(lst.HinhKhuon);
                var tien = (from s in db.tbQuanLyTienTes where s.IDTienTe == _scd select s).Single();
                donGiaKhuonSpinEdit.Text = tien.DonGiaKhuon.ToString();
                donGiaMauSpinEdit.Text = tien.DonGiaMau.ToString();
                donGiaSanPhamSpinEdit.Text = tien.DonGiaSanPham.ToString();
                donGiaVanChuyenSpinEdit.Text = tien.DonGiaVanChuyen.ToString();
                tongTienSpinEdit.Text = tien.TongTien.ToString();
                ngoaiTeComboBox.Text = tien.NgoaiTe;
                CheckVAT.Text = tien.VAT.ToString();
            }
        }
        private void sCDTextEdit_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            }

        private void maDonHangTextEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

    }
}