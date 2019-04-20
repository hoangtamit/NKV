using System;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmTyGiaNgoaiTe : XtraForm
    {
        public frmTyGiaNgoaiTe()
        {
            InitializeComponent();
        }

        private void frmTyGiaNgoaiTe_Load(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("https://www.vietcombank.com.vn/exchangerates/ExrateXML.aspx");

            XmlNodeList noXml;
            noXml = xml.SelectNodes("/ExrateList/Exrate");
            int i = 0;
            for (i = 0; i <= noXml.Count - 1; i++)
            {
                ListViewItem item = new ListViewItem
                                 (noXml.Item(i).Attributes["CurrencyCode"].InnerText);
                item.SubItems.Add(noXml.Item(i).Attributes["CurrencyName"].InnerText);
                item.SubItems.Add(noXml.Item(i).Attributes["Buy"].InnerText);
                item.SubItems.Add(noXml.Item(i).Attributes["Transfer"].InnerText);
                item.SubItems.Add(noXml.Item(i).Attributes["Sell"].InnerText);
                listView1.Items.Add(item);


            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listView1.Refresh();
            //frmTyGiaNgoaiTe_Load(sender, e);
        }
    }
}