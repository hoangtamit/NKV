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
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;

namespace QuanLySanXuat
{
    public partial class frmDate : DevExpress.XtraEditors.XtraForm
    {
        public frmDate()
        {
            InitializeComponent();
        }
        public readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        private void dateNavigator1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(dateNavigator1.SelectionStart.ToString("yyyy-MM-dd"));
            var dt = dsxCtr.LoadData_DonSanXuat_NgayXuongDon(dateNavigator1.SelectionStart.ToString("yyyy-MM-dd"));
            var rp = new rptDonSanXuat_Avery { DataSource = dt };
            rp.databing();
            rp.ShowRibbonPreviewDialog();
        }
    }
}