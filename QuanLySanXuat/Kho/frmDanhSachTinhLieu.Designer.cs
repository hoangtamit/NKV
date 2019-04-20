namespace QuanLySanXuat.Kho
{
    partial class frmDanhSachTinhLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachTinhLieu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.check = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDonLanhLieu = new DevExpress.XtraEditors.SimpleButton();
            this.LamMoitxt = new DevExpress.XtraEditors.SimpleButton();
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
            this.colPhuongPhapIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanhLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procDonSanXuat_ViewGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.check);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnDonLanhLieu);
            this.panelControl1.Controls.Add(this.LamMoitxt);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1071, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(373, 17);
            this.check.Name = "check";
            this.check.Properties.Caption = "Hiện tất cả đơn hàng";
            this.check.Size = new System.Drawing.Size(131, 19);
            this.check.TabIndex = 9;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 30);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "PHIẾU XUẤT KHO";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDonLanhLieu
            // 
            this.btnDonLanhLieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDonLanhLieu.ImageOptions.Image")));
            this.btnDonLanhLieu.Location = new System.Drawing.Point(155, 6);
            this.btnDonLanhLieu.Name = "btnDonLanhLieu";
            this.btnDonLanhLieu.Size = new System.Drawing.Size(103, 30);
            this.btnDonLanhLieu.TabIndex = 7;
            this.btnDonLanhLieu.Text = "IN";
            this.btnDonLanhLieu.Click += new System.EventHandler(this.btnDonLanhLieu_Click);
            // 
            // LamMoitxt
            // 
            this.LamMoitxt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LamMoitxt.ImageOptions.Image")));
            this.LamMoitxt.Location = new System.Drawing.Point(264, 6);
            this.LamMoitxt.Name = "LamMoitxt";
            this.LamMoitxt.Size = new System.Drawing.Size(103, 30);
            this.LamMoitxt.TabIndex = 6;
            this.LamMoitxt.Text = "LÀM MỚI";
            this.LamMoitxt.Click += new System.EventHandler(this.LamMoitxt_Click);
            // 
            // procDonSanXuat_ViewGridControl
            // 
            this.procDonSanXuat_ViewGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procDonSanXuat_ViewGridControl.Location = new System.Drawing.Point(0, 46);
            this.procDonSanXuat_ViewGridControl.MainView = this.gridView1;
            this.procDonSanXuat_ViewGridControl.Name = "procDonSanXuat_ViewGridControl";
            this.procDonSanXuat_ViewGridControl.Size = new System.Drawing.Size(1071, 605);
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
            this.colPhuongPhapIn,
            this.colKho,
            this.colLanhLieu,
            this.colDonViTinh,
            this.colQuyCach,
            this.colVatLieu,
            this.colMaHang});
            this.gridView1.GridControl = this.procDonSanXuat_ViewGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
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
            this.colSCD.VisibleIndex = 1;
            this.colSCD.Width = 125;
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.FieldName = "MaDonHang";
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.Visible = true;
            this.colMaDonHang.VisibleIndex = 2;
            this.colMaDonHang.Width = 95;
            // 
            // colNgayXuongDon
            // 
            this.colNgayXuongDon.FieldName = "NgayXuongDon";
            this.colNgayXuongDon.Name = "colNgayXuongDon";
            this.colNgayXuongDon.Visible = true;
            this.colNgayXuongDon.VisibleIndex = 3;
            this.colNgayXuongDon.Width = 103;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.FieldName = "NgayGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.Visible = true;
            this.colNgayGiaoHang.VisibleIndex = 4;
            this.colNgayGiaoHang.Width = 103;
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
            this.colSoLuong.VisibleIndex = 5;
            this.colSoLuong.Width = 74;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 6;
            this.colTenKhachHang.Width = 110;
            // 
            // colBoPhan
            // 
            this.colBoPhan.FieldName = "BoPhan";
            this.colBoPhan.Name = "colBoPhan";
            this.colBoPhan.Visible = true;
            this.colBoPhan.VisibleIndex = 10;
            this.colBoPhan.Width = 83;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 7;
            this.colTenSanPham.Width = 93;
            // 
            // colKichThuoc
            // 
            this.colKichThuoc.FieldName = "KichThuoc";
            this.colKichThuoc.Name = "colKichThuoc";
            this.colKichThuoc.Visible = true;
            this.colKichThuoc.VisibleIndex = 8;
            this.colKichThuoc.Width = 71;
            // 
            // colPhuongPhapIn
            // 
            this.colPhuongPhapIn.FieldName = "PhuongPhapIn";
            this.colPhuongPhapIn.Name = "colPhuongPhapIn";
            this.colPhuongPhapIn.Visible = true;
            this.colPhuongPhapIn.VisibleIndex = 9;
            this.colPhuongPhapIn.Width = 88;
            // 
            // colKho
            // 
            this.colKho.FieldName = "Kho";
            this.colKho.Name = "colKho";
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 11;
            this.colKho.Width = 110;
            // 
            // colLanhLieu
            // 
            this.colLanhLieu.FieldName = "LanhLieu";
            this.colLanhLieu.Name = "colLanhLieu";
            this.colLanhLieu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LanhLieu", "TỔNG = {0:0.##}")});
            this.colLanhLieu.Visible = true;
            this.colLanhLieu.VisibleIndex = 14;
            this.colLanhLieu.Width = 96;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn Vị Tính";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 15;
            this.colDonViTinh.Width = 81;
            // 
            // colQuyCach
            // 
            this.colQuyCach.Caption = "Quy Cách";
            this.colQuyCach.FieldName = "QuyCach";
            this.colQuyCach.Name = "colQuyCach";
            this.colQuyCach.Visible = true;
            this.colQuyCach.VisibleIndex = 16;
            // 
            // colVatLieu
            // 
            this.colVatLieu.Caption = "Vật Liệu";
            this.colVatLieu.FieldName = "VatLieu";
            this.colVatLieu.Name = "colVatLieu";
            this.colVatLieu.Visible = true;
            this.colVatLieu.VisibleIndex = 13;
            this.colVatLieu.Width = 324;
            // 
            // colMaHang
            // 
            this.colMaHang.Caption = "Mã Hàng Hóa";
            this.colMaHang.FieldName = "MaHang";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.Visible = true;
            this.colMaHang.VisibleIndex = 12;
            // 
            // frmDanhSachTinhLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 651);
            this.Controls.Add(this.procDonSanXuat_ViewGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDanhSachTinhLieu";
            this.Text = "DANH SÁCH TÍNH LIỆU";
            this.Load += new System.EventHandler(this.frmDanhSachTinhLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procDonSanXuat_ViewGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colPhuongPhapIn;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colLanhLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colVatLieu;
        private DevExpress.XtraEditors.SimpleButton btnDonLanhLieu;
        private DevExpress.XtraEditors.SimpleButton LamMoitxt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit check;
        private DevExpress.XtraGrid.Columns.GridColumn colQuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
    }
}