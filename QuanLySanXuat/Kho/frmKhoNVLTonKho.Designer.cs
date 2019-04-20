namespace QuanLySanXuat.Kho
{
    partial class frmKhoNVLTonKho
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
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.LayoutTop = new DevExpress.XtraLayout.LayoutControl();
            this.txtdenngay = new DevExpress.XtraEditors.DateEdit();
            this.txttungay = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.procTonKhoNVL_ViewGridControl = new DevExpress.XtraGrid.GridControl();
            this.Gridview1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloaihang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmahang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhanghoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltondauky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltongnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltongxuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltoncuoiky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHanSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutTop)).BeginInit();
            this.LayoutTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procTonKhoNVL_ViewGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.checkEdit1);
            this.panelTop.Controls.Add(this.btnXuatExcel);
            this.panelTop.Controls.Add(this.btnTim);
            this.panelTop.Controls.Add(this.LayoutTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(911, 31);
            this.panelTop.TabIndex = 17;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(602, 5);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "TỒN KHO TÍNH SỐ LOT";
            this.checkEdit1.Size = new System.Drawing.Size(166, 19);
            this.checkEdit1.TabIndex = 49;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Enabled = false;
            this.btnXuatExcel.Location = new System.Drawing.Point(484, 2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(100, 23);
            this.btnXuatExcel.TabIndex = 48;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(378, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 23);
            this.btnTim.TabIndex = 47;
            this.btnTim.Text = "TÌM";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // LayoutTop
            // 
            this.LayoutTop.Controls.Add(this.txtdenngay);
            this.LayoutTop.Controls.Add(this.txttungay);
            this.LayoutTop.Location = new System.Drawing.Point(2, 2);
            this.LayoutTop.Margin = new System.Windows.Forms.Padding(20);
            this.LayoutTop.Name = "LayoutTop";
            this.LayoutTop.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(606, 333, 450, 512);
            this.LayoutTop.Padding = new System.Windows.Forms.Padding(20);
            this.LayoutTop.Root = this.layoutControlGroup1;
            this.LayoutTop.Size = new System.Drawing.Size(372, 25);
            this.LayoutTop.TabIndex = 46;
            this.LayoutTop.Text = "layoutControl1";
            // 
            // txtdenngay
            // 
            this.txtdenngay.EditValue = new System.DateTime(2017, 10, 26, 0, 0, 0, 0);
            this.txtdenngay.Location = new System.Drawing.Point(244, 2);
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdenngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdenngay.Size = new System.Drawing.Size(126, 20);
            this.txtdenngay.StyleController = this.LayoutTop;
            this.txtdenngay.TabIndex = 2;
            // 
            // txttungay
            // 
            this.txttungay.EditValue = new System.DateTime(2017, 10, 26, 0, 0, 0, 0);
            this.txttungay.Location = new System.Drawing.Point(53, 2);
            this.txttungay.Name = "txttungay";
            this.txttungay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttungay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttungay.Size = new System.Drawing.Size(127, 20);
            this.txttungay.StyleController = this.LayoutTop;
            this.txttungay.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CaptionImageOptions.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(372, 25);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txttungay;
            this.layoutControlItem6.CustomizationFormText = "TỪ NGÀY:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(182, 25);
            this.layoutControlItem6.Text = "TỪ NGÀY:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtdenngay;
            this.layoutControlItem1.Location = new System.Drawing.Point(182, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(190, 25);
            this.layoutControlItem1.Text = "ĐẾN NGÀY:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // procTonKhoNVL_ViewGridControl
            // 
            this.procTonKhoNVL_ViewGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procTonKhoNVL_ViewGridControl.Location = new System.Drawing.Point(0, 31);
            this.procTonKhoNVL_ViewGridControl.MainView = this.Gridview1;
            this.procTonKhoNVL_ViewGridControl.Name = "procTonKhoNVL_ViewGridControl";
            this.procTonKhoNVL_ViewGridControl.Size = new System.Drawing.Size(911, 641);
            this.procTonKhoNVL_ViewGridControl.TabIndex = 18;
            this.procTonKhoNVL_ViewGridControl.UseEmbeddedNavigator = true;
            this.procTonKhoNVL_ViewGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gridview1});
            // 
            // Gridview1
            // 
            this.Gridview1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKho,
            this.colloaihang,
            this.colmahang,
            this.colmaAD,
            this.coltenhanghoa,
            this.coldonvitinh,
            this.colquycach,
            this.coltondauky,
            this.coltongnhap,
            this.coltongxuat,
            this.coltoncuoiky,
            this.colLo,
            this.colHanSuDung});
            this.Gridview1.GridControl = this.procTonKhoNVL_ViewGridControl;
            this.Gridview1.Name = "Gridview1";
            this.Gridview1.OptionsBehavior.Editable = false;
            this.Gridview1.OptionsFind.AlwaysVisible = true;
            this.Gridview1.OptionsView.ShowAutoFilterRow = true;
            this.Gridview1.OptionsView.ShowFooter = true;
            this.Gridview1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.Gridview1_RowCellStyle_1);
            // 
            // colKho
            // 
            this.colKho.Caption = "KHO";
            this.colKho.FieldName = "Kho";
            this.colKho.Name = "colKho";
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 0;
            // 
            // colloaihang
            // 
            this.colloaihang.Caption = "LOẠI HÀNG HÓA";
            this.colloaihang.FieldName = "loaihang";
            this.colloaihang.Name = "colloaihang";
            this.colloaihang.OptionsFilter.AllowFilter = false;
            this.colloaihang.Visible = true;
            this.colloaihang.VisibleIndex = 2;
            // 
            // colmahang
            // 
            this.colmahang.Caption = "MÃ HÀNG HÓA";
            this.colmahang.FieldName = "mahang";
            this.colmahang.Name = "colmahang";
            this.colmahang.Visible = true;
            this.colmahang.VisibleIndex = 3;
            // 
            // colmaAD
            // 
            this.colmaAD.Caption = "MÃ AVERY";
            this.colmaAD.FieldName = "maAD";
            this.colmaAD.Name = "colmaAD";
            this.colmaAD.Visible = true;
            this.colmaAD.VisibleIndex = 4;
            // 
            // coltenhanghoa
            // 
            this.coltenhanghoa.Caption = "TÊN HÀNG HÓA";
            this.coltenhanghoa.FieldName = "tenhanghoa";
            this.coltenhanghoa.Name = "coltenhanghoa";
            this.coltenhanghoa.Visible = true;
            this.coltenhanghoa.VisibleIndex = 5;
            this.coltenhanghoa.Width = 78;
            // 
            // coldonvitinh
            // 
            this.coldonvitinh.Caption = "ĐƠN VỊ TÍNH";
            this.coldonvitinh.FieldName = "donvitinh";
            this.coldonvitinh.Name = "coldonvitinh";
            this.coldonvitinh.Visible = true;
            this.coldonvitinh.VisibleIndex = 6;
            // 
            // colquycach
            // 
            this.colquycach.Caption = "QUY CÁCH";
            this.colquycach.FieldName = "quycach";
            this.colquycach.Name = "colquycach";
            this.colquycach.Visible = true;
            this.colquycach.VisibleIndex = 7;
            // 
            // coltondauky
            // 
            this.coltondauky.Caption = "TỒN ĐẦU KỲ";
            this.coltondauky.DisplayFormat.FormatString = "{0:0,#.#}";
            this.coltondauky.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coltondauky.FieldName = "tondauky";
            this.coltondauky.Name = "coltondauky";
            this.coltondauky.Visible = true;
            this.coltondauky.VisibleIndex = 9;
            // 
            // coltongnhap
            // 
            this.coltongnhap.Caption = "TỔNG NHẬP";
            this.coltongnhap.DisplayFormat.FormatString = "{0:0,#.#}";
            this.coltongnhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coltongnhap.FieldName = "tongnhap";
            this.coltongnhap.Name = "coltongnhap";
            this.coltongnhap.Visible = true;
            this.coltongnhap.VisibleIndex = 10;
            // 
            // coltongxuat
            // 
            this.coltongxuat.Caption = "TỔNG XUẤT";
            this.coltongxuat.DisplayFormat.FormatString = "{0:0,#.#}";
            this.coltongxuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coltongxuat.FieldName = "tongxuat";
            this.coltongxuat.Name = "coltongxuat";
            this.coltongxuat.Visible = true;
            this.coltongxuat.VisibleIndex = 11;
            // 
            // coltoncuoiky
            // 
            this.coltoncuoiky.Caption = "TỒN CUỐI KỲ";
            this.coltoncuoiky.DisplayFormat.FormatString = "{0:0,#.#}";
            this.coltoncuoiky.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coltoncuoiky.FieldName = "toncuoiky";
            this.coltoncuoiky.Name = "coltoncuoiky";
            this.coltoncuoiky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "toncuoiky", "TỔNG ={0:0,0.##}")});
            this.coltoncuoiky.Visible = true;
            this.coltoncuoiky.VisibleIndex = 12;
            // 
            // colLo
            // 
            this.colLo.Caption = "Lô ( Lot )";
            this.colLo.FieldName = "Lo";
            this.colLo.Name = "colLo";
            this.colLo.Visible = true;
            this.colLo.VisibleIndex = 1;
            // 
            // colHanSuDung
            // 
            this.colHanSuDung.Caption = "HanSuDung";
            this.colHanSuDung.FieldName = "HanSuDung";
            this.colHanSuDung.Name = "colHanSuDung";
            this.colHanSuDung.Visible = true;
            this.colHanSuDung.VisibleIndex = 8;
            // 
            // frmKhoNVLTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 672);
            this.Controls.Add(this.procTonKhoNVL_ViewGridControl);
            this.Controls.Add(this.panelTop);
            this.Name = "frmKhoNVLTonKho";
            this.Text = "TỒN KHO NGUYÊN VẬT LIỆU";
            this.Load += new System.EventHandler(this.frmKhoNVLTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutTop)).EndInit();
            this.LayoutTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procTonKhoNVL_ViewGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelTop;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcel;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraLayout.LayoutControl LayoutTop;
        private DevExpress.XtraEditors.DateEdit txtdenngay;
        private DevExpress.XtraEditors.DateEdit txttungay;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl procTonKhoNVL_ViewGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView Gridview1;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colloaihang;
        private DevExpress.XtraGrid.Columns.GridColumn colmahang;
        private DevExpress.XtraGrid.Columns.GridColumn colmaAD;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhanghoa;
        private DevExpress.XtraGrid.Columns.GridColumn coldonvitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colquycach;
        private DevExpress.XtraGrid.Columns.GridColumn coltondauky;
        private DevExpress.XtraGrid.Columns.GridColumn coltongnhap;
        private DevExpress.XtraGrid.Columns.GridColumn coltongxuat;
        private DevExpress.XtraGrid.Columns.GridColumn coltoncuoiky;
        private DevExpress.XtraGrid.Columns.GridColumn colLo;
        private DevExpress.XtraGrid.Columns.GridColumn colHanSuDung;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}