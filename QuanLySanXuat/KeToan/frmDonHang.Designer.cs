namespace QuanLySanXuat
{
    partial class frmDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang));
            this.VATCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tbDonSanXuatGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhienBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKichThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuongDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGiaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGiaKhuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGiaMau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGiaVanChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgoaiTe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhanTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien_nghiepvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChinhSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colketchuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ptbHinhMatTrai = new System.Windows.Forms.PictureBox();
            this.ptbHinhMatPhai = new System.Windows.Forms.PictureBox();
            this.ptbHinhKhuon = new System.Windows.Forms.PictureBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.hiendonhang = new DevExpress.XtraEditors.CheckEdit();
            this.tblTool = new System.Windows.Forms.TableLayoutPanel();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.sCDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VATCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDonSanXuatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhMatTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhMatPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhKhuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiendonhang.Properties)).BeginInit();
            this.tblTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // VATCheck
            // 
            this.VATCheck.AutoHeight = false;
            this.VATCheck.LookAndFeel.SkinName = "Liquid Sky";
            this.VATCheck.Name = "VATCheck";
            this.VATCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.VATCheck.ValueChecked = 1.1D;
            // 
            // tbDonSanXuatGridControl
            // 
            this.tbDonSanXuatGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDonSanXuatGridControl.Location = new System.Drawing.Point(0, 0);
            this.tbDonSanXuatGridControl.MainView = this.gridView1;
            this.tbDonSanXuatGridControl.Name = "tbDonSanXuatGridControl";
            this.tbDonSanXuatGridControl.Size = new System.Drawing.Size(923, 523);
            this.tbDonSanXuatGridControl.TabIndex = 1;
            this.tbDonSanXuatGridControl.UseEmbeddedNavigator = true;
            this.tbDonSanXuatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.tbDonSanXuatGridControl.Click += new System.EventHandler(this.tbDonSanXuatGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSCD,
            this.colMaDonHang,
            this.colPhienBan,
            this.colTenKhachHang,
            this.colTenSanPham,
            this.colKichThuoc,
            this.colBoPhan,
            this.colNgayXuongDon,
            this.colNgayGiaoHang,
            this.colSoLuong,
            this.colLoaiSanPham,
            this.colVatLieu,
            this.colDonGiaSanPham,
            this.colDonGiaKhuon,
            this.colDonGiaMau,
            this.colDonGiaVanChuyen,
            this.colVAT,
            this.colTongTien,
            this.colNgoaiTe,
            this.colNgayNhanTien,
            this.colNhanVien_nghiepvu,
            this.colChinhSua,
            this.colketchuyen});
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.AllowNegativeAxis = false;
            formatConditionRuleDataBar1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            formatConditionRuleDataBar1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleDataBar1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            formatConditionRuleDataBar1.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleDataBar1.PredefinedName = "Coral Gradient";
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.tbDonSanXuatGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.AutoResetPrintDocument = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colSCD
            // 
            this.colSCD.Caption = "SCD";
            this.colSCD.FieldName = "SCD";
            this.colSCD.Name = "colSCD";
            this.colSCD.Visible = true;
            this.colSCD.VisibleIndex = 0;
            this.colSCD.Width = 97;
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.Caption = "MÃ ĐƠN HÀNG";
            this.colMaDonHang.FieldName = "MaDonHang";
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.Visible = true;
            this.colMaDonHang.VisibleIndex = 1;
            this.colMaDonHang.Width = 86;
            // 
            // colPhienBan
            // 
            this.colPhienBan.Caption = "PHIÊN BẢN";
            this.colPhienBan.FieldName = "PhienBan";
            this.colPhienBan.Name = "colPhienBan";
            this.colPhienBan.Visible = true;
            this.colPhienBan.VisibleIndex = 2;
            this.colPhienBan.Width = 76;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "TÊN KHÁCH HÀNG";
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 3;
            this.colTenKhachHang.Width = 98;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.Caption = "TÊN SẢN PHẨM";
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 4;
            this.colTenSanPham.Width = 88;
            // 
            // colKichThuoc
            // 
            this.colKichThuoc.Caption = "KÍCH THƯỚC";
            this.colKichThuoc.FieldName = "KichThuoc";
            this.colKichThuoc.Name = "colKichThuoc";
            this.colKichThuoc.Visible = true;
            this.colKichThuoc.VisibleIndex = 5;
            this.colKichThuoc.Width = 76;
            // 
            // colBoPhan
            // 
            this.colBoPhan.Caption = "BỘ PHẬN";
            this.colBoPhan.FieldName = "BoPhan";
            this.colBoPhan.Name = "colBoPhan";
            this.colBoPhan.Visible = true;
            this.colBoPhan.VisibleIndex = 6;
            this.colBoPhan.Width = 76;
            // 
            // colNgayXuongDon
            // 
            this.colNgayXuongDon.Caption = "NGÀY XUỐNG ĐƠN";
            this.colNgayXuongDon.FieldName = "NgayXuongDon";
            this.colNgayXuongDon.Name = "colNgayXuongDon";
            this.colNgayXuongDon.Visible = true;
            this.colNgayXuongDon.VisibleIndex = 7;
            this.colNgayXuongDon.Width = 100;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.Caption = "NGÀY GIAO HÀNG";
            this.colNgayGiaoHang.FieldName = "NgayGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.Visible = true;
            this.colNgayGiaoHang.VisibleIndex = 8;
            this.colNgayGiaoHang.Width = 97;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "SỐ LƯỢNG";
            this.colSoLuong.DisplayFormat.FormatString = "{0:#,#}";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "SUM={0:#,0.#######}")});
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 9;
            this.colSoLuong.Width = 76;
            // 
            // colLoaiSanPham
            // 
            this.colLoaiSanPham.Caption = "LOẠI SẢN PHẨM";
            this.colLoaiSanPham.FieldName = "LoaiSanPham";
            this.colLoaiSanPham.Name = "colLoaiSanPham";
            this.colLoaiSanPham.Visible = true;
            this.colLoaiSanPham.VisibleIndex = 10;
            this.colLoaiSanPham.Width = 89;
            // 
            // colVatLieu
            // 
            this.colVatLieu.Caption = "VẬT LIỆU";
            this.colVatLieu.FieldName = "VatLieu";
            this.colVatLieu.Name = "colVatLieu";
            this.colVatLieu.Visible = true;
            this.colVatLieu.VisibleIndex = 11;
            this.colVatLieu.Width = 76;
            // 
            // colDonGiaSanPham
            // 
            this.colDonGiaSanPham.Caption = "ĐƠN GIÁ SẢN PHẨM";
            this.colDonGiaSanPham.DisplayFormat.FormatString = "{#,#.#######}";
            this.colDonGiaSanPham.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGiaSanPham.FieldName = "DonGiaSanPham";
            this.colDonGiaSanPham.Name = "colDonGiaSanPham";
            this.colDonGiaSanPham.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DonGiaSanPham", "SUM={0:#,0.#######}")});
            this.colDonGiaSanPham.Visible = true;
            this.colDonGiaSanPham.VisibleIndex = 12;
            this.colDonGiaSanPham.Width = 107;
            // 
            // colDonGiaKhuon
            // 
            this.colDonGiaKhuon.Caption = "ĐƠN GIÁ KHUÔN";
            this.colDonGiaKhuon.DisplayFormat.FormatString = "{0:#,#.#######}";
            this.colDonGiaKhuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGiaKhuon.FieldName = "DonGiaKhuon";
            this.colDonGiaKhuon.Name = "colDonGiaKhuon";
            this.colDonGiaKhuon.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DonGiaKhuon", "SUM={0:#,0.#######}")});
            this.colDonGiaKhuon.Visible = true;
            this.colDonGiaKhuon.VisibleIndex = 13;
            this.colDonGiaKhuon.Width = 90;
            // 
            // colDonGiaMau
            // 
            this.colDonGiaMau.Caption = "ĐƠN GIÁ MẪU";
            this.colDonGiaMau.DisplayFormat.FormatString = "{0:#,#.#######}";
            this.colDonGiaMau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGiaMau.FieldName = "DonGiaMau";
            this.colDonGiaMau.Name = "colDonGiaMau";
            this.colDonGiaMau.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DonGiaMau", "SUM={0:#,0.#######}")});
            this.colDonGiaMau.Visible = true;
            this.colDonGiaMau.VisibleIndex = 14;
            this.colDonGiaMau.Width = 80;
            // 
            // colDonGiaVanChuyen
            // 
            this.colDonGiaVanChuyen.Caption = "ĐƠN GIÁ VẬN CHUYỂN";
            this.colDonGiaVanChuyen.DisplayFormat.FormatString = "{0:#,#.#######}";
            this.colDonGiaVanChuyen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGiaVanChuyen.FieldName = "DonGiaVanChuyen";
            this.colDonGiaVanChuyen.Name = "colDonGiaVanChuyen";
            this.colDonGiaVanChuyen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DonGiaVanChuyen", "SUM={0:#,0.#######}")});
            this.colDonGiaVanChuyen.Visible = true;
            this.colDonGiaVanChuyen.VisibleIndex = 15;
            this.colDonGiaVanChuyen.Width = 118;
            // 
            // colVAT
            // 
            this.colVAT.ColumnEdit = this.VATCheck;
            this.colVAT.FieldName = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 16;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "TỔNG TIỀN";
            this.colTongTien.DisplayFormat.FormatString = "{0:#,0.#######}";
            this.colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTien", "SUM={0:#,0.#######}")});
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 17;
            this.colTongTien.Width = 76;
            // 
            // colNgoaiTe
            // 
            this.colNgoaiTe.Caption = "NGOẠI TỆ";
            this.colNgoaiTe.FieldName = "NgoaiTe";
            this.colNgoaiTe.Name = "colNgoaiTe";
            this.colNgoaiTe.Visible = true;
            this.colNgoaiTe.VisibleIndex = 18;
            this.colNgoaiTe.Width = 76;
            // 
            // colNgayNhanTien
            // 
            this.colNgayNhanTien.Caption = "NGÀY NHẬN TIỀN";
            this.colNgayNhanTien.FieldName = "NgayNhanTien";
            this.colNgayNhanTien.Name = "colNgayNhanTien";
            this.colNgayNhanTien.Visible = true;
            this.colNgayNhanTien.VisibleIndex = 20;
            // 
            // colNhanVien_nghiepvu
            // 
            this.colNhanVien_nghiepvu.Caption = "NHÂN VIÊN NGHIỆP VỤ";
            this.colNhanVien_nghiepvu.FieldName = "NhanVien_nghiepvu";
            this.colNhanVien_nghiepvu.Name = "colNhanVien_nghiepvu";
            this.colNhanVien_nghiepvu.Visible = true;
            this.colNhanVien_nghiepvu.VisibleIndex = 19;
            this.colNhanVien_nghiepvu.Width = 119;
            // 
            // colChinhSua
            // 
            this.colChinhSua.Caption = "CHỈNH SỬA";
            this.colChinhSua.FieldName = "ChinhSua";
            this.colChinhSua.Name = "colChinhSua";
            this.colChinhSua.Width = 76;
            // 
            // colketchuyen
            // 
            this.colketchuyen.Caption = "KẾT CHUYỂN";
            this.colketchuyen.FieldName = "ketchuyen";
            this.colketchuyen.Name = "colketchuyen";
            this.colketchuyen.Width = 76;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitter2);
            this.panelControl1.Controls.Add(this.splitter1);
            this.panelControl1.Controls.Add(this.ptbHinhMatTrai);
            this.panelControl1.Controls.Add(this.ptbHinhMatPhai);
            this.panelControl1.Controls.Add(this.ptbHinhKhuon);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(923, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 523);
            this.panelControl1.TabIndex = 4;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(2, 342);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(196, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(2, 213);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(196, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // ptbHinhMatTrai
            // 
            this.ptbHinhMatTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbHinhMatTrai.Location = new System.Drawing.Point(2, 213);
            this.ptbHinhMatTrai.Name = "ptbHinhMatTrai";
            this.ptbHinhMatTrai.Padding = new System.Windows.Forms.Padding(5);
            this.ptbHinhMatTrai.Size = new System.Drawing.Size(196, 132);
            this.ptbHinhMatTrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHinhMatTrai.TabIndex = 1;
            this.ptbHinhMatTrai.TabStop = false;
            this.ptbHinhMatTrai.Click += new System.EventHandler(this.ptbHinhMatTrai_Click);
            // 
            // ptbHinhMatPhai
            // 
            this.ptbHinhMatPhai.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbHinhMatPhai.Location = new System.Drawing.Point(2, 2);
            this.ptbHinhMatPhai.MinimumSize = new System.Drawing.Size(0, 150);
            this.ptbHinhMatPhai.Name = "ptbHinhMatPhai";
            this.ptbHinhMatPhai.Padding = new System.Windows.Forms.Padding(5);
            this.ptbHinhMatPhai.Size = new System.Drawing.Size(196, 211);
            this.ptbHinhMatPhai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbHinhMatPhai.TabIndex = 0;
            this.ptbHinhMatPhai.TabStop = false;
            this.ptbHinhMatPhai.Click += new System.EventHandler(this.ptbHinhMatPhai_Click);
            // 
            // ptbHinhKhuon
            // 
            this.ptbHinhKhuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ptbHinhKhuon.Location = new System.Drawing.Point(2, 345);
            this.ptbHinhKhuon.Name = "ptbHinhKhuon";
            this.ptbHinhKhuon.Size = new System.Drawing.Size(196, 176);
            this.ptbHinhKhuon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHinhKhuon.TabIndex = 3;
            this.ptbHinhKhuon.TabStop = false;
            this.ptbHinhKhuon.Click += new System.EventHandler(this.ptbHinhKhuon_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.hiendonhang);
            this.panelControl2.Controls.Add(this.tblTool);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(923, 42);
            this.panelControl2.TabIndex = 6;
            // 
            // hiendonhang
            // 
            this.hiendonhang.Location = new System.Drawing.Point(360, 12);
            this.hiendonhang.Name = "hiendonhang";
            this.hiendonhang.Properties.Caption = "HIỆN TẤT CẢ ĐƠN HÀNG";
            this.hiendonhang.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.hiendonhang.Size = new System.Drawing.Size(152, 19);
            this.hiendonhang.TabIndex = 40;
            // 
            // tblTool
            // 
            this.tblTool.ColumnCount = 3;
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblTool.Controls.Add(this.btnXem, 0, 0);
            this.tblTool.Controls.Add(this.btnin, 1, 0);
            this.tblTool.Controls.Add(this.btnHuy, 2, 0);
            this.tblTool.Location = new System.Drawing.Point(5, 4);
            this.tblTool.Name = "tblTool";
            this.tblTool.RowCount = 1;
            this.tblTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTool.Size = new System.Drawing.Size(349, 35);
            this.tblTool.TabIndex = 38;
            // 
            // btnXem
            // 
            this.btnXem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(3, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(114, 29);
            this.btnXem.TabIndex = 41;
            this.btnXem.Text = "Xác Nhận";
            // 
            // btnin
            // 
            this.btnin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnin.Location = new System.Drawing.Point(123, 3);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(108, 29);
            this.btnin.TabIndex = 31;
            this.btnin.Text = "IN";
            // 
            // btnHuy
            // 
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnHuy.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnHuy.Location = new System.Drawing.Point(237, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 29);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "LÀM MỚI";
            // 
            // sCDLabel1
            // 
            this.sCDLabel1.Location = new System.Drawing.Point(566, 106);
            this.sCDLabel1.Name = "sCDLabel1";
            this.sCDLabel1.Size = new System.Drawing.Size(103, 28);
            this.sCDLabel1.TabIndex = 39;
            this.sCDLabel1.Text = "scd";
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 523);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.tbDonSanXuatGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.sCDLabel1);
            this.Name = "frmDonHang";
            this.Text = "ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VATCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDonSanXuatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhMatTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhMatPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhKhuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hiendonhang.Properties)).EndInit();
            this.tblTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl tbDonSanXuatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox ptbHinhMatTrai;
        private System.Windows.Forms.PictureBox ptbHinhMatPhai;
        private System.Windows.Forms.PictureBox ptbHinhKhuon;
        private DevExpress.XtraGrid.Columns.GridColumn colSCD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colPhienBan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colKichThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colBoPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuongDon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colVatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGiaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGiaKhuon;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGiaMau;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGiaVanChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgoaiTe;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien_nghiepvu;
        private DevExpress.XtraGrid.Columns.GridColumn colChinhSua;
        private DevExpress.XtraGrid.Columns.GridColumn colketchuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhanTien;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit hiendonhang;
        private System.Windows.Forms.Label sCDLabel1;
        private System.Windows.Forms.TableLayoutPanel tblTool;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit VATCheck;
    }
}