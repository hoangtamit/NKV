using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.Kho
{
    public partial class frmKhoNVLTonKho : XtraForm
    {

        #region SoThuTu
        public frmKhoNVLTonKho()
        {
            InitializeComponent();
            Load += frmKhoNVLTonKho_Load;
            Gridview1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!Gridview1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, Gridview1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, Gridview1); }));
            }
        }

        #endregion

        public readonly NhanVienObj nvObj = new NhanVienObj();
        public frmKhoNVLTonKho(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            txttungay.DateTime = Convert.ToDateTime(txttungay.DateTime.ToString("yyyy/MM/dd") + " 00:00:00");
            txtdenngay.DateTime =Convert.ToDateTime(txtdenngay.DateTime.ToString("yyyy/MM/dd") + " 23:59:59");
            var lst = (from s in db.LoadData_TonKhoNVL_View(txttungay.DateTime, txtdenngay.DateTime) select s).ToList();
            procTonKhoNVL_ViewGridControl.DataSource = lst;
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

        private void frmKhoNVLTonKho_Load(object sender, EventArgs e)
        {
            txttungay.DateTime = Convert.ToDateTime(GetFirstDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 00:00:00");
            txtdenngay.DateTime = Convert.ToDateTime(GetLastDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 23:59:59");
            var db = new MyDBContextDataContext();
            var lst = (from s in db.LoadData_TonKhoNVL_View(txttungay.DateTime, txtdenngay.DateTime) select s).ToList();
            procTonKhoNVL_ViewGridControl.DataSource = lst;
            Gridview1.Columns["HanSuDung"].Visible = false;
            Gridview1.Columns["Lo"].Visible = false;
            if (nvObj.Bophan == "KHONVL")
            {
                btnXuatExcel.Enabled = true;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            procTonKhoNVL_ViewGridControl.ShowRibbonPrintPreview();
        }

        private void Gridview1_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
        {
            //try
            //{
            //    GridView View = sender as GridView;
            //    string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["loaihang"]);
            //    if (e.Column.FieldName == "toncuoiky")
            //    {
            //        int sl = Convert.ToInt32(e.CellValue);

            //        if (category == "GIẤY " && sl < 1000)
            //        {

            //            e.Appearance.BackColor = Color.OrangeRed;
            //            e.Appearance.BackColor2 = Color.White;
            //        }
            //    }
            //}
            //catch { }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEdit1.Checked == true)
            {
                txttungay.DateTime = Convert.ToDateTime(GetFirstDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 00:00:00");
                txtdenngay.DateTime = Convert.ToDateTime(GetLastDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 23:59:59");
                var db = new MyDBContextDataContext();
                var lst = (from s in db.LoadData_TonKhoNVL_Lot_View(txttungay.DateTime, txtdenngay.DateTime) select s).ToList();
                procTonKhoNVL_ViewGridControl.DataSource = lst;
                Gridview1.Columns["HanSuDung"].Visible = true;
                Gridview1.Columns["Lo"].Visible = true;
            }
            else
            {
                frmKhoNVLTonKho_Load(sender, e);
            }
        }
    }
}