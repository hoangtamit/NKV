using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using QuanLySanXuat.Class;

namespace QuanLySanXuat
{
    [SuppressMessage("ReSharper", "SpecifyACultureInStringConversionExplicitly")]
    public partial class frmGiay : DevExpress.XtraEditors.XtraForm
    {
        private int CanMang = 0;
        //public bool TinhXoGiay;
        private bool XogiayA, XogiayB;
        public  KichThuocGiay ktg = new KichThuocGiay();
        public string QuyCach_889_1194,QuyCach_787_1092,QuyCach_660_960,QuyCach_750_1000;


        public frmGiay()
        {
            InitializeComponent();
        }

        private void frmGiay_Load(object sender, EventArgs e)
        {
            Group_BoPhan_SelectedIndexChanged(sender,e);
            tinhxogiay();
        }

        public void tinhxogiay()
        {
            if (GroupTinhXoGiay.SelectedIndex == 0)
            {
                XogiayA = true;
                XogiayB = false;
            }
            else
            {
                XogiayA = false;
                XogiayB = true;
            }            
        }

        //public void kythuatso()
        //{
        //    Group_889_1194_2K.Visible = false;
        //    Group_889_1194_4K.Visible = false;
        //    Group_889_1194_5K.Visible = false;
        //    Group_889_1194_6K.Visible = false;
        //}

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (Group_BoPhan.SelectedIndex == 0)
            {
                CheckListKichThuoc.Items[0].CheckState = CheckState.Unchecked;
                CheckListKichThuoc.Items[1].CheckState = CheckState.Unchecked;
                CheckListKichThuoc.Items[2].CheckState = CheckState.Unchecked;
                CheckListKichThuoc.Items[3].CheckState = CheckState.Unchecked;
                QuyCachtxt.Text = string.Empty;
                var db = new MyDBContextDataContext();
                var lst = (from s in db.tbDonSanXuats where s.SCD == SearchSCD.Text select s).Single();
                var kt = lst.KichThuoc.Replace("MM", "").Split('*');
                txtChieudai.Value = Math.Ceiling(Convert.ToDecimal(kt[1]));
                txtChieurong.Value = Math.Ceiling(Convert.ToDecimal(kt[0]));
                ;
                VatLieu.Text = lst.VatLieu;
                var vatlieu = (from s in db.tbVatLieus where s.TenHangHoa == lst.VatLieu select s).ToList();
                foreach (var item in vatlieu)
                {
                    QuyCachtxt.Text = QuyCachtxt.Text + item.QuyCach + Environment.NewLine;
                    var quycach = item.QuyCach.Split('*');
                    if (Convert.ToInt32(quycach[1]) > Convert.ToInt32(quycach[0]))
                    {
                        if (Convert.ToInt32(quycach[0]) > 880 && Convert.ToInt32(quycach[0]) < 890 &&
                            Convert.ToInt32(quycach[1]) > 1190)
                        {
                            CheckListKichThuoc.Items[0].CheckState = CheckState.Checked;
                            Group_889_1194.Visible = true;
                            QuyCach_889_1194 = item.QuyCach;
                        }
                        else if (Convert.ToInt32(quycach[0]) > 780 && Convert.ToInt32(quycach[0]) < 790 &&
                                 Convert.ToInt32(quycach[1]) > 1090)
                        {
                            CheckListKichThuoc.Items[1].CheckState = CheckState.Checked;
                            //Group_787_1092.Visible = true;
                            QuyCach_787_1092 = item.QuyCach;
                        }

                        else if (Convert.ToInt32(quycach[0]) > 750 && Convert.ToInt32(quycach[0]) < 760 &&
                                 Convert.ToInt32(quycach[1]) > 1000)
                        {
                            CheckListKichThuoc.Items[2].CheckState = CheckState.Checked;
                            QuyCach_750_1000 = item.QuyCach;
                        }

                        else if (Convert.ToInt32(quycach[0]) >= 660 && Convert.ToInt32(quycach[0]) < 670 &&
                                 Convert.ToInt32(quycach[1]) > 960)
                        {
                            CheckListKichThuoc.Items[3].CheckState = CheckState.Checked;
                            QuyCach_660_960 = item.QuyCach;
                        }
                        else
                        {
                            KGI_Chieurong.Value = Convert.ToInt32(quycach[0]);
                            KGI_Chieudai.Value = Convert.ToInt32(quycach[1]);
                        }

                    }
                }
            }
            else if(Group_BoPhan.SelectedIndex == 1)
            {
                QuyCachtxt.Text = string.Empty;
                var db = new MyDBContextDataContext();
                var dsx = (from s in db.tbDonSanXuats where s.SCD == SearchSCD.Text select s).Single();
                var kt = dsx.KichThuoc.Replace("MM", "").Split('*');
                ChieuRong_Sticker.Value = Math.Ceiling(Convert.ToDecimal(kt[1]));
                Chieudai_Sticker.Value = Math.Ceiling(Convert.ToDecimal(kt[0]));
                
                VatLieu.Text = dsx.VatLieu;
                var vatlieu = (from s in db.tbVatLieus where s.TenHangHoa == dsx.VatLieu select s).ToList();
                foreach (var item in vatlieu)
                {
                    QuyCachtxt.Text = QuyCachtxt.Text + item.QuyCach + Environment.NewLine;
                }
            }

        }

        private void CheckListKichThuoc_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(checkedListBox1.SelectedItem.ToString());

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            var K4_889_1194 = "K4_440_595";
            var K9_889_1194 = "K9_293_396";
            var K4_787_1092 = "K4_390_540";
            var K9_787_1092 = "K9_260_360";
            var K4_660_960 = "K4_330_480";
            var K4_750_1000 = "K4_375_500";
            var K1_250_350 = "K1_250_350";
            var K1_TimX_TimY = "K1_" + TimX.Text + "_" + TimY.Text+ "_";
            var X2 = Math.Floor(KGI_Chieurong.Value / 2).ToString(CultureInfo.InvariantCulture);
            var X3 = Math.Floor(KGI_Chieurong.Value / 3).ToString(CultureInfo.InvariantCulture);
            var Y2 = Math.Floor(KGI_Chieudai.Value / 2).ToString(CultureInfo.InvariantCulture);
            var Y4 = Math.Floor(KGI_Chieudai.Value / 4).ToString(CultureInfo.InvariantCulture);
            var K4_X_Y = "K4_" + X2 + "_" + Y2 + "_";


            string[] KGI1 = { K4_889_1194, K9_889_1194, K4_787_1092, K9_787_1092, K4_660_960, K4_750_1000, K4_X_Y, K1_250_350, K1_TimX_TimY };
            foreach (var t in KGI1)
            {
                var K = Convert.ToInt32(t.Split('_')[0].Replace("K", ""));
                var slchieurong = txtChieurong.Value + KhoangCachtxt.Value;
                var slchieudai = txtChieudai.Value + KhoangCachtxt.Value;
                var _chieurong = ktg.ChieuRong((int) txtChieurong.Value,(int)txtChieudai.Value,(int)KhoangCachtxt.Value,(int)GHCR.Value,(int)GHCD.Value,CanMang,t,XogiayA);
                var _chieudai = ktg.ChieuDai((int)txtChieurong.Value, (int)txtChieudai.Value, (int)KhoangCachtxt.Value, (int)GHCR.Value, (int)GHCD.Value, CanMang, t, XogiayA);
                if (t == K4_889_1194)
                {
                    SLCR_440_595.Text = _chieurong.ToString();
                    SLCD_440_595.Text = _chieudai.ToString();
                    TONG_440_595.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCR_440_595.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_440_595.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_440_595.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_440_595.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if(t == K9_889_1194)
                {

                    SLCR_293_396.Text = _chieurong.ToString();
                    SLCD_293_396.Text = _chieudai.ToString();
                    TONG_293_396.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCR_293_396.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_293_396.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_293_396.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_293_396.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K4_787_1092)
                {
                    SLCR_390_540.Text = _chieurong.ToString();
                    SLCD_390_540.Text = _chieudai.ToString();
                    TONG_390_540.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCR_390_540.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_390_540.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_390_540.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_390_540.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K9_787_1092)
                {

                    SLCR_260_360.Text = _chieurong.ToString();
                    SLCD_260_360.Text = _chieudai.ToString();
                    TONG_260_360.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCR_260_360.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_260_360.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_260_360.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_260_360.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K4_660_960)
                {

                    SLCR_330_480.Text = _chieurong.ToString();
                    SLCD_330_480.Text = _chieudai.ToString();
                    TONG_330_480.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCR_330_480.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_330_480.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_330_480.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_330_480.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K4_750_1000)
                {

                    SLCR_375_500.Text = _chieurong.ToString();
                    SLCD_375_500.Text = _chieudai.ToString();
                    TONG_375_500.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCR_375_500.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_375_500.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_375_500.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_375_500.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K4_X_Y)
                {
                    SLCR_4K_X_Y.Text = _chieurong.ToString();
                    SLCD_4K_X_Y.Text = _chieudai.ToString();
                    TONG_4K_X_Y.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCR_4K_X_Y.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_4K_X_Y.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_4K_X_Y.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_4K_X_Y.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K1_250_350)
                {
                    SLCR_250_350.Text = _chieurong.ToString();
                    SLCD_250_350.Text = _chieudai.ToString();
                    TONG_250_350.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCR_250_350.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_250_350.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_250_350.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_250_350.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K1_TimX_TimY)
                {
                    SLCD_TimX_TimY.Text = _chieurong.ToString();
                    SLCR_TimX_TimY.Text = _chieudai.ToString();
                    TONG_TimX_TimY.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayA)
                    {
                        NCD_TimX_TimY.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCR_TimX_TimY.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCD_TimX_TimY.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCR_TimX_TimY.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }


            }

            var K6_889_1194 = "K6_396_440";
            var K8_889_1194 = "K8_297_440";
            var K10_889_1194 = "K10_238_440";
            var K6_787_1092 = "K6_360_390";
            var K8_787_1092 = "K8_270_390";
            var K2_660_960 = "K2_480_660";
            var K3_660_960 = "K3_330_660";
            var K2_750_1000 = "K2_500_750";
            var K6_750_1000 = "K6_330_350";
            var K8_750_1000 = "K8_250_350";

            var K2_X_Y = "K2_" + Y2 + "_" + KGI_Chieurong.Text + "_";
            var K6_X_Y = "K6_" + X3 + "_" + Y2 + "_";
            var K8_X_Y = "K8_" + Y4 + "_" + X2 + "_";


            string[] KGI2 = { K6_889_1194, K8_889_1194, K10_889_1194, K6_787_1092, K8_787_1092, K2_660_960, K3_660_960, K2_750_1000, K6_750_1000, K8_750_1000, K2_X_Y, K6_X_Y, K8_X_Y };
            foreach (var t in KGI2)
            {
                var K = Convert.ToInt32(t.Split('_')[0].Replace("K", ""));
                var slchieurong = txtChieurong.Value + KhoangCachtxt.Value;
                var slchieudai = txtChieudai.Value + KhoangCachtxt.Value;
                var _chieurong = ktg.ChieuRong((int)txtChieurong.Value, (int)txtChieudai.Value, (int)KhoangCachtxt.Value, (int)GHCR.Value, (int)GHCD.Value, CanMang, t, XogiayB);
                var _chieudai = ktg.ChieuDai((int)txtChieurong.Value, (int)txtChieudai.Value, (int)KhoangCachtxt.Value, (int)GHCR.Value, (int)GHCD.Value, CanMang, t, XogiayB);
                if (t == K6_889_1194)
                {
                    SLCR_396_440.Text = _chieurong.ToString();
                    SLCD_396_440.Text = _chieudai.ToString();
                    TONG_396_440.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_396_440.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_396_440.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_396_440.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_396_440.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K8_889_1194)
                {
                    SLCR_297_440.Text = _chieurong.ToString();
                    SLCD_297_440.Text = _chieudai.ToString();
                    TONG_297_440.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_297_440.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_297_440.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_297_440.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_297_440.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K10_889_1194)
                {
                    SLCR_238_440.Text = _chieurong.ToString();
                    SLCD_238_440.Text = _chieudai.ToString();
                    TONG_238_440.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_238_440.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_238_440.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_238_440.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_238_440.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K6_787_1092)
                {
                    SLCR_360_390.Text = _chieurong.ToString();
                    SLCD_360_390.Text = _chieudai.ToString();
                    TONG_360_390.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_360_390.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_360_390.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_360_390.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_360_390.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K8_787_1092)
                {
                    SLCR_270_390.Text = _chieurong.ToString();
                    SLCD_270_390.Text = _chieudai.ToString();
                    TONG_270_390.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_270_390.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_270_390.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_270_390.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_270_390.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K2_660_960)
                {
                    SLCR_480_660.Text = _chieurong.ToString();
                    SLCD_480_660.Text = _chieudai.ToString();
                    TONG_480_660.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_480_660.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_480_660.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_480_660.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_480_660.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K3_660_960)
                {
                    SLCR_330_660.Text = _chieurong.ToString();
                    SLCD_330_660.Text = _chieudai.ToString();
                    TONG_330_660.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_330_660.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_330_660.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_330_660.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_330_660.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K2_750_1000)
                {
                    SLCR_500_750.Text = _chieurong.ToString();
                    SLCD_500_750.Text = _chieudai.ToString();
                    TONG_500_750.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_500_750.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_500_750.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_500_750.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_500_750.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K6_750_1000)
                {
                    SLCR_250_500.Text = _chieurong.ToString();
                    SLCD_250_500.Text = _chieudai.ToString();
                    TONG_250_500.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_250_500.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_250_500.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_250_500.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_250_500.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K8_750_1000)
                {
                    SLCR_250_375.Text = _chieurong.ToString();
                    SLCD_250_375.Text = _chieudai.ToString();
                    TONG_250_375.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_250_375.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_250_375.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_250_375.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_250_375.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K2_X_Y)
                {
                    SLCR_2K_X_Y.Text = _chieurong.ToString();
                    SLCD_2K_X_Y.Text = _chieudai.ToString();
                    TONG_2K_X_Y.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_2K_X_Y.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_2K_X_Y.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_2K_X_Y.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_2K_X_Y.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K6_X_Y)
                {
                    SLCR_6K_X_Y.Text = _chieurong.ToString();
                    SLCD_6K_X_Y.Text = _chieudai.ToString();
                    TONG_6K_X_Y.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_6K_X_Y.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_6K_X_Y.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_6K_X_Y.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_6K_X_Y.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else if (t == K8_X_Y)
                {
                    SLCR_8K_X_Y.Text = _chieurong.ToString();
                    SLCD_8K_X_Y.Text = _chieudai.ToString();
                    TONG_8K_X_Y.Text = ktg.Tong(_chieurong, _chieudai, K).ToString();
                    if (XogiayB)
                    {
                        NCR_8K_X_Y.Text = (_chieurong * slchieurong).ToString(CultureInfo.InvariantCulture);
                        NCD_8K_X_Y.Text = (_chieudai * slchieudai).ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        NCR_8K_X_Y.Text = (_chieurong * slchieudai).ToString(CultureInfo.InvariantCulture);
                        NCD_8K_X_Y.Text = (_chieudai * slchieurong).ToString(CultureInfo.InvariantCulture);
                        
                    }
                }








            }
        }

        private void CheckListKichThuoc_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            Group_889_1194.Visible = CheckListKichThuoc.Items[0].CheckState == CheckState.Checked;
            Group_787_1092.Visible = CheckListKichThuoc.Items[1].CheckState == CheckState.Checked;
            Group_660_960.Visible = CheckListKichThuoc.Items[2].CheckState == CheckState.Checked;
            Group_750_1000.Visible = CheckListKichThuoc.Items[3].CheckState == CheckState.Checked;
            GroupDacbiet.Visible = CheckListKichThuoc.Items[4].CheckState == CheckState.Checked;
        }


        private void CheckListThongTin_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (CheckListThongTin.Items[0].CheckState == CheckState.Checked)
            {
                CheckListThongTin.Items[1].CheckState = CheckState.Unchecked;
                Group_889_1194_6K.Visible = false;
                Group_889_1194_8K.Visible = false;
                Group_889_1194_9K.Visible = false;
                Group_889_1194_10K.Visible = false;
                Group_787_1092_6K.Visible = false;
                Group_787_1092_8K.Visible = false;
                Group_787_1092_9K.Visible = false;
            }
            else
            {
                Group_889_1194_6K.Visible = true;
                Group_889_1194_8K.Visible = true;
                Group_889_1194_9K.Visible = true;
                Group_889_1194_10K.Visible = true;

                Group_787_1092_6K.Visible = true;
                Group_787_1092_8K.Visible = true;
                Group_787_1092_9K.Visible = true;
            }

            if (CheckListThongTin.Items[1].CheckState == CheckState.Checked)
            {
                CheckListThongTin.Items[0].CheckState = CheckState.Unchecked;
                //Group_889_1194_2K.Visible = false;
                Group_889_1194_4K.Visible = false;
                //Group_250_350_1K.Visible = false;
                Group_889_1194_6K.Visible = false;
                Group_787_1092_6K.Visible = false;
                Group_787_1092_4K.Visible = false;}
            else
            {
                //Group_889_1194_2K.Visible = true;
                Group_889_1194_4K.Visible = true;
                Group_250_350_1K.Visible = true;
                Group_889_1194_6K.Visible = true;

                Group_787_1092_6K.Visible = true;
                Group_787_1092_4K.Visible = true;
            }
            CanMang = CheckListThongTin.Items[2].CheckState == CheckState.Checked ? 5 : 0;
            btnTinh_Click(sender,e);
        }

        private void Group_BoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            object lst = null;
            if (Group_BoPhan.SelectedIndex == 0)
            {
                xtraTabRight.SelectedTabPage = TabRightOffset;
                xtraTabLeft.SelectedTabPage = TabLeftOffset;
                lst = from s in db.tbDonSanXuats
                    from a in db.tbQuanLyDonHangs
                    where s.SCD == a.IDQuanLyDonHang && a.HoanThanh == null && s.Kho == PrintRibbon.nguyenvatlieu &&
                          s.BoPhan == PrintRibbon.offset
                    select new{   s.SCD,
                        s.MaDonHang,
                        s.BoPhan,
                        s.KichThuoc,
                        s.VatLieu

                    };

            }
            else if(Group_BoPhan.SelectedIndex == 1)
            {
                xtraTabRight.SelectedTabPage = TabRightSticker;
                xtraTabLeft.SelectedTabPage = TabLeftSticker;
                lst = from s in db.tbDonSanXuats
                    from a in db.tbQuanLyDonHangs
                    where s.SCD == a.IDQuanLyDonHang && a.HoanThanh == null && s.Kho == PrintRibbon.nguyenvatlieu &&
                          s.BoPhan == PrintRibbon.sticker
                    select new
                    {
                        s.SCD,
                        s.MaDonHang,
                        s.BoPhan,
                        s.KichThuoc,
                        s.VatLieu

                    };
                var vatlieu = (from s in db.tbVatLieus where s.IDMaHang == "STICKER" select  new{s.TenHangHoa }).Distinct();
                SearchVatLieu.Properties.DataSource = vatlieu;
                SearchVatLieu.Properties.DisplayMember = "TenHangHoa";
                SearchVatLieu.Properties.ValueMember = "TenHangHoa";
               

            }
            else if (Group_BoPhan.SelectedIndex == 2)
            {
                xtraTabRight.SelectedTabPage = TabRightTemvai;
                xtraTabLeft.SelectedTabPage = TabLeftTemvai;
                lst = from s in db.tbDonSanXuats
                    from a in db.tbQuanLyDonHangs
                    where s.SCD == a.IDQuanLyDonHang && a.HoanThanh == null && s.Kho == PrintRibbon.nguyenvatlieu &&
                          s.BoPhan == PrintRibbon.temvai
                    select new
                    {
                        s.SCD,
                        s.MaDonHang,
                        s.BoPhan,
                        s.KichThuoc,
                        s.VatLieu};
            }
            SearchSCD.Properties.DataSource = lst;
            SearchSCD.Properties.DisplayMember = "SCD";
            SearchSCD.Properties.ValueMember = "SCD";
        }

        private void KGI_Chieudai_EditValueChanged(object sender, EventArgs e)
        {
            Group_X_Y.Visible = true;
            Group_X_Y.Text = KGI_Chieurong.Text + "*" + KGI_Chieudai.Text.Replace(",","").Replace(".","");
            var X2 = Math.Floor(KGI_Chieurong.Value / 2).ToString(CultureInfo.InvariantCulture);
            var X3 = Math.Floor(KGI_Chieurong.Value / 3).ToString(CultureInfo.InvariantCulture);
            var Y2 = Math.Floor(KGI_Chieudai.Value / 2).ToString(CultureInfo.InvariantCulture);
            var Y4 = Math.Floor(KGI_Chieudai.Value / 4).ToString(CultureInfo.InvariantCulture);
            KGI_4K_X_Y.Text = X2 + "*" + Y2;
            KGI_2K_X_Y.Text = Y2 + "*" + KGI_Chieurong.Text;
            KGI_6K_X_Y.Text = X3 + "*" + Y2;
            KGI_8K_X_Y.Text =  Y4 + "*" + X2;
        }

        private void TimY_Validated(object sender, EventArgs e)
        {
            KGI_1K_TimX_TimY.Text = TimX.Text + "*" + TimY.Text;
        }

        private void SearchMaHang_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var tungay = Convert.ToDateTime(GetFirstDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 00:00:00");
            var denngay = Convert.ToDateTime(GetLastDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 23:59:59");
            var tonkho = from s in db.LoadData_TonKhoNVL_View(tungay, denngay)
                where s.tenhanghoa == SearchVatLieu.Text && s.Kho == PrintRibbon.nguyenvatlieu && s.toncuoiky > 0 && s.donvitinh == "M"
                select new { s.mahang, s.tenhanghoa, s.donvitinh, s.quycach, s.toncuoiky };
            int tong = 0;
            foreach (var item in tonkho)
            {
                tong = tong + 1;
                QuyCach_Sticker.Text = QuyCach_Sticker.Text + item.quycach + Environment.NewLine;
                if(tong == 1)
                Group_Sticker_1.Text = item.quycach;
                else if (tong == 2)
                    Group_Sticker_2.Text = item.quycach;
                else if (tong == 3)
                    Group_Sticker_3.Text = item.quycach;
            }


            var lst =from s in db.LoadData_TonKhoNVL_View(tungay, denngay) where s.tenhanghoa == SearchVatLieu.Text && s.Kho == PrintRibbon.nguyenvatlieu && s.toncuoiky > 0 && s.donvitinh == "M"
                select new { s.mahang,s.tenhanghoa,s.donvitinh,s.quycach,s.toncuoiky};
            Gridcontrol_Sticker.DataSource = lst;


        }

        private void KGI_440_595_Click(object sender, EventArgs e)
        {           
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbLanhLieus where s.IDLanhLieu == SearchSCD.Text select s).Single();
            if (string.IsNullOrEmpty(lst.LanhLieu.ToString()))
            {
                if(MessageBox.Show("Bạn có muốn thêm không" ,"Cảnh Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)return;
                Group_889_1194_4K.BackColor = Color.LightSeaGreen;
                lst.KhoGiayIn = KGI_4K_440_595.Text;  // 440*595
                lst.CatGiay = KGI_4K_440_595.Name.Split('_')[1]; // 
                lst.QuyCach = QuyCach_889_1194;
                lst.SoLuongDanTrang = Convert.ToInt32(SLCD_440_595.Text) * Convert.ToInt32(SLCR_440_595.Text);
                db.SubmitChanges();
                MessageBox.Show("Thêm đơn hàng thành công");
            }
            else
            {
                MessageBox.Show("Đơn hàng này đã tính liệu rồi");
            }
        }

        private void KGI_396_440_Click(object sender, EventArgs e)
        {
            KGI_4K_440_595.BackColor = Color.Red;
        }

        private void KGI_390_540_Click(object sender, EventArgs e)
        {
            MessageBox.Show(QuyCach_787_1092);
        }

        private void GroupTinhXoGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmGiay_Load(sender,e);
            btnTinh_Click(sender,e);
        }

        private void btnTinh_Sticker_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < gridView_Sticker.RowCount; i++)
            //{
            //    var dr = gridView_Sticker.GetDataRow(i);
            //    var quycach = Convert.ToDecimal(dr["quycach"].ToString().Split('*')[0].Replace("MM", ""));
            //    var chieurong = Math.Floor(ChieuRong_Sticker.Value + Khoangcach_Sticker.Value);
            //    var chieudai = Math.Floor(Chieudai_Sticker.Value + Khoangcach_Sticker.Value);
            //    var slchieurong = 0;
            //    var slchieudai = 0;
            //    if (ChieuRong_Sticker.Value > quycach)
            //    {
            //        if (Math.Floor(quycach / chieurong) * chieurong + GHCR_Sticker.Value <= quycach)
            //            slchieurong = (int)Math.Floor(quycach / chieurong);
            //        else
            //        {
            //            slchieurong = (int)Math.Floor(quycach / chieurong) - 1;
            //        }
            //    }
            //    if (Chieudai_Sticker.Value > quycach)
            //    {
            //        if (Math.Floor(quycach / chieudai) * chieudai + GHCR_Sticker.Value <= quycach)
            //            slchieudai = (int)Math.Floor(quycach / chieudai);
            //        else
            //        {
            //            slchieudai = (int)Math.Floor(quycach / chieudai) - 1;
            //        }
            //    }
            //    dr["ChieuRong"] = slchieurong * chieurong;
            //    dr["ChieuDai"] = slchieudai * chieudai;
            //}

            var db = new MyDBContextDataContext();
            var tungay = Convert.ToDateTime(GetFirstDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 00:00:00");
            var denngay = Convert.ToDateTime(GetLastDayOfMonth(DateTime.Now).ToString("yyyy/MM/dd") + " 23:59:59");
            var tonkho = from s in db.LoadData_TonKhoNVL_View(tungay, denngay)
                where s.tenhanghoa == SearchVatLieu.Text && s.Kho == PrintRibbon.nguyenvatlieu && s.toncuoiky > 0 && s.donvitinh == "M"
                select new { s.mahang, s.tenhanghoa, s.donvitinh, s.quycach, s.toncuoiky };
            int tong = 0;
            foreach (var item in tonkho)
            {
                tong = tong + 1;
                if (tong == 1)
                {
                    KGI_1K.Text = item.quycach.Split('*')[0];
                    var quycach = Convert.ToDecimal(item.quycach.Split('*')[0].Replace("MM", ""));
                    var chieurong = Math.Floor(ChieuRong_Sticker.Value + Khoangcach_Sticker.Value);
                    var chieudai = Math.Floor(Chieudai_Sticker.Value + Khoangcach_Sticker.Value);
                    var slchieurong = 0;
                    //var slchieudai = 0;
                    if (ChieuRong_Sticker.Value < quycach)
                    {
                        if (Math.Floor(quycach / chieurong) * chieurong + GHCR_Sticker.Value <= quycach)
                            slchieurong = (int)Math.Floor(quycach / chieurong);
                        else
                        {
                            slchieurong = (int)Math.Floor(quycach / chieurong) - 1;
                        }
                    }

                    SLCR_1K.Text = slchieurong.ToString();
                    NCR_1K.Text = (slchieurong * chieurong).ToString();
                    TONG_1K.Text = Math.Ceiling(SoLuong_Sticker.Value * 105 / 100 * chieudai / 1000 / slchieurong).ToString();
                }
                else if (tong == 2)
                    Group_Sticker_2.Text = item.quycach;
                else if (tong == 3)
                    Group_Sticker_3.Text = item.quycach;
            }


        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        //var chieurong = txtChieurong.Value + KhoangCachtxt.Value;
        //var chieudai = txtChieudai.Value + KhoangCachtxt.Value;
        //int slchieudai, slchieurong = 0;
        //if (CheckListKichThuoc.Items[0].CheckState == CheckState.Checked)
        //{
        //    string[] KGI1 = {"440*595", "293*396"};
        //    foreach (var t in KGI1)
        //    {
        //        var KGI_Chieurong = Convert.ToInt32(t.Split('*')[0]);
        //        var KGI_Chieudai = Convert.ToInt32(t.Split('*')[1]);
        //        slchieurong = Math.Floor(KGI_Chieurong / chieurong) * chieurong + GHCR.Value <= KGI_Chieurong
        //            ? (int) Math.Floor(KGI_Chieurong / chieurong)
        //            : (int) Math.Floor(KGI_Chieurong / chieurong) - 1;
        //        slchieudai = Math.Floor(KGI_Chieudai / chieudai) * chieudai + GHCD.Value + CanMang <= KGI_Chieudai
        //            ? (int) Math.Floor(KGI_Chieudai / chieudai)
        //            : (int) Math.Floor(KGI_Chieudai / chieudai) - 1;

        //        switch (t)
        //        {
        //            case "440*595":

        //                SLCR_440_595.Text = slchieurong.ToString();
        //                NCR_440_595.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                SLCD_440_595.Text = slchieudai.ToString();
        //                NCD_440_595.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                TONG_440_595.Text = (slchieudai * slchieurong * 4).ToString();
        //                break;
        //            case "293*396":
        //                SLCR_293_396.Text = slchieurong.ToString();
        //                NCR_293_396.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                SLCD_293_396.Text = slchieudai.ToString();
        //                NCD_293_396.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                TONG_293_396.Text = (slchieudai * slchieurong * 9).ToString();
        //                break;
        //        }
        //    }

        //    string[] KGI2 = {"396*440", "297*440", "238*440"};
        //    foreach (var t in KGI2)
        //    {
        //        var KGI_Chieurong = Convert.ToInt32(t.Split('*')[1]);
        //        var KGI_Chieudai = Convert.ToInt32(t.Split('*')[0]);
        //        slchieurong = Math.Floor(KGI_Chieurong / chieurong) * chieurong + GHCD.Value + CanMang <=
        //                      KGI_Chieurong
        //            ? (int) Math.Floor(KGI_Chieurong / chieurong)
        //            : (int) Math.Floor(KGI_Chieurong / chieurong) - 1;
        //        slchieudai = Math.Floor(KGI_Chieudai / chieudai) * chieudai + GHCR.Value <= KGI_Chieudai
        //            ? (int) Math.Floor(KGI_Chieudai / chieudai)
        //            : (int) Math.Floor(KGI_Chieudai / chieudai) - 1;
        //        switch (t)
        //        {
        //            case "396*440":
        //                SLCR_396_440.Text = slchieudai.ToString();
        //                NCR_396_440.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                SLCD_396_440.Text = slchieurong.ToString();
        //                NCD_396_440.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                TONG_396_440.Text = (slchieurong * slchieudai * 6).ToString();
        //                break;
        //            case "297*440":
        //                SLCR_297_440.Text = slchieudai.ToString();
        //                NCR_297_440.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                SLCD_297_440.Text = slchieurong.ToString();
        //                NCD_297_440.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                TONG_297_440.Text = (slchieurong * slchieudai * 8).ToString();
        //                break;
        //            case "238*440":
        //                SLCR_238_440.Text = slchieudai.ToString();
        //                NCR_238_440.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                SLCD_238_440.Text = slchieurong.ToString();
        //                NCD_238_440.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                TONG_238_440.Text = (slchieurong * slchieudai * 10).ToString();
        //                break;

        //        }


        //    }

        //}

        //if (CheckListKichThuoc.Items[1].CheckState == CheckState.Checked)
        //{
        //    string[] KGI1 = {"390*540", "360*360"};
        //    foreach (var t in KGI1)
        //    {
        //        var KGI_Chieurong = Convert.ToInt32(t.Split('*')[0]);
        //        var KGI_Chieudai = Convert.ToInt32(t.Split('*')[1]);
        //        slchieurong = Math.Floor(KGI_Chieurong / chieurong) * chieurong + GHCR.Value <= KGI_Chieurong
        //            ? (int) Math.Floor(KGI_Chieurong / chieurong)
        //            : (int) Math.Floor(KGI_Chieurong / chieurong) - 1;
        //        slchieudai = Math.Floor(KGI_Chieudai / chieudai) * chieudai + GHCD.Value + CanMang <= KGI_Chieudai
        //            ? (int) Math.Floor(KGI_Chieudai / chieudai)
        //            : (int) Math.Floor(KGI_Chieudai / chieudai) - 1;
        //        switch (t)
        //        {
        //            case "390*540":
        //                SLCR_390_540.Text = slchieurong.ToString();
        //                NCR_390_540.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                SLCD_390_540.Text = slchieudai.ToString();
        //                NCD_390_540.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                TONG_390_540.Text = (slchieudai * slchieurong * 4).ToString();
        //                break;
        //            case "260*360":
        //                SLCR_260_360.Text = slchieurong.ToString();
        //                NCR_260_360.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                SLCD_260_360.Text = slchieudai.ToString();
        //                NCD_260_360.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                TONG_260_360.Text = (slchieudai * slchieurong * 9).ToString();
        //                break;
        //        }
        //    }

        //    string[] KGI2 = {"360*390", "270*390"};
        //    foreach (var t in KGI2)
        //    {
        //        var KGI_Chieurong = Convert.ToInt32(t.Split('*')[1]);
        //        var KGI_Chieudai = Convert.ToInt32(t.Split('*')[0]);
        //        slchieurong = Math.Floor(KGI_Chieurong / chieurong) * chieurong + GHCD.Value + CanMang <=
        //                      KGI_Chieurong
        //            ? (int) Math.Floor(KGI_Chieurong / chieurong)
        //            : (int) Math.Floor(KGI_Chieurong / chieurong) - 1;
        //        slchieudai = Math.Floor(KGI_Chieudai / chieudai) * chieudai + GHCR.Value <= KGI_Chieudai
        //            ? (int) Math.Floor(KGI_Chieudai / chieudai)
        //            : (int) Math.Floor(KGI_Chieudai / chieudai) - 1;
        //        switch (t)
        //        {
        //            case "360*390":
        //                SLCR_360_390.Text = slchieudai.ToString();
        //                NCR_360_390.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                SLCD_360_390.Text = slchieurong.ToString();
        //                NCD_360_390.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                TONG_360_390.Text = (slchieurong * slchieudai * 6).ToString();
        //                break;
        //            case "270*390":
        //                SLCR_270_390.Text = slchieudai.ToString();
        //                NCR_270_390.Text = (slchieudai * chieudai).ToString(CultureInfo.InvariantCulture);
        //                SLCD_270_390.Text = slchieurong.ToString();
        //                NCD_270_390.Text = (slchieurong * chieurong).ToString(CultureInfo.InvariantCulture);
        //                TONG_270_390.Text = (slchieurong * slchieudai * 8).ToString();

        //                break;
        //        }
        //    }
        //}
        #region Ngaydauthang,cuoithang 
        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        public static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        public static DateTime GetLastDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        #endregion
    }
}