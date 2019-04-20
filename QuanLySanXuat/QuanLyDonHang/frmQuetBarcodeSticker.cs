using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QuanLySanXuat.Object;
using ZXing;
using ZXing.QrCode;
using DevExpress.XtraReports.UI;
using WMPLib;
using QuanLySanXuat.Control;


namespace QuanLySanXuat
{
    public partial class frmQuetBarcodeSticker : DevExpress.XtraEditors.XtraForm
    {
        public NhanVienObj NvObj = new NhanVienObj();
        private BarcodeStickerCtr bsCtr = new BarcodeStickerCtr();
        public string SCD;
        //private int sl = 0;
        private int tong;
        WindowsMediaPlayer sound = new WindowsMediaPlayer();

        private QrCodeEncodingOptions options;
        private BarcodeWriter writer;
        public frmQuetBarcodeSticker(NhanVienObj obj , string scd)
        {
            InitializeComponent();
            NvObj = obj;
            SCD = scd;
        }

        private void frmQuetBarcodeSticker_Load(object sender, EventArgs e)
        {
            thongtindonhang();
            truyendulieu();
            phanquyen();
            
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 300,
                Height = 300,
            };
            writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = options
            };
            //txtNhap.Text = "ok";
            txtNhap.Focus();

        }
        //private void PlayFile(String url)
        //{
        //    Player = new WMPLib.WindowsMediaPlayer();
        //    Player.PlayStateChange +=
        //        new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
        //    Player.MediaError +=
        //        new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
        //    Player.URL = url;
        //    Player.controls.play();
        //}
        //private void Player_PlayStateChange(int NewState)
        //{
        //    if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
        //    {
        //        this.Close();
        //    }
        //}


        public void phanquyen()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }

        public void thongtindonhang()
        {
            var db = new MyDBContextDataContext();
            var dsx = (from s in db.tbDonSanXuats where s.SCD == SCD select s).Single();
            sCDTextEdit.Text = SCD;
            tenKhachHangTextEdit.Text = dsx.TenKhachHang;
            tenSanPhamTextEdit.Text = dsx.TenSanPham;
            if (dsx.SoLuong != null) soLuongTextEdit.Value = (int) dsx.SoLuong;
            kichThuocTextEdit.Text = dsx.KichThuoc;

        }
        public void truyendulieu()
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbBarcodeStickers where s.SCD == sCDTextEdit.Text select s).ToList();
            gridControl1.DataSource = lst;

            var lst2 = db.tbBarcodeSticker_Temps.Single(s => s.STT == 1);
            if(lst2.ID == true)
                btnLuuTam.Text = "LẤY DỮ LIỆU";
        }
        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var qr = new BarcodeWriter
                {
                    Options = options,
                    Format = BarcodeFormat.QR_CODE
                };
                var result = new Bitmap(qr.Write(txtNhap.Text.Trim()));
                pictureEdit1.Image = result;
                if (txtNhap.Text.Substring(0, 3) == "893")
                    QuocGiaTxt.Text = "Việt Nam";
                else
                {
                    QuocGiaTxt.Text = "United States";
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                //var tsl1 = 0;
                //var bc = db.tbBarcodeStickers.ToList();
                //foreach (var item in bc)
                //{
                //    if (item.Barcode != QuetTxt.Text && item.SCD == sCDTextEdit.Text)
                //    tsl1 = tsl1 + Convert.ToInt32(item.SoLuongSheet_Goi) * Convert.ToInt32(item.SoLuongPcs_Sheet);
                //}

                //if (tsl1 + (int)SoLuongQuetTxt.Value * (int)SoLuongPcs_Sheet.Value <= SoLuongCanIn.Value)
                //{
                    var barcode = new tbBarcodeSticker();
                    barcode.SCD = sCDTextEdit.Text;
                    barcode.Barcode = txtNhap.Text;
                    barcode.NhanVien = NvObj.Tennhanvien;
                    barcode.SoLuongSKU = (int)SoLuongSKU.Value;
                    barcode.SoLuongCanIn = (int)SoLuongCanIn.Value;
                    barcode.SoLuongSheet_Goi = (int)SoLuongQuetTxt.Value;
                    barcode.SoLuongPcs_Sheet = (int)SoLuongPcs_Sheet.Value;
                    barcode.BarcodeLoi = MaLoiTxt.Text;
                    barcode.NgayNhap = DateTime.Now;
                    db.tbBarcodeStickers.InsertOnSubmit(barcode);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                    frmQuetBarcodeSticker_Load(sender, e);
                    MaLoiTxt.Text = string.Empty;
                //}
                //else
                //{
                //    MessageBox.Show("Đơn hàng sản xuất đúng số lượng , nên không được thêm");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuetTxt.Text = string.Empty;
            QuetTxt.Focus();
        }

        private void QuetTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNhap.Text.Length == QuetTxt.Text.Length)// && !string.IsNullOrEmpty(txtNhap.Text))
                {

                    if (txtNhap.Text == QuetTxt.Text)
                    {
                        int ttsl = 0;
                        int dem = 0;
                        if (SoLuongSKU.Value <= 0) return;
                        //{
                        if (SoLuongQuetTxt.Value < SoLuongSheet_Goi.Value)
                        {
                            int tsl = 0;

                            tong = tong + 1;
                            SoLuongQuetTxt.Value = tong;
                            var db = new MyDBContextDataContext();
                            var bc = db.tbBarcodeStickers.ToList();
                            foreach (var item in bc)
                            {
                                if (item.Barcode == QuetTxt.Text && item.SCD == sCDTextEdit.Text)
                                    tsl = tsl + Convert.ToInt32(item.SoLuongSheet_Goi) * Convert.ToInt32(item.SoLuongPcs_Sheet);
                            }
                            ttsl = tsl + (int)SoLuongQuetTxt.Value * (int)SoLuongPcs_Sheet.Value;
                            //if (SoLuongQuetTxt.Value == SoLuongSheet_Goi.Value && ttsl < SoLuongCanIn.Value)
                            //{
                            //    if (SoLuongCanIn.Value != SoLuongSheet_Goi.Value * SoLuongPcs_Sheet.Value)
                            //    {
                            //        MessageBox.Show("");
                            //        MoNhac(@"Audio\DuSoLuong.wav");
                            //        if (MessageBox.Show("Số lượng đạt " + SoLuongSheet_Goi.Text + " ,bạn hãy chuyển công đoạn", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            //        {
                            //            //timer1.Start();
                            //            simpleButton1_Click(sender, e);
                            //            QuetTxt.Text = string.Empty;
                            //            SoLuongQuetTxt.Text = string.Empty;
                            //            tong = 0;
                            //            dem = 1;
                            //            QuetTxt.Focus();
                            //        }
                            //    }
                            //}
                        }
                        if (SoLuongCanIn.Value == ttsl && dem == 0 && ttsl > 0)
                        {
                            MessageBox.Show("");
                            MoNhac(@"Audio\HoanThanh.wav");
                            if (MessageBox.Show("Số lượng " + ttsl + " đã đúng Đã đúng với số lượng cần in, bạn có muốn hoàn tất đơn hàng", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //timer1.Start();
                                SoLuongSheet_Goi.Value = SoLuongQuetTxt.Value;
                                simpleButton1_Click(sender, e);
                                ttsl = 0;
                                btnLamMoi_Click(sender, e);
                                tong = 0;
                                QuetTxt.Focus();

                            }
                        }
                        if (SoLuongQuetTxt.Value > SoLuongSheet_Goi.Value || ttsl > SoLuongCanIn.Value)
                        {
                            MessageBox.Show("");
                            MoNhac(@"Audio\CanhBao.wav");
                            MessageBox.Show("Tổng số lượng quét đã vượt quá yêu cầu");
                        }
                    }

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Số lượng không được nhỏ hơn hoặc bằng 0");
                    //}

                    else
                    {
                        MaLoiTxt.Text = QuetTxt.Text;
                        MaLoiTxt.ForeColor = Color.OrangeRed;
                        MessageBox.Show("");
                        MoNhac(@"Audio\CanhBao.wav");
                        MessageBox.Show("Mã vạch không trùng khớp , vui lòng xem lại");
                    }
                }

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.Message);
            }

        }
        private void txtNhap_Click(object sender, EventArgs e)
        {
            tong = 0;
            txtNhap.Text = string.Empty;
            SoLuongQuetTxt.Text = string.Empty;
            SoLuongSKU.Text = string.Empty;
            QuetTxt.Text = string.Empty;          
        }

        private void QuetTxt_Click(object sender, EventArgs e)
        {
            QuetTxt.Text = string.Empty;
        }
        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SoLuongSKU.Focus();
            }
        }

        private void SoLuongSKU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SoLuongPcs_Sheet.Focus();
            }
        }

        private void slcoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SoLuongPcs_Sheet.Focus();
            }
        }
        private void SoLuongPcs_Sheet_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                QuetTxt.Focus();
            }
        }

        private void QuetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnXoa_Click(sender, e);
            }
            //if (e.KeyChar == 13)
            //    MessageBox.Show("ban phim");
                //e.Handled = true;
        }

        private void SoLuongPcs_Sheet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SoLuongCanIn.Value = Math.Ceiling(SoLuongSKU.Value / SoLuongPcs_Sheet.Value) * SoLuongPcs_Sheet.Value;
                SoLuongSheet_Goi.Value = Math.Round(SoLuongCanIn.Value / SoLuongPcs_Sheet.Value, 0);
            }
            catch
            {
                // ignored
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                var bc = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colBarcode).ToString();
                //var db = new MyDBContextDataContext();
                //var lst = (from s in db.tbBarcodeStickers where s.SCD == sCDTextEdit.Text && s.Barcode == bc select s).ToList(); ;
                var rp = new rpBangTheoDoiBarcode();
                rp.DataSource = bsCtr.BarcodeSticker_SCD_Barcode(sCDTextEdit.Text,bc);
                //rp.DataMember = "Table";
                rp.databingding();
                rp.ShowRibbonPreview();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnInTheoDon_Click(object sender, EventArgs e)
        {
            try
            {
                //var db = new MyDBContextDataContext();
                //var lst = (from s in db.tbBarcodeStickers where s.SCD == sCDTextEdit.Text select s).ToList(); ;
                var rp = new rpBangTheoDoiBarcode();
                rp.DataSource = bsCtr.BarcodeSticker_SCD(sCDTextEdit.Text);
                //rp.DataMember = "Table";
                rp.databingding();
                rp.ShowRibbonPreview();
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sound.controls.stop();
        }
        public void MoNhac(string nhac)
        {
            sound.URL = nhac;
            sound.controls.play();
        }

        private void frmQuetBarcodeSticker_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //    //e.Handled = false;
            //    MessageBox.Show("ban phim");
        }

        public frmQuetBarcodeSticker()
        {
            InitializeComponent();
            Load += frmQuetBarcodeSticker_Load;
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }
        private static void Cal(int width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (!e.Info.IsRowIndicator) return;
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
                var size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                var width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { Cal(width, gridView1); })); //Tăng kích thước nếu Text vượt quá
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = $"[{(e.RowHandle * -1)}]"; //Nhân -1 để đánh lại số thứ tự tăng dần
                var size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                var width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { Cal(width, gridView1); }));
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtNhap.Text = string.Empty;
            SoLuongSKU.Text = string.Empty;
            SoLuongCanIn.Text = string.Empty;
            SoLuongSheet_Goi.Text = string.Empty;
            SoLuongPcs_Sheet.Text = string.Empty;
            QuetTxt.Text = string.Empty;
            SoLuongQuetTxt.Text = string.Empty;
            MaLoiTxt.Text = string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }

        private void QuetTxt_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void SoLuongSKU_TextChanged(object sender, EventArgs e)
        {
            SoLuongPcs_Sheet_TextChanged(sender, e);
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = db.tbBarcodeSticker_Temps.Single(s =>s.STT == 1);
            if (lst.ID == false)
            {
                lst.ID = true;
                lst.SCD = sCDTextEdit.Text;
                lst.Barcode = txtNhap.Text;
                lst.SoLuongCanIn = (int)SoLuongCanIn.Value;
                lst.SoLuongSKU = (int)SoLuongSKU.Value;
                lst.SoLuongSheet_Goi = (int)SoLuongSheet_Goi.Value;
                lst.SoLuongPcs_Sheet = (int)SoLuongPcs_Sheet.Value;
                lst.BarcodeLoi = MaLoiTxt.Text;
                lst.SoLuongQuet = (int)SoLuongQuetTxt.Value;
                db.SubmitChanges();
                MessageBox.Show("Lưu vào bộ nhớ tạm thành công");
                btnLuuTam.Text = "LẤY DỮ LIỆU";
            }
            else
            {
                if (sCDTextEdit.Text == lst.SCD)
                {
                    if (MessageBox.Show(
                            "Bạn có muốn lấy dữ liệu từ bộ nhớ tạm không, dữ liệu chỉ phục hồi 1 lần duy nhất",
                            "Cảnh báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) != DialogResult.Yes) return;
                    txtNhap.Text = lst.Barcode;
                    if (lst.SoLuongCanIn != null)
                    {
                        SoLuongCanIn.Value = (int) lst.SoLuongCanIn;
                        if (lst.SoLuongSKU != null) SoLuongSKU.Value = (int) lst.SoLuongSKU;
                        if (lst.SoLuongSheet_Goi != null) SoLuongSheet_Goi.Value = (int) lst.SoLuongSheet_Goi;
                        if (lst.SoLuongPcs_Sheet != null) SoLuongPcs_Sheet.Value = (int) lst.SoLuongPcs_Sheet;
                        MaLoiTxt.Text = lst.BarcodeLoi;
                        if (lst.SoLuongQuet != null) SoLuongQuetTxt.Value = (int) lst.SoLuongQuet;

                        lst.ID = false;
                        lst.SCD = null;
                        lst.Barcode = null;
                    }

                    lst.SoLuongCanIn = null;
                    lst.SoLuongSKU = null;
                    lst.SoLuongSheet_Goi = null;
                    lst.SoLuongPcs_Sheet = null;
                    lst.BarcodeLoi = null;
                    lst.SoLuongQuet = null;
                    db.SubmitChanges();
                    MessageBox.Show("Lấy dữ liệu thành công");
                    btnLuuTam.Text = "LƯU DỮ LIỆU";
                }
                else
                {
                    MessageBox.Show("Không trùng mã SCD, Mã SCD lưu tạm là : " + lst.SCD);
                }
            }
        }
    }
}