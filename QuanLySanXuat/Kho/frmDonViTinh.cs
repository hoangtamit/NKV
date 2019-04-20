using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.Kho
{
    public partial class frmDonViTinh : XtraForm
    {
        private readonly DonViTinhCtr dvtCtr = new DonViTinhCtr();
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            tbDonViTinhGridControl.DataSource = dvtCtr.LoadData();
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
                        var tb = db.tbDonViTinhs.Single(s => s.ID == dr["ID"].ToString());
                        tb.DIENGIAI = dr["DIENGIAI"].ToString();
                        tb.GHICHU = dr["GHICHU"].ToString();
                        tb.TINHTRANG = dr["TINHTRANG"].ToString();
                        db.SubmitChanges();
                        //frmDonViTinh_Load(sender, e);
                        MessageBox.Show(PrintRibbon.capnhat);

                    }
                }
                else if (dr.RowState == DataRowState.Added)
                {
                    if (XtraMessageBox.Show("Bạn có muốn thêm không", "Cảnh báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var db = new MyDBContextDataContext();
                        var tb = new tbDonViTinh
                        {
                            ID = dr["ID"].ToString(),
                            DIENGIAI = dr["DIENGIAI"].ToString(),
                            GHICHU = dr["GHICHU"].ToString(),
                            TINHTRANG = dr["TINHTRANG"].ToString()
                        };
                        db.tbDonViTinhs.InsertOnSubmit(tb);
                        db.SubmitChanges();
                        MessageBox.Show(PrintRibbon.themthanhcong);
                        //frmDonViTinh_Load(sender, e);
                    }
                }
            }
        }

        private void Xoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string dulieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colID).ToString();
                dvtCtr.DelData(dulieu);
                gridView1.DeleteSelectedRows();
                MessageBox.Show(PrintRibbon.xoathanhcong);
            }
        }
    }
}