namespace QuanLySanXuat.Kho
{
    partial class frmMaHangHoa
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaHangHoa));
            this.tbMaHangHoaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENGIAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaHangHoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMaHangHoaGridControl
            // 
            this.tbMaHangHoaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMaHangHoaGridControl.Location = new System.Drawing.Point(0, 0);
            this.tbMaHangHoaGridControl.MainView = this.gridView1;
            this.tbMaHangHoaGridControl.Name = "tbMaHangHoaGridControl";
            this.tbMaHangHoaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Xoa});
            this.tbMaHangHoaGridControl.Size = new System.Drawing.Size(589, 429);
            this.tbMaHangHoaGridControl.TabIndex = 1;
            this.tbMaHangHoaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDelete,
            this.colIDMaHang,
            this.colDIENGIAI,
            this.colTINHTRANG,
            this.colGHICHU});
            this.gridView1.GridControl = this.tbMaHangHoaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Xóa";
            this.colDelete.ColumnEdit = this.Xoa;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 27;
            // 
            // colIDMaHang
            // 
            this.colIDMaHang.FieldName = "IDMaHang";
            this.colIDMaHang.Name = "colIDMaHang";
            this.colIDMaHang.Visible = true;
            this.colIDMaHang.VisibleIndex = 1;
            this.colIDMaHang.Width = 384;
            // 
            // colDIENGIAI
            // 
            this.colDIENGIAI.FieldName = "DIENGIAI";
            this.colDIENGIAI.Name = "colDIENGIAI";
            this.colDIENGIAI.Visible = true;
            this.colDIENGIAI.VisibleIndex = 2;
            this.colDIENGIAI.Width = 384;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.FieldName = "TINHTRANG";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Visible = true;
            this.colTINHTRANG.VisibleIndex = 3;
            this.colTINHTRANG.Width = 384;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 4;
            this.colGHICHU.Width = 424;
            // 
            // Xoa
            // 
            this.Xoa.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.Xoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.Xoa.Name = "Xoa";
            this.Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // frmMaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 429);
            this.Controls.Add(this.tbMaHangHoaGridControl);
            this.Name = "frmMaHangHoa";
            this.Text = "MÃ HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmMaHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMaHangHoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl tbMaHangHoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENGIAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Xoa;
    }
}