using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Object;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySanXuat.Kho
{
    public partial class frmKhoBTP_TPXuat : XtraForm
    {
        private readonly NhanVienObj nvObj = new NhanVienObj();
        private readonly KhoBTP_TPCtr kbtpCtr = new KhoBTP_TPCtr();
        #region SoThuTu
        public frmKhoBTP_TPXuat()
        {
            InitializeComponent();
            Load += frmKhoBTP_TPXuat_Load;
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }
        public frmKhoBTP_TPXuat(NhanVienObj nvobj)
        {
            InitializeComponent();
            nvObj = nvobj;
        }

        private void cal(int _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); }));
            }
        }

        #endregion

        private void frmKhoBTP_TPXuat_Load(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = from s in db.tbKhoBTP_TPs where s.NhapXuat == "Xuất" select s;
            tbKhoBTP_TPGridControl.DataSource = lst;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmPhieuXuatKhoBTP(nvObj, "mới", 1, null);
            frm.ShowDialog();
            frmKhoBTP_TPXuat_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNgay).ToString();
            var gioihan = DateTime.Today - Convert.ToDateTime(ngay);
            if ((int)gioihan.TotalDays <= 7 && gioihan.TotalDays >= 0)
            {
                var MaPhieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaPhieu).ToString();
                if (!string.IsNullOrEmpty(MaPhieu))
                {
                    var frm = new frmPhieuXuatKhoBTP(nvObj, MaPhieu, 2, null);
                    frm.ShowDialog();
                    frmKhoBTP_TPXuat_Load(sender, e);
                }
                else
                    MessageBox.Show("Dữ liệu này không cho phép chỉnh sửa");
            }
            else
            {
                MessageBox.Show("Dữ liệu đã vượt quá thời gian cho phép chỉnh sửa");
            }
        }
        private void btnPhieuXuatKho_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbKhoBTP_TPs.ToList();
            var _MaPhieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaPhieu).ToString();
            var tong = 0;
            foreach (var tbKhoNlv in lst)
            {
                if (tbKhoNlv.MaPhieu != _MaPhieu) continue;
                tong = 1;
                var rp = new rpPhieuXuatKhoBTP();
                rp.DataSource = kbtpCtr.GetData("MaPhieu", _MaPhieu);
                rp.databing();
                rp.ShowRibbonPreviewDialog();
                break;
            }

            if (tong == 0)
                MessageBox.Show("Vui lòng Xuất kho mã phiếu " + _MaPhieu + " này trước khi in");
        }
    }

}