using System;
using System.Linq;
using System.Windows.Forms;
using QuanLySanXuat.Control;

namespace QuanLySanXuat
{
    public partial class frmTemDan1SKU : DevExpress.XtraEditors.XtraForm
    {
        private readonly DonSanXuat_AveryCtr dsx_Avery = new DonSanXuat_AveryCtr();
        private readonly TemDanADCtr td_Avery = new TemDanADCtr();

        public frmTemDan1SKU()
        {
            InitializeComponent();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var dsx = (from s in db.tbDonSanXuat_Averies where s.OrderDate == dateEdit1.DateTime && s.SKU == 1 && s.scd != null select s).ToList();
            foreach (var item in dsx)
            {

                //var tdAD = db.tbTemDanAds.ToList();
                var tdAD = (from s in db.tbTemDanAds where s.OrderDate == dateEdit1.DateTime && s.SO == item.SO && s.IDTemDanAD == item.scd select s).ToList();
                if (tdAD.Count != 0) continue;
                var sli1 = (int)(Convert.ToInt32(item.Qty) / 500);
                var sli2 = Convert.ToInt32(item.Qty) - ((int)(Convert.ToInt32(item.Qty) / 500) * 500);
                for (int i = 0; i < sli1; i++)
                {
                    var temdanAd = new tbTemDanAd();
                    temdanAd.IDTemDanAD = item.scd;
                    temdanAd.SO = item.SO;
                    temdanAd.Size = null;
                    temdanAd.QTY = "500";
                    temdanAd.OrderDate = dateEdit1.DateTime;
                    db.tbTemDanAds.InsertOnSubmit(temdanAd);
                    db.SubmitChanges();
                }
                var temdanAd2 = new tbTemDanAd();
                temdanAd2.IDTemDanAD = item.scd;
                temdanAd2.SO = item.SO;
                temdanAd2.Size = null;
                temdanAd2.QTY = sli2.ToString();
                temdanAd2.OrderDate = dateEdit1.DateTime;
                db.tbTemDanAds.InsertOnSubmit(temdanAd2);
                var dsxAvery = (from s in db.tbDonSanXuat_Averies where s.SO == item.SO select s).Single();
                dsxAvery.XacNhan = 2;
                db.SubmitChanges();
            }
            MessageBox.Show(PrintRibbon.themthanhcong);
            dateEdit1_EditValueChanged(sender, e);
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridControl2.DataSource = dsx_Avery.GetData_OrderDate2(dateEdit1.Text);
            gridControl3.DataSource = td_Avery.GetData_OrderDate(dateEdit1.Text);
        }

        private void frmTemDan1SKU_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Today;
            dateEdit1_EditValueChanged(sender, e);
        }
    }
}