using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using static QuanLySanXuat.PrintRibbon;
using QuanLySanXuat.Control;
using QuanLySanXuat.DonSanXuat;
using  QuanLySanXuat.Object;

namespace QuanLySanXuat
{
    public partial class frmDonSanXuat_Avery : XtraForm
    {
        private DonSanXuat_AveryCtr donSanXuatAveryCtr = new DonSanXuat_AveryCtr();
        private readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        public DataTable tbl;
        public frmDonSanXuat_Avery()
        {
            InitializeComponent();
        }
        public readonly NhanVienObj nvObj = new NhanVienObj();
        public frmDonSanXuat_Avery(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;

        }
        private void frmDonSanXuat_Avery_Load(object sender, EventArgs e)
        {
            tbl = donSanXuatAveryCtr.DonSanXuatAD_NhanVien_XacNhanNull(nvObj.Tennhanvien);
            //var db = new MyDBContextDataContext();
            //var lst = db.DonSanXuatAD_NhanVien_XacNhanNull(nvObj.Tennhanvien);
            gridControl1.DataSource = tbl;
            gcDonSanXuat.DataSource = dsxCtr.LoadData();
            sCDLabel1.Hide();
            sCDLabel1.DataBindings.Clear();
            sCDLabel1.DataBindings.Add("text", gcDonSanXuat.DataSource, "SCD");
            OrderDate.DateTime = DateTime.Now;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xác nhận không", "Cảnh báo", MessageBoxButtons.YesNo,
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
                            var a = row["SO"];
                            row.ItemArray = new object[4];
                            var db = new MyDBContextDataContext();
                            var lst = db.tbDonSanXuat_Averies.Single(s => s.SO == a.ToString());
                            lst.XacNhan = 1;
                            db.SubmitChanges();
                            //donSanXuatAveryCtr.DelData(a.ToString());
                        }
                    }
                    finally
                    {
                        gridView1.EndUpdate();
                        MessageBox.Show(" Xác nhận thành công");
                        frmDonSanXuat_Avery_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show(xoathatbai);
                }

            }
            else
                MessageBox.Show(xoathatbai);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
            var frm = new frmDonSanXuat_Avery_CapNhat(lst.SCD, nvObj);
            frm.ShowDialog();
            frmDonSanXuat_Avery_Load(sender, e);
        }
        private void HiendonhangCheck_CheckedChanged(object sender, EventArgs e)
        {
            tbl = new DataTable();
            if (HiendonhangCheck.Checked)
                tbl = donSanXuatAveryCtr.GetAllData();
            else
                tbl = donSanXuatAveryCtr.DonSanXuatAD_NhanVien_XacNhanNull(nvObj.Tennhanvien);
            gridControl1.DataSource = tbl;
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //if (sender is GridView view)
            //{
            //    var capnhat = view.GetRowCellDisplayText(e.RowHandle, view.Columns["No"]);
            //    if (capnhat == "5") e.Appearance.BackColor = Color.Red;
            //}
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
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
                        for (int i = 0; i < rows.Count; i++)
                        {
                            var row = rows[i] as DataRow;
                            // Change the field value.
                            var a = row["SO"];
                            row.ItemArray = new object[4];
                            donSanXuatAveryCtr.DelData(a.ToString());
                        }
                    }
                    finally
                    {
                        gridView1.EndUpdate();
                        MessageBox.Show(xoathanhcong);
                        frmDonSanXuat_Avery_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show(xoathatbai);
                }

            }
            else
                MessageBox.Show(xoathatbai);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dt = donSanXuatAveryCtr.GetDataNull_Nhanvien_DanhSach(nvObj.Tennhanvien,(int)txtDanhSach.Value);
            var rp = new rptOutSourceList()
            {
                DataSource = dt,
                DataMember = "Table"
            };
            rp.ShowRibbonPreviewDialog();
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dt = dsxCtr.LoadData_DonSanXuat_NgayXuongDon_DanhSach(OrderDate.Text,(int)txtDanhSach.Value);
            var rp = new rptDonSanXuat_Avery { DataSource = dt };
            rp.databing();
            rp.ShowRibbonPreviewDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridView1.CopyToClipboard();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            var data = ClipboardData.Split('\n');
            if (data.Length < 1)
            {
                return;
            }
            foreach (string row in data)
            {
                AddRow(row);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var dsxObj = new DonSanXuat_AveryObj();
            if (XtraMessageBox.Show("Bạn có muốn lưu dữ liệu không", "Cảnh báo", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (var index = 0; index <= gridView1.RowCount - 1; index++)
                {
                    var dr = gridView1.GetDataRow(index);
                    // Nếu dữ liệu trên grid view có thêm mới dữ liệu
                    if (dr.RowState == DataRowState.Added)
                    {
                        dsxObj.No = (int)dr["No"];
                        dsxObj.Orderdate = DateTime.Parse(dr["OrderDate"].ToString());
                        dsxObj.Requestdate = DateTime.Parse(dr["RequestDate"].ToString());
                        dsxObj.So = dr["SO"].ToString();
                        dsxObj.Rbo = dr["RBO"].ToString();
                        dsxObj.Customerpo = dr["CustomerPO"].ToString();
                        dsxObj.Customeritem = dr["CustomerItem"].ToString();
                        dsxObj.Item = dr["Item"].ToString();
                        dsxObj.Qty = (int)dr["Qty"];
                        dsxObj.Material = dr["Material"].ToString();
                        dsxObj.Length = (float)Convert.ToDouble(dr["Length"]);
                        dsxObj.Materialqty = (float)Convert.ToDouble(dr["MaterialQty"]);
                        dsxObj.Sku = (int)dr["SKU"];
                        dsxObj.Cut = dr["Cut"].ToString();
                        dsxObj.Fold = dr["Fold"].ToString();
                        dsxObj.Gopdon = (int)dr["GopDon"];
                        dsxObj.NhanVien = nvObj.Tennhanvien;
                        dsxObj.Danhsach = (int)txtDanhSach.Value;                      
                        if (donSanXuatAveryCtr.Kiemtra(dsxObj.So) == 0)
                        {
                            donSanXuatAveryCtr.AddData(dsxObj);
                        }
                    }
                }
            }
            //MessageBox.Show("Thêm dữ liệu thành công");
        }
        private string ClipboardData
        {
            get
            {
                var iData = Clipboard.GetDataObject();
                if (iData != null && iData.ToString() == "")
                {
                    return "";
                }

                if (iData != null && iData.GetDataPresent(DataFormats.UnicodeText))
                {
                    return (string)iData.GetData(DataFormats.UnicodeText);
                }
                return "";
            }
            set => Clipboard.SetDataObject(value);
        }

        private void AddRow(string data)
        {
            if (data == string.Empty)
            {
                return;
            }
            var rowData = data.Split(new char[] { '\n', '\t' });
            var newRow = tbl.NewRow();

            var i = 0;
            while (i < rowData.Length)
            {
                if (i >= tbl.Columns.Count)
                {
                    break; // TODO: might not be correct. Was : Exit While
                }
                newRow[i] = rowData[i];
                Math.Max(System.Threading.Interlocked.Increment(ref i), i - 1);
            }
            tbl.Rows.Add(newRow);
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var _masanpham = "";
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
            var frm = new frmDonSanXuat_Avery_Them(lst.SCD, _masanpham, nvObj);
            frm.ShowDialog();
            frmDonSanXuat_Avery_Load(sender, e);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcDonSanXuat.ShowRibbonPrintPreview();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu dữ liệu không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (var index = 0; index <= gridView1.RowCount - 1; index++)
                {
                    var dr = gridView1.GetDataRow(index);
                    if (dr.RowState == DataRowState.Modified)
                    {
                        var db = new MyDBContextDataContext();
                        var dsx = (from s in db.tbDonSanXuat_Averies where s.SO == dr["SO"].ToString() select s).Single();
                        dsx.No = (int)dr["No"];
                        dsx.OrderDate = DateTime.Parse(dr["OrderDate"].ToString());
                        dsx.RequestDate = DateTime.Parse(dr["RequestDate"].ToString());
                        dsx.RBO = dr["RBO"].ToString();
                        dsx.CustomerPO = dr["CustomerPO"].ToString();
                        dsx.CustomerItem = dr["CustomerItem"].ToString();
                        dsx.Item = dr["Item"].ToString();
                        dsx.Qty = (int)dr["Qty"];
                        dsx.Material = dr["Material"].ToString();
                        dsx.Length = (float)Convert.ToDouble(dr["Length"]);
                        dsx.MaterialQty = (float)Convert.ToDouble(dr["MaterialQty"]);
                        dsx.SKU = (int)dr["SKU"];
                        dsx.Cut = dr["Cut"].ToString();
                        dsx.Fold = dr["Fold"].ToString();
                        dsx.GopDon = (int)dr["GopDon"];
                        dsx.scd = dr["scd"].ToString();
                        dsx.NhanVien = nvObj.Tennhanvien;
                        db.SubmitChanges();
                        MessageBox.Show(capnhat);
                    }
                }
            }
        }
    }
}