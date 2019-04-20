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
using QuanLySanXuat.Control;

namespace QuanLySanXuat
{
    public partial class frmKhoGiayIn : DevExpress.XtraEditors.XtraForm
    {
        KhoGiayInCtr kgiCtr = new KhoGiayInCtr();
        private DataTable dt;
        public frmKhoGiayIn()
        {
            InitializeComponent();
        }

        private void frmKhoGiayIn_Load(object sender, EventArgs e)
        {
            dt = kgiCtr.LoadData();
            gridControl1.DataSource = dt;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            for (var i = 0; i <= gridView1.RowCount - 1; i++)
            {

                var dr = gridView1.GetDataRow(i);
                if (dr.RowState == DataRowState.Added)
                {
                    if (XtraMessageBox.Show("Bạn có muốn thêm không", "Cảnh báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var db = new MyDBContextDataContext();
                        var tb = new tbKhoGiayIn();
                        tb.KhoIn = dr["KhoIn"].ToString();
                        tb.CatGiay = dr["CatGiay"].ToString();
                        //if(dr["GiayLon"].ToString() != null)
                        tb.GiayLon = dr["GiayLon"].ToString();
                        db.tbKhoGiayIns.InsertOnSubmit(tb);
                        db.SubmitChanges();
                        MessageBox.Show(PrintRibbon.themthanhcong);
                        frmKhoGiayIn_Load(sender, e);
                    }
                    else
                    {
                        frmKhoGiayIn_Load(sender, e);
                    }
                }
                if (dr.RowState == DataRowState.Modified)
                {
                    if (XtraMessageBox.Show("Bạn có muốn cập nhật không", "Cảnh báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var db = new MyDBContextDataContext();
                        var tb = db.tbKhoGiayIns.Single(s => s.ID == (int)dr["ID"]);
                        tb.KhoIn = dr["KhoIn"].ToString();
                        tb.CatGiay = dr["CatGiay"].ToString();
                        tb.GiayLon = dr["GiayLon"].ToString();
                        db.SubmitChanges();
                        MessageBox.Show(PrintRibbon.capnhat);
                        frmKhoGiayIn_Load(sender, e);

                    }
                    else
                    {
                        frmKhoGiayIn_Load(sender, e);
                    }
                }

            }
        }
    }
}