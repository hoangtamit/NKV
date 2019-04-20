using System;
using System.Collections;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.Kho
{
    public partial class frmDanhSachTinhLieu : DevExpress.XtraEditors.XtraForm
    {
        private readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        private readonly NhanVienObj nvObj;

        public frmDanhSachTinhLieu(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }
        private void frmDanhSachTinhLieu_Load(object sender, EventArgs e)
        {
            //var db = new MyDBContextDataContext();
            //var lst = (from s in db.DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null() select s).ToList();
            //foreach (var collection in lst)
            //{
            //    if (collection.BoPhanSX != null)
            //    {
            //        collection.BoPhan = collection.BoPhanSX;
            //        collection.PhuongPhapIn = collection.PhuongPhapInSX;
            //    }
            //    if (collection.VatLieuSX == null) continue;
            //    collection.VatLieu = collection.VatLieuSX;
            //    collection.Kho = collection.KhoSX;
            //}
            //procDonSanXuat_ViewGridControl.DataSource = lst;
           procDonSanXuat_ViewGridControl.DataSource = dsxCtr.LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_MaHang();
        }

        private void LamMoitxt_Click(object sender, EventArgs e)
        {
            frmDanhSachTinhLieu_Load(sender, e);
        }

        private void btnDonLanhLieu_Click(object sender, EventArgs e)
        {
            procDonSanXuat_ViewGridControl.ShowRibbonPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = new ArrayList();
                // Add the selected rows to the list.
                for (var i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    if (gridView1.GetSelectedRows()[i] >= 0)
                        rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
                }
                var frm = new frmPhieuXuatKhoNVL(nvObj, "mới", 1, rows);
                frm.Show();
                //frmDanhSachTinhLieu_Load(sender, e);  
            }
            catch
            {
                // ignored
            }
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                procDonSanXuat_ViewGridControl.DataSource =
                    dsxCtr.LoadData_DonSanXuat_LanhLieu_SanXuat_NguyenVatLieu_All();
            }
            else
            {
                frmDanhSachTinhLieu_Load(sender,e);
            }
        }
    }
}