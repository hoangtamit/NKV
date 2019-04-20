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
using System.IO;
using System.Data.OleDb;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat
{
    public partial class frmBangLuong : XtraForm
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Excel Files (*.xlsx)|*.xlsx|All File(*.*)|*.*";
            //open.FilterIndex = 1;

            //string name = "Items";
            //string constr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Dialog_Excel.FileName.ToString() + "; Extented Properties =\"Excel 8.0; HDR=Yes;\";";
            //OleDbConnection con = new OleDbConnection(constr);
            //OleDbDataAdapter sda = new OleDbDataAdapter("Select * From [" + name + "$]", con);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //gridControl1.DataSource = data;
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Excel Files (.xlsx)|*.xlsx|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                LoadData(openFileDialog1.FileName);

        }
        public string GetConnectionString(string excelFileName)
        {
            string strConnectionString = "";
            if (Path.GetExtension(excelFileName).ToLower() == ".xlsx")
                strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", excelFileName);
            else if (Path.GetExtension(excelFileName).ToLower() == ".xls")
                strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", excelFileName);
            return strConnectionString;
        }

        public void LoadData(string excelFileName)
        {
            DataTable dt = new DataTable();
            string cmdText = "SELECT * FROM [Sheet1$]";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdText, GetConnectionString(excelFileName)))
            {
                adapter.Fill(dt);
            }
            gridControl1.DataSource = dt;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            rpBangLuong rp = new rpBangLuong();
            rp.ShowRibbonPreviewDialog();
        }
    }
}