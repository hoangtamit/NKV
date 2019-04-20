namespace QuanLySanXuat.DonSanXuat
{
    partial class frmDonHang_Avery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang_Avery));
            this.tbDonSanXuat_AveryGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkvalue = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.hiendonhang = new DevExpress.XtraEditors.CheckEdit();
            this.tblTool = new System.Windows.Forms.TableLayoutPanel();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbDonSanXuat_AveryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiendonhang.Properties)).BeginInit();
            this.tblTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDonSanXuat_AveryGridControl
            // 
            this.tbDonSanXuat_AveryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDonSanXuat_AveryGridControl.Location = new System.Drawing.Point(0, 42);
            this.tbDonSanXuat_AveryGridControl.MainView = this.gridView1;
            this.tbDonSanXuat_AveryGridControl.Name = "tbDonSanXuat_AveryGridControl";
            this.tbDonSanXuat_AveryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkvalue});
            this.tbDonSanXuat_AveryGridControl.Size = new System.Drawing.Size(1084, 530);
            this.tbDonSanXuat_AveryGridControl.TabIndex = 1;
            this.tbDonSanXuat_AveryGridControl.UseEmbeddedNavigator = true;
            this.tbDonSanXuat_AveryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.tbDonSanXuat_AveryGridControl.Click += new System.EventHandler(this.tbDonSanXuat_AveryGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colNo,
            this.colOrderDate,
            this.colRequestDate,
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
            this.colPrice,
            this.colTongTien});
            this.gridView1.GridControl = this.tbDonSanXuat_AveryGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colCheck
            // 
            this.colCheck.Caption = "Check";
            this.colCheck.ColumnEdit = this.checkvalue;
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            // 
            // checkvalue
            // 
            this.checkvalue.AutoHeight = false;
            this.checkvalue.Name = "checkvalue";
            this.checkvalue.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colNo
            // 
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 1;
            this.colNo.Width = 84;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            this.colOrderDate.Width = 76;
            // 
            // colRequestDate
            // 
            this.colRequestDate.FieldName = "RequestDate";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.Visible = true;
            this.colRequestDate.VisibleIndex = 3;
            this.colRequestDate.Width = 84;
            // 
            // colSO
            // 
            this.colSO.FieldName = "SO";
            this.colSO.Name = "colSO";
            this.colSO.Visible = true;
            this.colSO.VisibleIndex = 4;
            this.colSO.Width = 84;
            // 
            // colRBO
            // 
            this.colRBO.FieldName = "RBO";
            this.colRBO.Name = "colRBO";
            this.colRBO.Visible = true;
            this.colRBO.VisibleIndex = 5;
            this.colRBO.Width = 84;
            // 
            // colCustomerPO
            // 
            this.colCustomerPO.FieldName = "CustomerPO";
            this.colCustomerPO.Name = "colCustomerPO";
            this.colCustomerPO.Visible = true;
            this.colCustomerPO.VisibleIndex = 6;
            this.colCustomerPO.Width = 84;
            // 
            // colCustomerItem
            // 
            this.colCustomerItem.FieldName = "CustomerItem";
            this.colCustomerItem.Name = "colCustomerItem";
            this.colCustomerItem.Visible = true;
            this.colCustomerItem.VisibleIndex = 7;
            this.colCustomerItem.Width = 84;
            // 
            // colItem
            // 
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 8;
            this.colItem.Width = 84;
            // 
            // colQty
            // 
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 9;
            this.colQty.Width = 84;
            // 
            // colMaterial
            // 
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 10;
            this.colMaterial.Width = 84;
            // 
            // colLength
            // 
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 11;
            this.colLength.Width = 84;
            // 
            // colMaterialQty
            // 
            this.colMaterialQty.FieldName = "MaterialQty";
            this.colMaterialQty.Name = "colMaterialQty";
            this.colMaterialQty.Visible = true;
            this.colMaterialQty.VisibleIndex = 12;
            this.colMaterialQty.Width = 84;
            // 
            // colSKU
            // 
            this.colSKU.FieldName = "SKU";
            this.colSKU.Name = "colSKU";
            this.colSKU.Visible = true;
            this.colSKU.VisibleIndex = 13;
            this.colSKU.Width = 84;
            // 
            // colCut
            // 
            this.colCut.FieldName = "Cut";
            this.colCut.Name = "colCut";
            this.colCut.Visible = true;
            this.colCut.VisibleIndex = 14;
            this.colCut.Width = 84;
            // 
            // colFold
            // 
            this.colFold.FieldName = "Fold";
            this.colFold.Name = "colFold";
            this.colFold.Visible = true;
            this.colFold.VisibleIndex = 15;
            this.colFold.Width = 84;
            // 
            // colGopDon
            // 
            this.colGopDon.FieldName = "GopDon";
            this.colGopDon.Name = "colGopDon";
            this.colGopDon.Visible = true;
            this.colGopDon.VisibleIndex = 16;
            this.colGopDon.Width = 84;
            // 
            // colXacNhan
            // 
            this.colXacNhan.FieldName = "XacNhan";
            this.colXacNhan.Name = "colXacNhan";
            this.colXacNhan.Visible = true;
            this.colXacNhan.VisibleIndex = 17;
            this.colXacNhan.Width = 84;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Giá Tiền";
            this.colPrice.DisplayFormat.FormatString = "{0:#,#}";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 18;
            this.colPrice.Width = 84;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.DisplayFormat.FormatString = "{0:#,#}";
            this.colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTien", "SUM={0:#,#}")});
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 19;
            this.colTongTien.Width = 96;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Controls.Add(this.hiendonhang);
            this.panelControl1.Controls.Add(this.tblTool);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 42);
            this.panelControl1.TabIndex = 3;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(526, 11);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(85, 20);
            this.dateEdit1.TabIndex = 41;
            // 
            // hiendonhang
            // 
            this.hiendonhang.Location = new System.Drawing.Point(347, 11);
            this.hiendonhang.Name = "hiendonhang";
            this.hiendonhang.Properties.Caption = "HIỆN TẤT CẢ ĐƠN HÀNG";
            this.hiendonhang.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.hiendonhang.Size = new System.Drawing.Size(152, 19);
            this.hiendonhang.TabIndex = 40;
            this.hiendonhang.CheckedChanged += new System.EventHandler(this.hiendonhang_CheckedChanged);
            // 
            // tblTool
            // 
            this.tblTool.ColumnCount = 3;
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tblTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblTool.Controls.Add(this.btnXacNhan, 0, 0);
            this.tblTool.Controls.Add(this.btnin, 1, 0);
            this.tblTool.Controls.Add(this.btnHuy, 2, 0);
            this.tblTool.Location = new System.Drawing.Point(5, 4);
            this.tblTool.Name = "tblTool";
            this.tblTool.RowCount = 1;
            this.tblTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTool.Size = new System.Drawing.Size(318, 35);
            this.tblTool.TabIndex = 38;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
            this.btnXacNhan.Location = new System.Drawing.Point(3, 3);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(114, 29);
            this.btnXacNhan.TabIndex = 41;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnin
            // 
            this.btnin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnin.Location = new System.Drawing.Point(123, 3);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(92, 29);
            this.btnin.TabIndex = 31;
            this.btnin.Text = "IN";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnHuy.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btnHuy.Location = new System.Drawing.Point(221, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "LÀM MỚI";
            this.btnHuy.Click += new System.EventHandler(this.frmDonHang_Avery_Load);
            // 
            // frmDonHang_Avery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 572);
            this.Controls.Add(this.tbDonSanXuat_AveryGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDonHang_Avery";
            this.Text = "ĐƠN HÀNG AVERY";
            this.Load += new System.EventHandler(this.frmDonHang_Avery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDonSanXuat_AveryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiendonhang.Properties)).EndInit();
            this.tblTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl tbDonSanXuat_AveryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestDate;
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
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkvalue;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.CheckEdit hiendonhang;
        private System.Windows.Forms.TableLayoutPanel tblTool;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}