namespace QuanLySanXuat
{
    partial class frmKhoGiayIn
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
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatGiay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiayLon = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(999, 615);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKhoIn,
            this.colCatGiay,
            this.colGiayLon});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colKhoIn
            // 
            this.colKhoIn.Caption = "Khổ In";
            this.colKhoIn.FieldName = "KhoIn";
            this.colKhoIn.Name = "colKhoIn";
            this.colKhoIn.Visible = true;
            this.colKhoIn.VisibleIndex = 1;
            // 
            // colCatGiay
            // 
            this.colCatGiay.Caption = "Cắt Giấy";
            this.colCatGiay.FieldName = "CatGiay";
            this.colCatGiay.Name = "colCatGiay";
            this.colCatGiay.Visible = true;
            this.colCatGiay.VisibleIndex = 2;
            // 
            // colGiayLon
            // 
            this.colGiayLon.Caption = "Quy Cách";
            this.colGiayLon.FieldName = "GiayLon";
            this.colGiayLon.Name = "colGiayLon";
            this.colGiayLon.Visible = true;
            this.colGiayLon.VisibleIndex = 3;
            // 
            // frmKhoGiayIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 615);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmKhoGiayIn";
            this.Text = "frmKhoGiayIn";
            this.Load += new System.EventHandler(this.frmKhoGiayIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoIn;
        private DevExpress.XtraGrid.Columns.GridColumn colCatGiay;
        private DevExpress.XtraGrid.Columns.GridColumn colGiayLon;
    }
}