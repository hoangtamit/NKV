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
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;
using QuanLySanXuat.DonSanXuat;
using QuanLySanXuat.Object;
using static QuanLySanXuat.PrintRibbon;

namespace QuanLySanXuat
{
    public partial class frmSticker : XtraForm
    {
        #region SoThuTu
        public frmSticker()
        {
            InitializeComponent();
            Load += frmSticker_Load;
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
        public frmSticker(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;

        }
        private void btnChiTietDonSanXuat_Click(object sender, EventArgs e)
        {
            var frm = new frmChiTietDonSanXuat(sCDTextEdit.Text);
            frm.ShowDialog();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmSticker_Load(sender, e);
        }

        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked == true)
            {
                btnXacNhan.Enabled = false;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.LoadData_DonSanXuat_QuanLyDonHang_Sticker() where s.BoPhan == sticker && s.NghiepVu_XuongDon != null select s).ToList();
                foreach (var item in lst)
                {
                    if (item.NghiepVu_XuongDon != null)
                    {
                        item.NghiepVu_XuongDon = "True";
                        NghiepvuCheck.ValueChecked = "True";
                    }

                    if (item.CtfNhan != null)
                    {
                        item.CtfNhan = "True";
                        CtfNhanCheck.ValueChecked = "True";
                    }
                    if (item.CtfHoanThanh != null)
                    {
                        item.CtfHoanThanh = "True";
                        CtfHoanThanhCheck.ValueChecked = "True";
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
                frmSticker_Load(sender, e);
                btnXacNhan.Enabled = true;
            }
        }


        private void btnin_Click(object sender, EventArgs e)
        {
            procQuanLyDonhang_ViewGridControl.ShowRibbonPrintPreview();
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
             var _xn = nvObj.Tennhanvien + " " + DateTime.Now;
              var db = new MyDBContextDataContext();
            var lst = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            if (lst.StickerNhan == null)
                lst.StickerNhan = _xn;
            else
                lst.StickerHoanThanh = _xn;
            db.SubmitChanges();
            frmSticker_Load(sender, e);
        }

        private void procQuanLyDonhang_ViewGridControl_Click(object sender, EventArgs e)
        {
            databinding();
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            xacnhan.Text = lst.StickerNhan;
            hoanthanh.Text = lst.StickerHoanThanh;

        }

        private void frmSticker_Load(object sender, EventArgs e)
        {
            check();
            databinding();
        }
        public void databinding()
        {
            sCDTextEdit.DataBindings.Clear();
            sCDTextEdit.DataBindings.Add("text", procQuanLyDonhang_ViewGridControl.DataSource, "IDQuanLyDonHang");
        }
        public void check()
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.LoadData_DonSanXuat_QuanLyDonHang_Sticker() where s.StickerHoanThanh == null && s.NghiepVu_XuongDon != null && s.BoPhan == sticker && s.HoanThanh == null select s).ToList();
            foreach (var item in lst)
            {
                if (item.NghiepVu_XuongDon != null)
                {
                    item.NghiepVu_XuongDon = "True";
                    NghiepvuCheck.ValueChecked = "True";
                }

                if (item.CtfNhan != null)
                {
                    item.CtfNhan = "True";
                    CtfNhanCheck.ValueChecked = "True";
                }
                if (item.CtfHoanThanh != null)
                {
                    item.CtfHoanThanh = "True";
                    CtfHoanThanhCheck.ValueChecked = "True";
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

                if (item.HoanThanh != null)
                {
                    item.HoanThanh = "True";
                    SanxuatHoanThanhCheck.ValueChecked = "True";
                }
            }
            procQuanLyDonhang_ViewGridControl.DataSource = lst;
        }

        private void procQuanLyDonhang_ViewGridControl_DoubleClick(object sender, EventArgs e)
        {
            var frm = new frmQuetBarcodeSticker(nvObj,sCDTextEdit.Text);
            frm.ShowDialog();
        }
    }
}
