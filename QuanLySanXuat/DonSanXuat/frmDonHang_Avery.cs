using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmDonHang_Avery : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt;
        public frmDonHang_Avery()
        {
            InitializeComponent();
        }

        private DonSanXuat_AveryCtr dsxAveryCtr = new DonSanXuat_AveryCtr();
        private void frmDonHang_Avery_Load(object sender, EventArgs e)
        {
            dt = dsxAveryCtr.GetData_Donsanxuat_Avery_Standard_TongTien();
            tbDonSanXuat_AveryGridControl.DataSource = dt;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            // Create an empty list.
            var rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
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
                        var a = row["SO"];
                        var db = new MyDBContextDataContext();
                        var tb = (from s in db.tbDonSanXuat_Averies where s.SO == a.ToString() select s).Single();
                        tb.XacNhan = 1;
                        db.SubmitChanges();
                    }
                }
                finally
                {
                    gridView1.EndUpdate();
                    MessageBox.Show("Xác nhận thành công");
                    frmDonHang_Avery_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Xác nhận không thành công");
            }

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            tbDonSanXuat_AveryGridControl.ShowRibbonPrintPreview(); 
        }

        private void hiendonhang_CheckedChanged(object sender, EventArgs e)
        {
            if (hiendonhang.Checked == true)
            {
                dt = dsxAveryCtr.GetData_Donsanxuat_Avery_Standard_NotNull();
                btnXacNhan.Enabled = false;
                tbDonSanXuat_AveryGridControl.DataSource = null;
                tbDonSanXuat_AveryGridControl.DataSource = dt;
            }
            else
            {
                btnXacNhan.Enabled = true;
                frmDonHang_Avery_Load(sender,e);
            }
        }

        private void tbDonSanXuat_AveryGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}