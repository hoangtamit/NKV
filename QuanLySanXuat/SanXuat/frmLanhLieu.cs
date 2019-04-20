using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QuanLySanXuat.Control;
using QuanLySanXuat.DonSanXuat;
using QuanLySanXuat.Object;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static QuanLySanXuat.PrintRibbon;
using static System.String;

namespace QuanLySanXuat
{
    public partial class frmLanhLieu : XtraForm
    {
        private readonly ConnectSQL _con = new ConnectSQL();
        private readonly LanhLieuCtr llCtr = new LanhLieuCtr();
        private int TinhOffset, TinhDanhThiep, TinhKyThuatSo, TinhInChu, TinhTemVai, TinhSticker, TinhSauIn;
        #region SoThuTu
        public frmLanhLieu()
        {
            InitializeComponent();
            Load += frmLanhLieu_Load_1;
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private static void cal(int width, GridView view)
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
                    e.Info.DisplayText = Empty;
                }
                else
                {
                    e.Info.ImageIndex = -1; //Không hiển thị hình
                    e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                }
                var size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                var width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(width, gridView1); })); //Tăng kích thước nếu Text vượt quá
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = $"[{(e.RowHandle * -1)}]"; //Nhân -1 để đánh lại số thứ tự tăng dần
                var size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                var width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(width, gridView1); }));
            }
        }

        #endregion

        public readonly NhanVienObj nvObj = new NhanVienObj();
        public frmLanhLieu(NhanVienObj obj)
        {
            InitializeComponent();
            nvObj = obj;
        }

        private string chieudai;
        private void frmLanhLieu_Load_1(object sender, EventArgs e)
        {
            SearchLookup();
            var db = new MyDBContextDataContext();
            var lst = (from s in db.DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null() select s).ToList();
            foreach (var collection in lst)
            {
                if (collection.BoPhanSX != null)
                {
                    collection.BoPhan = collection.BoPhanSX;
                    collection.PhuongPhapIn = collection.PhuongPhapInSX;
                }
                if (collection.VatLieuSX != null)
                {
                    collection.VatLieu = collection.VatLieuSX;
                    collection.Kho = collection.KhoSX;
                }
            }

            procDonSanXuat_ViewGridControl.DataSource = lst;
            //dsxCtr.LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null();
            databing();

        }
        public void SearchLookup()
        {
            //Bảng Khổ Giấy In
            var kgiCtr = new KhoGiayInCtr();
            KhoGiayInOffset.Properties.DataSource = kgiCtr.LoadData();
            KhoGiayInOffset.Properties.DisplayMember = "KhoIn";
            KhoGiayInOffset.Properties.ValueMember = "KhoIn";

            txtKhoGiayInKTS.Properties.DataSource = kgiCtr.LoadData();
            txtKhoGiayInKTS.Properties.DisplayMember = "KhoIn";
            txtKhoGiayInKTS.Properties.ValueMember = "KhoIn";

            txtKhoGiayInSauIn.Properties.DataSource = kgiCtr.LoadData();
            txtKhoGiayInSauIn.Properties.DisplayMember = "KhoIn";
            txtKhoGiayInSauIn.Properties.ValueMember = "KhoIn";


            //var vlCtrl = new VatLieuCtr();
            //QuyCachStickerSearch.Properties.DataSource = vlCtrl.LoadData4C();
            //QuyCachStickerSearch.Properties.DisplayMember = "QuyCach";
            //QuyCachStickerSearch.Properties.ValueMember = "QuyCach";

            //QuyCachInChuSearch.Properties.DataSource = vlCtrl.LoadData4C();
            //QuyCachInChuSearch.Properties.DisplayMember = "QuyCach";
            //QuyCachInChuSearch.Properties.ValueMember = "QuyCach";
        }
        public void databing()
        {
            sCDTextEdit.DataBindings.Clear();
            sCDTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "SCD");
            tenSanPhamTextEdit.DataBindings.Clear();
            tenSanPhamTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "TenSanPham");
            tenKhachHangTextEdit.DataBindings.Clear();
            tenKhachHangTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "TenKhachHang");
            loaiSanPhamTextEdit.DataBindings.Clear();
            loaiSanPhamTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "LoaiSanPham");

            mauMatPhaiTextEdit.DataBindings.Clear();
            mauMatPhaiTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "MauMatPhai");
            mauMatTraiTextEdit.DataBindings.Clear();
            mauMatTraiTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "MauMatTrai");
            phuongPhapInTextEdit.DataBindings.Clear();
            phuongPhapInTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "PhuongPhapIn");
            soLuongTextEdit.DataBindings.Clear();
            soLuongTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "SoLuong");

            vatLieuTextEdit.DataBindings.Clear();
            vatLieuTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "VatLieu");
            khoTextEdit.DataBindings.Clear();
            khoTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "Kho");
            kichThuocTextEdit.DataBindings.Clear();
            kichThuocTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "KichThuoc");
            boPhanTextEdit.DataBindings.Clear();
            boPhanTextEdit.DataBindings.Add("text", procDonSanXuat_ViewGridControl.DataSource, "BoPhan");
        }

        private void btnTinhSticker_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (boPhanTextEdit.Text == sticker)
            {
                //var a = Math.Round(Convert.ToDouble(_tinhlieu),0);
                //MessageBox.Show(a.ToString());
                TinhSticker = ((int)(txtSLSXSticker.Value * txtBuHaoSticker.Value * (Convert.ToInt32(_tinhlieu) + 3) / 1000 / txtSLDTSticker.Value));
                btnTinhSticker.Text = TinhSticker + " MÉT";
            }

        }

        private void buttonEdit3_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (boPhanTextEdit.Text == kts)
            {
                TinhKyThuatSo = (int)Math.Round(txtSLSXKyThuatSo.Value / txtSLDTKTS.Value + txtSoLuongSizeKTS.Value * txtBuHaoKTS.Value);
                btnTinhKTS.Text = TinhKyThuatSo + "  TẤM " + txtKhoGiayInKTS.Text;
            }
        }

        private void procDonSanXuat_ViewGridControl_Click(object sender, EventArgs e)
        {
            chieudai = kichThuocTextEdit.Text.ToUpper().Replace("MM", "");
            // xóa dữ liệu 
            Clear();

            // click chọn sẽ tab đến bộ phận của đơn hàng đó
            try
            {
                var db = new MyDBContextDataContext();
                var ll = (from s in db.DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_Null() where s.SCD == sCDTextEdit.Text select s).Single();
                if (ll.BoPhanSX != null)
                {
                    boPhanTextEdit.Text = ll.BoPhanSX;
                    MessageBox.Show("Đơn hàng đã chuyển đổi bộ phận " + ll.BoPhanSX + " , mọi người xem kỹ khi tính liệu");
                }

                var vatlieu = (from s in db.VatLieu_4C() where s.TenHangHoa == vatLieuTextEdit.Text select s).ToList();
                if (boPhanTextEdit.Text == offset)
                {
                    xtraTabControl1.SelectedTabPage = tpOffset;
                    QuycachOffset.Properties.DataSource = vatlieu;//vlCtr.GetData1C(vatLieuTextEdit.Text);
                    QuycachOffset.Properties.DisplayMember = "QuyCach";
                    QuycachOffset.Properties.ValueMember = "QuyCach";
                    if (ll.LanhLieu == null)
                    {
                        if (tenKhachHangTextEdit.Text == PrintRibbon.AD)
                            SLSXOffset.Value = soLuongTextEdit.Value;
                        else
                            SLSXOffset.Value = soLuongTextEdit.Value * 115 / 100;
                        if (khoTextEdit.Text == banthanhpham || khoTextEdit.Text == thanhpham)
                            CatGiayOffset.Text = "1K";
                    }
                    else
                    {
                        KhoGiayInOffset.Text = ll.KhoGiayIn;
                        CatGiayOffset.Text = ll.CatGiay;
                        soLuongDanTrangTextEdit.Text = ll.SoLuongDanTrang.ToString();
                        SLSXOffset.Text = ll.SoLuongSanXuat.ToString();
                        soTrangInTextEdit.Text = ll.SoTrangIn;
                        buHaoTextEdit.Text = ll.BuHao.ToString();
                        ctpOffsetTextEdit.Text = ll.CtpOffset.ToString();
                        QuycachOffset.Text = ll.QuyCach;
                        if (ll.Kho == nguyenvatlieu)
                        {
                            var vl = (from a in db.tbVatLieus
                                      where a.TenHangHoa == ll.VatLieu && a.QuyCach == ll.QuyCach
                                      select a).Single();
                            btnTinhOffset.Text = ll.LanhLieu + " " + ll.DonViTinh + " (" + vatLieuTextEdit.Text +
                                                 ") " +
                                                 " " + ll.QuyCach;
                        }
                        else
                        {
                            btnTinhOffset.Text = ll.LanhLieu + " " + ll.DonViTinh + " " + vatLieuTextEdit.Text;
                        }
                    }
                }
                else if (boPhanTextEdit.Text == temvai)
                {
                    //var vatlieu = (from s in db.VatLieu_4C() where s.TenHangHoa == vatLieuTextEdit.Text select s).ToList();
                    QuyCachTemVaiSearch.Properties.DataSource = vatlieu;
                    QuyCachTemVaiSearch.Properties.DisplayMember = "QuyCach";
                    QuyCachTemVaiSearch.Properties.ValueMember = "QuyCach";

                    xtraTabControl1.SelectedTabPage = tpTemVai;
                    var _kichthuoc = chieudai.Split('*');
                    txtChieuDai.Text = _kichthuoc[1];
                    if (ll.LanhLieu == null)
                    {
                        txtSLSXTemVai.Value = soLuongTextEdit.Value;
                        txtChieuDai.Text = _kichthuoc[1];

                        if (tenKhachHangTextEdit.Text == PrintRibbon.AD)
                        {
                            txtBuHaoTemVai.Value = (decimal)1.06;
                            foreach (var item in vatlieu)
                            {
                                QuyCachTemVaiSearch.Text = item.QuyCach;
                                break;
                            }

                        }
                        else
                        {
                            txtBuHaoTemVai.Value = (decimal)1.06;
                        }
                    }
                    else
                    {
                        if (ll.SoLuongSanXuat != null)
                            txtSLSXTemVai.Value = ll.SoLuongSanXuat.Value;
                        txtBuHaoTemVai.Text = ll.BuHao.ToString();
                        btnTinhTemVai.Text = ll.LanhLieu.ToString();
                        QuyCachTemVaiSearch.Text = ll.QuyCach;
                    }
                }
                else if (boPhanTextEdit.Text == danhthiep)
                {
                    xtraTabControl1.SelectedTabPage = tpDanhThiep;
                    if (ll.LanhLieu == null)
                    {
                        txtBuHaoDanhThiep.Text = "1.04";
                        txtSLDTDanhThiep.Value = 1;
                    }
                    else
                    {
                        txtSLSX_DanhThiep.Text = ll.SoLuongSanXuat.ToString();
                        txtSLDTDanhThiep.Text = ll.SoLuongDanTrang.ToString();
                        txtBuHaoDanhThiep.Text = ll.BuHao.ToString();
                        txtCTPDanhThiep.Text = ll.CtpOffset.ToString();
                        btnTinhDanhThiep.Text = ll.LanhLieu + " " + ll.DonViTinh;
                    }
                }
                else if (boPhanTextEdit.Text == sticker)
                {
                    //var vatlieu = (from s in db.VatLieu_4C() where s.TenHangHoa == vatLieuTextEdit.Text select s).ToList();
                    QuyCachStickerSearch.Properties.DataSource = vatlieu;
                    QuyCachStickerSearch.Properties.DisplayMember = "QuyCach";
                    QuyCachStickerSearch.Properties.ValueMember = "QuyCach";

                    xtraTabControl1.SelectedTabPage = tpSticker;
                    var chon = chieudai.Split('*');
                    if (radioGroup1.SelectedIndex == 0)
                    {
                        _dantrang = Math.Round(Convert.ToDouble(chon[0]), 0);
                        _tinhlieu = Math.Round(Convert.ToDouble(chon[1]), 0);
                    }
                    else
                    {
                        _dantrang = Math.Round(Convert.ToDouble(chon[1]), 0);
                        _tinhlieu = Math.Round(Convert.ToDouble(chon[0]), 0);
                    }
                    if (ll.LanhLieu == null)
                    {
                        txtBuHaoSticker.Text = "1.05";
                        txtSLDTSticker.Text = "2";
                    }
                    else
                    {
                        txtSLSXSticker.Text = ll.SoLuongSanXuat.ToString();
                        txtSLDTSticker.Text = ll.SoLuongDanTrang.ToString();
                        txtBuHaoSticker.Text = ll.BuHao.ToString();
                        btnTinhSticker.Text = ll.LanhLieu + " " + ll.DonViTinh;
                        QuyCachStickerSearch.Text = ll.QuyCach;
                    }

                }
                else if (boPhanTextEdit.Text == inchu)
                {
                    //var vatlieu = (from s in db.VatLieu_4C() where s.TenHangHoa == vatLieuTextEdit.Text select s).ToList();
                    QuyCachInChuSearch.Properties.DataSource = vatlieu;
                    QuyCachInChuSearch.Properties.DisplayMember = "QuyCach";
                    QuyCachInChuSearch.Properties.ValueMember = "QuyCach";
                    xtraTabControl1.SelectedTabPage = tpInChuViTinh;
                    var chon = chieudai.Split('*');
                    if (radioGroup2.SelectedIndex == 0)
                    {
                        _dantrang = Math.Round(Convert.ToDouble(chon[0]), 0);
                        _tinhlieu = Math.Round(Convert.ToDouble(chon[1]), 0);
                    }
                    else
                    {
                        _dantrang = Math.Round(Convert.ToDouble(chon[0]), 0);
                        _tinhlieu = Math.Round(Convert.ToDouble(chon[1]), 0);
                    }


                    if (ll.LanhLieu == null)
                    {
                        txtBuHaoInChu.Text = "1.03";
                        if (ll.LoaiSanPham == "TEM GIẤY")
                        {
                            txtSLSXInChu.BackColor = Color.LightGreen;
                            txtSLDTInChu.BackColor = Color.LightGreen;
                            txtBuHaoInChu.BackColor = Color.LightGreen;
                            txtSLDTInChu.Text = "1";

                        }
                        else if (ll.LoaiSanPham == "STICKER")
                        {
                            txtSLSXInChu.BackColor = Color.LightSalmon;
                            txtSLDTInChu.BackColor = Color.LightSalmon;
                            txtBuHaoInChu.BackColor = Color.LightSalmon;
                            radioGroup2.BackColor = Color.LightSalmon;
                            txtSLDTInChu.Text = "2";

                        }

                    }
                    else
                    {
                        txtSLSXInChu.Text = ll.SoLuongSanXuat.ToString();
                        txtSLDTInChu.Text = ll.SoLuongDanTrang.ToString();
                        txtBuHaoInChu.Text = ll.BuHao.ToString();
                        btnTinhInChu.Text = ll.LanhLieu + " " + ll.DonViTinh;
                        QuyCachInChuSearch.Text = ll.QuyCach;
                    }
                }
                else if (boPhanTextEdit.Text == sauin)
                {
                    xtraTabControl1.SelectedTabPage = tpSauIn;

                    txtKhoGiayInSauIn.Text = ll.KhoGiayIn;
                    txtCatGiaySauIn.Text = ll.CatGiay;
                    txtSLDTSauIn.Text = ll.SoLuongDanTrang.ToString();
                    txtSLSXSauIn.Text = ll.SoLuongSanXuat.ToString();
                    txtSLTISauIn.Text = ll.SoTrangIn;
                    txtBuHaoSauIn.Text = ll.BuHao.ToString();
                    var khoGiayIn = (from a in db.tbKhoGiayIns where a.KhoIn == txtKhoGiayInSauIn.Text && a.CatGiay == txtCatGiaySauIn.Text select a).Single();
                    btnTinhSauIn.Text = ll.LanhLieu + " " + ll.DonViTinh + " (" + ll.VatLieu + ") " + khoGiayIn.GiayLon;
                }
                else if (boPhanTextEdit.Text == kts)
                {
                    xtraTabControl1.SelectedTabPage = tpKyThuatSo;
                    if (ll.LanhLieu == null)
                    {
                        if (soLuongTextEdit.Value < 5000)
                            txtBuHaoKTS.Text = "3";
                        else
                            txtBuHaoKTS.Text = "5";
                    }
                    else
                    {
                        txtSLSXKyThuatSo.Text = ll.SoLuongSanXuat.ToString();
                        txtKhoGiayInKTS.Text = ll.KhoGiayIn;
                        txtBuHaoKTS.Text = ll.BuHao.ToString();
                        txtSoLuongSizeKTS.Text = ll.SoLuongSize.ToString();
                        txtSLDTKTS.Text = ll.SoLuongDanTrang.ToString();
                        btnTinhKTS.Text = ll.LanhLieu + " " + ll.DonViTinh + " " + ll.KhoGiayIn;
                    }

                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void Clear()
        {
            // offset
            //mauSacComboBox.Text = Empty;khoGiayInTextEdit.Text = Empty;
            CatGiayOffset.Text = Empty;
            soLuongDanTrangTextEdit.Text = Empty;
            SLSXOffset.Text = Empty;
            soTrangInTextEdit.Text = Empty;
            buHaoTextEdit.Text = Empty;
            ctpOffsetTextEdit.Text = Empty;
            btnTinhOffset.Text = Empty;

            // tem vải
            txtSLSXTemVai.Text = Empty;
            txtChieuDai.Text = Empty;
            btnTinhTemVai.Text = Empty;
            txtBuHaoTemVai.Text = Empty;
            // danh thiếp
            txtSLSX_DanhThiep.Text = Empty;
            txtSLDTDanhThiep.Text = Empty;
            txtBuHaoDanhThiep.Text = Empty;
            txtCTPDanhThiep.Text = Empty;
            btnTinhDanhThiep.Text = Empty;

            // sticker
            txtSLSXSticker.Text = Empty;
            txtSLDTSticker.Text = Empty;
            txtBuHaoSticker.Text = Empty;
            btnTinhSticker.Text = Empty;

            // in chữ
            txtSLSXInChu.Text = Empty;
            txtSLDTInChu.Text = Empty;
            txtBuHaoInChu.Text = Empty;
            btnTinhInChu.Text = Empty;

            // kỹ thuật số
            txtSLSXKyThuatSo.Text = Empty;
            txtKhoGiayInKTS.Text = Empty;
            txtBuHaoKTS.Text = Empty;
            txtSoLuongSizeKTS.Text = Empty;
            txtSLDTKTS.Text = Empty;
            btnTinhKTS.Text = Empty;

            // Sau In
            txtKhoGiayInSauIn.Text = Empty;
            txtCatGiaySauIn.Text = Empty;
            txtSLDTSauIn.Text = Empty;
            txtSLSXSauIn.Text = Empty;
            txtSLTISauIn.Text = Empty;
            txtBuHaoInChu.Text = Empty;
            btnTinhSauIn.Text = Empty;
        }

        private void btnTinhTemVai_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var db = new MyDBContextDataContext();
            //var lst = (from s in db.tbBuHaos select s).Single();
            if (boPhanTextEdit.Text == temvai)
            {
                if (tenKhachHangTextEdit.Text == AD)
                {
                    TinhTemVai = (int)((int)txtSLSXTemVai.Value * (int)(txtChieuDai.Value) * (double)txtBuHaoTemVai.Value * 1.0944 / 1000);
                    btnTinhTemVai.Text = TinhTemVai.ToString();
                }
                else
                {
                    //txtBuHaoTemVai.Value = (decimal)1.05;
                    TinhTemVai = (int)((int)txtSLSXTemVai.Value * (int)(txtChieuDai.Value) * (double)txtBuHaoTemVai.Value / 1000);
                    btnTinhTemVai.Text = TinhTemVai.ToString();
                }
            }
            else
            {
                MessageBox.Show("Bộ phận không đúng , vui lòng xem lại");
            }
        }

        private void btnTinhDanhThiep_Properties_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (boPhanTextEdit.Text == danhthiep)
            {
                TinhDanhThiep =
                    (int)Math.Round(txtSLSX_DanhThiep.Value * txtBuHaoDanhThiep.Value / txtSLDTDanhThiep.Value, 0);
                btnTinhDanhThiep.Text = TinhDanhThiep + " TẤM";
            }
        }

        private void buttonEdit2_Properties_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (loaiSanPhamTextEdit.Text == "TEM GIẤY")
            {
                TinhInChu = (int)Math.Round(txtSLSXInChu.Value * txtBuHaoInChu.Value / txtSLDTInChu.Value, 0);
                btnTinhInChu.Text = TinhInChu + " TẤM";
            }
            else if (loaiSanPhamTextEdit.Text == "STICKER")
            {
                TinhInChu = (int)Math.Round(txtSLSXInChu.Value * txtBuHaoInChu.Value * (Convert.ToInt32(_tinhlieu) + 3) / 1000 / txtSLDTInChu.Value, 0);
                btnTinhInChu.Text = TinhInChu + " MÉT";
            }
            else
            {
                MessageBox.Show("Loại sản phẩm không đúng , vui lòng xem lại đơn hàng");
            }
        }

        private void buttonEdit2_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (boPhanTextEdit.Text == sauin)
            {
                var s = txtCatGiaySauIn.Text;
                switch (s.Length)
                {
                    case 4:
                        s = s.Remove(3, 1);
                        break;
                    case 3:
                        s = s.Remove(2, 1);
                        break;
                    case 2:
                        s = s.Remove(1, 1);
                        break;
                }

                txtSLTISauIn.Enabled = false;
                if (txtSLSXSauIn.Value != 0)
                {
                    txtSLTISauIn.Text = Math.Round(txtSLSXSauIn.Value / txtSLDTSauIn.Value, 0) +
                                             "  (" + txtKhoGiayInSauIn.Text + ")";
                }
                TinhSauIn = (int)Math.Round((txtSLSXSauIn.Value / txtSLDTSauIn.Value + txtBuHaoSauIn.Value) / Convert.ToInt32(s), 0);

                var db = new MyDBContextDataContext();
                var kgi = (from a in db.tbKhoGiayIns where a.KhoIn == txtKhoGiayInSauIn.Text & a.CatGiay == txtCatGiaySauIn.Text select a).Single();
                btnTinhSauIn.Text = TinhSauIn + " TẤM (" + vatLieuTextEdit.Text + ") " + kgi.GiayLon;
            }
            else
            {
                MessageBox.Show("Bộ phận không đúng vui lòng xem lại đơn hàng");
            }
        }

        private void txtKhoGiayInSauIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbKhoGiayIns select s).ToList();
            foreach (var itemKhoGiayIn in lst)
            {
                if (itemKhoGiayIn.KhoIn != txtKhoGiayInSauIn.Text) continue;
                txtCatGiaySauIn.Text = itemKhoGiayIn.CatGiay;
            }
        }
        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chon = chieudai.Split('*');
            if (radioGroup2.SelectedIndex == 0)
            {
                _dantrang = Math.Round(Convert.ToDouble(chon[0]), 0);
                _tinhlieu = Math.Round(Convert.ToDouble(chon[1]), 0);
            }
            else
            {
                _dantrang = Math.Round(Convert.ToDouble(chon[1]), 0);
                _tinhlieu = Math.Round(Convert.ToDouble(chon[0]), 0);
            }
        }
        private double _tinhlieu, _dantrang;
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chon = chieudai.Split('*');
            if (radioGroup1.SelectedIndex == 0)
            {
                _dantrang = Math.Round(Convert.ToDouble(chon[0]), 0);
                _tinhlieu = Math.Round(Convert.ToDouble(chon[1]), 0);
            }
            else
            {
                _dantrang = Math.Round(Convert.ToDouble(chon[1]), 0);
                _tinhlieu = Math.Round(Convert.ToDouble(chon[0]), 0);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MyDBContextDataContext();
                var qldh = (from s in db.tbQuanLyDonHangs where s.IDQuanLyDonHang == sCDTextEdit.Text select s).Single();
                var dsx = (from s in db.tbDonSanXuats where s.SCD == sCDTextEdit.Text select s).Single();
                var ll = (from s in db.tbLanhLieus where s.IDLanhLieu == sCDTextEdit.Text select s).Single();
                var sanxuat = (from s in db.tbSanXuats where s.IDSanXuat == sCDTextEdit.Text select s).Single();
                if (qldh.HoanThanh == null)
                {
                    if (!string.IsNullOrEmpty(sanxuat.BoPhanSX))
                    {
                        dsx.BoPhan = sanxuat.BoPhanSX;
                        dsx.PhuongPhapIn = sanxuat.PhuongPhapInSX;
                    }
                    if (!string.IsNullOrEmpty(sanxuat.VatLieuSX))
                    {
                        dsx.VatLieu = sanxuat.VatLieuSX;
                        dsx.Kho = sanxuat.KhoSX;
                    }
                    if (dsx.BoPhan == offset)
                    {
                        var vatlieu = (from s in db.tbVatLieus
                                       where dsx.VatLieu == s.TenHangHoa && QuycachOffset.Text == s.QuyCach
                                       select s).ToList();
                        //if (vatlieu.Count == 1)
                        //{
                        ll.KhoGiayIn = KhoGiayInOffset.Text;
                        ll.CatGiay = CatGiayOffset.Text;
                        ll.SoLuongDanTrang = (int)soLuongDanTrangTextEdit.Value;
                        ll.SoLuongSanXuat = (int)SLSXOffset.Value;
                        ll.BuHao = (int)buHaoTextEdit.Value;
                        ll.CtpOffset = (int)ctpOffsetTextEdit.Value;
                        ll.SoTrangIn = soTrangInTextEdit.Text;
                        ll.LanhLieu = TinhOffset;
                        ll.DonViTinh = "TẤM";
                        ll.QuyCach = QuycachOffset.Text;
                        MessageBox.Show(themthanhcong);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Quy cách " + QuycachOffset.Text + " không đúng, không thêm đơn hàng");
                        //}
                        //var kgi = (from s in db.tbKhoGiayIns
                        //           where s.KhoIn == ll.KhoGiayIn && s.CatGiay == ll.CatGiay
                        //           select s).Single();
                        //ll.QuyCach = kgi.GiayLon;
                    }
                    else if (dsx.BoPhan == danhthiep)
                    {
                        ll.SoLuongSanXuat = (int)txtSLSX_DanhThiep.Value;
                        ll.SoLuongDanTrang = (int)txtSLDTDanhThiep.Value;
                        ll.BuHao = (double)(txtBuHaoDanhThiep.Value);
                        ll.CtpOffset = (int)txtCTPDanhThiep.Value;
                        ll.LanhLieu = TinhDanhThiep;
                        ll.DonViTinh = "TẤM";
                        MessageBox.Show(themthanhcong);
                    }
                    else if (dsx.BoPhan == temvai)
                    {
                        ll.SoLuongSanXuat = (int)txtSLSXTemVai.Value;
                        ll.BuHao = (double)txtBuHaoTemVai.Value;
                        ll.LanhLieu = Convert.ToInt32(btnTinhTemVai.Text);
                        ll.QuyCach = QuyCachTemVaiSearch.Text;
                        if (dsx.TenKhachHang == AD)
                        {
                            ll.DonViTinh = "YARD";
                        }
                        else
                        {
                            ll.DonViTinh = "MÉT";
                        }
                        MessageBox.Show(themthanhcong);
                    }
                    else if (dsx.BoPhan == kts)
                    {
                        ll.SoLuongSanXuat = (int)txtSLSXKyThuatSo.Value;
                        ll.SoLuongDanTrang = Convert.ToInt32(txtSLDTKTS.Value);
                        ll.BuHao = Convert.ToDouble(txtBuHaoKTS.Value);
                        ll.KhoGiayIn = txtKhoGiayInKTS.Text;
                        ll.SoLuongSize = Convert.ToInt32(txtSoLuongSizeKTS.Value);
                        ll.LanhLieu = TinhKyThuatSo;
                        ll.DonViTinh = "TẤM";
                        MessageBox.Show(themthanhcong);
                    }
                    else if (dsx.BoPhan == sticker)
                    {
                        ll.SoLuongSanXuat = (int)txtSLSXSticker.Value;
                        ll.SoLuongDanTrang = int.Parse(txtSLDTSticker.Text);
                        ll.BuHao = Convert.ToDouble(txtBuHaoSticker.Value);
                        ll.LanhLieu = TinhSticker;
                        ll.DonViTinh = "MÉT";
                        ll.QuyCach = QuyCachStickerSearch.Text;
                        MessageBox.Show(themthanhcong);
                    }
                    else if (dsx.BoPhan == inchu)
                    {
                        ll.SoLuongDanTrang = (int)txtSLDTInChu.Value;
                        ll.SoLuongSanXuat = (int)txtSLSXInChu.Value;
                        ll.BuHao = Convert.ToDouble(txtBuHaoInChu.Value);
                        ll.LanhLieu = TinhInChu;
                        if (dsx.LoaiSanPham == "TEM GIẤY")
                            ll.DonViTinh = "TẤM";
                        else if (dsx.LoaiSanPham == "STICKER")
                        {
                            ll.DonViTinh = "MÉT";
                            ll.QuyCach = QuyCachInChuSearch.Text;
                        }
                        MessageBox.Show(themthanhcong);
                    }

                    if (dsx.BoPhan == sauin)
                    {
                        ll.KhoGiayIn = txtKhoGiayInSauIn.Text;
                        ll.CatGiay = txtCatGiaySauIn.Text;
                        ll.SoLuongDanTrang = (int)txtSLDTSauIn.Value;
                        ll.SoLuongSanXuat = (int)txtSLSXSauIn.Value;
                        ll.BuHao = (int)txtBuHaoSauIn.Value;
                        ll.SoTrangIn = txtSLTISauIn.Text;
                        ll.LanhLieu = TinhSauIn;
                        ll.DonViTinh = "TẤM";
                        MessageBox.Show(themthanhcong);
                    }

                    ll.NhanVienSanXuat = nvObj.Tennhanvien;
                    db.SubmitChanges();
                    frmLanhLieu_Load_1(sender, e);
                }
                else
                {
                    MessageBox.Show("Đơn hàng đã hoàn thành ko thể chỉnh sửa");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi, liên hệ admin");
            }
        }

        private void btnTinh_Properties_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (boPhanTextEdit.Text == offset)
                {
                    var s = CatGiayOffset.Text;
                    switch (s.Length)
                    {
                        case 4:
                            s = s.Remove(3, 1);
                            break;
                        case 3:
                            s = s.Remove(2, 1);
                            break;
                        case 2:
                            s = s.Remove(1, 1);
                            break;
                    }

                    soTrangInTextEdit.Enabled = false;
                    Soluongtoin();
                    TinhOffset = (int)Math.Round(
                        (SLSXOffset.Value / soLuongDanTrangTextEdit.Value + buHaoTextEdit.Value) /
                        Convert.ToInt32(s), 0);
                    if (khoTextEdit.Text == nguyenvatlieu)
                    {
                        var db = new MyDBContextDataContext();
                        //var lst = (from a in db.tbKhoGiayIns where a.KhoIn == KhoGiayInOffset.Text && a.CatGiay == CatGiayOffset.Text select a).Single();
                        var lst = db.tbKhoGiayIns.ToList();
                        foreach (var tbKhoGiayIn in lst)
                        {
                            if (tbKhoGiayIn.KhoIn == KhoGiayInOffset.Text && tbKhoGiayIn.CatGiay == CatGiayOffset.Text)
                                btnTinhOffset.Text = TinhOffset + " TẤM (" + vatLieuTextEdit.Text + ") " + QuycachOffset.Text;
                        }

                    }
                    else
                        btnTinhOffset.Text = TinhOffset + " TẤM " + vatLieuTextEdit.Text + " " + KhoGiayInOffset.Text;
                }
                else
                {
                    MessageBox.Show("Bộ phận không đúng vui lòng xem lại đơn hàng");
                }
            }
            catch (Exception)
            {
                //null
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dt = _con.GetData("select * from tbDonSanXuat left join tbLanhLieu on tbDonSanXuat.SCD = tbLanhLieu.IDLanhLieu where SCD = '" + sCDTextEdit.Text + "'  ");
            var rp = new rpDonSanXuat(sCDTextEdit.Text)
            { DataSource = dt };
            rp.ShowRibbonPreview();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //DataTable dt;
            //dt = _con.GetData("select * from tbDonSanXuat left join tbLanhLieu on tbDonSanXuat.SCD = tbLanhLieu.IDLanhLieu where SCD = '" + sCDTextEdit.Text + "'  ");
            var rpt = new rpDonLanhLieu(sCDTextEdit.Text);
            var dt = llCtr.LoadDataIDLanhLieu(sCDTextEdit.Text);
            rpt.DataSource = dt;
            rpt.ShowRibbonPreviewDialog();
            //}
            //catch
            //{
            //    ignored
            //}
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            procDonSanXuat_ViewGridControl.ShowRibbonPrintPreview();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDate();
            frm.ShowDialog();
        }

        private void gridView4_Click(object sender, EventArgs e)
        {
        }

        private void btnTinhTemVai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCongDoanSanXuat frm = new frmCongDoanSanXuat();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var frm = new frmChiTietDonSanXuat(sCDTextEdit.Text);
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new frmDonSanXuat_Them(sCDTextEdit.Text, "0", nvObj);
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmThayDoiDonSanXuat(sCDTextEdit.Text);
            frm.ShowDialog();
            frmLanhLieu_Load_1(sender, e);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            if (checkEdit1.Checked == true)
            {
                procDonSanXuat_ViewGridControl.DataSource =
                    db.LoadData_DonSanXuat_LanhLieu_QuanLyDonHang_SanXuat_All().ToList();
                databing();
            }
            else
                frmLanhLieu_Load_1(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmLanhLieu_Load_1(sender, e);
        }

        private void khoGiayInTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            var db = new MyDBContextDataContext();
            var lst = (from s in db.tbKhoGiayIns select s).ToList();
            var vatlieu = db.tbVatLieus.ToList();
            foreach (var kgi in lst)
            {
                if (khoTextEdit.Text == nguyenvatlieu & kgi.KhoIn == KhoGiayInOffset.Text)
                {
                    CatGiayOffset.Text = kgi.CatGiay;
                    //QuycachOffset.Text = kgi.GiayLon;
                    //    var tong = 0;
                    //    foreach (var vl in vatlieu)
                    //    {
                    //        if (tenSanPhamTextEdit.Text == vl.TenHangHoa && QuycachOffset.Text == vl.QuyCach)
                    //        {
                    //            tong = 1;
                    //            break;
                    //        }
                    //    }
                    //    if(tong == 0)
                    //        MessageBox.Show("Quy cách " + QuycachOffset.Text + " không đúng, vui lòng xem lại");
                }
            }
        }

        private void soLuongDanTrangTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                soTrangInTextEdit.Text = Math.Round(SLSXOffset.Value / soLuongDanTrangTextEdit.Value, 0) +
                                         " TẤM (" + KhoGiayInOffset.Text + ")";
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void Soluongtoin()
        {
            if (SLSXOffset.Value != 0)
            {
                soTrangInTextEdit.Text = Math.Round(SLSXOffset.Value / soLuongDanTrangTextEdit.Value, 0) +
                                         " (" + KhoGiayInOffset.Text + ")";
            }
            else
            {
                MessageBox.Show("Chưa điền số lượng sản xuất");
            }
        }
    }
}