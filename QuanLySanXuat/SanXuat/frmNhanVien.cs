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
using DevExpress.XtraEditors.Controls;
using QuanLySanXuat.GraphicsEditor;
using QuanLySanXuat.Object;

namespace QuanLySanXuat
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public readonly NhanVienObj nvObj = new NhanVienObj();
        
        public frmNhanVien(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;

        }

        private void tbNhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            tbNhanVienGridControl.DataSource = db.tbNhanViens.ToList();
            var itemGraphicsEdit = new RepositoryItemGraphicsEdit
            {
                SizeMode = PictureSizeMode.Squeeze,
                BestFitWidth = 100

            };
            layoutView1.Columns["HinhNhanVien"].ColumnEdit = itemGraphicsEdit;
        }

        private void tbNhanVienGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}