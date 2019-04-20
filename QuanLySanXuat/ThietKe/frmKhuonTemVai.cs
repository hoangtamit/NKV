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

namespace QuanLySanXuat
{
    public partial class frmKhuonTemVai : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuonTemVai()
        {
            InitializeComponent();
        }

        private void frmKhuonTemVai_Load(object sender, EventArgs e)
        {
            pictureEdit1.Image = Image.FromFile("Images/Khuon.jpg");
        }
    }
}