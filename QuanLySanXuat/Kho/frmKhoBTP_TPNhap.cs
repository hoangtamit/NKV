using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Object;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat.Kho
{
    public partial class frmKhoBTP_TPNhap : XtraForm
    {
        private readonly NhanVienObj nvObj = new NhanVienObj();
        public  readonly KhoBTP_TPCtr kbtpCtr = new KhoBTP_TPCtr();
        #region SoThuTu
        public frmKhoBTP_TPNhap()
        {
            InitializeComponent();
            Load += frmKhoBTP_TPNhap_Load;
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
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
                        e.Info.DisplayText = String.Empty;
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
                e.Info.DisplayText = String.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                var size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); }));
                
            }
        }

        #endregion

        
        public frmKhoBTP_TPNhap(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;

        }

        private void frmKhoBTP_TPNhap_Load(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = from s in db.tbKhoBTP_TPs where s.NhapXuat == "Nhập" select s;
            tbKhoBTP_TPGridControl.DataSource = lst;
        }
        //public void SearchLookup()
        //{
        //    // Bảng Kho BTP-TP
        //    var kbtp = new KhoBTP_TPCtr();
        //    tbKhoBTP_TPGridControl.DataSource = kbtp.LoadData();
        //}
        private void btnthem_Click(object sender, EventArgs e)
        {
            var frm = new frmPhieuNhapKhoBTP(nvObj, "mới", 1,null);
            frm.ShowDialog();
            frmKhoBTP_TPNhap_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNgay).ToString();
            var gioihan = DateTime.Today - Convert.ToDateTime(ngay);
            if ((int)gioihan.TotalDays <= 7 && gioihan.TotalDays >= 0)
            {
                var MaPhieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaPhieu).ToString();
                if (!string.IsNullOrEmpty(MaPhieu))
                {
                    var frm = new frmPhieuNhapKhoBTP(nvObj, MaPhieu, 2, null);
                    frm.ShowDialog();
                    frmKhoBTP_TPNhap_Load(sender, e);
                }
                else
                    MessageBox.Show("Dữ liệu này không cho phép chỉnh sửa");
            }
            else
            {
                MessageBox.Show("Dữ liệu đã vượt quá thời gian cho phép chỉnh sửa");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var maphieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaPhieu).ToString();
                var ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNgay).ToString();
                var gioihan = DateTime.Today - Convert.ToDateTime(ngay);
                if ((int)gioihan.TotalDays <= 7 && gioihan.TotalDays >= 0)
                {
                    kbtpCtr.DelData("MaPhieu", maphieu);
                    MessageBox.Show("Xóa thành công");
                    frmKhoBTP_TPNhap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không được phép xóa dữ liệu đã thống kế tồn kho");
                }
            }
            else
                MessageBox.Show("Xóa thất bại");
        }
        private void btnin_Click(object sender, EventArgs e)
        {
            tbKhoBTP_TPGridControl.ShowRibbonPrintPreview();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmKhoBTP_TPNhap_Load(sender,e);
        }

        private void btnPhieuNhapKho_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbKhoBTP_TPs.ToList();
            var _MaPhieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaPhieu).ToString();
            var tong = 0;
            foreach (var tbKhoNlv in lst)
            {
                if (tbKhoNlv.MaPhieu != _MaPhieu) continue;
                tong = 1;
                var rp = new rpPhieuNhapKhoBTP();
                rp.DataSource = kbtpCtr.GetData("MaPhieu", _MaPhieu);
                rp.databing();
                rp.ShowRibbonPreviewDialog();
                break;
            }

            if (tong == 0)
                MessageBox.Show("Vui lòng Lưu kho mã phiếu " + _MaPhieu + " này trước khi in");
        }
    }
}