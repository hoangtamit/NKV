using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Object;
using QuanLySanXuat.Control;

namespace QuanLySanXuat
{
    public partial class frmTemVaiAvery : DevExpress.XtraEditors.XtraForm
    {
        public readonly NhanVienObj nvObj;
        public readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        public frmTemVaiAvery(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                //if (radioGroup1.SelectedIndex == 0)
                //{
                    var lst = (from s in db.DonSanXuat_LanhLieu_View()
                               where s.NgayXuongDon == Ngayxuongdontxt.DateTime && s.TenKhachHang == PrintRibbon.AD && s.BoPhan == PrintRibbon.temvai && s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" && s.DanhSach == txtDanhSach.Value// && s.Khac == "SKU 1"
                               select s).ToList();

                    foreach (var dsx in lst)
                    {
                        var tbLanhLieu = (from s in db.tbLanhLieus where s.LanhLieu == null select s).ToList();
                        foreach (var tb in tbLanhLieu)
                        {
                            if (tb.IDLanhLieu != dsx.SCD) continue;
                            var kichthuoc = dsx.KichThuoc.Split('*');
                            //var sku = dsx.Khac.Split(' ');
                            tb.SoLuongSanXuat = dsx.SoLuong;
                            tb.BuHao = (double)txtBuHao.Value;
                            tb.NhanVienSanXuat = nvObj.Tennhanvien;
                            tb.DonViTinh = "YARD";
                            var tinh = ((tb.SoLuongSanXuat * tb.BuHao ) * Convert.ToDouble(kichthuoc[1]) * 1.09 / 1000) + (int)txtChoThem.Value * Convert.ToInt32(dsx.SKU);
                            if (tinh != null) tb.LanhLieu = (int) tinh;
                            //if (tinh != null)
                            //{
                            //    if (dsx.SoLuong < 500)
                            //        tb.LanhLieu = (int)tinh + 5;
                            //    else
                            //        tb.LanhLieu = (int)tinh;
                            //}
                            var vatlieu = db.tbVatLieus.Single(s => s.TenHangHoa == dsx.VatLieu && tb.DonViTinh == "YARD");
                            tb.QuyCach = vatlieu.QuyCach;
                            db.SubmitChanges();
                        }
                    }
                //}
                //else
                //{
                //    var donsanxuat = (from s in db.DonSanXuat_LanhLieu_View()
                //                  where s.NgayXuongDon == Ngayxuongdontxt.DateTime && s.TenKhachHang == PrintRibbon.AD && s.BoPhan == PrintRibbon.temvai && s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" && s.Khac != "SKU 1" && s.Khac != null
                //                  select s).ToList();
                //    foreach (var dsx in donsanxuat)
                //    {
                //        var lanhlieu = (from s in db.tbLanhLieus where s.IDLanhLieu == dsx.SCD select s).Single();
                //        var kichthuoc = dsx.KichThuoc.Split('*');
                //        var _Size = db.TemDanAD_GroupBy_Size(dsx.SCD).ToList();
                //        double tong = 0;
                //        foreach (var size in _Size)
                //        {
                //            double tong1;
                //            double tong2 = 0;
                //            var TongSize = (from s in db.TemDanAD_Size(dsx.SCD) select s).ToList();
                //            foreach (var item2 in TongSize)
                //            {
                //                if (size.Size != item2.Size) continue;
                //                if (item2.QTY == "500 + 5")
                //                {
                //                    var a = item2.QTY.Split('+');
                //                    tong2 = tong2 + Convert.ToInt32(a[0]);
                //                }
                //                else
                //                    tong2 = tong2 + Convert.ToInt32(item2.QTY);

                //            }
                //            if (tong2 < 500)
                //                tong1 = (double)(tong2 * lanhlieu.BuHao * Convert.ToInt32(kichthuoc[1]) * 1.09 / 1000 + 5);
                //            else
                //                tong1 = (double)(tong2 * lanhlieu.BuHao * Convert.ToInt32(kichthuoc[1]) * 1.09 / 1000);
                //            tong = tong + tong1;
                //        }
                //        //MessageBox.Show(item.SCD + "  - tong -  " + Math.Ceiling(tong));
                //        lanhlieu.SoLuongSanXuat = dsx.SoLuong;
                //        lanhlieu.BuHao = (double)txtBuHao.Value;
                //        lanhlieu.NhanVienSanXuat = nvObj.Tennhanvien;
                //        lanhlieu.DonViTinh = "YARD";
                //        lanhlieu.LanhLieu = (int)Math.Ceiling(tong);
                //        var vatlieu = db.tbVatLieus.Single(s => s.TenHangHoa == dsx.VatLieu && dsx.DonViTinh == "YARD");
                //        lanhlieu.QuyCach = vatlieu.QuyCach;
                //        db.SubmitChanges();
                //    }                    
                //}
                MessageBox.Show(PrintRibbon.themthanhcong);
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi " + exception);
                //throw;
            }
            Ngayxuongdontxt_EditValueChanged(sender ,e);
            

        }

        private void Ngayxuongdontxt_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            //if (radioGroup1.SelectedIndex == 0)
            //{              
                var lst = (from s in db.DonSanXuat_LanhLieu_View()
                           where s.NgayXuongDon == Ngayxuongdontxt.DateTime && s.TenKhachHang == PrintRibbon.AD && s.BoPhan == PrintRibbon.temvai && s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" && s.DanhSach == txtDanhSach.Value //&& s.Khac == "SKU 1"
                           select s).ToList();
                procDonSanXuat_ViewGridControl.DataSource = lst;
            //}
            //else
            //{
            //    var lst = (from s in db.DonSanXuat_LanhLieu_View()
            //               where s.NgayXuongDon == Ngayxuongdontxt.DateTime && s.TenKhachHang == PrintRibbon.AD && s.BoPhan == PrintRibbon.temvai && s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" && s.Khac != "SKU 1" && s.Khac != null
            //               select s).ToList();
            //    procDonSanXuat_ViewGridControl.DataSource = lst;
            //}
        }

        private void LamMoitxt_Click(object sender, EventArgs e)
        {
            Ngayxuongdontxt_EditValueChanged(sender,e);
        }

        private void btnDonLanhLieu_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            //if (radioGroup1.SelectedIndex == 0)
            //{
                var lst = (from s in db.DonSanXuat_LanhLieu_View()
                           where s.NgayXuongDon == Ngayxuongdontxt.DateTime && s.TenKhachHang == PrintRibbon.AD && s.BoPhan == PrintRibbon.temvai && s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" && s.DanhSach == txtDanhSach.Value// && s.Khac == "SKU 1"
                           select s).ToList();
                var rp = new rpDonLanhLieu_Avery { DataSource = lst };
                rp.databing();
                rp.ShowRibbonPreviewDialog();
            //}
            //else
            //{
            //    var lst = (from s in db.DonSanXuat_LanhLieu_View()
            //               where s.NgayXuongDon == Ngayxuongdontxt.DateTime && s.TenKhachHang == PrintRibbon.AD && s.BoPhan == PrintRibbon.temvai && s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" && s.Khac != "SKU 1" && s.Khac != null
            //               select s).ToList();
            //    var rp = new rpDonLanhLieu_Avery { DataSource = lst };
            //    rp.databing();
            //    rp.ShowRibbonPreviewDialog();
            //}
        }

        private void frmTemVaiAvery_Load(object sender, EventArgs e)
        {
            Ngayxuongdontxt.DateTime = DateTime.Today;
            Ngayxuongdontxt_EditValueChanged(sender, e);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ngayxuongdontxt_EditValueChanged(sender, e);
        }

        private void bbiDonSanXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dt = dsxCtr.LoadData_DonSanXuat_NgayXuongDon_DanhSach(Ngayxuongdontxt.DateTime.ToString("yyyy-MM-dd"),(int)txtDanhSach.Value);
            var rp = new rptDonSanXuat_Avery { DataSource = dt };
            rp.databing();
            rp.ShowRibbonPreviewDialog();
        }

        private void bbiDonLanhLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var db = new MyDBContextDataContext();
            //if (radioGroup1.SelectedIndex == 0)
            //{
            var lst = (from s in db.DonSanXuat_LanhLieu_View()
                where s.NgayXuongDon == Ngayxuongdontxt.DateTime && s.TenKhachHang == PrintRibbon.AD && s.BoPhan == PrintRibbon.temvai && s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" && s.DanhSach == txtDanhSach.Value// && s.Khac == "SKU 1"
                select s).ToList();
            var rp = new rpDonLanhLieu_Avery { DataSource = lst };
            rp.databing();
            rp.ShowRibbonPreviewDialog();
        }

        private void txtDanhSach_EditValueChanged(object sender, EventArgs e)
        {
            Ngayxuongdontxt_EditValueChanged(sender,e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //int tong = 0;
        //foreach (var dsxAvery in dsxAD)
        //{
        //}
        //var dsxAD = (from s in db.tbDonSanXuat_Averies where s.OrderDate == Ngayxuongdontxt.DateTime select s).ToList();
        //foreach (var dsx in lst)
        //{//    int tong = 0;
        //    foreach (var dsxAvery in dsxAD)
        //    {
        //        double scrap = 0;
        //        if (dsx.SCD != dsxAvery.scd) continue;
        //        if (dsxAvery.Qty / dsxAvery.SKU > 1000)
        //            scrap = 0.02;
        //        else if (dsxAvery.Qty / dsxAvery.SKU > 500)
        //            scrap = 0.04;
        //        else if (dsxAvery.Qty / dsxAvery.SKU > 300)
        //            scrap = 0.06;
        //        else if (dsxAvery.Qty / dsxAvery.SKU > 200)
        //            scrap = 0.08;
        //        else if (dsxAvery.Qty / dsxAvery.SKU > 100)
        //            scrap = 0.12;
        //        else if (dsxAvery.Qty / dsxAvery.SKU <= 100)
        //            scrap = 0.21;
        //        var tinh = (1 + scrap) *
        //                   ((dsxAvery.Qty * 1.1 + dsxAvery.SKU * 5 +
        //                     Math.Ceiling((double)dsxAvery.Qty / 500) * 6 + 15 + 15) *
        //                    (dsxAvery.Length / 1000) + (dsxAvery.SKU - 1) * 2 + 9) / 0.9144;
        //        if (tinh != null)
        //            tong = (int)(tong + Math.Truncate((double)tinh));
        //    }

        //    var tb = (from s in db.tbLanhLieus where s.IDLanhLieu == dsx.SCD select s).Single();
        //    tb.LanhLieu = tong;
        //    tb.SoLuongSanXuat = dsx.SoLuong;
        //    tb.BuHao = 1.1;
        //    tb.DonViTinh = "YARD";
        //    db.SubmitChanges();
        //}
    }
}