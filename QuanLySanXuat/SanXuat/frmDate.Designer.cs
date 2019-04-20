namespace QuanLySanXuat
{
    partial class frmDate
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
            this.components = new System.ComponentModel.Container();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.CalendarAppearance.DayCellSelected.ForeColor = System.Drawing.Color.Blue;
            this.dateNavigator1.CalendarAppearance.DayCellSelected.Options.UseForeColor = true;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator1.CalendarAppearance.WeekDay.ForeColor = System.Drawing.Color.SpringGreen;
            this.dateNavigator1.CalendarAppearance.WeekDay.Options.UseForeColor = true;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator1.CalendarTimeProperties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateNavigator1.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNavigator1.CalendarTimeProperties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateNavigator1.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNavigator1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dateNavigator1.Location = new System.Drawing.Point(12, 120);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(243, 255);
            this.dateNavigator1.TabIndex = 1;
            this.dateNavigator1.DoubleClick += new System.EventHandler(this.dateNavigator1_DoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "* Chọn ngày xuống đơn để in danh sách đơn ",
            "   sản xuất.",
            "* Danh sách đơn sản xuất chỉ in cho khách ",
            "   hàng Avery Dennison , Bộ phận Tem Vải",
            "* Double Click vào ngày cần in bên dưới ,",
            "sẽ hiện ra danh sách đơn sản xuất cần in"});
            this.listBox1.Location = new System.Drawing.Point(12, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(243, 94);
            this.listBox1.TabIndex = 2;
            // 
            // frmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 390);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateNavigator1);
            this.Name = "frmDate";
            this.Text = "frmDate";
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}