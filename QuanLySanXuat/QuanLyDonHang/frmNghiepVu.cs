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
using QuanLySanXuat.Object;
using QuanLySanXuat.Control;

//using DevExpress.XtraPrinting;

namespace QuanLySanXuat
{
    public partial class frmNghiepVu : XtraForm
    {
        #region SoThuTu
        public frmNghiepVu()
        {
            InitializeComponent();
            Load += frmNghiepVu_Load;
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
        public readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        public frmNghiepVu(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;

        }

        //public void Form1_OnNewHome()
        //{
        //    var i = (ISynchronizeInvoke)this;
        //    if (i.InvokeRequired)//tab
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

        private void frmNghiepVu_Load(object sender, EventArgs e)
        {
            //OnNewHome += Form1_OnNewHome;//tab
            ////load data vao datagrid
            //LoadData();
            check();
            databinding();
            sCDTextEdit.Hide();
            btnThuHoiDon.Enabled = false;
        }
        #endregion


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmNghiepVu_Load(sender, e);
        }

        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked == true)
            {
                btnThuHoiDon.Enabled = true;
                btnXacNhan.Enabled = false;
                var db = new MyDBContextDataContext();
                var lst = db.LoadData_DonSanXuat_QuanLyDonHang_NghiepVu().ToList();
                foreach (var item in lst)
                {
                    if (item.NghiepVu_XuongDon != null)
                        item.NghiepVu_XuongDon = "True";
                    if (item.ThietKeNhan != null)
                        item.ThietKeNhan = "True";
                    if (item.ThietKeHoanThanh != null)
                        item.ThietKeHoanThanh = "True";
                    if (item.HoanThanh != null)
                        item.HoanThanh = "True";

                }
                procQuanLyDonhang_ViewGridControl.DataSource = lst;
            }
            else
            {
                frmNghiepVu_Load(sender, e);
                btnXacNhan.Enabled = true;
            }
        }



        private void btnin_Click(object sender, EventArgs e)
        {
            procQuanLyDonhang_ViewGridControl.ShowRibbonPrintPreview();
        }

        private string sku;
        public void GetValue(string str1)
        {
            sku = str1;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var xn = nvObj.Tennhanvien + " " + DateTime.Now;
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            if (lst.NghiepVu_XuongDon != null)return;
            var tb = db.tbBaoCaoNghiepVus.Single(s => s.IDBaoCaoNghiepVu == sCDTextEdit.Text);
            tb.SpSize = "O";
            tb.DanhGia = "Đạt";
            var lst2 = (from s in db.tbDonSanXuats where s.SCD == sCDTextEdit.Text select s).Single();
            if (lst2.TenKhachHang != PrintRibbon.AD || lst2.BoPhan != "TEM VẢI")
            {
                var frm = new frmSKU();
                frm.MySKU = new frmSKU.GetString(GetValue);
                frm.ShowDialog();
                tb.Size = sku;
            }
            lst.NghiepVu_XuongDon = xn;
            db.SubmitChanges();
            frmNghiepVu_Load(sender,e);
        }

        private void procQuanLyDonhang_ViewGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                databinding();
                var db = new MyDBContextDataContext();
                var lst = (from s in db.LoadData_DonSanXuat_QuanLyDonHang_NghiepVu() where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
                xacnhan.Text = lst.NghiepVu_XuongDon;
            }
            catch { }

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
            var lst = (from s in db.LoadData_DonSanXuat_QuanLyDonHang_NghiepVu() where s.NghiepVu_XuongDon == null  select s).ToList();
            foreach (var item in lst)
            {
                if (item.NghiepVu_XuongDon != null)
                    item.NghiepVu_XuongDon = "True";
                if (item.ThietKeNhan != null)
                    item.ThietKeNhan = "True";
                if (item.ThietKeHoanThanh != null)
                    item.ThietKeHoanThanh = "True";
                if (item.HoanThanh != null)
                    item.HoanThanh = "True";
            }
            procQuanLyDonhang_ViewGridControl.DataSource = lst;
            //procQuanLyDonhang_ViewGridControl.DataSource = dsxCtr.LoadData_DonSanXuat_QuanLyDonHang_NghiepVu();
        }

        private void btnThuHoiDon_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
            if (lst.NghiepVu_XuongDon != null)
                lst.NghiepVu_XuongDon = null;
            db.SubmitChanges();
            frmNghiepVu_Load(sender, e);
        }
    }
}
