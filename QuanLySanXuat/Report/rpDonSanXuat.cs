using System;
using System.Drawing;
using System.Linq;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Object;
using ZXing;
using ZXing.QrCode;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class rpDonSanXuat : XtraReport
    {
        private readonly NhanVienObj nvObj = new NhanVienObj();
        private QrCodeEncodingOptions options;
        private BarcodeWriter _writer;

        private string _scd;

        public rpDonSanXuat(string scd)
        {
            InitializeComponent();
            lblThoiGianXuongDon.Text = DateTime.Now.ToString();
            if (PhienBantxt.Text == "( HÀNG BÙ )" || PhienBantxt.Text == "( GẤP )")
                PhienBantxt.ForeColor = Color.Red;
            _scd = scd;
            var db = new MyDBContextDataContext();

            var sanxuat = db.tbSanXuats.Single(s => s.IDSanXuat == _scd);
            txtBoPhanSanXuat.Text = sanxuat.BoPhanSX;
            txtPhuongPhapInSanXuat.Text = sanxuat.PhuongPhapInSX;
            txtKhoSanXuat.Text = sanxuat.KhoSX;
            txtVatLieuSanXuat.Text = sanxuat.VatLieuSX;

            var donsanxuat = db.tbDonSanXuats.Single(s => s.SCD == _scd);
            lblSCD.Text = donsanxuat.SCD;
            PhienBantxt.Text = donsanxuat.PhienBan;
            NhanVienNghiepVutxt.Text = donsanxuat.NhanVienNghiepVu;
            MaDonHangtxt.Text = donsanxuat.MaDonHang;
            NgayXuongDontxt.Text = donsanxuat.NgayXuongDon.Value.ToShortDateString();
            NgayGiaoHangtxt.Text = donsanxuat.NgayGiaoHang.Value.ToShortDateString();
            TenKhachHangtxt.Text = donsanxuat.TenKhachHang;
            TenSanPhamtxt.Text = donsanxuat.TenSanPham;
            KichThuoctxt.Text = donsanxuat.KichThuoc;
            SoLuongtxt.Text = donsanxuat.SoLuong.Value.ToString("N0");
            LoaiSanPhamtxt.Text = donsanxuat.LoaiSanPham;
            BoPhantxt.Text = donsanxuat.BoPhan;
            PhuongPhapIntxt.Text = donsanxuat.PhuongPhapIn;
            Khotxt.Text = donsanxuat.Kho;
            VatLieutxt.Text = donsanxuat.VatLieu;
            MauMatPhaitxt.Text = donsanxuat.MauMatPhai;
            MauMatTraitxt.Text = donsanxuat.MauMatTrai;
            GiaCongMatPhaitxt.Text = donsanxuat.GiaCongMatPhai;
            GiaCongMatTraitxt.Text = donsanxuat.GiaCongMatTrai;
            BeHoptxt.Text = donsanxuat.PhuongPhapCat;
            BoGoctxt.Text = donsanxuat.BoGoc;
            DucLotxt.Text = donsanxuat.DucLo;
            DuongChamCattxt.Text = donsanxuat.ChamCatDapHop;
            Khactxt.Text = donsanxuat.Khac;
            xrLoaiChi.Text = donsanxuat.LoaiChi;
            xrSKU.Text = donsanxuat.SKU.ToString();
            MaVachtxt.Text = donsanxuat.InChu_MaVach;
            GiaCongSautxt.Text = donsanxuat.GiaCongSau;
            xrDoDaiChi.Text = donsanxuat.DoDai;
            if (donsanxuat.BTPSoLuongTonKho != null)
                BTPKhachHangtxt.Text = donsanxuat.BTPSoLuongTonKho.Value.ToString("N0");
            if (donsanxuat.TPSoLuongTonKho != null)
                TPKhachHangtxt.Text = donsanxuat.TPSoLuongTonKho.Value.ToString("N0");
            if (donsanxuat.BTPTonKhoCongTy != null)
                BTPCongTytxt.Text = donsanxuat.BTPTonKhoCongTy.Value.ToString("N0");
            if (donsanxuat.TPTonKhoCongTy != null)
                TPCongTytxt.Text = donsanxuat.TPTonKhoCongTy.Value.ToString("N0");
            ChuYtxt.Text = donsanxuat.ChuY;

            var lanhlieu = db.tbLanhLieus.Single(s => s.IDLanhLieu == _scd);
            KhoGiayIntxt.Text = lanhlieu.KhoGiayIn;
            CatGiaytxt.Text = lanhlieu.CatGiay;
            CTPtxt.Text = lanhlieu.CtpOffset.ToString();
            if (lanhlieu.SoLuongSanXuat != null)
                SoLuongSanXuattxt.Text = lanhlieu.SoLuongSanXuat.Value.ToString("N0");
            if (lanhlieu.BuHao != null)
                BuHaotxt.Text = lanhlieu.BuHao.Value.ToString("#.##");
            if (lanhlieu.SoLuongDanTrang != null)
                SoLuongDanTrangtxt.Text = lanhlieu.SoLuongDanTrang.Value.ToString("N0");
            SoLuongToIntxt.Text = lanhlieu.SoTrangIn;
            try
            {
                if (donsanxuat.BoPhan == PrintRibbon.offset || donsanxuat.BoPhan == PrintRibbon.sauin)
                {
                    if (donsanxuat.Kho == "NGUYÊN VẬT LIỆU")
                    {
                        var khoGiayIn = (from a in db.tbKhoGiayIns
                            where a.KhoIn == lanhlieu.KhoGiayIn && a.CatGiay == lanhlieu.CatGiay
                            select a).Single();
                        LanhLieutxt.Text = Convert.ToInt32(lanhlieu.LanhLieu).ToString("#,#") + " " +
                                           lanhlieu.DonViTinh + " (" + donsanxuat.VatLieu + ") " + " " +
                                           khoGiayIn.GiayLon;
                    }
                    else
                    {
                        LanhLieutxt.Text = Convert.ToInt32(lanhlieu.LanhLieu).ToString("#,#") + " " +
                                           lanhlieu.DonViTinh + " (" + donsanxuat.VatLieu + ") " + KhoGiayIntxt.Text;
                    }
                }
                else if (donsanxuat.BoPhan == PrintRibbon.temvai || donsanxuat.BoPhan == PrintRibbon.danhthiep ||
                         donsanxuat.BoPhan == PrintRibbon.sticker || donsanxuat.BoPhan == PrintRibbon.inchu)
                {
                    LanhLieutxt.Text = Convert.ToInt32(lanhlieu.LanhLieu).ToString("#,#") + " " + lanhlieu.DonViTinh;
                }
                else if (donsanxuat.BoPhan == PrintRibbon.kts)
                {
                    LanhLieutxt.Text = Convert.ToInt32(lanhlieu.LanhLieu).ToString("#,#") + " " + lanhlieu.DonViTinh +
                                       " " + lanhlieu.KhoGiayIn;
                }
            }
            catch (Exception)
            {
                //null
            }

            lblNhanVienXuongDon.Text = lanhlieu.NhanVienSanXuat;

            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 85,
                Height = 85,
            };
            _writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = options
            };

            var thongtindonhang = "SCD : " + donsanxuat.SCD +
                                  "\n" + "Mã Đơn Hàng : " + donsanxuat.MaDonHang +
                                  "\n" + "Tên Khách Hàng : " + donsanxuat.TenKhachHang +
                                  "\n" + "Tên Sản Phẩm : " + donsanxuat.TenSanPham +
                                  "\n" + "Ngày Xuống Đơn : " +
                                  donsanxuat.NgayXuongDon.Value.ToShortDateString().ToString() +
                                  "\n" + "Ngày Giao Hàng : " +
                                  donsanxuat.NgayGiaoHang.Value.ToShortDateString().ToString() +
                                  "\n" + "Số Lượng : " + donsanxuat.SoLuong +
                                  "\n" + "Bộ Phận : " + donsanxuat.BoPhan +
                                  "\n" + "Vật Liệu : " + donsanxuat.VatLieu;

            var qr = new BarcodeWriter
            {
                Options = options,
                Format = BarcodeFormat.QR_CODE
            };
            var result = new Bitmap(qr.Write(thongtindonhang));
            xrBarCodeQR.Image = result;
            try
            {
                ptbHinhMatPhai.Image = Image.FromFile(donsanxuat.HinhMatPhai);
                ptbHinhMatPhai.Borders = DevExpress.XtraPrinting.BorderSide.All;
                ptbHinhMatPhai.BorderWidth = 1;
            }
            catch
            {
                ptbHinhMatPhai.Image = null;
            }

            try
            {
                ptbHinhMatTrai.Image = Image.FromFile(donsanxuat.HinhMatTrai);
                ptbHinhMatTrai.Borders = DevExpress.XtraPrinting.BorderSide.All;
                ptbHinhMatTrai.BorderWidth = 1;
            }
            catch
            {
                ptbHinhMatTrai.Image = null;
            }

            if (txtBoPhanSanXuat.Text == "" & txtKhoSanXuat.Text == "")
            {

                lblSanXuat.Visible = false;
                GroupSanXuat.Visible = false;

                lblGiaCong.Location = new Point(0, 202);
                GroupGiaCong.Location = new Point(0, 220);

                lblKho.Location = new Point(0, 432);
                GroupTonKho.Location = new Point(0, 450);

                lblChuY.Location = new Point(0, 522);

                GroupChuY.Location = new Point(0, 540);
                ptbHinhMatPhai.Location = new Point(440, 540);
                ptbHinhMatTrai.Location = new Point(615, 540);

                lblLieuSanXuat.Location = new Point(0, 777);
                GroupLieuSanXuat.Location = new Point(0, 797);

                lblNguoiXuongDon.Location = new Point(0, 904);
                lblNhanVienXuongDon.Location = new Point(149, 904);
                lblThoiGian.Location = new Point(406, 904);
                lblThoiGianXuongDon.Location = new Point(574, 904);

                if (ptbHinhMatPhai.Image == null && ptbHinhMatTrai.Image == null)
                {
                    GroupChuY.Width = 785;
                }
                else if (ptbHinhMatPhai.Image == null && ptbHinhMatTrai.Image != null)
                {
                    GroupChuY.Width = 605;

                }
                else if (ptbHinhMatPhai.Image != null && ptbHinhMatTrai.Image == null)
                {
                    ptbHinhMatPhai.Location = new Point(615, 540);
                    GroupChuY.Width = 605;
                }
            }
            else
            {
                if (txtBoPhanSanXuat.Text != "")
                {
                    BoPhantxt.Text = string.Empty;
                    PhuongPhapIntxt.Text = string.Empty;
                }

                if (txtKhoSanXuat.Text != "")
                {
                    Khotxt.Text = string.Empty;
                    VatLieutxt.Text = string.Empty;
                }

                if (ptbHinhMatPhai.Image == null && ptbHinhMatTrai.Image == null)
                {
                    GroupChuY.Width = 785;
                }
                else if (ptbHinhMatPhai.Image == null && ptbHinhMatTrai.Image != null)
                {
                    GroupChuY.Width = 605;

                }
                else if (ptbHinhMatPhai.Image != null && ptbHinhMatTrai.Image == null)
                {
                    ptbHinhMatPhai.Location = new Point(615, 621);
                    GroupChuY.Width = 605;
                }



            }

        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void lblSCD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var danhsach = (from s in db.tbDonSanXuat_Averies where s.scd == lblSCD.Text select s).ToList();
                foreach (var item in danhsach)
                {
                    switch (item.DanhSach)
                    {
                        case 1:
                            xrDanhSach.Image = Image.FromFile("Images\\1.png");
                            break;
                        case 2:
                            xrDanhSach.Image = Image.FromFile("Images\\2.png");
                            break;
                        case 3:
                            xrDanhSach.Image = Image.FromFile("Images\\3.png");
                            break;
                        case 4:
                            xrDanhSach.Image = Image.FromFile("Images\\4.png");
                            break;
                    }
                    break;
                }

            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
