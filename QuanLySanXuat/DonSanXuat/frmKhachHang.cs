using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmKhachHang : XtraForm
    {
        KhachHangCtr khCtr = new KhachHangCtr();
        public frmKhachHang()
        {
            InitializeComponent();
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = khCtr.LoadData();
            tbKhachHangGridControl.DataSource = dt;
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
                        var tb = db.tbKhachHangs.Single(s => s.MaKhachHang == (int)dr["MaKhachHang"]);
                        tb.TenKhachHang = dr["TenKhachHang"].ToString();
                        tb.DiaChi = dr["DiaChi"].ToString();
                        tb.MaSoThue = dr["MaSoThue"].ToString();
                        tb.NguoiLienHe = dr["NguoiLienHe"].ToString();
                        tb.Email = dr["Email"].ToString();
                        tb.DienThoai = dr["DienThoai"].ToString();
                        tb.GhiChu = dr["GhiChu"].ToString();
                        tb.TinhTrang = dr["TinhTrang"].ToString();
                        db.SubmitChanges();
                        MessageBox.Show(PrintRibbon.capnhat);

                    }
                }
                else if (dr.RowState == DataRowState.Added)
                {
                    if (XtraMessageBox.Show("Bạn có muốn thêm không", "Cảnh báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var db = new MyDBContextDataContext();
                        var tb = new tbKhachHang();
                        tb.TenKhachHang = dr["TenKhachHang"].ToString();
                        tb.DiaChi = dr["DiaChi"].ToString();
                        tb.MaSoThue = dr["MaSoThue"].ToString();
                        tb.NguoiLienHe = dr["NguoiLienHe"].ToString();
                        tb.Email = dr["Email"].ToString();
                        tb.DienThoai = dr["DienThoai"].ToString();
                        tb.GhiChu = dr["GhiChu"].ToString();
                        tb.TinhTrang = dr["TinhTrang"].ToString();
                        db.tbKhachHangs.InsertOnSubmit(tb);
                        db.SubmitChanges();
                        MessageBox.Show(PrintRibbon.themthanhcong);
                    }
                }
            }
            //frmKhachHang_Load(sender, e);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string dulieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaKhachHang).ToString();
                khCtr.DelData(dulieu);
                gridView1.DeleteSelectedRows();
                MessageBox.Show(PrintRibbon.xoathanhcong);
            }
        }
    }
}