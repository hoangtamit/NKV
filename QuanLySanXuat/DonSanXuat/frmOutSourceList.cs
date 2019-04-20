using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmOutSourceList : XtraForm
    {
        private readonly DonSanXuat_AveryCtr donSanXuatAveryCtr = new DonSanXuat_AveryCtr();

        //private readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        public DataTable tbl;
        private readonly NhanVienObj nvObj;
        private string[] rowData;
        public int flagluu;
        public int dem = 0;

        public frmOutSourceList(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }

        private void frmOutSourceList_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Today;
            dateEdit1_EditValueChanged(sender, e);

        }


        private void check_CheckedChanged(object sender, EventArgs e)
        {
            //tbl = new DataTable();
            if (check.Checked)
            {
                //tbl = donSanXuatAveryCtr.GetAllData();
                var db = new MyDBContextDataContext();
                var lst = db.tbDonSanXuat_Averies;
                GridControl1.DataSource = lst;
                dem = 1;
            }
            else
            {
                dateEdit1_EditValueChanged(sender, e);
                dem = 0;
            }

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

                newRow[i] = rowData[i].Replace("'", "");
                Math.Max(System.Threading.Interlocked.Increment(ref i), i - 1);
            }
            tbl.Rows.Add(newRow);
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            var data = ClipboardData.Split('\n');
            if (data.Length < 1)
            {
                return;
            }
            int _Colcount = 0;
            if (nvObj.Bophan == PrintRibbon.nghiepvu)
            {
                foreach (string row in data)
                {
                    _Colcount = row.Split(new char[] { '\n', '\t' }).Length;
                    break;
                }
                if (_Colcount == 16)
                {
                    foreach (string row in data)
                    {
                        flagluu = 1;
                        AddRow(row);
                    }
                }
                else if (_Colcount == 1)
                {
                    flagluu = 2;
                    for (var i = 0; i < data.Length - 1; i++)
                    {
                        rowData = data[i].Split('\n', '\t');
                        gridView1.SetRowCellValue(i, colPO, rowData[0]);
                    }

                }
                else //if(_Colcount != 1 || _Colcount != 16)
                {
                    MessageBox.Show("Số cột không đúng vui lòng xem lại");
                }


            }
            if (nvObj.Bophan == PrintRibbon.khobtp)
            {
                flagluu = 3;
                for (var i = 0; i < data.Length - 1; i++)
                {
                    rowData = data[i].Split('\n', '\t');
                    gridView1.SetRowCellValue(i, colNote, rowData[0]);
                }
            }

            //var data = ClipboardData.Split('\n');
            //if (data.Length < 1)
            //{
            //    return;
            //}
            //var db = new MyDBContextDataContext();
            //if (nvObj.Bophan == PrintRibbon.nghiepvu)
            //{

            //    for (var i = 0; i < data.Length - 1; i++)
            //    {
            //        rowData = data[i].Split('\n', '\t');
            //        if (rowData.Length > 1)
            //        {
            //            flagluu = 1;
            //            gridView1.AddNewRow();
            //            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNo, rowData[0]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colOrderDate, rowData[1]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colRequestDate, rowData[2]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSO, rowData[3]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colRBO, rowData[4]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCustomerPO,
            //                rowData[5].Replace("'", ""));
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCustomerItem,
            //                rowData[6].Replace("'", ""));
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItem, rowData[7]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQty, rowData[8]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaterial, rowData[9]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colLength, rowData[10]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaterialQty, rowData[11]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSKU, rowData[12]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCut, rowData[13]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colFold, rowData[14]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDJ, rowData[15]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colGopDon, rowData[16]);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDanhSach, txtDanhSach.Text);
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNhanVien, nvObj.Tennhanvien);
            //        }
            //        else
            //        {
            //            flagluu = 2;
            //            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colPO, rowData[0]);
            //        }
            //    }

            //}

            //if (nvObj.Bophan == "KHOBTP_TP")
            //{
            //    flagluu = 3;
            //    for (var i = 0; i < data.Length - 1; i++)
            //    {
            //        rowData = data[i].Split('\n', '\t');
            //        gridView1.SetRowCellValue(i, colNote, rowData[0]);
            //    }
            //}

            //gridView1.AddNewRow();
        }


        private string ClipboardData
        {
            get
            {
                var iData = Clipboard.GetDataObject();
                if (iData != null && iData.ToString() == string.Empty)
                {
                    return string.Empty;
                }

                if (iData != null && iData.GetDataPresent(DataFormats.UnicodeText))
                {
                    return (string)iData.GetData(DataFormats.UnicodeText);
                }

                return string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dsxObj = new DonSanXuat_AveryObj();
                if (XtraMessageBox.Show("Bạn có muốn lưu dữ liệu không", "Cảnh báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes) return;
                var db = new MyDBContextDataContext();
                if (flagluu == 1)
                {
                    for (var i = 0; i < gridView1.RowCount - 1; i++)
                    {
                        var dr = gridView1.GetDataRow(i);
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
                            //dsxObj.dj
                            dsxObj.NhanVien = nvObj.Tennhanvien;
                            dsxObj.Danhsach = (int)txtDanhSach.Value;
                            if (donSanXuatAveryCtr.Kiemtra(dsxObj.So) == 0)
                            {
                                donSanXuatAveryCtr.AddData(dsxObj);
                            }
                        }
                    }
                }
                else if (flagluu == 2)
                {
                    for (var i = 0; i < gridView1.RowCount - 1; i++)
                    {
                        var dr = gridView1.GetDataRow(i);
                        if (dr.RowState == DataRowState.Modified)
                        {
                            var dsx = (from s in db.tbDonSanXuat_Averies where s.SO == dr["SO"].ToString() select s).Single();
                            dsx.PO = dr["PO"].ToString(); 
                        }

                        //var so = gridView1.GetRowCellValue(i, colSO).ToString();
                        //var lst = (from s in db.tbDonSanXuat_Averies where s.SO == so select s).ToList();
                        //if (lst.Count != 1) continue;
                        ////lst.ForEach(x => { x.PO = gridView1.GetRowCellValue(i, colPO).ToString();});
                        //foreach (var item in lst)
                        //{
                        //    item.PO = gridView1.GetRowCellValue(i, colPO).ToString();
                        //    break;
                        //}
                    }
                }
                else if (flagluu == 3)
                {
                    for (var i = 0; i < gridView1.RowCount - 1; i++)
                    {
                        var dr = gridView1.GetDataRow(i);
                        if (dr.RowState == DataRowState.Modified)
                        {
                            var dsx = (from s in db.tbDonSanXuat_Averies where s.SO == dr["SO"].ToString() select s).Single();
                            dsx.Note = dr["Note"].ToString();
                        }
                        //var so = gridView1.GetRowCellValue(i, colSO).ToString();
                        //var lst = (from s in db.tbDonSanXuat_Averies where s.SO == so select s).ToList();
                        //if (lst.Count != 1) continue;
                        //foreach (var item in lst)
                        //{
                        //    item.Note = gridView1.GetRowCellValue(i, colNote).ToString();
                        //    break;
                        //}
                    }
                }

                db.SubmitChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("lỗi " + exception);
                //Console.WriteLine(exception);
                //throw;
            }
            //try
            //{
            //    if (XtraMessageBox.Show("Bạn có muốn lưu dữ liệu không", "Cảnh báo", MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Question) != DialogResult.Yes) return;
            //    var db = new MyDBContextDataContext();
            //    var dem = 0;
            //    if (flagluu == 1)
            //    {
            //        for (var i = 0; i < gridView1.RowCount - 1; i++)
            //        {
            //            var so = gridView1.GetRowCellValue(i, colSO).ToString();
            //            var lst = (from s in db.tbDonSanXuat_Averies where s.SO == so select s).ToList();
            //            if (lst.Count == 0)
            //            {
            //                var dsxAvery = new tbDonSanXuat_Avery();
            //                dsxAvery.SO = gridView1.GetRowCellValue(i, colSO).ToString();
            //                dsxAvery.OrderDate =
            //                    Convert.ToDateTime(gridView1.GetRowCellValue(i, colOrderDate).ToString());
            //                dsxAvery.RequestDate =
            //                    Convert.ToDateTime(gridView1.GetRowCellValue(i, colRequestDate).ToString());
            //                dsxAvery.No = Convert.ToInt32(gridView1.GetRowCellValue(i, colNo).ToString());
            //                dsxAvery.RBO = gridView1.GetRowCellValue(i, colRBO).ToString();
            //                dsxAvery.CustomerPO = gridView1.GetRowCellValue(i, colCustomerPO).ToString();
            //                dsxAvery.CustomerItem = gridView1.GetRowCellValue(i, colCustomerItem).ToString();
            //                dsxAvery.Item = gridView1.GetRowCellValue(i, colItem).ToString();
            //                dsxAvery.Qty = Convert.ToInt32(gridView1.GetRowCellValue(i, colQty).ToString());
            //                dsxAvery.Material = gridView1.GetRowCellValue(i, colMaterial).ToString();
            //                dsxAvery.Length = Convert.ToDouble(gridView1.GetRowCellValue(i, colLength).ToString());
            //                dsxAvery.MaterialQty =
            //                    Convert.ToDouble(gridView1.GetRowCellValue(i, colMaterialQty).ToString());
            //                dsxAvery.SKU = Convert.ToInt32(gridView1.GetRowCellValue(i, colSKU).ToString());
            //                dsxAvery.Cut = gridView1.GetRowCellValue(i, colCut).ToString();
            //                dsxAvery.Fold = gridView1.GetRowCellValue(i, colFold).ToString();
            //                dsxAvery.GopDon = Convert.ToInt32(gridView1.GetRowCellValue(i, colGopDon).ToString());
            //                dsxAvery.NhanVien = gridView1.GetRowCellValue(i, colNhanVien).ToString();
            //                dsxAvery.DanhSach =
            //                    Convert.ToInt32(gridView1.GetRowCellValue(i, colDanhSach).ToString());
            //                db.tbDonSanXuat_Averies.InsertOnSubmit(dsxAvery);
            //            }
            //            else
            //            {
            //                MessageBox.Show("SO: {0} đã tồn tại , vui lòng xem lại", so);
            //                dem = dem + 1;
            //            }

            //            if (dem == 3)
            //            {
            //                MessageBox.Show("Đã có 3 SO trùng nên hệ thống sẽ dừng lại");
            //                break;
            //            }
            //        }
            //    }
            //    else if (flagluu == 2)
            //    {
            //        for (var i = 0; i < gridView1.RowCount - 1; i++)
            //        {
            //            var so = gridView1.GetRowCellValue(i, colSO).ToString();
            //            var lst = (from s in db.tbDonSanXuat_Averies where s.SO == so select s).ToList();
            //            if (lst.Count != 1) continue;
            //            //lst.ForEach(x => { x.PO = gridView1.GetRowCellValue(i, colPO).ToString();});
            //            foreach (var item in lst)
            //            {
            //                item.PO = gridView1.GetRowCellValue(i, colPO).ToString();
            //                break;
            //            }

            //            //var dsxAvery = db.tbDonSanXuat_Averies.ToList().Exists(s => s.SO == so);
            //            //if(dsxAvery == false)
            //            //    foreach (var VARIABLE in dsxAvery)
            //            //    {

            //            //    }

            //        }
            //    }
            //    else if (flagluu == 3)
            //    {
            //        //DataSet ds = new DataSet();
            //        //DataTable dt = ds.Tables["tbDonSanXuat_Avery"];
            //        for (var i = 0; i < gridView1.RowCount - 1; i++)
            //        {
            //            var so = gridView1.GetRowCellValue(i, colSO).ToString();
            //            var lst = (from s in db.tbDonSanXuat_Averies where s.SO == so select s).ToList();
            //            if (lst.Count != 1) continue;
            //            foreach (var item in lst)
            //            {
            //                item.Note = gridView1.GetRowCellValue(i, colNote).ToString();
            //                break;
            //            }
            //        }
            //    }

            //    db.SubmitChanges();
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show("lỗi " + exception);
            //    //Console.WriteLine(exception);
            //    //throw;
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dateEdit1_EditValueChanged(sender, e);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var db = new MyDBContextDataContext();
            if (nvObj.Bophan == PrintRibbon.khobtp)
            {
                var so = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSO).ToString();
                var lst = (from s in db.tbDonSanXuat_Averies where s.SO == so select s).Single();
                lst.Note = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote).ToString();
                db.SubmitChanges();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    gridView1.BeginUpdate();
                    for (var i = 0; i < gridView1.SelectedRowsCount; i++)
                    {

                        var so = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colSO).ToString();
                        var db = new MyDBContextDataContext();
                        var dsx = db.tbDonSanXuat_Averies.Single(s => s.SO == so);
                        db.tbDonSanXuat_Averies.DeleteOnSubmit(dsx);
                        db.SubmitChanges();
                    }
                }
                catch (Exception)
                {
                    //null
                }
                finally
                {
                    gridView1.EndUpdate();
                    MessageBox.Show(PrintRibbon.xoathanhcong);
                    dateEdit1_EditValueChanged(sender, e);
                }
            }
            else
            {
                MessageBox.Show(PrintRibbon.xoathatbai);
            }
        }

        private void btnPackingList_Click(object sender, EventArgs e)
        {
            var dt = donSanXuatAveryCtr.GetDataNull_OrderDate_DanhSach(dateEdit1.DateTime.ToString("yyyy-MM-dd"), (int)txtDanhSach.Value);
            var rp = new rpPackingList();
            rp.DataSource = dt;
            rp.DataMember = "Table";
            rp.ShowRibbonPreviewDialog();

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            IQueryable<tbDonSanXuat_Avery> lst = null;
            if (nvObj.Bophan == PrintRibbon.nghiepvu)
            {
                tbl = donSanXuatAveryCtr.DonSanXuatAD_NhanVien_XacNhanNull(nvObj.Tennhanvien);
                lst = from s in db.tbDonSanXuat_Averies
                      where s.OrderDate == dateEdit1.DateTime && s.DanhSach == txtDanhSach.Value && s.NhanVien == nvObj.Tennhanvien
                      orderby s.No
                      select s;
            }

            if (nvObj.Bophan == PrintRibbon.khobtp)
            {
                tbl = donSanXuatAveryCtr.DonSanXuatAD_NhanVien_XacNhan2(dateEdit1.DateTime.ToString("yyyy-MM-dd"),txtDanhSach.Text);
                lst = from s in db.tbDonSanXuat_Averies
                      where s.XacNhan == 2
                      orderby s.No
                      select s;
            }

            GridControl1.DataSource = tbl;
            //dateEdit1.DateTime = DateTime.Today;
        }

        private void txtDanhSach_EditValueChanged(object sender, EventArgs e)
        {
            dateEdit1_EditValueChanged(sender, e);
        }

        private void bbiOutSourceList_Click(object sender, EventArgs e)
        {
            var dt = donSanXuatAveryCtr.GetDataNull_Nhanvien_DanhSach(nvObj.Tennhanvien, (int)txtDanhSach.Value);
            var rp = new rptOutSourceList()
            {
                DataSource = dt,
                DataMember = "Table"
            };
            rp.ShowRibbonPreviewDialog();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle < 0) return;
                var db = new MyDBContextDataContext();
                if (e.Column.FieldName == "Item")
                {
                    var _Item = gridView1.GetRowCellValue(e.RowHandle, "Item").ToString();
                    var lst = db.tbStandards.Where(s => s.ItemCode == _Item).ToList();
                    if (lst.Count > 0) return;
                        e.Appearance.BackColor = Color.PaleVioletRed;
                        btnSave.Enabled = false;
                }
                if (nvObj.Bophan != PrintRibbon.nghiepvu) return;
                if (e.Column.FieldName != "SO") return;
                var _SO = gridView1.GetRowCellValue(e.RowHandle, "SO").ToString();
                var lst2 = db.tbDonSanXuat_Averies.Where(s => s.SO == _SO).ToList();
                if (lst2.Count <= 0 || dem == 1) return;
                e.Appearance.BackColor = Color.IndianRed;
                btnSave.Enabled = false;

            }
            catch (Exception)
            {

            }

        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            //try
            //{
            //    if (e.RowHandle < 0) return;
            //    var db = new MyDBContextDataContext();
            //    if (sender is GridView view)
            //    {
            //        var _Item = view.GetRowCellValue(e.RowHandle, "Item").ToString();
            //        var lst = db.tbStandards.Where(s => s.ItemCode == _Item).ToList();
            //        if (lst.Count != 0) return;
            //             e.Appearance.BackColor = Color.PaleVioletRed;
            //        //MessageBox.Show("Item = " + _Item + " không có,hãy thêm Item vào Standard");
            //        btnSave.Enabled = false;

            //    }
            //}
            //catch (Exception)
            //{
            //    // ignored
            //}
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

                try
                {
                    gridView1.BeginUpdate();
                    for (var i = 0; i < gridView1.SelectedRowsCount; i++)
                    {

                        var so = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colSO).ToString();
                        var db = new MyDBContextDataContext();
                        var dsx = db.tbDonSanXuat_Averies.Single(s => s.SO == so);
                        dsx.XacNhan = 1;
                        db.SubmitChanges();
                    }
                }
                catch (Exception)
                {
                    //null
                }
                finally
                {
                    gridView1.EndUpdate();
                    dateEdit1_EditValueChanged(sender, e);
                }

        }
    }
}