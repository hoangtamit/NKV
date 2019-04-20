using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraVerticalGrid.Rows;
using QuanLySanXuat.Object;
using QuanLySanXuat.Control;
using QuanLySanXuat.LinqToSql;

namespace QuanLySanXuat
{
    public partial class frmDonHangTemVaiAvery : DevExpress.XtraEditors.XtraForm
    {
        private readonly NhanVienObj nvObj;
        private readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        private int iFiles;
        //private int iDirectories = 0;
        //private Panel panel1;
        //private StatusBar statusBar1;
        //GridHitInfo downHitInfor;
        private DataTable dt;
        public frmDonHangTemVaiAvery(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }

        private void frmDonHangTemVaiAvery_Load(object sender, EventArgs e)
        {
            Ngayxuongdontxt.DateTime = DateTime.Today;
            Ngayxuongdontxt_EditValueChanged(sender, e);
        }

        private void Ngayxuongdontxt_EditValueChanged(object sender, EventArgs e)
        {
            //var db = new DonHangTemVaiAveryDataContext();
            //var donhang = db.GetTable<tbDonHangTemVaiAvery>();
            //var query = from s in donhang select s;
            //gridControl1.DataSource = query;


            dt = dsxCtr.DonSanXuat_DonHangTemVaiAvery(Ngayxuongdontxt.Text);
            gridControl1.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Create an empty list.
            var rows = new ArrayList();
            // Add the selected rows to the list.
            for (var i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
            }

            if ((Convert.ToInt32(rows.Count) <= 0)) return;
            try
            {
                gridView1.BeginUpdate();
                foreach (var t in rows)
                {
                    var xn = nvObj.Tennhanvien + " " + DateTime.Now;
                    // Change the field value.
                    if (!(t is DataRow row)) continue;
                    var scd = row["SCD"].ToString();
                    //var gopdon = row["LoaiChi"].ToString();
                    //var so = row["SO"].ToString();
                    var db = new MyDBContextDataContext();
                    var donhang = (from s in db.tbDonHangTemVaiAveries where s.IDDonHangTemVaiAvery == scd select s).Single();
                    if (string.IsNullOrEmpty(donhang.XacNhan))
                    {
                        donhang.XacNhan = xn;
                        db.SubmitChanges();
                        //var a = so.Split('-');
                        //var filename = "LAYOUT " + a[0].Trim() + ".pdf"; ;
                        //var PathSource = txtDuongDan.Text + "\\" + gopdon;
                        //var PathDest = txtDuongDan.Text + "\\" + "DataThietKe";
                        //var FileSource = Path.Combine(PathSource, filename);
                        //var FileDest = Path.Combine(PathDest, filename);

                        //var URL = txtDuongDan.Text + "\\" + gopdon + "\\" + filename;
                        //var thumucmoi = txtDuongDan.Text + "\\" + "DataThietKe";
                        //if (!Directory.Exists(thumucmoi))
                        //{
                        //    Directory.CreateDirectory(thumucmoi);
                        //}
                        //File.Copy(FileSource, FileDest, true);
                    }
                    else
                        MessageBox.Show("Mã SO  " + donhang.SO + "  đã được xác nhận bởi  " + donhang.XacNhan);
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                gridView1.EndUpdate();
                MessageBox.Show(PrintRibbon.capnhat);
                Ngayxuongdontxt_EditValueChanged(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbDonHangTemVaiAveries where s.XacNhan != null && s.XacNhan2 == null select s).ToList();
            foreach (var item in lst)
            {
                item.XacNhan2 = "1";
            }
            db.SubmitChanges();
            Ngayxuongdontxt_EditValueChanged(sender, e);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEdit1.Checked)
            {
                dt = dsxCtr.DonSanXuat_DonHangTemVaiAvery_All(Ngayxuongdontxt.Text);
                gridControl1.DataSource = dt;
            }
            else
            {
                Ngayxuongdontxt_EditValueChanged(sender, e);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var db = new MyDBContextDataContext();
            //    var scd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSCD).ToString();
            //    var lst = (from s in db.tbDonHangTemVaiAveries where s.IDDonHangTemVaiAvery == scd select s).Single();
            //    textEdit1.Text = lst.XacNhan;
            //}
            //catch (Exception)
            //{
            //    // ignored
            //}
            try
            {
                //var db = new MyDBContextDataContext();
                //var scd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSCD).ToString();
                //var lst = (from s in db.tbDonHangTemVaiAveries where s.IDDonHangTemVaiAvery == scd select s).Single();
                //textEdit1.Text = lst.XacNhan;

                var gopdon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSTT).ToString();
                var URL = txtDuongDan.Text + "\\" + gopdon;
                //MessageBox.Show(URL);
                AddFiles(URL);

            }
            catch (Exception)
            {
                // ignored
            }
        }
        private void AddFiles(string strPath)
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            iFiles = 0;
            try
            {
                var di = new DirectoryInfo(strPath + "");
                var theFiles = di.GetFiles();
                foreach (var theFile in theFiles)
                {
                    iFiles++;
                    string _Size;
                    _Size = theFile.Length < 1024 ? $"{theFile.Length} Bytes" : $"{theFile.Length / 1024:### ### ###} KB";

                    var lvItem = new ListViewItem(theFile.Name);
                    lvItem.SubItems.Add(_Size);
                    lvItem.SubItems.Add(theFile.LastWriteTime.ToString("dd/MM/yyyy"));
                    lvItem.SubItems.Add(theFile.LastWriteTime.ToShortTimeString());
                    listView1.Items.Add(lvItem);
                }
            }
            catch (Exception)
            { //statusBar1.Text = Exc.ToString();
            }
            listView1.EndUpdate();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //var gopdon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colLoaiChi).ToString();
                //var so = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSO).ToString();
                //var a = so.Split('-');
                //var b = "LAYOUT " + a[0].Trim();
                //var URL = txtDuongDan.Text + "\\" + gopdon + "\\" + b + ".pdf" ;
                //MessageBox.Show(URL);
                //System.Diagnostics.Process.Start(URL);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnXacNhan2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            Point pt = listView1.PointToClient(new Point(e.X, e.Y));
            ListViewItem ItemDrag = listView1.GetItemAt(pt.X, pt.Y);
            if (ItemDrag == null) { return; }

            int ItemDragIndex = ItemDrag.Index;
            var sel = new ListViewItem[listView1.SelectedItems.Count];
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                sel[i] = listView1.SelectedItems[i];
            }

            for (int i = 0; i < sel.GetLength(0); i++)
            {
                ListViewItem Item = sel[i];
                int ItemIndex = ItemDragIndex;
                if (ItemIndex == Item.Index) { return; }

                if (Item.Index < ItemIndex)
                    ItemIndex++;
                else
                {
                    ItemIndex = ItemDragIndex + 1;
                }

                ListViewItem InsertItem = (ListViewItem)Item.Clone();
                listView1.Items.Insert(ItemIndex, InsertItem);
                listView1.Items.Remove(Item);
            }}

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            for (var i = 0; i <= gridView1.RowCount - 1; i++)
            {
                var dr = gridView1.GetDataRow(i);
                if (dr.RowState != DataRowState.Modified) continue;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonHangTemVaiAveries where s.SO == dr["SO"].ToString() select s).Single();
                lst.GhiChu = dr["GhiChu"].ToString();
                db.SubmitChanges();


                //var donhang = db.GetTable<tbDonHangTemVaiAvery>();
                //var lst = (from s in donhang where s.SO == dr["SO"].ToString() select s).Single();
                //var query = from s in donhang select s;
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            // Create an empty list.
            var rows = new ArrayList();
            // Add the selected rows to the list.
            for (var i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
            }

            if ((Convert.ToInt32(rows.Count) <= 0)) return;
            try
            {
                var tong1 = 0;
                var tong = "";
                gridView1.BeginUpdate();
                foreach (var t in rows)
                {
                    // Change the field value.
                    if (!(t is DataRow row)) continue;
                    tong1 = tong1 + 1;
                    var scd = row["SCD"].ToString();
                    //var gopdon = row["LoaiChi"].ToString();
                    //var so = row["SO"].ToString();
                    var db = new MyDBContextDataContext();
                    var dsx = (from s in db.tbDonSanXuats where s.SCD == scd select s).Single();
                    if (tong1 == 1)
                        tong = tong + dsx.MaDonHang;
                    else
                    {   tong = tong + "-" +dsx.MaDonHang.Substring(6, 4);}
                }

                textEdit1.Text = tong + " ADVN.pdf";
                //MessageBox.Show(tong);
            }
            catch
            {
                // ignored
            }
            finally
            {
                gridView1.EndUpdate();}
        }
    }
}