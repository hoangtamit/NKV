namespace QuanLySanXuat
{
    partial class frmDonHangTemVaiAvery
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
            DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate formatConditionRuleUniqueDuplicate1 = new DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate formatConditionRuleUniqueDuplicate2 = new DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate formatConditionRuleUniqueDuplicate3 = new DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHangTemVaiAvery));
            this.colMaDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Ngayxuongdontxt = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKichThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuongDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXacNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXacNhan2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckXacNhan = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnThongTin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngayxuongdontxt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngayxuongdontxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.Caption = "Mã Đơn Hàng";
            this.colMaDonHang.FieldName = "MaDonHang";
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.Visible = true;
            this.colMaDonHang.VisibleIndex = 1;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.Caption = "Tên Sản Phẩm";
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.DisplayFormat.FormatString = "#,#";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "SUM={0:#,#}")});
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 11;
            // 
            // colSO
            // 
            this.colSO.Caption = "SO";
            this.colSO.FieldName = "SO";
            this.colSO.Name = "colSO";
            this.colSO.Visible = true;
            this.colSO.VisibleIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThongTin);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtDuongDan);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.btnLamMoi);
            this.panelControl1.Controls.Add(this.btnXacNhan);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.Ngayxuongdontxt);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1078, 54);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ĐƯỜNG DẪN:";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.EditValue = "Z:\\Nghiep Vu\\AVERY DENNISON\\2018\\2. PFL\\2. NEW ORDERS_NKV\'S PLATE\\2. ORDERS\\2019\\" +
    "30.26.01.2019";
            this.txtDuongDan.Location = new System.Drawing.Point(498, 28);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(571, 20);
            this.txtDuongDan.TabIndex = 8;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(741, 5);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(328, 20);
            this.textEdit1.TabIndex = 7;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(650, 5);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "HIỆN TẤT CẢ";
            this.checkEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkEdit1.Size = new System.Drawing.Size(97, 19);
            this.checkEdit1.TabIndex = 6;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(259, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(122, 44);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
            this.btnXacNhan.Location = new System.Drawing.Point(5, 5);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(120, 44);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NGÀY XUỐNG ĐƠN";
            // 
            // Ngayxuongdontxt
            // 
            this.Ngayxuongdontxt.EditValue = null;
            this.Ngayxuongdontxt.Location = new System.Drawing.Point(530, 5);
            this.Ngayxuongdontxt.Name = "Ngayxuongdontxt";
            this.Ngayxuongdontxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ngayxuongdontxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ngayxuongdontxt.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.Ngayxuongdontxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Ngayxuongdontxt.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.Ngayxuongdontxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Ngayxuongdontxt.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.Ngayxuongdontxt.Size = new System.Drawing.Size(114, 20);
            this.Ngayxuongdontxt.TabIndex = 2;
            this.Ngayxuongdontxt.EditValueChanged += new System.EventHandler(this.Ngayxuongdontxt_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CheckXacNhan});
            this.gridControl1.Size = new System.Drawing.Size(914, 616);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSCD,
            this.colMaDonHang,
            this.colTenKhachHang,
            this.colTenSanPham,
            this.colKichThuoc,
            this.colBoPhan,
            this.colNgayXuongDon,
            this.colSoLuong,
            this.colItem,
            this.colSO,
            this.colXacNhan,
            this.colSKU,
            this.colSTT,
            this.colDanhSach,
            this.colXacNhan2,
            this.colGhiChu});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colMaDonHang;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleUniqueDuplicate1.Appearance.BackColor = System.Drawing.Color.Tomato;
            formatConditionRuleUniqueDuplicate1.Appearance.Options.UseBackColor = true;
            gridFormatRule1.Rule = formatConditionRuleUniqueDuplicate1;
            gridFormatRule2.Column = this.colTenSanPham;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleUniqueDuplicate2.Appearance.BackColor = System.Drawing.Color.Yellow;
            formatConditionRuleUniqueDuplicate2.Appearance.Options.UseBackColor = true;
            gridFormatRule2.Rule = formatConditionRuleUniqueDuplicate2;
            gridFormatRule3.Column = this.colSoLuong;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.LightGreen;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.GreaterOrEqual;
            formatConditionRuleValue1.Value1 = 10000;
            gridFormatRule3.Rule = formatConditionRuleValue1;
            gridFormatRule4.Column = this.colSO;
            gridFormatRule4.Name = "Format5";
            formatConditionRuleUniqueDuplicate3.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleUniqueDuplicate3.Appearance.Options.UseBackColor = true;
            gridFormatRule4.Rule = formatConditionRuleUniqueDuplicate3;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.FormatRules.Add(gridFormatRule4);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colSCD
            // 
            this.colSCD.Caption = "SCD";
            this.colSCD.FieldName = "SCD";
            this.colSCD.Name = "colSCD";
            this.colSCD.Visible = true;
            this.colSCD.VisibleIndex = 0;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "Tên Khách Hàng";
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            // 
            // colKichThuoc
            // 
            this.colKichThuoc.Caption = "Kích Thước";
            this.colKichThuoc.FieldName = "KichThuoc";
            this.colKichThuoc.Name = "colKichThuoc";
            this.colKichThuoc.Visible = true;
            this.colKichThuoc.VisibleIndex = 2;
            // 
            // colBoPhan
            // 
            this.colBoPhan.Caption = "Bộ Phận";
            this.colBoPhan.FieldName = "BoPhan";
            this.colBoPhan.Name = "colBoPhan";
            // 
            // colNgayXuongDon
            // 
            this.colNgayXuongDon.Caption = "Ngày Xuống Đơn";
            this.colNgayXuongDon.FieldName = "NgayXuongDon";
            this.colNgayXuongDon.Name = "colNgayXuongDon";
            this.colNgayXuongDon.Visible = true;
            this.colNgayXuongDon.VisibleIndex = 3;
            // 
            // colItem
            // 
            this.colItem.Caption = "Item";
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 5;
            // 
            // colXacNhan
            // 
            this.colXacNhan.Caption = "Xác Nhận";
            this.colXacNhan.FieldName = "XacNhan";
            this.colXacNhan.Name = "colXacNhan";
            this.colXacNhan.Visible = true;
            this.colXacNhan.VisibleIndex = 10;
            // 
            // colSKU
            // 
            this.colSKU.Caption = "SKU";
            this.colSKU.FieldName = "SKU";
            this.colSKU.Name = "colSKU";
            this.colSKU.Visible = true;
            this.colSKU.VisibleIndex = 7;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "Gộp Đơn";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 8;
            // 
            // colDanhSach
            // 
            this.colDanhSach.Caption = "Danh Sách";
            this.colDanhSach.FieldName = "DanhSach";
            this.colDanhSach.Name = "colDanhSach";
            this.colDanhSach.Visible = true;
            this.colDanhSach.VisibleIndex = 9;
            // 
            // colXacNhan2
            // 
            this.colXacNhan2.Caption = "Xác Nhận 3";
            this.colXacNhan2.FieldName = "XacNhan2";
            this.colXacNhan2.Name = "colXacNhan2";
            // 
            // CheckXacNhan
            // 
            this.CheckXacNhan.AutoHeight = false;
            this.CheckXacNhan.Name = "CheckXacNhan";
            this.CheckXacNhan.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.CheckXacNhan.ValueChecked = "True";
            this.CheckXacNhan.ValueUnchecked = "False";
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Location = new System.Drawing.Point(917, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(161, 616);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kích thước";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời gian";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(914, 54);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 616);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // btnThongTin
            // 
            this.btnThongTin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnThongTin.Location = new System.Drawing.Point(131, 4);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(122, 44);
            this.btnThongTin.TabIndex = 10;
            this.btnThongTin.Text = "THÔNG TIN";
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // frmDonHangTemVaiAvery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 670);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDonHangTemVaiAvery";
            this.Text = "frmDonHangTemVaiAvery";
            this.Load += new System.EventHandler(this.frmDonHangTemVaiAvery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngayxuongdontxt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngayxuongdontxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckXacNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit Ngayxuongdontxt;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colSCD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colXacNhan;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckXacNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colKichThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colBoPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuongDon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colSO;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colXacNhan2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnThongTin;
    }
}