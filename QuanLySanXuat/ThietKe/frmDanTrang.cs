using System;
using static System.Int32;

namespace QuanLySanXuat
{
    public partial class frmDanTrang : DevExpress.XtraEditors.XtraForm
    {
        public frmDanTrang()
        {
            InitializeComponent();
        }

        //private void btnTinh_Click(object sender, EventArgs e)
        //{

        //    var chieuRong = Parse(txtChieurong.Text) + 3;
        //    var chieuDai = Parse(txtChieudai.Text) + 3;
        //    int slchieudai, slchieurong;
        //    var canMang = 5;
        //    //if (checkBox1.Checked == true)
        //        canMang = canMang + 3;


        //    //9k 260*360

        //    if ((260 / chieuRong) * chieuRong + 15 <= 260)
        //        slchieurong = 260 / chieuRong;
        //    else
        //        slchieurong = (260 / chieuRong) - 1;
        //    SLCR_260_360.Text = slchieurong.ToString();
        //    NCR_260_360.Text = (slchieurong * chieuRong).ToString();

        //    if ((360 / chieuDai) * chieuDai + canMang <= 360)
        //        slchieudai = 360 / chieuDai;
        //    else
        //        slchieudai = (360 / chieuDai) - 1;

        //    SLCD_260_360.Text = slchieudai.ToString();
        //    NCD_260_360.Text = (slchieudai * chieuDai).ToString();
        //    TONG_260_360.Text = (slchieudai * slchieurong * 9).ToString();

        //    //9k 293*396

        //    if ((293 / chieuRong) * chieuRong + 15 <= 293)
        //        slchieurong = 293 / chieuRong;
        //    else
        //        slchieurong = (293 / chieuRong) - 1;
        //    SLCR_293_396.Text = slchieurong.ToString();
        //    NCR_293_396.Text = (slchieurong * chieuRong).ToString();
        //    if ((396 / chieuDai) * chieuDai + canMang <= 396)
        //        slchieudai = 396 / chieuDai;
        //    else
        //        slchieudai = (396 / chieuDai) - 1;
        //    SLCD_293_396.Text = slchieudai.ToString();
        //    NCD_293_396.Text = (slchieudai * chieuDai).ToString();
        //    TONG_293_396.Text = (slchieudai * slchieurong * 9).ToString();

        //    //10k 238*440

        //    if ((440 / chieuRong) * chieuRong + canMang <= 440)
        //        slchieurong = 440 / chieuRong;
        //    else
        //        slchieurong = (440 / chieuRong) - 1;
        //    SLCR_238_440.Text = slchieurong.ToString();
        //    NCR_238_440.Text = (slchieurong * chieuRong).ToString();

        //    if ((238 / chieuDai) * chieuDai + 15 <= 238)
        //        slchieudai = 238 / chieuDai;
        //    else
        //        slchieudai = (238 / chieuDai) - 1;
        //    SLCD_238_440.Text = slchieudai.ToString();
        //    NCD_238_440.Text = (slchieudai * chieuDai).ToString();
        //    TONG_238_440.Text = (slchieudai * slchieurong * 10).ToString();

        //    //8k 270*390	

        //    if ((390 / chieuRong) * chieuRong + canMang <= 390)
        //        slchieurong = 390 / chieuRong;
        //    else
        //        slchieurong = (390 / chieuRong) - 1;
        //    SLCR_270_390.Text = slchieurong.ToString();
        //    NCR_270_390.Text = (slchieurong * chieuRong).ToString();

        //    if ((270 / chieuDai) * chieuDai + 15 <= 270)
        //        slchieudai = 270 / chieuDai;
        //    else
        //        slchieudai = (270 / chieuDai) - 1;
        //    SLCD_270_390.Text = slchieudai.ToString();
        //    NCD_270_390.Text = (slchieudai * chieuDai).ToString();
        //    TONG_270_390.Text = (slchieudai * slchieurong * 8).ToString();

        //    //8k 297*440	

        //    if ((440 / chieuRong) * chieuRong + canMang <= 440)
        //        slchieurong = 440 / chieuRong;
        //    else
        //        slchieurong = (440 / chieuRong) - 1;
        //    SLCR_297_440.Text = slchieurong.ToString();
        //    NCR_297_440.Text = (slchieurong * chieuRong).ToString();

        //    if ((297 / chieuDai) * chieuDai + 15 <= 297)
        //        slchieudai = 297 / chieuDai;
        //    else
        //        slchieudai = (297 / chieuDai) - 1;
        //    SLCD_297_440.Text = slchieudai.ToString();
        //    NCD_297_440.Text = (slchieudai * chieuDai).ToString();
        //    TONG_297_440.Text = (slchieudai * slchieurong * 8).ToString();

        //    //6k 360*390	

        //    if ((390 / chieuRong) * chieuRong + canMang <= 390)
        //        slchieurong = 390 / chieuRong;
        //    else
        //        slchieurong = (390 / chieuRong) - 1;
        //    SLCR_360_390.Text = slchieurong.ToString();
        //    NCR_360_390.Text = (slchieurong * chieuRong).ToString();

        //    if ((360 / chieuDai) * chieuDai + 15 <= 360)
        //        slchieudai = 360 / chieuDai;
        //    else
        //        slchieudai = (360 / chieuDai) - 1;
        //    SLCD_360_390.Text = slchieudai.ToString();
        //    NCD_360_390.Text = (slchieudai * chieuDai).ToString();
        //    TONG_360_390.Text = (slchieudai * slchieurong * 6).ToString();

        //    //6k 396*440
        //    if ((440 / chieuRong) * chieuRong + canMang <= 440)
        //        slchieurong = 440 / chieuRong;
        //    else
        //        slchieurong = (440 / chieuRong) - 1;
        //    SLCR_396_440.Text = slchieurong.ToString();
        //    NCR_396_440.Text = (slchieurong * chieuRong).ToString();

        //    if ((396 / chieuDai) * chieuDai + 15 <= 396)
        //        slchieudai = 396 / chieuDai;
        //    else
        //        slchieudai = (396 / chieuDai) - 1;
        //    SLCD_396_440.Text = slchieudai.ToString();
        //    NCD_396_440.Text = (slchieudai * chieuDai).ToString();
        //    TONG_396_440.Text = (slchieudai * slchieurong * 6).ToString();

        //    //6k 293*595

        //    if ((293 / chieuRong) * chieuRong + 15 <= 293)
        //        slchieurong = 293 / chieuRong;
        //    else
        //        slchieurong = (293 / chieuRong) - 1;
        //    SLCR_293_595.Text = slchieurong.ToString();
        //    NCR_293_595.Text = (slchieurong * chieuRong).ToString();

        //    if ((595 / chieuDai) * chieuDai + canMang <= 595)
        //        slchieudai = 595 / chieuDai;
        //    else
        //        slchieudai = (595 / chieuDai) - 1;
        //    SLCD_293_595.Text = slchieudai.ToString();
        //    NCD_293_595.Text = (slchieudai * chieuDai).ToString();
        //    TONG_293_595.Text = (slchieudai * slchieurong * 6).ToString();

        //    //6k 260*540

        //    if ((260 / chieuRong) * chieuRong + 15 <= 260)
        //        slchieurong = 260 / chieuRong;
        //    else
        //        slchieurong = (260 / chieuRong) - 1;
        //    SLCR_260_540.Text = slchieurong.ToString();
        //    NCR_260_540.Text = (slchieurong * chieuRong).ToString();

        //    if ((540 / chieuDai) * chieuDai + canMang <= 540)
        //        slchieudai = 540 / chieuDai;
        //    else
        //        slchieudai = (540 / chieuDai) - 1;
        //    SLCD_260_540.Text = slchieudai.ToString();
        //    NCD_260_540.Text = (slchieudai * chieuDai).ToString();
        //    TONG_260_540.Text = (slchieudai * slchieurong * 6).ToString();

        //    //4k 390*540

        //    if ((390 / chieuRong) * chieuRong + 15 <= 390)
        //        slchieurong = 390 / chieuRong;
        //    else
        //        slchieurong = (390 / chieuRong) - 1;
        //    SLCR_390_540.Text = slchieurong.ToString();
        //    NCR_390_540.Text = (slchieurong * chieuRong).ToString();

        //    if ((540 / chieuDai) * chieuDai + canMang <= 540)
        //        slchieudai = 540 / chieuDai;
        //    else
        //        slchieudai = (540 / chieuDai) - 1;
        //    SLCD_390_540.Text = slchieudai.ToString();
        //    NCD_390_540.Text = (slchieudai * chieuDai).ToString();
        //    TONG_390_540.Text = (slchieudai * slchieurong * 4).ToString();

        //    //4k 440*595

        //    if ((440 / chieuRong) * chieuRong + 15 <= 440)
        //        slchieurong = 440 / chieuRong;
        //    else
        //        slchieurong = (440 / chieuRong) - 1;
        //    SLCR_440_595.Text = slchieurong.ToString();
        //    NCR_440_595.Text = (slchieurong * chieuRong).ToString();

        //    if ((595 / chieuDai) * chieuDai + canMang <= 595)
        //        slchieudai = 595 / chieuDai;
        //    else
        //        slchieudai = (595 / chieuDai) - 1;
        //    SLCD_440_595.Text = slchieudai.ToString();
        //    NCD_440_595.Text = (slchieudai * chieuDai).ToString();
        //    TONG_440_595.Text = (slchieudai * slchieurong * 4).ToString();

        //    //8k 220*595
        //    if ((595 / chieuRong) * chieuRong + canMang <= 595)
        //        slchieurong = 595 / chieuRong;
        //    else
        //        slchieurong = (595 / chieuRong) - 1;
        //    SLCD_220_595.Text = slchieurong.ToString();
        //    NCD_220_595.Text = (slchieurong * chieuRong).ToString();

        //    if ((220 / chieuDai) * chieuDai + 15 <= 220)
        //        slchieudai = 220 / chieuDai;
        //    else
        //        slchieudai = (220 / chieuDai) - 1;
        //    SLCR_220_595.Text = slchieudai.ToString();
        //    NCR_220_595.Text = (slchieudai * chieuDai).ToString();
        //    TONG_220_595.Text = (slchieudai * slchieurong * 8).ToString();


        //    //5k 370*510	
        //    if ((370 / chieuRong) * chieuRong + 15 <= 370)
        //        slchieurong = 370 / chieuRong;
        //    else
        //        slchieurong = (370 / chieuRong) - 1;
        //    SLCR_370_510.Text = slchieurong.ToString();
        //    NCR_370_510.Text = (slchieurong * chieuRong).ToString();

        //    if ((510 / chieuDai) * chieuDai + canMang <= 510)
        //        slchieudai = 510 / chieuDai;
        //    else
        //        slchieudai = (510 / chieuDai) - 1;
        //    SLCD_370_510.Text = slchieudai.ToString();
        //    NCD_370_510.Text = (slchieudai * chieuDai).ToString();
        //    TONG_370_510.Text = (slchieudai * slchieurong * 5).ToString();

        //    //5k 330*450
        //    if ((330 / chieuRong) * chieuRong + 15 <= 330)
        //        slchieurong = 330 / chieuRong;
        //    else
        //        slchieurong = (330 / chieuRong) - 1;
        //    SLCR_330_450.Text = slchieurong.ToString();
        //    NCR_330_450.Text = (slchieurong * chieuRong).ToString();

        //    if ((450 / chieuDai) * chieuDai + canMang <= 450)
        //        slchieudai = 450 / chieuDai;
        //    else
        //        slchieudai = (450 / chieuDai) - 1;
        //    SLCD_330_450.Text = slchieudai.ToString();
        //    NCD_330_450.Text = (slchieudai * chieuDai).ToString();
        //    TONG_330_450.Text = (slchieudai * slchieurong * 5).ToString();

        //    //7k 293*448
        //    if ((293 / chieuRong) * chieuRong + 15 <= 293)
        //        slchieurong = 293 / chieuRong;
        //    else
        //        slchieurong = (293 / chieuRong) - 1;
        //    SLCR_293_448.Text = slchieurong.ToString();
        //    NCR_293_448.Text = (slchieurong * chieuRong).ToString();

        //    if ((448 / chieuDai) * chieuDai + canMang <= 448)
        //        slchieudai = 448 / chieuDai;
        //    else
        //        slchieudai = (448 / chieuDai) - 1;
        //    SLCD_293_448.Text = slchieudai.ToString();
        //    NCD_293_448.Text = (slchieudai * chieuDai).ToString();
        //    TONG_293_448.Text = (slchieudai * slchieurong * 7).ToString();

        //    //7k 260*410
        //    if ((260 / chieuRong) * chieuRong + 15 <= 260)
        //        slchieurong = 260 / chieuRong;
        //    else
        //        slchieurong = (260 / chieuRong) - 1;
        //    SLCR_260_410.Text = slchieurong.ToString();
        //    NCR_260_410.Text = (slchieurong * chieuRong).ToString();

        //    if ((410 / chieuDai) * chieuDai + canMang <= 410)
        //        slchieudai = 410 / chieuDai;
        //    else
        //        slchieudai = (410 / chieuDai) - 1;
        //    SLCD_260_410.Text = slchieudai.ToString();
        //    NCD_260_410.Text = (slchieudai * chieuDai).ToString();
        //    TONG_260_410.Text = (slchieudai * slchieurong * 7).ToString();

        //    //9K 250*440
        //    if ((250 / chieuRong) * chieuRong + 15 <= 250)
        //        slchieurong = 250 / chieuRong;
        //    else
        //        slchieurong = (250 / chieuRong) - 1;
        //    SLCR_250_440.Text = slchieurong.ToString();
        //    NCR_250_440.Text = (slchieurong * chieuRong).ToString();

        //    if ((440 / chieuDai) * chieuDai + canMang <= 440)
        //        slchieudai = 440 / chieuDai;
        //    else
        //        slchieudai = (440 / chieuDai) - 1;
        //    SLCD_250_440.Text = slchieudai.ToString();
        //    NCD_250_440.Text = (slchieudai * chieuDai).ToString();
        //    TONG_250_440.Text = (slchieudai * slchieurong * 9).ToString();

        //    //9K 230*390
        //    if ((230 / chieuRong) * chieuRong + 15 <= 230)
        //        slchieurong = 230 / chieuRong;
        //    else
        //        slchieurong = (230 / chieuRong) - 1;
        //    SLCR_230_390.Text = slchieurong.ToString();
        //    NCR_230_390.Text = (slchieurong * chieuRong).ToString();

        //    if ((390 / chieuDai) * chieuDai + canMang <= 390)
        //        slchieudai = 390 / chieuDai;
        //    else
        //        slchieudai = (390 / chieuDai) - 1;
        //    SLCD_230_390.Text = slchieudai.ToString();
        //    NCD_230_390.Text = (slchieudai * chieuDai).ToString();
        //    TONG_230_390.Text = (slchieudai * slchieurong * 9).ToString();

        //    //5k 293*604
        //    if ((604 / chieuRong) * chieuRong + canMang <= 604)
        //        slchieurong = 604 / chieuRong;
        //    else
        //        slchieurong = (604 / chieuRong) - 1;
        //    SLCR_293_604.Text = slchieurong.ToString();
        //    NCR_293_604.Text = (slchieurong * chieuRong).ToString();

        //    if ((293 / chieuDai) * chieuDai + 15 <= 293)
        //        slchieudai = 293 / chieuDai;
        //    else
        //        slchieudai = (293 / chieuDai) - 1;
        //    SLCD_293_604.Text = slchieudai.ToString();
        //    NCD_293_604.Text = (slchieudai * chieuDai).ToString();
        //    TONG_293_604.Text = (slchieudai * slchieurong * 5).ToString();

        //    //3k 390*690 
        //    if ((390 / chieuRong) * chieuRong + 15 <= 390)
        //        slchieurong = 390 / chieuRong;
        //    else
        //        slchieurong = (390 / chieuRong) - 1;
        //    SLCR_390_690.Text = slchieurong.ToString();
        //    NCR_390_690.Text = (slchieurong * chieuRong).ToString();

        //    if ((690 / chieuDai) * chieuDai + canMang <= 690)
        //        slchieudai = 690 / chieuDai;
        //    else
        //        slchieudai = (690 / chieuDai) - 1;
        //    SLCD_390_690.Text = slchieudai.ToString();
        //    NCD_390_690.Text = (slchieudai * chieuDai).ToString();
        //    TONG_390_690.Text = (slchieudai * slchieurong * 3).ToString();

        //    //5k 260*560 
        //    if ((260 / chieuRong) * chieuRong + 15 <= 260)
        //        slchieurong = 260 / chieuRong;
        //    else
        //        slchieurong = (260 / chieuRong) - 1;
        //    SLCR_260_560.Text = slchieurong.ToString();
        //    NCR_260_560.Text = (slchieurong * chieuRong).ToString();

        //    if ((560 / chieuDai) * chieuDai + canMang <= 560)
        //        slchieudai = 560 / chieuDai;
        //    else
        //        slchieudai = (560 / chieuDai) - 1;
        //    SLCD_260_560.Text = slchieudai.ToString();
        //    NCD_260_560.Text = (slchieudai * chieuDai).ToString();
        //    TONG_260_560.Text = (slchieudai * slchieurong * 5).ToString();

        //    //7k 238*595
        //    if ((238 / chieuRong) * chieuRong + 15 <= 238)
        //        slchieurong = 238 / chieuRong;
        //    else
        //        slchieurong = (238 / chieuRong) - 1;
        //    SLCR_238_595.Text = slchieurong.ToString();
        //    NCR_238_595.Text = (slchieurong * chieuRong).ToString();

        //    if ((595 / chieuDai) * chieuDai + canMang <= 595)
        //        slchieudai = 595 / chieuDai;
        //    else
        //        slchieudai = (595 / chieuDai) - 1;
        //    SLCD_238_595.Text = slchieudai.ToString();
        //    NCD_238_595.Text = (slchieudai * chieuDai).ToString();
        //    TONG_238_595.Text = (slchieudai * slchieurong * 7).ToString();

        //    //6k 297*583
        //    if ((297 / chieuRong) * chieuRong + 15 <= 297)
        //        slchieurong = 297 / chieuRong;
        //    else
        //        slchieurong = (297 / chieuRong) - 1;
        //    SLCR_297_583.Text = slchieurong.ToString();
        //    NCR_297_583.Text = (slchieurong * chieuRong).ToString();

        //    if ((583 / chieuDai) * chieuDai + canMang <= 583)
        //        slchieudai = 583 / chieuDai;
        //    else
        //        slchieudai = (583 / chieuDai) - 1;
        //    SLCD_297_583.Text = slchieudai.ToString();
        //    NCD_297_583.Text = (slchieudai * chieuDai).ToString();
        //    TONG_297_583.Text = (slchieudai * slchieurong * 6).ToString();

        //    //6k 270*510
        //    if ((270 / chieuRong) * chieuRong + 15 <= 270)
        //        slchieurong = 270 / chieuRong;
        //    else
        //        slchieurong = (270 / chieuRong) - 1;
        //    SLCR_270_510.Text = slchieurong.ToString();
        //    NCR_270_510.Text = (slchieurong * chieuRong).ToString();

        //    if ((510 / chieuDai) * chieuDai + canMang <= 510)
        //        slchieudai = 510 / chieuDai;
        //    else
        //        slchieudai = (510 / chieuDai) - 1;
        //    SLCD_270_510.Text = slchieudai.ToString();
        //    NCD_270_510.Text = (slchieudai * chieuDai).ToString();
        //    TONG_270_510.Text = (slchieudai * slchieurong * 6).ToString();

        //    //9k 220*485
        //    if ((220 / chieuRong) * chieuRong + 15 <= 220)
        //        slchieurong = 220 / chieuRong;
        //    else
        //        slchieurong = (220 / chieuRong) - 1;
        //    SLCR_220_485.Text = slchieurong.ToString();
        //    NCR_220_485.Text = (slchieurong * chieuRong).ToString();

        //    if ((485 / chieuDai) * chieuDai + canMang <= 485)
        //        slchieudai = 485 / chieuDai;
        //    else
        //        slchieudai = (485 / chieuDai) - 1;
        //    SLCD_220_485.Text = slchieudai.ToString();
        //    NCD_220_485.Text = (slchieudai * chieuDai).ToString();
        //    TONG_220_485.Text = (slchieudai * slchieurong * 9).ToString();

        //    //10k 260*360
        //    if ((260 / chieuRong) * chieuRong + 15 <= 260)
        //        slchieurong = 260 / chieuRong;
        //    else
        //        slchieurong = (260 / chieuRong) - 1;
        //    SLCR_260_360_10K.Text = slchieurong.ToString();
        //    NCR_260_360_10K.Text = (slchieurong * chieuRong).ToString();

        //    if ((360 / chieuDai) * chieuDai + canMang <= 360)
        //        slchieudai = 360 / chieuDai;
        //    else
        //        slchieudai = (360 / chieuDai) - 1;
        //    SLCD_260_360_10K.Text = slchieudai.ToString();
        //    NCD_260_360_10K.Text = (slchieudai * chieuDai).ToString();
        //    TONG_260_360_10K.Text = (slchieudai * slchieurong * 10).ToString();





        //    //tìm số lớn nhất
        //    var A = Parse(TONG_260_360.Text);
        //    var B = Parse(TONG_293_396.Text);
        //    var C = Parse(TONG_260_540.Text);
        //    var D = Parse(TONG_293_595.Text);
        //    var E = Parse(TONG_390_540.Text);
        //    var F = Parse(TONG_440_595.Text);
        //    var G = Parse(TONG_238_440.Text);
        //    var H = Parse(TONG_297_440.Text);
        //    var I = Parse(TONG_270_390.Text);
        //    var J = Parse(TONG_360_390.Text);
        //    var K = Parse(TONG_396_440.Text);
        //    var L = Parse(TONG_370_510.Text);
        //    var M = Parse(TONG_330_450.Text);
        //    var N = Parse(TONG_293_448.Text);
        //    var O = Parse(TONG_260_410.Text);
        //    var P = Parse(TONG_250_440.Text);
        //    var R = Parse(TONG_230_390.Text);
        //    var S = Parse(TONG_293_604.Text);
        //    var V = Parse(TONG_220_595.Text);
        //    var T = Parse(TONG_390_690.Text);
        //    var AD = Parse(TONG_260_560.Text);
        //    var AE = Parse(TONG_238_595.Text);
        //    var AF = Parse(TONG_297_583.Text);
        //    var AA = Parse(TONG_270_510.Text);
        //    var AB = Parse(TONG_220_485.Text);
        //    var AC = Parse(TONG_260_360_10K.Text);

        //    var timMax = new int[] { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, R, S, V, T, AD, AE, AF, AA, AB, AC };
        //    var max = 0;
        //    foreach (var t in timMax)
        //    {
        //        if (t > max)
        //            max = t;
        //    }

        //    SOLONNHAT.Text = max.ToString();

        //    // if()



        //    //kich thuoc dac biet
        //    int X, Y;

        //    X = Parse(TimX.Text);

        //    Y = Parse(TimY.Text);


        //    if ((X / chieuRong) * chieuRong + 15 <= X) //SLCR_TimX_TimY
        //        slchieurong = X / chieuRong;
        //    else
        //        slchieurong = (X / chieuRong) - 1;
        //    SLCR_TimX_TimY.Text = slchieurong.ToString();
        //    NCR_TimX_TimY.Text = (slchieurong * chieuRong).ToString();

        //    if ((Y / chieuDai) * chieuDai + canMang <= Y)
        //        slchieudai = Y / chieuDai;
        //    else
        //        slchieudai = (Y / chieuDai) - 1;
        //    SLCD_TimX_TimY.Text = slchieudai.ToString();
        //    NCD_TimX_TimY.Text = (slchieudai * chieuDai).ToString();
        //    //TONG_TimX_TimY.Text = (Slchieudai * Slchieurong * 9).ToString();

        //    //--------------------------------------------------------//
        //    txtChieurongN.Text = txtChieudai.Text;
        //    txtChieudaiN.Text = txtChieurong.Text;
        //}

        //private void btnTinhNguoc_Click(object sender, EventArgs e)
        //{
        //    var chieuRong = Parse(txtChieurong.Text) + 3;
        //    var chieuDai = Parse(txtChieudai.Text) + 3;
        //    int slchieudai, slchieurong;
        //    var canMang = 5;
        //   // if (checkBox1.Checked == true)
        //        canMang = canMang + 3;

        //    //9k 260*360

        //    if ((260 / chieuDai) * chieuDai + 15 <= 260)
        //        slchieurong = 260 / chieuDai;
        //    else
        //        slchieurong = (260 / chieuDai) - 1;
        //    SLCR_260_360.Text = slchieurong.ToString();
        //    NCR_260_360.Text = (slchieurong * chieuDai).ToString();

        //    if ((360 / chieuRong) * chieuRong + canMang <= 360)
        //        slchieudai = 360 / chieuRong;
        //    else
        //        slchieudai = (360 / chieuRong) - 1;
        //    SLCD_260_360.Text = slchieudai.ToString();
        //    NCD_260_360.Text = (slchieudai * chieuRong).ToString();
        //    TONG_260_360.Text = (slchieudai * slchieurong * 9).ToString();

        //    //9k 293*396

        //    if ((293 / chieuDai) * chieuDai + 15 <= 293)
        //        slchieurong = 293 / chieuDai;
        //    else
        //        slchieurong = (293 / chieuDai) - 1;
        //    SLCR_293_396.Text = slchieurong.ToString();
        //    NCR_293_396.Text = (slchieurong * chieuDai).ToString();
        //    if ((396 / chieuRong) * chieuRong + canMang <= 396)
        //        slchieudai = 396 / chieuRong;
        //    else
        //        slchieudai = (396 / chieuRong) - 1;
        //    SLCD_293_396.Text = slchieudai.ToString();
        //    NCD_293_396.Text = (slchieudai * chieuRong).ToString();
        //    TONG_293_396.Text = (slchieudai * slchieurong * 9).ToString();

        //    //10k 238*440

        //    if ((440 / chieuDai) * chieuDai + canMang <= 440)
        //        slchieurong = 440 / chieuDai;
        //    else
        //        slchieurong = (440 / chieuDai) - 1;
        //    SLCR_238_440.Text = slchieurong.ToString();
        //    NCR_238_440.Text = (slchieurong * chieuDai).ToString();

        //    if ((238 / chieuRong) * chieuRong + 15 <= 238)
        //        slchieudai = 238 / chieuRong;
        //    else
        //        slchieudai = (238 / chieuRong) - 1;
        //    SLCD_238_440.Text = slchieudai.ToString();
        //    NCD_238_440.Text = (slchieudai * chieuRong).ToString();
        //    TONG_238_440.Text = (slchieudai * slchieurong * 10).ToString();

        //    //8k 270*390	

        //    if ((390 / chieuDai) * chieuDai + canMang <= 390)
        //        slchieurong = 390 / chieuDai;
        //    else
        //        slchieurong = (390 / chieuDai) - 1;
        //    SLCR_270_390.Text = slchieurong.ToString();
        //    NCR_270_390.Text = (slchieurong * chieuDai).ToString();

        //    if ((270 / chieuRong) * chieuRong + 15 <= 270)
        //        slchieudai = 270 / chieuRong;
        //    else
        //        slchieudai = (270 / chieuRong) - 1;
        //    SLCD_270_390.Text = slchieudai.ToString();
        //    NCD_270_390.Text = (slchieudai * chieuRong).ToString();
        //    TONG_270_390.Text = (slchieudai * slchieurong * 8).ToString();

        //    //8k 297*440	

        //    if ((440 / chieuDai) * chieuDai + canMang <= 440)
        //        slchieurong = 440 / chieuDai;
        //    else
        //        slchieurong = (440 / chieuDai) - 1;
        //    SLCR_297_440.Text = slchieurong.ToString();
        //    NCR_297_440.Text = (slchieurong * chieuDai).ToString();

        //    if ((297 / chieuRong) * chieuRong + 15 <= 297)
        //        slchieudai = 297 / chieuRong;
        //    else
        //        slchieudai = (297 / chieuRong) - 1;
        //    SLCD_297_440.Text = slchieudai.ToString();
        //    NCD_297_440.Text = (slchieudai * chieuRong).ToString();
        //    TONG_297_440.Text = (slchieudai * slchieurong * 8).ToString();

        //    //6k 360*390	

        //    if ((390 / chieuDai) * chieuDai + canMang <= 390)
        //        slchieurong = 390 / chieuDai;
        //    else
        //        slchieurong = (390 / chieuDai) - 1;
        //    SLCR_360_390.Text = slchieurong.ToString();
        //    NCR_360_390.Text = (slchieurong * chieuDai).ToString();

        //    if ((360 / chieuRong) * chieuRong + 15 <= 360)
        //        slchieudai = 360 / chieuRong;
        //    else
        //        slchieudai = (360 / chieuRong) - 1;
        //    SLCD_360_390.Text = slchieudai.ToString();
        //    NCD_360_390.Text = (slchieudai * chieuRong).ToString();
        //    TONG_360_390.Text = (slchieudai * slchieurong * 6).ToString();

        //    //6k 396*440
        //    if ((440 / chieuDai) * chieuDai + canMang <= 440)
        //        slchieurong = 440 / chieuDai;
        //    else
        //        slchieurong = (440 / chieuDai) - 1;
        //    SLCR_396_440.Text = slchieurong.ToString();
        //    NCR_396_440.Text = (slchieurong * chieuDai).ToString();

        //    if ((396 / chieuRong) * chieuRong + 15 <= 396)
        //        slchieudai = 396 / chieuRong;
        //    else
        //        slchieudai = (396 / chieuRong) - 1;
        //    SLCD_396_440.Text = slchieudai.ToString();
        //    NCD_396_440.Text = (slchieudai * chieuRong).ToString();
        //    TONG_396_440.Text = (slchieudai * slchieurong * 6).ToString();

        //    //6k 293*595

        //    if ((293 / chieuDai) * chieuDai + 15 <= 293)
        //        slchieurong = 293 / chieuDai;
        //    else
        //        slchieurong = (293 / chieuDai) - 1;
        //    SLCR_293_595.Text = slchieurong.ToString();
        //    NCR_293_595.Text = (slchieurong * chieuDai).ToString();

        //    if ((595 / chieuRong) * chieuRong + canMang <= 595)
        //        slchieudai = 595 / chieuRong;
        //    else
        //        slchieudai = (595 / chieuRong) - 1;
        //    SLCD_293_595.Text = slchieudai.ToString();
        //    NCD_293_595.Text = (slchieudai * chieuRong).ToString();
        //    TONG_293_595.Text = (slchieudai * slchieurong * 6).ToString();

        //    //6k 260*540

        //    if ((260 / chieuDai) * chieuDai + 15 <= 260)
        //        slchieurong = 260 / chieuDai;
        //    else
        //        slchieurong = (260 / chieuDai) - 1;
        //    SLCR_260_540.Text = slchieurong.ToString();
        //    NCR_260_540.Text = (slchieurong * chieuDai).ToString();

        //    if ((540 / chieuRong) * chieuRong + canMang <= 540)
        //        slchieudai = 540 / chieuRong;
        //    else
        //        slchieudai = (540 / chieuRong) - 1;
        //    SLCD_260_540.Text = slchieudai.ToString();
        //    NCD_260_540.Text = (slchieudai * chieuRong).ToString();
        //    TONG_260_540.Text = (slchieudai * slchieurong * 6).ToString();

        //    //4k 390*540

        //    if ((390 / chieuDai) * chieuDai + 15 <= 390)
        //        slchieurong = 390 / chieuDai;
        //    else
        //        slchieurong = (390 / chieuDai) - 1;
        //    SLCR_390_540.Text = slchieurong.ToString();
        //    NCR_390_540.Text = (slchieurong * chieuDai).ToString();

        //    if ((540 / chieuRong) * chieuRong + canMang <= 540)
        //        slchieudai = 540 / chieuRong;
        //    else
        //        slchieudai = (540 / chieuRong) - 1;
        //    SLCD_390_540.Text = slchieudai.ToString();
        //    NCD_390_540.Text = (slchieudai * chieuRong).ToString();
        //    TONG_390_540.Text = (slchieudai * slchieurong * 4).ToString();

        //    //4k 440*595

        //    if ((440 / chieuDai) * chieuDai + 15 <= 440)
        //        slchieurong = 440 / chieuDai;
        //    else
        //        slchieurong = (440 / chieuDai) - 1;
        //    SLCR_440_595.Text = slchieurong.ToString();
        //    NCR_440_595.Text = (slchieurong * chieuDai).ToString();

        //    if ((595 / chieuRong) * chieuRong + canMang <= 595)
        //        slchieudai = 595 / chieuRong;
        //    else
        //        slchieudai = (595 / chieuRong) - 1;
        //    SLCD_440_595.Text = slchieudai.ToString();
        //    NCD_440_595.Text = (slchieudai * chieuRong).ToString();
        //    TONG_440_595.Text = (slchieudai * slchieurong * 4).ToString();

        //    //8k 220*595
        //    if ((595 / chieuDai) * chieuDai + canMang <= 595)
        //        slchieurong = 595 / chieuDai;
        //    else
        //        slchieurong = (595 / chieuDai) - 1;
        //    SLCD_220_595.Text = slchieurong.ToString();
        //    NCD_220_595.Text = (slchieurong * chieuDai).ToString();

        //    if ((220 / chieuRong) * chieuRong + 15 <= 220)
        //        slchieudai = 220 / chieuRong;
        //    else
        //        slchieudai = (220 / chieuRong) - 1;
        //    SLCR_220_595.Text = slchieudai.ToString();
        //    NCR_220_595.Text = (slchieudai * chieuRong).ToString();
        //    TONG_220_595.Text = (slchieudai * slchieurong * 8).ToString();


        //    //5k 370*510	
        //    if ((370 / chieuDai) * chieuDai + 15 <= 370)
        //        slchieurong = 370 / chieuDai;
        //    else
        //        slchieurong = (370 / chieuDai) - 1;
        //    SLCR_370_510.Text = slchieurong.ToString();
        //    NCR_370_510.Text = (slchieurong * chieuDai).ToString();

        //    if ((510 / chieuRong) * chieuRong + canMang <= 510)
        //        slchieudai = 510 / chieuRong;
        //    else
        //        slchieudai = (510 / chieuRong) - 1;
        //    SLCD_370_510.Text = slchieudai.ToString();
        //    NCD_370_510.Text = (slchieudai * chieuRong).ToString();
        //    TONG_370_510.Text = (slchieudai * slchieurong * 5).ToString();

        //    //5k 330*450
        //    if ((330 / chieuDai) * chieuDai + 15 <= 330)
        //        slchieurong = 330 / chieuDai;
        //    else
        //        slchieurong = (330 / chieuDai) - 1;
        //    SLCR_330_450.Text = slchieurong.ToString();
        //    NCR_330_450.Text = (slchieurong * chieuDai).ToString();

        //    if ((450 / chieuRong) * chieuRong + canMang <= 450)
        //        slchieudai = 450 / chieuRong;
        //    else
        //        slchieudai = (450 / chieuRong) - 1;
        //    SLCD_330_450.Text = slchieudai.ToString();
        //    NCD_330_450.Text = (slchieudai * chieuRong).ToString();
        //    TONG_330_450.Text = (slchieudai * slchieurong * 5).ToString();

        //    //7k 293*448
        //    if ((293 / chieuDai) * chieuDai + 15 <= 293)
        //        slchieurong = 293 / chieuDai;
        //    else
        //        slchieurong = (293 / chieuDai) - 1;
        //    SLCR_293_448.Text = slchieurong.ToString();
        //    NCR_293_448.Text = (slchieurong * chieuDai).ToString();

        //    if ((448 / chieuRong) * chieuRong + canMang <= 448)
        //        slchieudai = 448 / chieuRong;
        //    else
        //        slchieudai = (448 / chieuRong) - 1;
        //    SLCD_293_448.Text = slchieudai.ToString();
        //    NCD_293_448.Text = (slchieudai * chieuRong).ToString();
        //    TONG_293_448.Text = (slchieudai * slchieurong * 7).ToString();

        //    //7k 260*410
        //    if ((260 / chieuDai) * chieuDai + 15 <= 260)
        //        slchieurong = 260 / chieuDai;
        //    else
        //        slchieurong = (260 / chieuDai) - 1;
        //    SLCR_260_410.Text = slchieurong.ToString();
        //    NCR_260_410.Text = (slchieurong * chieuDai).ToString();

        //    if ((410 / chieuRong) * chieuRong + canMang <= 410)
        //        slchieudai = 410 / chieuRong;
        //    else
        //        slchieudai = (410 / chieuRong) - 1;
        //    SLCD_260_410.Text = slchieudai.ToString();
        //    NCD_260_410.Text = (slchieudai * chieuRong).ToString();
        //    TONG_260_410.Text = (slchieudai * slchieurong * 7).ToString();

        //    //9K 250*440
        //    if ((250 / chieuDai) * chieuDai + 15 <= 250)
        //        slchieurong = 250 / chieuDai;
        //    else
        //        slchieurong = (250 / chieuDai) - 1;
        //    SLCR_250_440.Text = slchieurong.ToString();
        //    NCR_250_440.Text = (slchieurong * chieuDai).ToString();

        //    if ((440 / chieuRong) * chieuRong + canMang <= 440)
        //        slchieudai = 440 / chieuRong;
        //    else
        //        slchieudai = (440 / chieuRong) - 1;
        //    SLCD_250_440.Text = slchieudai.ToString();
        //    NCD_250_440.Text = (slchieudai * chieuRong).ToString();
        //    TONG_250_440.Text = (slchieudai * slchieurong * 9).ToString();

        //    //9K 230*390
        //    if ((230 / chieuDai) * chieuDai + 15 <= 230)
        //        slchieurong = 230 / chieuDai;
        //    else
        //        slchieurong = (230 / chieuDai) - 1;
        //    SLCR_230_390.Text = slchieurong.ToString();
        //    NCR_230_390.Text = (slchieurong * chieuDai).ToString();

        //    if ((390 / chieuRong) * chieuRong + canMang <= 390)
        //        slchieudai = 390 / chieuRong;
        //    else
        //        slchieudai = (390 / chieuRong) - 1;
        //    SLCD_230_390.Text = slchieudai.ToString();
        //    NCD_230_390.Text = (slchieudai * chieuRong).ToString();
        //    TONG_230_390.Text = (slchieudai * slchieurong * 9).ToString();

        //    //5k 293*604
        //    if ((604 / chieuDai) * chieuDai + canMang <= 604)
        //        slchieurong = 604 / chieuDai;
        //    else
        //        slchieurong = (604 / chieuDai) - 1;
        //    SLCR_293_604.Text = slchieurong.ToString();
        //    NCR_293_604.Text = (slchieurong * chieuDai).ToString();

        //    if ((293 / chieuRong) * chieuRong + 15 <= 293)
        //        slchieudai = 293 / chieuRong;
        //    else
        //        slchieudai = (293 / chieuRong) - 1;
        //    SLCD_293_604.Text = slchieudai.ToString();
        //    NCD_293_604.Text = (slchieudai * chieuRong).ToString();
        //    TONG_293_604.Text = (slchieudai * slchieurong * 5).ToString();

        //    //3k 390*690 
        //    if ((390 / chieuDai) * chieuDai + 15 <= 390)
        //        slchieurong = 390 / chieuDai;
        //    else
        //        slchieurong = (390 / chieuDai) - 1;
        //    SLCR_390_690.Text = slchieurong.ToString();
        //    NCR_390_690.Text = (slchieurong * chieuDai).ToString();

        //    if ((690 / chieuRong) * chieuRong + canMang <= 690)
        //        slchieudai = 690 / chieuRong;
        //    else
        //        slchieudai = (690 / chieuRong) - 1;
        //    SLCD_390_690.Text = slchieudai.ToString();
        //    NCD_390_690.Text = (slchieudai * chieuRong).ToString();
        //    TONG_390_690.Text = (slchieudai * slchieurong * 3).ToString();

        //    //5k 260*560 
        //    if ((260 / chieuDai) * chieuDai + 15 <= 260)
        //        slchieurong = 260 / chieuDai;
        //    else
        //        slchieurong = (260 / chieuDai) - 1;
        //    SLCR_260_560.Text = slchieurong.ToString();
        //    NCR_260_560.Text = (slchieurong * chieuDai).ToString();

        //    if ((560 / chieuRong) * chieuRong + canMang <= 560)
        //        slchieudai = 560 / chieuRong;
        //    else
        //        slchieudai = (560 / chieuRong) - 1;
        //    SLCD_260_560.Text = slchieudai.ToString();
        //    NCD_260_560.Text = (slchieudai * chieuRong).ToString();
        //    TONG_260_560.Text = (slchieudai * slchieurong * 5).ToString();

        //    //7k 238*595
        //    if ((238 / chieuDai) * chieuDai + 15 <= 238)
        //        slchieurong = 238 / chieuDai;
        //    else
        //        slchieurong = (238 / chieuDai) - 1;
        //    SLCR_238_595.Text = slchieurong.ToString();
        //    NCR_238_595.Text = (slchieurong * chieuDai).ToString();

        //    if ((595 / chieuRong) * chieuRong + canMang <= 595)
        //        slchieudai = 595 / chieuRong;
        //    else
        //        slchieudai = (595 / chieuRong) - 1;
        //    SLCD_238_595.Text = slchieudai.ToString();
        //    NCD_238_595.Text = (slchieudai * chieuRong).ToString();
        //    TONG_238_595.Text = (slchieudai * slchieurong * 7).ToString();

        //    //6k 297*583
        //    if ((297 / chieuDai) * chieuDai + 15 <= 297)
        //        slchieurong = 297 / chieuDai;
        //    else
        //        slchieurong = (297 / chieuDai) - 1;
        //    SLCR_297_583.Text = slchieurong.ToString();
        //    NCR_297_583.Text = (slchieurong * chieuDai).ToString();

        //    if ((583 / chieuRong) * chieuRong + canMang <= 583)
        //        slchieudai = 583 / chieuRong;
        //    else
        //        slchieudai = (583 / chieuRong) - 1;
        //    SLCD_297_583.Text = slchieudai.ToString();
        //    NCD_297_583.Text = (slchieudai * chieuRong).ToString();
        //    TONG_297_583.Text = (slchieudai * slchieurong * 6).ToString();

        //    //6k 270*510
        //    if ((270 / chieuDai) * chieuDai + 15 <= 270)
        //        slchieurong = 270 / chieuDai;
        //    else
        //        slchieurong = (270 / chieuDai) - 1;
        //    SLCR_270_510.Text = slchieurong.ToString();
        //    NCR_270_510.Text = (slchieurong * chieuDai).ToString();

        //    if ((510 / chieuRong) * chieuRong + canMang <= 510)
        //        slchieudai = 510 / chieuRong;
        //    else
        //        slchieudai = (510 / chieuRong) - 1;
        //    SLCD_270_510.Text = slchieudai.ToString();
        //    NCD_270_510.Text = (slchieudai * chieuRong).ToString();
        //    TONG_270_510.Text = (slchieudai * slchieurong * 6).ToString();

        //    //9k 220*485
        //    if ((220 / chieuDai) * chieuDai + 15 <= 220)
        //        slchieurong = 220 / chieuDai;
        //    else
        //        slchieurong = (220 / chieuDai) - 1;
        //    SLCR_220_485.Text = slchieurong.ToString();
        //    NCR_220_485.Text = (slchieurong * chieuDai).ToString();

        //    if ((485 / chieuRong) * chieuRong + canMang <= 485)
        //        slchieudai = 485 / chieuRong;
        //    else
        //        slchieudai = (485 / chieuRong) - 1;
        //    SLCD_220_485.Text = slchieudai.ToString();
        //    NCD_220_485.Text = (slchieudai * chieuRong).ToString();
        //    TONG_220_485.Text = (slchieudai * slchieurong * 9).ToString();

        //    //10k 260*360
        //    if ((260 / chieuDai) * chieuDai + 15 <= 260)
        //        slchieurong = 260 / chieuDai;
        //    else
        //        slchieurong = (260 / chieuDai) - 1;
        //    SLCR_260_360_10K.Text = slchieurong.ToString();
        //    NCR_260_360_10K.Text = (slchieurong * chieuDai).ToString();

        //    if ((360 / chieuRong) * chieuRong + canMang <= 360)
        //        slchieudai = 360 / chieuRong;
        //    else
        //        slchieudai = (360 / chieuRong) - 1;
        //    SLCD_260_360_10K.Text = slchieudai.ToString();
        //    NCD_260_360_10K.Text = (slchieudai * chieuRong).ToString();
        //    TONG_260_360_10K.Text = (slchieudai * slchieurong * 10).ToString();





        //    //tìm số lớn nhất
        //    int A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, R, S, V, T, AD, AE, AF, AA, AB, AC;
        //    A = Parse(TONG_260_360.Text); // ĐỔI CHUỖI SANG SỐ A = 100

        //    B = Parse(TONG_293_396.Text);
        //    C = Parse(TONG_260_540.Text);
        //    D = Parse(TONG_293_595.Text);
        //    E = Parse(TONG_390_540.Text);
        //    F = Parse(TONG_440_595.Text);
        //    G = Parse(TONG_238_440.Text);
        //    H = Parse(TONG_297_440.Text);
        //    I = Parse(TONG_270_390.Text);
        //    J = Parse(TONG_360_390.Text);
        //    K = Parse(TONG_396_440.Text);
        //    L = Parse(TONG_370_510.Text);
        //    M = Parse(TONG_330_450.Text);
        //    N = Parse(TONG_293_448.Text);
        //    O = Parse(TONG_260_410.Text);
        //    P = Parse(TONG_250_440.Text);
        //    R = Parse(TONG_230_390.Text);
        //    S = Parse(TONG_293_604.Text);
        //    V = Parse(TONG_220_595.Text);
        //    T = Parse(TONG_390_690.Text);
        //    AD = Parse(TONG_260_560.Text);
        //    AE = Parse(TONG_238_595.Text);
        //    AF = Parse(TONG_297_583.Text);
        //    AA = Parse(TONG_270_510.Text);
        //    AB = Parse(TONG_220_485.Text);
        //    AC = Parse(TONG_260_360_10K.Text);

        //    var timMax = new[] { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, R, S, V, T, AD, AE, AF, AA, AB, AC };
        //    var max = 0;
        //    foreach (var t in timMax)
        //    {
        //        if (t > max)
        //            max = t;
        //    }

        //    SOLONNHAT.Text = max.ToString();

        //    //kich thuoc dac biet
        //    int X, Y;

        //    X = Parse(TimX.Text);

        //    Y = Parse(TimY.Text);


        //    if ((X / chieuDai) * chieuDai + 15 <= X) //SLCR_TimX_TimY
        //        slchieurong = X / chieuDai;
        //    else
        //        slchieurong = (X / chieuDai) - 1;
        //    SLCR_TimX_TimY.Text = slchieurong.ToString();
        //    NCR_TimX_TimY.Text = (slchieurong * chieuDai).ToString();

        //    if ((Y / chieuRong) * chieuRong + canMang <= Y)
        //        slchieudai = Y / chieuRong;
        //    else
        //        slchieudai = (Y / chieuRong) - 1;
        //    SLCD_TimX_TimY.Text = slchieudai.ToString();
        //    NCD_TimX_TimY.Text = (slchieudai * chieuRong).ToString();
        //    //TONG_TimX_TimY.Text = (Slchieudai * Slchieurong * 9).ToString();

        //}

    }
}