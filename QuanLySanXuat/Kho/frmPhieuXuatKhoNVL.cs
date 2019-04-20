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
    public partial class frmPhieuXuatKhoNVL : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt;
        private readonly KhoNVLCtr knvlCtr = new KhoNVLCtr();
        private readonly NhanVienObj nvObj;
        private string _MaPhieu;
        private int _flagluu;
        private readonly ArrayList rows;
        public readonly DateTime tungay = Convert.ToDateTime(GetFirstDayOfMonth(DateTime.Now));
        public readonly DateTime denngay = Convert.ToDateTime(GetLastDayOfMonth(DateTime.Now));
        public frmPhieuXuatKhoNVL(NhanVienObj obj, string maphieu, int flagluu, ArrayList row)
        {
            InitializeComponent();
            nvObj = obj;
            _MaPhieu = maphieu;
            _flagluu = flagluu;
            rows = row;
        }

        private void frmPhieuXuatKhoNVL_Load(object sender, EventArgs e)
        {
            SearchLookup();
            MaPhieu();
            truyendulieu();
            //nhapsolot();
            risLo_Click_1(sender, e);
        }

        public void MaPhieu()
        {
            if (_MaPhieu == "mới")
            {
                var knvl_DemoCtr = new KhoNVLCtr_Demo();
                gridControl1.DataSource = knvl_DemoCtr.LoadData();
                var maphieu = "PXK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
                dt = knvlCtr.GetData_MaPhieu(maphieu);
                MaPhieutxt.Text = maphieu + knvlCtr.SinhMaTuDong_MaPhieu(dt);
                KhoCongTytxt.Text = "NGUYÊN VẬT LIỆU";
                NgayNhaptxt.DateTime = DateTime.Today;
            }
            else
            {
                MaPhieutxt.Text = _MaPhieu;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbKhoNLVs where s.MaPhieu == _MaPhieu select s).ToList();
                foreach (var tbKhonlv in lst)
                {
                    KhoCongTytxt.Text = tbKhonlv.Kho;
                    BoPhantxt.Text = tbKhonlv.BoPhan;
                    if (tbKhonlv.Ngay != null) NgayNhaptxt.DateTime = tbKhonlv.Ngay.Value;
                    break;
                }

                gridControl1.DataSource = knvlCtr.GetData("MaPhieu", _MaPhieu);
                btnLuu.Text = "Cập Nhật";
            }
        }

        public void nhapsolot()
        {
            var db = new MyDBContextDataContext();
            var a = db.LoadData_TonKhoNVL_Lot_View(tungay, denngay).ToList();
            foreach (var item in a)
            {
                var tong = 0;
                var sl1 = 0;
                for (var i = 0; i < gridView1.RowCount; i++)
                {
                    var dr = gridView1.GetDataRow(i);
                    if (!string.IsNullOrEmpty(dr["Lo"].ToString())) continue;
                    if (item.mahang != dr["MaHang"].ToString()) continue;
                    if (string.IsNullOrEmpty(item.Lo)) continue;
                    if (i == 0) tong = Convert.ToInt32(dr["SoLuongXuat"]);
                    if (i > 0) sl1 = Convert.ToInt32(dr["SoLuongXuat"]);
                    tong = sl1 + tong;
                    if (item.toncuoiky >= tong)
                    {
                        dr["Lo"] = item.Lo;
                        dr["HanSuDung"] = item.HanSuDung;
                        //MessageBox.Show(tong + "  " + item.mahang + "  " + item.Lo);
                    }
                    else
                    {
                        tong = tong - sl1;
                        //MessageBox.Show(tong + "  " + item.mahang + "  " + item.Lo);
                    }
                }
            }
        }

        public void truyendulieu()
        {
            try
            {
                if (rows == null) return;
                KhoCongTytxt.Text = "NGUYÊN VẬT LIỆU";
                foreach (var t in rows)
                {
                    if (!(t is DataRow row)) continue;
                    var SCD = row["SCD"];
                    row.ItemArray = new object[4];
                    gridView1.AddNewRow();
                    gridView1.OptionsNavigation.AutoFocusNewRow = true;
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSCD, SCD);
                    var db = new MyDBContextDataContext();
                    var dulieu = (from s in db.DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null_PhieuXuatKho() where s.SCD == SCD.ToString() select s).Single();
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSoLuongXuat, dulieu.LanhLieu);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTenHangHoa, dulieu.VatLieu);

                    BoPhantxt.Text = dulieu.BoPhan;
                    if (dulieu.BoPhan == "SAU IN" || dulieu.BoPhan == "OFFSET" && dulieu.TenKhachHang != PrintRibbon.AD)
                    {
                        var khogiayin = (from s in db.tbKhoGiayIns where s.KhoIn == dulieu.KhoGiayIn && s.CatGiay == s.CatGiay && s.GiayLon == dulieu.QuyCach select s).Single();
                        var lst = (from a in db.tbVatLieus
                                   where a.TenHangHoa == dulieu.VatLieu && a.QuyCach == khogiayin.GiayLon
                                   select a).Single();
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDonViTinh, lst.DonViTinh);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuyCach, lst.QuyCach);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaHang, lst.MaHang);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaAD, lst.MaAvery);
                    }
                    else if (dulieu.BoPhan == "STICKER" || dulieu.BoPhan == "IN CHỮ VI TÍNH" &&
                             dulieu.PhuongPhapIn == "Máy in Sticker (In Chữ)")
                    {
                        var lst = (from a in db.tbVatLieus
                                   where a.TenHangHoa == dulieu.VatLieu && a.QuyCach == dulieu.QuyCach
                                   select a).Single();
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDonViTinh, lst.DonViTinh);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuyCach, lst.QuyCach);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaHang, lst.MaHang);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaAD, lst.MaAvery);
                    }
                    else if (dulieu.BoPhan == "TEM VẢI" && dulieu.TenKhachHang != PrintRibbon.AD)
                    {
                        var kichthuoc = dulieu.KichThuoc.Split('*');
                        var lst = (from a in db.tbVatLieus where a.TenHangHoa == dulieu.VatLieu select a).ToList();
                        foreach (var item in lst)
                        {
                            var quycach = item.QuyCach.Split('*');
                            if (kichthuoc[0] != quycach[0]) continue;
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDonViTinh, item.DonViTinh);
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuyCach, item.QuyCach);
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaHang, item.MaHang);
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaAD, item.MaAvery);
                        }
                    }
                    else
                    {
                        var lst = (from a in db.tbVatLieus where a.TenHangHoa == dulieu.VatLieu select a).Single();
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDonViTinh, lst.DonViTinh);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuyCach, lst.QuyCach);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaHang, lst.MaHang);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaAD, lst.MaAvery);
                    }


                }
            }
            catch { }
        }

        public void SearchLookup()
        {
            //// Bảng Vật Liệu
            var vlCtr = new VatLieuCtr();
            risMaHang.DataSource = vlCtr.LoadData4C();
            risMaHang.DisplayMember = "MaHang";
            risMaHang.ValueMember = "MaHang";

            // Bảng Nhà Cung Cấp
            var bpCtr = new BoPhanCtr();
            BoPhantxt.Properties.DataSource = bpCtr.LoadData();
            BoPhantxt.Properties.DisplayMember = "ID";
            BoPhantxt.Properties.ValueMember = "ID";

            // Bảng Kho
            var khoCtr = new KhoCtr();
            KhoCongTytxt.Properties.DataSource = khoCtr.LoadData1C();
            KhoCongTytxt.Properties.DisplayMember = "ID";
            KhoCongTytxt.Properties.ValueMember = "ID";

            //SCD
            //var dsxCtr = new DonSanXuatCtr();
            //risSCD.DataSource = dsxCtr.LoadData_SCD_Search();
            //risSCD.DisplayMember = "SCD";
            //risSCD.ValueMember = "SCD";   


        }

        private void risTenHangHoa_Leave(object sender, EventArgs e)
        {

        }

        private void risCopy_Click(object sender, EventArgs e)
        {
            try
            {
                var TenHangHoa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colTenHangHoa).ToString();
                var DonViTinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colDonViTinh).ToString();
                var QuyCach = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colQuyCach).ToString();
                //var kho = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colKho).ToString();
                var Mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaHang).ToString();
                var MaAD = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaAD).ToString();
                gridView1.AddNewRow();
                gridView1.OptionsNavigation.AutoFocusNewRow = true;
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTenHangHoa, TenHangHoa);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDonViTinh, DonViTinh);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuyCach, QuyCach);
                //gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colKho, kho);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaHang, Mahang);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMaAD, MaAD);
            }
            catch (Exception)
            {
                //Console.WriteLine(exception);
                //throw;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var kiemtra = (from s in db.tbKhoNLVs where s.MaPhieu == MaPhieutxt.Text select s).ToList();
                if(kiemtra.Count > 0 && _MaPhieu == "mới" && _flagluu == 1)
                {
                    MessageBox.Show("Mã phiếu đã có, hệ thống tự động thay đổi Mã phiếu mới");
                    var maphieu = "PXK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
                    dt = knvlCtr.GetData_MaPhieu(maphieu);
                    MaPhieutxt.Text = maphieu + knvlCtr.SinhMaTuDong_MaPhieu(dt);
                }
                if (!string.IsNullOrEmpty(KhoCongTytxt.Text))
                {
                    if (!string.IsNullOrEmpty(BoPhantxt.Text))
                    {
                        var gioihan = DateTime.Today - NgayNhaptxt.DateTime;
                        if ((int)gioihan.TotalDays <= 30 && gioihan.TotalDays >= 0)
                        {
                            DataRow dr;
                            if (_flagluu == 2)
                                knvlCtr.DelData("MaPhieu", _MaPhieu);
                            for (var i = 0; i < gridView1.RowCount - 1; i++)
                            {
                                var IDKho = "/" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "X";
                                dt = knvlCtr.GetData_IDKho(IDKho);
                                dr = gridView1.GetDataRow(i);
                                var lst = db.tbVatLieus.Single(s => s.MaHang == dr["MaHang"].ToString());
                                var knvl = new tbKhoNLV();
                                knvl.IDKhoNVL = knvlCtr.SinhMaTuDong_IDkho(dt) + IDKho;
                                knvl.MaPhieu = MaPhieutxt.Text;
                                knvl.SCD = dr["SCD"].ToString();
                                knvl.Lo = dr["Lo"].ToString();
                                if (!string.IsNullOrEmpty(dr["HanSuDung"].ToString()))
                                {
                                    knvl.HanSuDung = (DateTime)dr["HanSuDung"];
                                }
                                knvl.NhapXuat = "Xuất";
                                knvl.Kho = KhoCongTytxt.Text;
                                knvl.Ngay = NgayNhaptxt.DateTime;
                                knvl.TenHangHoa = lst.TenHangHoa;
                                knvl.DonViTinh = lst.DonViTinh;
                                knvl.QuyCach = lst.QuyCach;
                                knvl.MaHang = lst.MaHang;
                                knvl.MaAD = lst.MaAvery;
                                knvl.LoaiHang = lst.IDMaHang;
                                knvl.SoLuongXuat = (double)dr["SoLuongXuat"];
                                knvl.BoPhan = BoPhantxt.Text;
                                knvl.GhiChu = dr["GhiChu"].ToString();
                                knvl.NguoiQuanKho = nvObj.Tennhanvien;
                                db.tbKhoNLVs.InsertOnSubmit(knvl);
                                db.SubmitChanges();
                                if (!string.IsNullOrEmpty(knvl.SCD))
                                {
                                    var count = 0;
                                    var tb = db.tbLanhLieus.ToList();
                                    foreach (var xacnhan in tb)
                                    {
                                        if (xacnhan.IDLanhLieu != knvl.SCD) continue;
                                        xacnhan.XacNhanLanhLieu = 1;
                                        db.SubmitChanges();
                                        count = 1;
                                        break;
                                    }

                                    if (count == 0)
                                    {
                                        MessageBox.Show("Mã SCD : " + knvl.SCD + " không đúng , vui lòng xem lại");
                                    }
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

                            //frmPhieuXuatKhoNVL_Load(sender, e);
                            btnLuu.Text = "Cập Nhật";
                            _flagluu = 2;
                            _MaPhieu = MaPhieutxt.Text;
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
                    MessageBox.Show("Vui lòng nhập Kho Công Ty");
                }
            }
            catch (Exception)
            {
                //null
            }
        }

        private void gridView1_CellValueChanging(object sender,
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                gridView1.GetFocusedValue();
                var mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaHang).ToString();
                var db = new MyDBContextDataContext();
                var lst = db.tbVatLieus.Single(s => s.MaHang == mahang);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DonViTinh", lst.DonViTinh);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "QuyCach", lst.QuyCach);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TenHangHoa", lst.TenHangHoa);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "MaAD", lst.MaAvery);

                //var mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaHang).ToString();
                var lo = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colLo).ToString();
                //var db = new MyDBContextDataContext();
                var lst2 = db.LoadData_TonKhoNVL_Lot_View(tungay, denngay).ToList();
                foreach (var item in lst2)
                {
                    if (item.mahang == mahang && item.Lo == lo)
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colHanSuDung, item.HanSuDung);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                //null
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (_MaPhieu != "mới") return;
            var maphieu = "PXK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
            dt = knvlCtr.GetData_MaPhieu(maphieu);
            MaPhieutxt.Text = maphieu + knvlCtr.SinhMaTuDong_MaPhieu(dt);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var khonvl = db.tbKhoNLVs.ToList();
            var tong = 0;
            foreach (var item in khonvl)
            {
                if (item.MaPhieu != MaPhieutxt.Text) continue;
                tong = 1;
                var rp = new rpPhieuXuatKhoNVL();
                rp.DataSource = knvlCtr.GetData("MaPhieu", MaPhieutxt.Text);
                rp.databing();
                rp.ShowRibbonPreviewDialog();
                break;
            }

            if (tong == 0)
                MessageBox.Show("Vui lòng Lưu kho mã phiếu " + MaPhieutxt.Text + " này trước khi in");
        }

        #region Ngaydauthang,cuoithang 

        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        public static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }

        public static DateTime GetLastDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }

        #endregion
        private void risLo_Click_1(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaHang).ToString();
                //var lo = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colLo).ToString();
                //var tong = 0;
                //for (var i = 0; i < gridView1.RowCount - 1; i++)
                //{
                //    var dr = gridView1.GetDataRow(i);
                //    if (dr["MaHang"].ToString() != mahang || string.IsNullOrEmpty(dr["lo"].ToString())) continue;
                //    tong = tong + Convert.ToInt32(dr["SoLuongXuat"]);
                //}
                //MessageBox.Show(tong.ToString());
                var khonvl = (from s in db.LoadData_TonKhoNVL_PhieuXuatKho(tungay, denngay) where s.mahang == mahang select s).ToList();
                foreach (var item in khonvl)
                {
                    for (var i = 0; i < gridView1.RowCount - 1; i++)
                    {
                        var dr = gridView1.GetDataRow(i);
                        if (dr["lo"].ToString() != item.Lo || dr["Mahang"].ToString() != mahang) continue;
                        item.toncuoiky = item.toncuoiky - Convert.ToInt32(dr["SoLuongXuat"]);
                    }
                }
                risLo.DataSource = khonvl;
                risLo.DisplayMember = "Lo";
                risLo.ValueMember = "Lo";
            }
            catch (Exception)
            {
                // ignored
                //Console.WriteLine(ex);
                //throw;
            }

        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var khonvl = db.LoadData_TonKhoNVL_Lot_View(tungay, denngay).ToList();
                foreach (var item in khonvl)
                {
                    var tong = 0;
                    var sl1 = 0;
                    for (var i = 0; i < gridView1.RowCount - 1; i++)
                    {
                        var dr = gridView1.GetDataRow(i);
                        if (!string.IsNullOrEmpty(dr["Lo"].ToString())) continue;
                        if (item.mahang != dr["MaHang"].ToString() || item.Kho != KhoCongTytxt.Text) continue;
                        if (string.IsNullOrEmpty(item.Lo)) continue;
                        if (i == 0) tong = Convert.ToInt32(dr["SoLuongXuat"]);
                        if (i > 0) sl1 = Convert.ToInt32(dr["SoLuongXuat"]);
                        tong = sl1 + tong;
                        if (item.toncuoiky >= tong)
                        {
                            dr["Lo"] = item.Lo;
                            dr["HanSuDung"] = item.HanSuDung;
                            //MessageBox.Show(tong + "  " + item.mahang + "  " + item.Lo);
                        }
                        else
                        {
                            tong = tong - sl1;
                            //MessageBox.Show(tong + "  " + item.mahang + "  " + item.Lo);
                        }
                    }
                }
            }
            catch (Exception)
            {
                //Console.WriteLine(exception);
                //throw;
            }

            //try
            //{
            //    var db = new MyDBContextDataContext();
            //    var a = db.LoadData_TonKhoNVL_View(tungay, denngay).ToList();
            //    foreach (var item in a)
            //    {
            //        var tong = 0;
            //        var sl1 = 0;
            //        for (var i = 0; i < gridView1.RowCount - 1; i++)
            //        {
            //            var dr = gridView1.GetDataRow(i);
            //            if (!string.IsNullOrEmpty(dr["Lo"].ToString())) continue;
            //            if (item.mahang != dr["MaHang"].ToString() || item.Kho != KhoCongTytxt.Text) continue;
            //            if (string.IsNullOrEmpty(item.Lo)) continue;
            //            if (i == 0) tong = Convert.ToInt32(dr["SoLuongXuat"]);
            //            if (i > 0) sl1 = Convert.ToInt32(dr["SoLuongXuat"]);
            //            tong = sl1 + tong;
            //            if (item.toncuoiky >= tong)
            //            {
            //                dr["Lo"] = item.Lo;
            //                dr["HanSuDung"] = item.HanSuDung;
            //                //MessageBox.Show(tong + "  " + item.mahang + "  " + item.Lo);
            //            }
            //            else
            //            {
            //                tong = tong - sl1;
            //                //MessageBox.Show(tong + "  " + item.mahang + "  " + item.Lo);
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    //Console.WriteLine(exception);
            //    //throw;
            //}
        }

        private void btnLichTrinhSanXuat_Click(object sender, EventArgs e)
        {
            var tong = 0;
            var db = new MyDBContextDataContext();
            if (BoPhantxt.Text == "TEM VẢI")
            {
                var khonvl = db.tbKhoNLVs.ToList();
                foreach (var item in khonvl)
                {
                    if (item.MaPhieu != MaPhieutxt.Text) continue;
                    var lst = db.DonSanXuat_KhoNVL_LichTrinh(MaPhieutxt.Text).ToList();
                    var rp = new rpLichTrinhSanXuat(BoPhantxt.Text);
                    rp.DataSource = lst;
                    rp.databingding();
                    rp.ShowRibbonPreviewDialog();
                    tong = 1;
                    break;
                }
                var khonvl2 = db.tbKhoNLVs.ToList();
                foreach (var item in khonvl2)
                {
                    if (item.MaPhieu != MaPhieutxt.Text) continue;
                    var lst = db.DonSanXuat_KhoNVL(MaPhieutxt.Text).ToList();
                    var rp = new rpDanhSachLichTrinhSanXuat();
                    rp.DataSource = lst;
                    rp.databingding();
                    rp.ShowRibbonPreviewDialog();
                    tong = 1;
                    break;
                }

            }
            else
            {
                var khonvl = db.tbKhoNLVs.ToList();
                foreach (var item in khonvl)
                {
                    if (item.MaPhieu != MaPhieutxt.Text) continue;
                    var lst = db.DonSanXuat_KhoNVL(MaPhieutxt.Text).ToList();
                    var rp = new rpLichTrinhSanXuat(BoPhantxt.Text);
                    rp.DataSource = lst;
                    rp.databingding();
                    rp.ShowRibbonPreviewDialog();
                    tong = 1;
                    break;
                }
                if (tong == 0)
                    MessageBox.Show("Vui lòng Lưu kho mã phiếu " + MaPhieutxt.Text + " này trước khi in");

            }
        }
    }
}

