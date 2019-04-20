using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLySanXuat.Kho
{
    public partial class frmKhoBTP_TPTonKho : XtraForm
    {
        #region SoThuTu
        public frmKhoBTP_TPTonKho()
        {
            InitializeComponent();
            Load += frmKhoBTP_TPTonKho_Load;
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            txttungay.DateTime = Convert.ToDateTime(txttungay.DateTime.ToString("yyyy/MM/dd") + " 01:00:00");
            txtdenngay.DateTime = Convert.ToDateTime(txtdenngay.DateTime.ToString("yyyy/MM/dd") + " 23:59:59");
            var lst = (from s in db.procTonKhoBTP_TP_View(txttungay.DateTime, txtdenngay.DateTime) select s).ToList();
            procTonKhoBTP_TP_ViewGridControl.DataSource = lst;
        }
        #region Ngaydauthang,cuoithang 
        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        public static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        public static DateTime GetLastDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        #endregion
        private void frmKhoBTP_TPTonKho_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentCulture = new Globalization.CultureInfo("vi");
            //Thread.CurrentThread.CurrentUICulture = new Globalization.CultureInfo("vi");
            txttungay.DateTime = Convert.ToDateTime(GetFirstDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 01:00:00");
            txtdenngay.DateTime = Convert.ToDateTime(GetLastDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 23:59:59");
            var db = new MyDBContextDataContext();
            var lst = (from s in db.procTonKhoBTP_TP_View(txttungay.DateTime, txtdenngay.DateTime) select s).ToList();
            procTonKhoBTP_TP_ViewGridControl.DataSource = lst;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            procTonKhoBTP_TP_ViewGridControl.ShowRibbonPrintPreview();
        }

        private void bandedGridView1_RowStyle(object sender, RowStyleEventArgs e)
        {

        }
    }
}