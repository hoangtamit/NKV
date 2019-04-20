namespace QuanLySanXuat.DonSanXuat
{
    partial class frmDonSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonSanXuat));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate formatConditionRuleUniqueDuplicate1 = new DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate formatConditionRuleUniqueDuplicate2 = new DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDateOccuring formatConditionRuleDateOccuring1 = new DevExpress.XtraEditors.FormatConditionRuleDateOccuring();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDateOccuring formatConditionRuleDateOccuring2 = new DevExpress.XtraEditors.FormatConditionRuleDateOccuring();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbHinhMatTrai = new DevExpress.XtraEditors.PictureEdit();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ptbHinhMatPhai = new DevExpress.XtraEditors.PictureEdit();
            this.ptbHinhKhuon = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.hiendonhang = new DevExpress.XtraEditors.CheckEdit();
            this.sCDLabel1 = new System.Windows.Forms.Label();
            this.tblTool = new System.Windows.Forms.TableLayoutPanel();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gcDonSanXuat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhienBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKichThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuongDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChinhSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHinhMatPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhMatTrai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhMatPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhKhuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiendonhang.Properties)).BeginInit();
            this.tblTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "SỐ LƯỢNG";
            this.colSoLuong.DisplayFormat.FormatString = "{0:#,#}";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "TỔNG = {0:#,#}")});
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 9;
            this.colSoLuong.Width = 76;
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
            // colMaDonHang
            // 
            this.colMaDonHang.Caption = "MÃ ĐƠN HÀNG";
            this.colMaDonHang.FieldName = "MaDonHang";
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.Visible = true;
            this.colMaDonHang.VisibleIndex = 1;
            this.colMaDonHang.Width = 86;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbHinhMatTrai);
            this.groupBox1.Controls.Add(this.splitter2);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Controls.Add(this.ptbHinhMatPhai);
            this.groupBox1.Controls.Add(this.ptbHinhKhuon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(953, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ptbHinhMatTrai
            // 
            this.ptbHinhMatTrai.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbHinhMatTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbHinhMatTrai.Location = new System.Drawing.Point(3, 264);
            this.ptbHinhMatTrai.Name = "ptbHinhMatTrai";
            this.ptbHinhMatTrai.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptbHinhMatTrai.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ptbHinhMatTrai.Size = new System.Drawing.Size(180, 0);
            this.ptbHinhMatTrai.TabIndex = 8;
            this.ptbHinhMatTrai.Click += new System.EventHandler(this.ptbHinhMatTrai_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(3, 255);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(180, 10);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 254);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(180, 10);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // ptbHinhMatPhai
            // 
            this.ptbHinhMatPhai.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbHinhMatPhai.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbHinhMatPhai.Location = new System.Drawing.Point(3, 17);
            this.ptbHinhMatPhai.Name = "ptbHinhMatPhai";
            this.ptbHinhMatPhai.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptbHinhMatPhai.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ptbHinhMatPhai.Size = new System.Drawing.Size(180, 237);
            this.ptbHinhMatPhai.TabIndex = 7;
            this.ptbHinhMatPhai.EditValueChanged += new System.EventHandler(this.ptbHinhMatPhai_EditValueChanged);
            this.ptbHinhMatPhai.Click += new System.EventHandler(this.ptbHinhMatPhai_Click);
            // 
            // ptbHinhKhuon
            // 
            this.ptbHinhKhuon.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbHinhKhuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ptbHinhKhuon.Location = new System.Drawing.Point(3, 265);
            this.ptbHinhKhuon.Name = "ptbHinhKhuon";
            this.ptbHinhKhuon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptbHinhKhuon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ptbHinhKhuon.Size = new System.Drawing.Size(180, 206);
            this.ptbHinhKhuon.TabIndex = 9;
            this.ptbHinhKhuon.EditValueChanged += new System.EventHandler(this.ptbHinhKhuon_EditValueChanged);
            this.ptbHinhKhuon.Click += new System.EventHandler(this.ptbHinhKhuon_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.hiendonhang);
            this.panelControl1.Controls.Add(this.sCDLabel1);
            this.panelControl1.Controls.Add(this.tblTool);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(953, 42);
            this.panelControl1.TabIndex = 1;
            // 
            // hiendonhang
            // 
            this.hiendonhang.Location = new System.Drawing.Point(673, 12);
            this.hiendonhang.Name = "hiendonhang";
            this.hiendonhang.Properties.Caption = "HIỆN TẤT CẢ ĐƠN HÀNG";
            this.hiendonhang.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.hiendonhang.Size = new System.Drawing.Size(152, 19);
            this.hiendonhang.TabIndex = 40;
            this.hiendonhang.CheckedChanged += new System.EventHandler(this.hiendonhang_CheckedChanged);
            // 
            // sCDLabel1
            // 
            this.sCDLabel1.Location = new System.Drawing.Point(822, 9);
            this.sCDLabel1.Name = "sCDLabel1";
            this.sCDLabel1.Size = new System.Drawing.Size(125, 28);
            this.sCDLabel1.TabIndex = 39;
            this.sCDLabel1.Text = "scd";
            // 
            // tblTool
            // 
            this.tblTool.ColumnCount = 7;
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2853F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tblTool.Controls.Add(this.btnXem, 0, 0);
            this.tblTool.Controls.Add(this.btnthem, 1, 0);
            this.tblTool.Controls.Add(this.btnXoa, 3, 0);
            this.tblTool.Controls.Add(this.btnsua, 2, 0);
            this.tblTool.Controls.Add(this.btnin, 4, 0);
            this.tblTool.Controls.Add(this.btnHuy, 5, 0);
            this.tblTool.Location = new System.Drawing.Point(5, 4);
            this.tblTool.Name = "tblTool";
            this.tblTool.RowCount = 1;
            this.tblTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTool.Size = new System.Drawing.Size(662, 35);
            this.tblTool.TabIndex = 38;
            // 
            // btnXem
            // 
            this.btnXem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(3, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(88, 29);
            this.btnXem.TabIndex = 41;
            this.btnXem.Text = "XEM";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnthem.Location = new System.Drawing.Point(97, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 29);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnXoa.Location = new System.Drawing.Point(285, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 29);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.ToolTipTitle = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsua.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnsua.Location = new System.Drawing.Point(191, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 29);
            this.btnsua.TabIndex = 30;
            this.btnsua.Text = "SỬA";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnin
            // 
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnin.Location = new System.Drawing.Point(379, 3);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(88, 29);
            this.btnin.TabIndex = 31;
            this.btnin.Text = "IN";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnHuy.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnHuy.Location = new System.Drawing.Point(473, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 29);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "LÀM MỚI";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(946, 42);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(7, 432);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // gcDonSanXuat
            // 
            this.gcDonSanXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDonSanXuat.Location = new System.Drawing.Point(0, 42);
            this.gcDonSanXuat.MainView = this.gridView1;
            this.gcDonSanXuat.Name = "gcDonSanXuat";
            this.gcDonSanXuat.Size = new System.Drawing.Size(946, 432);
            this.gcDonSanXuat.TabIndex = 3;
            this.gcDonSanXuat.UseEmbeddedNavigator = true;
            this.gcDonSanXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDonSanXuat.Click += new System.EventHandler(this.gcDonSanXuat_Click);
            this.gcDonSanXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcDonSanXuat_KeyDown);
            this.gcDonSanXuat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gcDonSanXuat_KeyDown);
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
            this.colChinhSua,
            this.colHinhMatPhai});
            gridFormatRule1.Column = this.colSoLuong;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.AxisColor = System.Drawing.Color.Aquamarine;
            formatConditionRuleDataBar1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            formatConditionRuleDataBar1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleDataBar1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            formatConditionRuleDataBar1.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleDataBar1.PredefinedName = "Blue";
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            gridFormatRule2.Column = this.colTenSanPham;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleUniqueDuplicate1.Appearance.BackColor = System.Drawing.Color.Yellow;
            formatConditionRuleUniqueDuplicate1.Appearance.Options.UseBackColor = true;
            gridFormatRule2.Rule = formatConditionRuleUniqueDuplicate1;
            gridFormatRule3.Column = this.colMaDonHang;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleUniqueDuplicate2.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            formatConditionRuleUniqueDuplicate2.Appearance.Options.UseBackColor = true;
            formatConditionRuleUniqueDuplicate2.PredefinedName = "Bold Text";
            gridFormatRule3.Rule = formatConditionRuleUniqueDuplicate2;
            gridFormatRule4.Column = this.colNgayGiaoHang;
            gridFormatRule4.Name = "Format3";
            formatConditionRuleDateOccuring1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleDateOccuring1.Appearance.Options.UseBackColor = true;
            formatConditionRuleDateOccuring1.DateType = DevExpress.XtraEditors.FilterDateType.Today;
            gridFormatRule4.Rule = formatConditionRuleDateOccuring1;
            gridFormatRule5.Column = this.colNgayGiaoHang;
            gridFormatRule5.Name = "Format4";
            formatConditionRuleDateOccuring2.Appearance.BackColor = System.Drawing.Color.LightSalmon;
            formatConditionRuleDateOccuring2.Appearance.Options.UseBackColor = true;
            gridFormatRule5.Rule = formatConditionRuleDateOccuring2;
            gridFormatRule6.Column = this.colNgayGiaoHang;
            gridFormatRule6.Name = "Format5";
            gridFormatRule6.Rule = formatConditionRuleExpression1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.FormatRules.Add(gridFormatRule4);
            this.gridView1.FormatRules.Add(gridFormatRule5);
            this.gridView1.FormatRules.Add(gridFormatRule6);
            this.gridView1.GridControl = this.gcDonSanXuat;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView1.OptionsPrint.AutoResetPrintDocument = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayXuongDon, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
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
            // colChinhSua
            // 
            this.colChinhSua.FieldName = "ChinhSua";
            this.colChinhSua.Name = "colChinhSua";
            // 
            // colHinhMatPhai
            // 
            this.colHinhMatPhai.Caption = "Hình Mặt Phải";
            this.colHinhMatPhai.FieldName = "HinhMatPhai";
            this.colHinhMatPhai.Name = "colHinhMatPhai";
            // 
            // frmDonSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 474);
            this.Controls.Add(this.gcDonSanXuat);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDonSanXuat";
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Text = "ĐƠN SẢN XUẤT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDonSanXuat_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhMatTrai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhMatPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhKhuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hiendonhang.Properties)).EndInit();
            this.tblTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDonSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tblTool;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private System.Windows.Forms.Label sCDLabel1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraEditors.CheckEdit hiendonhang;
        private DevExpress.XtraGrid.GridControl gcDonSanXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Splitter splitter2;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.PictureEdit ptbHinhMatTrai;
        private DevExpress.XtraEditors.PictureEdit ptbHinhMatPhai;
        private DevExpress.XtraEditors.PictureEdit ptbHinhKhuon;
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
        private DevExpress.XtraGrid.Columns.GridColumn colChinhSua;
        private DevExpress.XtraGrid.Columns.GridColumn colHinhMatPhai;
    }
}