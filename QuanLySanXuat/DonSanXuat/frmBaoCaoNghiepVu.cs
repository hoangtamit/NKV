using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmBaoCao_nghiepvu : DevExpress.XtraEditors.XtraForm
    {
        public readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        public NhanVienObj NvObj = new NhanVienObj();
        public frmBaoCao_nghiepvu()
        {
            InitializeComponent();
        }

        private void frmBaoCao_nghiepvu_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dsxCtr.LoadData_DonSanXuat_BaoCao_nghiepvu();
            dateEdit1.DateTime = DateTime.Today;
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
                    var tb = db.tbBaoCaoNghiepVus.Single(s => s.IDBaoCaoNghiepVu == dr["SCD"].ToString());
                    tb.Size = dr["Size"].ToString();
                    tb.SpSize = dr["SpSize"].ToString();
                    tb.DanhGia = dr["DanhGia"].ToString();
                    tb.GhiChu = dr["GhiChu"].ToString();
                    db.SubmitChanges();
                }

            }
            frmBaoCao_nghiepvu_Load(sender, e);
            MessageBox.Show(PrintRibbon.capnhat);
            //}
            //catch
            //{
            //    //null
            //}
        }

        private void btnXacNhan1Dong_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var scd = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle,colSCD);
            var tb = db.tbBaoCaoNghiepVus.Single(s => s.IDBaoCaoNghiepVu == scd.ToString());
            tb.SpSize = "O";
            tb.DanhGia = "Đạt";
            db.SubmitChanges();
            frmBaoCao_nghiepvu_Load(sender, e);
            MessageBox.Show(PrintRibbon.capnhat);

        }

        private void btnXacNhanTatCa_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            var rp = new rptBaoCaoNghiepVu(NvObj);
            rp.DataSource = dsxCtr.LoadData_DonSanXuat_BaoCao_nghiepvu_NgayXuongDon(dateEdit1.Text);
            rp.databingding();
            rp.ShowRibbonPreviewDialog();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                gridControl1.DataSource = dsxCtr.LoadData_DonSanXuat_BaoCao_nghiepvu_All();
            }
            else
                gridControl1.DataSource = dsxCtr.LoadData_DonSanXuat_BaoCao_nghiepvu();
        }
    }
}