using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeParser;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;

namespace QuanLySanXuat
{
    public partial class rpDonSanXuat : XtraReport
    {
        private QrCodeEncodingOptions options;
        private BarcodeWriter _writer;
        public rpDonSanXuat()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void Detail_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblThoiGianXuongDon.Text = DateTime.Now.ToString();
            if (label3.Text == "( HÀNG BÙ )" || label3.Text == "( GẤP )")
                label3.ForeColor = Color.Red;
      }

        private void lblSCD_TextChanged(object sender, EventArgs e)
        {
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
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == lblSCD.Text select s).ToList();
            foreach (var item in lst)
            {
                var thongtindonhang = "SCD : " + item.SCD +
                    "\n" + "Mã Đơn Hàng : " + item.MaDonHang +
                    "\n" + "Tên Khách Hàng : " + item.TenKhachHang +
                    "\n" + "Tên Sản Phẩm : " + item.TenSanPham +
                    "\n" + "Ngày Xuống Đơn : " + item.NgayXuongDon.Value.ToShortDateString().ToString() +
                    "\n" + "Ngày Giao Hàng : " + item.NgayGiaoHang.Value.ToShortDateString().ToString() +
                    "\n" + "Số Lượng : " + item.SoLuong +
                    "\n" + "Bộ Phận : " + item.BoPhan +
                    "\n" + "Vật Liệu : " + item.VatLieu;

                var qr = new BarcodeWriter
                {
                    Options = options,
                    Format = BarcodeFormat.QR_CODE
                };
                var result = new Bitmap(qr.Write(thongtindonhang));
                xrBarCodeQR.Image = result;

                try
                {
                    ptbHinhMatPhai.Image = Image.FromFile(item.HinhMatPhai);
                    ptbHinhMatPhai.Borders = DevExpress.XtraPrinting.BorderSide.All;
                    ptbHinhMatPhai.BorderWidth = 1;
                }
                catch
                {
                    ptbHinhMatPhai.Image = null;
                }

                try
                {
                    ptbHinhMatTrai.Image = Image.FromFile(item.HinhMatTrai);
                    ptbHinhMatTrai.Borders = DevExpress.XtraPrinting.BorderSide.All;
                    ptbHinhMatTrai.BorderWidth = 1;
                }
                catch
                { ptbHinhMatTrai.Image = null; }

                if (ptbHinhMatPhai.Image == null && ptbHinhMatTrai.Image == null)
                {
                    table3.Width = 785;
                }
                else if (ptbHinhMatPhai.Image == null && ptbHinhMatTrai.Image != null)
                {   
                    table3.Width = 605;

                }
                else if (ptbHinhMatPhai.Image != null && ptbHinhMatTrai.Image == null)
                {
                    ptbHinhMatPhai.Location = new Point(615,587);
                    table3.Width = 605;
                }
            }

           
        }
    }
}
