namespace QuanLySanXuat
{
    partial class frmCongThucAvery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongThucAvery));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MauSacSearch = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SoLuongTxt = new DevExpress.XtraEditors.SpinEdit();
            this.SoLuongDanTrangTxt = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Tongtxt = new DevExpress.XtraEditors.TextEdit();
            this.SoLuongSizeTxt = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MauSacSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongDanTrangTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tongtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongSizeTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImage")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(903, 440);
            this.pictureEdit1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.MauSacSearch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SoLuongTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SoLuongDanTrangTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Tongtxt, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.SoLuongSizeTxt, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 446);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 57);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MauSacSearch
            // 
            this.MauSacSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MauSacSearch.Location = new System.Drawing.Point(3, 31);
            this.MauSacSearch.Name = "MauSacSearch";
            this.MauSacSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MauSacSearch.Properties.NullText = "";
            this.MauSacSearch.Properties.View = this.searchLookUpEdit1View;
            this.MauSacSearch.Size = new System.Drawing.Size(122, 20);
            this.MauSacSearch.TabIndex = 0;
            this.MauSacSearch.EditValueChanged += new System.EventHandler(this.MauSacSearch_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // SoLuongTxt
            // 
            this.SoLuongTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoLuongTxt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SoLuongTxt.Location = new System.Drawing.Point(131, 31);
            this.SoLuongTxt.Name = "SoLuongTxt";
            this.SoLuongTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SoLuongTxt.Size = new System.Drawing.Size(122, 20);
            this.SoLuongTxt.TabIndex = 1;
            // 
            // SoLuongDanTrangTxt
            // 
            this.SoLuongDanTrangTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoLuongDanTrangTxt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SoLuongDanTrangTxt.Location = new System.Drawing.Point(259, 31);
            this.SoLuongDanTrangTxt.Name = "SoLuongDanTrangTxt";
            this.SoLuongDanTrangTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SoLuongDanTrangTxt.Size = new System.Drawing.Size(122, 20);
            this.SoLuongDanTrangTxt.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(515, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(123, 22);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "TÍNH";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Tongtxt
            // 
            this.Tongtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tongtxt.Location = new System.Drawing.Point(515, 31);
            this.Tongtxt.Name = "Tongtxt";
            this.Tongtxt.Size = new System.Drawing.Size(123, 20);
            this.Tongtxt.TabIndex = 30;
            // 
            // SoLuongSizeTxt
            // 
            this.SoLuongSizeTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoLuongSizeTxt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SoLuongSizeTxt.Location = new System.Drawing.Point(387, 31);
            this.SoLuongSizeTxt.Name = "SoLuongSizeTxt";
            this.SoLuongSizeTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SoLuongSizeTxt.Size = new System.Drawing.Size(122, 20);
            this.SoLuongSizeTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "MÀU SẮC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(131, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "SỐ LƯỢNG IN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(259, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "SỐ LƯỢNG DÀN TRANG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(387, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "SỐ LƯỢNG SIZE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCongThucAvery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "frmCongThucAvery";
            this.Text = "frmCongThucAvery";
            this.Load += new System.EventHandler(this.frmCongThucAvery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MauSacSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongDanTrangTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tongtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongSizeTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SearchLookUpEdit MauSacSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit Tongtxt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SpinEdit SoLuongTxt;
        private DevExpress.XtraEditors.SpinEdit SoLuongDanTrangTxt;
        private DevExpress.XtraEditors.SpinEdit SoLuongSizeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}