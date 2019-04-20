using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static QuanLySanXuat.PrintRibbon;
using QuanLySanXuat.Object;
using QuanLySanXuat.Control;

namespace QuanLySanXuat
{
    public partial class frmStandard : XtraForm
    {
        public DataTable tbl;
        private readonly StandardObj sdObj = new StandardObj();
        private readonly StandardCtr sdCtr = new StandardCtr();
        public frmStandard()
        {
            InitializeComponent();
        }


        private void frmStandard_Load(object sender, EventArgs e)
        {
            itemLabel1.Hide();
            tbl = sdCtr.LoadData();
            tbStandardGridControl.DataSource = tbl;

            itemLabel1.DataBindings.Clear();
            itemLabel1.DataBindings.Add("text", tbStandardGridControl.DataSource, "ItemCode");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.CopyToClipboard();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var data = ClipboardData.Split('\n');
            if (data.Length < 1)
            {return;
            }
            foreach (var row in data)
            {
                AddRow(row);
            }
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataRow dr;
            for (var index = 0; index <= gridView1.RowCount - 1; index++)
            {
                dr = gridView1.GetDataRow(index);
                // Nếu dữ liệu trên grid view có thêm mới dữ liệu
                if (dr.RowState == DataRowState.Added)
                {
                    sdObj.ItemCode = dr["ItemCode"].ToString();
                    sdObj.Printing = dr["Printing"].ToString();
                    sdObj.RBO = dr["RBO"].ToString();
                    sdObj.MaterialCode = dr["MaterialCode"].ToString();
                    sdObj.PrintSize = dr["PrintSize"].ToString();
                    sdObj.InkCode = dr["InkCode"].ToString();
                    sdObj.Note = dr["Note"].ToString();
                    sdObj.Price = (float)Convert.ToDouble(dr["Price"]);
                    //Kiểm tra mã sinh đã tồn tại chưa
                    if (sdCtr.KiemTra(sdObj.ItemCode) == 0)//(_kiemtra("select count(*) from tbStandard where ItemCode ='" + sdObj.InkCode + "'") == 0)
                    {
                        sdCtr.AddData(sdObj);
                        //_Save("INSERT INTO tbStandard(ItemCode,Printing,RBO,MaterialCode,PrintSize,InkCode,Note,Price ) " +
                        //      "VALUES('" + sdObj.ItemCode + "',N'" + sdObj.Printing + "',N'" + sdObj.RBO + "',N'" + sdObj.MaterialCode + "','" + sdObj.PrintSize + "',N'" + sdObj.InkCode + "' , N'" + sdObj.Note + "', N'" + sdObj.Price + "') ");
                    }
                }

            }
            MessageBox.Show("Thêm dữ liệu thành công");
        }
        //public void taoketnoi()
        //{
        //    var str = @"Data Source=192.168.1.100;Initial Catalog=NKV;User ID=sa;Password=Ngochoa123";
        //    con.ConnectionString = str;
        //    con.Open();
        //}
        //public void dongketnoi()
        //{
        //    con.Close();
        //}
        //public DataTable _load_data(string strLenh)
        //{
        //    var dt = new DataTable();
        //    taoketnoi();
        //    var cmd = new SqlDataAdapter(strLenh, con);
        //    cmd.Fill(dt);
        //    dongketnoi();
        //    return dt;
        //}

        //public int _kiemtra(string strLenh)
        //{
        //    int str;
        //    taoketnoi();
        //    var cmd = new SqlCommand(strLenh, con);
        //    str = (int)cmd.ExecuteScalar();
        //    dongketnoi();
        //    return str;
        //}

        //public void _Save(string strLenh)
        //{
        //    taoketnoi();
        //    var d = "set dateformat dmy";
        //    var cmd1 = new SqlCommand(d, con);
        //    cmd1.ExecuteNonQuery();
        //    var cmd = new SqlCommand(strLenh, con);
        //    cmd.ExecuteNonQuery();
        //    dongketnoi();
        //}
        private string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData.ToString() == "")
                {
                    return "";
                }

                if (iData.GetDataPresent(DataFormats.UnicodeText))
                {
                    return (string)iData.GetData(DataFormats.UnicodeText);
                }
                return "";
            }
            set { Clipboard.SetDataObject(value); }
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

        private void tbStandardGridControl_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MyDBContextDataContext();
                var standard = (from a in db.tbStandards where a.ItemCode == itemLabel1.Text select a).Single();
                db.tbStandards.DeleteOnSubmit(standard);
                db.SubmitChanges();
                MessageBox.Show(xoathanhcong);
                frmStandard_Load(sender, e);
            }
            else
                MessageBox.Show(xoathatbai);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            for (var i = 0; i <= gridView1.RowCount - 1; i++)
            {
                var dr = gridView1.GetDataRow(i);
                if (dr.RowState == DataRowState.Modified)
                {
                    if (XtraMessageBox.Show("Bạn có muốn cập nhật không", "Cảnh báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var db = new MyDBContextDataContext();
                        MessageBox.Show(dr["ItemCode"].ToString());
                        var tb = db.tbStandards.Single(s => s.ItemCode == dr["ItemCode"].ToString());
                        tb.Printing = dr["Printing"].ToString();
                        tb.RBO = dr["RBO"].ToString();
                        tb.MaterialCode = dr["MaterialCode"].ToString();
                        tb.PrintSize = dr["PrintSize"].ToString();
                        tb.InkCode = dr["InkCode"].ToString();
                        tb.Note = dr["Note"].ToString();
                        tb.Price = Convert.ToDouble(dr["Price"]);
                        db.SubmitChanges();
                        //frmNhaCungCap_Load(sender, e);
                        MessageBox.Show(capnhat);
                    }
                }
                //else if (dr.RowState == DataRowState.Added)
                //{
                //    if (XtraMessageBox.Show("Bạn có muốn thêm không", "Cảnh báo", MessageBoxButtons.YesNo,
                //            MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        var db = new MyDBContextDataContext();
                //        var tb = new tbStandard();
                //        tb.ItemCode = dr["ItemCode"].ToString();
                //        tb.Printing = dr["Printing"].ToString();
                //        tb.RBO = dr["RBO"].ToString();
                //        tb.MaterialCode = dr["MaterialCode"].ToString();
                //        tb.PrintSize = dr["PrintSize"].ToString();
                //        tb.InkCode = dr["InkCode"].ToString();
                //        tb.Note = dr["Note"].ToString();
                //        tb.Price = (int)dr["Price"];
                //        db.tbStandards.InsertOnSubmit(tb);
                //        db.SubmitChanges();
                //        MessageBox.Show(themthanhcong);
                //        //frmNhaCungCap_Load(sender, e);
                //    }
                //}
            }
        }
    }
}