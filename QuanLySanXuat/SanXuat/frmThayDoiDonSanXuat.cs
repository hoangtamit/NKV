using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLySanXuat.Control;
using static QuanLySanXuat.PrintRibbon;
namespace QuanLySanXuat
{
    public partial class frmThayDoiDonSanXuat : DevExpress.XtraEditors.XtraForm
    {
        private readonly VatLieuCtr vlCtr = new VatLieuCtr();
        private readonly KhoBTP_TPCtr khoBtpTpCtr = new KhoBTP_TPCtr();
        private string _scd;
        public frmThayDoiDonSanXuat(string scd)
        {
            InitializeComponent();
            _scd = scd;
        }

        private void frmThayDoiDonSanXuat_Load(object sender, EventArgs e)
        {
            SearchLookup();
            txtBoPhan.Text = null;
            txtPhuongPhapIn.Text = null;
            txtKho.Text = null;
            vatLieuComboBox.Text = null; 
        }

        public void SearchLookup()
        {
            //// Đơn sản xuất Avery
            //var dsxAveryCtr = new DonSanXuat_AveryCtr();
            //txtTenSanPham.Properties.DataSource = dsxAveryCtr.LoadData(); ;
            //txtTenSanPham.Properties.DisplayMember = "SO";
            //txtTenSanPham.Properties.ValueMember = "SO";

            ////Bảng Phiên Bản
            //var pbCtr = new PhienBanCtr();
            //txtPhienBan.Properties.DataSource = pbCtr.LoadData();
            //txtPhienBan.Properties.DisplayMember = "ID";
            //txtPhienBan.Properties.ValueMember = "ID";

            //// Bảng Khách Hàng
            //var khCtr = new KhachHangCtr();
            //txtKhachHang.Properties.DataSource = khCtr.LoadData1C();
            //txtKhachHang.Properties.DisplayMember = "TenKhachHang";
            //txtKhachHang.Properties.ValueMember = "TenKhachHang";

            //// Bảng Loại Sản Phẩm
            //var lspCtr = new LoaiSanPhamCtr();
            //txtLoaiSanPham.Properties.DataSource = lspCtr.LoadData();
            //txtLoaiSanPham.Properties.DisplayMember = "ID";
            //txtLoaiSanPham.Properties.ValueMember = "ID";

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbSanXuats where s.IDSanXuat == _scd select s).Single();
            lst.BoPhanSX = txtBoPhan.Text;
            lst.PhuongPhapInSX = txtPhuongPhapIn.Text;
            lst.KhoSX = txtKho.Text;
            lst.VatLieuSX = vatLieuComboBox.Text;
            db.SubmitChanges();
            MessageBox.Show("Đơn hàng thay đổi thành công");

        }

        private void txtKho_EditValueChanged(object sender, EventArgs e)
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
        }
    }
}