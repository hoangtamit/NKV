namespace QuanLySanXuat.Kho
{
    partial class frmKhoBTP_TPNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoBTP_TPNhap));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.tbKhoBTP_TPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKhoBTP_TP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDonHang1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongNhapKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongNhapCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKichThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoGiayIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPhieuNhapKho = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKhoBTP_TPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1131, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLamMoi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnLamMoi.Location = new System.Drawing.Point(568, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnXoa.Location = new System.Drawing.Point(215, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.ToolTipTitle = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnSua.Location = new System.Drawing.Point(109, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnin
            // 
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnin.Location = new System.Drawing.Point(321, 3);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(100, 40);
            this.btnin.TabIndex = 31;
            this.btnin.Text = "IN";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // tbKhoBTP_TPGridControl
            // 
            this.tbKhoBTP_TPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKhoBTP_TPGridControl.Location = new System.Drawing.Point(0, 52);
            this.tbKhoBTP_TPGridControl.MainView = this.gridView1;
            this.tbKhoBTP_TPGridControl.Name = "tbKhoBTP_TPGridControl";
            this.tbKhoBTP_TPGridControl.Size = new System.Drawing.Size(1131, 527);
            this.tbKhoBTP_TPGridControl.TabIndex = 2;
            this.tbKhoBTP_TPGridControl.UseEmbeddedNavigator = true;
            this.tbKhoBTP_TPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKhoBTP_TP,
            this.colNhapXuat,
            this.colMaPhieu,
            this.colLo,
            this.colSCD,
            this.colKho,
            this.colNgay,
            this.colLoaiSanPham,
            this.colMaDonHang1,
            this.colTenKhachHang,
            this.colTenSanPham1,
            this.colSoLuongNhapKhachHang,
            this.colSoLuongNhapCongTy,
            this.colDonViTinh,
            this.colKichThuoc,
            this.colKhoGiayIn,
            this.colBoPhan,
            this.colGhiChu,
            this.colNhanVien});
            this.gridView1.GridControl = this.tbKhoBTP_TPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colIDKhoBTP_TP
            // 
            this.colIDKhoBTP_TP.FieldName = "IDKhoBTP_TP";
            this.colIDKhoBTP_TP.Name = "colIDKhoBTP_TP";
            this.colIDKhoBTP_TP.Visible = true;
            this.colIDKhoBTP_TP.VisibleIndex = 0;
            // 
            // colNhapXuat
            // 
            this.colNhapXuat.FieldName = "NhapXuat";
            this.colNhapXuat.Name = "colNhapXuat";
            this.colNhapXuat.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.Caption = "Mã Phiếu";
            this.colMaPhieu.FieldName = "MaPhieu";
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.Visible = true;
            this.colMaPhieu.VisibleIndex = 2;
            // 
            // colLo
            // 
            this.colLo.Caption = "Lô";
            this.colLo.FieldName = "Lo";
            this.colLo.Name = "colLo";
            // 
            // colSCD
            // 
            this.colSCD.FieldName = "SCD";
            this.colSCD.Name = "colSCD";
            this.colSCD.Visible = true;
            this.colSCD.VisibleIndex = 1;
            // 
            // colKho
            // 
            this.colKho.Caption = "KHO";
            this.colKho.FieldName = "Kho";
            this.colKho.Name = "colKho";
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 3;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "NGÀY XUẤT";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 4;
            // 
            // colLoaiSanPham
            // 
            this.colLoaiSanPham.Caption = "LOẠI SẢN PHẨM";
            this.colLoaiSanPham.FieldName = "LoaiSanPham";
            this.colLoaiSanPham.Name = "colLoaiSanPham";
            this.colLoaiSanPham.Visible = true;
            this.colLoaiSanPham.VisibleIndex = 5;
            // 
            // colMaDonHang1
            // 
            this.colMaDonHang1.Caption = "MÃ ĐƠN HÀNG";
            this.colMaDonHang1.FieldName = "MaDonHang";
            this.colMaDonHang1.Name = "colMaDonHang1";
            this.colMaDonHang1.Visible = true;
            this.colMaDonHang1.VisibleIndex = 6;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "TÊN KHÁCH HÀNG";
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 7;
            // 
            // colTenSanPham1
            // 
            this.colTenSanPham1.Caption = "TÊN SẢN PHẨM";
            this.colTenSanPham1.FieldName = "TenSanPham";
            this.colTenSanPham1.Name = "colTenSanPham1";
            this.colTenSanPham1.Visible = true;
            this.colTenSanPham1.VisibleIndex = 8;
            // 
            // colSoLuongNhapKhachHang
            // 
            this.colSoLuongNhapKhachHang.Caption = "SỐ LƯỢNG NHẬP KHÁCH HÀNG";
            this.colSoLuongNhapKhachHang.DisplayFormat.FormatString = "{0:#,#}";
            this.colSoLuongNhapKhachHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuongNhapKhachHang.FieldName = "SoLuongNhapKhachHang";
            this.colSoLuongNhapKhachHang.Name = "colSoLuongNhapKhachHang";
            this.colSoLuongNhapKhachHang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongNhapKhachHang", "TỔNG = {0:#,#}")});
            this.colSoLuongNhapKhachHang.Visible = true;
            this.colSoLuongNhapKhachHang.VisibleIndex = 9;
            // 
            // colSoLuongNhapCongTy
            // 
            this.colSoLuongNhapCongTy.Caption = "SỐ LƯỢNG NHẬP CÔNG TY";
            this.colSoLuongNhapCongTy.DisplayFormat.FormatString = "{0:#,#}";
            this.colSoLuongNhapCongTy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuongNhapCongTy.FieldName = "SoLuongNhapCongTy";
            this.colSoLuongNhapCongTy.Name = "colSoLuongNhapCongTy";
            this.colSoLuongNhapCongTy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongNhapCongTy", "TỔNG = {0:#,#}")});
            this.colSoLuongNhapCongTy.Visible = true;
            this.colSoLuongNhapCongTy.VisibleIndex = 10;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "ĐƠN VỊ TÍNH";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 11;
            // 
            // colKichThuoc
            // 
            this.colKichThuoc.Caption = "KÍCH THƯỚC";
            this.colKichThuoc.FieldName = "KichThuoc";
            this.colKichThuoc.Name = "colKichThuoc";
            this.colKichThuoc.Visible = true;
            this.colKichThuoc.VisibleIndex = 12;
            // 
            // colKhoGiayIn
            // 
            this.colKhoGiayIn.Caption = "KHỔ GIẤY IN";
            this.colKhoGiayIn.FieldName = "KhoGiayIn";
            this.colKhoGiayIn.Name = "colKhoGiayIn";
            this.colKhoGiayIn.Visible = true;
            this.colKhoGiayIn.VisibleIndex = 13;
            // 
            // colBoPhan
            // 
            this.colBoPhan.Caption = "BỘ PHẬN NHẬP ";
            this.colBoPhan.FieldName = "BoPhan";
            this.colBoPhan.Name = "colBoPhan";
            this.colBoPhan.Visible = true;
            this.colBoPhan.VisibleIndex = 14;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "GHI CHÚ";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 15;
            // 
            // colNhanVien
            // 
            this.colNhanVien.Caption = "NHÂN VIÊN KHO";
            this.colNhanVien.FieldName = "NhanVien";
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnSua);
            this.flowLayoutPanel1.Controls.Add(this.btnXoa);
            this.flowLayoutPanel1.Controls.Add(this.btnin);
            this.flowLayoutPanel1.Controls.Add(this.btnPhieuNhapKho);
            this.flowLayoutPanel1.Controls.Add(this.btnLamMoi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1127, 48);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // btnPhieuNhapKho
            // 
            this.btnPhieuNhapKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPhieuNhapKho.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPhieuNhapKho.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnPhieuNhapKho.Location = new System.Drawing.Point(427, 3);
            this.btnPhieuNhapKho.Name = "btnPhieuNhapKho";
            this.btnPhieuNhapKho.Size = new System.Drawing.Size(135, 40);
            this.btnPhieuNhapKho.TabIndex = 39;
            this.btnPhieuNhapKho.Text = "PHIẾU NHẬP KHO";
            this.btnPhieuNhapKho.Click += new System.EventHandler(this.btnPhieuNhapKho_Click);
            // 
            // frmKhoBTP_TPNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 579);
            this.Controls.Add(this.tbKhoBTP_TPGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKhoBTP_TPNhap";
            this.Text = "KHO BTP-TP NHẬP";
            this.Load += new System.EventHandler(this.frmKhoBTP_TPNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbKhoBTP_TPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl tbKhoBTP_TPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKhoBTP_TP;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colSCD;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonHang1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongNhapKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongNhapCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colKichThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoGiayIn;
        private DevExpress.XtraGrid.Columns.GridColumn colBoPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colLo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnPhieuNhapKho;
    }
}