namespace QuanLySanXuat
{
    partial class frmQuyDinhThietKe
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage6 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage7 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Controls.Add(this.tabNavigationPage6);
            this.tabPane1.Controls.Add(this.tabNavigationPage7);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage7,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4,
            this.tabNavigationPage5,
            this.tabNavigationPage6});
            this.tabPane1.RegularSize = new System.Drawing.Size(970, 626);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(970, 626);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "THIẾT KẾ";
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(948, 585);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "OFFSET";
            this.tabNavigationPage2.Controls.Add(this.listBox1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(948, 585);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "TEM VẢI";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(970, 626);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "STICKER";
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(970, 626);
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.Caption = "KỸ THUẬT SỐ";
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.Size = new System.Drawing.Size(970, 626);
            // 
            // tabNavigationPage6
            // 
            this.tabNavigationPage6.Caption = "IN CHỮ VI TÍNH";
            this.tabNavigationPage6.Name = "tabNavigationPage6";
            this.tabNavigationPage6.Size = new System.Drawing.Size(970, 626);
            // 
            // tabNavigationPage7
            // 
            this.tabNavigationPage7.Caption = "DANH THIẾP";
            this.tabNavigationPage7.Name = "tabNavigationPage7";
            this.tabNavigationPage7.Size = new System.Drawing.Size(948, 585);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "-Kích thước bản kẽm : 605*745",
            "-Khoảng cách nhiếp 60",
            "-Dàn trang chiều rộng > 230 , chiều dài < 590,",
            "-Dàn trang khoảng cách từ 2 – 4 mm ,làm khuôn bế khoảng cách nhỏ nhất 3mm",
            "-In 2 mặt theo chiều dọc     thì 1 mặt xoay 180, và 2 mặt tạo trên cùng 1 file pd" +
                "f (2 Artbroads) ",
            "-Những kích thước nhỏ sử dụng giấy kích thước 8K, 9K, 10K",
            "-Khi dàn trang phải để ý xớ giấy, xem dàn có đúng chiều xớ giấy không.",
            "-Dàn trang phải biết tiết kiệm giấy và đúng các yêu cầu trên ",
            "-Sau khi làm xong in ra file A4, và kiểm tra lại file vừa mới làm xong trước xuất" +
                " bản kẽm.",
            "-Khi đơn hàng bế số lượng 10.000 có cán màn hoặc số lượng 20.000 ko có cán màn th" +
                "ì dùng khuôn nhật."});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(948, 585);
            this.listBox1.TabIndex = 0;
            // 
            // frmQuyDinhThietKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 626);
            this.Controls.Add(this.tabPane1);
            this.Name = "frmQuyDinhThietKe";
            this.Text = "QUY ĐỊNH THIẾT KẾ";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage6;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage7;
        private System.Windows.Forms.ListBox listBox1;
    }
}