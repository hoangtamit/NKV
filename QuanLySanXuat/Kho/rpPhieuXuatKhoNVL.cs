namespace QuanLySanXuat.Kho
{
    public partial class rpPhieuXuatKhoNVL : DevExpress.XtraReports.UI.XtraReport
    {
        public rpPhieuXuatKhoNVL()
        {
            InitializeComponent();

        }

        public void databing()
        {
            xrMaPhieu.DataBindings.Add("Text", DataSource, "MaPhieu");
            xrTenVatLieu.DataBindings.Add("Text", DataSource, "TenHangHoa");
            DonViTinhtxt.DataBindings.Add("Text", DataSource, "DonViTinh");
            xrSoLuong.DataBindings.Add("Text", DataSource, "SoLuongXuat", "{0:#,#}");
            Ngaytxt.DataBindings.Add("Text", DataSource, "Ngay", "{0:dd/MM/yyyy}");
            xrXuatKho.DataBindings.Add("Text", DataSource, "Kho");
            xrSCD.DataBindings.Add("Text", DataSource, "SCD");
            xrQuyCach.DataBindings.Add("Text", DataSource, "QuyCach");
            xrBoPhan.DataBindings.Add("Text", DataSource, "BoPhan");
            xrTong.DataBindings.Add("Text", DataSource, "SoLuongXuat", "{0:#,#}");
            xrGhiChu.DataBindings.Add("Text", DataSource, "GhiChu");
            xrNhanVienXuat.DataBindings.Add("Text", DataSource, "NguoiQuanKho");
            xrLo.DataBindings.Add("Text", DataSource, "Lo");
            //Ngaytxt.DataBindings.Add("Text", DataSource, "Ngay", "{0:dd/MM/yyyy}");
        }

    }
}
