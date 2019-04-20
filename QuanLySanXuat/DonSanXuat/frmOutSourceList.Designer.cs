namespace QuanLySanXuat.DonSanXuat
{
    partial class frmOutSourceList
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
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutSourceList));
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colDJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXacNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPaste = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.bbiOutSourceList = new DevExpress.XtraEditors.SimpleButton();
            this.btnPackingList = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDanhSach = new DevExpress.XtraEditors.SpinEdit();
            this.check = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDanhSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridControl1
            // 
            this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl1.Location = new System.Drawing.Point(0, 49);
            this.GridControl1.MainView = this.gridView1;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(1407, 616);
            this.GridControl1.TabIndex = 32;
            this.GridControl1.UseEmbeddedNavigator = true;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colDJ,
            this.colGopDon,
            this.colPO,
            this.colNote,
            this.colXacNhan,
            this.colSCD1,
            this.colDanhSach,
            this.colNhanVien});
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.GridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 1;
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView1.OptionsPrint.AutoResetPrintDocument = false;
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsPrint.SplitCellPreviewAcrossPages = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colNo
            // 
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 1;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 4;
            // 
            // colRequestDate
            // 
            this.colRequestDate.FieldName = "RequestDate";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.Visible = true;
            this.colRequestDate.VisibleIndex = 5;
            // 
            // colSO
            // 
            this.colSO.FieldName = "SO";
            this.colSO.Name = "colSO";
            this.colSO.Visible = true;
            this.colSO.VisibleIndex = 3;
            // 
            // colRBO
            // 
            this.colRBO.FieldName = "RBO";
            this.colRBO.Name = "colRBO";
            this.colRBO.Visible = true;
            this.colRBO.VisibleIndex = 6;
            // 
            // colCustomerPO
            // 
            this.colCustomerPO.FieldName = "CustomerPO";
            this.colCustomerPO.Name = "colCustomerPO";
            this.colCustomerPO.Visible = true;
            this.colCustomerPO.VisibleIndex = 7;
            // 
            // colCustomerItem
            // 
            this.colCustomerItem.FieldName = "CustomerItem";
            this.colCustomerItem.Name = "colCustomerItem";
            this.colCustomerItem.Visible = true;
            this.colCustomerItem.VisibleIndex = 8;
            // 
            // colItem
            // 
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 9;
            // 
            // colQty
            // 
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "TỔNG = {0:#,#}")});
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 10;
            // 
            // colMaterial
            // 
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 11;
            // 
            // colLength
            // 
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 12;
            // 
            // colMaterialQty
            // 
            this.colMaterialQty.FieldName = "MaterialQty";
            this.colMaterialQty.Name = "colMaterialQty";
            this.colMaterialQty.Visible = true;
            this.colMaterialQty.VisibleIndex = 13;
            // 
            // colSKU
            // 
            this.colSKU.FieldName = "SKU";
            this.colSKU.Name = "colSKU";
            this.colSKU.Visible = true;
            this.colSKU.VisibleIndex = 14;
            // 
            // colCut
            // 
            this.colCut.FieldName = "Cut";
            this.colCut.Name = "colCut";
            this.colCut.Visible = true;
            this.colCut.VisibleIndex = 15;
            // 
            // colFold
            // 
            this.colFold.FieldName = "Fold";
            this.colFold.Name = "colFold";
            this.colFold.Visible = true;
            this.colFold.VisibleIndex = 16;
            // 
            // colGopDon
            // 
            this.colGopDon.FieldName = "GopDon";
            this.colGopDon.Name = "colGopDon";
            this.colGopDon.Visible = true;
            this.colGopDon.VisibleIndex = 21;
            // 
            // colDJ
            // 
            this.colDJ.Caption = "DJ";
            this.colDJ.FieldName = "DJ";
            this.colDJ.Name = "colDJ";
            this.colDJ.Visible = true;
            this.colDJ.VisibleIndex = 17;
            // 
            // colPO
            // 
            this.colPO.Caption = "PO";
            this.colPO.FieldName = "PO";
            this.colPO.Name = "colPO";
            this.colPO.Visible = true;
            this.colPO.VisibleIndex = 18;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 19;
            // 
            // colXacNhan
            // 
            this.colXacNhan.FieldName = "XacNhan";
            this.colXacNhan.Name = "colXacNhan";
            // 
            // colSCD1
            // 
            this.colSCD1.Caption = "SCD";
            this.colSCD1.FieldName = "scd";
            this.colSCD1.Name = "colSCD1";
            this.colSCD1.Visible = true;
            this.colSCD1.VisibleIndex = 2;
            // 
            // colDanhSach
            // 
            this.colDanhSach.Caption = "Danh Sách";
            this.colDanhSach.FieldName = "DanhSach";
            this.colDanhSach.Name = "colDanhSach";
            this.colDanhSach.Visible = true;
            this.colDanhSach.VisibleIndex = 20;
            // 
            // colNhanVien
            // 
            this.colNhanVien.Caption = "Nhân Viên";
            this.colNhanVien.FieldName = "NhanVien";
            this.colNhanVien.Name = "colNhanVien";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPaste);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton6);
            this.flowLayoutPanel1.Controls.Add(this.bbiOutSourceList);
            this.flowLayoutPanel1.Controls.Add(this.btnPackingList);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.btnXoa);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dateEdit1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtDanhSach);
            this.flowLayoutPanel1.Controls.Add(this.check);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1403, 45);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // btnPaste
            // 
            this.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaste.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.ImageOptions.Image")));
            this.btnPaste.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPaste.ImageOptions.SvgImage")));
            this.btnPaste.Location = new System.Drawing.Point(3, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(100, 40);
            this.btnPaste.TabIndex = 8;
            this.btnPaste.Text = "PASTE";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(109, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton6.ImageOptions.Image = global::QuanLySanXuat.Properties.Resources.apply_32x32;
            this.simpleButton6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.simpleButton6.Location = new System.Drawing.Point(215, 3);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(114, 40);
            this.simpleButton6.TabIndex = 42;
            this.simpleButton6.Text = "CONFIRM";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // bbiOutSourceList
            // 
            this.bbiOutSourceList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiOutSourceList.ImageOptions.Image")));
            this.bbiOutSourceList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiOutSourceList.ImageOptions.SvgImage")));
            this.bbiOutSourceList.Location = new System.Drawing.Point(335, 3);
            this.bbiOutSourceList.Name = "bbiOutSourceList";
            this.bbiOutSourceList.Size = new System.Drawing.Size(142, 40);
            this.bbiOutSourceList.TabIndex = 44;
            this.bbiOutSourceList.Text = "OUT SOURCE LIST";
            this.bbiOutSourceList.Click += new System.EventHandler(this.bbiOutSourceList_Click);
            // 
            // btnPackingList
            // 
            this.btnPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPackingList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPackingList.ImageOptions.Image")));
            this.btnPackingList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPackingList.ImageOptions.SvgImage")));
            this.btnPackingList.Location = new System.Drawing.Point(483, 3);
            this.btnPackingList.Name = "btnPackingList";
            this.btnPackingList.Size = new System.Drawing.Size(127, 40);
            this.btnPackingList.TabIndex = 6;
            this.btnPackingList.Text = "PACKING LIST";
            this.btnPackingList.Click += new System.EventHandler(this.btnPackingList_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(616, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 40);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Location = new System.Drawing.Point(722, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 40);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "DELETE";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 46);
            this.label2.TabIndex = 45;
            this.label2.Text = "NGÀY XUỐNG ĐƠN:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(((long)(0)));
            this.dateEdit1.Location = new System.Drawing.Point(937, 3);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(171, 40);
            this.dateEdit1.TabIndex = 46;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1114, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "LIST:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDanhSach.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDanhSach.Location = new System.Drawing.Point(1155, 3);
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhSach.Properties.Appearance.Options.UseFont = true;
            this.txtDanhSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDanhSach.Properties.IsFloatValue = false;
            this.txtDanhSach.Properties.Mask.EditMask = "N00";
            this.txtDanhSach.Size = new System.Drawing.Size(50, 40);
            this.txtDanhSach.TabIndex = 12;
            this.txtDanhSach.EditValueChanged += new System.EventHandler(this.txtDanhSach_EditValueChanged);
            // 
            // check
            // 
            this.check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check.Location = new System.Drawing.Point(1211, 3);
            this.check.Name = "check";
            this.check.Properties.Caption = "All Out Source List";
            this.check.Size = new System.Drawing.Size(131, 40);
            this.check.TabIndex = 9;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1407, 49);
            this.panelControl1.TabIndex = 31;
            // 
            // frmOutSourceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 665);
            this.Controls.Add(this.GridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmOutSourceList";
            this.Text = "Out Source List";
            this.Load += new System.EventHandler(this.frmOutSourceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDanhSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSO;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnPaste;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnPackingList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRBO;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPO;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerItem;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSKU;
        private DevExpress.XtraGrid.Columns.GridColumn colCut;
        private DevExpress.XtraGrid.Columns.GridColumn colFold;
        private DevExpress.XtraGrid.Columns.GridColumn colGopDon;
        private DevExpress.XtraGrid.Columns.GridColumn colDJ;
        private DevExpress.XtraGrid.Columns.GridColumn colPO;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colXacNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colSCD1;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSach;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit txtDanhSach;
        private DevExpress.XtraEditors.CheckEdit check;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton bbiOutSourceList;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}