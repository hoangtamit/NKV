namespace QuanLySanXuat
{
    partial class frmTemVaiAvery
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemVaiAvery));
            this.Ngayxuongdontxt = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.procDonSanXuat_ViewGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuongDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKichThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuHao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanhLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiDonSanXuat = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDonLanhLieu = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtDanhSach = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChoThem = new DevExpress.XtraEditors.SpinEdit();
            this.txtBuHao = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LamMoitxt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Ngayxuongdontxt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngayxuongdontxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procDonSanXuat_ViewGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDanhSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoThem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuHao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Ngayxuongdontxt
            // 
            this.Ngayxuongdontxt.EditValue = null;
            this.Ngayxuongdontxt.Location = new System.Drawing.Point(116, 10);
            this.Ngayxuongdontxt.Name = "Ngayxuongdontxt";
            this.Ngayxuongdontxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ngayxuongdontxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ngayxuongdontxt.Size = new System.Drawing.Size(114, 20);
            this.Ngayxuongdontxt.TabIndex = 0;
            this.Ngayxuongdontxt.EditValueChanged += new System.EventHandler(this.Ngayxuongdontxt_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NGÀY XUỐNG ĐƠN";
            // 
            // btnTinh
            // 
            this.btnTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTinh.ImageOptions.Image")));
            this.btnTinh.Location = new System.Drawing.Point(12, 34);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(109, 37);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "TÍNH";
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBox1.Location = new System.Drawing.Point(745, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(354, 68);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Lưu ý:\n       Công thức này chỉ tính cho đơn hàng tem vải của Avery\n       Ngày x" +
    "uống đơn sẽ  một hoặc nhiều danh sách\n       Chọn ngày xuống đơn và Danh sách tr" +
    "ước khi tính và in\n";
            // 
            // procDonSanXuat_ViewGridControl
            // 
            this.procDonSanXuat_ViewGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procDonSanXuat_ViewGridControl.Location = new System.Drawing.Point(0, 77);
            this.procDonSanXuat_ViewGridControl.MainView = this.gridView1;
            this.procDonSanXuat_ViewGridControl.Name = "procDonSanXuat_ViewGridControl";
            this.procDonSanXuat_ViewGridControl.Size = new System.Drawing.Size(1104, 473);
            this.procDonSanXuat_ViewGridControl.TabIndex = 29;
            this.procDonSanXuat_ViewGridControl.UseEmbeddedNavigator = true;
            this.procDonSanXuat_ViewGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSCD,
            this.colMaDonHang,
            this.colNgayXuongDon,
            this.colNgayGiaoHang,
            this.colSoLuong,
            this.colTenKhachHang,
            this.colBoPhan,
            this.colTenSanPham,
            this.colKichThuoc,
            this.colSKU,
            this.colSoLuongSanXuat,
            this.colBuHao,
            this.colLanhLieu,
            this.colDonViTinh,
            this.colQuyCach});
            this.gridView1.GridControl = this.procDonSanXuat_ViewGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayXuongDon, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colSCD
            // 
            this.colSCD.FieldName = "SCD";
            this.colSCD.Name = "colSCD";
            this.colSCD.Visible = true;
            this.colSCD.VisibleIndex = 0;
            this.colSCD.Width = 111;
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.FieldName = "MaDonHang";
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.Visible = true;
            this.colMaDonHang.VisibleIndex = 1;
            this.colMaDonHang.Width = 98;
            // 
            // colNgayXuongDon
            // 
            this.colNgayXuongDon.FieldName = "NgayXuongDon";
            this.colNgayXuongDon.Name = "colNgayXuongDon";
            this.colNgayXuongDon.Visible = true;
            this.colNgayXuongDon.VisibleIndex = 2;
            this.colNgayXuongDon.Width = 91;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.FieldName = "NgayGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.Visible = true;
            this.colNgayGiaoHang.VisibleIndex = 3;
            this.colNgayGiaoHang.Width = 91;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DisplayFormat.FormatString = "{0:0,##}";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "TỔNG = {0:0,##}")});
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            this.colSoLuong.Width = 66;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 5;
            this.colTenKhachHang.Width = 97;
            // 
            // colBoPhan
            // 
            this.colBoPhan.FieldName = "BoPhan";
            this.colBoPhan.Name = "colBoPhan";
            this.colBoPhan.Visible = true;
            this.colBoPhan.VisibleIndex = 8;
            this.colBoPhan.Width = 74;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 6;
            this.colTenSanPham.Width = 81;
            // 
            // colKichThuoc
            // 
            this.colKichThuoc.FieldName = "KichThuoc";
            this.colKichThuoc.Name = "colKichThuoc";
            this.colKichThuoc.Visible = true;
            this.colKichThuoc.VisibleIndex = 7;
            this.colKichThuoc.Width = 63;
            // 
            // colSKU
            // 
            this.colSKU.Caption = "SKU";
            this.colSKU.FieldName = "SKU";
            this.colSKU.Name = "colSKU";
            this.colSKU.Visible = true;
            this.colSKU.VisibleIndex = 13;
            // 
            // colSoLuongSanXuat
            // 
            this.colSoLuongSanXuat.FieldName = "SoLuongSanXuat";
            this.colSoLuongSanXuat.Name = "colSoLuongSanXuat";
            this.colSoLuongSanXuat.Visible = true;
            this.colSoLuongSanXuat.VisibleIndex = 9;
            this.colSoLuongSanXuat.Width = 97;
            // 
            // colBuHao
            // 
            this.colBuHao.FieldName = "BuHao";
            this.colBuHao.Name = "colBuHao";
            this.colBuHao.Visible = true;
            this.colBuHao.VisibleIndex = 10;
            this.colBuHao.Width = 62;
            // 
            // colLanhLieu
            // 
            this.colLanhLieu.FieldName = "LanhLieu";
            this.colLanhLieu.Name = "colLanhLieu";
            this.colLanhLieu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LanhLieu", "TỔNG = {0:0.##}")});
            this.colLanhLieu.Visible = true;
            this.colLanhLieu.VisibleIndex = 11;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn Vị Tính";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 12;
            // 
            // colQuyCach
            // 
            this.colQuyCach.Caption = "Quy Cách";
            this.colQuyCach.FieldName = "QuyCach";
            this.colQuyCach.Name = "colQuyCach";
            this.colQuyCach.Visible = true;
            this.colQuyCach.VisibleIndex = 14;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dropDownButton1);
            this.panelControl1.Controls.Add(this.txtDanhSach);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtChoThem);
            this.panelControl1.Controls.Add(this.txtBuHao);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.LamMoitxt);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.Ngayxuongdontxt);
            this.panelControl1.Controls.Add(this.richTextBox1);
            this.panelControl1.Controls.Add(this.btnTinh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1104, 77);
            this.panelControl1.TabIndex = 30;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.Location = new System.Drawing.Point(127, 34);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(135, 37);
            this.dropDownButton1.TabIndex = 36;
            this.dropDownButton1.Text = "IN DANH SÁCH";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDonSanXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDonLanhLieu)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bbiDonSanXuat
            // 
            this.bbiDonSanXuat.Caption = "ĐƠN SẢN XUẤT";
            this.bbiDonSanXuat.Id = 0;
            this.bbiDonSanXuat.Name = "bbiDonSanXuat";
            this.bbiDonSanXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDonSanXuat_ItemClick);
            // 
            // bbiDonLanhLieu
            // 
            this.bbiDonLanhLieu.Caption = "ĐƠN LÃNH LIỆU";
            this.bbiDonLanhLieu.Id = 1;
            this.bbiDonLanhLieu.Name = "bbiDonLanhLieu";
            this.bbiDonLanhLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDonLanhLieu_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiDonSanXuat,
            this.bbiDonLanhLieu});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1104, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1104, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 550);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1104, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 550);
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDanhSach.Location = new System.Drawing.Point(304, 10);
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDanhSach.Properties.IsFloatValue = false;
            this.txtDanhSach.Properties.Mask.EditMask = "N00";
            this.txtDanhSach.Size = new System.Drawing.Size(100, 20);
            this.txtDanhSach.TabIndex = 35;
            this.txtDanhSach.EditValueChanged += new System.EventHandler(this.txtDanhSach_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "DANH SÁCH:";
            // 
            // txtChoThem
            // 
            this.txtChoThem.EditValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtChoThem.Location = new System.Drawing.Point(477, 10);
            this.txtChoThem.Name = "txtChoThem";
            this.txtChoThem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtChoThem.Properties.IsFloatValue = false;
            this.txtChoThem.Properties.Mask.EditMask = "n0";
            this.txtChoThem.Size = new System.Drawing.Size(83, 20);
            this.txtChoThem.TabIndex = 32;
            // 
            // txtBuHao
            // 
            this.txtBuHao.EditValue = new decimal(new int[] {
            106,
            0,
            0,
            131072});
            this.txtBuHao.Location = new System.Drawing.Point(657, 9);
            this.txtBuHao.Name = "txtBuHao";
            this.txtBuHao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBuHao.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtBuHao.Properties.Mask.EditMask = "f2";
            this.txtBuHao.Size = new System.Drawing.Size(84, 20);
            this.txtBuHao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "CHO THÊM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BÙ HAO TÍNH %:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LamMoitxt
            // 
            this.LamMoitxt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LamMoitxt.ImageOptions.Image")));
            this.LamMoitxt.Location = new System.Drawing.Point(268, 34);
            this.LamMoitxt.Name = "LamMoitxt";
            this.LamMoitxt.Size = new System.Drawing.Size(110, 37);
            this.LamMoitxt.TabIndex = 4;
            this.LamMoitxt.Text = "LÀM MỚI";
            this.LamMoitxt.Click += new System.EventHandler(this.LamMoitxt_Click);
            // 
            // frmTemVaiAvery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 550);
            this.Controls.Add(this.procDonSanXuat_ViewGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTemVaiAvery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tem Vải Avery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTemVaiAvery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ngayxuongdontxt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngayxuongdontxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procDonSanXuat_ViewGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDanhSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoThem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuHao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit Ngayxuongdontxt;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTinh;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraGrid.GridControl procDonSanXuat_ViewGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSCD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuongDon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colBoPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colKichThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colBuHao;
        private DevExpress.XtraGrid.Columns.GridColumn colLanhLieu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton LamMoitxt;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU;
        private DevExpress.XtraEditors.SpinEdit txtBuHao;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SpinEdit txtChoThem;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colQuyCach;
        private DevExpress.XtraEditors.SpinEdit txtDanhSach;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbiDonSanXuat;
        private DevExpress.XtraBars.BarButtonItem bbiDonLanhLieu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}