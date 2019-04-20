using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.DonSanXuat;
using QuanLySanXuat.Object;

//using DevExpress.XtraPrinting;

namespace QuanLySanXuat
{
    public partial class frmKhoBTP_TP : XtraForm
    {
        #region SoThuTu
        public frmKhoBTP_TP()
        {
            InitializeComponent();
            Load += frmKhoBTP_TP_Load;
            bandedGridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
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
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, bandedGridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, bandedGridView1); }));
            }
        }

        #endregion

        public readonly NhanVienObj nvObj = new NhanVienObj();
        public frmKhoBTP_TP(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmKhoBTP_TP_Load(sender, e);
        }
        private void btnChiTietDonSanXuat_Click(object sender, EventArgs e)
        {
            var frm = new frmChiTietDonSanXuat(sCDTextEdit.Text);
            frm.ShowDialog();

        }
        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked == true)
            {
                btnXacNhan.Enabled = false;
                MyDBContextDataContext db = new MyDBContextDataContext();
                var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.NghiepVu_XuongDon!=null select s).ToList();
                foreach (var item in lst)
                {
                    if (item.NghiepVu_XuongDon != null)
                    {
                        item.NghiepVu_XuongDon = "True";
                        NghiepvuCheck.ValueChecked = "True";
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
                    if (item.KiemPhamHoanThanh != null)
                    {
                        item.KiemPhamHoanThanh = "True";
                        KiemphamHoanthanhCheck.ValueChecked = "True";
                    }
                    if (item.KiemPhamNhan != null)
                    {
                        item.KiemPhamNhan = "True";
                        KiemphamNhanCheck.ValueChecked = "True";
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
                    if (item.HoanThanh != null)
                    {
                        item.HoanThanh = "True";
                        SanxuatHoanThanhCheck.ValueChecked = "True";
                    }
                }
                procQuanLyDonhang_ViewGridControl.DataSource = lst;
            }
            else
            {
                frmKhoBTP_TP_Load(sender, e);
                btnXacNhan.Enabled = true;
            }
        }



        private void btnin_Click(object sender, EventArgs e)
        {
            procQuanLyDonhang_ViewGridControl.ShowRibbonPrintPreview();
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var xn = nvObj.Tennhanvien + " " + DateTime.Now;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            if (lst.KhoBTPNhan == null)
                lst.KhoBTPNhan = xn;
            else
                lst.KhoBTPHoanThanh = xn;
            db.SubmitChanges();
            frmKhoBTP_TP_Load(sender, e);
        }

        private void procQuanLyDonhang_ViewGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                databinding();
                var db = new MyDBContextDataContext();
                var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
                xacnhan.Text = lst.KhoBTPNhan;
                hoanthanh.Text = lst.KhoBTPHoanThanh;
            }
            catch { }

        }

        private void frmKhoBTP_TP_Load(object sender, EventArgs e)
        {
            check();
            databinding();

        }
        public void databinding()
        {
            sCDTextEdit.DataBindings.Clear();
            sCDTextEdit.DataBindings.Add("text", procQuanLyDonhang_ViewGridControl.DataSource, "IDQuanLyDonHang");
        }

        //where s.SauInHoanThanh == null && s.BoPhan == "SAU IN"  || s.BoPhan == "OFFSET" || s.BoPhan == "KỸ THUẬT SỐ"
        public void check()
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.NghiepVu_XuongDon!=null && s.KhoBTPHoanThanh == null select s).ToList();
            foreach (var item in lst)
            {
                if (item.NghiepVu_XuongDon != null)
                {
                    item.NghiepVu_XuongDon = "True";
                    NghiepvuCheck.ValueChecked = "True";
                }
                if (item.KiemPhamHoanThanh != null)
                {
                    item.KiemPhamHoanThanh = "True";
                    KiemphamHoanthanhCheck.ValueChecked = "True";
                }
                if (item.KiemPhamNhan != null)
                {
                    item.KiemPhamNhan = "True";
                    KiemphamNhanCheck.ValueChecked = "True";
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
                if (item.HoanThanh != null)
                {
                    item.HoanThanh = "True";
                    SanxuatHoanThanhCheck.ValueChecked = "True";
                }
            }
            procQuanLyDonhang_ViewGridControl.DataSource = lst;
        }

    }
}
