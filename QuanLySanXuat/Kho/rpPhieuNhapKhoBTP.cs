namespace QuanLySanXuat.Kho
{
    public partial class rpPhieuNhapKhoBTP : DevExpress.XtraReports.UI.XtraReport
    {
        public rpPhieuNhapKhoBTP()//string id, NhanVienObj obj)
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
            xrKhachHang.DataBindings.Add("Text", DataSource, "TenKhachHang");
            DonViTinhtxt.DataBindings.Add("Text", DataSource, "DonViTinh");
            xrSoLuongKhachHang.DataBindings.Add("Text", DataSource, "SoLuongNhapKhachHang", "{0:#,#}");
            xrSoLuongCongTy.DataBindings.Add("Text", DataSource, "SoLuongNhapCongTy", "{0:#,#}");
            Ngaytxt.DataBindings.Add("Text", DataSource, "Ngay", "{0:dd/MM/yyyy}");
            xrBoPhanNhap.DataBindings.Add("Text", DataSource, "BoPhan");
            xrTongSLKH.DataBindings.Add("Text", DataSource, "SoLuongNhapKhachHang", "{0:#,#}");
            xrTongSLCT.DataBindings.Add("Text", DataSource, "SoLuongNhapCongTy", "{0:#,#}");
            //xrKho.DataBindings.Add("Text", DataSource, "Kho");
            xrQuyCach.DataBindings.Add("Text", DataSource, "QuyCach");
            xrSCD.DataBindings.Add("Text", DataSource, "SCD");
            xrTenSanPham.DataBindings.Add("Text", DataSource, "TenSanPham");
            NhapKhotxt.DataBindings.Add("Text", DataSource, "Kho");
            xrGhiChu.DataBindings.Add("Text", DataSource, "GhiChu");
            xrNhanVienNhap.DataBindings.Add("Text", DataSource, "NguoiQuanKho");
            xrLo.DataBindings.Add("Text", DataSource, "Lo");
            
        }

    }
}
