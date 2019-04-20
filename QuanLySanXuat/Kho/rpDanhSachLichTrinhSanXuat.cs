namespace QuanLySanXuat.Kho
{
    public partial class rpDanhSachLichTrinhSanXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDanhSachLichTrinhSanXuat()
        {
            InitializeComponent();
        }


        public void databingding()
        {
            xrTenKhachHang.DataBindings.Add("Text", DataSource, "TenKhachHang");
            xrNgayXuongDon.DataBindings.Add("Text", DataSource, "NgayXuongDon", "{0:dd/MM/yyyy}");
            xrNgayXuatKho.DataBindings.Add("Text", DataSource, "Ngay", "{0:dd/MM/yyyy}");
            xrNgayGiaoHang.DataBindings.Add("Text", DataSource, "NgayGiaoHang", "{0:dd/MM/yyyy}");
            xrTenSanPham.DataBindings.Add("Text", DataSource, "TenSanPham");
            xrBoPhan.DataBindings.Add("Text", DataSource, "BoPhan");
            xrSCD.DataBindings.Add("Text", DataSource, "SCD");
            xrMaDonHang.DataBindings.Add("Text", DataSource, "MaDonHang");
            xrKichThuoc.DataBindings.Add("Text", DataSource, "KichThuoc");
            xrSoLuong.DataBindings.Add("Text", DataSource, "SoLuong" , "{0:#,#}");
            xrTong.DataBindings.Add("Text", DataSource, "SoLuong", "{0:#,#}");
            xrVatLieu.DataBindings.Add("Text", DataSource, "VatLieu");
            xrQuyCach.DataBindings.Add("Text", DataSource, "QuyCach");
            xrLo.DataBindings.Add("Text", DataSource, "Lo");

        }

    }
}
