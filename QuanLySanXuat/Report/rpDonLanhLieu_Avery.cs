using System;
namespace QuanLySanXuat
{
    public partial class rpDonLanhLieu_Avery : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDonLanhLieu_Avery()
        {
            InitializeComponent();
            xrTableCell13.Text = "1";
            //xrDonViTinh.Text = "YARD";
            lblNgay.Text = DateTime.Now.ToString("'NGÀY ' dd ' THÁNG ' MM ' NĂM ' yyyy");

        }

        public void databing()
        {
            xrIDLanhLieu.DataBindings.Add("Text", DataSource, "SCD");
            xrBoPhan.DataBindings.Add("Text", DataSource, "BoPhan");
            xrVatLieu.DataBindings.Add("Text", DataSource, "VatLieu");
            xrDonViTinh.DataBindings.Add("Text", DataSource, "DonViTinh");
            xrSoLuong.DataBindings.Add("Text", DataSource, "LanhLieu", "{0:#,#}");
            xrNo.DataBindings.Add("Text", DataSource, "STT");
        }

    }
}
