using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmMarkAvery : XtraForm
    {
        private readonly SqlConnection con = new SqlConnection();
        private DataTable tbl;
        public void taoketnoi()
        {
            var str = @"Data Source=192.168.1.100;Initial Catalog=NKV;User ID=sa;Password=Ngochoa123";
            con.ConnectionString = str;
            con.Open();
        }
        public void dongketnoi()
        {
            con.Close();
        }
        public DataTable _load_data(string strLenh)
        {
            var dt = new DataTable();
            taoketnoi();
            var cmd = new SqlDataAdapter(strLenh, con);
            cmd.Fill(dt);
            dongketnoi();
            return dt;
        }

        public int _kiemtra(string strLenh)
        {
            int str;
            taoketnoi();
            var cmd = new SqlCommand(strLenh, con);
            str = (int)cmd.ExecuteScalar();
            dongketnoi();
            return str;
        }

        public void _Save(string strLenh)
        {
            taoketnoi();
            var d = "set dateformat dmy";
            var cmd1 = new SqlCommand(d, con);
            cmd1.ExecuteNonQuery();
            var cmd = new SqlCommand(strLenh, con);
            cmd.ExecuteNonQuery();
            dongketnoi();
        }

        public frmMarkAvery()
        {
            InitializeComponent();
        }

        private void frmMarkAvery_Load(object sender, EventArgs e)
        {
            tbl = new DataTable();
            tbl = _load_data(" select * from tbMarkAvery order by stt asc");
            tbMarkAveryGridControl.DataSource = tbl;
        }

        private DataTable dt = new DataTable();
        private void btnXuat_Click_1(object sender, EventArgs e)
        {
            var rp = new rpMarkAvery();
            rp.DataSource = tbMarkAveryGridControl.DataSource;
            rp.ShowRibbonPreviewDialog();
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
            // dữ liệu đổ vào gridcontrol phải là datatable , không sử dụng linq sẽ bị báo lỗi
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

            for (var i = 0; i < gridView1.RowCount; i++)
            {
                var dr = gridView1.GetDataRow(i);
                var SO = dr["SO"].ToString();
                var qty = dr["QTY"].ToString().Replace(",", "");
                var a = "*" + SO + "/" + qty + "*";
                dr["SIREMARK"] = a;
            }


            //DataRow dr;
            //for (var index = 0; index <= gridView1.RowCount - 1; index++)
            //{
            //    dr = gridView1.GetDataRow(index);
            //    // Nếu dữ liệu trên grid view có thêm mới dữ liệu
            //    if (dr.RowState == DataRowState.Added)
            //    {
            //        var STT = dr["STT"].ToString();
            //        var RBO = dr["RBO"].ToString();
            //        var SO = dr["SO"].ToString();
            //        var OP_NO = dr["OP_NO"].ToString();
            //        var PDLINE = dr["PDLINE"].ToString();
            //        var STYLE = dr["STYLE"].ToString();
            //        var Item = dr["Item"].ToString();
            //        var SIZE = dr["SIZE"].ToString();
            //        var QTY = dr["QTY"].ToString();
            //        var CUSPO = dr["CUSPO"].ToString();
            //        var CUSJOB = dr["CUSJOB"].ToString();
            //        var GWT = dr["GWT"].ToString();
            //        var DATE = dr["DATE"].ToString();
            //        var ATO = dr["ATO"].ToString();
            //        var SIREMARK = dr["SIREMARK"].ToString();
            //        var RQD = dr["RQD"].ToString();
            //        //Kiểm tra mã sinh đã tồn tại chưa
            //        if ((_kiemtra("select count(*) from tbMarkAvery where SO ='" + SO + "'") == 0))
            //        {
            //            _Save(
            //                "INSERT INTO tbMarkAvery(STT,RBO,SO,OP_NO,PDLINE,STYLE,Item,SIZE,QTY,CUSPO,CUSJOB,GWT,DATE,ATO,SIREMARK,RQD ) VALUES('" +
            //                STT + "','" + RBO + "','" + SO + "','" + OP_NO + "','" +
            //                PDLINE + "','" + STYLE + "','" + Item + "','" + SIZE + "','" + QTY + "','" +
            //                CUSPO + "','" + CUSJOB + "','" + GWT + "' ,'" + DATE + "' ,'" + ATO + "','" +SIREMARK + "','" + RQD + "' ) ");

            //        }
            //    }

            //    //openFileDialog1.InitialDirectory = Application.StartupPath;
            //    //openFileDialog1.Filter = PrintRibbon.dinhdangexcel;
            //    //openFileDialog1.FilterIndex = 1;
            //    //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    //    LoadData(openFileDialog1.FileName);
            //}
            //MessageBox.Show("Thêm dữ liệu thành công");

            //string GetConnectionString(string excelFileName)
            //{
            //    string strConnectionString = "";
            //    if (Path.GetExtension(excelFileName).ToLower() == ".xlsx")
            //        strConnectionString =
            //            string.Format(
            //                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";",
            //                excelFileName);
            //    else if (Path.GetExtension(excelFileName).ToLower() == ".xls")
            //        strConnectionString =
            //            string.Format(
            //                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";",
            //                excelFileName);
            //    return strConnectionString;
            //}

            //void LoadData(string excelFileName)
            //{
            //    try
            //    {

            //        var cmdText = "SELECT * FROM [Sheet1$]";
            //        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdText, GetConnectionString(excelFileName)))
            //        {
            //            adapter.Fill(dt);
            //        }

            //        tbMarkAveryGridControl.DataSource = dt;
            //    }
            //    catch
            //    {
            //    }
            //}
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dt = _load_data("truncate table tbmarkavery");
            frmMarkAvery_Load(sender, e);
        }
    }
}