using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.QuanLyDonHang
{
    public partial class frmTemDanAD : DevExpress.XtraEditors.XtraForm
    {
        private readonly TemDanADCtr tdADCtr = new TemDanADCtr();
        private readonly DonSanXuat_AveryCtr dsx_Avery = new DonSanXuat_AveryCtr();
        string SCD;
        string so,sku,qty;
        public int tsl = 0;
        DateTime orderdate;
        public frmTemDanAD()
        {
            InitializeComponent();
        }

        private void frmTemDanAD_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Today;
            dateEdit1_EditValueChanged(sender,e);
            var db = new MyDBContextDataContext();
            gcBang.DataSource = db.tbBangTemDanADs;
        }


        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                //ClearSize();
                ClearSO();
                ClearSoLuong();
                var db = new MyDBContextDataContext();
                //scd = gvOutSourceList.GetRowCellValue(gvOutSourceList.FocusedRowHandle, colSCD1).ToString();
                so = gvOutSourceList.GetRowCellValue(gvOutSourceList.FocusedRowHandle, colSO).ToString();
                sku = gvOutSourceList.GetRowCellValue(gvOutSourceList.FocusedRowHandle, colSKU).ToString();
                qty = gvOutSourceList.GetRowCellValue(gvOutSourceList.FocusedRowHandle, colQty).ToString();
                orderdate = Convert.ToDateTime(gvOutSourceList
                    .GetRowCellValue(gvOutSourceList.FocusedRowHandle, colOrderDate).ToString());
                for (int i = 0; i < gvBang.RowCount; i++)
                {
                    gvBang.SetRowCellValue(i, colSO2, so);
                }

                var tdAD = (from s in db.tbTemDanAds where s.IDTemDanAD == SCD && s.SO == so select s).ToList();
                if (tdAD.Count == 0)
                    simpleButton1.Enabled = true;
                else
                    simpleButton1.Enabled = false;
            }
            catch (Exception)
            {
                //null
            }          
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            var frm = new frmXem(SCD);
            frm.ShowDialog();
        }


        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            gridControl1_Click(sender, e);
        }

        private void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
            gridControl1_Click(sender, e);
        }

        private void frmTemDanAD_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var tong = 0;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbTemDanAds where s.IDTemDanAD == SCD select s).ToList();
                foreach (var item in lst)
                {
                    //item.QTY.ContainsAny()
                    if (Convert.ToInt32(item.QTY) > 0)
                    {
                        tong = tong + Convert.ToInt32(item.QTY);
                    }
                    else
                    {
                        var soluong = item.QTY;
                        tong = tong + Convert.ToInt32(soluong[0]);
                    }

                    
                }
                var dsx = (from s in db.tbDonSanXuats where s.SCD == SCD select s).Single();
                if (tong != dsx.SoLuong)
                    MessageBox.Show("Đơn hàng này tính số lượng chưa đúng với đơn hàng vui lòng xem lại");
            }
            catch (Exception)
            {
                // ignored
            }
        }

      
        public void ClearSize()
        {
            for (int i = 0; i < gvBang.RowCount; i++)
            {
                gvBang.SetRowCellValue(i,colSize,string.Empty);
            }
        }
        public void ClearSoLuong()
        {
            for (int i = 0; i < gvBang.RowCount; i++)
            {
                gvBang.SetRowCellValue(i, colSoLuong, string.Empty);
            }
        }

        public void ClearSO()
        {
            for(int i = 0; i < gvBang.RowCount; i++)
            {
                gvBang.SetRowCellValue(i, colSO2, string.Empty);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbTemDanAds where s.SO == so select s).ToList();
            db.tbTemDanAds.DeleteAllOnSubmit(lst);
            db.SubmitChanges();
        }

        private void gcQuanLyDonHang_Click(object sender, EventArgs e)
        {
            ClearSize();
            try
            {
                var bophan = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colBoPhan).ToString();
                var khachhang = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colTenKhachHang).ToString();
                //var SKU = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colSKU).ToString();
                if (bophan == PrintRibbon.temvai && khachhang == PrintRibbon.AD)
                {
                    SCD = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, colSCD).ToString();
                    gcOutSourceList.DataSource = dsx_Avery.GetData_SCD(SCD);
                    ClearSize();
                    ClearSoLuong();
                }
                else
                {
                    MessageBox.Show("Không phải đơn hàng tem vải 1.AD");
                }
            }
            catch (Exception)
            {
                //null
            }

            
        }

        private void bbiSKU_Click(object sender, EventArgs e)
        {
            var frm = new frmTemDan1SKU();
            frm.ShowDialog();
        }

        private void btnInNhanh_Click(object sender, EventArgs e)
        {
            XtraReport1 rp = new XtraReport1();
            rp.DataSource = tdADCtr.GetData_IDTemDanAD(SCD);
            rp.databingding();
            rp.Print();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            XtraReport1 rp = new XtraReport1();
            rp.DataSource = tdADCtr.GetData_IDTemDanAD(SCD);
            rp.databingding();
            rp.ShowRibbonPreviewDialog();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            for (int i = 0; i < gvOutSourceList.RowCount; i++)
            {
                var dr = gvOutSourceList.GetDataRow(i);
                if (dr.RowState != DataRowState.Modified) continue;
                var db = new MyDBContextDataContext();
                var _so = (from s in db.tbDonSanXuat_Averies where s.SO == so select s).Single();
                //_so.scd = dr["SCD"].ToString();
                _so.Qty = Convert.ToInt32(dr["Qty"].ToString());
                _so.SKU = Convert.ToInt32(dr["SKU"].ToString());
                db.SubmitChanges();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (simpleButton2.Text == "SỬA")
            {
                gvOutSourceList.OptionsBehavior.Editable = true;
                simpleButton2.Text = "SỬA XONG";
            }
            else if(simpleButton2.Text == "SỬA XONG")
            {
                gvOutSourceList.OptionsBehavior.Editable = false;
                simpleButton2.Text = "SỬA";
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dateEdit1_EditValueChanged(sender,e);
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            object tb;

            tb = (from s in db.tbDonSanXuats
                join y in db.tbDonSanXuat_Averies on s.SCD equals y.scd
                from x in db.tbQuanLyDonHangs
                where s.TenKhachHang == "1.AD" && s.BoPhan == "TEM VẢI" && s.SCD == x.IDQuanLyDonHang &&
                      x.HoanThanh == null
                      && s.NgayXuongDon == dateEdit1.DateTime
                select new
                {
                    s.SCD,
                    s.MaDonHang,
                    s.NgayXuongDon,
                    s.NgayGiaoHang,
                    s.SoLuong,
                    s.TenKhachHang,
                    s.TenSanPham,
                    s.KichThuoc,
                    s.BoPhan,
                    s.SKU,
                    y.XacNhan
                    //x.NghiepVu_XuongDon,x.ThietKeNhan,x.ThietKeHoanThanh,x.HoanThanh
                }).Distinct().OrderByDescending(s => s.SCD);


            gcQuanLyDonHang.DataSource = tb;
        }

        private void SIZE1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClearSize();
            if (cbbSize.Text == "0001")
            {
                for (int i = 0; i < gvBang.RowCount; i++)
                {
                    string dem;
                    if (i < 9)
                    {
                        dem = "000";
                        dem = dem + (i + 1);
                    }
                    else
                    {
                        dem = "00";
                        dem = dem + (i + 1);
                    }

                    gvBang.SetRowCellValue(i, colSize, dem);
                }
            }

            if (cbbSize.Text == "1 YEARS")
            {
                gvBang.SetRowCellValue(0, colSize, "1 YEARS");
                gvBang.SetRowCellValue(1, colSize, "2 YEARS");
                gvBang.SetRowCellValue(2, colSize, "3 YEARS");
                gvBang.SetRowCellValue(3, colSize, "4 YEARS");
                gvBang.SetRowCellValue(4, colSize, "5 YEARS");
                gvBang.SetRowCellValue(5, colSize, "6-12 YEARS");
                gvBang.SetRowCellValue(6, colSize, "12-18 YEARS");
                gvBang.SetRowCellValue(7, colSize, "18-24 YEARS");
                gvBang.SetRowCellValue(8, colSize, "S");
                gvBang.SetRowCellValue(9, colSize, "M");
                gvBang.SetRowCellValue(10, colSize, "L");
                gvBang.SetRowCellValue(11, colSize, "XL");
                gvBang.SetRowCellValue(12, colSize, "XXL");
                gvBang.SetRowCellValue(13, colSize, "3XL");
                gvBang.SetRowCellValue(14, colSize, "4XL");
            }

            if (cbbSize.Text == "S")
            {
                gvBang.SetRowCellValue(0, colSize, "S");
                gvBang.SetRowCellValue(1, colSize, "M");
                gvBang.SetRowCellValue(2, colSize, "L");
                gvBang.SetRowCellValue(3, colSize, "LL");
                gvBang.SetRowCellValue(4, colSize, "3L");
                gvBang.SetRowCellValue(5, colSize, "4L");
                gvBang.SetRowCellValue(6, colSize, "XL");
                gvBang.SetRowCellValue(7, colSize, "XXL");
                gvBang.SetRowCellValue(8, colSize, "XS");
                gvBang.SetRowCellValue(9, colSize, "2XS");
                gvBang.SetRowCellValue(10, colSize, "1T");
                gvBang.SetRowCellValue(11, colSize, "2T");
                gvBang.SetRowCellValue(12, colSize, "3T");
                gvBang.SetRowCellValue(13, colSize, "4T");
                gvBang.SetRowCellValue(14, colSize, "5T");
            }

            if (cbbSize.Text == "J110")
            {
                gvBang.SetRowCellValue(0, colSize, "J110");
                gvBang.SetRowCellValue(1, colSize, "J116");
                gvBang.SetRowCellValue(2, colSize, "J128");
                gvBang.SetRowCellValue(3, colSize, "J140");
                gvBang.SetRowCellValue(4, colSize, "J152");
                gvBang.SetRowCellValue(5, colSize, "J164");
                gvBang.SetRowCellValue(6, colSize, "J176");
                gvBang.SetRowCellValue(7, colSize, "110");
                gvBang.SetRowCellValue(8, colSize, "116");
                gvBang.SetRowCellValue(9, colSize, "128");
                gvBang.SetRowCellValue(10, colSize, "140");
                gvBang.SetRowCellValue(11, colSize, "152");
                gvBang.SetRowCellValue(12, colSize, "164");
                gvBang.SetRowCellValue(13, colSize, "176");
            }

            if (cbbSize.Text == "A/2XL")
            {
                gvBang.SetRowCellValue(0, colSize, "A/2XL");
                gvBang.SetRowCellValue(1, colSize, "A/3XL");
                gvBang.SetRowCellValue(2, colSize, "A/L");
                gvBang.SetRowCellValue(3, colSize, "A/M");
                gvBang.SetRowCellValue(4, colSize, "A/S");
                gvBang.SetRowCellValue(5, colSize, "A/XL");
                gvBang.SetRowCellValue(6, colSize, "A/XS");
            }

            if (cbbSize.Text == "A38")
            {
                gvBang.SetRowCellValue(0, colSize, "A38");
                gvBang.SetRowCellValue(1, colSize, "A42");
                gvBang.SetRowCellValue(2, colSize, "A46");
                gvBang.SetRowCellValue(3, colSize, "A50");
                gvBang.SetRowCellValue(4, colSize, "A54");
                gvBang.SetRowCellValue(5, colSize, "A58");
            }

            if (cbbSize.Text == "32")
            {
                gvBang.SetRowCellValue(0, colSize, "32");
                gvBang.SetRowCellValue(1, colSize, "36");
                gvBang.SetRowCellValue(2, colSize, "40");
                gvBang.SetRowCellValue(3, colSize, "42");
                gvBang.SetRowCellValue(4, colSize, "44");
                gvBang.SetRowCellValue(5, colSize, "46");
                gvBang.SetRowCellValue(6, colSize, "48");
                gvBang.SetRowCellValue(7, colSize, "50");
                gvBang.SetRowCellValue(8, colSize, "52");
                gvBang.SetRowCellValue(9, colSize, "54");
                gvBang.SetRowCellValue(10, colSize, "56");
                gvBang.SetRowCellValue(11, colSize, "58");
                gvBang.SetRowCellValue(12, colSize, "50L");
                gvBang.SetRowCellValue(13, colSize, "54T");
                gvBang.SetRowCellValue(14, colSize, "58T");
                gvBang.SetRowCellValue(15, colSize, "62T");
                gvBang.SetRowCellValue(16, colSize, "66T");
                gvBang.SetRowCellValue(17, colSize, "70T");
            }

            if (cbbSize.Text == "92")
            {
                gvBang.SetRowCellValue(0, colSize, "92");
                gvBang.SetRowCellValue(1, colSize, "98");
                gvBang.SetRowCellValue(2, colSize, "100");
                gvBang.SetRowCellValue(3, colSize, "104");
                gvBang.SetRowCellValue(4, colSize, "110");
                gvBang.SetRowCellValue(5, colSize, "116");
                gvBang.SetRowCellValue(6, colSize, "122");
                gvBang.SetRowCellValue(7, colSize, "128");
                gvBang.SetRowCellValue(8, colSize, "134");
                gvBang.SetRowCellValue(9, colSize, "140");
                gvBang.SetRowCellValue(10, colSize, "146");
                gvBang.SetRowCellValue(11, colSize, "152");
                gvBang.SetRowCellValue(12, colSize, "158");
                gvBang.SetRowCellValue(13, colSize, "164");
                gvBang.SetRowCellValue(14, colSize, "170");
                gvBang.SetRowCellValue(15, colSize, "176");
            }

            if (cbbSize.Text == "1 YEARS ANS")
            {
                gvBang.SetRowCellValue(0, colSize, "1 YEARS ANS");
                gvBang.SetRowCellValue(1, colSize, "2 YEARS ANS");
                gvBang.SetRowCellValue(2, colSize, "3 YEARS ANS");
                gvBang.SetRowCellValue(3, colSize, "4 YEARS ANS");
                gvBang.SetRowCellValue(4, colSize, "5 YEARS ANS");
                gvBang.SetRowCellValue(5, colSize, "6-12 MONTHS MOIS");
                gvBang.SetRowCellValue(6, colSize, "12-18 MONTHS MOIS");
                gvBang.SetRowCellValue(7, colSize, "18-24 MONTHS MOIS");
                gvBang.SetRowCellValue(8, colSize, "S");
                gvBang.SetRowCellValue(9, colSize, "M");
                gvBang.SetRowCellValue(10, colSize, "L");
                gvBang.SetRowCellValue(11, colSize, "XL");
                gvBang.SetRowCellValue(12, colSize, "XXL");
                gvBang.SetRowCellValue(13, colSize, "3XL");
                gvBang.SetRowCellValue(13, colSize, "4XL");
            }

            if (cbbSize.Text == "0-3M")
            {
                gvBang.SetRowCellValue(0, colSize, "0-3M");
                gvBang.SetRowCellValue(1, colSize, "3-6M");
                gvBang.SetRowCellValue(2, colSize, "6-12M");
                gvBang.SetRowCellValue(3, colSize, "12-18M");
                gvBang.SetRowCellValue(4, colSize, "18-24M");
            }

            if (cbbSize.Text == "3M")
            {
                gvBang.SetRowCellValue(0, colSize, "6M");
                gvBang.SetRowCellValue(1, colSize, "9M");
                gvBang.SetRowCellValue(2, colSize, "12M");
                gvBang.SetRowCellValue(3, colSize, "15M");
                gvBang.SetRowCellValue(4, colSize, "18M");
                gvBang.SetRowCellValue(5, colSize, "1TOD");
                gvBang.SetRowCellValue(6, colSize, "2TOD");
                gvBang.SetRowCellValue(7, colSize, "3TOD");
                gvBang.SetRowCellValue(8, colSize, "4TOD");
                gvBang.SetRowCellValue(9, colSize, "5TOD");
                gvBang.SetRowCellValue(10, colSize, "6TOD");
            }

            if (cbbSize.Text == "J42")
            {
                gvBang.SetRowCellValue(0, colSize, "J42");
                gvBang.SetRowCellValue(1, colSize, "J44");
                gvBang.SetRowCellValue(2, colSize, "J46");
                gvBang.SetRowCellValue(3, colSize, "J48");
                gvBang.SetRowCellValue(4, colSize, "J50");
                gvBang.SetRowCellValue(5, colSize, "J52");
                gvBang.SetRowCellValue(6, colSize, "J54");
                gvBang.SetRowCellValue(7, colSize, "J56");
                gvBang.SetRowCellValue(8, colSize, "J58");
            }

            if (cbbSize.Text == "28")
            {
                gvBang.SetRowCellValue(0, colSize, "28");
                gvBang.SetRowCellValue(1, colSize, "28L");
                gvBang.SetRowCellValue(2, colSize, "32");
                gvBang.SetRowCellValue(3, colSize, "32L");
                gvBang.SetRowCellValue(4, colSize, "36");
                gvBang.SetRowCellValue(5, colSize, "36L");
                gvBang.SetRowCellValue(6, colSize, "40");
                gvBang.SetRowCellValue(7, colSize, "40L");
                gvBang.SetRowCellValue(8, colSize, "44");
                gvBang.SetRowCellValue(9, colSize, "44L");
                gvBang.SetRowCellValue(10, colSize, "48");
                gvBang.SetRowCellValue(11, colSize, "48L");
                gvBang.SetRowCellValue(12, colSize, "52");
                gvBang.SetRowCellValue(13, colSize, "52L");
            }

            if (cbbSize.Text == "YLG")
            {
                gvBang.SetRowCellValue(0, colSize, "YLG");
                gvBang.SetRowCellValue(1, colSize, "YSM");
                gvBang.SetRowCellValue(2, colSize, "YXL");
                gvBang.SetRowCellValue(3, colSize, "YXS");

            }

            if (cbbSize.Text == "XS/P")
            {
                gvBang.SetRowCellValue(0, colSize, "XS/P");
                gvBang.SetRowCellValue(1, colSize, "S/P");
                gvBang.SetRowCellValue(2, colSize, "M/P");
                gvBang.SetRowCellValue(3, colSize, "L/P");
                gvBang.SetRowCellValue(4, colSize, "XL/P");
                gvBang.SetRowCellValue(5, colSize, "XXL/P");
                gvBang.SetRowCellValue(6, colSize, "3XL/P");
            }

            if (cbbSize.Text == "S REGULAR")
            {
                gvBang.SetRowCellValue(0, colSize, "S REGULAR");
                gvBang.SetRowCellValue(1, colSize, "M REGULAR");
                gvBang.SetRowCellValue(2, colSize, "L REGULAR");
                gvBang.SetRowCellValue(3, colSize, "XL REGULAR");
                gvBang.SetRowCellValue(4, colSize, "XXL REGULAR");
                gvBang.SetRowCellValue(5, colSize, "3XL REGULAR");
                gvBang.SetRowCellValue(6, colSize, "XS REGULAR");
            }

            if (cbbSize.Text == "LG")
            {
                gvBang.SetRowCellValue(0, colSize, "LG");
                gvBang.SetRowCellValue(1, colSize, "MD");
                gvBang.SetRowCellValue(2, colSize, "SM");
                gvBang.SetRowCellValue(3, colSize, "XL");
                gvBang.SetRowCellValue(4, colSize, "XS");
                gvBang.SetRowCellValue(4, colSize, "XXL");
            }

            if (cbbSize.Text == "7-8Y")
            {
                gvBang.SetRowCellValue(0, colSize, "7-8Y");
                gvBang.SetRowCellValue(1, colSize, "9-10Y");
                gvBang.SetRowCellValue(2, colSize, "11-12Y");
                gvBang.SetRowCellValue(3, colSize, "13-14Y");
                gvBang.SetRowCellValue(4, colSize, "15-16Y");
                gvBang.SetRowCellValue(5, colSize, "17-18Y");
                gvBang.SetRowCellValue(6, colSize, "19-20Y");
                gvBang.SetRowCellValue(7, colSize, "21-22Y");
                gvBang.SetRowCellValue(8, colSize, "910Y");
                gvBang.SetRowCellValue(9, colSize, "128");
                gvBang.SetRowCellValue(10, colSize, "1112");
                gvBang.SetRowCellValue(11, colSize, "1314");
                gvBang.SetRowCellValue(12, colSize, "1314");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int tong = 0;
            var dbc = new MyDBContextDataContext();
            for (int i = 0; i < gvBang.RowCount; i++)
            {
                var soluong = Convert.ToInt32(gvBang.GetRowCellValue(i, colSoLuong));
                var size = gvBang.GetRowCellValue(i, colSize).ToString();
                if (Convert.ToInt32(soluong) < 1) continue;
                var _solanin = Math.Ceiling((double)soluong / 500);
                var _sodu = soluong - soluong / 500 * 500; 
                for (int j = 1; j <= _solanin; j++)
                {
                    tbTemDanAd tb = new tbTemDanAd();
                    tb.IDTemDanAD = SCD;
                    tb.SO = so;
                    tb.Size = size;
                    tb.OrderDate = orderdate;
                    if (j == (int)_solanin && _sodu > 0 || soluong < 500 && _sodu == 0)
                        tb.QTY = _sodu.ToString();
                    else
                        tb.QTY = "500";
                    
                    dbc.tbTemDanAds.InsertOnSubmit(tb);
                    tong = tong + Convert.ToInt32(tb.QTY);
                }

                //MessageBox.Show(tong.ToString());
            }
            if (tong == Convert.ToInt32(qty))
            {
                dbc.SubmitChanges();
                MessageBox.Show(PrintRibbon.themthanhcong);
                var tb = dbc.tbBaoCaoThietKes.Single(s => s.IDBaoCaoThietKe == SCD);
                var nghiepvu = dbc.tbBaoCaoNghiepVus.Single(s => s.IDBaoCaoNghiepVu == SCD);
                tb.BanIn = "Đạt";
                tb.SanPham = "Đạt";
                tb.Layout = "Đạt";
                tb.NetChu = "Đạt";
                tb.CoChu = "Đạt";
                tb.VitriCatGap = "Đạt";
                tb.KyHieu = "Đạt";
                tb.DanhGia = "Đạt";
                tb.Size = nghiepvu.Size;
                var dsxAvery = (from s in dbc.tbDonSanXuat_Averies where s.SO == so select s).Single();
                dsxAvery.XacNhan = 2;
                dbc.SubmitChanges();
                dateEdit1_EditValueChanged(sender,e);
            }
            else if (tong == 0)
            {
                MessageBox.Show("Đơn hàng không tồn tại");
            }
            else
                MessageBox.Show("Số lượng không đúng , vui lòng xem lại");
        }

    }
}