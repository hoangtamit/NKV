﻿namespace QuanLySanXuat.Kho
{
    partial class frmDonViTinh
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonViTinh));
            this.tbDonViTinhGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENGIAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbDonViTinhGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDonViTinhGridControl
            // 
            this.tbDonViTinhGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDonViTinhGridControl.Location = new System.Drawing.Point(0, 0);
            this.tbDonViTinhGridControl.MainView = this.gridView1;
            this.tbDonViTinhGridControl.Name = "tbDonViTinhGridControl";
            this.tbDonViTinhGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Xoa});
            this.tbDonViTinhGridControl.Size = new System.Drawing.Size(563, 489);
            this.tbDonViTinhGridControl.TabIndex = 1;
            this.tbDonViTinhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDelete,
            this.colID,
            this.colDIENGIAI,
            this.colTINHTRANG,
            this.colGHICHU});
            this.gridView1.GridControl = this.tbDonViTinhGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Xóa";
            this.colDelete.ColumnEdit = this.Xoa;
            this.colDelete.FieldName = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 37;
            // 
            // Xoa
            // 
            this.Xoa.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.Xoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.Xoa.Name = "Xoa";
            this.Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.Xoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Xoa_ButtonClick);
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 390;
            // 
            // colDIENGIAI
            // 
            this.colDIENGIAI.FieldName = "DIENGIAI";
            this.colDIENGIAI.Name = "colDIENGIAI";
            this.colDIENGIAI.Visible = true;
            this.colDIENGIAI.VisibleIndex = 2;
            this.colDIENGIAI.Width = 390;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.FieldName = "TINHTRANG";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Visible = true;
            this.colTINHTRANG.VisibleIndex = 3;
            this.colTINHTRANG.Width = 390;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 4;
            this.colGHICHU.Width = 396;
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 489);
            this.Controls.Add(this.tbDonViTinhGridControl);
            this.Name = "frmDonViTinh";
            this.Text = "ĐƠN VỊ TÍNH";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDonViTinhGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl tbDonViTinhGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Xoa;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENGIAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
    }
}