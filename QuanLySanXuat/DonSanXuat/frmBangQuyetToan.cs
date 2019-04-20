using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmBangQuyetToan : DevExpress.XtraEditors.XtraForm
    {
        private QuanLyTienTeCtr qlttCtr = new QuanLyTienTeCtr();
        private readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        private readonly NhanVienObj nvObj;
        private DataTable dt;
        public frmBangQuyetToan(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }

        private void frmBangQuyetToan_Load(object sender, EventArgs e)
        {
            sCDLabel1.Hide();
            check();
        }
        
        public void check()
        {
            var db = new MyDBContextDataContext();
            var dsx = (from a in db.DonSanXuat_TienTe_View() where a.KetChuyen == null select a).ToList();
            dt = dsxCtr.LoadData_DonSanXuat_TienTe();
            foreach (var item in dsx)
            {
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (item.VAT != null && item.VAT == 1.1)
                    item.VAT = 1.1;
            }
            gcDonSanXuat.DataSource = dsx;
            sCDLabel1.DataBindings.Clear();
            sCDLabel1.DataBindings.Add("text", gcDonSanXuat.DataSource, "IDTienTe");
            sCDLabel1.Hide();
        }
        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked == true)
            {
                var db = new MyDBContextDataContext();
                var dsx = db.DonSanXuat_TienTe_View().ToList();
                foreach (var item in dsx)
                {
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    if (item.VAT == 1.1)
                        item.VAT = 1.1;
                }
                gcDonSanXuat.DataSource = dsx;
            }
            else
            {
                frmBangQuyetToan_Load(sender,e);
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {

            gcDonSanXuat.ShowRibbonPrintPreview();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xác nhận không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Create an empty list.
                var rows = new ArrayList();
                // Add the selected rows to the list.
                for (var i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    if (gridView1.GetSelectedRows()[i] >= 0)
                        rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
                }
                if ((Convert.ToInt32(rows.Count) > 0))
                {
                    try
                    {
                        gridView1.BeginUpdate();
                        foreach (var t in rows)
                        {
                            var row = t as DataRow;
                            // Change the field value.
                            if (row == null) continue;
                            var a = row["SCD"];
                            row.ItemArray = new object[4];
                            var db = new MyDBContextDataContext();
                            var dsx = (from s in db.DonSanXuat_TienTe_View() where s.SCD == a.ToString() select s).Single();
                            dsx.KetChuyen = "1";
                            db.SubmitChanges();
                        }
                    }
                    finally
                    {
                        gridView1.EndUpdate();
                        MessageBox.Show(" Xác nhận thành công");
                        frmBangQuyetToan_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show(" Xác nhận thất bại");
                }

            }
            else
                MessageBox.Show(" Xác nhận thất bại");

            frmBangQuyetToan_Load(sender,e);
        }

        private void gcDonSanXuat_Click(object sender, EventArgs e)
        {
            //var db = new MyDBContextDataContext();
            //var dsx = (from s in db.tbDonSanXuats select s).Single();
            //sCDLabel1.Text = dsx.SCD;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var dsx = (from s in db.tbQuanLyTienTes where s.IDTienTe == sCDLabel1.Text select s).Single();
            dsx.NgayNhanTien = dateEdit1.DateTime;
            db.SubmitChanges();
            frmBangQuyetToan_Load(sender, e);          
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //sCDLabel1.Text = gridView1.GetRowCellValue(e.RowHandle, "SCD").ToString();
            //lblNgayNhanTien.Text = gridView1.GetRowCellValue(e.RowHandle, "NgayNhanTien").ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
            var frm = new frmDonSanXuat_CapNhat(lst.SCD,nvObj);
            frm.ShowDialog();
            frmBangQuyetToan_Load(sender, e);
        }
    }
}