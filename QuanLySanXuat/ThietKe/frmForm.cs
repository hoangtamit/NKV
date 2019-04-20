using System;
using System.Data;
using System.Windows.Forms;
using QuanLySanXuat.Control;
using System.Diagnostics;
//using System.Drawing;
using System.IO;
using System.Linq;
using DevExpress.XtraEditors;

namespace QuanLySanXuat
{
    public partial class frmForm : XtraForm
    {
        public frmForm()
        {
            InitializeComponent();
        }

        public readonly FormCtr formCtr = new FormCtr();
        private void frmForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = formCtr.LoadData();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //var URL = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colURL).ToString();
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Filter = ".pdf,.doc,.xls|*.pdf;*.doc;*.xls| All file (*.*)|*.*";
            //Process.Start(URL);


            //if (TenForm == "Đơn Lãnh Liệu")
            //{
            //    var rp = new rpDonLanhLieu(null);
            //    rp.ShowRibbonPreviewDialog();
            //}

            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    URL = dlg.FileName;
            //}
            //Images\LFJR-TG-RE.PNG

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = ".pdf,.doc,.xls,.docx,.xlsx|*.pdf;*.doc;*.xls,*.docx,*.xlsx| All file (*.*)|*.*";
            open.FilterIndex = 2;
            if (open.ShowDialog() != DialogResult.OK) return;
            if (!open.CheckFileExists) return;
            var correctfilename = Path.GetFileName(open.FileName);
            var paths = "File\\" + correctfilename;
            var db = new MyDBContextDataContext();
            try
            {
                var tb = new tbForm();
                File.Copy(open.FileName, paths, true);
                tb.URL = paths;
                tb.TenForm = correctfilename;
                db.tbForms.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Upload " + correctfilename + " thành công");
            }
            catch
            {
                //MessageBox.Show("Hình " + correctfilename + " đã tồn tại");
                //lst.HinhMatTrai = paths;
                //db.SubmitChanges();
                //ptbHinhMatTrai.Image = Image.FromFile(paths);
            }
            frmForm_Load(sender,e);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                var URL = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colURL).ToString();
                Process.Start(URL);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for (var i = 0; i <= gridView1.RowCount - 1; i++)
            {
                var dr = gridView1.GetDataRow(i);
                if (dr.RowState != DataRowState.Modified) continue;
                if (XtraMessageBox.Show("Bạn có muốn cập nhật không", "Cảnh báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes) continue;
                var db = new MyDBContextDataContext();
                var tb = db.tbForms.Single(s => s.idForm == (int)dr["idForm"]);
                tb.TenForm = dr["TenForm"].ToString();
                tb.DienGiai = dr["DienGiai"].ToString();
                tb.URL = dr["URL"].ToString();
                db.SubmitChanges();
                MessageBox.Show(PrintRibbon.capnhat);
                frmForm_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;
            //File.Copy(open.FileName, paths, true);
            var db = new MyDBContextDataContext();
            var ID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colidForm);
            var lst = (from s in db.tbForms where s.idForm == (int) ID select s).Single();
            db.tbForms.DeleteOnSubmit(lst);
            db.SubmitChanges();
            File.Delete(lst.URL);
            frmForm_Load(sender,e);

        }
    }
}