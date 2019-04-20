using QuanLySanXuat.Control;
using QuanLySanXuat.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLySanXuat.Kho
{
    public partial class frmDanhSachDonHangBTP : DevExpress.XtraEditors.XtraForm
    {
        private readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        private readonly NhanVienObj nvObj;
        public frmDanhSachDonHangBTP(NhanVienObj nvobj)
        {
            InitializeComponent();
            nvObj = nvobj;
        }

        private void frmDanhSachDonHangBTP_Load(object sender, EventArgs e)
        {
            truyendulieu();

        }

        public void truyendulieu()
        {
            if (rgNhapXuat.SelectedIndex == 0)
            {
                btnPhieuNhapXuatKho.Text = "PHIẾU NHẬP KHO";
                procDonSanXuat_ViewGridControl.MainView = gvDanhSachNhapKho;
                procDonSanXuat_ViewGridControl.DataSource = dsxCtr.LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_NhapBTP();
                if (rgLoaiHangHoa.SelectedIndex == 0)
                {
                    gvDanhSachNhapKho.ActiveFilter.Clear();
                    gvDanhSachNhapKho.ActiveFilter.NonColumnFilter = "[BoPhan] = 'OFFSET'";
                    colQuyCach.Visible = true;
                    colDonViTinh.Visible = true;
                    colKhoGiayIn.Visible = true;
                    colCatGiay.Visible = true;
                    colDanhSach.Visible = false;
                    colItem.Visible = false;

                }
                else if (rgLoaiHangHoa.SelectedIndex == 1)
                {
                    //var filter = "[Bo Phan] = 'TEM VẢI'";
                    //gridView1.Columns["BoPhan"].FilterInfo = new ColumnFilterInfo(filter);
                    gvDanhSachNhapKho.ActiveFilter.Clear();
                    gvDanhSachNhapKho.ActiveFilter.NonColumnFilter = "[BoPhan] = 'TEM VẢI'";
                    colQuyCach.Visible = false;
                    colDonViTinh.Visible = false;
                    colKhoGiayIn.Visible = false;
                    colCatGiay.Visible = false;
                    colDanhSach.Visible = true;
                    colItem.Visible = true;
                }
                else
                {
                    gvDanhSachNhapKho.ActiveFilter.Clear();
                    gvDanhSachNhapKho.ActiveFilter.NonColumnFilter = "[BoPhan] = 'STICKER'";
                    colQuyCach.Visible = true;
                    colDonViTinh.Visible = true;
                    colKhoGiayIn.Visible = false;
                    colCatGiay.Visible = false;
                    colDanhSach.Visible = false;
                    colItem.Visible = false;
                }
            }
            else
            {
                procDonSanXuat_ViewGridControl.MainView = gvDanhSachXuatKho;
                //procDonSanXuat_ViewGridControl.DataSource = khoCtrl.LoadData();
                var db = new MyDBContextDataContext();
                IQueryable<tbKhoBTP_TP> kho = from s in db.tbKhoBTP_TPs
                                              where s.NhapXuat == "Nhập" && s.XacNhan == null
                                              orderby s.Ngay descending
                                              select s;
                                              
                procDonSanXuat_ViewGridControl.DataSource = kho;
                btnPhieuNhapXuatKho.Text = "PHIẾU XUẤT KHO";
                if (rgLoaiHangHoa.SelectedIndex == 0)
                {
                    gvDanhSachXuatKho.ActiveFilter.Clear();
                    gvDanhSachXuatKho.ActiveFilter.NonColumnFilter = "[LoaiSanPham] = 'TEM GIẤY'";

                }
                else if (rgLoaiHangHoa.SelectedIndex == 1)
                {
                    //var filter = "[Bo Phan] = 'TEM VẢI'";
                    //gridView1.Columns["BoPhan"].FilterInfo = new ColumnFilterInfo(filter);
                    gvDanhSachXuatKho.ActiveFilter.Clear();
                    gvDanhSachXuatKho.ActiveFilter.NonColumnFilter = "[LoaiSanPham] = 'TEM VẢI'";
                }
                else
                {
                    gvDanhSachXuatKho.ActiveFilter.Clear();
                    gvDanhSachXuatKho.ActiveFilter.NonColumnFilter = "[LoaiSanPham] = 'STICKER'";
                }
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmDanhSachDonHangBTP_Load(sender, e);
        }

        private void btnPhieuNhapXuatKho_Click(object sender, EventArgs e)
        {
            if (rgNhapXuat.SelectedIndex == 0)
            {
                var rows = new ArrayList();
                // Add the selected rows to the list.
                for (var i = 0; i < gvDanhSachNhapKho.GetSelectedRows().Length; i++)
                {
                    if (gvDanhSachNhapKho.GetSelectedRows()[i] >= 0)
                        rows.Add(gvDanhSachNhapKho.GetDataRow(gvDanhSachNhapKho.GetSelectedRows()[i]));
                }
                var frm = new frmPhieuNhapKhoBTP(nvObj, "mới", 1, rows);
                frm.ShowDialog();
            }
            else
            {
                var rows = new List<string>();

                for (var i = 0; i < gvDanhSachXuatKho.SelectedRowsCount; i++)
                {
                    if (gvDanhSachXuatKho.GetSelectedRows()[i] >= 0)
                        rows.Add(gvDanhSachXuatKho.GetRowCellValue(gvDanhSachXuatKho.GetSelectedRows()[i], colSCD).ToString());
                    //rows.Add(gvDanhSachXuatKho.GetDataRow(gvDanhSachXuatKho.GetSelectedRows()[i]));
                }

                //var lst = from _scd in rows select _scd;
                var frm = new frmPhieuXuatKhoBTP(nvObj, "mới", 1, rows);
                frm.ShowDialog();
            }
            frmDanhSachDonHangBTP_Load(sender, e);
        }

        private void rgLoaiHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmDanhSachDonHangBTP_Load(sender, e);
        }
    }
}