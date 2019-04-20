using System;
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

namespace QuanLySanXuat
{
    public partial class frmXem : DevExpress.XtraEditors.XtraForm
    {
        private string scd;
        public frmXem(string _scd)
        {
            InitializeComponent();
            scd = _scd;
        }

        private void frmXem_Load(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbTemDanAds where s.IDTemDanAD == scd select s).ToList();
            gridControl1.DataSource = lst;
        }
    }
}