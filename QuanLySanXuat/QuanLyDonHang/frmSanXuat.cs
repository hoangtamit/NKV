using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using DevExpress.CodeParser;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.DonSanXuat;
using QuanLySanXuat.Object;

namespace QuanLySanXuat
{
    public partial class frmSanXuat : XtraForm
    {

        #region SoThuTu

        public frmSanXuat()
        {
            InitializeComponent();
            Load += frmSanXuat_Load;
            bandedGridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private void procQuanLyDonhang_ViewGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                databinding();
                var db = new MyDBContextDataContext();
                var lst = (from s in db.DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null() where s.SCD == sCDTextEdit.Text select s).Single();
                if (lst.BoPhanSX != null)
                {
                    MessageBox.Show("Đơn hàng đã chuyển đổi bộ phận " + lst.BoPhan + " sang bộ phận " + lst.BoPhanSX + " ");
                }
            }
            catch (Exception)
            {
                //null
            }
        }

        private bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!bandedGridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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

                    SizeF _Size =
                        e.Graphics.MeasureString(e.Info.DisplayText,
                            e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate
                    {
                        cal(_Width, bandedGridView1);
                    })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText =
                    string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, bandedGridView1); }));
            }
        }

        #endregion

        private void btnin_Click(object sender, EventArgs e)
        {
            procQuanLyDonhang_ViewGridControl.ShowRibbonPrintPreview();
        }

        private void btnChiTietDonSanXuat_Click(object sender, EventArgs e)
        {
            var frm = new frmChiTietDonSanXuat(sCDTextEdit.Text);
            frm.ShowDialog();

        }

        #region SqlDependency

        private readonly NhanVienObj nvObj = new NhanVienObj();
        public frmSanXuat(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }

        //public void Form1_OnNewHome()
        //{
        //    var i = (ISynchronizeInvoke) this;
        //    if (i.InvokeRequired) //tab
        //    {
        //        var dd = new NewHome(Form1_OnNewHome);
        //        i.BeginInvoke(dd, null);
        //        return;
        //    }

        //    LoadData();

        //}

        ////Ham load data
        //private void LoadData()
        //{

        //    try
        //    {
        //        var dt = new DataTable();
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }

        //        var caulenh = "DonSanXuat_QuanLyDonhang_View";


        //        var cmd = new SqlCommand(caulenh, con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Notification = null;

        //        var de = new SqlDependency(cmd);
        //        de.OnChange += de_OnChange;

        //        dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
        //        procQuanLyDonhang_ViewGridControl.DataSource = dt;
        //        databinding();
        //        sCDTextEdit.Hide();
        //        check();

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }


        //}

        //public void de_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    var de = sender as SqlDependency;
        //    if (de != null) de.OnChange -= de_OnChange;
        //    if (OnNewHome != null)
        //    {
        //        OnNewHome();
        //    }
        //}

        private void frmSanXuat_Load(object sender, EventArgs e)
        {
            //OnNewHome += Form1_OnNewHome; //tab
            ////load data vao datagrid
            //LoadData();
            check();
            databinding();
            sCDTextEdit.Hide();
            phanquyen();
        }
        public void phanquyen()
        {
            if (nvObj.Chucvu != "Tổ Trưởng" || nvObj.Bophan != "QUẢN LÝ CHẤT LƯỢNG")
                btnXacNhan.Enabled = false;
        }

        #endregion

        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked == true)
            {
                
                var db = new MyDBContextDataContext();
                var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.NghiepVu_XuongDon != null select s).ToList();
                //var lst = (from s in db.tbQuanLyDonHangs join x in db.tbDonSanXuats on s.IDQuanLyDonHang equals x.SCD select s).ToList();
                foreach (var item in lst)
                {

                    if (item.NghiepVu_XuongDon != null)
                    {item.NghiepVu_XuongDon = "True";NghiepvuCheck.ValueChecked = "True";}
                    if (item.ThietKeNhan != null)
                    {item.ThietKeNhan = "True"; thietkenhancheck.ValueChecked = "True";}
                    if (item.ThietKeHoanThanh != null)
                    {
                        item.ThietKeHoanThanh = "True";
                        thietkehtcheck.ValueChecked = "True";
                    }
                    if (item.CtpNhan != null)
                    {
                        item.CtpNhan = "True";
                        CtpNhanCheck.ValueChecked = "True";
                    }
                    if (item.CtpHoanThanh != null)
                    {
                        item.CtpHoanThanh = "True";
                        CtpHoanthanhCheck.ValueChecked = "True";
                    }
                    if (item.CtfNhan != null)
                    {
                        item.CtfNhan = "True";
                        CtfNhanCheck.ValueChecked = "True";
                    }
                    if (item.CtfHoanThanh != null)
                    {
                        item.CtfHoanThanh = "True";
                        CtfHoanthanhCheck.ValueChecked = "True";
                    }
                    if (item.OffsetNhan != null)
                    {
                        item.OffsetNhan = "True";
                        OffsetNhanCheck.ValueChecked = "True";
                    }
                    if (item.OffsetHoanThanh != null)
                    {
                        item.OffsetHoanThanh = "True";
                        OffsetHoanthanhCheck.ValueChecked = "True";
                    }
                    if (item.KyThuatSoNhan != null)
                    {
                        item.KyThuatSoNhan = "True";
                        KtsNhanCheck.ValueChecked = "True";
                    }
                    if (item.KyThuatSoHoanThanh != null)
                    {
                        item.KyThuatSoHoanThanh = "True";
                        KtsHoanthanhCheck.ValueChecked = "True";
                    }
                    if (item.DanhThiepNhan != null)
                    {
                        item.DanhThiepNhan = "True";
                        DanhthiepNhanCheck.ValueChecked = "True";
                    }
                    if (item.DanhThiepHoanThanh != null)
                    {
                        item.DanhThiepHoanThanh = "True";
                        DanhthiepHoanthanhCheck.ValueChecked = "True";
                    }
                    if (item.StickerNhan != null)
                    {
                        item.StickerNhan = "True";
                        StickerNhanCheck.ValueChecked = "True";
                    }

                    if (item.StickerHoanThanh != null)
                    {
                        item.StickerHoanThanh = "True";
                        StickerHoanthanhCheck.ValueChecked = "True";
                    }

                    if (item.TemVaiNhan != null)
                    {
                        item.TemVaiNhan = "True";
                        TemvaiNhanCheck.ValueChecked = "True";
                    }

                    if (item.TemVaiHoanThanh != null)
                    {
                        item.TemVaiHoanThanh = "True";
                        TemvaiHoanthanhCheck.ValueChecked = "True";
                    }

                    if (item.InChuNhan != null)
                    {
                        item.InChuNhan = "True";
                        InchuNhanCheck.ValueChecked = "True";
                    }

                    if (item.InChuHoanThanh != null)
                    {
                        item.InChuHoanThanh = "True";
                        InchuHoanThanhCheck.ValueChecked = "True";
                    }

                    if (item.KiemPhamNhan != null)
                    {
                        item.KiemPhamNhan = "True";
                        KiemphamNhanCheck.ValueChecked = "True";
                    }

                    if (item.KiemPhamHoanThanh != null)
                    {
                        item.KiemPhamHoanThanh = "True";
                        KiemphamHoanthanhCheck.ValueChecked = "True";
                    }

                    if (item.KhoBTPNhan != null)
                    {
                        item.KhoBTPNhan = "True";
                        KhoNhanCheck.ValueChecked = "True";
                    }

                    if (item.KhoBTPHoanThanh != null)
                    {
                        item.KhoBTPHoanThanh = "True";
                        KhoHoanthanhCheck.ValueChecked = "True";
                    }

                    if (item.SauInNhan != null)
                    {
                        item.SauInNhan = "True";
                        SauinNhanCheck.ValueChecked = "True";
                    }

                    if (item.SauInHoanThanh != null)
                    {
                        item.SauInHoanThanh = "True";
                        SauinHoanthanhCheck.ValueChecked = "True";
                    }

                    if (item.HoanThanh != null)
                    {
                        item.HoanThanh = "True";
                        SanxuatHoanThanhCheck.ValueChecked = "True";
                    }
                }

                procQuanLyDonhang_ViewGridControl.DataSource = lst;
            }
            else
                frmSanXuat_Load(sender, e);

            //if (hiendonhang.Checked == true)
            //{
            //    bandedGridView1.Columns.Clear();
            //    btnXacNhan.Enabled = false;
            //    MyDBContextDataContext db = new MyDBContextDataContext();
            //    var lst = (from s in db.DonSanXuat_QuanLyDonhang_View()
            //               select new
            //               {
            //                   s.SCD,s.MaDonHang,s.TenKhachHang,s.TenSanPham,s.SoLuong,s.NgayXuongDon,s.NgayGiaoHang,s.NghiepVu_XuongDon,s.ThietKeNhan,s.ThietKeHoanThanh
            //    }).ToList();
            //    procQuanLyDonhang_ViewGridControl.DataSource = lst;
            //}
            //else
            //    frmSanXuat_Load(sender, e);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var xn = nvObj.Tennhanvien + " " + DateTime.Now;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            if (lst.HoanThanh != null) return;
            lst.HoanThanh = xn;
            db.SubmitChanges();
            frmSanXuat_Load(sender,e);
        }

        public void databinding()
        {
            sCDTextEdit.DataBindings.Clear();
            sCDTextEdit.DataBindings.Add("text", procQuanLyDonhang_ViewGridControl.DataSource, "IDQuanLyDonHang");
        }

        public void check()
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null()
                where s.NghiepVu_XuongDon != null
                select s).ToList();
            //var lst = (from s in db.tbQuanLyDonHangs join x in db.tbDonSanXuats on s.IDQuanLyDonHang equals x.SCD select s).ToList();
            foreach (var item in lst)
            {
                if (item.BoPhanSX != null)
                {
                    item.BoPhan = item.BoPhanSX;
                    item.PhuongPhapIn = item.PhuongPhapInSX;
                }
                if (item.VatLieuSX != null)
                {
                    item.VatLieu = item.VatLieuSX;
                    item.Kho = item.KhoSX;
                }
                if (item.NghiepVu_XuongDon != null)
                {
                    item.NghiepVu_XuongDon = "True";
                    NghiepvuCheck.ValueChecked = "True";
                }

                if (item.ThietKeNhan != null)
                {
                    item.ThietKeNhan = "True";
                    thietkenhancheck.ValueChecked = "True";
                }

                if (item.ThietKeHoanThanh != null)
                {
                    item.ThietKeHoanThanh = "True";
                    thietkehtcheck.ValueChecked = "True";
                }

                if (item.CtpNhan != null)
                {
                    item.CtpNhan = "True";
                    CtpNhanCheck.ValueChecked = "True";
                }

                if (item.CtpHoanThanh != null)
                {
                    item.CtpHoanThanh = "True";
                    CtpHoanthanhCheck.ValueChecked = "True";
                }

                if (item.OffsetNhan != null)
                {
                    item.OffsetNhan = "True";
                    OffsetNhanCheck.ValueChecked = "True";
                }

                if (item.OffsetHoanThanh != null)
                {
                    item.OffsetHoanThanh = "True";
                    OffsetHoanthanhCheck.ValueChecked = "True";
                }

                if (item.KyThuatSoNhan != null)
                {
                    item.KyThuatSoNhan = "True";
                    KtsNhanCheck.ValueChecked = "True";
                }

                if (item.KyThuatSoHoanThanh != null)
                {
                    item.KyThuatSoHoanThanh = "True";
                    KtsHoanthanhCheck.ValueChecked = "True";
                }

                if (item.DanhThiepNhan != null)
                {
                    item.DanhThiepNhan = "True";
                    DanhthiepNhanCheck.ValueChecked = "True";
                }

                if (item.DanhThiepHoanThanh != null)
                {
                    item.DanhThiepHoanThanh = "True";
                    DanhthiepHoanthanhCheck.ValueChecked = "True";
                }

                if (item.StickerNhan != null)
                {
                    item.StickerNhan = "True";
                    StickerNhanCheck.ValueChecked = "True";
                }

                if (item.StickerHoanThanh != null)
                {
                    item.StickerHoanThanh = "True";
                    StickerHoanthanhCheck.ValueChecked = "True";
                }

                if (item.TemVaiNhan != null)
                {
                    item.TemVaiNhan = "True";
                    TemvaiNhanCheck.ValueChecked = "True";
                }

                if (item.TemVaiHoanThanh != null)
                {
                    item.TemVaiHoanThanh = "True";
                    TemvaiHoanthanhCheck.ValueChecked = "True";
                }

                if (item.InChuNhan != null)
                {
                    item.InChuNhan = "True";
                    InchuNhanCheck.ValueChecked = "True";
                }

                if (item.InChuHoanThanh != null)
                {
                    item.InChuHoanThanh = "True";
                    InchuHoanThanhCheck.ValueChecked = "True";
                }

                if (item.KiemPhamNhan != null)
                {
                    item.KiemPhamNhan = "True";
                    KiemphamNhanCheck.ValueChecked = "True";
                }

                if (item.KiemPhamHoanThanh != null)
                {
                    item.KiemPhamHoanThanh = "True";
                    KiemphamHoanthanhCheck.ValueChecked = "True";
                }

                if (item.KhoBTPNhan != null)
                {
                    item.KhoBTPNhan = "True";
                    KhoNhanCheck.ValueChecked = "True";
                }

                if (item.KhoBTPHoanThanh != null)
                {
                    item.KhoBTPHoanThanh = "True";
                    KhoHoanthanhCheck.ValueChecked = "True";
                }

                if (item.SauInNhan != null)
                {
                    item.SauInNhan = "True";
                    SauinNhanCheck.ValueChecked = "True";
                }

                if (item.SauInHoanThanh != null)
                {
                    item.SauInHoanThanh = "True";
                    SauinHoanthanhCheck.ValueChecked = "True";
                }

                if (item.HoanThanh != null)
                {
                    item.HoanThanh = "True";
                    SanxuatHoanThanhCheck.ValueChecked = "True";
                }

                procQuanLyDonhang_ViewGridControl.DataSource = lst;
            }

        }

        private void btnXacNhanSuCo_Click(object sender, EventArgs e)
        {


        }

        private void bandedGridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                if (sender is GridView view)
                {
                    var capnhat = view.GetRowCellDisplayText(e.RowHandle, view.Columns["DonSuCo"]);
                    switch (capnhat)
                    {
                        case "Nhẹ":
                            e.Appearance.BackColor = Color.LightYellow;
                            break;
                        case "Nặng":
                            e.Appearance.BackColor = Color.DarkOrange;
                            break;
                        case "Nghiêm Trọng":
                            e.Appearance.BackColor = Color.OrangeRed;
                            break;
                    }
                }

            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void bbiNhe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var db = new MyDBContextDataContext();
            var donsuco = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            donsuco.DonSuCo = "Nhẹ";
            try{donsuco.GhiChu = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colGhiChu).ToString();}
            catch{}
            db.SubmitChanges();
            frmSanXuat_Load(sender, e);
            MessageBox.Show("Đơn hàng " + donsuco.IDQuanLyDonHang + " đã cập nhật đơn 'Sự Cố " + donsuco.DonSuCo + "' thành công ");
        }

        private void bbiNang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var db = new MyDBContextDataContext();
            var donsuco = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            donsuco.DonSuCo = "Nặng";
            try { donsuco.GhiChu = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colGhiChu).ToString(); }
            catch{}
                db.SubmitChanges();
            frmSanXuat_Load(sender, e);
            MessageBox.Show("Đơn hàng " + donsuco.IDQuanLyDonHang + " đã cập nhật đơn 'Sự Cố " + donsuco.DonSuCo + "' thành công ");
        }

        private void bbiNghiemTrong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var db = new MyDBContextDataContext();
            var donsuco = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            donsuco.DonSuCo = "Nghiêm Trọng";
            try { donsuco.GhiChu = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colGhiChu).ToString(); }
            catch {}
            db.SubmitChanges();
            frmSanXuat_Load(sender, e);
            MessageBox.Show("Đơn hàng " + donsuco.IDQuanLyDonHang + " đã cập nhật đơn 'Sự Cố " + donsuco.DonSuCo + "' thành công ");
        }
    }
}