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
using QuanLySanXuat.Control;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Object;
using System.Collections;
using DevExpress.Data.Svg;

namespace QuanLySanXuat
{
    public partial class frmBaoCaoThietKe : DevExpress.XtraEditors.XtraForm
    {
        public NhanVienObj NvObj = new NhanVienObj();
        public frmBaoCaoThietKe(NhanVienObj nvobj)
        {
            InitializeComponent();
            NvObj = nvobj;
        }
        public readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();

        private void frmBaoCaoThietKe_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dsxCtr.LoadData_DonSanXuat_BaoCaoThietKe();
            dateEdit1.DateTime = DateTime.Today;
        }

        private void bandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //for (int i = 0; i <= bandedGridView1.RowCount - 1; i++)
            //{
            //    var dr = bandedGridView1.GetDataRow(i);
            //    if (dr.RowState == DataRowState.Modified)
            //    {
            //        var db = new MyDBContextDataContext();
            //        var tb = db.tbBaoCaoThietKes.Single(s => s.IDBaoCaoThietKe == dr["SCD"]);
            //        tb.Size = dr["Size"].ToString();
            //        tb.GhiChu = dr["GhiChu"].ToString();
            //        db.SubmitChanges();
            //    }

            //}
            //frmBaoCaoThietKe_Load(sender, e);
            //MessageBox.Show(PrintRibbon.capnhat);
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //try
            //{
            for (var i = 0; i <= bandedGridView1.RowCount - 1; i++)
            {
                var dr = bandedGridView1.GetDataRow(i);
                if (dr.RowState == DataRowState.Modified)
                {
                    var db = new MyDBContextDataContext();
                    var tb = db.tbBaoCaoThietKes.Single(s => s.IDBaoCaoThietKe == dr["SCD"].ToString());
                    tb.BanIn = dr["BanIn"].ToString();
                    tb.SanPham = dr["SanPham"].ToString();
                    tb.Layout = dr["Layout"].ToString();
                    tb.NetChu = dr["NetChu"].ToString();
                    tb.CoChu = dr["CoChu"].ToString();
                    tb.VitriCatGap = dr["VitriCatGap"].ToString();
                    tb.KyHieu = dr["KyHieu"].ToString();
                    tb.Size = dr["Size"].ToString();
                    tb.SpSize = dr["SpSize"].ToString();
                    tb.DanhGia = dr["DanhGia"].ToString();
                    tb.GhiChu = dr["GhiChu"].ToString();
                    db.SubmitChanges();
                }

            }
            frmBaoCaoThietKe_Load(sender, e);
            MessageBox.Show(PrintRibbon.capnhat);
            //}
            //catch
            //{
            //    //null
            //}
        }

        private void btnXacNhanTatCa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn cập nhật không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MyDBContextDataContext();
                for (int i = 0; i <= bandedGridView1.RowCount - 1; i++)
                {
                    var dr = bandedGridView1.GetDataRow(i);                 
                    var tb = db.tbBaoCaoThietKes.Single( s=>s.IDBaoCaoThietKe == dr["SCD"].ToString());
                    tb.BanIn = "Đạt";
                    tb.SanPham = "Đạt";
                    tb.Layout = "Đạt";
                    tb.NetChu = "Đạt";
                    tb.CoChu = "Đạt";
                    tb.VitriCatGap = "Đạt";
                    tb.KyHieu = "Đạt";
                    //tb.Size = "Đạt";
                    //tb.SpSize = "Đạt";
                    tb.DanhGia = "Đạt";
                    //tb.GhiChu = dr["GhiChu"].ToString();

                }
                db.SubmitChanges();
                frmBaoCaoThietKe_Load(sender, e);
                MessageBox.Show(PrintRibbon.capnhat);

            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //var rows = new ArrayList();
            //var dt = new DataTable();
            //for (var i = 0; i < bandedGridView1.SelectedRowsCount; i++)
            //{
            //    //if (bandedGridView1.GetSelectedRows()[i] >= 0)
            //    rows.Add(bandedGridView1.GetDataRow(bandedGridView1.GetSelectedRows()[i]));
            //}


            var rp = new rpBaoCaoThietKe(NvObj);
            rp.DataSource = dsxCtr.LoadData_DonSanXuat_BaoCaoThietKe_NgayXuongDon(dateEdit1.Text);
            rp.databingding();
            rp.ShowRibbonPreviewDialog();
        }

        private void btnXacNhan1Dong_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var scd = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "SCD");
            var tb = db.tbBaoCaoThietKes.Single(s => s.IDBaoCaoThietKe == scd.ToString());
            tb.BanIn = "Đạt";
            tb.SanPham = "Đạt";
            tb.Layout = "Đạt";
            tb.NetChu = "Đạt";
            tb.CoChu = "Đạt";
            tb.VitriCatGap = "Đạt";
            tb.KyHieu = "Đạt";
            tb.DanhGia = "Đạt";
            //tb.GhiChu = dr["GhiChu"].ToString();
            db.SubmitChanges();
            frmBaoCaoThietKe_Load(sender, e);
            MessageBox.Show(PrintRibbon.capnhat);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                gridControl1.DataSource = dsxCtr.LoadData_DonSanXuat_BaoCaoThietKe_All();
            }
            else
                gridControl1.DataSource = dsxCtr.LoadData_DonSanXuat_BaoCaoThietKe();
        }
    }
}