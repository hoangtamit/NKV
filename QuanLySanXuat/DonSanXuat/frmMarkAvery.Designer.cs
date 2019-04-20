namespace QuanLySanXuat.DonSanXuat
{
    partial class frmMarkAvery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarkAvery));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.tbMarkAveryGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRBO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPDLINE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTYLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSJOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGWT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRQD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkAveryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnXuat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(984, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(198, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(90, 31);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "XÓA";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 32);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Import";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(102, 4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(90, 31);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "XUẤT";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click_1);
            // 
            // tbMarkAveryGridControl
            // 
            this.tbMarkAveryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMarkAveryGridControl.Location = new System.Drawing.Point(0, 42);
            this.tbMarkAveryGridControl.MainView = this.gridView1;
            this.tbMarkAveryGridControl.Name = "tbMarkAveryGridControl";
            this.tbMarkAveryGridControl.Size = new System.Drawing.Size(984, 581);
            this.tbMarkAveryGridControl.TabIndex = 2;
            this.tbMarkAveryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colRBO,
            this.colSO,
            this.colOP_NO,
            this.colPDLINE,
            this.colSTYLE,
            this.colITEM,
            this.colSIZE,
            this.colQTY,
            this.colCUSPO,
            this.colCUSJOB,
            this.colGWT,
            this.colDATE,
            this.colATO,
            this.colSIREMARK,
            this.colRQD});
            this.gridView1.GridControl = this.tbMarkAveryGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colRBO
            // 
            this.colRBO.FieldName = "RBO";
            this.colRBO.Name = "colRBO";
            this.colRBO.Visible = true;
            this.colRBO.VisibleIndex = 1;
            // 
            // colSO
            // 
            this.colSO.FieldName = "SO";
            this.colSO.Name = "colSO";
            this.colSO.Visible = true;
            this.colSO.VisibleIndex = 2;
            // 
            // colOP_NO
            // 
            this.colOP_NO.FieldName = "OP_NO";
            this.colOP_NO.Name = "colOP_NO";
            this.colOP_NO.Visible = true;
            this.colOP_NO.VisibleIndex = 3;
            // 
            // colPDLINE
            // 
            this.colPDLINE.FieldName = "PDLINE";
            this.colPDLINE.Name = "colPDLINE";
            this.colPDLINE.Visible = true;
            this.colPDLINE.VisibleIndex = 4;
            // 
            // colSTYLE
            // 
            this.colSTYLE.FieldName = "STYLE";
            this.colSTYLE.Name = "colSTYLE";
            this.colSTYLE.Visible = true;
            this.colSTYLE.VisibleIndex = 5;
            // 
            // colITEM
            // 
            this.colITEM.FieldName = "ITEM";
            this.colITEM.Name = "colITEM";
            this.colITEM.Visible = true;
            this.colITEM.VisibleIndex = 6;
            // 
            // colSIZE
            // 
            this.colSIZE.FieldName = "SIZE";
            this.colSIZE.Name = "colSIZE";
            this.colSIZE.Visible = true;
            this.colSIZE.VisibleIndex = 7;
            // 
            // colQTY
            // 
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 8;
            // 
            // colCUSPO
            // 
            this.colCUSPO.FieldName = "CUSPO";
            this.colCUSPO.Name = "colCUSPO";
            this.colCUSPO.Visible = true;
            this.colCUSPO.VisibleIndex = 9;
            // 
            // colCUSJOB
            // 
            this.colCUSJOB.FieldName = "CUSJOB";
            this.colCUSJOB.Name = "colCUSJOB";
            this.colCUSJOB.Visible = true;
            this.colCUSJOB.VisibleIndex = 10;
            // 
            // colGWT
            // 
            this.colGWT.FieldName = "GWT";
            this.colGWT.Name = "colGWT";
            this.colGWT.Visible = true;
            this.colGWT.VisibleIndex = 11;
            // 
            // colDATE
            // 
            this.colDATE.FieldName = "DATE";
            this.colDATE.Name = "colDATE";
            this.colDATE.Visible = true;
            this.colDATE.VisibleIndex = 12;
            // 
            // colATO
            // 
            this.colATO.FieldName = "ATO";
            this.colATO.Name = "colATO";
            this.colATO.Visible = true;
            this.colATO.VisibleIndex = 13;
            // 
            // colSIREMARK
            // 
            this.colSIREMARK.FieldName = "SIREMARK";
            this.colSIREMARK.Name = "colSIREMARK";
            this.colSIREMARK.Visible = true;
            this.colSIREMARK.VisibleIndex = 14;
            // 
            // colRQD
            // 
            this.colRQD.FieldName = "RQD";
            this.colRQD.Name = "colRQD";
            this.colRQD.Visible = true;
            this.colRQD.VisibleIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMarkAvery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 623);
            this.Controls.Add(this.tbMarkAveryGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmMarkAvery";
            this.Text = "frmMarkAvery";
            this.Load += new System.EventHandler(this.frmMarkAvery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkAveryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl tbMarkAveryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colRBO;
        private DevExpress.XtraGrid.Columns.GridColumn colSO;
        private DevExpress.XtraGrid.Columns.GridColumn colOP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPDLINE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTYLE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM;
        private DevExpress.XtraGrid.Columns.GridColumn colSIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSPO;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSJOB;
        private DevExpress.XtraGrid.Columns.GridColumn colGWT;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colATO;
        private DevExpress.XtraGrid.Columns.GridColumn colSIREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colRQD;
    }
}