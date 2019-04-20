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
using System.Diagnostics;
using DevExpress.CodeParser;
using DevExpress.XtraSplashScreen;
using Illustrator;

namespace QuanLySanXuat
{
    public partial class frmtest : DevExpress.XtraEditors.XtraForm
    {
        public frmtest()
        {
            InitializeComponent();
        }

        private Control.DonSanXuatCtr dsxCtr = new Control.DonSanXuatCtr();
        private void frmtest_Load(object sender, EventArgs e)
        {
            //var db = new MyDBContextDataContext();
            //var ngay = "17/01/2019";
            //var temvai = (from s in db.DonSanXuat_LanhLieu_View() where
            //              s.NgayXuongDon == Convert.ToDateTime(ngay) && 
            //              s.TenKhachHang == PrintRibbon.AD &&
            //              s.BoPhan == PrintRibbon.temvai && 
            //              s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" &&
            //              s.Khac != "SKU 1" && s.Khac != null
            //              select s).ToList();
            //gridControl1.DataSource = temvai;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //var scd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSCD).ToString();
            //var db = new MyDBContextDataContext();
            //var ngay = "17/01/2019";
            //var temvai = (from s in db.DonSanXuat_LanhLieu_View()
            //              where
            //                s.NgayXuongDon == Convert.ToDateTime(ngay) &&
            //                s.TenKhachHang == PrintRibbon.AD &&
            //                s.BoPhan == PrintRibbon.temvai &&
            //                s.PhuongPhapIn == "Máy in Tem Vải (In Mềm)" &&
            //                s.Khac != "SKU 1" && s.Khac != null &&
            //                s.SCD == scd
            //              select s).ToList();
            //foreach (var item in temvai)
            //{
            //    var tblanhlieu = db.tbLanhLieus.ToList();
            //    foreach (var lanhlieu in tblanhlieu)
            //    {
            //        if (item.SCD != lanhlieu.IDLanhLieu) continue;
            //        //var _so = db.TemDanAD_GroupBy_SO(item.SCD).ToList();
            //        //foreach (var so in _so)
            //        //{
            //            var _Size = db.TemDanAD_GroupBy_Size(item.SCD).ToList();
            //            gridControl2.DataSource = _Size;
            //        //gridControl3.DataSource = _so;
            //        foreach (var size in _Size)
            //        {
            //            //var tinh = (lanhlieu.SoLuongSanXuat * lanhlieu.BuHao + (int)txtChoThem.Value) * Convert.ToDouble(kichthuoc[1]) * 1.09 / 1000;
            //            //if (tinh != null)
            //            //{
            //            //    if (item.SoLuong < 500)
            //            //        lanhlieu.LanhLieu = (int)tinh + 5;
            //            //    else
            //            //        lanhlieu.LanhLieu = (int)tinh;
            //            //}
            //        }
            //        //}
            //    }
            //}

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Process notePad = new Process();

            //notePad.StartInfo.FileName = "C:\\Program Files\\Adobe\\Adobe Illustrator CC 2019\\Support Files\\Contents\\Windows\\Illustrator.exe";//thay cai nay bang duong dan  toi file exe cua ban 
            //notePad.StartInfo.Arguments = "Z:\\IMG_20190102_0002.pdf"; 
            //notePad.Start();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //int tong = 0;
            //var db = new MyDBContextDataContext();
            //var dsx = (from s in db.tbDonSanXuats where s.Khac != "" && s.BoPhan == "TEM VẢI" select s).ToList();
            //foreach (var item in dsx)
            //{
            //    var a = item.Khac.Split(' ');
            //    if (Convert.ToInt32(a[1]) <= 0) continue;
            //    item.SKU = Convert.ToInt32(a[1]);
            //    tong = tong + 1;
            //}
            //db.SubmitChanges();
            //MessageBox.Show(tong.ToString());


            //int tong = 0;
            //var db = new MyDBContextDataContext();
            //var dsx = (from s in db.tbDonSanXuats where s.LoaiChi != "" && s.BoPhan == "TEM VẢI" select s).ToList();
            //foreach (var item in dsx)
            //{
            //    try
            //    {
            //        if (Convert.ToInt32(item.LoaiChi) <= 0) continue;
            //        item.STT = Convert.ToInt32(item.LoaiChi);
            //        tong = tong + 1;
            //    }
            //    catch (Exception)
            //    {
            //    }

            //}
            //db.SubmitChanges();
            //MessageBox.Show(tong.ToString());
        }
    }
}