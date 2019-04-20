using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DashboardWin.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Internal;
using QuanLySanXuat.Avery_Dennison;
using QuanLySanXuat.Control;

namespace QuanLySanXuat
{
    public partial class frmChiTietDonHangTemVaiAvery : DevExpress.XtraEditors.XtraForm
    {
        public TemDanADCtr TdCtr = new TemDanADCtr();
        public ThongTinGopDonADCtr ThongTin = new ThongTinGopDonADCtr();
        public frmChiTietDonHangTemVaiAvery()
        {
            InitializeComponent();
        }

        private void frmChiTietDonHangTemVaiAvery_Load(object sender, EventArgs e)
        {
            Ngayxuongdontxt.DateTime = DateTime.Today;
            Ngayxuongdontxt_EditValueChanged(sender,e);
        }

        private void Ngayxuongdontxt_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            //var lst2 = (from s in db.tbTemDanAds where s.OrderDate == Ngayxuongdontxt.DateTime select new {s.IDTemDanAD,s.SO,s.QTY}).Distinct().ToList();
            //var lst = (from s in db.tbTemDanAds from a in db.tbDonSanXuats where s.IDTemDanAD == a.SCD && (a.KichThuoc == "33*67" || a.KichThuoc == "33*134")&&  s.OrderDate == Ngayxuongdontxt.DateTime select new { s.IDTemDanAD,a.MaDonHang ,s.SO,a.KichThuoc }).Distinct().ToList();
            var lst = (from s in db.tbTemDanAds  where s.OrderDate == Ngayxuongdontxt.DateTime select  s.SO.Substring(0,8)).Distinct().ToList();
            SearchSO.Properties.DataSource = lst;
            SearchSO.Properties.ValueMember = "SO";
            SearchSO.Properties.DisplayMember = "SO";
        }

        private void SearchSO_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var SO = SearchSO.Text;

            var lst = from AD in (
                    (from tb in db.tbTemDanAds
                        group tb by new { tb.IDTemDanAD, tb.SO, tb.Size, tb.OrderDate, tb.XacNhan }
                        into g
                        select new
                        {
                            g.Key.IDTemDanAD,
                            g.Key.SO,
                            g.Key.Size,
                            g.Key.OrderDate,
                            QTY = (int?)g.Sum(p => Convert.ToInt32(p.QTY)),
                            g.Key.XacNhan
                        }))
                where
                    AD.OrderDate == Ngayxuongdontxt.DateTime &&
                    AD.SO.StartsWith(SO)
                select AD;

            gridControl1.DataSource = lst;//TdCtr.GetData_NgayXuongDon_SO(Ngayxuongdontxt.Text, SO);
            gridView1.BestFitColumns();
            
            var lst2 = (from s in db.tbThongTinGopDonADs where s.SO.StartsWith(SO) select s).ToList();
            gridControl2.DataSource = lst2;
        }


        private void btnTinh_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var _OrderDate = new DateTime();
            try
            {
                var Soluongtong = 0;
                gridView1.BeginUpdate();
                string _SO = null;
                string Madonhang = null, SCD = null, SIZE = null, Soluongchitiet = null;
                string SoXacnhan = null;
                for (var i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    string xacnhan = null, _Size = null;
                    try{xacnhan = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colXacNhan).ToString();}catch{ }               
                    _SO = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colso).ToString();
                    _OrderDate =
                        Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colOrderDate));
                    var _IDTemDanAD = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colIDTemDanAD)
                        .ToString();
                    try { _Size = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colSize).ToString(); } catch { }
                    
                    var _Qty = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colQTY).ToString();
                    if (!string.IsNullOrEmpty(xacnhan))
                    {
                        SoXacnhan = SoXacnhan + _SO + " , ";
                    }

                    var dsx = (from s in db.tbDonSanXuats where s.SCD == _IDTemDanAD select s).ToList();
                    foreach (var dsxItem in dsx)
                    {
                        SCD = SCD + dsxItem.SCD + " , " + Environment.NewLine;
                        Madonhang = Madonhang + dsxItem.MaDonHang + " , " + Environment.NewLine;
                    }

                    if (string.IsNullOrEmpty(_Size))
                    {
                        SIZE = SIZE + _SO + " , " + Environment.NewLine;
                        Soluongchitiet = Soluongchitiet + _SO + " ( " + _Qty + " pcs ) " + " , " +
                                         Environment.NewLine;
                        var lst1 = (from s in db.tbTemDanAds where s.SO == _SO select s).ToList();
                        foreach (var item in lst1)
                        {
                            item.XacNhan = "1";
                        }
                    }
                    else
                    {
                        SIZE = SIZE + _SO + "_" + _Size + " , " + Environment.NewLine;
                        Soluongchitiet = Soluongchitiet + _SO + "_" + _Size + " ( " + _Qty +
                                         " pcs )" + " , " + Environment.NewLine;
                        var lst2 = (from s in db.tbTemDanAds
                            where s.SO == _SO && s.Size == _Size
                            select s).ToList();
                        foreach (var item in lst2)
                        {
                            item.XacNhan = "1";
                        }
                    }

                    Soluongtong = Soluongtong + Convert.ToInt32(_Qty);

                }

                if (SoXacnhan == null)
                {
                    var thongtin = new tbThongTinGopDonAD();
                    if (_SO != null) thongtin.SO = _SO.Split('-')[0];
                    thongtin.NgayXuongDon = _OrderDate;
                    thongtin.DonGop = SIZE;
                    thongtin.SoLuongDonGop = Soluongchitiet;
                    thongtin.TongSoLuong = Soluongtong;
                    thongtin.SCD = SCD;
                    thongtin.MaDonHang = Madonhang;
                    db.tbThongTinGopDonADs.InsertOnSubmit(thongtin);
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Mã SO: " + SoXacnhan +" đã xác nhận rồi , nên không gộp đơn được");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);

                // ignored
            }
            finally
            {
                gridView1.EndUpdate();
                MessageBox.Show(PrintRibbon.capnhat);
                SearchSO_EditValueChanged(sender, e);
            }
        }


        private void btnIn_Click(object sender, EventArgs e)
        {
            var rp = new rpThongTinGopDonAD();
            rp.DataSource = ThongTin.GetData_NgayXuongDon_SO(Ngayxuongdontxt.Text, SearchSO.Text);
            rp.databing();
            rp.DataMember = "table";
            rp.ShowRibbonPreview();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var stt = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colSTT2);
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbThongTinGopDonADs where s.STT == Convert.ToInt32(stt) select s).Single();
            db.tbThongTinGopDonADs.DeleteOnSubmit(lst);
            db.SubmitChanges();
            MessageBox.Show(PrintRibbon.xoathanhcong);
            var sldongop = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colDonGop);
            var sl = sldongop.ToString().Replace("\r\n","").Split(',').Length ;
            string so = null;
            string size = null;
            var thongtin = sldongop.ToString().Replace("\r\n","").Split(',');
            for (int i = 0; i < Convert.ToInt32(sl) - 1; i++)
            {

                if (thongtin[i].Trim().Contains('_'))
                {
                    so = thongtin[i].Trim().Split('_')[0];
                    size = thongtin[i].Trim().Split('_')[1];
                    var lst2 = (from s in db.tbTemDanAds where s.SO == so && s.Size == size select s).ToList();
                    foreach (var item in lst2)
                    {
                        item.XacNhan = string.Empty;
                        db.SubmitChanges();
                    }
                }
                else
                {
                    so = thongtin[i].Trim();
                    var lst2 = (from s in db.tbTemDanAds where s.SO == so select s).ToList();
                    foreach (var item in lst2)
                    {
                        item.XacNhan = string.Empty;
                        db.SubmitChanges();
                    }
                }

            }
            SearchSO_EditValueChanged(sender,e);
        }

        //public void backup()
        //{
        //    // Create an empty list.
        //    var rows = new ArrayList();
        //    // Add the selected rows to the list.
        //    for (var i = 0; i < gridView1.SelectedRowsCount; i++)
        //    {
        //        if (gridView1.GetSelectedRows()[i] >= 0)
        //            rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
        //    }

        //    if ((Convert.ToInt32(rows.Count) <= 0)) return;
        //    string SO = null, SCD = null, SIZE = null, Soluongchitiet = null, Madonhang = null;
        //    try
        //    {
        //        var OrderDate = new DateTime();
        //        var Soluongtong = 0;
        //        gridView1.BeginUpdate();
        //        var db = new MyDBContextDataContext();
        //        foreach (var t in rows)
        //        {
        //            //var xn = nvObj.Tennhanvien + " " + DateTime.Now;
        //            // Change the field value.
        //            if (!(t is DataRow row)) continue;
        //            SO = row["SO"].ToString();
        //            //var _SO = row["SO"].ToString();
        //            //var _Size = row["Size"].ToString();
        //            OrderDate = (DateTime)row["OrderDate"];

        //            var dsx = (from s in db.tbDonSanXuats where s.SCD == row["IDTemDanAD"].ToString() select s).ToList();
        //            foreach (var dsxItem in dsx)
        //            {
        //                SCD = SCD + dsxItem.SCD + " , " + Environment.NewLine;
        //                Madonhang = Madonhang + dsxItem.MaDonHang + " , " + Environment.NewLine;
        //            }

        //            if (string.IsNullOrEmpty(row["Size"].ToString()))
        //            {
        //                SIZE = SIZE + row["SO"] + " , " + Environment.NewLine;
        //                Soluongchitiet = Soluongchitiet + row["SO"] + " ( " + row["QTY"] + " pcs ) " + " , " + Environment.NewLine;
        //                var lst1 = (from s in db.tbTemDanAds where s.SO == row["SO"].ToString() select s).ToList();
        //                foreach (var item in lst1)
        //                {
        //                    item.XacNhan = "1";
        //                }
        //            }

        //            else
        //            {
        //                SIZE = SIZE + row["SO"] + "_" + row["Size"] + " , " + Environment.NewLine;
        //                Soluongchitiet = Soluongchitiet + row["SO"] + "_" + row["Size"] + " ( " + row["QTY"] + " pcs )" + " , " + Environment.NewLine;
        //                var lst2 = (from s in db.tbTemDanAds where s.SO == row["SO"].ToString() && s.Size == row["Size"].ToString() select s).ToList();
        //                foreach (var item in lst2)
        //                {
        //                    item.XacNhan = "1";
        //                }
        //            }
        //            //Soluongchitiet = Soluongchitiet  + row["QTY"] + " pcs " + " , " + Environment.NewLine;

        //            Soluongtong = Soluongtong + Convert.ToInt32(row["QTY"]);



        //        }
        //        //var db = new MyDBContextDataContext();
        //        var thongtin = new tbThongTinGopDonAD();
        //        if (SO != null) thongtin.SO = SO.Split('-')[0];
        //        thongtin.NgayXuongDon = OrderDate;
        //        thongtin.DonGop = SIZE;
        //        thongtin.SoLuongDonGop = Soluongchitiet;
        //        thongtin.TongSoLuong = Soluongtong;
        //        thongtin.SCD = SCD;
        //        thongtin.MaDonHang = Madonhang;
        //        db.tbThongTinGopDonADs.InsertOnSubmit(thongtin);
        //        db.SubmitChanges();


        //    }
        //    catch
        //    {
        //        // ignored
        //    }
        //    finally
        //    {
        //        gridView1.EndUpdate();
        //        MessageBox.Show(PrintRibbon.capnhat);
        //        //Ngayxuongdontxt_EditValueChanged(sender, e);
        //        SearchSO_EditValueChanged(sender, e);
        //    }
        //}

    }
}