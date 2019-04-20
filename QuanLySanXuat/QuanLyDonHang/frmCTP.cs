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
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;
using QuanLySanXuat.DonSanXuat;
using QuanLySanXuat.Object;
//using DevExpress.XtraPrinting;
using static QuanLySanXuat.PrintRibbon;
namespace QuanLySanXuat
{
    public partial class frmCTP : XtraForm
    {
        #region SoThuTu
        public frmCTP()
        {
            InitializeComponent();
            Load += frmCTP_Load;
            bandedGridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private void Cal(int width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
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
                    SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 width = Convert.ToInt32(size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { Cal(width, bandedGridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = $"[{(e.RowHandle * -1)}]"; //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { Cal(width, bandedGridView1); }));
            }
        }

        #endregion

        #region SqlDependency

        public readonly NhanVienObj nvObj = new NhanVienObj();
        public frmCTP(NhanVienObj obj)
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
        //        Check();

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

        private void frmCTP_Load(object sender, EventArgs e)
        {
            //OnNewHome += Form1_OnNewHome; //tab
            ////load data vao datagrid
            //LoadData();
            Check();
            databinding();
            sCDTextEdit.Hide();
        }

        #endregion
        private void btnChiTietDonSanXuat_Click(object sender, EventArgs e)
        {
            var frm = new frmChiTietDonSanXuat(sCDTextEdit.Text);
            frm.ShowDialog();

        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmCTP_Load(sender, e);
        }

        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked == true)
            {
                btnXacNhan.Enabled = false;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.DonSanXuat_QuanLyDonhang_View()
                    where  s.NghiepVu_XuongDon != null && (s.BoPhan == offset || s.BoPhan == danhthiep)  select s).ToList();
                foreach (var item in lst)
                {
                    if (item.NghiepVu_XuongDon != null)
                    {
                        item.NghiepVu_XuongDon = "True";
                        _nghiepvuCheck.ValueChecked = "True";
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

                    if (item.DanhThiepNhan != null)
                    {
                        item.DanhThiepNhan = "True";
                        OffsetNhanCheck.ValueChecked = "True";
                    }
                    if (item.DanhThiepHoanThanh != null)
                    {
                        item.DanhThiepHoanThanh = "True";
                        DanhthiepHoanthanhCheck.ValueChecked = "True";
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
                frmCTP_Load(sender, e);
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
            if (lst.CtpNhan == null)
                lst.CtpNhan = xn;
            else
                lst.CtpHoanThanh = xn;
            db.SubmitChanges();
            frmCTP_Load(sender,e);
        }

        private void procQuanLyDonhang_ViewGridControl_Click(object sender, EventArgs e)
        {
            databinding();
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            xacnhan.Text = lst.CtpNhan;
            hoanthanh.Text = lst.CtpHoanThanh;

        }

        public void databinding()
        {
            sCDTextEdit.DataBindings.Clear();
            sCDTextEdit.DataBindings.Add("text", procQuanLyDonhang_ViewGridControl.DataSource, "IDQuanLyDonHang");
        }

        public void Check()
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() where s.CtpHoanThanh == null && s.NghiepVu_XuongDon != null && (s.BoPhan == offset || s.BoPhan == danhthiep) select s).ToList();
            //var lst = (from s in db.tbQuanLyDonHangs join x in db.tbDonSanXuats on s.IDQuanLyDonHang equals x.SCD select s).ToList();
            foreach (var item in lst)
            {
                if (item.NghiepVu_XuongDon != null)
                {
                    item.NghiepVu_XuongDon = "True";
                    _nghiepvuCheck.ValueChecked = "True";
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

                if (item.DanhThiepNhan != null)
                {
                    item.DanhThiepNhan = "True";
                    OffsetNhanCheck.ValueChecked = "True";
                }
                if (item.DanhThiepHoanThanh != null)
                {
                    item.DanhThiepHoanThanh = "True";
                    DanhthiepHoanthanhCheck.ValueChecked = "True";
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