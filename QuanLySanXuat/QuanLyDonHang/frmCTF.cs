using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.DonSanXuat;
using QuanLySanXuat.Object;
using static QuanLySanXuat.PrintRibbon;

namespace QuanLySanXuat
{
    public partial class frmCTF : DevExpress.XtraEditors.XtraForm
    {
        #region SoThuTu
        public frmCTF()
        {
            InitializeComponent();
            Load += frmCTF_Load;
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

        #region SqlDependency
        public readonly NhanVienObj nvObj = new NhanVienObj();
        public frmCTF(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;

        }

        //public void Form1_OnNewHome()
        //{
        //    var i = (ISynchronizeInvoke)this;
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

        private void frmCTF_Load(object sender, EventArgs e)
        {
            //OnNewHome += Form1_OnNewHome; //tab
            ////load data vao datagrid
            //LoadData();
            check();
            databinding();
            sCDTextEdit.Hide();
        }

        #endregion
        private void btnChiTietDonSanXuat_Click(object sender, EventArgs e)
        {
            var frm = new frmChiTietDonSanXuat(sCDTextEdit.Text);
            frm.ShowDialog();
        }


        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked)
            {
                btnXacNhan.Enabled = false;
                MyDBContextDataContext db = new MyDBContextDataContext();
                var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.NghiepVu_XuongDon != null  && (s.BoPhan == temvai || s.BoPhan == sticker) && s.CtfHoanThanh  == null select s).ToList();
                foreach (var item in lst)
                {
                    if (item.NghiepVu_XuongDon != null)
                    {
                        item.NghiepVu_XuongDon = "True";
                        _nghiepvuCheck.ValueChecked = "True";
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
                frmCTF_Load(sender, e);
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
            if (lst.CtfNhan == null)
                lst.CtfNhan = xn;
            else
                lst.CtfHoanThanh = xn;
            db.SubmitChanges();
            frmCTF_Load(sender,e);
        }

        private void procQuanLyDonhang_ViewGridControl_Click(object sender, EventArgs e)
        {
            databinding();
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            xacnhan.Text = lst.CtfNhan;
            hoanthanh.Text = lst.CtfHoanThanh;

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
            var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.NghiepVu_XuongDon != null && s.CtfHoanThanh == null && (s.BoPhan == temvai || s.BoPhan == sticker) select s).ToList();
            foreach (var item in lst)
            {
                if (item.NghiepVu_XuongDon != null)
                {
                    item.NghiepVu_XuongDon = "True";
                    _nghiepvuCheck.ValueChecked = "True";
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
