using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySanXuat
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void phanquyen()
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmKhoNVLNhap")
            //{
            //    frmKhoNVLNhap frm = new frmKhoNVLNhap(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        string manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu;

        private void barButtonItem7_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmKhoBTP_TPNhap")
            //{
            //    frmKhoBTP_TPNhap frm = new frmKhoBTP_TPNhap(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();

            //}
        }

        private void barButtonItem8_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmKhoBTP_TPXuat")
            //{
            //    frmKhoBTP_TPXuat frm = new frmKhoBTP_TPXuat(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void barButtonItem11_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmMaHangHoa")
            //{
            //    frmMaHangHoa frm = new frmMaHangHoa();//manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmDonViTinh")
            //{
            //    frmDonViTinh frm = new frmDonViTinh();//manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmVatLieu")
            //{
            //    frmVatLieu frm = new frmVatLieu();//manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmNhaCungCap")
            //{
            //    frmNhaCungCap frm = new frmNhaCungCap();//manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmQuyCach")
            //{
            //    frmQuyCach frm = new frmQuyCach();//manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmSanXuat")
            //{
            //    frmSanXuat frm = new frmSanXuat(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
            
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmThietKe")
            //{
            //    frmThietKe frm = new frmThietKe(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmKhoBTP_TPTonKho")
            //{
            //    frmKhoBTP_TPTonKho frm = new frmKhoBTP_TPTonKho();// manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void CTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmCTP")
            //{
            //    frmCTP frm = new frmCTP(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmKichThuocGiay")
            //{
            //    frmKichThuocGiay frm = new frmKichThuocGiay();// manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void bbiOffset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmOffset")
            //{
            //    frmOffset frm = new frmOffset(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmThietKe")
            //{
            //    frmThietKe frm = new frmThietKe(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmKhoNVLTonKho")
            //{
            //    frmKhoNVLTonKho frm = new frmKhoNVLTonKho();// manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmKhoNVLXuat")
            //{
            //    frmKhoNVLXuat frm = new frmKhoNVLXuat(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }

        public frmMain(string manhanvien, string tennhanvien, string taikhoan, string matkhau, string ngaysinh,
            string gioitinh, string diachi, string dienthoai, string bophan, string chucvu, string tinhtrang, string ghichu)
        {
            InitializeComponent();
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.bophan = bophan;
            this.chucvu = chucvu;
            this.tinhtrang = tinhtrang;
            this.ghichu = ghichu;
            barStaticItemTenNhanVien.Caption = tennhanvien;
            GroupBoPhan.Caption = bophan;
        }

        public void OpenForm(Type typeform)
        {
            try
            {
                foreach (Form frm in MdiChildren)
                {
                    if (frm.GetType() == typeform)
                    {
                        frm.Activate();

                        return;
                    }
                }
                Form f = (Form)(Activator.CreateInstance(typeform));
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }


        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmDanhSachSanPham")
            //{
            //    frmDanhSachSanPham frm = new frmDanhSachSanPham(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //    //OpenForm(typeof(frmDanhSachSanPham));
            //}
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmDonSanXuat")
            {
                frmDonSanXuat frm = new frmDonSanXuat(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
                frm.MdiParent = this;
                frm.Show();

            }

        }

        private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmLanhLieu")
            //{
            //    frmLanhLieu frm = new frmLanhLieu(manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
    }
}

