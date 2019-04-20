using System;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmChiTietDonSanXuat : XtraForm
    {
        private string _scd;
        public frmChiTietDonSanXuat(string scd)
        {
            InitializeComponent();
            _scd = scd;
        }
        private void frmChiTietDonSanXuat_Load(object sender, EventArgs e)
        {
            NhanData();
        }
        public void NhanData()
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == _scd select s).Single();
                sCDTextEdit.Text = lst.SCD;
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
                ptbHinhMatPhai.Image = Image.FromFile(lst.HinhMatPhai);
                ptbHinhMatTrai.Image = Image.FromFile(lst.HinhMatTrai);
                ptbHinhKhuon.Image = Image.FromFile(lst.HinhKhuon);
            }
            catch (Exception)
            {
                // ignored
            }
        }
        }
    }
