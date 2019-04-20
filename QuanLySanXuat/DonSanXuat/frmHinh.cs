using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace QuanLySanXuat.DonSanXuat
{
    public partial class frmHinh : XtraForm
    {
        public frmHinh()
        {
            InitializeComponent();

        }

        private string _hinhmatphai, _hinhmattrai, _hinhkhuon;

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmHinh_Load(object sender, EventArgs e)
        {
            var a = new[] { _hinhmatphai,_hinhmattrai,_hinhkhuon};
            foreach (var item in a)
            {
                if(item != null)
                    pictureEdit1.Image = Image.FromFile(item);}
        }

        public frmHinh( string hinhmatphai, string hinhmattrai, string hinhkhuon)
        {
            InitializeComponent();
            _hinhmatphai = hinhmatphai;
            _hinhmattrai = hinhmattrai;
            _hinhkhuon = hinhkhuon;
        }
    }
}