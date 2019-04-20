using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Object;

namespace QuanLySanXuat.MyDung
{
    public partial class rpMyDungSticker : DevExpress.XtraReports.UI.XtraReport
    {
        //private NhanVienObj nvObj;
        public rpMyDungSticker(NhanVienObj nvobj)
        {
            InitializeComponent();
            xrNgay.Text = DateTime.Today.ToString(CultureInfo.InvariantCulture);
            xrName.Text = nvobj.Tennhanvien;
        }

        public void Databing()
        {
            xrItemCode.DataBindings.Add("Text", DataSource, "ItemCode");
            xrItemCode2.DataBindings.Add("Text", DataSource, "ItemCode2");
            xrItemName.DataBindings.Add("Text", DataSource, "ItemName");
            xrJanCode.DataBindings.Add("Text", DataSource, "JanCode");
            xrLocation.DataBindings.Add("Text", DataSource, "Location");
            xrTana.DataBindings.Add("Text", DataSource, "Tana");
            xrSoLuong.DataBindings.Add("Text", DataSource, "SoLuong");
        }
    }


}
