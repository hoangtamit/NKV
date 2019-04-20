namespace QuanLySanXuat.Kho
{
    public partial class rpPhieuNhapKhoNVL : DevExpress.XtraReports.UI.XtraReport
    {
        public rpPhieuNhapKhoNVL()//string id, NhanVienObj obj)
        {
            InitializeComponent();
            //var db = new MyDBContextDataContext();
            //var nhaCungCap = (from s in db.tbNhaCungCaps where s.IDNhaCungCap == 1 select s).Single();
            //NhapKhotxt.Text = nhaCungCap.TenNhaCungCap;

        }

        public void databing()
        {
            //Sotxt.DataBindings.AddRange(new[] { new XRBinding("Text", DataSource, "IDKhoNVL") });
            Sotxt.DataBindings.Add("Text", DataSource, "MaPhieu");
            TenVatLieutxt.DataBindings.Add("Text", DataSource, "TenHangHoa");
            DonViTinhtxt.DataBindings.Add("Text", DataSource, "DonViTinh");
            SoLuongtxt.DataBindings.Add("Text", DataSource, "SoLuongNhap", "{0:#,#}");
            Ngaytxt.DataBindings.Add("Text", DataSource, "Ngay", "{0:dd/MM/yyyy}");
            NhaCungCaptxt.DataBindings.Add("Text", DataSource, "NhaCungCap");
            xrTong.DataBindings.Add("Text", DataSource, "SoLuongNhap", "{0:#,#}");
            //xrKho.DataBindings.Add("Text", DataSource, "Kho");
            xrQuyCach.DataBindings.Add("Text", DataSource, "QuyCach");
            xrMaHang.DataBindings.Add("Text", DataSource, "MaHang");
            xrMaAvery.DataBindings.Add("Text", DataSource, "MaAD");
            NhapKhotxt.DataBindings.Add("Text", DataSource, "Kho");
            xrGhiChu.DataBindings.Add("Text", DataSource, "GhiChu");
            xrNhanVienNhap.DataBindings.Add("Text", DataSource, "NguoiQuanKho");
            xrLo.DataBindings.Add("Text", DataSource, "Lo");
        }

    }
}
