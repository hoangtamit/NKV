using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.Kho
{
    public partial class frmPhieuNhapKhoNVL : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt;
        private readonly KhoNVLCtr knvlCtr = new KhoNVLCtr();
        private readonly NhanVienObj nvObj;
        private readonly string _MaPhieu;
        private readonly int _flagluu;

        public frmPhieuNhapKhoNVL(NhanVienObj obj, string maphieu, int flagluu)
        {
            InitializeComponent();
            nvObj = obj;
            _MaPhieu = maphieu;
            _flagluu = flagluu;
        }

        private void frmPhieuNhapKhoNVL_Load(object sender, EventArgs e)
        {
            SearchLookup();
            MaPhieu();
            
        }

        public void MaPhieu()
        {
            if (_MaPhieu == "mới")
            {
                var knvl_DemoCtr = new KhoNVLCtr_Demo();
                gridControl1.DataSource = knvl_DemoCtr.LoadData();
                var maphieu = "PNK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
                dt = knvlCtr.GetData_MaPhieu(maphieu);
                MaPhieutxt.Text = maphieu + knvlCtr.SinhMaTuDong_MaPhieu(dt);
                NgayNhaptxt.DateTime = DateTime.Today;
                KhoCongTytxt.Text = "NGUYÊN VẬT LIỆU";
            }
            else
            {
                MaPhieutxt.Text = _MaPhieu;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbKhoNLVs where s.MaPhieu == _MaPhieu select s).ToList();
                foreach (var tbkhonvl in lst)
                {
                    KhoCongTytxt.Text = tbkhonvl.Kho;
                    NhaCungCaptxt.Text = tbkhonvl.NhaCungCap;
                    txtlo.Text = tbkhonvl.Lo;
                    if (tbkhonvl.Ngay != null) NgayNhaptxt.DateTime = tbkhonvl.Ngay.Value;

                    break;
                }
                gridControl1.DataSource = knvlCtr.GetData("MaPhieu",_MaPhieu);
                btnLuu.Text = "Cập Nhật";
            }
        }

        public void SearchLookup()
        {
            //// Bảng Vật Liệu
            var vlCtr = new VatLieuCtr();
            risMaHang.DataSource = vlCtr.LoadData4C();
            risMaHang.DisplayMember = "MaHang";
            risMaHang.ValueMember = "MaHang";

            // Bảng Nhà Cung Cấp
            var nccCtr = new NhaCungCapCtr();
            NhaCungCaptxt.Properties.DataSource = nccCtr.LoadData1C();
            NhaCungCaptxt.Properties.DisplayMember = "TenNhaCungCap";
            NhaCungCaptxt.Properties.ValueMember = "TenNhaCungCap";

            // Bảng Kho
            var khoCtr = new KhoCtr();
            KhoCongTytxt.Properties.DataSource = khoCtr.LoadData1C();
            KhoCongTytxt.Properties.DisplayMember = "ID";
            KhoCongTytxt.Properties.ValueMember = "ID";



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
                var gioihan = DateTime.Today - NgayNhaptxt.DateTime;
                if (!string.IsNullOrEmpty(NhaCungCaptxt.Text))
                {
                    if (!string.IsNullOrEmpty(KhoCongTytxt.Text))
                    {
                        if ((int) gioihan.TotalDays <= 100 && gioihan.TotalDays >= 0)
                        {
                            DataRow dr;
                            var db = new MyDBContextDataContext();
                            if (_flagluu == 2)
                                knvlCtr.DelData("MaPhieu", _MaPhieu);
                            for (var i = 0; i < gridView1.RowCount - 1; i++)
                            {
                                var IDKho = "/" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "N";
                                dt = knvlCtr.GetData_IDKho(IDKho);
                                dr = gridView1.GetDataRow(i);
                                var lst = db.tbVatLieus.Single(s => s.MaHang == dr["MaHang"].ToString());
                                var knvl = new tbKhoNLV();
                                knvl.IDKhoNVL = knvlCtr.SinhMaTuDong_IDkho(dt) + IDKho;
                                knvl.MaPhieu = MaPhieutxt.Text;
                                knvl.Lo = txtlo.Text;
                                if (!string.IsNullOrEmpty(dr["HanSuDung"].ToString()))
                                {
                                    knvl.HanSuDung = (DateTime) dr["HanSuDung"];
                                }
                                knvl.NhapXuat = "Nhập";
                                knvl.Kho = KhoCongTytxt.Text;
                                knvl.Ngay = NgayNhaptxt.DateTime;
                                knvl.TenHangHoa = lst.TenHangHoa;
                                knvl.DonViTinh = lst.DonViTinh;
                                knvl.QuyCach = lst.QuyCach;
                                knvl.MaHang = lst.MaHang;
                                knvl.MaAD = lst.MaAvery;
                                knvl.LoaiHang = lst.IDMaHang;
                                knvl.SoLuongNhap = (double) dr["SoLuongNhap"];
                                knvl.NhaCungCap = NhaCungCaptxt.Text;
                                knvl.GhiChu = dr["GhiChu"].ToString();
                                knvl.NguoiQuanKho = nvObj.Tennhanvien;
                                db.tbKhoNLVs.InsertOnSubmit(knvl);
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

                            //frmPhieuNhapKhoNVL_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu đã vượt quá thời gian cho phép Lưu kho");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập kho công ty");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập Nhà Cung Cấp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                //null
            }
        }
        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var mahang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMaHang).ToString();
                var db = new MyDBContextDataContext();
                var lst = db.tbVatLieus.Single(s => s.MaHang == mahang);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DonViTinh", lst.DonViTinh);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "QuyCach", lst.QuyCach);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TenHangHoa", lst.TenHangHoa);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "MaAD", lst.MaAvery);
            }
            catch (Exception)
            {
                //null
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (_MaPhieu != "mới") return;
            var maphieu = "PNK" + DateTime.Now.ToString("ddMMyyHHmmss").Substring(2, 4) + "/";
            dt = knvlCtr.GetData_MaPhieu(maphieu);
            MaPhieutxt.Text = maphieu + knvlCtr.SinhMaTuDong_MaPhieu(dt);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbKhoNLVs.ToList();
            var tong = 0;
            foreach (var tbKhoNlv in lst)
            {
                if(tbKhoNlv.MaPhieu != MaPhieutxt.Text)continue;
                tong = 1;
                var rp = new rpPhieuNhapKhoNVL();
                rp.DataSource = knvlCtr.GetData("MaPhieu", MaPhieutxt.Text);
                rp.databing();
                rp.ShowRibbonPreviewDialog();
                break;
            }

            if (tong == 0)
                MessageBox.Show("Vui lòng Lưu kho mã phiếu " + MaPhieutxt.Text + " này trước khi in");

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
