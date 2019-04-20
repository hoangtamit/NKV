namespace QuanLySanXuat.Kho
{
    partial class frmKhoBTP_TPXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoBTP_TPXuat));
            this.tbKhoBTP_TPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKhoBTP_TP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDonHang1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSanPham1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongXuatKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongXuatCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKichThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoGiayIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhieuXuatKho = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbKhoBTP_TPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKhoBTP_TPGridControl
            // 
            this.tbKhoBTP_TPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKhoBTP_TPGridControl.Location = new System.Drawing.Point(0, 50);
            this.tbKhoBTP_TPGridControl.MainView = this.gridView1;
            this.tbKhoBTP_TPGridControl.Name = "tbKhoBTP_TPGridControl";
            this.tbKhoBTP_TPGridControl.Size = new System.Drawing.Size(1050, 428);
            this.tbKhoBTP_TPGridControl.TabIndex = 3;
            this.tbKhoBTP_TPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKhoBTP_TP,
            this.colMaPhieu,
            this.colSCD,
            this.colKho,
            this.colNgay,
            this.colLoaiSanPham,
            this.colMaDonHang1,
            this.colTenKhachHang,
            this.colTenSanPham1,
            this.colSoLuongXuatKhachHang,
            this.colSoLuongXuatCongTy,
            this.colDonViTinh,
            this.colKichThuoc,
            this.colKhoGiayIn,
            this.colBoPhan,
            this.colGhiChu,
            this.colNhanVien,
            this.colNhapXuat});
            this.gridView1.GridControl = this.tbKhoBTP_TPGridControl;
            this.gridView1.Name = "gridView1";
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
            // colMaPhieu
            // 
            this.colMaPhieu.Caption = "Mã Phiếu";
            this.colMaPhieu.FieldName = "MaPhieu";
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.Visible = true;
            this.colMaPhieu.VisibleIndex = 1;
            // 
            // colSCD
            // 
            this.colSCD.FieldName = "SCD";
            this.colSCD.Name = "colSCD";
            this.colSCD.Visible = true;
            this.colSCD.VisibleIndex = 2;
            // 
            // colKho
            // 
            this.colKho.FieldName = "Kho";
            this.colKho.Name = "colKho";
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 3;
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 4;
            // 
            // colLoaiSanPham
            // 
            this.colLoaiSanPham.FieldName = "LoaiSanPham";
            this.colLoaiSanPham.Name = "colLoaiSanPham";
            this.colLoaiSanPham.Visible = true;
            this.colLoaiSanPham.VisibleIndex = 5;
            // 
            // colMaDonHang1
            // 
            this.colMaDonHang1.FieldName = "MaDonHang";
            this.colMaDonHang1.Name = "colMaDonHang1";
            this.colMaDonHang1.Visible = true;
            this.colMaDonHang1.VisibleIndex = 6;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 7;
            // 
            // colTenSanPham1
            // 
            this.colTenSanPham1.FieldName = "TenSanPham";
            this.colTenSanPham1.Name = "colTenSanPham1";
            this.colTenSanPham1.Visible = true;
            this.colTenSanPham1.VisibleIndex = 8;
            // 
            // colSoLuongXuatKhachHang
            // 
            this.colSoLuongXuatKhachHang.DisplayFormat.FormatString = "{0:#,#}";
            this.colSoLuongXuatKhachHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuongXuatKhachHang.FieldName = "SoLuongXuatKhachHang";
            this.colSoLuongXuatKhachHang.Name = "colSoLuongXuatKhachHang";
            this.colSoLuongXuatKhachHang.Visible = true;
            this.colSoLuongXuatKhachHang.VisibleIndex = 9;
            // 
            // colSoLuongXuatCongTy
            // 
            this.colSoLuongXuatCongTy.DisplayFormat.FormatString = "{0:#,#}";
            this.colSoLuongXuatCongTy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuongXuatCongTy.FieldName = "SoLuongXuatCongTy";
            this.colSoLuongXuatCongTy.Name = "colSoLuongXuatCongTy";
            this.colSoLuongXuatCongTy.Visible = true;
            this.colSoLuongXuatCongTy.VisibleIndex = 10;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 11;
            // 
            // colKichThuoc
            // 
            this.colKichThuoc.FieldName = "KichThuoc";
            this.colKichThuoc.Name = "colKichThuoc";
            this.colKichThuoc.Visible = true;
            this.colKichThuoc.VisibleIndex = 12;
            // 
            // colKhoGiayIn
            // 
            this.colKhoGiayIn.FieldName = "KhoGiayIn";
            this.colKhoGiayIn.Name = "colKhoGiayIn";
            this.colKhoGiayIn.Visible = true;
            this.colKhoGiayIn.VisibleIndex = 13;
            // 
            // colBoPhan
            // 
            this.colBoPhan.FieldName = "BoPhan";
            this.colBoPhan.Name = "colBoPhan";
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 14;
            // 
            // colNhanVien
            // 
            this.colNhanVien.FieldName = "NhanVien";
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 15;
            // 
            // colNhapXuat
            // 
            this.colNhapXuat.FieldName = "NhapXuat";
            this.colNhapXuat.Name = "colNhapXuat";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1050, 50);
            this.panelControl1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnSua);
            this.flowLayoutPanel1.Controls.Add(this.btnXoa);
            this.flowLayoutPanel1.Controls.Add(this.btnin);
            this.flowLayoutPanel1.Controls.Add(this.btnPhieuXuatKho);
            this.flowLayoutPanel1.Controls.Add(this.btnLamMoi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1046, 46);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLamMoi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnLamMoi.Location = new System.Drawing.Point(565, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Text = "LÀM MỚI";
            // 
            // btnPhieuXuatKho
            // 
            this.btnPhieuXuatKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuXuatKho.ImageOptions.Image")));
            this.btnPhieuXuatKho.Location = new System.Drawing.Point(427, 3);
            this.btnPhieuXuatKho.Name = "btnPhieuXuatKho";
            this.btnPhieuXuatKho.Size = new System.Drawing.Size(132, 40);
            this.btnPhieuXuatKho.TabIndex = 39;
            this.btnPhieuXuatKho.Text = "PHIẾU XUẤT KHO";
            this.btnPhieuXuatKho.Click += new System.EventHandler(this.btnPhieuXuatKho_Click);
            // 
            // frmKhoBTP_TPXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 478);
            this.Controls.Add(this.tbKhoBTP_TPGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKhoBTP_TPXuat";
            this.Text = "KHO BTP-TP XUẤT";
            this.Load += new System.EventHandler(this.frmKhoBTP_TPXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbKhoBTP_TPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl tbKhoBTP_TPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKhoBTP_TP;
        private DevExpress.XtraGrid.Columns.GridColumn colSCD;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonHang1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongXuatKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongXuatCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colKichThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoGiayIn;
        private DevExpress.XtraGrid.Columns.GridColumn colBoPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapXuat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnPhieuXuatKho;
    }
}