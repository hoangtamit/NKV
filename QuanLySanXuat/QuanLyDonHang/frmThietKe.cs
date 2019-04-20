using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Object;
using QuanLySanXuat.Control;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.DonSanXuat;
using QuanLySanXuat.QuanLyDonHang;

namespace QuanLySanXuat
{
    public partial class frmThietKe : DevExpress.XtraEditors.XtraForm
    {
        private readonly TemDanADCtr tdADCtr = new TemDanADCtr();
        #region SoThuTu
        public frmThietKe()
        {
            InitializeComponent();
            Load += frmThietKe_Load;
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
        //public string m_connect = @"Data Source=192.168.1.100;Initial Catalog=NKV;User ID=sa;Password=Ngochoa123";
        //private readonly ConnectSQL _con = new ConnectSQL();
        public readonly NhanVienObj nvObj = new NhanVienObj();
        public DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        public QuanLyDonHangCtr qldhCtr = new QuanLyDonHangCtr();
        public frmThietKe(NhanVienObj obj)
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
        //        Databinding();
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

        private void frmThietKe_Load(object sender, EventArgs e)
        {
            //OnNewHome += Form1_OnNewHome;//tab
            ////load data vao datagrid
            //LoadData();
            Check();
            Databinding();
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
            frmThietKe_Load(sender, e);
        }

        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked)
            {
                btnXacNhan.Enabled = false;
                //procQuanLyDonhang_ViewGridControl.DataSource = dsxCtr.LoadData_DonSanXuat_QuanLyDonHang_ThietKe_All();
                var db = new MyDBContextDataContext();
                var lst = db.LoadData_DonSanXuat_QuanLyDonHang_ThietKe().ToList();
                foreach (var item in lst)
                {
                    if (item.NghiepVu_XuongDon != null)
                    {
                        item.NghiepVu_XuongDon = "True";
                    }
                    if (item.ThietKeNhan != null)
                    {
                        item.ThietKeNhan = "True";
                    }
                    if (item.ThietKeHoanThanh != null)
                    {
                        item.ThietKeHoanThanh = "True";
                    }
                    if (item.CtfNhan != null)
                    {
                        item.CtfNhan = "True";
                    }
                    if (item.CtfHoanThanh != null)
                    {
                        item.CtfHoanThanh = "True";
                    }
                    if (item.CtpNhan != null)
                    {
                        item.CtpNhan = "True";
                    }
                    if (item.CtpHoanThanh != null)
                    {
                        item.CtpHoanThanh = "True";
                    }

                    if (item.HoanThanh != null)
                    {
                        item.HoanThanh = "True";
                    }
                }
                procQuanLyDonhang_ViewGridControl.DataSource = lst;
            }
            else
            {
                frmThietKe_Load(sender, e);
                btnXacNhan.Enabled = true;
            }
        }



        private void btnin_Click(object sender, EventArgs e)
        {
            //procQuanLyDonhang_ViewGridControl.ShowRibbonPrintPreview();
            XtraReport1 rp = new XtraReport1();
            rp.DataSource = tdADCtr.GetData_IDTemDanAD(sCDTextEdit.Text);
            rp.databingding();
            rp.Print();
            //rp.ShowRibbonPreviewDialog();

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
            if (lst.ThietKeNhan == null)
            {
                lst.ThietKeNhan = xn;
                db.SubmitChanges();
                frmThietKe_Load(sender, e);          
            }
            else
            {
                lst.ThietKeHoanThanh = xn;
                var tb = db.tbBaoCaoThietKes.Single(s => s.IDBaoCaoThietKe == sCDTextEdit.Text);
                var nghiepvu = db.tbBaoCaoNghiepVus.Single(s => s.IDBaoCaoNghiepVu == sCDTextEdit.Text);
                tb.BanIn = "Đạt";
                tb.SanPham = "Đạt";
                tb.Layout = "Đạt";
                tb.NetChu = "Đạt";
                tb.CoChu = "Đạt";
                tb.VitriCatGap = "Đạt";
                tb.KyHieu = "Đạt";
                tb.DanhGia = "Đạt";
                tb.Size = nghiepvu.Size;
                db.SubmitChanges();
                frmThietKe_Load(sender, e);               
            }
        }

        private void procQuanLyDonhang_ViewGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                Databinding();
                var db = new MyDBContextDataContext();
                var lst = (from s in db.LoadData_DonSanXuat_QuanLyDonHang_ThietKe() where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
                xacnhan.Text = lst.ThietKeNhan;
                hoanthanh.Text = lst.ThietKeHoanThanh;

                //var dt = qldhCtr.GetData_IDQuanlydonhang(sCDTextEdit.Text);
                //xacnhan.Text = dt.Rows[0][2].ToString();
                //xacnhan.Text = dt.Rows[0][3].ToString();
            }
            catch (Exception)
            {
                // ignored
            }
        }


        public void Databinding()
        {
            sCDTextEdit.DataBindings.Clear();
            sCDTextEdit.DataBindings.Add("text", procQuanLyDonhang_ViewGridControl.DataSource, "SCD");
        }
        

        //where s.SauInHoanThanh == null && s.BoPhan == "SAU IN"  || s.BoPhan == "OFFSET" || s.BoPhan == "KỸ THUẬT SỐ"
        public void Check()
        {
            //procQuanLyDonhang_ViewGridControl.DataSource = dsxCtr.LoadData_DonSanXuat_QuanLyDonHang_ThietKe();
            var db = new MyDBContextDataContext();
            var lst = (from s in db.LoadData_DonSanXuat_QuanLyDonHang_ThietKe() where s.ThietKeHoanThanh == null && s.NghiepVu_XuongDon != null && s.HoanThanh == null select s).ToList();
            foreach (var item in lst)
            {
                if (item.NghiepVu_XuongDon != null)
                    item.NghiepVu_XuongDon = "True";
                if (item.ThietKeNhan != null)
                    item.ThietKeNhan = "True";
                if (item.ThietKeHoanThanh != null)
                    item.ThietKeHoanThanh = "True";
                if (item.CtfNhan != null)
                    item.CtfNhan = "True";
                if (item.CtfHoanThanh != null)
                    item.CtfHoanThanh = "True";
                if (item.CtpNhan != null)
                    item.CtpNhan = "True";
                if (item.CtpHoanThanh != null)
                    item.CtpHoanThanh = "True";
                if (item.HoanThanh != null)
                    item.HoanThanh = "True";
            }
            procQuanLyDonhang_ViewGridControl.DataSource = lst;

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
                var frm = new frmBaoCaoThietKe(nvObj);
                frm.ShowDialog();
        }

        private void procQuanLyDonhang_ViewGridControl_DoubleClick(object sender, EventArgs e)
        {
            //var bophan = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colBoPhan).ToString();
            //var khachhang = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colTenKhachHang).ToString();
            //var SKU = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colSKU).ToString();
            //if (bophan == PrintRibbon.temvai && khachhang == PrintRibbon.AD)
            //{
            //    var frm = new frmTemDanAD();
            //    frm.ShowDialog();
            //    var db = new MyDBContextDataContext();
            //        var tb = db.tbBaoCaoThietKes.Single(s => s.IDBaoCaoThietKe == sCDTextEdit.Text);
            //        var nghiepvu = db.tbBaoCaoNghiepVus.Single(s => s.IDBaoCaoNghiepVu == sCDTextEdit.Text);
            //        tb.BanIn = "Đạt";
            //        tb.SanPham = "Đạt";
            //        tb.Layout = "Đạt";
            //        tb.NetChu = "Đạt";
            //        tb.CoChu = "Đạt";
            //        tb.VitriCatGap = "Đạt";
            //        tb.KyHieu = "Đạt";
            //        tb.DanhGia = "Đạt";
            //        tb.Size = nghiepvu.Size;
            //        db.SubmitChanges();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn đã chọn sai đơn hàng");
            //}

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var frm = new frmTemDan1SKU();
            frm.ShowDialog();
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            //var db = new MyDBContextDataContext();
            //var lst = (from s in db.tbTemDanAds where s.IDTemDanAD == sCDTextEdit.Text select s).ToList();
            //foreach (var item in lst)
            //{
            //    if (item.QTY != "500") return;
            //    item.QTY = "500 + 5";
            //}
            XtraReport1 rp = new XtraReport1();
            rp.DataSource = tdADCtr.GetData_IDTemDanAD(sCDTextEdit.Text);
            rp.databingding();
            rp.ShowRibbonPreviewDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmDonHangTemVaiAvery frm = new frmDonHangTemVaiAvery(nvObj);
            frm.Show();
        }
    }

}
