using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;
//using System.Text;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Threading;
//using DevExpress.Utils.Extensions;

namespace QuanLySanXuat.Kho
{
    public partial class frmKhoNVLNhap : XtraForm
    {
        private readonly KhoNVLCtr knvlCtr = new KhoNVLCtr();
        #region SoThuTu
        public frmKhoNVLNhap()
        {
            InitializeComponent();
            Load += frmKhoNVLNhap_Load;
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
        public readonly NhanVienObj nvObj = new NhanVienObj();
        public frmKhoNVLNhap(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }
        private void frmKhoNVLNhap_Load(object sender, EventArgs e)
        {
            SearchLookup();
            phanquyen();
        }
        public void SearchLookup()
        {
            tbKhoNLVGridControl.DataSource = knvlCtr.GetData("NhapXuat", "Nhập");
        }
        public void phanquyen()
        {
            if (nvObj.Bophan == "KHONVL")
                panelControl1.Enabled = true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            var frm = new frmPhieuNhapKhoNVL(nvObj, "mới", 1);
            frm.ShowDialog();
            frmKhoNVLNhap_Load(sender,e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            var ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNgay).ToString();
            var gioihan = DateTime.Today - Convert.ToDateTime(ngay);
            if ((int) gioihan.TotalDays <= 100 && gioihan.TotalDays >= 0)
            {
                var MaPhieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaPhieu).ToString();
                if (!string.IsNullOrEmpty(MaPhieu))
                {
                    var frm = new frmPhieuNhapKhoNVL(nvObj, MaPhieu, 2);
                    frm.ShowDialog();
                    frmKhoNVLNhap_Load(sender, e);
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
                if ((int)gioihan.TotalDays <= 100 && gioihan.TotalDays >= 0)
                {
                    //var db = new MyDBContextDataContext();
                    //var lst = (from s in db.tbKhoNLVs where s.MaPhieu == maphieu select s).ToList();
                    //foreach (var tbKhoNlv in lst)
                    //{
                    //    db.tbKhoNLVs.DeleteOnSubmit(tbKhoNlv);
                    //    db.SubmitChanges();
                    //}
                    knvlCtr.DelData("MaPhieu", maphieu);
                    MessageBox.Show("Xóa thành công");
                    frmKhoNVLNhap_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("Không được phép xóa dữ liệu đã thống kế tồn kho");
                }
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void PhieuNhapKhoNVLbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var maphieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaPhieu).ToString();
            var rp = new rpPhieuNhapKhoNVL();
            var dt = knvlCtr.GetData("MaPhieu",maphieu);
            rp.DataSource = dt;
            rp.databing();
            rp.ShowRibbonPreviewDialog();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            frmKhoNVLNhap_Load(sender,e);
        }

        private void DanhSachNhapKhoNVLbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbKhoNLVGridControl.ShowRibbonPrintPreview();
        }
    }
}