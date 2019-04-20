using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.Kho
{
    public partial class frmNhaCungCap : XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private NhaCungCapCtr nccCtr = new NhaCungCapCtr();
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            tbNhaCungCapGridControl.DataSource = nccCtr.LoadData();
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
        }
 
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            for (int i = 0; i <= gridView1.RowCount - 1; i++)
            {
                var dr = gridView1.GetDataRow(i);
                if (dr.RowState == DataRowState.Modified)
                {
                    if (XtraMessageBox.Show("Bạn có muốn cập nhật không", "Cảnh báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var db = new MyDBContextDataContext();
                        var tb = db.tbNhaCungCaps.Single(s => s.IDNhaCungCap == (int) dr["IDNhaCungCap"]);
                        tb.TenNhaCungCap = dr["TenNhaCungCap"].ToString();
                        tb.DIACHI = dr["DIACHI"].ToString();
                        tb.MASOTHUE = dr["MASOTHUE"].ToString();
                        tb.NGUOILIENHE = dr["NGUOILIENHE"].ToString();
                        tb.EMAIL = dr["EMAIL"].ToString();
                        tb.DIACHI = dr["DIACHI"].ToString();
                        tb.TINHTRANG = dr["TINHTRANG"].ToString();
                        tb.GHICHU = dr["GHICHU"].ToString();
                        db.SubmitChanges();
                        //frmNhaCungCap_Load(sender, e);
                        MessageBox.Show(PrintRibbon.capnhat);
                        
                    }
                }
                else if (dr.RowState == DataRowState.Added)
                {
                    if (XtraMessageBox.Show("Bạn có muốn thêm không", "Cảnh báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var db = new MyDBContextDataContext();
                        var tb = new tbNhaCungCap();
                        tb.TenNhaCungCap = dr["TenNhaCungCap"].ToString();
                        tb.DIACHI = dr["DIACHI"].ToString();
                        tb.MASOTHUE = dr["MASOTHUE"].ToString();
                        tb.NGUOILIENHE = dr["NGUOILIENHE"].ToString();
                        tb.EMAIL = dr["EMAIL"].ToString();
                        tb.DIACHI = dr["DIACHI"].ToString();
                        tb.TINHTRANG = dr["TINHTRANG"].ToString();
                        tb.GHICHU = dr["GHICHU"].ToString();
                        db.tbNhaCungCaps.InsertOnSubmit(tb);
                        db.SubmitChanges();
                        MessageBox.Show(PrintRibbon.themthanhcong);
                        //frmNhaCungCap_Load(sender, e);
                    }
                }
            }

        }

      

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string dulieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDNhaCungCap).ToString();
                nccCtr.DelData(dulieu);
                gridView1.DeleteSelectedRows();
                MessageBox.Show(PrintRibbon.xoathanhcong);
            }
        }
    }
}