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
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.DonSanXuat;

namespace QuanLySanXuat
{
    public partial class frmDonHang : XtraForm
    {
        #region SoThuTu
        public frmDonHang()
        {
            InitializeComponent();
            Load += frmDonHang_Load;
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); }));
            }
        }

        #endregion

        private void tbDonSanXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_TienTe_View() where s.KetChuyen == "1" select s).ToList();
            foreach (var item in lst)
            {
                if (item.VAT == 1.1)
                    item.VAT = 1.1;
            }
            tbDonSanXuatGridControl.DataSource = lst;
        }

        private void tbDonSanXuatGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                MyDBContextDataContext db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
                try
                { ptbHinhMatPhai.Image = Image.FromFile(lst.HinhMatPhai); }
                catch
                { ptbHinhMatPhai.Image = null; }

                try
                { ptbHinhMatTrai.Image = Image.FromFile(lst.HinhMatTrai); }
                catch
                { ptbHinhMatTrai.Image = null; }

                try
                { ptbHinhKhuon.Image = Image.FromFile(lst.HinhKhuon); }
                catch
                { ptbHinhKhuon.Image = null; }
            }
            catch { }
        }

        private void ptbHinhMatPhai_Click(object sender, EventArgs e)
        {
           
            try
            {
                MyDBContextDataContext db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();

                frmHinh frm = new frmHinh();
                if (lst.HinhMatPhai != null)
                {
                    frm.BackgroundImage = Image.FromFile(lst.HinhMatPhai);
                    frm.BackgroundImageLayout = ImageLayout.Stretch;
                    frm.Show();
                }
            }
            catch { }
        }

        private void ptbHinhMatTrai_Click(object sender, EventArgs e)
        {
           
            try
            {
                MyDBContextDataContext db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
                frmHinh frm = new frmHinh();
                if (lst.HinhMatTrai != null)
                {
                    frm.BackgroundImage = Image.FromFile(lst.HinhMatTrai);
                    frm.BackgroundImageLayout = ImageLayout.Stretch;
                    frm.Show();
                }
            }
            catch { }
        }

        private void ptbHinhKhuon_Click(object sender, EventArgs e)
        {
           
            try
            {
                MyDBContextDataContext db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == sCDLabel1.Text select s).Single();
                frmHinh frm = new frmHinh();
                if (lst.HinhKhuon != null)
                {
                    frm.BackgroundImage = Image.FromFile(lst.HinhKhuon);
                    frm.BackgroundImageLayout = ImageLayout.Stretch;
                    frm.Show();
                }
            }
            catch { }
        }
    }
}