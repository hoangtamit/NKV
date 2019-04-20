using System.Windows.Forms;
using QuanLySanXuat.Object;
using DevExpress.XtraGrid.Localization;
using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Linq;
using QuanLySanXuat.DonSanXuat;
using QuanLySanXuat.Kho;
using QuanLySanXuat.QuanLyDonHang;
using QuanLySanXuat.Test;
using static QuanLySanXuat.PrintRibbon;

namespace QuanLySanXuat
{


    internal partial class frmCha : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private readonly NhanVienObj nvObj = new NhanVienObj();
        private string phanquyen;
        public string _nghiepvu, _thietke, _ctp, _ctf, _offset, _temvai, _sauin, _kiempham, _khonvl, _khobtp, _quanlychatluong, _quanlysanxuat, _danhthiep, _kythuatso, _sticker, _inchuvitinh;

        public void frmCha_Load(object sender, EventArgs e)
        {
            ribbon.Minimized = true;
            GridLocalizer.Active = new MyGridLocalizer();
            Phanquyen();
            GiaoDien();
            ThongBao();
        }
        public void GiaoDien()
        {
            try
            {
                if (!string.IsNullOrEmpty(nvObj.Ghichu))
                {
                    defaultLookAndFeel1.EnableBonusSkins = true;
                    defaultLookAndFeel1.LookAndFeel.SkinName = nvObj.Giaodien;// "Caramel";
                }
            }
            catch
            {
                // ignored
            }
        }

        public frmCha()
        {
            InitializeComponent();
        }

        public frmCha(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
            bsiNhanVien.Caption = nvObj.Tennhanvien;
            bsiBoPhan.Caption = nvObj.Bophan;
        }

        public void ThongBao()
        {
            if (string.IsNullOrEmpty(nvObj.Thongbao) && !string.IsNullOrEmpty(nvObj.Manhanvien))
            {
                var frm = new frmThongBao();
                frm.ShowDialog();
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbNhanViens where s.MaNhanVien == nvObj.Manhanvien select s).Single();
                lst.ThongBao = "1";
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// The phanquyen.
        /// </summary>
        protected virtual void Phanquyen()
        {
            phanquyen = "fullcontrol";


            if (nvObj.Taikhoan == "hoangtamit")
            {
                bbiTaoTaiKhoan.Visibility = BarItemVisibility.Always;
                bbiPhanQuyen.Visibility = BarItemVisibility.Always;
            }
            if (nvObj.Manhanvien == null) return;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbPhanQuyens where s.MaNhanVien == nvObj.Manhanvien select s).Single();
            _nghiepvu = lst.NghiepVu;
            _thietke = lst.ThietKe;
            _ctp = lst.CTP;
            _ctf = lst.CTF;
            _offset = lst.Offset;
            _temvai = lst.TemVai;
            _sauin = lst.SauIn;
            _kiempham = lst.KiemPham;
            _khobtp = lst.KhoBTP;
            _khonvl = lst.KhoNVL;
            _danhthiep = lst.DanhThiep;
            _kythuatso = lst.KyThuatSo;
            _sticker = lst.Sticker;
            _inchuvitinh = lst.InChuViTinh;
            _quanlychatluong = lst.QuanLyChatLuong;
            _quanlysanxuat = lst.QuanLySanXuat;


            ////Bộ phận Nghiệp Vụ
            //rbgDonSanXuat.Enabled = false;
            ////bbi_nghiepvu.Enabled = false;
            //bbiDonHangAvery.Enabled = false;
            //bbiStandard.Enabled = false;
            //rbgLanhLieu.Enabled = false;
            //bbiDonSanXuat.Enabled = false;
            ////rbgDanTrang.Enabled = false;


            //// Thiết kế
            //rpgTienIch.Enabled = false;
            //bbiTaoTaiKhoan.Enabled = false;
            //// Kế toán
            //rpgKetoan.Enabled = false;
            //bbiKhoBTP_TPTon.Enabled = false;
            //bbiCapNhatKhoNVL.Enabled = false;
            //bbiKhoNVLTon.Enabled = false;
            ////rbgKhoNVL.Enabled = false;
            ////rpgKhoBTP_TP.Enabled = false;
            //rbgThem.Enabled = false;
            //bbiKhoBTP_TPNhap.Enabled = false;
            //bbiKhoBTP_TPXuat.Enabled = false;
            //bbiKhoNVLNhap.Enabled = false;
            //bbiKhoNVLXuat.Enabled = false;

            //bbiSanXuat.Enabled = false;
            //bbiThietKe.Enabled = false;
            //bbiCTP.Enabled = false;
            //bbiOffset.Enabled = false;
            //bbiSauIn.Enabled = false;
            //bbiTemVai.Enabled = false;
            //bbiKyThuatSo.Enabled = false;
            //bbiDanhThiep.Enabled = false;
            //bbiKiemPham.Enabled = false;
            //bbiKhoBTP_TP.Enabled = false;
            //bbiSticker.Enabled = false;
            //bbiCTF.Enabled = false;
            //bbiInChuViTinh.Enabled = false;

            //if (_nghiepvu == "Nghiệp Vụ")
            //{
            //    rbgDonSanXuat.Enabled = true;
            //    bbiDonSanXuat.Enabled = true;
            //    rpgTienIch.Enabled = true;
            //    bbiKhoBTP_TPTon.Enabled = true;
            //    bbiKhoNVLTon.Enabled = true;
            //    bbi_nghiepvu.Enabled = true;
            //    bbiDonHangAvery.Enabled = true;
            //    bbiStandard.Enabled = true;
            //    if (nvObj.Chucvu == "Quản Lý")
            //        bbiBangQuyetToan.Enabled = true;
            //}
            //else if (nvObj.Bophan == xnk)
            //{
            //    rpgTienIch.Enabled = true;
            //}
            //else if (nvObj.Bophan == thietke)
            //{
            //    rbgDanTrang.Enabled = true;
            //    bbiThietKe.Enabled = true;
            //    bbiKhoBTP_TPTon.Enabled = true;
            //    bbiKhoNVLTon.Enabled = true;
            //    bbiCapNhatKhoNVL.Enabled = true;
            //    if (nvObj.Chucvu == "Quản Lý")
            //        bbiTaoTaiKhoan.Enabled = true;
            //}
            //else if (nvObj.Bophan == ketoan)
            //{
            //    rpgKetoan.Enabled = true;
            //    bbiKhoBTP_TPTon.Enabled = true;
            //    bbiKhoNVLTon.Enabled = true;
            //}
            //else if (nvObj.Bophan == khonvl)
            //{
            //    bbiKhoNVLNhap.Enabled = true;
            //    bbiKhoNVLXuat.Enabled = true;
            //    bbiKhoNVLTon.Enabled = true;
            //    rbgThem.Enabled = true;
            //}
            //else if (nvObj.Bophan == khobtp)
            //{
            //    bbiKhoBTP_TPNhap.Enabled = true;
            //    bbiKhoBTP_TPXuat.Enabled = true;
            //    bbiKhoBTP_TPTon.Enabled = true;
            //    bbiKhoBTP_TP.Enabled = true;
            //    rbgThem.Enabled = true;

            //}
            //else if (nvObj.Bophan == qlsx)
            //{
            //    rbgLanhLieu.Enabled = true;
            //    bbiKhoBTP_TPTon.Enabled = true;
            //    bbiKhoNVLTon.Enabled = true;
            //    bbiSanXuat.Enabled = true;
            //}
            //else if (nvObj.Bophan == ctp)
            //    bbiCTP.Enabled = true;
            //else if (nvObj.Bophan == offset)
            //    bbiOffset.Enabled = true;
            //else if (nvObj.Bophan == sauin)
            //    bbiSauIn.Enabled = true;
            //else if (nvObj.Bophan == temvai)
            //    bbiTemVai.Enabled = true;
            //else if (nvObj.Bophan == kts)
            //    bbiKyThuatSo.Enabled = true;
            //else if (nvObj.Bophan == danhthiep)
            //    bbiDanhThiep.Enabled = true;
            //else if (nvObj.Bophan == kiempham)
            //    bbiKiemPham.Enabled = true;
            //else if (nvObj.Bophan == sticker)
            //    bbiSticker.Enabled = true;
            //else if (nvObj.Bophan == ctf)
            //    bbiCTF.Enabled = true;
            //else if (nvObj.Bophan == inchu)
            //    bbiInChuViTinh.Enabled = true;

        }

        private void bbiDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmLogin();
            Visible = false;
            frm.ShowDialog();
            Close();
        }

        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name != form.Name) continue;
                child.Activate();
                return true;
            }

            return false;
        }

        private void bbiKhoBTP_TPNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khobtp == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKhoBTP_TPNhap(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }


        private void bbiKhoBTP_TPXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khobtp == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKhoBTP_TPXuat(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void bbiKhoBTP_TPTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nvObj.Bophan != null || phanquyen == "fullcontrol")
            {
                var frm = new frmKhoBTP_TPTonKho();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn đăng nhập mới xem được");
            }
        }

        private void bbiSanXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quanlychatluong == "True" || _quanlysanxuat == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmSanXuat(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Quản Lý Sản Xuất");
            }
        }


        private void bbiThietKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_thietke == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmThietKe(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Thiết Kế");
            }
        }

        private void bbiCTP_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_ctp == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmCTP(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận CTP");
            }
        }

        private void bbiOffset_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_offset == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmOffset(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Offset");
            }
        }

        private void bbiTemVai_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_temvai == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmTemVai(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Tem Vải");
            }
        }

        private void bbiKyThuatSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_kythuatso == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKyThuatSo(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kỹ Thuật Số");
            }
        }

        private void bbiSticker_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_sticker == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmSticker(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Sticker");
            }
        }

        private void bbiSauIn_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (_sauin == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmSauIn(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Sau In");
            }
        }

        private void bbiDanhThiep_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (_danhthiep == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmDanhThiep(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Danh Thiếp");
            }
        }

        private void bbiKhoBTP_TP_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khobtp == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKhoBTP_TP(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void bbiKiemPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_kiempham == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKiemPham(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kiểm Phẩm");
            }
        }

        private void bbiLanhLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quanlysanxuat == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmLanhLieu(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Quản Lý Sản Xuất");
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (_inchuvitinh == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmInChuViTinh(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận In Chữ Vi Tính");
            }
        }

        private void bbiCTF_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_ctf == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmCTF(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận CTF");
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmForeachControl();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmMarkAvery();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nvObj.Bophan == ketoan || phanquyen == "fullcontrol")
            {
                var frm = new frmBangLuong();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kế Toán");
            }
        }

        private void bbiTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nvObj.Tennhanvien == "Nguyễn Hoàng Tâm" || phanquyen == "fullcontrol")
            {
                var frm = new frmTaoTaiKhoan();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Admin");
            }
        }

        private void bbi_nghiepvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmNghiepVu(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var frm = new frmBarCode(); // (nvObj);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbiDonHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nvObj.Bophan == ketoan || phanquyen == "fullcontrol")
            {
                var frm = new frmDonHang();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kế Toán");
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmTyGiaNgoaiTe();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmBangQuyetToan(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void bbiKichThuocGiay_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmGiay(); // (nvObj);
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmBangCatGiay();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmCongThucTinhLieu();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmKhuonTemVai();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (_quanlysanxuat == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmNhanVien();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Quản Lý Sản Xuất");
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmDonSanXuat_Avery(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" && nvObj.Tennhanvien == "Phan Thị Huyền Trang" ||
                _nghiepvu == "True" && nvObj.Tennhanvien == "Quy Thị Hậu" || phanquyen == "fullcontrol")
            {
                var frm = new frmStandard();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmDonSanXuat(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void bbiDanhSachSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmDanhSachSanPham(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void bbiKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKhachHang();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void bbiKhoNVLNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khonvl == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKhoNVLNhap(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void bbiKhoNVLXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khonvl == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKhoNVLXuat(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void bbiKhoNVLTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nvObj.Bophan != null || phanquyen == "fullcontrol")
            {
                var frm = new frmKhoNVLTonKho(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập mới xem được !");
            }
        }

        private void bbiMaHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khonvl == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmMaHangHoa();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void bbiDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khonvl == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmDonViTinh();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void bbiVatLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khonvl == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmVatLieu();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void bbiCongDoanSanXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmCongDoanSanXuat();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmExcel();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbiTemVaiAvery_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quanlysanxuat == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmTemVaiAvery(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Sản Xuất");
            }
        }

        private void bbiDanhSachDonHangBTP_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khobtp == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmDanhSachDonHangBTP(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận KhoBTP");
            }
        }

        private void bbiThongTinGopDonAvery_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quanlysanxuat == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmChiTietDonHangTemVaiAvery();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Sản Xuất");
            }
        }

        private void bbiOutSourceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmOutSourceList(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Nghiệp Vụ");
            }
        }

        private void bbiTemDanAvery_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quanlysanxuat == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmTemDanAD();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Sản Xuất");
            }
        }

        private void bbiKhoGiayIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quanlysanxuat == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmKhoGiayIn();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Sản Xuất");
            }
        }

        private void bbiNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khonvl == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmNhaCungCap();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void bbiQuyCach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khonvl == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmQuyCach();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void barButtonItem8_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (nvObj.Bophan == ketoan || phanquyen == "fullcontrol")
            {
                var frm = new frmDonHang_Avery();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kế Toán");
            }
        }

        private void barButtonItem11_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (phanquyen == "fullcontrol")
            {
                var frm = new frmCapNhatKhoNVL();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận admin");
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem11_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            if (_khonvl == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmDanhSachTinhLieu(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Kho");
            }
        }

        private void barButtonItem12_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            var frm = new frmForm();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbiBaoCaoThietKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_thietke == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmBaoCaoThietKe(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Thiết Kế");
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_thietke == "True" || _sauin == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmDanhSachKhuonBe(nvObj);
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không được phép truy cập");
            }
        }

        private void bbiBaoCao_nghiepvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nghiepvu == "True" || phanquyen == "fullcontrol")
            {
                var frm = new frmBaoCao_nghiepvu();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Thiết Kế");
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmCongThucAvery();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbiBaoCaoThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmForeachControl2();
            frm.Show();
        }

        private void skinRibbonGalleryBarItem1_GalleryPopupClose(object sender, DevExpress.XtraBars.Ribbon.InplaceGalleryEventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbNhanViens where s.MaNhanVien == nvObj.Manhanvien select s).Single();
                lst.GiaoDien = defaultLookAndFeel1.LookAndFeel.SkinName;
                db.SubmitChanges();
            }
            catch
            {
                // ignored
            }
        }

        private void bbiPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nvObj.Tennhanvien == "Nguyễn Hoàng Tâm" || phanquyen == "fullcontrol")
            {
                var frm = new frmPhanQuyen();
                if (ExistForm(frm)) return;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không thuộc bộ phận Admin");
            }
        }
    }

}