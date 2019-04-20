using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.Kho
{
    public partial class frmVatLieu : XtraForm
    {
        private readonly VatLieuCtr vlCtr = new VatLieuCtr();
        private readonly MaHangHoaCtr MhhCtr = new MaHangHoaCtr();
        DataTable dt;
        public frmVatLieu()
        {
            InitializeComponent();
        }

        private void frmVatLieu_Load(object sender, EventArgs e)
        {
            SearchLookup();
            tbVatLieuGridControl.DataSource = vlCtr.LoadAllData();
            DisEnl(false);
            risID.Buttons[0].Visible = false;

        }

        public void SearchLookup()
        {
            // Bảng Mã Hàng Hóa
            var mhhCtr = new MaHangHoaCtr();
            risMaHang.DataSource = mhhCtr.LoadData1C();
            risMaHang.DisplayMember = "DIENGIAI";
            risMaHang.ValueMember = "DIENGIAI";

            // Bảng Đơn Vị Tính
            var dvtCtr = new DonViTinhCtr();
            risDonViTinh.DataSource = dvtCtr.LoadData1C();
            risDonViTinh.DisplayMember = "ID";
            risDonViTinh.ValueMember = "ID";

            // Bảng Quy Cách
            var qcCtr = new QuyCachCtr();
            risQuyCach.DataSource = qcCtr.LoadData1C();
            risQuyCach.DisplayMember = "ID";
            risQuyCach.ValueMember = "ID";

            //// Bảng Mã Hàng Hóa
            //MaHangHoaCtr mhhCtr = new MaHangHoaCtr();
            //MaHangHoaCol.DataSource = mhhCtr.LoadData1C();
            //MaHangHoaCol.DisplayMember = "DIENGIAI";
            //MaHangHoaCol.ValueMember = "DIENGIAI";

            //// Bảng Đơn Vị Tính
            //DonViTinhCtr dvtCtr = new DonViTinhCtr();
            //DonViTinhCol.DataSource = dvtCtr.LoadData1C();
            //DonViTinhCol.DisplayMember = "ID";
            //DonViTinhCol.ValueMember = "ID";

            //// Bảng Quy Cách
            //QuyCachCtr qcCtr = new QuyCachCtr();
            //QuyCachCol.DataSource = qcCtr.LoadData1C();
            //QuyCachCol.DisplayMember = "ID";
            //QuyCachCol.ValueMember = "ID";



        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
        }
        private string SinhMaTuDong(DataTable dt)
        {
            var coso = 0;
            var count = dt.Rows.Count;
            if (count == 0)
                coso = 1;
            else
            {
                if (count >= 2)
                {
                    for (var i = 0; i < count - 1; i++)
                    {
                        //MessageBox.Show(dt.Rows[i + 1][1].ToString().Substring(2, 4));
                        if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(2,4)) - int.Parse(dt.Rows[i][0].ToString().Substring(2, 4)) > 1)
                        {
                            coso = int.Parse(dt.Rows[i][0].ToString().Substring(2, 4)) + 1;
                            break;
                        }
                        coso = int.Parse(dt.Rows[count - 1][0].ToString().Substring(2, 4)) + 1;
                    }
                }
                else
                {
                    if (int.Parse(dt.Rows[0][0].ToString().Substring(2, 4)) == 1)
                        coso = 2;
                    else
                        coso = 1;
                }
            }

            if (coso < 10)
                return "000" + coso;
            if (coso < 100)
                return "00" + coso;
            if (coso < 1000)
                return "0" + coso;
            return coso.ToString();
        }
        int flagluu =0;
        private void btnthem_Click(object sender, EventArgs e)
        {
            flagluu = 1;
            DisEnl(true);
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView1.AddNewRow();
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            risID.Buttons[0].Visible = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flagluu = 2;
            DisEnl(true);
            risID.Buttons[0].Visible = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaHang).ToString();
                vlCtr.DelData(mahang);
                MessageBox.Show(PrintRibbon.xoathanhcong);
                frmVatLieu_Load(sender,e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flagluu == 1)
            {
                for (var i = 0; i < gridView1.RowCount - 1; i++)
                {
                    var dr = gridView1.GetDataRow(i);
                    if (dr.RowState != DataRowState.Added) continue;
                    var db = new MyDBContextDataContext();
                    var tb = new tbVatLieu
                    {
                        IDMaHang = dr["IDMaHang"].ToString(),
                        MaHang = dr["MaHang"].ToString(),
                        MaAvery = dr["MaAvery"].ToString(),
                        TenHangHoa = dr["TenHangHoa"].ToString(),
                        DonViTinh = dr["DonViTinh"].ToString(),
                        QuyCach = dr["QuyCach"].ToString(),
                        GhiChu = dr["GhiChu"].ToString(),
                    };
                    db.tbVatLieus.InsertOnSubmit(tb);
                    db.SubmitChanges();
                    MessageBox.Show(PrintRibbon.themthanhcong);
                    frmVatLieu_Load(sender, e);
                }
            }
            else if (flagluu ==2 )
            {
                try
                {
                    for (var i = 0; i < gridView1.RowCount - 1; i++)
                    {
                        var db = new MyDBContextDataContext();
                        var dr = gridView1.GetDataRow(i);
                        if (dr.RowState != DataRowState.Modified) continue;
                        var mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaHang).ToString();
                        var vatlieu = db.tbVatLieus.Single(s => s.MaHang == mahang);
                        vatlieu.IDMaHang = dr["IDMaHang"].ToString();
                        //vatlieu.MaHang = MaHangtxt.Text;
                        vatlieu.MaAvery = dr["MaAvery"].ToString();
                        vatlieu.TenHangHoa = dr["TenHangHoa"].ToString();
                        vatlieu.DonViTinh = dr["DonViTinh"].ToString();
                        vatlieu.QuyCach = dr["QuyCach"].ToString();
                        vatlieu.GhiChu = dr["GhiChu"].ToString();
                        db.SubmitChanges();
                        MessageBox.Show(PrintRibbon.capnhat);
                        frmVatLieu_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            gridView1.ShowRibbonPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmVatLieu_Load(sender, e);
            }
            else
                MessageBox.Show("Hủy thất bại");
        }
        private void risID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDMaHang).ToString();
                //MessageBox.Show(mahang);
                var ID = MhhCtr.GetData_MaHang(mahang);
                //MessageBox.Show(ID.Rows[0][0].ToString());
                dt = vlCtr.GetData(Convert.ToString(ID.Rows[0][0]));
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaHang, Convert.ToString(ID.Rows[0][0]) + SinhMaTuDong(dt));
            }
            catch
            {
                // ignored
            }
        }

        private void btnNgungSuDung_Click(object sender, EventArgs e)
        {           
            var mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaHang).ToString();
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbVatLieus where s.MaHang == mahang select s).Single();
            if(lst.DienGiai == null)
            lst.DienGiai = "Ngưng Sử Dụng";
            else
            {
                lst.DienGiai = null;
            }

            db.SubmitChanges();
            frmVatLieu_Load(sender,e);
        }

        private void tbVatLieuGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                var diengiai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colDienGiai).ToString();
                btnNgungSuDung.Text = string.IsNullOrEmpty(diengiai) ? "NGƯNG SỬ DỤNG" : "SỬ DỤNG";
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}