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
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.MyDung
{
    public partial class frmMyDungSticker : DevExpress.XtraEditors.XtraForm
    {
        public DataTable tbl;
        public  MyDungCtr mdCtr = new MyDungCtr();
        private NhanVienObj nvObj;
        public frmMyDungSticker(NhanVienObj nvobj)
        {
            InitializeComponent();
            nvObj = nvobj;
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
            var lst = db.tbMyDungStickers.ToList();
            foreach (var item in lst)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    var dr = gridView1.GetDataRow(i);
                    var itemcode = dr["ItemCode"].ToString() + " " + dr["ItemCode2"].ToString();
                    if(itemcode != item.ItemCode)continue;
                    dr["JanCode"] = item.JanCode;
                    dr["ItemName"] = item.ItemName;
                    dr["Tana"] = item.Tana;
                    dr["Location"] = item.Location;
                    dr["Irisu"] = item.Irisu;
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

        private void frmMyDungSticker_Load(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbMyDungStickers.ToList();
            gridControl2.DataSource = lst;
            tbl = mdCtr.LoadData();
            gridControl1.DataSource = tbl;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            var rp = new rpMyDungSticker(nvObj);
            rp.DataSource = gridControl1.DataSource;
            rp.Databing();
            rp.ShowRibbonPreview();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var rp = new rpMyDungSticker2();
            rp.DataSource = gridControl1.DataSource;
            rp.Databing();
            rp.ShowRibbonPreview();
        }
    }
}