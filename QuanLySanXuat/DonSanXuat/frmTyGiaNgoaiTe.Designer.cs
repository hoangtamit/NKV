namespace QuanLySanXuat.DonSanXuat
{
    partial class frmTyGiaNgoaiTe
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.CurrencyCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrencyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Buy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Transfer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackgroundImage = global::QuanLySanXuat.Properties.Resources.tien_te_005;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CurrencyCode,
            this.CurrencyName,
            this.Buy,
            this.Transfer,
            this.Sell});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(0, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(659, 365);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CurrencyCode
            // 
            this.CurrencyCode.Text = "MÃ TIỀN TỆ";
            this.CurrencyCode.Width = 120;
            // 
            // CurrencyName
            // 
            this.CurrencyName.Text = "TÊN TIỀN TỆ";
            this.CurrencyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrencyName.Width = 120;
            // 
            // Buy
            // 
            this.Buy.Text = "GIÁ MUA";
            this.Buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Buy.Width = 120;
            // 
            // Transfer
            // 
            this.Transfer.Text = "CHUYỂN KHOẢN";
            this.Transfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Transfer.Width = 120;
            // 
            // Sell
            // 
            this.Sell.Text = "GIÁ BÁN";
            this.Sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sell.Width = 120;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(659, 45);
            this.panelControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tỷ giá các ngoại tệ dựa trên website https://www.vietcombank.com.vn/exchangerates" +
    "/";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 35);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "LÀM MỚI";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmTyGiaNgoaiTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 410);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTyGiaNgoaiTe";
            this.Text = "TỶ GIÁ NGOẠI TỆ";
            this.Load += new System.EventHandler(this.frmTyGiaNgoaiTe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CurrencyCode;
        private System.Windows.Forms.ColumnHeader CurrencyName;
        private System.Windows.Forms.ColumnHeader Buy;
        private System.Windows.Forms.ColumnHeader Transfer;
        private System.Windows.Forms.ColumnHeader Sell;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
    }
}