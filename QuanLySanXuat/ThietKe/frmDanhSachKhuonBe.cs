using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLySanXuat.Control;
using System.IO;
using System.Diagnostics;
using QuanLySanXuat.GraphicsEditor;
using DevExpress.XtraEditors.Controls;
using QuanLySanXuat.Object;

namespace QuanLySanXuat
{
    public partial class frmDanhSachKhuonBe : DevExpress.XtraEditors.XtraForm
    {
        private readonly DanhSachKhuonBeCtr dskbCtr = new DanhSachKhuonBeCtr();
        public NhanVienObj nvObj = new NhanVienObj();
        public frmDanhSachKhuonBe(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }

        private void frmDanhSachKhuonBe_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dskbCtr.LoadData_KhuonBe();
            var itemGraphicsEdit = new RepositoryItemGraphicsEdit
            {
                SizeMode = PictureSizeMode.Squeeze,
                //BestFitWidth = 150
            };
            gridView1.Columns["HinhAnh"].ColumnEdit = itemGraphicsEdit;
            SearchLookup();
            phanquyen();
        }

        public void phanquyen()
        {
            if(nvObj.Bophan != "THIẾT KẾ")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
            }
        }
        public void SearchLookup()
        {
            // Bảng Khách Hàng
            var khCtr = new KhachHangCtr();
            risKhachHang.DataSource = khCtr.LoadData1C();
            risKhachHang.DisplayMember = "TenKhachHang";
            risKhachHang.ValueMember = "TenKhachHang";

            // Bảng Khổ Giấy In
            var kgiCtr = new KhoGiayInCtr();
            risKhoGiayIn.DataSource = kgiCtr.LoadData();
            risKhoGiayIn.DisplayMember = "KhoIn";
            risKhoGiayIn.ValueMember = "KhoIn";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Format files ( *.pdf,*.jpg, *.jpeg, *.jpe, *.jfif, *.png)| *.pdf;*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*"; ;
            open.FilterIndex = 1;
            open.Multiselect  = true;
            if (open.ShowDialog() != DialogResult.OK) return;
            if (!open.CheckFileExists) return;
            string pathPdf = null, pathJpg = null;
            var db = new MyDBContextDataContext();
            try
            {
                if (Path.GetExtension(open.SafeFileNames[0]) == ".pdf")
                {
                    pathPdf = "Khuon\\" + Path.GetFileName(open.FileNames[0]);
                    File.Copy(open.FileNames[0], pathPdf, true);

                }
                if (Path.GetExtension(open.SafeFileNames[1]) == ".jpg")
                {
                    pathJpg = "Khuon\\Hinh\\" + Path.GetFileName(open.FileNames[1]);
                    File.Copy(open.FileNames[1], pathJpg, true);
                }
            }
            catch { }
            try
            {
                if (Path.GetExtension(open.SafeFileNames[1]) == ".pdf")
                {
                    pathPdf = "Khuon\\" + Path.GetFileName(open.FileNames[1]);
                    File.Copy(open.FileNames[1], pathPdf, true);

                }
                if (Path.GetExtension(open.SafeFileNames[0]) == ".jpg")
                {
                    pathJpg = "Khuon\\Hinh\\" + Path.GetFileName(open.FileNames[0]);
                    File.Copy(open.FileNames[0], pathJpg, true);
                }
            }
            catch { }

            var tb = new tbDanhSachKhuonBe();
            DataTable dt;
            var dskbCtr = new DanhSachKhuonBeCtr();
            dt = dskbCtr.GetData_KhuonBe_IDKhuon("KB");
            tb.IDKhuon = "KB" + dskbCtr.SinhMaTuDong(dt);
            tb.DuongDan = pathPdf;
            tb.HinhAnh = pathJpg;
            tb.TenKhuon = Path.GetFileNameWithoutExtension(open.FileName);
            db.tbDanhSachKhuonBes.InsertOnSubmit(tb);
            db.SubmitChanges();
            MessageBox.Show("Thêm " + Path.GetFileNameWithoutExtension(open.FileName) + " thành công");
            frmDanhSachKhuonBe_Load(sender, e);

            //var open = new OpenFileDialog();
            //open.Filter = ".pdf,.JPG |*.pdf;*.JPG | All file (*.*)|*.*";
            //open.FilterIndex = 2;
            ////open.Multiselect = true;
            //if (open.ShowDialog() != DialogResult.OK) return;
            ////if (!open.CheckFileExists) return;
            //var db = new MyDBContextDataContext();
            //try
            //{
            //    if (Path.GetExtension(open.FileName) == ".pdf")
            //    {
            //        var path = "Khuon\\" + Path.GetFileName(open.FileName);
            //        File.Copy(open.FileName, path, true);
            //        var tb = new tbDanhSachKhuonBe();
            //        DataTable dt;
            //        var dskbCtr = new DanhSachKhuonBeCtr();
            //        dt = dskbCtr.GetData_KhuonBe_IDKhuon("KB");
            //        tb.IDKhuon = "KB" + dskbCtr.SinhMaTuDong(dt);
            //        tb.DuongDan = path;
            //        tb.TenKhuon = Path.GetFileNameWithoutExtension(open.FileName);
            //        db.tbDanhSachKhuonBes.InsertOnSubmit(tb);
            //        db.SubmitChanges();
            //        MessageBox.Show("Thêm " + Path.GetFileNameWithoutExtension(open.FileName) + " thành công");

            //    }
            //    if (Path.GetExtension(open.FileName) == ".jpg")
            //    {
            //        var path = "Khuon\\Hinh\\" + Path.GetFileName(open.FileName);
            //        File.Copy(open.FileName, path, true);
            //        var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDKhuon);
            //        var tb = (from s in db.tbDanhSachKhuonBes where s.IDKhuon == id.ToString() select s).Single();
            //        if (string.IsNullOrEmpty(tb.HinhAnh))
            //        {
            //            tb.HinhAnh = path;
            //            db.SubmitChanges();
            //            MessageBox.Show("Upload " + Path.GetFileNameWithoutExtension(open.FileName) + " thành công");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Hình ảnh đã upload rồi ");
            //        }
            //    }
            //}
            //catch { }
            //frmDanhSachKhuonBe_Load(sender, e);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                var URL = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colDuongDan).ToString();
                Process.Start(URL);
                
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            gridControl1.MainView = layoutView1;
            phanquyen();
            var itemGraphicsEdit = new RepositoryItemGraphicsEdit
            {
                SizeMode = PictureSizeMode.Squeeze,
                BestFitWidth = 100
            };
            layoutView1.Columns["HinhAnh"].ColumnEdit = itemGraphicsEdit;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn cập nhật không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    for (var i = 0; i <= gridView1.RowCount - 1; i++)
                    {
                        var dr = gridView1.GetDataRow(i);
                        if (dr.RowState != DataRowState.Modified) continue;
                        var db = new MyDBContextDataContext();
                        var tb = db.tbDanhSachKhuonBes.Single(s => s.IDKhuon == dr["IDKhuon"].ToString());
                        tb.TenKhuon = dr["TenKhuon"].ToString();
                        tb.KhachHang = dr["KhachHang"].ToString();
                        tb.LoaiKhuon = dr["LoaiKhuon"].ToString();
                        tb.KichThuoc = dr["KichThuoc"].ToString();
                        tb.SoLuongDanTrang = dr["SoLuongDanTrang"].ToString();
                        tb.DanTrang = dr["DanTrang"].ToString();
                        tb.HinhAnh = dr["HinhAnh"].ToString();
                        tb.GhiChu = dr["GhiChu"].ToString();
                        db.SubmitChanges();
                    }
            }
            catch
            {
                frmDanhSachKhuonBe_Load(sender, e);
                MessageBox.Show(PrintRibbon.capnhat);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.MainView = gridView1;
            var itemGraphicsEdit = new RepositoryItemGraphicsEdit
            {
                SizeMode = PictureSizeMode.Squeeze,
                BestFitWidth = 150

            };
            gridView1.Columns["HinhAnh"].ColumnEdit = itemGraphicsEdit;
            //frmDanhSachKhuonBe_Load(sender, e);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.MainView = layoutView1;
            var itemGraphicsEdit = new RepositoryItemGraphicsEdit
            {
                SizeMode = PictureSizeMode.Squeeze,
                BestFitWidth = 150

            };
            layoutView1.Columns["HinhAnh"].ColumnEdit = itemGraphicsEdit;
        }
        private void layoutView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var URL = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, colDuongDan1).ToString();
                Process.Start(URL);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MyDBContextDataContext();
                var ID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDKhuon).ToString();
                var pdf = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colDuongDan).ToString();
                var jpg = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colHinhAnh).ToString();
                var lst = (from s in db.tbDanhSachKhuonBes where s.IDKhuon == ID select s).Single();
                db.tbDanhSachKhuonBes.DeleteOnSubmit(lst);
                db.SubmitChanges();
                MessageBox.Show(PrintRibbon.xoathanhcong);
                File.Delete(pdf);
                //File.Delete(jpg);
                frmDanhSachKhuonBe_Load(sender, e);
            }
            else
                MessageBox.Show(PrintRibbon.xoathatbai);

        }
    }
}