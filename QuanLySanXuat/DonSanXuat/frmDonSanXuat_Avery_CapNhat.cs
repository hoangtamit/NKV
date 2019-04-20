using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;
using static System.Int32;
using static System.String;
using static QuanLySanXuat.PrintRibbon;

namespace QuanLySanXuat
{
    public partial class frmDonSanXuat_Avery_CapNhat : XtraForm
    {
        private double vat;
        private readonly DonSanXuat_AveryCtr dsxAveryCtr = new DonSanXuat_AveryCtr();
        private readonly VatLieuCtr vlCtr = new VatLieuCtr();
        private readonly KhoBTP_TPCtr khoBtpTpCtr = new KhoBTP_TPCtr();
        private readonly NhanVienObj nvObj = new NhanVienObj();
        private string scd;
        public frmDonSanXuat_Avery_CapNhat(string scd, NhanVienObj obj)
        {
            InitializeComponent();
            this.scd = scd;
            nvObj = obj;
        }
        public frmDonSanXuat_Avery_CapNhat()
        {
            InitializeComponent();
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
        public static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }

        private void txtTenSanPham_EditValueChanged(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(txtGiaTienUSD.Text) || txtGiaTienUSD.Value == 0)
            {
                txtGiaTienUSD.Text = "22757";
            }

            var vatlieu_count = 0;
            var lstVatLieu2_count = 0;
            try
            {
                kichThuocTextEdit.BackColor = Color.LightSalmon;
                mauMatPhaiTextEdit.BackColor = Color.LightSalmon;
                giaCongSauTextEdit.BackColor = Color.LightSalmon;
                vatLieuComboBox.BackColor = Color.LightSeaGreen;
                ngayXuongDonDateEdit.BackColor = Color.LightGreen;
                ngayGiaoHangDateEdit.BackColor = Color.LightGreen;
                soLuongSpinEdit.BackColor = Color.LightGreen;
                tongTienSpinEdit.BackColor = Color.Aqua;
                donGiaSanPhamSpinEdit.BackColor = Color.Aqua;
                ngoaiTeComboBox.BackColor = Color.Aqua;

                var db = new MyDBContextDataContext();
                var dsx = (from a in db.tbDonSanXuat_Averies where a.SO == txtTenSanPham.Text select a).Single();
                if (dsx.OrderDate != null) ngayXuongDonDateEdit.DateTime = (DateTime)dsx.OrderDate;
                if (dsx.RequestDate != null) ngayGiaoHangDateEdit.DateTime = (DateTime)dsx.RequestDate;
                loaiChiTextEdit.Text = dsx.No.ToString();
                var gopdon = (from s in db.GopDon_Avery(nvObj.Tennhanvien) where s.gopdon == dsx.No select s).Single();
                soLuongSpinEdit.Text = gopdon.tong.ToString();
                khacTextEdit.Text = "SKU " + gopdon.SkuMax;

                // Dò trong tbVatlieu tìm tên hàng hóa cho vật liệu in
                var lstVatLieus = (from s in db.tbVatLieus where s.MaAvery != null | s.MaAvery != "" select s).ToList();
                foreach (var vatLieu in lstVatLieus)
                {
                    if (vatLieu.MaAvery.Trim() == dsx.Material.Trim())
                    {
                        vatLieuComboBox.Text = vatLieu.TenHangHoa;
                        vatlieu_count = 1;
                        break;
                    }
                }
                if (vatlieu_count == 0)
                {
                    vatLieuComboBox.Text = Empty;
                    MessageBox.Show("Mã" + dsx.Material + "này không tồn tại trong Kho Nguyên Vật Liệu, Vui lòng liên hệ Kho Nguyên Vật Liệu");
                }

                // Dò tbStandard tìm CB có giống nhau không.
                var standard_count = 0;
                var standard = (from s in db.tbStandards select s).ToList();
                foreach (var itemsStandard in standard)
                {
                    // CB408942 == CB408942
                    if (itemsStandard.ItemCode == dsx.Item.Trim())
                    {
                        var tong = 0;
                        kichThuocTextEdit.Text = itemsStandard.PrintSize;
                        //txtPhuongPhapIn.Text = itemsStandard.LoaiMayIn;
                        giaCongSauTextEdit.Text = itemsStandard.Note;
                        donGiaSanPhamSpinEdit.Text = itemsStandard.Price.ToString();
                        ngoaiTeComboBox.Text = "VND";
                        var dsx2 = (from s in db.tbDonSanXuat_Averies where s.XacNhan == null select s).ToList();
                        foreach (var dogopdon in dsx2)
                        {
                            if (dsx.No != dogopdon.GopDon) continue;
                            var kq = 0;
                            if (dogopdon.Qty * donGiaSanPhamSpinEdit.Value / dogopdon.SKU <=
                                txtGiaTienUSD.Value * 5)
                            {
                                kq = (int)txtGiaTienUSD.Value * 5 * (int)dogopdon.SKU;
                            }
                            else
                            {
                                kq = Convert.ToInt32(dogopdon.Qty) * (int)donGiaSanPhamSpinEdit.Value;
                            }

                            tong = tong + kq;
                        }

                        tongTienSpinEdit.Text = tong.ToString();

                        standard_count = 1;

                        // Trích chuỗi từ AD cung cấp lấy mã mực = 9V000198-000-00
                        // if (itemsStandard.InkCode != null)
                        var muc = itemsStandard.InkCode.Trim().Substring(0, 15);
                        //Dò tìm mã mực


                        var lstVatLieu2 = (from c in db.tbVatLieus select c).ToList();
                        foreach (var lieu in lstVatLieu2)
                        {

                            if (lieu.MaAvery == muc)
                            {
                                mauMatPhaiTextEdit.Text = lieu.MaAvery;
                                lstVatLieu2_count = 1;
                                break;
                            }
                        }

                        break;
                    }
                }

                if (standard_count == 0)
                {
                    kichThuocTextEdit.Text = Empty;
                    txtPhuongPhapIn.Text = Empty;
                    giaCongSauTextEdit.Text = Empty;
                    tongTienSpinEdit.Text = Empty;
                    donGiaKhuonSpinEdit.Text = Empty;
                    ngoaiTeComboBox.Text = Empty;
                    MessageBox.Show(
                        "Mã" + dsx.Item + "này không tồn tại trong danh mục Standard, Vui lòng hãy thêm vào");
                }

                if (lstVatLieu2_count == 0)
                {
                    mauMatPhaiTextEdit.Text = Empty;
                }

            }
            catch
            {
                // ignored
            }

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
                if (item.TenSanPham != txtTenSanPham.Text) continue;
                if (txtKho.Text == item.Kho || txtKho.Text == banthanhpham)
                {
                    bTPSoLuongTonKhoSpinEdit.Text = item.TonCuoiKyKhachHang.ToString();
                    bTPTonKhoCongtySpinEdit.Text = item.TonCuoiKyCongTy.ToString();

                }
                if (txtKho.Text == item.Kho && txtKho.Text == thanhpham)
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
            if (CheckVAT.Checked)
                vat = 1.1;
            else
                vat = 1;
            try
            {
                var s = ((double.Parse(soLuongSpinEdit.Text) * Convert.ToDouble(donGiaSanPhamSpinEdit.Value)) + Convert.ToDouble(donGiaKhuonSpinEdit.Value) + Convert.ToDouble(donGiaMauSpinEdit.Value) + Convert.ToDouble(donGiaVanChuyenSpinEdit.Value)) * vat;
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

        private void frmDonSanXuat_Avery_CapNhat_Load(object sender, EventArgs e)
        {
            txtKho.Text = "NGUYÊN VẬT LIỆU";
            SearchLookup();
            NhanData();
            
        }
        public void SearchLookup()
        {
            // Đơn sản xuất Avery
            //txtTenSanPham.Properties.DataSource = dsxAveryCtr.LoadData();
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

            // Bảng Kho Nguyên Vật Liệu
            searchLookUpEdit1View.Columns.Clear();
            vatLieuComboBox.Properties.DataSource = vlCtr.LoadData4C();
            vatLieuComboBox.Properties.DisplayMember = "TenHangHoa";
            vatLieuComboBox.Properties.ValueMember = "TenHangHoa";
        }
        public void NhanData()
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == scd select s).Single();
            sCDTextEdit.Text = scd;
            maDonHangTextEdit.Text = lst.MaDonHang;
            txtPhienBan.Text = lst.PhienBan;
            txtKhachHang.Text = lst.TenKhachHang;
            txtTenSanPham.Text = lst.TenSanPham;
            if (lst.NgayGiaoHang != null) ngayGiaoHangDateEdit.DateTime = (DateTime) lst.NgayGiaoHang;
            if (lst.NgayXuongDon != null) ngayXuongDonDateEdit.DateTime = (DateTime) lst.NgayXuongDon;
            txtLoaiSanPham.Text = lst.LoaiSanPham;
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
            txtKho.Text = lst.Kho;
            kichThuocTextEdit.Text = lst.KichThuoc;
            inChu_MaVachTextEdit.Text = lst.InChu_MaVach;
            bTPSoLuongTonKhoSpinEdit.Text = lst.BTPSoLuongTonKho.ToString();
            tPSoLuongTonKhoSpinEdit.Text = lst.TPSoLuongTonKho.ToString();
            txtSKU.Text = lst.SKU.ToString();

            var tien = (from s in db.tbQuanLyTienTes where s.IDTienTe == scd select s).Single();
            donGiaKhuonSpinEdit.Text = tien.DonGiaKhuon.ToString();
            donGiaMauSpinEdit.Text = tien.DonGiaMau.ToString();
            donGiaSanPhamSpinEdit.Text = tien.DonGiaSanPham.ToString();
            donGiaVanChuyenSpinEdit.Text = tien.DonGiaVanChuyen.ToString();
            tongTienSpinEdit.Text = tien.TongTien.ToString();
            ngoaiTeComboBox.Text = tien.NgoaiTe;
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (tien.VAT == 1.1)
            {
                CheckVAT.Checked = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var procqldh = (from a in db.DonSanXuat_QuanLyDonhang_View() where a.SCD == sCDTextEdit.Text select a).Single();
            if (procqldh.HoanThanh == null)
            {
                var tb = (from s in db.tbDonSanXuats where s.SCD == sCDTextEdit.Text select s).Single();
                tb.MaDonHang = maDonHangTextEdit.Text;
                tb.PhienBan = txtPhienBan.Text;
                tb.TenKhachHang = txtKhachHang.Text;
                tb.NgayXuongDon = ngayXuongDonDateEdit.DateTime;
                tb.NgayGiaoHang = ngayGiaoHangDateEdit.DateTime;
                tb.TenSanPham = txtTenSanPham.Text;
                tb.LoaiSanPham = txtLoaiSanPham.Text;
                tb.PhuongPhapIn = txtPhuongPhapIn.Text;
                tb.KichThuoc = kichThuocTextEdit.Text;
                tb.SoLuong = int.Parse(soLuongSpinEdit.Text);
                tb.VatLieu = vatLieuComboBox.Text;
                tb.GiaCongMatPhai = giaCongMatPhaiTextEdit.Text;
                tb.GiaCongMatTrai = giaCongMatTraiTextEdit.Text;
                tb.MauMatPhai = mauMatPhaiTextEdit.Text;
                tb.MauMatTrai = mauMatTraiTextEdit.Text;
                tb.PhuongPhapCat = phuongPhapCatTextEdit.Text;
                tb.BoGoc = boGocTextEdit.Text;
                tb.DucLo = ducLoTextEdit.Text;
                tb.LoaiChi = loaiChiTextEdit.Text;
                tb.ChuY = chuYTextEdit.Text;
                tb.BoPhan = txtBoPhan.Text;
                tb.ChamCatDapHop = chamCatDapHopTextEdit.Text;
                tb.DoDai = doDaiTextEdit.Text;
                tb.GiaCongSau = giaCongSauTextEdit.Text;
                tb.InChu_MaVach = inChu_MaVachTextEdit.Text;
                tb.Kho = txtKho.Text;
                tb.BTPSoLuongTonKho = Convert.ToInt32(bTPSoLuongTonKhoSpinEdit.Value);
                tb.TPSoLuongTonKho = Convert.ToInt32(tPSoLuongTonKhoSpinEdit.Value);
                tb.BTPTonKhoCongTy = Convert.ToInt32(bTPTonKhoCongtySpinEdit.Value);
                tb.TPTonKhoCongTy = Convert.ToInt32(TPTonKhoCongtySpinEdit.Value);
                tb.ThoiGianXuongDon = DateTime.Now;
                tb.Khac = khacTextEdit.Text;
                tb.SKU = (int)txtSKU.Value;
                if (procqldh.NghiepVu_XuongDon != null)
                {
                    tb.ChinhSua = "1";
                }

                var tiente = (from s in db.tbQuanLyTienTes where s.IDTienTe == sCDTextEdit.Text select s).Single();
                tiente.IDTienTe = sCDTextEdit.Text;
                tiente.DonGiaSanPham = Convert.ToDouble(donGiaSanPhamSpinEdit.Value);
                tiente.DonGiaKhuon = Convert.ToDouble(donGiaKhuonSpinEdit.Value);
                tiente.DonGiaMau = Convert.ToDouble(donGiaMauSpinEdit.Value);
                tiente.DonGiaVanChuyen = Convert.ToDouble(donGiaVanChuyenSpinEdit.Value);
                tiente.TongTien = Convert.ToDouble(tongTienSpinEdit.Value);
                tiente.NgoaiTe = ngoaiTeComboBox.Text;
                if (CheckVAT.Checked)
                    tiente.VAT = 1.1;
                else
                {
                    tiente.VAT = 1;
                }

                db.SubmitChanges();
                MessageBox.Show(capnhat);
                var soluong = tb.SoLuong;
                double scrap = 0;
                var dsx = db.tbDonSanXuat_Averies.ToList();
                var ll = (from s in db.tbLanhLieus where s.IDLanhLieu == sCDTextEdit.Text select s).Single();
                foreach (var item in dsx)
                {
                    if (item.SO != txtTenSanPham.Text) continue;
                    if (soluong / item.SKU > 1000)
                        scrap = 0.02;
                    else if (soluong / item.SKU > 500)
                        scrap = 0.04;
                    else if (soluong / item.SKU > 300)
                        scrap = 0.06;
                    else if (soluong / item.SKU > 200)
                        scrap = 0.08;
                    else if (soluong / item.SKU > 100)
                        scrap = 0.12;
                    else if (soluong / item.SKU <= 100)
                        scrap = 0.21;
                    ll.LanhLieu = (int) ((1 + scrap) *
                                         (soluong * 1.1 + item.SKU * 5 + Math.Round((double) item.Qty / 500, 0) * 6 +
                                          15 + 15) * ((item.Length / 1000) + (item.SKU - 1) * 2 + 6) / 0.9144);
                    ll.SoLuongSanXuat = soluong;
                    ll.BuHao = 1.1;
                    ll.DonViTinh = "YARD";
                    db.SubmitChanges();
                }
                frmDonSanXuat_Avery_CapNhat_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Đơn hàng đã hoàn thành, không thể cập nhật");
            }

        }
    }
}