using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Class;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.DonSanXuat
{
    internal partial class frmDonSanXuat : XtraForm
    {
        public readonly OverlayLoading overlayLoading = new OverlayLoading();
        //private readonly ConnectSQL _con = new ConnectSQL();
        //public string m_connect = @"Data Source=192.168.1.100;Initial Catalog=NKV;User ID=sa;Password=Ngochoa123";
        //private readonly ConnectSQL _con = new ConnectSQL();
        //private SqlConnection con;
        private readonly DonSanXuatCtr dsxCtrl = new DonSanXuatCtr();
        private readonly QuanLyDonHangCtr qldhCtr = new QuanLyDonHangCtr();
        private readonly QuanLyTienTeCtr qlttCtr = new QuanLyTienTeCtr();
        private readonly LanhLieuCtr llCtr = new LanhLieuCtr();
        private readonly SanXuatCtr sxCtr = new SanXuatCtr();
        public readonly NhanVienObj nvObj = new NhanVienObj();
        public readonly BaoCaoThietKeCtr bctkCtr = new BaoCaoThietKeCtr();
        public frmDonSanXuat(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }
        //public frmDonSanXuat(string manhanvien, string tennhanvien, string taikhoan, string matkhau, string ngaysinh,
        //    string gioitinh, string diachi, string dienthoai, string bophan, string chucvu, string tinhtrang, string ghichu)
        //{
        //    InitializeComponent();
        //    nvObj.Manhanvien = manhanvien;
        //    nvObj.Tennhanvien = tennhanvien;
        //    nvObj.Taikhoan = taikhoan;
        //    nvObj.Matkhau = matkhau;
        //    nvObj.Ngaysinh = ngaysinh;
        //    nvObj.Gioitinh = gioitinh;
        //    nvObj.Diachi = diachi;
        //    nvObj.Dienthoai = dienthoai;
        //    nvObj.Bophan = bophan;
        //    nvObj.Chucvu = chucvu;
        //    nvObj.Tinhtrang = tinhtrang;
        //    nvObj.Ghichu = ghichu;
        //    //dsxCtrl.broker();
        //    //var ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
        //    //ss.Demand();
        //    //SqlDependency.Stop(m_connect);
        //    //SqlDependency.Start(m_connect);
        //    //con = new SqlConnection(m_connect);
        //}

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

        //        var caulenh = "DonSanXuat_TienTe_QuanLyDonHang_View";


        //        var cmd = new SqlCommand(caulenh, con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Notification = null;

        //        var de = new SqlDependency(cmd);
        //        de.OnChange += de_OnChange;

        //        dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
        //        gcDonSanXuat.DataSource = dt;
        //        sCDLabel1.DataBindings.Clear();
        //        sCDLabel1.DataBindings.Add("text", dt, "SCD");
        //        sCDLabel1.Hide();
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
        //        OnNewHome();//    }
        //}
        private void frmDonSanXuat_Load(object sender, EventArgs e)
        {
            //CurrentThread.CurrentCulture = new Globalization.CultureInfo("vi");
            //CurrentThread.CurrentUICulture = new Globalization.CultureInfo("vi");
            //OnNewHome += dsxCtrl.Form1_OnNewHome;//tab
            //load data vao datagrid

            overlayLoading.StartLoading(gcDonSanXuat);
            gcDonSanXuat.DataSource = dsxCtrl.LoadData();
            sCDLabel1.DataBindings.Clear();
            sCDLabel1.DataBindings.Add("text", gcDonSanXuat.DataSource, "SCD");
            sCDLabel1.Hide();
            overlayLoading.EndLoading();
            //Thread.CurrentThread.CurrentCulture = new Globalization.CultureInfo("vi");
            //Thread.CurrentThread.CurrentUICulture = new Globalization.CultureInfo("vi");
        }


        #region SoThuTu
        public frmDonSanXuat()
        {
            InitializeComponent();
            Load += frmDonSanXuat_Load;
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked)
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.DonSanXuat_QuanLyDonhang_View() select s).ToList();
                gcDonSanXuat.DataSource = lst;

                sCDLabel1.DataBindings.Clear();
                sCDLabel1.DataBindings.Add("text", lst, "SCD");
            }
            else
                frmDonSanXuat_Load(sender, e);

        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)// sự kiện trong gridview , hiện màu nếu ngay giao hang gan bang ngay hien tai

        {
            //try
            //{
            //    if (sender is GridView view)
            //    {
            //        var capnhat = view.GetRowCellDisplayText(e.RowHandle, view.Columns["ChinhSua"]);
            //        switch (capnhat)
            //        {
            //            case "1":
            //                e.Appearance.BackColor = Color.AntiqueWhite;
            //                break;
            //        }

            //        var ngaygiaohang = view.GetRowCellValue(e.RowHandle, view.Columns["NgayGiaoHang"]);
            //        var dispText = (Convert.ToDateTime(ngaygiaohang) - DateTime.Today).Days.ToString();
            //        switch (dispText)
            //        {

            //            case "0":
            //                e.Appearance.BackColor = Color.OrangeRed;
            //                e.Appearance.BackColor2 = Color.White;
            //                break;
            //            case "1":
            //            case "2":
            //                e.Appearance.BackColor = Color.LightSalmon;
            //                e.Appearance.BackColor2 = Color.White;
            //                break;
            //        }

            //    }

            //}
            //catch (Exception)
            //{
            //    // ignored
            //}
        }

        private void ptbHinhMatPhai_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
            Process.Start(lst.HinhMatPhai);
            //var frm = new frmHinh(lst.HinhMatPhai, null, null);
            //    if (lst.HinhMatPhai == null) return;
            //    frm.Show();
        }

        private void ptbHinhMatTrai_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
            Process.Start(lst.HinhMatTrai);
            //var frm = new frmHinh(null, lst.HinhMatTrai, null);
            //    if (lst.HinhMatTrai == null) return;
            //    frm.Show();
        }

        private void ptbHinhKhuon_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
            Process.Start(lst.HinhKhuon);
            //var frm = new frmHinh(null, null, lst.HinhKhuon);
            //    if (lst.HinhKhuon == null) return;
            //    frm.Show();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                var masanpham = "";
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
                var frm = new frmDonSanXuat_View(lst.SCD, masanpham, nvObj);
                frm.ShowDialog();
            }
            catch (Exception)
            {
                //NULL
            }

        }

        private void ptbHinhKhuon_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gcDonSanXuat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).ToList();
                foreach (var itemTbDonSanXuat in lst)
                {
                    ptbHinhMatPhai.Image = null;
                    ptbHinhMatTrai.Image = null;
                    ptbHinhKhuon.Image = null;
                    if (itemTbDonSanXuat.HinhMatPhai != null)
                        ptbHinhMatPhai.Image = Image.FromFile(itemTbDonSanXuat.HinhMatPhai);
                    if (itemTbDonSanXuat.HinhMatTrai != null)
                        ptbHinhMatTrai.Image = Image.FromFile(itemTbDonSanXuat.HinhMatTrai);
                    if (itemTbDonSanXuat.HinhKhuon != null)
                        ptbHinhKhuon.Image = Image.FromFile(itemTbDonSanXuat.HinhKhuon);
                }

            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //sCDLabel1.Text = gridView1.GetRowCellValue(e.RowHandle, "SCD").ToString();
        }

        //private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        //{
        //    //if (e.Info == null && object.ReferenceEquals(e.SelectedControl, gcDonSanXuat))
        //    //{
        //    //    GridView view = gcDonSanXuat.FocusedView as GridView;
        //    //    GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
        //    //    if (view == null)
        //    //    {
        //    //        return;
        //    //    }
        //    //    if (info.InRowCell)
        //    //    {
        //    //        if (info.Column.FieldName == "SCD" || info.Column.FieldName == "MaDonHang")
        //    //        {
        //    //            string text = "";
        //    //            string scd = view.GetRowCellValue(info.RowHandle,view.Columns["ChuY"]).ToString();
        //    //            string mdh = view.GetRowCellValue(info.RowHandle, view.Columns["MaDonHang"]).ToString();
        //    //            text += scd + mdh;
        //    //            string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
        //    //            e.Info = new DevExpress.Utils.ToolTipControlInfo(cellKey, text);

        //    //        }
        //    //    }
        //    //}
        //}


        private void gcDonSanXuat_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).ToList();
                foreach (var itemTbDonSanXuat in lst)
                {
                    ptbHinhMatPhai.Image = null;
                    ptbHinhMatTrai.Image = null;
                    ptbHinhKhuon.Image = null;
                    if (itemTbDonSanXuat.HinhMatPhai != null)
                        ptbHinhMatPhai.Image = Image.FromFile(itemTbDonSanXuat.HinhMatPhai);
                    if (itemTbDonSanXuat.HinhMatTrai != null)
                        ptbHinhMatTrai.Image = Image.FromFile(itemTbDonSanXuat.HinhMatTrai);
                    if (itemTbDonSanXuat.HinhKhuon != null)
                        ptbHinhKhuon.Image = Image.FromFile(itemTbDonSanXuat.HinhKhuon);
                }
            }
            catch
            {
                // ignored
            }
        }
        private static void Cal(int width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)// còn cái này cũng vậy , mà hiện trên cell , cái kia row @@, rối não quá
        {
            //MyDBContextDataContext db = new MyDBContextDataContext();
            //var lst = (from s in db.tbDonSanXuats select s).ToList();
            //foreach (var item in lst)
            //{
            //    TimeSpan ngay = Convert.ToDateTime(item.NgayGiaoHang) - now;
            //   if(ngay.TotalDays <= 1)
            //    e.Appearance.BackColor = Color.OrangeRed;
            //    e.Appearance.BackColor2 = Color.White;
            //}
            //gcDonSanXuat.DataSource = lst;

            //DateTime now = DateTime.Now;
            //GridView View = sender as GridView;
            //if (e.Column.FieldName == "NgayGiaoHang")
            //{
            //    DateTime category = Convert.ToDateTime(View.GetRowCellDisplayText(e.RowHandle, View.Columns["NgayGiaoHang"]));
            //    // DateTime category = Convert.ToDateTime(e.Column["NgayGiaoHang"]);
            //    TimeSpan ngay = category - now;
            //    if (Convert.ToInt32(ngay.TotalDays) <= 3 && Convert.ToInt32(ngay.TotalDays) > 2)//Điều kiện là gì ()
            //    {
            //        e.Appearance.BackColor = Color.Yellow;
            //        e.Appearance.BackColor2 = Color.White;
            //    }
            //    if (Convert.ToInt32(ngay.TotalDays) <= 2 && Convert.ToInt32(ngay.TotalDays) > 1)
            //    {
            //        e.Appearance.BackColor = Color.Orange;
            //        e.Appearance.BackColor2 = Color.White;
            //    }
            //    if (Convert.ToInt32(ngay.TotalDays) <= 1 && Convert.ToInt32(ngay.TotalDays) > 0)
            //    {
            //        e.Appearance.BackColor = Color.Red;
            //        e.Appearance.BackColor2 = Color.White;
            //    }
            //}


            //try
            //{

            //    switch (e.Column.FieldName)
            //    {
            //        case "NgayGiaoHang":
            //            //DateTime category = Convert.ToDateTime(View.GetRowCellDisplayText(e.RowHandle, View.Columns["NgayGiaoHang"]));
            //            var ngaygiaohang = (DateTime) e.CellValue;
            //            if (ngaygiaohang > DateTime.Today)
            //            {
            //                var dispText = (ngaygiaohang - DateTime.Today).Days.ToString();
            //                //TimeSpan ngay = category - now;
            //                switch (dispText)
            //                {
            //                    case "1":
            //                    case "0":
            //                        e.Appearance.BackColor = Color.Red;
            //                        e.Appearance.BackColor2 = Color.White;
            //                        break;
            //                    case "2":
            //                        e.Appearance.BackColor = Color.Orange;
            //                        e.Appearance.BackColor2 = Color.White;
            //                        break;
            //                }
            //            }

            //            break;
            //case "BoPhan":
            //    if (sender is GridView view)
            //    {
            //        var bophan = view.GetRowCellDisplayText(e.RowHandle, view.Columns["BoPhan"]);
            //        switch (bophan)
            //        {
            //            case "OFFSET":
            //                e.Appearance.BackColor = Color.LightGreen;
            //                break;
            //            case "TEM VẢI":
            //                e.Appearance.BackColor = Color.LightCoral;
            //                break;
            //        }
            //    }

            //    break;
            //    }
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception);
            //    throw;//}
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (!e.Info.IsRowIndicator) return;
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
                var size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                var width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { Cal(width, gridView1); })); //Tăng kích thước nếu Text vượt quá
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = $"[{(e.RowHandle * -1)}]"; //Nhân -1 để đánh lại số thứ tự tăng dần
                var size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                var width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { Cal(width, gridView1); }));
            }
        }

        #endregion

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDonSanXuat_Load(sender, e);
        }



        private void btnthem_Click(object sender, EventArgs e)
        {
            const string masanpham = "";
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
            var frm = new frmDonSanXuat_Them(lst.SCD, masanpham, nvObj);   //, nvObj.Tennhanvien, nvObj.Taikhoan, nvObj.Matkhau, nvObj.Ngaysinh, nvObj.Gioitinh, nvObj.Diachi, nvObj.Dienthoai, nvObj.Bophan, nvObj.Chucvu, nvObj.Tinhtrang, nvObj.Ghichu);
            frm.ShowDialog();
            frmDonSanXuat_Load(sender, e);
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            var dt = dsxCtrl.GetData("SCD", sCDLabel1.Text);
            var rp = new rpDonSanXuat(sCDLabel1.Text) { DataSource = dt };
            rp.ShowRibbonPreview();
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
            var frm = new frmDonSanXuat_CapNhat(lst.SCD, nvObj);
            frm.ShowDialog();
            frmDonSanXuat_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MyDBContextDataContext();
                var nhanvien = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s)
                    .Single();
                if (nhanvien.NhanVienNghiepVu == nvObj.Tennhanvien)
                {
                    // Xóa lãnh liệu
                    llCtr.DelData(sCDLabel1.Text);
                    // Xóa Quản lý đơn hàng
                    qldhCtr.DelData(sCDLabel1.Text);
                    // Xóa Đơn sản xuất
                    dsxCtrl.DelData_DonSanXuat("SCD", sCDLabel1.Text);
                    // Xóa quản lý tiền tệ
                    qlttCtr.DelData(sCDLabel1.Text);
                    // Xóa Sản xuất
                    sxCtr.DelData(sCDLabel1.Text);
                    // Báo cáo thiết kế
                    bctkCtr.DelData_BaoCaoThietKe(sCDLabel1.Text);

                    var donhang = db.tbDonHangTemVaiAveries.Where(s => s.IDDonHangTemVaiAvery == sCDLabel1.Text).ToList();
                    db.tbDonHangTemVaiAveries.DeleteAllOnSubmit(donhang);
                    var temDanAds = db.tbTemDanAds.Where(s => s.IDTemDanAD == sCDLabel1.Text).ToList();
                    db.tbTemDanAds.DeleteAllOnSubmit(temDanAds);
                    var thongtin = db.tbThongTinGopDonADs.Where(s => s.SCD == sCDLabel1.Text).ToList();
                    db.tbThongTinGopDonADs.DeleteAllOnSubmit(thongtin);


                    db.SubmitChanges();

                    MessageBox.Show(PrintRibbon.xoathanhcong);
                    frmDonSanXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Nhân viên " + nhanvien.NhanVienNghiepVu + " mới có quyền xóa đơn hàng này");
                }

            }
            else
                MessageBox.Show(PrintRibbon.xoathatbai);

        }

        private void ptbHinhMatPhai_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}