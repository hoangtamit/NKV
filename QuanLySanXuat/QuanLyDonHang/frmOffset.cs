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

namespace QuanLySanXuat
{
    public partial class frmOffset : DevExpress.XtraEditors.XtraForm
    {
        #region SoThuTu
        public frmOffset()
        {
            InitializeComponent();
            Load += frmOffset_Load;
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
        public frmOffset(NhanVienObj obj)
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

        private void frmOffset_Load(object sender, EventArgs e)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmOffset_Load(sender, e);
        }

        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked == true)
            {
                btnXacNhan.Enabled = false;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.BoPhan == PrintRibbon.offset && s.NghiepVu_XuongDon != null  select s).ToList();
                foreach (var item in lst)
                {
                    if (item.NghiepVu_XuongDon != null)
                    {
                        item.NghiepVu_XuongDon = "True";
                        NghiepvuCheck.ValueChecked = "True";
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

                    if (item.CtpHoanThanh != null)
                    {
                        item.CtpHoanThanh = "True";
                        CtpHoanthanhCheck.ValueChecked = "True";
                    }
                    if (item.SauInNhan != null)
                    {
                        item.SauInNhan = "True";
                        SauinNhanCheck.ValueChecked = "True";
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
                frmOffset_Load(sender, e);
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
            if (lst.OffsetNhan == null)
                lst.OffsetNhan = xn;
            else
                lst.OffsetHoanThanh = xn;
            db.SubmitChanges();
            frmOffset_Load(sender,e);
        }

        private void procQuanLyDonhang_ViewGridControl_Click(object sender, EventArgs e)
        {
            databinding();
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            xacnhan.Text = lst.OffsetNhan;
            hoanthanh.Text = lst.OffsetHoanThanh;

        }
        public void databinding()
        {
            sCDTextEdit.DataBindings.Clear();
            sCDTextEdit.DataBindings.Add("text", procQuanLyDonhang_ViewGridControl.DataSource, "IDQuanLyDonHang");
        }

        public void check()
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.OffsetHoanThanh == null && s.NghiepVu_XuongDon !=null && s.BoPhan == PrintRibbon.offset select s).ToList();
            foreach (var item in lst)
            {
                if (item.NghiepVu_XuongDon != null)
                {
                    item.NghiepVu_XuongDon = "True";
                    NghiepvuCheck.ValueChecked = "True";
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
                if (item.CtpHoanThanh != null)
                {
                    item.CtpHoanThanh = "True";
                    CtpHoanthanhCheck.ValueChecked = "True";
                }
                if (item.SauInNhan != null)
                {
                    item.SauInNhan = "True";
                    SauinNhanCheck.ValueChecked = "True";
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