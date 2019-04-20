using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySanXuat.Test
{
    public partial class frmForeachControl : DevExpress.XtraEditors.XtraForm
    {
        public frmForeachControl()
        {
            InitializeComponent();
        }

        private void frmForeachControl_Load(object sender, EventArgs e)
        {

            var db = new MyDBContextDataContext();
            var lst = db.tbDonSanXuats;
            gridControl1.DataSource = lst;
            //gridView1.ShowLoadingPanel();
            //progressPanel1.sta

            

            //var lst = db.
            //gridControl1.DataSource = lst;//TdCtr.GetData_NgayXuongDon_SO(Ngayxuongdontxt.Text, SO);

            //" SELECT * from(SELECT IDTemDanAD,SO,Size ,OrderDate,SUM(CONVERT(int,QTY)) AS QTY,XacNhan
            //FROM dbo.tbTemDanAd GROUP BY IDTemDanAD,so,Size,OrderDate,XacNhan) AS AD
            //WHERE ad.OrderDate = '" + strlenh1+"' AND ad.SO LIKE '"+strlenh2+"%'"

            //foreach (System.Windows.Forms.Control control in Controls)
            //{
            //    //foreach (System.Windows.Forms.Control c in control)
            //    //{

            //    //}
            //    if (control.GetType() == typeof(TextBox))
            //    {
            //        control.Text = "123";
            //        control.BackColor = Color.Aqua;
            //    }
            //    if (control.GetType() == typeof(TextEdit))
            //    {
            //        control.Text = "456";
            //        control.BackColor = Color.Red;
            //    }
            //    if (control.GetType() == typeof(SpinEdit))
            //    {
            //        control.Text = "789";
            //        control.BackColor = Color.DeepSkyBlue;
            //    }
            //    if (control.GetType() == typeof(TextBox))
            //    {
            //        control.Text = "111";
            //        control.BackColor = Color.Yellow;
            //    }

            //    //    if (control.GetType() == typeof(LayoutControl))
            //    //    {
            //    //        control.BackColor = Color.Orange;
            //    //    }
            //    //}
            //    //ClearTextBoxes(frmTemDanAD.ActiveForm);

            //    //for (int i = 1; i < 60; i++)
            //    //{
            //    //    TextBox btn = new TextBox();
            //    //    btn.Name = "textBox" + i;
            //    //    btn.Text = "123456";
            //    //    this.Controls.Add(btn);
            //    //    Controls.
            //    //}



            //}
        }

        public void ClearTextBoxes(Form frm)
        {
            foreach (System.Windows.Forms.Control control in frm.Controls)
            {
                MessageBox.Show(Controls.GetType().ToString());
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(TextEdit))
                {
                    control.Text = "123";
                    control.BackColor = Color.Aqua;
                }
            }
        }

        private void SearchSO_EditValueChanged(object sender, EventArgs e)
        {
            //var db = new MyDBContextDataContext();
            //var SO = SearchSO.Text;

            //var lst = from s in (
            //         from x in db.tbTemDanAds
            //         group x by new { x.IDTemDanAD, x.OrderDate, x.SO, x.Size, x.XacNhan }
            //         into g
            //         select new
            //         {
            //             g.Key.IDTemDanAD,
            //             g.Key.OrderDate,
            //             g.Key.SO,
            //             g.Key.Size,
            //             QTY = (int?)g.Sum(p => Convert.ToInt32(p.QTY)),
            //             g.Key.XacNhan
            //         }) //QTY = (int?)g.Sum(p => Convert.ToInt32(p.QTY)),
            //           where s.OrderDate == Ngayxuongdontxt.DateTime && s.SO.StartsWith(SO)
            //           select s;
            //gridControl1.DataSource = lst;
            //var lst2 = (from s in db.tbThongTinGopDonADs where s.SO.StartsWith(SO) select s).ToList();
            //gridControl2.DataSource = lst2;
        }

        private void Ngayxuongdontxt_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            //var lst2 = (from s in db.tbTemDanAds where s.OrderDate == Ngayxuongdontxt.DateTime select new {s.IDTemDanAD,s.SO,s.QTY}).Distinct().ToList();
            //var lst = (from s in db.tbTemDanAds from a in db.tbDonSanXuats where s.IDTemDanAD == a.SCD && (a.KichThuoc == "33*67" || a.KichThuoc == "33*134")&&  s.OrderDate == Ngayxuongdontxt.DateTime select new { s.IDTemDanAD,a.MaDonHang ,s.SO,a.KichThuoc }).Distinct().ToList();
            var lst = (from s in db.tbTemDanAds where s.OrderDate == Ngayxuongdontxt.DateTime select s.SO.Substring(0, 8)).Distinct().ToList();
            SearchSO.Properties.DataSource = lst;
            SearchSO.Properties.ValueMember = "SO";
            SearchSO.Properties.DisplayMember = "SO";
        }
    }
}