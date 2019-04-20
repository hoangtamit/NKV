namespace QuanLySanXuat
{
    partial class frmKhuon
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colSCD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMaDonHang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPhienBan = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNgayXuongDon = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNgayGiaoHang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSoLuong = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLoaiSanPham = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVatLieu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colChuY = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTenKhachHang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTenSanPham = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colKichThuoc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colHinhMatPhai = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colHinhMatTrai = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMauMatPhai = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tbDonSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nKVDataSet = new QuanLySanXuat.NKVDataSet();
            this.tbDonSanXuatTableAdapter = new QuanLySanXuat.NKVDataSetTableAdapters.tbDonSanXuatTableAdapter();
            this.zoomTrackBarControl1 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDonSanXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colSCD,
            this.colMaDonHang,
            this.colPhienBan,
            this.colNgayXuongDon,
            this.colNgayGiaoHang,
            this.colSoLuong,
            this.colLoaiSanPham,
            this.colVatLieu,
            this.colChuY,
            this.colTenKhachHang,
            this.colTenSanPham,
            this.colKichThuoc,
            this.colHinhMatPhai,
            this.colHinhMatTrai,
            this.colMauMatPhai});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = this.tbDonSanXuatBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.OptionsView.ShowAutoFilterRow = true;
            this.treeList1.Size = new System.Drawing.Size(935, 640);
            this.treeList1.TabIndex = 0;
            this.treeList1.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList1_GetStateImage);
            this.treeList1.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.treeList1_GetSelectImage);
            this.treeList1.GetPreviewText += new DevExpress.XtraTreeList.GetPreviewTextEventHandler(this.treeList1_GetPreviewText);
            this.treeList1.VirtualTreeGetChildNodes += new DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(this.treeList1_VirtualTreeGetChildNodes);
            this.treeList1.VirtualTreeGetCellValue += new DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(this.treeList1_VirtualTreeGetCellValue);
            this.treeList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeList1_KeyDown);
            this.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            // 
            // colSCD
            // 
            this.colSCD.FieldName = "SCD";
            this.colSCD.Name = "colSCD";
            this.colSCD.Visible = true;
            this.colSCD.VisibleIndex = 0;
            this.colSCD.Width = 21;
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.FieldName = "MaDonHang";
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.Visible = true;
            this.colMaDonHang.VisibleIndex = 1;
            this.colMaDonHang.Width = 21;
            // 
            // colPhienBan
            // 
            this.colPhienBan.FieldName = "PhienBan";
            this.colPhienBan.Name = "colPhienBan";
            this.colPhienBan.Visible = true;
            this.colPhienBan.VisibleIndex = 2;
            this.colPhienBan.Width = 21;
            // 
            // colNgayXuongDon
            // 
            this.colNgayXuongDon.FieldName = "NgayXuongDon";
            this.colNgayXuongDon.Name = "colNgayXuongDon";
            this.colNgayXuongDon.Visible = true;
            this.colNgayXuongDon.VisibleIndex = 3;
            this.colNgayXuongDon.Width = 21;
            // 
            // colNgayGiaoHang
            // 
            this.colNgayGiaoHang.FieldName = "NgayGiaoHang";
            this.colNgayGiaoHang.Name = "colNgayGiaoHang";
            this.colNgayGiaoHang.Visible = true;
            this.colNgayGiaoHang.VisibleIndex = 4;
            this.colNgayGiaoHang.Width = 21;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 5;
            this.colSoLuong.Width = 21;
            // 
            // colLoaiSanPham
            // 
            this.colLoaiSanPham.FieldName = "LoaiSanPham";
            this.colLoaiSanPham.Name = "colLoaiSanPham";
            this.colLoaiSanPham.Visible = true;
            this.colLoaiSanPham.VisibleIndex = 6;
            this.colLoaiSanPham.Width = 21;
            // 
            // colVatLieu
            // 
            this.colVatLieu.FieldName = "VatLieu";
            this.colVatLieu.Name = "colVatLieu";
            this.colVatLieu.Visible = true;
            this.colVatLieu.VisibleIndex = 7;
            this.colVatLieu.Width = 21;
            // 
            // colChuY
            // 
            this.colChuY.FieldName = "ChuY";
            this.colChuY.Name = "colChuY";
            this.colChuY.Visible = true;
            this.colChuY.VisibleIndex = 8;
            this.colChuY.Width = 21;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 9;
            this.colTenKhachHang.Width = 21;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.FieldName = "TenSanPham";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 10;
            this.colTenSanPham.Width = 21;
            // 
            // colKichThuoc
            // 
            this.colKichThuoc.FieldName = "KichThuoc";
            this.colKichThuoc.Name = "colKichThuoc";
            this.colKichThuoc.Visible = true;
            this.colKichThuoc.VisibleIndex = 11;
            this.colKichThuoc.Width = 21;
            // 
            // colHinhMatPhai
            // 
            this.colHinhMatPhai.FieldName = "HinhMatPhai";
            this.colHinhMatPhai.Name = "colHinhMatPhai";
            this.colHinhMatPhai.Visible = true;
            this.colHinhMatPhai.VisibleIndex = 12;
            this.colHinhMatPhai.Width = 21;
            // 
            // colHinhMatTrai
            // 
            this.colHinhMatTrai.FieldName = "HinhMatTrai";
            this.colHinhMatTrai.Name = "colHinhMatTrai";
            this.colHinhMatTrai.Visible = true;
            this.colHinhMatTrai.VisibleIndex = 13;
            this.colHinhMatTrai.Width = 21;
            // 
            // colMauMatPhai
            // 
            this.colMauMatPhai.FieldName = "MauMatPhai";
            this.colMauMatPhai.Name = "colMauMatPhai";
            this.colMauMatPhai.Visible = true;
            this.colMauMatPhai.VisibleIndex = 14;
            this.colMauMatPhai.Width = 21;
            // 
            // tbDonSanXuatBindingSource
            // 
            this.tbDonSanXuatBindingSource.DataMember = "tbDonSanXuat";
            this.tbDonSanXuatBindingSource.DataSource = this.nKVDataSet;
            // 
            // nKVDataSet
            // 
            this.nKVDataSet.DataSetName = "NKVDataSet";
            this.nKVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDonSanXuatTableAdapter
            // 
            this.tbDonSanXuatTableAdapter.ClearBeforeFill = true;
            // 
            // zoomTrackBarControl1
            // 
            this.zoomTrackBarControl1.Location = new System.Drawing.Point(786, 610);
            this.zoomTrackBarControl1.Name = "zoomTrackBarControl1";
            this.zoomTrackBarControl1.Size = new System.Drawing.Size(104, 25);
            this.zoomTrackBarControl1.TabIndex = 1;
            // 
            // frmKhuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 640);
            this.Controls.Add(this.zoomTrackBarControl1);
            this.Controls.Add(this.treeList1);
            this.Name = "frmKhuon";
            this.Text = "frmKhuon";
            this.Load += new System.EventHandler(this.frmKhuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDonSanXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private NKVDataSet nKVDataSet;
        private System.Windows.Forms.BindingSource tbDonSanXuatBindingSource;
        private NKVDataSetTableAdapters.tbDonSanXuatTableAdapter tbDonSanXuatTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSCD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMaDonHang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPhienBan;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNgayXuongDon;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNgayGiaoHang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSoLuong;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLoaiSanPham;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVatLieu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colChuY;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenKhachHang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenSanPham;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colKichThuoc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colHinhMatPhai;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colHinhMatTrai;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMauMatPhai;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomTrackBarControl1;
    }
}