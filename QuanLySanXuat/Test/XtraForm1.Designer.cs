namespace QuanLySanXuat.Test
{
    partial class XtraForm1
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSoLanIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLanIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTinh = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRBO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGopDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXacNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(228, 727);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenSoLanIn,
            this.colSoLanIn,
            this.colTenSize,
            this.colSize,
            this.colTenSoLuong,
            this.colSoLuong});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colTenSoLanIn
            // 
            this.colTenSoLanIn.Caption = "TenSoLanIn";
            this.colTenSoLanIn.FieldName = "TenSoLanIn";
            this.colTenSoLanIn.Name = "colTenSoLanIn";
            // 
            // colSoLanIn
            // 
            this.colSoLanIn.Caption = "SoLanIn";
            this.colSoLanIn.FieldName = "SoLanIn";
            this.colSoLanIn.Name = "colSoLanIn";
            // 
            // colTenSize
            // 
            this.colTenSize.Caption = "TenSize";
            this.colTenSize.FieldName = "TenSize";
            this.colTenSize.Name = "colTenSize";
            // 
            // colSize
            // 
            this.colSize.Caption = "Size";
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 0;
            // 
            // colTenSoLuong
            // 
            this.colTenSoLuong.Caption = "TenSoLuong";
            this.colTenSoLuong.FieldName = "TenSoLuong";
            this.colTenSoLuong.Name = "colTenSoLuong";
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(3, 3);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(99, 34);
            this.btnTinh.TabIndex = 13;
            this.btnTinh.Text = "TÍNH";
            this.btnTinh.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(228, 41);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(884, 686);
            this.gridControl2.TabIndex = 14;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colOrderDate,
            this.colRequestDate,
            this.colSCD1,
            this.colSO,
            this.colRBO,
            this.colCustomerPO,
            this.colCustomerItem,
            this.colItem,
            this.colQty,
            this.colMaterial,
            this.colLength,
            this.colMaterialQty,
            this.colSKU,
            this.colCut,
            this.colFold,
            this.colGopDon,
            this.colXacNhan,
            this.colNhanVien});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView2.OptionsPrint.AutoResetPrintDocument = false;
            this.gridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsPrint.PrintPreview = true;
            this.gridView2.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView2.OptionsPrint.SplitCellPreviewAcrossPages = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNo
            // 
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 1;
            // 
            // colRequestDate
            // 
            this.colRequestDate.FieldName = "RequestDate";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.Visible = true;
            this.colRequestDate.VisibleIndex = 2;
            // 
            // colSCD1
            // 
            this.colSCD1.Caption = "SCD";
            this.colSCD1.FieldName = "scd";
            this.colSCD1.Name = "colSCD1";
            this.colSCD1.Visible = true;
            this.colSCD1.VisibleIndex = 3;
            // 
            // colSO
            // 
            this.colSO.FieldName = "SO";
            this.colSO.Name = "colSO";
            this.colSO.Visible = true;
            this.colSO.VisibleIndex = 4;
            // 
            // colRBO
            // 
            this.colRBO.FieldName = "RBO";
            this.colRBO.Name = "colRBO";
            this.colRBO.Visible = true;
            this.colRBO.VisibleIndex = 5;
            // 
            // colCustomerPO
            // 
            this.colCustomerPO.FieldName = "CustomerPO";
            this.colCustomerPO.Name = "colCustomerPO";
            // 
            // colCustomerItem
            // 
            this.colCustomerItem.FieldName = "CustomerItem";
            this.colCustomerItem.Name = "colCustomerItem";
            // 
            // colItem
            // 
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 6;
            // 
            // colQty
            // 
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "TỔNG = {0:#,#}")});
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 7;
            // 
            // colMaterial
            // 
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            // 
            // colLength
            // 
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 8;
            // 
            // colMaterialQty
            // 
            this.colMaterialQty.FieldName = "MaterialQty";
            this.colMaterialQty.Name = "colMaterialQty";
            // 
            // colSKU
            // 
            this.colSKU.FieldName = "SKU";
            this.colSKU.Name = "colSKU";
            this.colSKU.Visible = true;
            this.colSKU.VisibleIndex = 9;
            // 
            // colCut
            // 
            this.colCut.FieldName = "Cut";
            this.colCut.Name = "colCut";
            // 
            // colFold
            // 
            this.colFold.FieldName = "Fold";
            this.colFold.Name = "colFold";
            // 
            // colGopDon
            // 
            this.colGopDon.FieldName = "GopDon";
            this.colGopDon.Name = "colGopDon";
            this.colGopDon.Visible = true;
            this.colGopDon.VisibleIndex = 10;
            // 
            // colXacNhan
            // 
            this.colXacNhan.FieldName = "XacNhan";
            this.colXacNhan.Name = "colXacNhan";
            this.colXacNhan.Visible = true;
            this.colXacNhan.VisibleIndex = 11;
            // 
            // colNhanVien
            // 
            this.colNhanVien.Caption = "Nhân Viên";
            this.colNhanVien.FieldName = "NhanVien";
            this.colNhanVien.Name = "colNhanVien";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTinh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(228, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 41);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 727);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSoLanIn;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLanIn;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSize;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.SimpleButton btnTinh;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSCD1;
        private DevExpress.XtraGrid.Columns.GridColumn colSO;
        private DevExpress.XtraGrid.Columns.GridColumn colRBO;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPO;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerItem;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU;
        private DevExpress.XtraGrid.Columns.GridColumn colCut;
        private DevExpress.XtraGrid.Columns.GridColumn colFold;
        private DevExpress.XtraGrid.Columns.GridColumn colGopDon;
        private DevExpress.XtraGrid.Columns.GridColumn colXacNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}