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

namespace QuanLySanXuat.Test
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        private string SCD;
        string so, scd, sku, qty;
        public int tsl = 0;
        DateTime orderdate;

        private void gridControl2_Click(object sender, EventArgs e)
        {
            try
            {
                //ClearSoLanIn();
                //ClearSoLuong();
                var db = new MyDBContextDataContext();
                scd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSCD1).ToString();
                so = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSO).ToString();
                sku = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSKU).ToString();
                qty = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colQty).ToString();
                orderdate = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colOrderDate).ToString());
                var tdAD = (from s in db.tbTemDanAds where s.IDTemDanAD == SCD && s.SO == so select s).ToList();
                if (tdAD.Count == 0)
                    btnTinh.Enabled = true;
                else
                    btnTinh.Enabled = false;
            }
            catch
            {
                // ignored
            }
        }

        public XtraForm1(string scd)
        {
            SCD = scd;
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                int tong = 0;
                var db = new MyDBContextDataContext();
                var soluong = Convert.ToInt32(gridView1.GetRowCellValue(i, colSoLuong)); // sl = 2300  //2000   //300
                var solanin = Convert.ToInt32(gridView1.GetRowCellValue(i, colSoLanIn));
                var size = gridView1.GetRowCellValue(i, colSize).ToString();
                var _solanin = Math.Ceiling((double) soluong / 500); // 5  // 4    //1
                var _sodu = soluong - (soluong / 500) * 500; // 300  // 0   // 0
                for (int j = 1; j <= _solanin; j++)
                {
                    tbTemDanAd tb = new tbTemDanAd();
                    tb.IDTemDanAD = scd;
                    tb.SO = so;
                    tb.Size = size;
                    if (i == _solanin && _sodu > 0 || soluong < 500 && _sodu == 0)
                        tb.QTY = _sodu.ToString();
                    else
                        tb.QTY = "500";
                    tb.OrderDate = orderdate;
                    db.tbTemDanAds.InsertOnSubmit(tb);
                }
                tong = tong + Convert.ToInt32(soluong) * solanin;
                if (tong == Convert.ToInt32(qty))
                {
                    db.SubmitChanges();
                }

            }
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            gridControl1.DataSource = db.tbBangTemDanADs;

        }
    }
}