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

namespace QuanLySanXuat
{
    public partial class frmTaoTaiKhoan : XtraForm
    {
        NhanVienCtr nvCtr = new NhanVienCtr();
        private int flagluu = 0;
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            SearchLookup();
            phanquyen();
            databing();
        }

        public void SearchLookup()
        {
            tbNhanVienGridControl.DataSource = nvCtr.LoadAllData();

            // Bảng Bộ Phận
            var bpCtr = new BoPhanCtr();
            BoPhantxt.Properties.DataSource = bpCtr.LoadData();
            BoPhantxt.Properties.DisplayMember = "ID";
            BoPhantxt.Properties.ValueMember = "ID";
        }

        public void phanquyen()
        {
            btnLuu.Enabled = false;
            if (flagluu == 0)
                btnXoa.Enabled = true;
            else
            {
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
            }
        }
        public void databing()
        {
            maNhanVienTextEdit.DataBindings.Clear();
            maNhanVienTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "MaNhanVien");
            tenNhanVienTextEdit.DataBindings.Clear();
            tenNhanVienTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "TenNhanVien");
            taiKhoanTextEdit.DataBindings.Clear();
            taiKhoanTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "TaiKhoan");

            matKhauTextEdit.DataBindings.Clear();
            matKhauTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "MatKhau");
            BoPhantxt.DataBindings.Clear();
            BoPhantxt.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "BoPhan");
            chucVuTextEdit.DataBindings.Clear();
            chucVuTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "ChucVu");
            //gioiTinhTextEdit.DataBindings.Clear();
            //gioiTinhTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "GioiTinh");
            ngaySinhTextEdit.DataBindings.Clear();
            ngaySinhTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "NgaySinh");
            dienThoaiTextEdit.DataBindings.Clear();
            dienThoaiTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "DienThoai");

            tinhTrangTextEdit.DataBindings.Clear();
            tinhTrangTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "TinhTrang");
            diaChiTextEdit.DataBindings.Clear();
            diaChiTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "DiaChi");
            ghiChuTextEdit.DataBindings.Clear();
            ghiChuTextEdit.DataBindings.Add("text", tbNhanVienGridControl.DataSource, "GhiChu");
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            //matKhauTextEdit.Text = Md5(matKhauTextEdit.Text);
            //textEdit1.Text = Md5(textEdit1.Text);
            if (matKhauTextEdit.Text == textEdit1.Text) return;
            MessageBox.Show("Mật khẩu không trùng khớp");
            matKhauTextEdit.Focus();
        }

        private void tbNhanVienGridControl_Click(object sender, EventArgs e)
        {
            var gioitinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colGioiTinh).ToString();
            if (gioitinh == "Nam")
                gioiTinhTextEdit.SelectedIndex = 0;
            else
            {
                gioiTinhTextEdit.SelectedIndex = 1;
            }
            matKhauTextEdit.Text = string.Empty;
            try
            {
                var hnv = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colHinhNhanVien).ToString();
                pictureEdit1.Image = Image.FromFile(hnv);
            }
            catch (Exception)
            {
                //null
            }
            databing();
        }

        public string Md5(string str)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            var pass = "";
            var m_byte = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (var b in m_byte)
            {
                pass = pass + b.ToString("X");
            }
            return pass;

        }
     
        private void btnthem_Click(object sender, EventArgs e)
        {
            flagluu = 1;
            phanquyen();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flagluu = 2;
            phanquyen();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            if (flagluu == 1)
            {              
                var tb = new tbNhanVien();
                {
                    tb.MaNhanVien = maNhanVienTextEdit.Text;
                    tb.TenNhanVien = tenNhanVienTextEdit.Text;
                    tb.TaiKhoan = taiKhoanTextEdit.Text;
                    tb.MatKhau = Md5(matKhauTextEdit.Text);
                    tb.BoPhan = BoPhantxt.Text;
                    tb.NgaySinh = ngaySinhTextEdit.Text;
                    if (gioiTinhTextEdit.SelectedIndex == 1)
                        tb.GioiTinh = "Nam";
                    else
                    {
                        tb.GioiTinh = "Nữ";
                    }
                    tb.DiaChi = diaChiTextEdit.Text;
                    tb.DienThoai = dienThoaiTextEdit.Text;
                    tb.ChucVu = chucVuTextEdit.Text;
                    tb.TinhTrang = tinhTrangTextEdit.Text;
                    tb.GhiChu = ghiChuTextEdit.Text;
                }
                db.tbNhanViens.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show(PrintRibbon.themthanhcong);


                var phanquyen = new tbPhanQuyen();
                phanquyen.MaNhanVien = maNhanVienTextEdit.Text;
                phanquyen.NghiepVu = "False";
                phanquyen.ThietKe = "False";
                phanquyen.CTP = "False";
                phanquyen.CTF = "False";
                phanquyen.Offset = "False";
                phanquyen.TemVai = "False";
                phanquyen.SauIn = "False";
                phanquyen.KiemPham = "False";
                phanquyen.KhoBTP = "False";
                phanquyen.KhoNVL = "False";
                phanquyen.QuanLyChatLuong = "False";
                phanquyen.QuanLySanXuat = "False";
                phanquyen.DanhThiep = "False";
                phanquyen.KyThuatSo = "False";
                phanquyen.Sticker = "False";
                phanquyen.InChuViTinh = "False";
                db.tbPhanQuyens.InsertOnSubmit(phanquyen);
                db.SubmitChanges();

                flagluu = 0;
                frmTaoTaiKhoan_Load(sender, e);               
            }
            else if (flagluu == 2)
            {
                var tb = db.tbNhanViens.Single(s => s.MaNhanVien == maNhanVienTextEdit.Text);
                tb.TenNhanVien = tenNhanVienTextEdit.Text;
                tb.TaiKhoan = taiKhoanTextEdit.Text;
                tb.MatKhau = Md5(matKhauTextEdit.Text);
                tb.BoPhan = BoPhantxt.Text;
                tb.NgaySinh = ngaySinhTextEdit.Text;
                tb.GioiTinh = gioiTinhTextEdit.Text;
                tb.DiaChi = diaChiTextEdit.Text;
                tb.DienThoai = dienThoaiTextEdit.Text;
                tb.ChucVu = chucVuTextEdit.Text;
                tb.TinhTrang = tinhTrangTextEdit.Text;
                tb.GhiChu = ghiChuTextEdit.Text;
                db.SubmitChanges();
                MessageBox.Show(PrintRibbon.capnhat);
                flagluu = 0;
                frmTaoTaiKhoan_Load(sender, e);                
            }
        }
    }
}