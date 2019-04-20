using System;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using static QuanLySanXuat.PrintRibbon;
using QuanLySanXuat.Object;
namespace QuanLySanXuat
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private NhanVienObj nvObj = new NhanVienObj();
    
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatkhau.Text)) return;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbNhanViens where s.TaiKhoan == txtTaikhoan.Text.Trim() && s.MatKhau == Md5(txtMatkhau.Text) & s.TinhTrang != "Nghỉ" select s).ToList();
            foreach (var item in lst)
            {
                if (item.ToString().Length <= 0) continue;
                Visible = false;
                //var frm = new frmCha(item.MaNhanVien, item.TenNhanVien, item.TaiKhoan, item.MatKhau,
                //    item.NgaySinh, item.GioiTinh, item.DiaChi,
                //    item.DienThoai, item.BoPhan, item.ChucVu, item.TinhTrang, item.GhiChu);
                nvObj.Manhanvien = item.MaNhanVien;
                nvObj.Tennhanvien = item.TenNhanVien;
                nvObj.Taikhoan = item.TaiKhoan;
                nvObj.Matkhau = item.MatKhau;
                nvObj.Ngaysinh = item.NgaySinh;
                nvObj.Gioitinh = item.GioiTinh;
                nvObj.Diachi = item.DiaChi;
                nvObj.Dienthoai = item.DienThoai;
                nvObj.Bophan = item.BoPhan;
                nvObj.Chucvu = item.ChucVu;
                nvObj.Tinhtrang = item.TinhTrang;
                nvObj.Ghichu = item.GhiChu;
                nvObj.Giaodien = item.GiaoDien;
                nvObj.Thongbao = item.ThongBao;
                var frm = new frmCha(nvObj);
                MessageBox.Show(dangnhapthanhcong);
                Close();
                frm.ShowDialog();
                break;
            }
            if (lst.Count == 0)
                MessageBox.Show(dangnhapthatbai);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string Md5(string str)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            var pass = "";
            var mByte = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (var b in mByte)
            {
                pass = pass + b.ToString("X");
            }
            return pass;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}