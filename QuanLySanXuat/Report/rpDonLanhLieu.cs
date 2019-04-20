using System;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class rpDonLanhLieu : XtraReport
    {
        public rpDonLanhLieu(string scd)
        {
            InitializeComponent();
            xrIDLanhLieu.Text = scd;
        }

        public rpDonLanhLieu()
        {
        }

        private void xrIDLanhLieu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = db.DonSanXuat_LanhLieu_View().Single(s => s.IDLanhLieu == xrIDLanhLieu.Text);
                var sanxuat = (from s in db.tbSanXuats where s.IDSanXuat == xrIDLanhLieu.Text select s).Single();
                var dsx = (from s in db.tbDonSanXuats where s.SCD == xrIDLanhLieu.Text select s).Single();
                if (lst.LanhLieu == null) return;
                xrTableCell13.Text = "01";
                if (sanxuat.BoPhanSX != null)
                {
                    lst.BoPhan = sanxuat.BoPhanSX;
                    lst.PhuongPhapIn = sanxuat.PhuongPhapInSX;
                }
                if (sanxuat.VatLieuSX != null)
                {
                    lst.VatLieu = sanxuat.VatLieuSX;
                    lst.Kho = sanxuat.KhoSX;
                }
                if (lst.BoPhan == "OFFSET")
                {
                    xrBoPhan.Text = lst.BoPhan;
                    xrDonViTinh.Text = lst.DonViTinh;                  
                    xrSoLuong.Text = Convert.ToInt32(lst.LanhLieu).ToString("#,#");
                    lblNgay.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");
                    if (lst.Kho == "NGUYÊN VẬT LIỆU")
                    {
                        var khoGiayIn = (from a in db.tbKhoGiayIns where a.KhoIn == lst.KhoGiayIn && a.CatGiay == lst.CatGiay select a).Single();
                        xrVatLieu.Text = lst.VatLieu;
                        xrMucDich.Text = khoGiayIn.GiayLon;
                    }
                    else
                    {
                        xrVatLieu.Text = lst.VatLieu ;
                        xrMucDich.Text = lst.KhoGiayIn;
                    }
                    xrIDLanhLieu2.Text = xrIDLanhLieu.Text;
                    xrSTT2.Text = "01";
                    xrBoPhan2.Text = "CTP";
                    xrVatLieu2.Text = lst.MaDonHang;
                    xrMucDich2.Text = "605*745";
                    xrDonViTinh2.Text = lst.DonViTinh;
                    xrSoLuong2.Text = lst.CtpOffset.ToString();
                    lblNgay2.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");
                }
                else if (lst.BoPhan == "DANH THIẾP")
                {
                    xrBoPhan.Text = lst.BoPhan;
                    xrVatLieu.Text = "Bản thể " + lst.VatLieu;
                    xrDonViTinh.Text = lst.DonViTinh;
                    xrSoLuong.Text = Convert.ToInt32(lst.LanhLieu).ToString("#,#");
                    lblNgay.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");

                    xrIDLanhLieu2.Text = xrIDLanhLieu.Text;
                    xrSTT2.Text = "01";
                    xrBoPhan2.Text = "CTP";
                    xrVatLieu2.Text = lst.MaDonHang;
                    xrMucDich2.Text = "440*460";
                    xrDonViTinh2.Text = lst.DonViTinh;
                    xrSoLuong2.Text = lst.CtpOffset.ToString();
                    lblNgay2.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");
                }
                else if (lst.BoPhan == "TEM VẢI")
                {
                    xrBoPhan.Text = lst.BoPhan;
                    xrVatLieu.Text = lst.VatLieu;
                    xrDonViTinh.Text = lst.DonViTinh;
                    xrSoLuong.Text = Convert.ToInt32(lst.LanhLieu).ToString("#,#");
                    lblNgay.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");

                    lblNgay2.Text = "NGÀY........THÁNG........NĂM........";

                }
                else if (lst.BoPhan == "STICKER")
                {
                    xrBoPhan.Text = lst.BoPhan;
                    xrVatLieu.Text = lst.VatLieu;
                    xrDonViTinh.Text = lst.DonViTinh;
                    xrSoLuong.Text = Convert.ToInt32(lst.LanhLieu).ToString("#,#");
                    lblNgay.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");

                    lblNgay2.Text = "NGÀY........THÁNG........NĂM........";

                }
                else if (lst.BoPhan == "KỸ THUẬT SỐ")
                {
                    xrBoPhan.Text = lst.BoPhan;
                    xrVatLieu.Text = "Bản Thể " + lst.VatLieu;
                    xrDonViTinh.Text = lst.DonViTinh;
                    xrMucDich.Text = lst.KhoGiayIn;
                    xrSoLuong.Text = Convert.ToInt32(lst.LanhLieu).ToString("#,#");
                    lblNgay.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");

                    lblNgay2.Text = "NGÀY........THÁNG........NĂM........";

                }
                else if (lst.BoPhan == "IN CHỮ VI TÍNH")
                {
                    xrBoPhan.Text = lst.BoPhan;
                    if (lst.LoaiSanPham == "TEM GIẤY")
                    {
                        xrVatLieu.Text = "Bản Thể " + lst.VatLieu;
                        xrDonViTinh.Text = lst.DonViTinh;
                        xrMucDich.Text = lst.KichThuoc;
                        xrSoLuong.Text = Convert.ToInt32(lst.LanhLieu).ToString("#,#");
                    }
                    else if (lst.LoaiSanPham == "STICKER")
                    {
                        xrVatLieu.Text = lst.VatLieu;
                        xrDonViTinh.Text = lst.DonViTinh;
                        xrSoLuong.Text = Convert.ToInt32(lst.LanhLieu).ToString("#,#");
                    }

                    lblNgay.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");
                    lblNgay2.Text = "NGÀY........THÁNG........NĂM........";
                }
                else if (lst.BoPhan == "SAU IN")
                {
                    var khoGiayIn = (from a in db.tbKhoGiayIns where a.KhoIn == lst.KhoGiayIn && a.CatGiay == lst.CatGiay select a).Single();
                    xrBoPhan.Text = lst.BoPhan;
                    xrVatLieu.Text = lst.VatLieu + " " + khoGiayIn.GiayLon;
                    xrDonViTinh.Text = lst.DonViTinh;
                    xrSoLuong.Text = Convert.ToInt32(lst.LanhLieu).ToString("#,#");
                    lblNgay.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");

                    lblNgay2.Text = "NGÀY........THÁNG........NĂM........";
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
