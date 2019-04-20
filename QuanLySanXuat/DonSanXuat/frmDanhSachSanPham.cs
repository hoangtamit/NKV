using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.DonSanXuat
{
    internal partial class frmDanhSachSanPham : XtraForm
    {
        private ConnectSQL con = new ConnectSQL();
        private DataTable dt = new DataTable();
        private readonly NhanVienObj nvObj = new NhanVienObj();
        public frmDanhSachSanPham(NhanVienObj nvobj)
        {
            InitializeComponent();
            nvObj = nvobj;
        }

        private int flagluu;

        private void btnsua_Click(object sender, EventArgs e)
        {
            flagluu = 2;
            DisEnl(true);
            //risID.Buttons[0].Visible = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDanhSachSanPham_Load(sender, e);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var scd = "0";
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
                var frm = new frmDonSanXuat_Them(scd, lst.MaSanPham,nvObj);// manhanvien, tennhanvien, taikhoan, matkhau, ngaysinh, gioitinh, diachi, dienthoai, bophan, chucvu, tinhtrang, ghichu);
                frm.ShowDialog();
            }
            catch
            {
                // ignored
            }

            frmDanhSachSanPham_Load(sender, e);
        }

        private void ptbHinhMatPhai_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
                if (string.IsNullOrEmpty(lst.HinhMatPhai)) return;
                Process.Start(lst.HinhMatPhai);
            }
            catch
            {
                // ignored
            }
        }

        private void ptbHinhMatTrai_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
                if (string.IsNullOrEmpty(lst.HinhMatTrai)) return;
                Process.Start(lst.HinhMatTrai);
            }
            catch
            {
                // ignored
            }
        }
        private void ptbHinhKhuon_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
                if (string.IsNullOrEmpty(lst.HinhKhuon)) return;
                Process.Start(lst.HinhKhuon);
            }
            catch
            {
                // ignored
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = PrintRibbon.dinhdanghinh;
            open.FilterIndex = 1;
            if (open.ShowDialog() != DialogResult.OK) return;
            if (!open.CheckFileExists) return;
            //string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 1));
            var correctfilename = Path.GetFileName(open.FileName);
            var paths = "Images\\" + correctfilename;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
            try
            {                        
                File.Copy(open.FileName, paths, true);
                lst.HinhMatPhai = paths;
                db.SubmitChanges();
                ptbHinhMatPhai.Image = Image.FromFile(paths);
                MessageBox.Show("Upload " + correctfilename + " thành công");
            }
            catch
            {
                MessageBox.Show("Hình " + correctfilename + " đã tồn tại");
                lst.HinhMatPhai = paths;
                db.SubmitChanges();
                ptbHinhMatPhai.Image = Image.FromFile(paths);
            }
            frmDanhSachSanPham_Load(sender, e);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = PrintRibbon.dinhdanghinh;
            open.FilterIndex = 1;
            if (open.ShowDialog() != DialogResult.OK) return;
            if (!open.CheckFileExists) return;
            var correctfilename = Path.GetFileName(open.FileName);
            var paths = "Images\\" + correctfilename;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
            try
            {
                File.Copy(open.FileName, paths, true);
                lst.HinhMatTrai = paths;
                db.SubmitChanges();
                ptbHinhMatTrai.Image = Image.FromFile(paths);
                MessageBox.Show("Upload " + correctfilename + " thành công");
            }
            catch
            {
                MessageBox.Show("Hình " + correctfilename + " đã tồn tại");
                lst.HinhMatTrai = paths;
                db.SubmitChanges();
                ptbHinhMatTrai.Image = Image.FromFile(paths);
            }
            frmDanhSachSanPham_Load(sender, e);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = PrintRibbon.dinhdanghinh;
            open.FilterIndex = 1;
            if (open.ShowDialog() != DialogResult.OK) return;
            if (!open.CheckFileExists) return;
            //string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 1));
            var correctfilename = Path.GetFileName(open.FileName);
            var paths = "Images\\" + correctfilename;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
            try
            {
                File.Copy(open.FileName, paths, true);
                lst.HinhKhuon = paths;
                db.SubmitChanges();
                ptbHinhKhuon.Image = Image.FromFile(paths);
                MessageBox.Show("Upload " + correctfilename + " thành công");
            }
            catch
            {
                MessageBox.Show("Hình " + correctfilename + " đã tồn tại");
                lst.HinhKhuon = paths;
                db.SubmitChanges();
                ptbHinhKhuon.Image = Image.FromFile(paths);
            }
            frmDanhSachSanPham_Load(sender, e);
        }

        

        private string SinhMaTuDong(DataTable dt)
        {
            var coso = 0;
            var count = dt.Rows.Count;
            if (count == 0)
                coso = 1;
            else
            {
                if (count >= 2)
                {
                    for (var i = 0; i < count - 1; i++)
                    {
                        if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(0, 4)) - int.Parse(dt.Rows[i][0].ToString().Substring(0,4)) > 1)
                        {
                            coso = int.Parse(dt.Rows[i][0].ToString().Substring(0,4)) + 1;
                            break;
                        }
                        coso = int.Parse(dt.Rows[count - 1][0].ToString().Substring(0,4)) + 1;
                    }
                }
                else
                {
                    if (int.Parse(dt.Rows[0][0].ToString().Substring(0,4)) == 1)
                        coso = 2;
                    else
                        coso = 1;
                }
            }
            if (coso < 10)
                return "000" + coso;
            if (coso < 100)
                return "00" + coso;
            if (coso < 1000)
                return "0" + coso;
            return coso.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            if (MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
                db.tbDanhSachSanPhams.DeleteOnSubmit(lst);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công");
                frmDanhSachSanPham_Load(sender, e);
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flagluu != 1)
            {
                if (flagluu != 2) return;
                var db = new MyDBContextDataContext();
                var tb = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s)
                    .Single();
                tb.TenKhachHang = txtKhachHang.Text;
                tb.TenSanPham = TENSANPHAMTextEdit.Text;
                tb.LoaiSanPham = txtLoaiSanPham.Text;
                tb.PhuongPhapIn = txtPhuongPhapIn.Text;
                tb.KichThuoc = KICHTHUOCTextEdit.Text;
                tb.DonViTinh = txtDonViTinh.Text;
                tb.GiaCongMatPhai = GIACONGMATPHAITextEdit.Text;
                tb.GiaCongMatTrai = GIACONGMATTRAITextEdit.Text;
                tb.MauMatPhai = MAUMATPHAITextEdit.Text;
                tb.MauMatTrai = MAUMATTRAITextEdit.Text;
                tb.PhuongPhapCat = PHUONGPHAPCATTextEdit.Text;
                tb.BoGoc = BOGOCTextEdit.Text;
                tb.Lo = LOTextEdit.Text;
                tb.XoChi = XOCHITextEdit.Text;
                tb.TinhTrang = TINHTRANGTextEdit.Text;
                tb.GhiChu = GHICHUTextEdit.Text;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật Thành Công");
                frmDanhSachSanPham_Load(sender, e);
            }
            else
            {
                var db = new MyDBContextDataContext();
                var tb = new tbDanhSachSanPham();

                dt = con.GetData("select MaSanPham from tbDanhSachSanPham order by (MaSanPham) asc");
                tb.MaSanPham = SinhMaTuDong(dt);
                tb.TenKhachHang = txtKhachHang.Text;
                tb.TenSanPham = TENSANPHAMTextEdit.Text;
                tb.LoaiSanPham = txtLoaiSanPham.Text;
                tb.PhuongPhapIn = txtPhuongPhapIn.Text;
                tb.KichThuoc = KICHTHUOCTextEdit.Text;
                tb.DonViTinh = txtDonViTinh.Text;
                tb.GiaCongMatPhai = GIACONGMATPHAITextEdit.Text;
                tb.GiaCongMatTrai = GIACONGMATTRAITextEdit.Text;
                tb.MauMatPhai = MAUMATPHAITextEdit.Text;
                tb.MauMatTrai = MAUMATTRAITextEdit.Text;
                tb.PhuongPhapCat = PHUONGPHAPCATTextEdit.Text;
                tb.BoGoc = BOGOCTextEdit.Text;
                tb.Lo = LOTextEdit.Text;
                tb.XoChi = XOCHITextEdit.Text;
                tb.TinhTrang = TINHTRANGTextEdit.Text;
                tb.GhiChu = GHICHUTextEdit.Text;
                db.tbDanhSachSanPhams.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Thêm Sản Phẩm Thành Công");
                frmDanhSachSanPham_Load(sender, e);
            }
        }

        private void tbDanhSachSanPhamGridControl_Click_1(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            try
            {
                var lst = (from s in db.tbDanhSachSanPhams where s.MaSanPham == maSanPhamTextEdit.Text select s).Single();
                if (!string.IsNullOrEmpty(lst.HinhMatPhai))
                    ptbHinhMatPhai.Image = Image.FromFile(lst.HinhMatPhai);
                if (!string.IsNullOrEmpty(lst.HinhMatTrai))
                    ptbHinhMatPhai.Image = Image.FromFile(lst.HinhMatTrai);
                if (!string.IsNullOrEmpty(lst.HinhKhuon))
                    ptbHinhMatPhai.Image = Image.FromFile(lst.HinhKhuon);
            }
            catch
            {
                // ignored
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //flagluu = 1;
            //Clear();
            flagluu = 1;
            DisEnl(true);
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView1.AddNewRow();
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            //risID.Buttons[0].Visible = true;
        }
        public void Clear()
        {
            maSanPhamTextEdit.Text = string.Empty;
            txtKhachHang.Text = string.Empty;
            TENSANPHAMTextEdit.Text = string.Empty;
            txtLoaiSanPham.Text = string.Empty;
            GHICHUTextEdit.Text = string.Empty;
            GIACONGMATPHAITextEdit.Text = string.Empty;
            GIACONGMATTRAITextEdit.Text = string.Empty;
            MAUMATPHAITextEdit.Text = string.Empty;
            MAUMATTRAITextEdit.Text = string.Empty;
            BOGOCTextEdit.Text = string.Empty;
            LOTextEdit.Text = string.Empty;
            PHUONGPHAPCATTextEdit.Text = string.Empty;
            txtPhuongPhapIn.Text = string.Empty;
            KICHTHUOCTextEdit.Text = string.Empty;
            txtDonViTinh.Text = string.Empty;
            TINHTRANGTextEdit.Text = string.Empty;
            XOCHITextEdit.Text = string.Empty;
        }
        #region SoThuTu
        public frmDanhSachSanPham()
        {
            InitializeComponent();
            Load += frmDanhSachSanPham_Load;
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private void cal(int width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }
                    SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 width = Convert.ToInt32(size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(width, gridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = $"[{(e.RowHandle * -1)}]"; //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(width, gridView1); }));
            }
        }

#endregion

       

        private void frmDanhSachSanPham_Load(object sender, EventArgs e)
        {
            DisEnl(false);
            SearchLookup();
            databingding();
            //maSanPhamTextEdit.Hide();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
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

            // Bảng Khách Hàng
            var khCtr = new KhachHangCtr();
            txtKhachHang.Properties.DataSource = khCtr.LoadData1C();
            txtKhachHang.Properties.DisplayMember = "TenKhachHang";
            txtKhachHang.Properties.ValueMember = "TenKhachHang";

            // Bảng Loại Sản Phẩm
            var lspCtr = new LoaiSanPhamCtr();
            risLoaiSanPham.DataSource = lspCtr.LoadData();
            risLoaiSanPham.DisplayMember = "ID";
            risLoaiSanPham.ValueMember = "ID";

            //// Bảng Bộ Phận
            //var bpCtr = new BoPhanCtr();
            //txtBoPhan.Properties.DataSource = bpCtr.LoadData();
            //txtBoPhan.Properties.DisplayMember = "ID";
            //txtBoPhan.Properties.ValueMember = "ID";

            // Phương Pháp In
            var ppiCtr = new PhuongPhapInCtr();
            risPhuongPhapIn.DataSource = ppiCtr.LoadData();
            risPhuongPhapIn.DisplayMember = "ID";
            risPhuongPhapIn.ValueMember = "ID";

            //// Bảng Kho
            //var KhoCtr = new KhoCtr();
            //txtKho.Properties.DataSource = KhoCtr.LoadData1C();
            //txtKho.Properties.DisplayMember = "ID";
            //txtKho.Properties.ValueMember = "ID";

            // Bảng Đơn Vị Tính
            var dvtCtr = new DonViTinhCtr();
            risDonViTinh.DataSource = dvtCtr.LoadData();
            risDonViTinh.DisplayMember = "ID";
            risDonViTinh.ValueMember = "ID";

            // Bảng Đơn Vị Tính
            var dsspCtr = new DanhSachSanPhamCtr();
            tbDanhSachSanPhamGridControl.DataSource = dsspCtr.LoadData();
            lblMaSanPham.Hide();}

        public void databingding()
        {
            maSanPhamTextEdit.DataBindings.Clear();
            maSanPhamTextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "MaSanPham");
            txtKhachHang.DataBindings.Clear();
            txtKhachHang.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "TenKhachHang");
            TENSANPHAMTextEdit.DataBindings.Clear();
            TENSANPHAMTextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "TenSanPham");
            txtLoaiSanPham.DataBindings.Clear();
            txtLoaiSanPham.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "LoaiSanPham");
            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "DonViTinh");
            KICHTHUOCTextEdit.DataBindings.Clear();
            KICHTHUOCTextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "KichThuoc");
            txtPhuongPhapIn.DataBindings.Clear();
            txtPhuongPhapIn.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "PhuongPhapIn");
            MAUMATPHAITextEdit.DataBindings.Clear();
            MAUMATPHAITextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "MauMatPhai");
            MAUMATTRAITextEdit.DataBindings.Clear();
            MAUMATTRAITextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "MauMatTrai");
            GIACONGMATPHAITextEdit.DataBindings.Clear();
            GIACONGMATPHAITextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "GiaCongMatPhai");
            GIACONGMATTRAITextEdit.DataBindings.Clear();
            GIACONGMATTRAITextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "GiaCongMatTrai");
            PHUONGPHAPCATTextEdit.DataBindings.Clear();
            PHUONGPHAPCATTextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "PhuongPhapCat");
            BOGOCTextEdit.DataBindings.Clear();
            BOGOCTextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "BoGoc");
            XOCHITextEdit.DataBindings.Clear();
            XOCHITextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "XoChi");
            TINHTRANGTextEdit.DataBindings.Clear();
            TINHTRANGTextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "TinhTrang");
            GHICHUTextEdit.DataBindings.Clear();
            GHICHUTextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "GhiChu");
            LOTextEdit.DataBindings.Clear();
            LOTextEdit.DataBindings.Add("text", tbDanhSachSanPhamGridControl.DataSource, "Lo");
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmDanhSachSanPham_Load(sender, e);
            }
            else
                MessageBox.Show("Hủy thất bại");
        }
    }
}