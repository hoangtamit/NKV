using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLySanXuat.Class;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.DonSanXuat
{
    internal partial class frmDonSanXuat_Them : DevExpress.XtraEditors.XtraForm
    {
        private double vat;
        private readonly VatLieuCtr vlCtr = new VatLieuCtr();
        private readonly KhoBTP_TPCtr khoBtpTpCtr = new KhoBTP_TPCtr();
        private readonly string _scd,_masanpham;
        private readonly NhanVienObj nvObj;
        public readonly MaSCD sscd = new MaSCD();
        public frmDonSanXuat_Them(string scd, string masanpham,NhanVienObj nvobj)
        {
            InitializeComponent();
             _scd = scd;
            _masanpham = masanpham;
            nvObj = nvobj;}

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void donGiaSanPhamSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (double.Parse(donGiaSanPhamSpinEdit.Text) < 0)
            {
                MessageBox.Show("Số tiền không được âm , vui lòng nhập lại");
                donGiaSanPhamSpinEdit.Text = String.Empty;
            }
        }

        #region Ngaydauthang,cuoithang 
        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        

        private void vatLieuComboBox_EditValueChanged(object sender, EventArgs e)
        {
            //if (khoTextEdit.Text == banthanhpham || khoTextEdit.Text == thanhpham)
            //    tenSanPhamTextEdit.Text = vatLieuComboBox.Text;
        }
        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            var dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
            

        private void ngayXuongDonDateEdit_Click(object sender, EventArgs e)
        {
            ngayXuongDonDateEdit.BackColor = Color.Empty;
        }

        public static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        public static DateTime GetLastDayOfMonth(int iMonth)
        {
            var dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        #endregion

        private void khoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (txtKho.Text == PrintRibbon.banthanhpham || txtKho.Text == PrintRibbon.thanhpham)
            {
                searchLookUpEdit1View.Columns.Clear();
                vatLieuComboBox.Properties.DataSource = khoBtpTpCtr.LoadData3C();
                vatLieuComboBox.Properties.DisplayMember = "TenSanPham";
                vatLieuComboBox.Properties.ValueMember = "TenSanPham";

            }
            else if (txtKho.Text == PrintRibbon.nguyenvatlieu)
            {
                searchLookUpEdit1View.Columns.Clear();
                vatLieuComboBox.Properties.DataSource = vlCtr.LoadData4C();
                vatLieuComboBox.Properties.DisplayMember = "TenHangHoa";
                vatLieuComboBox.Properties.ValueMember = "TenHangHoa";
            }
            else
            {
                searchLookUpEdit1View.Columns.Clear();
                vatLieuComboBox.Properties.DataSource = null;
            }
            var dauthang = DateTime.Now;
            var cuoithang = DateTime.Now;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.procTonKhoBTP_TP_View_NV(GetFirstDayOfMonth(dauthang), GetLastDayOfMonth(cuoithang))
                select s).ToList();
            foreach (var item in lst)
            {
                if (item.TenSanPham != tenSanPhamTextEdit.Text) continue;
                if (txtKho.Text == item.Kho || txtKho.Text == PrintRibbon.banthanhpham)
                {
                    bTPSoLuongTonKhoSpinEdit.Text = item.TonCuoiKyKhachHang.ToString();
                    bTPTonKhoCongtySpinEdit.Text = item.TonCuoiKyCongTy.ToString();
                    break;
                }
                if (txtKho.Text == item.Kho && txtKho.Text == PrintRibbon.thanhpham)
                {
                    tPSoLuongTonKhoSpinEdit.Text = item.TonCuoiKyKhachHang.ToString();
                    TPTonKhoCongtySpinEdit.Text = item.TonCuoiKyCongTy.ToString();
                    break;
                }
            }
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (ngoaiTeComboBox.SelectedItem == null)
                MessageBox.Show("Bạn chưa chọn Ngoại Tệ");
            
            vat = CheckVAT.Checked ? 1.1 : 1;
            try
            {
                var s = ((double.Parse(soLuongSpinEdit.Text) * Convert.ToDouble(donGiaSanPhamSpinEdit.Value)) + Convert.ToDouble(donGiaKhuonSpinEdit.Value) + Convert.ToDouble(donGiaMauSpinEdit.Value) + Convert.ToDouble(donGiaVanChuyenSpinEdit.Value))* vat;
                switch (ngoaiTeComboBox.Text)
                {
                    case "USD":
                        tongTienSpinEdit.Text = $"{s:0.#######}";
                        break;
                    case "JPY":
                        tongTienSpinEdit.Text = $"{s:0.####}";
                        break;
                    case "VND":
                        tongTienSpinEdit.Text = $"{s:0}";
                        break;
                }
            }
            catch
            {
                // ignored
            }
        }

        private void sCDTextEdit_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            sCDTextEdit.Text = sscd.TaoSCD();
            //const string format = "yyMMddHHmmss";
            //var now = DateTime.Now;
            //var s = now.ToString(format);
            //sCDTextEdit.Text = "SCD" + s;
            //sCDTextEdit.BackColor = Color.Empty;
        }

        private void maDonHangTextEdit_TextChanged(object sender, EventArgs e)
        {
           

        }
        private void frmDonSanXuat_Them_Load(object sender, EventArgs e)
        {
            SearchLookup();
            NhanData();
            phanquyen();
        }

        public void phanquyen()
        {
            if (nvObj.Bophan == "QUẢN LÝ SẢN XUẤT")
            {
                GroupTien.Visible = false;
                txtPhienBan.Text = "HÀNG BÙ";
                txtPhienBan.Enabled = false;
                tenSanPhamTextEdit.Enabled = false;
                maDonHangTextEdit.Enabled = false;
                kichThuocTextEdit.Enabled = false;
                txtKhachHang.Enabled = false;
            }
        }
        public void SearchLookup()
        {
            //// Đơn sản xuất Avery
            //var dsxAveryCtr = new DonSanXuat_AveryCtr();
            //txtTenSanPham.Properties.DataSource = dsxAveryCtr.LoadData(); ;
            //txtTenSanPham.Properties.DisplayMember = "SO";
            //txtTenSanPham.Properties.ValueMember = "SO";

            //Bảng Phiên Bản
            var pbCtr = new PhienBanCtr();
            txtPhienBan.Properties.DataSource = pbCtr.LoadData();
            txtPhienBan.Properties.DisplayMember = "ID";
            txtPhienBan.Properties.ValueMember = "ID";

            // Bảng Khách Hàng
            var khCtr = new KhachHangCtr();
            txtKhachHang.Properties.DataSource = khCtr.LoadData1C();
            txtKhachHang.Properties.DisplayMember = "TenKhachHang";
            txtKhachHang.Properties.ValueMember = "TenKhachHang";

            // Bảng Loại Sản Phẩm
            var lspCtr = new LoaiSanPhamCtr();
            txtLoaiSanPham.Properties.DataSource = lspCtr.LoadData();
            txtLoaiSanPham.Properties.DisplayMember = "ID";
            txtLoaiSanPham.Properties.ValueMember = "ID";

            // Bảng Bộ Phận
            var bpCtr = new BoPhanCtr();
            txtBoPhan.Properties.DataSource = bpCtr.LoadData();
            txtBoPhan.Properties.DisplayMember = "ID";
            txtBoPhan.Properties.ValueMember = "ID";

            // Phương Pháp In
            var ppiCtr = new PhuongPhapInCtr();
            txtPhuongPhapIn.Properties.DataSource = ppiCtr.LoadData();
            txtPhuongPhapIn.Properties.DisplayMember = "ID";
            txtPhuongPhapIn.Properties.ValueMember = "ID";

            // Bảng Kho
            var KhoCtr = new KhoCtr();
            txtKho.Properties.DataSource = KhoCtr.LoadData1C();
            txtKho.Properties.DisplayMember = "ID";
            txtKho.Properties.ValueMember = "ID";



        }
        public void NhanData()
        {
            sCDTextEdit.BackColor = Color.LightGreen;
            ngayXuongDonDateEdit.BackColor = Color.LightGreen;
            ngayGiaoHangDateEdit.BackColor = Color.LightGreen;
            soLuongSpinEdit.BackColor = Color.LightGreen;

            if (_scd == "0")
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == _masanpham select s).Single();
                txtKhachHang.Text = lst.TenKhachHang;
                tenSanPhamTextEdit.Text = lst.TenSanPham;
                txtLoaiSanPham.Text = lst.LoaiSanPham;
                giaCongMatPhaiTextEdit.Text = lst.GiaCongMatPhai;
                giaCongMatTraiTextEdit.Text = lst.GiaCongMatTrai;
                mauMatPhaiTextEdit.Text = lst.MauMatPhai;
                mauMatTraiTextEdit.Text = lst.MauMatTrai;
                ngayXuongDonDateEdit.DateTime = DateTime.Now;
                ngayGiaoHangDateEdit.DateTime=DateTime.Now;
                boGocTextEdit.Text = lst.BoGoc;
                phuongPhapCatTextEdit.Text = lst.PhuongPhapCat;
                txtPhuongPhapIn.Text = lst.PhuongPhapIn;
                kichThuocTextEdit.Text = lst.KichThuoc;
                ducLoTextEdit.Text = lst.Lo;}
            else
            {
                
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == _scd select s).Single();
                sCDTextEdit.Text = _scd;
                maDonHangTextEdit.Text = lst.MaDonHang;
                txtPhienBan.Text = lst.PhienBan;
                txtKhachHang.Text = lst.TenKhachHang;
                tenSanPhamTextEdit.Text = lst.TenSanPham;
                if (lst.NgayGiaoHang != null) ngayGiaoHangDateEdit.DateTime = (DateTime) lst.NgayGiaoHang;
                if (lst.NgayXuongDon != null) ngayXuongDonDateEdit.DateTime = (DateTime) lst.NgayXuongDon;
                txtLoaiSanPham.Text = lst.LoaiSanPham;
                txtKho.Text = lst.Kho;
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
                txtPhuongPhapIn.Text = lst.PhuongPhapIn;
                soLuongSpinEdit.Text = lst.SoLuong.ToString();
                txtBoPhan.Text = lst.BoPhan;
                chamCatDapHopTextEdit.Text = lst.ChamCatDapHop; 
                khacTextEdit.Text = lst.Khac;
                doDaiTextEdit.Text = lst.DoDai;
                giaCongSauTextEdit.Text = lst.GiaCongSau;
                kichThuocTextEdit.Text = lst.KichThuoc;
                inChu_MaVachTextEdit.Text = lst.InChu_MaVach;
                txtSKU.Text = lst.SKU.ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var donSanXuats = (from s in db.tbDonSanXuats select s).ToList();
            var tong = 0;
            foreach (var itemDonSanXuat in donSanXuats)
            {
                if (sCDTextEdit.Text == itemDonSanXuat.SCD)
                    tong = tong + 1;
            }

            if (sCDTextEdit.Text.Length > 14 & tong == 0)
            {
                if (maDonHangTextEdit.Text.Length > 8)
                {
                    try
                    {
                        var tb = new tbDonSanXuat();
                        tb.SCD = sCDTextEdit.Text;
                        tb.MaDonHang = maDonHangTextEdit.Text;
                        tb.PhienBan = txtPhienBan.Text;
                        tb.TenKhachHang = txtKhachHang.Text;
                        tb.NgayXuongDon = ngayXuongDonDateEdit.DateTime;
                        tb.NgayGiaoHang = ngayGiaoHangDateEdit.DateTime;
                        tb.TenSanPham = tenSanPhamTextEdit.Text;
                        tb.LoaiSanPham = txtLoaiSanPham.Text;
                        tb.PhuongPhapIn = txtPhuongPhapIn.Text;
                        tb.KichThuoc = kichThuocTextEdit.Text;
                        tb.SoLuong = Convert.ToInt32(soLuongSpinEdit.Value);
                        tb.VatLieu = vatLieuComboBox.Text;
                        tb.GiaCongMatPhai = giaCongMatPhaiTextEdit.Text;
                        tb.GiaCongMatTrai = giaCongMatTraiTextEdit.Text;
                        var lst = (from s in db.tbDanhSachSanPhams select s).ToList();
                        foreach (var itemTbDanhSachSanPham in lst)
                        {
                            if (itemTbDanhSachSanPham.TenSanPham != tenSanPhamTextEdit.Text) continue;
                            tb.HinhMatPhai = itemTbDanhSachSanPham.HinhMatPhai;
                            tb.HinhMatTrai = itemTbDanhSachSanPham.HinhMatTrai;
                            tb.HinhKhuon = itemTbDanhSachSanPham.HinhKhuon;
                        }
                        tb.MauMatPhai = mauMatPhaiTextEdit.Text;
                        tb.MauMatTrai = mauMatTraiTextEdit.Text;
                        tb.PhuongPhapCat = phuongPhapCatTextEdit.Text;
                        tb.BoGoc = boGocTextEdit.Text;
                        tb.DucLo = ducLoTextEdit.Text;
                        tb.LoaiChi = loaiChiTextEdit.Text;
                        tb.BTPSoLuongTonKho = Convert.ToInt32(bTPSoLuongTonKhoSpinEdit.Value);
                        tb.TPSoLuongTonKho = Convert.ToInt32(tPSoLuongTonKhoSpinEdit.Value);
                        tb.BTPTonKhoCongTy = Convert.ToInt32(bTPTonKhoCongtySpinEdit.Value);
                        tb.TPTonKhoCongTy = Convert.ToInt32(TPTonKhoCongtySpinEdit.Value);
                        tb.BoPhan = txtBoPhan.Text;
                        tb.ChamCatDapHop = chamCatDapHopTextEdit.Text;
                        tb.Khac = khacTextEdit.Text;
                        tb.DoDai = doDaiTextEdit.Text;
                        tb.InChu_MaVach = inChu_MaVachTextEdit.Text;
                        tb.GiaCongSau = giaCongSauTextEdit.Text;
                        tb.Kho = txtKho.Text;
                        tb.ChuY = chuYTextEdit.Text;
                        tb.SKU = (int)txtSKU.Value;
                        tb.NhanVienNghiepVu = nvObj.Tennhanvien;
                        tb.ThoiGianXuongDon = DateTime.Now;
                        db.tbDonSanXuats.InsertOnSubmit(tb);

                        var tb2 = new tbQuanLyDonHang { IDQuanLyDonHang = sCDTextEdit.Text };
                        db.tbQuanLyDonHangs.InsertOnSubmit(tb2);

                        var tb3 = new tbLanhLieu { IDLanhLieu = sCDTextEdit.Text };
                        db.tbLanhLieus.InsertOnSubmit(tb3);

                        if (CheckVAT.CheckState == CheckState.Unchecked || tongTienSpinEdit.Text == null)
                            vat = 1;
                        var tb4 = new tbQuanLyTienTe
                        {
                            IDTienTe = sCDTextEdit.Text,
                            DonGiaSanPham = Convert.ToDouble(donGiaSanPhamSpinEdit.Value),
                            DonGiaKhuon = Convert.ToDouble(donGiaKhuonSpinEdit.Value),
                            DonGiaMau = Convert.ToDouble(donGiaMauSpinEdit.Value),
                            DonGiaVanChuyen = Convert.ToDouble(donGiaVanChuyenSpinEdit.Value),
                            TongTien = Convert.ToDouble(tongTienSpinEdit.Value),
                            NgoaiTe = ngoaiTeComboBox.Text,
                            VAT = vat
                        };
                        db.tbQuanLyTienTes.InsertOnSubmit(tb4);

                        var sanxuat = new tbSanXuat { IDSanXuat = sCDTextEdit.Text };
                        db.tbSanXuats.InsertOnSubmit(sanxuat);

                        var thietke = new tbBaoCaoThietKe
                        {
                            IDBaoCaoThietKe = sCDTextEdit.Text,
                            SpSize = soLuongSpinEdit.Text
                        };
                        db.tbBaoCaoThietKes.InsertOnSubmit(thietke);

                        var _nghiepvu = new tbBaoCaoNghiepVu()
                        {
                            IDBaoCaoNghiepVu = sCDTextEdit.Text,
                        };
                        db.tbBaoCaoNghiepVus.InsertOnSubmit(_nghiepvu);

                        var donhangtemvai = new tbDonHangTemVaiAvery
                        {
                            IDDonHangTemVaiAvery = sCDTextEdit.Text,
                        };
                        db.tbDonHangTemVaiAveries.InsertOnSubmit(donhangtemvai);

                        db.SubmitChanges();
                        MessageBox.Show(PrintRibbon.themthanhcong);

                        var xn = nvObj.Tennhanvien + " " + DateTime.Now;
                        if (nvObj.Bophan == "QUẢN LÝ SẢN XUẤT")
                        {
                            var qldh = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
                            qldh.NghiepVu_XuongDon = xn;
                            db.SubmitChanges();
                        }
                    }
                    catch
                    {
                        // ignored
                    }
                }
                else
                    MessageBox.Show("Bạn chưa nhập mã đơn hàng");
            }
            else
                MessageBox.Show("Bạn chưa nhập mã SCD, hoặc mã SCD bị trùng");
        }

        public void Clear()
        {
            sCDTextEdit.Text = String.Empty;
            maDonHangTextEdit.Text = String.Empty;
            txtPhienBan.Text = String.Empty;
            txtKhachHang.Text = String.Empty;
            tenSanPhamTextEdit.Text = String.Empty;
            ngayGiaoHangDateEdit.DateTime = DateTime.Now;
            ngayXuongDonDateEdit.DateTime = DateTime.Now;
            txtLoaiSanPham.Text = String.Empty;
            vatLieuComboBox.Text = String.Empty;
            chuYTextEdit.Text = String.Empty;
            giaCongMatPhaiTextEdit.Text = String.Empty;
            giaCongMatTraiTextEdit.Text = String.Empty;
            mauMatPhaiTextEdit.Text = String.Empty;
            mauMatTraiTextEdit.Text = String.Empty;
            boGocTextEdit.Text = String.Empty;
            ducLoTextEdit.Text = String.Empty;
            loaiChiTextEdit.Text = String.Empty;
            phuongPhapCatTextEdit.Text = String.Empty;
            txtPhuongPhapIn.Text = String.Empty;
            soLuongSpinEdit.Text = String.Empty;
            txtBoPhan.Text = String.Empty;
            chamCatDapHopTextEdit.Text = String.Empty;
            khacTextEdit.Text = String.Empty;
            doDaiTextEdit.Text = String.Empty;
            giaCongSauTextEdit.Text = String.Empty;
            kichThuocTextEdit.Text = String.Empty;
            txtKho.Text = String.Empty;
            inChu_MaVachTextEdit.Text = String.Empty;
            tPSoLuongTonKhoSpinEdit.Text = String.Empty;
            TPTonKhoCongtySpinEdit.Text = String.Empty;
            bTPSoLuongTonKhoSpinEdit.Text = String.Empty;
            bTPTonKhoCongtySpinEdit.Text = String.Empty;
        }

        private void maDonHangTextEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var dsxCtr = new DonSanXuatCtr();
            //var day = dsxCtr.GetDay();
            //var dt = dsxCtr.GetData_DonSanXuat_MaDonHang(day);
            //maDonHangTextEdit.Text = day + dsxCtr.SinhMaTuDong(dt);
            var mdh = new MaDonHang();
            maDonHangTextEdit.Text = mdh.TaoMaDonHang();
        }       
    }
}