using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySanXuat.Kho
{
    public partial class frmPhieuXuatKhoBTP : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt;
        private readonly KhoBTP_TPCtr kbtpCtr = new KhoBTP_TPCtr();
        private readonly NhanVienObj nvObj;
        private readonly string _MaPhieu;
        private readonly List<string> rows;
        private readonly int _flagluu;

        public frmPhieuXuatKhoBTP(NhanVienObj obj, string maphieu, int flagluu, List<string> row)
        {
            InitializeComponent();
            nvObj = obj;
            _MaPhieu = maphieu;
            _flagluu = flagluu;
            rows = row;
        }

        private void frmPhieuXuatKhoBTP_Load(object sender, EventArgs e)
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
                var maphieu = "PXK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
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
            var kho = from s in db.tbKhos where s.ID.Contains("THÀNH PHẨM") select new { s.ID };
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
                foreach (var SCD in rows)
                {
                    //if (!(t is DataRow row)) continue;
                    //var SCD = row["SCD"].ToString();
                    gridView1.AddNewRow();
                    gridView1.OptionsNavigation.AutoFocusNewRow = true;
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSCD, SCD);

                    var db = new MyDBContextDataContext();
                    var dulieu = (from s in db.DonSanXuat_LanhLieu_View() where s.SCD == SCD select s).Single();
                    //var kho = (from s in db.tbKhoBTP_TPs where s.SCD == SCD select s).Single();
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
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSoLuongXuatKhachHang, dulieu.SoLuong);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTenSanPham, dulieu.TenSanPham);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDonViTinh, dvt);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colKichThuoc, dulieu.KichThuoc);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colKhoGiayIn, dulieu.KhoGiayIn);
                    //gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colIDKhoBTP_TP, kho.IDKhoBTP_TP);
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
                var kiemtra = (from s in db.tbKhoBTP_TPs where s.MaPhieu == MaPhieutxt.Text select s).ToList();
                //if (kiemtra.Count > 0 && _MaPhieu == "mới" && _flagluu == 1)
                //{
                //    MessageBox.Show("Mã phiếu đã có, hệ thống tự động thay đổi Mã phiếu mới");
                //    var maphieu = "PXK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
                //    dt = kbtpCtr.GetData_MaPhieu(maphieu);
                //    MaPhieutxt.Text = maphieu + kbtpCtr.SinhMaTuDong_MaPhieu(dt);
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
                                if (_flagluu == 2)
                                    kbtpCtr.DelData("MaPhieu", _MaPhieu);
                                for (var i = 0; i < gridView1.RowCount - 1; i++)
                                {
                                    var IDKho = "/" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "X";
                                    dt = kbtpCtr.GetData_IDKhoBTP(IDKho);
                                    var dr = gridView1.GetDataRow(i);
                                    var lst = (from s in db.tbKhoBTP_TPs
                                               where s.SCD == dr["SCD"].ToString() && s.NhapXuat == "Nhập"
                                               select s).ToList();
                                    if (lst.Count == 1)
                                        foreach (var item in lst)
                                        {
                                            var kbtp = new tbKhoBTP_TP();
                                            kbtp.IDKhoBTP_TP = kbtpCtr.SinhMaTuDong(dt) + IDKho; ;
                                            kbtp.MaPhieu = MaPhieutxt.Text;
                                            kbtp.SCD = dr["SCD"].ToString();
                                            kbtp.Lo = txtlo.Text;
                                            kbtp.NhapXuat = "Xuất";
                                            kbtp.Kho = KhoCongTytxt.Text;
                                            kbtp.Ngay = NgayNhaptxt.DateTime;
                                            kbtp.LoaiSanPham = item.LoaiSanPham;
                                            kbtp.MaDonHang = item.MaDonHang;
                                            kbtp.TenKhachHang = item.TenKhachHang;
                                            kbtp.TenSanPham = dr["TenSanPham"].ToString();
                                            if (Convert.ToInt32(dr["SoLuongXuatKhachHang"].ToString()) > 0)
                                                kbtp.SoLuongXuatKhachHang = (int)dr["SoLuongXuatKhachHang"];
                                            if (!string.IsNullOrEmpty(dr["SoLuongXuatCongTy"].ToString()))
                                                kbtp.SoLuongXuatCongTy =
                                                    Convert.ToInt32(dr["SoLuongXuatCongTy"].ToString());
                                            kbtp.DonViTinh = dr["DonViTinh"].ToString();
                                            kbtp.KichThuoc = item.KichThuoc;
                                            kbtp.KhoGiayIn = item.KhoGiayIn;
                                            kbtp.BoPhan = txtBoPhan.Text;
                                            kbtp.GhiChu = dr["GhiChu"].ToString();
                                            kbtp.NhanVien = nvObj.Tennhanvien;
                                            db.tbKhoBTP_TPs.InsertOnSubmit(kbtp);
                                            var tbkho = (from s in db.tbKhoBTP_TPs
                                                         where s.SCD == dr["SCD"].ToString()
                                                         select s).Single();
                                            tbkho.XacNhan = 1;
                                            db.SubmitChanges();
                                        }
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

                                //frmPhieuNhapKhoNVL_Load(sender, e);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var maphieu = "PXK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
            dt = kbtpCtr.GetData_MaPhieu(maphieu);
            MaPhieutxt.Text = maphieu + kbtpCtr.SinhMaTuDong_MaPhieu(dt);
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
                var rp = new rpPhieuXuatKhoBTP();
                rp.DataSource = kbtpCtr.GetData("MaPhieu", MaPhieutxt.Text);
                rp.databing();
                rp.ShowRibbonPreviewDialog();
                break;
            }

            if (tong == 0)
                MessageBox.Show("Vui lòng Xuất kho mã phiếu " + MaPhieutxt.Text + " này trước khi in");
        }
    }
}