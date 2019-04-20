namespace QuanLySanXuat.DonSanXuat
{
    partial class frmBaoCao_nghiepvu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXacNhan1Dong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTenKhachHang = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSCD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMaDonHang = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNgayXuongDon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNgayGiaoHang = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colVatLieu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPhuongPhapIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKichThuoc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSize = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSpSize = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDanhGia = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CheckDanhGia = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CheckBanIn = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.CheckSanPham = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.CheckLayout = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.CheckNetChu = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.CheckCoChu = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.CheckVitri = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.CheckKyHieu = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.risSpSize = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBanIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckNetChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCoChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckVitri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckKyHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.risSpSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 83);
            this.panel1.TabIndex = 1;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(511, 41);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Hiện tất cả đơn hàng";
            this.checkEdit1.Size = new System.Drawing.Size(130, 19);
            this.checkEdit1.TabIndex = 5;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnXacNhan1Dong, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXacNhan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateEdit1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIn, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 44);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnXacNhan1Dong
            // 
            this.btnXacNhan1Dong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan1Dong.Location = new System.Drawing.Point(125, 4);
            this.btnXacNhan1Dong.Name = "btnXacNhan1Dong";
            this.btnXacNhan1Dong.Size = new System.Drawing.Size(114, 36);
            this.btnXacNhan1Dong.TabIndex = 5;
            this.btnXacNhan1Dong.Text = "XÁC NHẬN 1 DÒNG";
            this.btnXacNhan1Dong.Click += new System.EventHandler(this.btnXacNhan1Dong_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.Location = new System.Drawing.Point(4, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(114, 36);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(367, 4);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEdit1.Size = new System.Drawing.Size(130, 20);
            this.dateEdit1.TabIndex = 4;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(246, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(114, 36);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "IN";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO KIỂM TRA NGHIỆP VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 83);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CheckBanIn,
            this.CheckSanPham,
            this.CheckLayout,
            this.CheckNetChu,
            this.CheckCoChu,
            this.CheckVitri,
            this.CheckKyHieu,
            this.CheckDanhGia,
            this.risSpSize});
            this.gridControl1.Size = new System.Drawing.Size(1149, 580);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand5,
            this.gridBand3,
            this.gridBand2,
            this.gridBand4});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colTenKhachHang,
            this.colSCD,
            this.colMaDonHang,
            this.colNgayXuongDon,
            this.colNgayGiaoHang,
            this.colVatLieu,
            this.colPhuongPhapIn,
            this.colKichThuoc,
            this.colSize,
            this.colSoLuong,
            this.colSpSize,
            this.colDanhGia,
            this.colGhiChu});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsSelection.MultiSelect = true;
            this.bandedGridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.bandedGridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colTenKhachHang);
            this.gridBand1.Columns.Add(this.colSCD);
            this.gridBand1.Columns.Add(this.colMaDonHang);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 225;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "Tên Khách Hàng";
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            // 
            // colSCD
            // 
            this.colSCD.Caption = "SCD";
            this.colSCD.FieldName = "SCD";
            this.colSCD.Name = "colSCD";
            this.colSCD.Visible = true;
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.Caption = "Mã Sản Phẩm";
            this.colMaDonHang.FieldName = "MaDonHang";
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Thời Gian";
            this.gridBand5.Columns.Add(this.colNgayXuongDon);
            this.gridBand5.Columns.Add(this.colNgayGiaoHang);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 1;
            this.gridBand5.Width = 150;
            // 
            // colNgayXuongDon
            // 
            this.colNgayXuongDon.Caption = "Ngày Xuống Đơn";
            this.colNgayXuongDon.FieldName = "NgayXuongDon";
            this.colNgayXuongDon.Name = "colNgayXuongDon";
            this.colNgayXuongDon.Visible = true;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.Caption = "Ngày Xuất Hàng";
            this.colNgayGiaoHang.FieldName = "NgayGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Columns.Add(this.colVatLieu);
            this.gridBand3.Columns.Add(this.colPhuongPhapIn);
            this.gridBand3.Columns.Add(this.colKichThuoc);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 225;
            // 
            // colVatLieu
            // 
            this.colVatLieu.Caption = "Chất Liệu";
            this.colVatLieu.FieldName = "VatLieu";
            this.colVatLieu.Name = "colVatLieu";
            this.colVatLieu.Visible = true;
            // 
            // colPhuongPhapIn
            // 
            this.colPhuongPhapIn.Caption = "Nội Dung";
            this.colPhuongPhapIn.FieldName = "PhuongPhapIn";
            this.colPhuongPhapIn.Name = "colPhuongPhapIn";
            this.colPhuongPhapIn.Visible = true;
            // 
            // colKichThuoc
            // 
            this.colKichThuoc.Caption = "Quy Cách";
            this.colKichThuoc.FieldName = "KichThuoc";
            this.colKichThuoc.Name = "colKichThuoc";
            this.colKichThuoc.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Số Lượng";
            this.gridBand2.Columns.Add(this.colSize);
            this.gridBand2.Columns.Add(this.colSpSize);
            this.gridBand2.Columns.Add(this.colSoLuong);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 3;
            this.gridBand2.Width = 225;
            // 
            // colSize
            // 
            this.colSize.Caption = "Size";
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            // 
            // colSpSize
            // 
            this.colSpSize.Caption = "SP/Size";
            this.colSpSize.ColumnEdit = this.risSpSize;
            this.colSpSize.FieldName = "SpSize";
            this.colSpSize.Name = "colSpSize";
            this.colSpSize.Visible = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Tổng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.Columns.Add(this.colDanhGia);
            this.gridBand4.Columns.Add(this.colGhiChu);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 4;
            this.gridBand4.Width = 150;
            // 
            // colDanhGia
            // 
            this.colDanhGia.Caption = "Đánh Giá";
            this.colDanhGia.ColumnEdit = this.CheckDanhGia;
            this.colDanhGia.FieldName = "DanhGia";
            this.colDanhGia.Name = "colDanhGia";
            this.colDanhGia.Visible = true;
            // 
            // CheckDanhGia
            // 
            this.CheckDanhGia.AutoHeight = false;
            this.CheckDanhGia.Name = "CheckDanhGia";
            this.CheckDanhGia.ValueChecked = "Đạt";
            this.CheckDanhGia.ValueUnchecked = "Không Đạt";
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            // 
            // CheckBanIn
            // 
            this.CheckBanIn.AutoHeight = false;
            this.CheckBanIn.Name = "CheckBanIn";
            this.CheckBanIn.ValueChecked = "Đạt";
            this.CheckBanIn.ValueUnchecked = "Không Đạt";
            // 
            // CheckSanPham
            // 
            this.CheckSanPham.AutoHeight = false;
            this.CheckSanPham.Name = "CheckSanPham";
            this.CheckSanPham.ValueChecked = "Đạt";
            this.CheckSanPham.ValueUnchecked = "Không Đạt";
            // 
            // CheckLayout
            // 
            this.CheckLayout.AutoHeight = false;
            this.CheckLayout.Name = "CheckLayout";
            this.CheckLayout.ValueChecked = "Đạt";
            this.CheckLayout.ValueUnchecked = "Không Đạt";
            // 
            // CheckNetChu
            // 
            this.CheckNetChu.AutoHeight = false;
            this.CheckNetChu.Name = "CheckNetChu";
            this.CheckNetChu.ValueChecked = "Đạt";
            this.CheckNetChu.ValueUnchecked = "Không Đạt";
            // 
            // CheckCoChu
            // 
            this.CheckCoChu.AutoHeight = false;
            this.CheckCoChu.Name = "CheckCoChu";
            this.CheckCoChu.ValueChecked = "O";
            this.CheckCoChu.ValueUnchecked = "X";
            // 
            // CheckVitri
            // 
            this.CheckVitri.AutoHeight = false;
            this.CheckVitri.Name = "CheckVitri";
            this.CheckVitri.ValueChecked = "Đạt";
            this.CheckVitri.ValueUnchecked = "Không Đạt";
            // 
            // CheckKyHieu
            // 
            this.CheckKyHieu.AutoHeight = false;
            this.CheckKyHieu.Name = "CheckKyHieu";
            this.CheckKyHieu.ValueChecked = "Đạt";
            this.CheckKyHieu.ValueUnchecked = "Không Đạt";
            // 
            // risSpSize
            // 
            this.risSpSize.AutoHeight = false;
            this.risSpSize.Name = "risSpSize";
            this.risSpSize.ValueChecked = "O";
            this.risSpSize.ValueUnchecked = "X";
            // 
            // frmBaoCao_nghiepvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 663);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCao_nghiepvu";
            this.Text = "frmBaoCao_nghiepvu";
            this.Load += new System.EventHandler(this.frmBaoCao_nghiepvu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBanIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckNetChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCoChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckVitri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckKyHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.risSpSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan1Dong;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSCD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMaDonHang;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayXuongDon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayGiaoHang;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVatLieu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPhuongPhapIn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKichThuoc;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSize;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSpSize;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckCoChu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSoLuong;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDanhGia;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckBanIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckLayout;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckNetChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckVitri;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckKyHieu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckDanhGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit risSpSize;
    }
}