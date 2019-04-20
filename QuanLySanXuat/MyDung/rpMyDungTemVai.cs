using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QuanLySanXuat.MyDung
{
    public partial class rpMyDungTemVai : DevExpress.XtraReports.UI.XtraReport
    {
        public rpMyDungTemVai()
        {
            InitializeComponent();
        }

        public void databing()
        {
            xrItemCode.DataBindings.Add("Text", DataSource, "ItemCode");
            xrSoLuong.DataBindings.Add("Text", DataSource, "SoLuong");

        }

        private void xrItemCode_TextChanged(object sender, EventArgs e)
        {
//            try
//            {
//                var db = new MyDBContextDataContext();
//                var lst = (from s in db.tbMyDungTemVais where s.ItemCode == xrItemCode.Text select s).Single();
//                //var path = "Images/TemVai/" + lst.ItemCode + ".png";
//                xrImage.Image = Image.FromFile(lst.DuongDan);
//            }
//            catch (Exception)
//            {
//// null
//            }
        }

        private void xrItemCode_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrItemCode_EvaluateBinding(object sender, BindingEventArgs e)
        {

        }

        private void xrItemCode_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbMyDungTemVais where s.ItemCode == xrItemCode.Text select s).Single();
                //var path = "Images/TemVai/" + lst.ItemCode + ".png";
                xrImage.Image = Image.FromFile(lst.DuongDan);
            }
            catch (Exception)
            {
                // null
            }
        }
    }
}
