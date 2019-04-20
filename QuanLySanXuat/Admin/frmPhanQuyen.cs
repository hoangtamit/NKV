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
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        PhanQuyenCtr pqCtr = new PhanQuyenCtr();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = pqCtr.PhanQuyen();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                for (var i = 0; i <= gridView1.RowCount - 1; i++)
                {
                    var dr = gridView1.GetDataRow(i);
                    var db = new MyDBContextDataContext();
                    var tb = (from s in db.tbPhanQuyens where s.MaNhanVien == dr["MaNhanVien"].ToString() select s).Single();
                    tb.NghiepVu = dr["NghiepVu"].ToString();
                    tb.ThietKe = dr["ThietKe"].ToString();
                    tb.CTP = dr["CTP"].ToString();
                    tb.CTF = dr["CTF"].ToString();
                    tb.Offset = dr["Offset"].ToString();
                    tb.TemVai = dr["TemVai"].ToString();
                    tb.SauIn = dr["SauIn"].ToString();
                    tb.KiemPham = dr["KiemPham"].ToString();
                    tb.KhoNVL = dr["KhoNVL"].ToString();
                    tb.KhoBTP = dr["KhoBTP"].ToString();
                    tb.QuanLyChatLuong = dr["QuanLyChatLuong"].ToString();
                    tb.QuanLySanXuat = dr["QuanLySanXuat"].ToString();
                    tb.DanhThiep = dr["DanhThiep"].ToString();
                    tb.KyThuatSo = dr["KyThuatSo"].ToString();
                    tb.InChuViTinh = dr["InChuViTinh"].ToString();
                    tb.Sticker = dr["Sticker"].ToString();
                    db.SubmitChanges();
                }
                frmPhanQuyen_Load(sender, e);
                MessageBox.Show(PrintRibbon.capnhat);
            }
            catch { }
        }


    }
}