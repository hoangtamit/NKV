using System;
using System.Linq;
using System.Windows.Forms;
using QuanLySanXuat.Control;

namespace QuanLySanXuat.Kho
{
    public partial class frmCapNhatKhoNVL : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatKhoNVL()
        {
            InitializeComponent();
        }

        private void frmCapNhatKhoNVL_Load(object sender, EventArgs e)
        {
            //// Bảng Vật Liệu
            var vlCtr = new VatLieuCtr();
            maHangTextEdit.Properties.DataSource = vlCtr.LoadData4C();
            maHangTextEdit.Properties.DisplayMember = "MaHang";
            maHangTextEdit.Properties.ValueMember = "MaHang";
        }

        private void maHangTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbVatLieus.Single(s => s.MaHang == maHangTextEdit.Text);
            textEdit1.Text = lst.MaAvery;
            textEdit3.Text = lst.TenHangHoa;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var tong =0;
            var db = new MyDBContextDataContext();
            var lst = db.tbKhoNLVs.ToList();
            foreach (var itemKhoNlv in lst)
            {
                if (itemKhoNlv.MaHang == maHangTextEdit.Text)
                {

                    //itemKhoNlv.MaAD = textEdit1.Text;
                    itemKhoNlv.TenHangHoa = textEdit3.Text;
                    db.SubmitChanges();
                    tong = tong + 1;
                    
                }
            }
            MessageBox.Show(" cập nhật thành công " + maHangTextEdit.Text +" = " + tong);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbVatLieus.Single(s=>s.MaHang == maHangTextEdit.Text);
            //lst.MaAD = textEdit1.Text;
            lst.TenHangHoa = textEdit3.Text + " (" + lst.MaAvery + ")"  ;
            db.SubmitChanges();
        }
    }
}