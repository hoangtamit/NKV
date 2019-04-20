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
    public partial class frmCongThucAvery : DevExpress.XtraEditors.XtraForm
    {
        private BuHaoCtr bhCtr = new BuHaoCtr();
        public frmCongThucAvery()
        {
            InitializeComponent();
        }

        private void frmCongThucAvery_Load(object sender, EventArgs e)
        {
            MauSacSearch.Properties.DataSource = bhCtr.LoadData_BuHao();
            MauSacSearch.Properties.ValueMember = "MauSac";
            MauSacSearch.Properties.DisplayMember = "MauSac";

        }

        private void MauSacSearch_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbBuHaos where s.MauSac == MauSacSearch.Text select s).Single();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var MQ = 0;
            var XB = 1;
            var tong = 0;
            var Sheet = SoLuongTxt.Value / SoLuongDanTrangTxt.Value;
            if (Sheet <= 500)
                MQ = 3;
            else if (Sheet > 500 && Sheet <= 2000)
                MQ = 7;
            else if (Sheet > 2000 && Sheet <= 5000)
                MQ = 20;
            else
                MQ = 20;

            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbBuHaos where s.MauSac == MauSacSearch.Text select s).Single();
            var TotalImpress = Convert.ToInt32(lst.MauSac.Substring(8, 1).ToString()) * Sheet;
            var QualityCheck = TotalImpress / 300;
            var CleanRoller = (TotalImpress - 2000) / 2000 * 5;
            tong = (int)lst.BuHaoOffsetAvery.Value + ((int)SoLuongSizeTxt.Value - 1) * (int)lst.LotScrap + (int)QualityCheck + (int)CleanRoller;
            MessageBox.Show(tong.ToString());
            Tongtxt.Text = (tong + MQ + XB).ToString();
        }
    }
}