using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.MyDung
{
    public partial class frmMyDungTemVai : DevExpress.XtraEditors.XtraForm
    {
        public DataTable tbl;
        public MyDungCtr mdCtr = new MyDungCtr();
        public frmMyDungTemVai()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }

        private void frmMyDungTemVai_Load(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbMyDungTemVais.ToList();
            gridControl1.DataSource = lst;

            tbl = mdCtr.LoadData_TemVai();
            gridControl2.DataSource = tbl;

            //var db = new MyDBContextDataContext();
            //var lst = db.tbMyDungTemVais.ToList();
            //gridControl1.DataSource = lst;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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

            var db = new MyDBContextDataContext();
            var lst = db.tbMyDungTemVais.ToList();
            foreach (var item in lst)
            {
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    var dr = gridView2.GetDataRow(i);
                    if (dr["ItemCode"].ToString() != item.ItemCode) continue;
                    dr["DuongDan"] = item.DuongDan;
                }
            }
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenImages.ShowDialog() != DialogResult.OK) return;
                if (!OpenImages.CheckFileExists) return;
                foreach (var t in OpenImages.FileNames)
                {
                    var path = "Images\\TemVai\\" + Path.GetFileName(t);
                    var Itemcode = Path.GetFileNameWithoutExtension(t);
                    File.Copy(t, path, true);
                    var db = new MyDBContextDataContext();
                    var tb = new tbMyDungTemVai {ItemCode = Itemcode, DuongDan = path};
                    db.tbMyDungTemVais.InsertOnSubmit(tb);
                    db.SubmitChanges();
                }
                frmMyDungTemVai_Load(sender, e);

            }
            catch (Exception )
            {
                frmMyDungTemVai_Load(sender, e);
                //null
            }



        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var rp = new rpMyDungTemVai {DataSource = gridControl2.DataSource};
            rp.databing();
            rp.ShowRibbonPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}