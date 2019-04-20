using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.Kho
{
    public partial class frmPhieuNhapKhoBTP : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt;
        private readonly KhoBTP_TPCtr kbtpCtr = new KhoBTP_TPCtr();
        private readonly NhanVienObj nvObj;
        private string _MaPhieu;
        private readonly ArrayList rows;
        private readonly int _flagluu;
        public string _SCD;

        public frmPhieuNhapKhoBTP(NhanVienObj obj, string maphieu, int flagluu, ArrayList row)
        {
            InitializeComponent();
            nvObj = obj;
            _MaPhieu = maphieu;
            _flagluu = flagluu;
            rows = row;
        }

        private void frmPhieuNhapKhoBTP_Load(object sender, EventArgs e)
        {
            SearchLookup();
            MaPhieu();
            truyendulieu();
            gridView1.BestFitColumns(true);
        }

        public void MaPhieu()
        {
            if (_MaPhieu == "mới")
            {
                var kbtp_DemoCtr = new KhoBTPCtr_Demo();
                gridControl1.DataSource = kbtp_DemoCtr.LoadData();
                var maphieu = "PNK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
                dt = kbtpCtr.GetData_MaPhieu(maphieu);
                MaPhieutxt.Text = maphieu + kbtpCtr.SinhMaTuDong_MaPhieu(dt);
                NgayNhaptxt.DateTime = DateTime.Today;
                //KhoCongTytxt.Text = "NGUYÊN VẬT LIỆU";
            }
            else
            {
                MaPhieutxt.Text = _MaPhieu;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbKhoBTP_TPs where s.MaPhieu == _MaPhieu select s).ToList();
                foreach (var btp in lst)
                {
                    //KhoCongTytxt.Text = btp.Kho;
                    txtlo.Text = btp.Lo;
                    txtBoPhan.Text = btp.BoPhan;
                    KhoCongTytxt.Text = btp.Kho;
                    if (btp.Ngay != null) NgayNhaptxt.DateTime = btp.Ngay.Value;

                    break;
                }
                gridControl1.DataSource = kbtpCtr.GetData("MaPhieu", _MaPhieu);
                btnLuu.Text = "Cập Nhật";
            }
        }

        public void SearchLookup()
        {
            var db = new MyDBContextDataContext();
            //// Bảng Vật Liệu
            var vlCtr = new VatLieuCtr();
            risMaHang.DataSource = vlCtr.LoadData4C();
            risMaHang.DisplayMember = "MaHang";
            risMaHang.ValueMember = "MaHang";

            // Bảng Nhà Cung Cấp
            var bpCtr = new BoPhanCtr();
            txtBoPhan.Properties.DataSource = bpCtr.LoadData();
            txtBoPhan.Properties.DisplayMember = "ID";
            txtBoPhan.Properties.ValueMember = "ID";

            // Bảng Kho
            //var khoCtr = new KhoCtr();
            //KhoCongTytxt.Properties.DataSource = khoCtr.LoadData1C();
            //KhoCongTytxt.Properties.DisplayMember = "ID";
            //KhoCongTytxt.Properties.ValueMember = "ID";
            var kho = from s in db.tbKhos where s.ID.Contains("THÀNH PHẨM") select  new {s.ID};
            KhoCongTytxt.Properties.DataSource = kho;
            KhoCongTytxt.Properties.DisplayMember = "ID";
            KhoCongTytxt.Properties.ValueMember = "ID";

            // Bảng Kho
            //var bpCtr = new BoPhanCtr();
            risBoPhan.DataSource = bpCtr.LoadData();
            risBoPhan.DisplayMember = "ID";
            risBoPhan.ValueMember = "ID";

            var khCtr = new KhachHangCtr();
            risTenKhachHang.DataSource = khCtr.LoadData1C();
            risTenKhachHang.DisplayMember = "TenKhachHang";
            risTenKhachHang.ValueMember = "TenKhachHang";

            var dvtCtr = new DonViTinhCtr();
            risDonViTinh.DataSource = dvtCtr.LoadData1C();
            risDonViTinh.DisplayMember = "ID";
            risDonViTinh.ValueMember = "ID";

        }

        public void truyendulieu()
        {
            try
            {
                if (rows == null) return;
                foreach (var t in rows)
                {
                    if (!(t is DataRow row)) continue;
                    _SCD = row["SCD"].ToString();
                    gridView1.AddNewRow();
                    gridView1.OptionsNavigation.AutoFocusNewRow = true;
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSCD, _SCD);
                    var db = new MyDBContextDataContext();
                    var dulieu = (from s in db.DonSanXuat_LanhLieu_View() where s.SCD == _SCD.ToString() select s).Single();
                    string dvt = null;
                    if (dulieu.BoPhan == "OFFSET")
                        dvt = "TẤM";
                    else if (dulieu.BoPhan == "TEM VẢI")
                        dvt = "PCS";
                    else if (dulieu.BoPhan == "STICKER")
                        dvt = "SHEET / TỜ";
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colBoPhan, dulieu.BoPhan);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colLoaiSanPham, dulieu.LoaiSanPham);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaDonHang, dulieu.MaDonHang);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTenKhachHang, dulieu.TenKhachHang);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSoLuongNhapKhachHang, dulieu.SoLuong);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTenSanPham, dulieu.TenSanPham);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDonViTinh, dvt);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colKichThuoc, dulieu.KichThuoc);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colKhoGiayIn, dulieu.KhoGiayIn);

                }
            }
            catch
            {
                //null
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var kiemtra = (from s in db.tbKhoBTP_TPs where s.MaPhieu == MaPhieutxt.Text  select s).ToList();
                //var scd = db.tbKhoBTP_TPs.Where(s => s.SCD == _SCD).ToList();

                //if (kiemtra.Count > 0 && _MaPhieu == "mới" && _flagluu == 1)
                //{
                //    MessageBox.Show("Mã phiếu đã có, hệ thống tự động thay đổi Mã phiếu mới");
                //    var maphieu = "PXK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
                //    dt = kbtpCtr.GetData_MaPhieu(maphieu);
                //    MaPhieutxt.Text = maphieu + kbtpCtr.SinhMaTuDong_MaPhieu(dt);
                //    _MaPhieu = MaPhieutxt.Text;
                //}

                var gioihan = DateTime.Today - NgayNhaptxt.DateTime;
                if (!string.IsNullOrEmpty(KhoCongTytxt.Text))
                {
                    if (!string.IsNullOrEmpty(txtBoPhan.Text))
                    {
                        if ((int)gioihan.TotalDays <= 100 && gioihan.TotalDays >= 0)
                        {
                            if (kiemtra.Count == 0 && _MaPhieu == "mới" && _flagluu == 1 || kiemtra.Count > 0 && _MaPhieu != "mới" && _flagluu == 2)
                            {
                                DataRow dr;
                                if (_flagluu == 2)
                                    kbtpCtr.DelData("MaPhieu", _MaPhieu);
                                for (var i = 0; i < gridView1.RowCount - 1; i++)
                                {
                                    var IDKho = "/" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "N";
                                    dt = kbtpCtr.GetData_IDKhoBTP(IDKho);
                                    dr = gridView1.GetDataRow(i);
                                    var lst = (from s in db.LoadData_DonSanXuat_LanhLieu_DanhSachDonHang_NhapBTP()
                                               where s.SCD == dr["SCD"].ToString()
                                               select s).Single();
                                    var kbtp = new tbKhoBTP_TP();
                                    kbtp.IDKhoBTP_TP = kbtpCtr.SinhMaTuDong(dt) + IDKho;
                                    kbtp.MaPhieu = MaPhieutxt.Text;
                                    kbtp.SCD = dr["SCD"].ToString();
                                    kbtp.Lo = txtlo.Text;
                                    kbtp.NhapXuat = "Nhập";
                                    kbtp.Kho = KhoCongTytxt.Text;
                                    kbtp.Ngay = NgayNhaptxt.DateTime;
                                    kbtp.LoaiSanPham = lst.LoaiSanPham;
                                    kbtp.MaDonHang = lst.MaDonHang;
                                    kbtp.TenKhachHang = lst.TenKhachHang;
                                    kbtp.TenSanPham = dr["TenSanPham"].ToString();
                                    if (Convert.ToInt32(dr["SoLuongNhapKhachHang"].ToString()) > 0)
                                        kbtp.SoLuongNhapKhachHang = (int)dr["SoLuongNhapKhachHang"];
                                    if (!string.IsNullOrEmpty(dr["SoLuongNhapCongTy"].ToString()))
                                        kbtp.SoLuongNhapCongTy = Convert.ToInt32(dr["SoLuongNhapCongTy"].ToString());
                                    kbtp.DonViTinh = dr["DonViTinh"].ToString();
                                    kbtp.KichThuoc = lst.KichThuoc;
                                    kbtp.KhoGiayIn = lst.KhoGiayIn;
                                    kbtp.BoPhan = txtBoPhan.Text;
                                    kbtp.GhiChu = dr["GhiChu"].ToString();
                                    kbtp.NhanVien = nvObj.Tennhanvien;
                                    var ll = (from s in db.tbLanhLieus
                                              where s.IDLanhLieu == dr["SCD"].ToString()
                                              select s)
                                        .ToList();
                                    foreach (var item in ll)
                                    {
                                        item.XacNhanLanhLieu = 2;
                                    }

                                    db.tbKhoBTP_TPs.InsertOnSubmit(kbtp);
                                    db.SubmitChanges();
                                }

                               
                                switch (_flagluu)
                                {
                                    case 1:
                                        MessageBox.Show("Thêm Thành Công");
                                        break;
                                    case 2:
                                        MessageBox.Show("Cập nhật thành công");
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mã phiếu đã tồn tại , vui lòng tạo mã phiếu mới");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Dữ liệu đã vượt quá thời gian cho phép Lưu kho");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập bộ phận");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập kho công ty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                //null
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbKhoBTP_TPs.ToList();
            var tong = 0;
            foreach (var tbKhoNlv in lst)
            {
                if (tbKhoNlv.MaPhieu != MaPhieutxt.Text) continue;
                tong = 1;
                var rp = new rpPhieuNhapKhoBTP();
                rp.DataSource = kbtpCtr.GetData("MaPhieu", MaPhieutxt.Text);
                rp.databing();
                rp.ShowRibbonPreviewDialog();
                break;
            }

            if (tong == 0)
                MessageBox.Show("Vui lòng Lưu kho mã phiếu " + MaPhieutxt.Text + " này trước khi in");
        }

        private void btnMaPhieu_Click(object sender, EventArgs e)
        {
            var maphieu = "PNK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
            dt = kbtpCtr.GetData_MaPhieu(maphieu);
            MaPhieutxt.Text = maphieu + kbtpCtr.SinhMaTuDong_MaPhieu(dt);
        }
    }
}