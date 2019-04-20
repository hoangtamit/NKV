using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using QuanLySanXuat.Class;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;
using static System.Int32;
using static System.String;
using static QuanLySanXuat.PrintRibbon;
namespace QuanLySanXuat
{
    public partial class frmDonSanXuat_Avery_Them : DevExpress.XtraEditors.XtraForm
    {
        private double vat;
        private readonly DonSanXuat_AveryCtr dsxAveryCtr = new DonSanXuat_AveryCtr();
        private readonly VatLieuCtr vlCtr = new VatLieuCtr();
        private readonly KhoBTP_TPCtr khoBtpTpCtr = new KhoBTP_TPCtr();
        public readonly OverlayLoading overlay = new OverlayLoading();
        public readonly Class.MaDonHang mdh = new Class.MaDonHang();
        private readonly  MaSCD sscd = new MaSCD();
        public frmDonSanXuat_Avery_Them()
        {
            InitializeComponent();
        }

        private readonly NhanVienObj nvObj = new NhanVienObj();
        private readonly string _scd;
        private readonly string _masanpham;
        public frmDonSanXuat_Avery_Them(string scd, string masanpham, NhanVienObj obj)
        {
            _scd = scd;
            _masanpham = masanpham;
            InitializeComponent();
            nvObj = obj;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Clear();
            txtKho.Text = nguyenvatlieu;
        }

        private void donGiaSanPhamSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (double.Parse(donGiaSanPhamSpinEdit.Text) < 0)
            {
                MessageBox.Show("Số tiền không được âm , vui lòng nhập lại");
                donGiaSanPhamSpinEdit.Text = Empty;
            }
        }

        #region Ngaydauthang,cuoithang 

        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        private void tenSanPhamTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            // Tạo mã SCD tự động
            sCDTextEdit.Text = sscd.TaoSCD();
            //sCDTextEdit.Text = "SCD" + DateTime.Now.ToString("yyMMddHHmmss");

            // Tạo mã đơn hàng tự động
            maDonHangTextEdit.Text = mdh.TaoMaDonHang();

            if (IsNullOrEmpty(txtGiaTienUSD.Text) || txtGiaTienUSD.Value == 0)
            {
                txtGiaTienUSD.Text = "22757";
            }

            var vatlieu_count = 0;
            //var lstVatLieu2_count = 0;
            try
            {
                kichThuocTextEdit.BackColor = Color.LightSalmon;
                mauMatPhaiTextEdit.BackColor = Color.LightSalmon;
                //txtPhuongPhapIn.BackColor = Color.LightSalmon;
                giaCongSauTextEdit.BackColor = Color.LightSalmon;
                vatLieuComboBox.BackColor = Color.LightSeaGreen;
                ngayXuongDonDateEdit.BackColor = Color.LightGreen;
                ngayGiaoHangDateEdit.BackColor = Color.LightGreen;
                soLuongSpinEdit.BackColor = Color.LightGreen;
                tongTienSpinEdit.BackColor = Color.Aqua;
                donGiaSanPhamSpinEdit.BackColor = Color.Aqua;
                ngoaiTeComboBox.BackColor = Color.Aqua;

                var db = new MyDBContextDataContext();
                var dsx = (from a in db.tbDonSanXuat_Averies where a.SO == tenSanPhamTextEdit.Text select a).Single();
                if (dsx.OrderDate != null) ngayXuongDonDateEdit.DateTime = (DateTime) dsx.OrderDate;
                if (dsx.RequestDate != null) ngayGiaoHangDateEdit.DateTime = (DateTime) dsx.RequestDate;
                //loaiChiTextEdit.Text = dsx.No.ToString();
                var gopdon = (from s in db.GopDon_Avery(nvObj.Tennhanvien) where s.gopdon == dsx.No select s).Single();
                soLuongSpinEdit.Text = gopdon.tong.ToString();
                //khacTextEdit.Text = "SKU " + gopdon.SkuMax;
                if (gopdon.SkuMax != null) txtSKU.Value = (int) gopdon.SkuMax;

                // Dò trong tbVatlieu tìm tên hàng hóa cho vật liệu in
                //var lstVatLieus = (from s in db.tbVatLieus where s.MaAvery != null || s.MaAvery != "" select s).ToList();
                //foreach (var vatLieu in lstVatLieus)
                //{
                //    if (vatLieu.MaAvery.Trim() == dsx.Material.Trim())
                //    {
                //        vatLieuComboBox.Text = vatLieu.TenHangHoa;
                //        vatlieu_count = 1;
                //        break;
                //    }
                //}
                //if (vatlieu_count == 0)
                //{
                //    vatLieuComboBox.Text = Empty;
                //    MessageBox.Show("Mã " + dsx.Material + " này không tồn tại trong Kho Nguyên Vật Liệu, Vui lòng liên hệ Kho Nguyên Vật Liệu");
                //}

                // Dò tbStandard tìm CB có giống nhau không.
                var standard_count = 0;
                foreach (var itemsStandard in db.tbStandards.ToList())
                {
                    //CB408942 == CB408942
                    if (itemsStandard.ItemCode != dsx.Item.Trim()) continue;

                    var tong = 0;
                    kichThuocTextEdit.Text = itemsStandard.PrintSize;
                    giaCongSauTextEdit.Text = itemsStandard.Note;
                    donGiaSanPhamSpinEdit.Text = itemsStandard.Price.ToString();
                    mauMatPhaiTextEdit.Text = itemsStandard.InkCode;

                    var lstVatLieus = (from s in db.tbVatLieus where s.MaAvery != null || s.MaAvery != "" select s).ToList();
                    foreach (var vatLieu in lstVatLieus)
                    {
                        if (vatLieu.MaAvery.Trim() != itemsStandard.MaterialCode.Trim()) continue;
                        vatLieuComboBox.Text = vatLieu.TenHangHoa;
                        vatlieu_count = 1;
                        break;
                    }
                    if (dsx.Material != itemsStandard.MaterialCode)
                    {
                        overlay.EndLoading();
                        MessageBox.Show("Mã Đơn Hàng: " + maDonHangTextEdit.Text + Environment.NewLine + " Vật liệu OutSourceList = " + dsx.Material + " không giống vật liệu Standard = " + itemsStandard.MaterialCode);
                    }

                    if (vatlieu_count == 0)
                    {
                        overlay.EndLoading();
                        vatLieuComboBox.Text = Empty;
                        MessageBox.Show("Mã " + dsx.Material +
                                        " này không tồn tại trong Kho Nguyên Vật Liệu, Vui lòng liên hệ Kho Nguyên Vật Liệu");
                    }

                    ngoaiTeComboBox.Text = "VND";
                    var dsx2 = (from s in db.tbDonSanXuat_Averies where s.XacNhan == null select s).ToList();
                    foreach (var dogopdon in dsx2)
                    {
                        if (dsx.No != dogopdon.GopDon) continue;
                        var kq = 0;
                        if (dogopdon.Qty * donGiaSanPhamSpinEdit.Value / dogopdon.SKU <=
                            txtGiaTienUSD.Value * 5)
                        {
                            if (dogopdon.SKU != null) kq = (int) txtGiaTienUSD.Value * 5 * (int) dogopdon.SKU;
                        }
                        else
                        {
                            kq = Convert.ToInt32(dogopdon.Qty) * (int) donGiaSanPhamSpinEdit.Value;
                        }

                        tong = tong + kq;
                    }

                    tongTienSpinEdit.Text = tong.ToString();
                    standard_count = 1;
                    //var muc = itemsStandard.InkCode.Trim().Substring(0, 15);
                    break;
                }

                if (standard_count != 0) return;
                kichThuocTextEdit.Text = Empty;
                txtPhuongPhapIn.Text = Empty;
                giaCongSauTextEdit.Text = Empty;
                tongTienSpinEdit.Text = Empty;
                donGiaKhuonSpinEdit.Text = Empty;
                mauMatPhaiTextEdit.Text = Empty;
                ngoaiTeComboBox.Text = Empty;
                tongTienSpinEdit.Text = Empty;
                donGiaSanPhamSpinEdit.Text = Empty;
                MessageBox.Show("Mã " + dsx.Item + " này không tồn tại trong danh mục Standard, Vui lòng hãy thêm vào");

                //if (vatlieu_count == 0)
                //{
                //    vatLieuComboBox.Text = Empty;
                //}

            }
            catch
            {
                // ignored
            }

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
            if (txtKho.Text == banthanhpham || txtKho.Text == thanhpham)
            {
                searchLookUpEdit1View.Columns.Clear();
                vatLieuComboBox.Properties.DataSource = khoBtpTpCtr.LoadData3C();
                vatLieuComboBox.Properties.DisplayMember = "TenSanPham";
                vatLieuComboBox.Properties.ValueMember = "TenSanPham";
            }
            else if (txtKho.Text == nguyenvatlieu)
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
                if (txtKho.Text == item.Kho || txtKho.Text == banthanhpham)
                {
                    bTPSoLuongTonKhoSpinEdit.Text = item.TonCuoiKyKhachHang.ToString();
                    bTPTonKhoCongtySpinEdit.Text = item.TonCuoiKyCongTy.ToString();

                }

                if (txtKho.Text != item.Kho || txtKho.Text != thanhpham) continue;
                tPSoLuongTonKhoSpinEdit.Text = item.TonCuoiKyKhachHang.ToString();
                TPTonKhoCongtySpinEdit.Text = item.TonCuoiKyCongTy.ToString();
                break;
            }
        }




        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (ngoaiTeComboBox.SelectedItem == null)
                MessageBox.Show("Bạn chưa chọn Ngoại Tệ");
            if (CheckVAT.Checked)
                vat = 1.1;
            else
                vat = 1;
            try
            {
                var s = ((double.Parse(soLuongSpinEdit.Text) * Convert.ToDouble(donGiaSanPhamSpinEdit.Value)) +
                         Convert.ToDouble(donGiaKhuonSpinEdit.Value) + Convert.ToDouble(donGiaMauSpinEdit.Value) +
                         Convert.ToDouble(donGiaVanChuyenSpinEdit.Value)) * vat;
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

        private void sCDTextEdit_Properties_ButtonClick_1(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            sCDTextEdit.Text = sscd.TaoSCD();
            //const string format = "yyMMddHHmmss";
            //var now = DateTime.Now;
            //var s = now.ToString(format);
            //sCDTextEdit.Text = "SCD" + s;
        }

        private void frmDonSanXuat_Avery_Them_Load(object sender, EventArgs e)
        {
            SearchLookup();
            NhanData();
            txtKho.Text = "NGUYÊN VẬT LIỆU";
            if (txtKho.Text == nguyenvatlieu)
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

            txtPhuongPhapIn.Text = "Máy in Tem Vải (In Mềm)";

        }

        public void SearchLookup()
        {
            // Đơn sản xuất Avery
            tenSanPhamTextEdit.Properties.DataSource = dsxAveryCtr.LoadData(nvObj.Tennhanvien);
            tenSanPhamTextEdit.Properties.DisplayMember = "SO";
            tenSanPhamTextEdit.Properties.ValueMember = "SO";

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
            if (_scd == "0")
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == _masanpham select s).Single();
                txtKhachHang.Text = lst.TenKhachHang;
                //tenSanPhamTextEdit.Text = lst.TenSanPham;
                txtLoaiSanPham.Text = lst.LoaiSanPham;
                giaCongMatPhaiTextEdit.Text = lst.GiaCongMatPhai;
                giaCongMatTraiTextEdit.Text = lst.GiaCongMatTrai;
                mauMatPhaiTextEdit.Text = lst.MauMatPhai;
                mauMatTraiTextEdit.Text = lst.MauMatTrai;
                ngayXuongDonDateEdit.DateTime = DateTime.Now;
                ngayGiaoHangDateEdit.DateTime = DateTime.Now;
                boGocTextEdit.Text = lst.BoGoc;
                phuongPhapCatTextEdit.Text = lst.PhuongPhapCat;
                txtPhuongPhapIn.Text = lst.PhuongPhapIn;
                kichThuocTextEdit.Text = lst.KichThuoc;
                ducLoTextEdit.Text = lst.Lo;
            }
            else
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == _scd select s).Single();
                //sCDTextEdit.Text = _scd;
                //maDonHangTextEdit.Text = lst.MaDonHang;
                txtPhienBan.Text = "( MỚI )";
                txtKhachHang.Text = lst.TenKhachHang;
                //tenSanPhamTextEdit.Text = lst.TenSanPham;
                ngayGiaoHangDateEdit.DateTime = DateTime.Now;
                ngayXuongDonDateEdit.DateTime = DateTime.Now;
                txtLoaiSanPham.Text = lst.LoaiSanPham;
                //vatLieuComboBox.Text = lst.VatLieu;
                //chuYTextEdit.Text = lst.ChuY;
                //giaCongMatPhaiTextEdit.Text = lst.GiaCongMatPhai;
                //giaCongMatTraiTextEdit.Text = lst.GiaCongMatTrai;
                //mauMatPhaiTextEdit.Text = lst.MauMatPhai;
                //mauMatTraiTextEdit.Text = lst.MauMatTrai;
                //boGocTextEdit.Text = lst.BoGoc;
                //ducLoTextEdit.Text = lst.DucLo;
                //loaiChiTextEdit.Text = lst.LoaiChi;
                //phuongPhapCatTextEdit.Text = lst.PhuongPhapCat;
                txtPhuongPhapIn.Text = lst.PhuongPhapIn;
                //soLuongSpinEdit.Text = lst.SoLuong.ToString();
                txtBoPhan.Text = lst.BoPhan;
                //chamCatDapHopTextEdit.Text = lst.ChamCatDapHop;
                //khacTextEdit.Text = lst.Khac;
                //doDaiTextEdit.Text = lst.DoDai;
                //giaCongSauTextEdit.Text = lst.GiaCongSau;
                txtKho.Text = lst.Kho;
                //kichThuocTextEdit.Text = lst.KichThuoc;
                //inChu_MaVachTextEdit.Text = lst.InChu_MaVach;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            //var donSanXuats = (from s in db.tbDonSanXuats select s).ToList();
            //var tong = 0;
            //foreach (var itemDonSanXuat in donSanXuats)
            //{
            //    if (sCDTextEdit.Text != itemDonSanXuat.SCD) continue;
            //    tong = tong + 1;
            //}
            scd:
            sCDTextEdit.Text = sscd.TaoSCD();
            var tong = (from s in db.tbDonSanXuats where s.SCD == sCDTextEdit.Text select s).ToList();
            if (tong.Count > 0)
                goto scd;
            if (sCDTextEdit.Text.Length > 14)
            {
                    try
                    {
                        var dsx = (from a in db.tbDonSanXuat_Averies where a.SO == tenSanPhamTextEdit.Text select a).Single();
                        var soluong = Convert.ToInt32(soLuongSpinEdit.Value);
                        var tb = new tbDonSanXuat();
                        tb.SCD = sCDTextEdit.Text;
                        tb.MaDonHang = maDonHangTextEdit.Text;
                        tb.PhienBan = txtPhienBan.Text;
                        tb.TenKhachHang = txtKhachHang.Text;
                        tb.NgayXuongDon = ngayXuongDonDateEdit.DateTime;
                        tb.NgayGiaoHang = ngayGiaoHangDateEdit.DateTime;
                        var gopdon = (from s in db.GopDon_Avery(nvObj.Tennhanvien) where s.gopdon == dsx.GopDon select s).Single();
                        if (gopdon.CountNo == 1)
                        {
                            tb.TenSanPham = dsx.SO + " - " + dsx.Item; //
                        }
                        else
                        {
                            tb.TenSanPham = dsx.Item; //dsx.SO + " - " +
                        }

                        tb.LoaiSanPham = txtLoaiSanPham.Text;
                        tb.PhuongPhapIn = txtPhuongPhapIn.Text;
                        tb.KichThuoc = kichThuocTextEdit.Text;
                        tb.SoLuong = soluong;
                        tb.VatLieu = vatLieuComboBox.Text;
                        tb.GiaCongMatPhai = giaCongMatPhaiTextEdit.Text;
                        tb.GiaCongMatTrai = giaCongMatTraiTextEdit.Text;
                        var lst = (from s in db.tbDanhSachSanPhams select s).ToList();
                        foreach (var dssPham in lst)
                        {
                            if (dssPham.TenSanPham != tenSanPhamTextEdit.Text) continue;
                            tb.HinhMatPhai = dssPham.HinhMatPhai;
                            tb.HinhMatTrai = dssPham.HinhMatTrai;
                            tb.HinhKhuon = dssPham.HinhKhuon;
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
                        tb.SKU = (int)txtSKU.Value;
                        tb.STT = dsx.No;



                        var so = Empty;
                        var tbDonSanXuatAveries =
                            (from s in db.tbDonSanXuat_Averies where s.XacNhan == null select s).ToList();
                        foreach (var item in tbDonSanXuatAveries)
                        {
                            if (item.GopDon != dsx.GopDon) continue;
                            item.scd = sCDTextEdit.Text;
                            item.XacNhan = 1;
                            db.SubmitChanges();
                            if (!(gopdon.CountNo > 1)) continue;
                            so = so + item.SO + " , ";
                        }

                        //var tb8 = (from s in db.tbDonSanXuat_Averies where s.XacNhan == null && gopdon.CountNo > 1 select s).ToList();
                        //foreach (var tbDonSanXuatAvery in tb8)
                        //{
                        //    if (tbDonSanXuatAvery.GopDon != dsx.GopDon) continue;
                        //    so = so + tbDonSanXuatAvery.SO + " , ";

                        //}

                        if (gopdon.CountNo > 1)
                            tb.ChuY = chuYTextEdit.Text + Environment.NewLine + so + " dùng chung layout";
                        else
                        {
                            tb.ChuY = chuYTextEdit.Text;
                        }

                        tb.NhanVienNghiepVu = nvObj.Tennhanvien;
                        tb.ThoiGianXuongDon = DateTime.Now;
                        db.tbDonSanXuats.InsertOnSubmit(tb);
                        db.SubmitChanges();


                        var qldh = new tbQuanLyDonHang {IDQuanLyDonHang = sCDTextEdit.Text};
                        db.tbQuanLyDonHangs.InsertOnSubmit(qldh);

                        var ll = new tbLanhLieu {IDLanhLieu = sCDTextEdit.Text};
                        db.tbLanhLieus.InsertOnSubmit(ll);
                        db.SubmitChanges();

                        var thietke = new tbBaoCaoThietKe
                        {
                            IDBaoCaoThietKe = sCDTextEdit.Text,
                            Size = khacTextEdit.Text,
                            SpSize = soLuongSpinEdit.Text
                        };
                        db.tbBaoCaoThietKes.InsertOnSubmit(thietke);
                        db.SubmitChanges();

                        var nghiepvu = new tbBaoCaoNghiepVu()
                        {
                            IDBaoCaoNghiepVu = sCDTextEdit.Text,
                            Size = khacTextEdit.Text
                        };
                        db.tbBaoCaoNghiepVus.InsertOnSubmit(nghiepvu);
                        db.SubmitChanges();

                        var tb4 = new tbQuanLyTienTe
                        {
                            IDTienTe = sCDTextEdit.Text,
                            DonGiaSanPham = Convert.ToDouble(donGiaSanPhamSpinEdit.Value),
                            DonGiaKhuon = Convert.ToDouble(donGiaKhuonSpinEdit.Value),
                            DonGiaMau = Convert.ToDouble(donGiaMauSpinEdit.Value),
                            DonGiaVanChuyen = Convert.ToDouble(donGiaVanChuyenSpinEdit.Value),
                            TongTien = Convert.ToDouble(tongTienSpinEdit.Value),
                            NgoaiTe = ngoaiTeComboBox.Text,
                            GiaTienUSD = (int) txtGiaTienUSD.Value,
                            VAT = vat
                        };
                        db.tbQuanLyTienTes.InsertOnSubmit(tb4);
                        db.SubmitChanges();

                        var tb6 = new tbSanXuat {IDSanXuat = sCDTextEdit.Text};
                        db.tbSanXuats.InsertOnSubmit(tb6);
                        db.SubmitChanges();


                        var donhang = new tbDonHangTemVaiAvery();
                        donhang.IDDonHangTemVaiAvery = sCDTextEdit.Text;
                        donhang.Item = dsx.Item;
                        donhang.SO = gopdon.CountNo != 1 ? so : dsx.SO;
                        donhang.DanhSach = dsx.DanhSach;
                        db.tbDonHangTemVaiAveries.InsertOnSubmit(donhang);
                        db.SubmitChanges();

                        frmDonSanXuat_Avery_Them_Load(sender, e);
                        MessageBox.Show(themthanhcong);

                        var tb7 = (from s in db.tbDonSanXuat_Averies
                            where s.XacNhan == null && s.NhanVien == nvObj.Tennhanvien
                            orderby s.GopDon, s.No ascending
                            select s).ToList();
                        foreach (var tbDonSanXuatAvery in tb7)
                        {
                            tenSanPhamTextEdit.Text = tbDonSanXuatAvery.SO;
                            break;
                        }

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                        // ignored
                    }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã SCD, hoặc mã SCD bị trùng");

            }

        }

        public void Clear()
        {
            sCDTextEdit.Text = Empty;
            maDonHangTextEdit.Text = Empty;
            txtPhienBan.Text = Empty;
            txtKhachHang.Text = Empty;
            tenSanPhamTextEdit.Text = Empty;
            ngayGiaoHangDateEdit.DateTime = DateTime.Now;
            ngayXuongDonDateEdit.DateTime = DateTime.Now;
            txtLoaiSanPham.Text = Empty;
            vatLieuComboBox.Text = Empty;
            chuYTextEdit.Text = Empty;
            giaCongMatPhaiTextEdit.Text = Empty;
            giaCongMatTraiTextEdit.Text = Empty;
            mauMatPhaiTextEdit.Text = Empty;
            mauMatTraiTextEdit.Text = Empty;
            boGocTextEdit.Text = Empty;
            ducLoTextEdit.Text = Empty;
            loaiChiTextEdit.Text = Empty;
            phuongPhapCatTextEdit.Text = Empty;
            txtPhuongPhapIn.Text = Empty;
            soLuongSpinEdit.Text = Empty;
            txtBoPhan.Text = Empty;
            chamCatDapHopTextEdit.Text = Empty;
            khacTextEdit.Text = Empty;
            doDaiTextEdit.Text = Empty;
            giaCongSauTextEdit.Text = Empty;
            kichThuocTextEdit.Text = Empty;
            txtKho.Text = Empty;
            inChu_MaVachTextEdit.Text = Empty;

        }

        private void maDonHangTextEdit_Properties_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            maDonHangTextEdit.Text = mdh.TaoMaDonHang();
        }
        private void btnDanhSachDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                overlay.StartLoading(groupControl2);
                var db = new MyDBContextDataContext();
                var dsdonhang = (from s in db.tbDonSanXuat_Averies where s.XacNhan == null && s.NhanVien == nvObj.Tennhanvien && s.No == s.GopDon
                    orderby s.GopDon, s.No ascending
                    select s).ToList();

                var tongsl = 0;
                var tongdh = 0;
                foreach (var ds in dsdonhang)
                {
                    tenSanPhamTextEdit.Text = ds.SO;
                    Taoscd:
                    sCDTextEdit.Text = sscd.TaoSCD();
                    var tong = (from s in db.tbDonSanXuats where s.SCD == sCDTextEdit.Text select s).ToList();
                    if (tong.Count > 0)
                        goto Taoscd;
                    //var donSanXuats = (from s in db.tbDonSanXuats select s).ToList();
                    //foreach (var itemDonSanXuat in donSanXuats)
                    //{
                    //    if (sCDTextEdit.Text == itemDonSanXuat.SCD)
                    //        goto scd;
                    //}
                    if (sCDTextEdit.Text.Length > 14 && !string.IsNullOrEmpty(sCDTextEdit.Text))
                    {
                        if (maDonHangTextEdit.Text.Length > 8)
                        {
                            var dsx = (from a in db.tbDonSanXuat_Averies where a.SO == tenSanPhamTextEdit.Text select a).Single();
                            var soluong = Convert.ToInt32(soLuongSpinEdit.Value);
                            var tb = new tbDonSanXuat();
                            tb.SCD = sCDTextEdit.Text;
                            tb.MaDonHang = maDonHangTextEdit.Text;
                            tb.PhienBan = txtPhienBan.Text;
                            tb.TenKhachHang = txtKhachHang.Text;
                            tb.NgayXuongDon = ngayXuongDonDateEdit.DateTime;
                            tb.NgayGiaoHang = ngayGiaoHangDateEdit.DateTime;
                            var gopdon = (from s in db.GopDon_Avery(nvObj.Tennhanvien)
                                where s.gopdon == dsx.GopDon
                                select s).Single();
                            if (gopdon.CountNo == 1)
                            {
                                tb.TenSanPham = dsx.SO + " - " + dsx.Item; //
                            }
                            else
                            {
                                tb.TenSanPham = dsx.Item; //dsx.SO + " - " +
                            }

                            tb.LoaiSanPham = txtLoaiSanPham.Text;
                            tb.PhuongPhapIn = txtPhuongPhapIn.Text;
                            tb.KichThuoc = kichThuocTextEdit.Text;
                            tb.SoLuong = soluong;
                            tb.VatLieu = vatLieuComboBox.Text;
                            tb.GiaCongMatPhai = giaCongMatPhaiTextEdit.Text;
                            tb.GiaCongMatTrai = giaCongMatTraiTextEdit.Text;
                            //var lst = (from s in db.tbDanhSachSanPhams select s).ToList();
                            //foreach (var dssPham in lst)
                            //{
                            //    if (dssPham.TenSanPham != tenSanPhamTextEdit.Text) continue;
                            //    tb.HinhMatPhai = dssPham.HinhMatPhai;
                            //    tb.HinhMatTrai = dssPham.HinhMatTrai;
                            //    tb.HinhKhuon = dssPham.HinhKhuon;
                            //}

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
                            tb.SKU = (int)txtSKU.Value;
                            tb.STT = dsx.No;



                            var so = Empty;
                            var tbDonSanXuatAveries =
                                (from s in db.tbDonSanXuat_Averies where s.XacNhan == null select s).ToList();
                            foreach (var item in tbDonSanXuatAveries)
                            {
                                if (item.GopDon != dsx.GopDon) continue;
                                item.scd = sCDTextEdit.Text;
                                item.XacNhan = 1;
                                //db.SubmitChanges();
                                if (gopdon.CountNo > 1) so = so + item.SO + " , ";
                            }

                            if (gopdon.CountNo > 1)
                                tb.ChuY = chuYTextEdit.Text + Environment.NewLine + so + " dùng chung layout";
                            else
                            {
                                tb.ChuY = chuYTextEdit.Text;
                            }

                            tb.NhanVienNghiepVu = nvObj.Tennhanvien;
                            tb.ThoiGianXuongDon = DateTime.Now;
                            db.tbDonSanXuats.InsertOnSubmit(tb);
                            db.SubmitChanges();


                            var qldh = new tbQuanLyDonHang {IDQuanLyDonHang = sCDTextEdit.Text};
                            db.tbQuanLyDonHangs.InsertOnSubmit(qldh);

                            var ll = new tbLanhLieu {IDLanhLieu = sCDTextEdit.Text};
                            db.tbLanhLieus.InsertOnSubmit(ll);
                            db.SubmitChanges();

                            var thietke = new tbBaoCaoThietKe
                            {
                                IDBaoCaoThietKe = sCDTextEdit.Text,
                                Size = khacTextEdit.Text,
                                SpSize = soLuongSpinEdit.Text
                            };
                            db.tbBaoCaoThietKes.InsertOnSubmit(thietke);
                            db.SubmitChanges();

                            var nghiepvu = new tbBaoCaoNghiepVu()
                            {
                                IDBaoCaoNghiepVu = sCDTextEdit.Text,
                                Size = khacTextEdit.Text
                            };
                            db.tbBaoCaoNghiepVus.InsertOnSubmit(nghiepvu);
                            db.SubmitChanges();

                            var tb4 = new tbQuanLyTienTe
                            {
                                IDTienTe = sCDTextEdit.Text,
                                DonGiaSanPham = Convert.ToDouble(donGiaSanPhamSpinEdit.Value),
                                DonGiaKhuon = Convert.ToDouble(donGiaKhuonSpinEdit.Value),
                                DonGiaMau = Convert.ToDouble(donGiaMauSpinEdit.Value),
                                DonGiaVanChuyen = Convert.ToDouble(donGiaVanChuyenSpinEdit.Value),
                                TongTien = Convert.ToDouble(tongTienSpinEdit.Value),
                                NgoaiTe = ngoaiTeComboBox.Text,
                                GiaTienUSD = (int) txtGiaTienUSD.Value,
                                VAT = vat
                            };
                            db.tbQuanLyTienTes.InsertOnSubmit(tb4);
                            db.SubmitChanges();

                            var tb6 = new tbSanXuat {IDSanXuat = sCDTextEdit.Text};
                            db.tbSanXuats.InsertOnSubmit(tb6);
                            db.SubmitChanges();


                            var donhang = new tbDonHangTemVaiAvery();
                            donhang.IDDonHangTemVaiAvery = sCDTextEdit.Text;
                            donhang.Item = dsx.Item;
                            donhang.SO = gopdon.CountNo != 1 ? so : dsx.SO;
                            donhang.DanhSach = dsx.DanhSach;
                            db.tbDonHangTemVaiAveries.InsertOnSubmit(donhang);
                            db.SubmitChanges();

                            //frmDonSanXuat_Avery_Them_Load(sender,e);
                            tongsl = tongsl + soluong;
                            tongdh = tongdh + 1;
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa nhập mã đơn hàng");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mã SCD, hoặc mã SCD bị trùng");

                    }
                }
                overlay.EndLoading();
                MessageBox.Show("Tổng số đơn hàng thêm vào: " + tongdh  + Environment.NewLine + "Tổng số lượng là : "+ tongsl);
            }
            catch (Exception exception)
            {
                overlay.EndLoading();
                MessageBox.Show(exception.ToString());
                // ignored
            }
            
        }
    }
}