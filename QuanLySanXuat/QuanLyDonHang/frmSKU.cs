using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;

namespace QuanLySanXuat
{
    public partial class frmSKU : DevExpress.XtraEditors.XtraForm
    {
        public delegate void GetString(string sku);
        public GetString MySKU;
        public frmSKU()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var _sku = spinEdit1.Text;
            MySKU(_sku);
            Close();
        }

        private void frmSKU_Load(object sender, EventArgs e)
        {

        }
    }
}