namespace QuanLySanXuat.MyDung
{
    partial class rpMyDungSticker
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpMyDungSticker));
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator1 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrSoLuong = new DevExpress.XtraReports.UI.XRLabel();
            this.panel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrItemCode2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrTana = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLocation = new DevExpress.XtraReports.UI.XRRichText();
            this.xrJanCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrItemName = new DevExpress.XtraReports.UI.XRRichText();
            this.xrItemCode = new DevExpress.XtraReports.UI.XRRichText();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrNgay = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrKichThuoc = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrMau = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.xrItemCode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QuanLySanXuat.Properties.Settings.NKVConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "JanCode";
            table1.Name = "tbMyDungSticker";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ItemCode";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "ItemName";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Tana";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Location";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Irisu";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "tbMyDungSticker";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSoLuong,
            this.panel1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 358.42F;
            this.Detail.MultiColumn.ColumnSpacing = 50F;
            this.Detail.MultiColumn.ColumnWidth = 420F;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            // 
            // xrSoLuong
            // 
            this.xrSoLuong.Dpi = 254F;
            this.xrSoLuong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrSoLuong.LocationFloat = new DevExpress.Utils.PointFloat(0F, 300F);
            this.xrSoLuong.Multiline = true;
            this.xrSoLuong.Name = "xrSoLuong";
            this.xrSoLuong.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrSoLuong.SizeF = new System.Drawing.SizeF(213.5074F, 42.7507F);
            this.xrSoLuong.StylePriority.UseFont = false;
            this.xrSoLuong.StylePriority.UseTextAlignment = false;
            this.xrSoLuong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrSoLuong.TextFormatString = "{0:#,# PCS}";
            // 
            // panel1
            // 
            this.panel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.panel1.CanGrow = false;
            this.panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrItemCode2,
            this.xrTana,
            this.xrLine1,
            this.xrLocation,
            this.xrJanCode,
            this.xrItemName,
            this.xrItemCode});
            this.panel1.Dpi = 254F;
            this.panel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.SizeF = new System.Drawing.SizeF(420F, 300F);
            // 
            // xrItemCode2
            // 
            this.xrItemCode2.BorderColor = System.Drawing.Color.Transparent;
            this.xrItemCode2.Dpi = 254F;
            this.xrItemCode2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrItemCode2.LocationFloat = new DevExpress.Utils.PointFloat(213.5075F, 25F);
            this.xrItemCode2.Name = "xrItemCode2";
            this.xrItemCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrItemCode2.SerializableRtfString = resources.GetString("xrItemCode2.SerializableRtfString");
            this.xrItemCode2.SizeF = new System.Drawing.SizeF(153.0803F, 45.19084F);
            this.xrItemCode2.StylePriority.UseBorderColor = false;
            this.xrItemCode2.StylePriority.UseFont = false;
            // 
            // xrTana
            // 
            this.xrTana.BorderColor = System.Drawing.Color.Transparent;
            this.xrTana.Dpi = 254F;
            this.xrTana.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTana.LocationFloat = new DevExpress.Utils.PointFloat(255.4087F, 212.097F);
            this.xrTana.Name = "xrTana";
            this.xrTana.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.xrTana.SerializableRtfString = resources.GetString("xrTana.SerializableRtfString");
            this.xrTana.SizeF = new System.Drawing.SizeF(94.17912F, 31.41042F);
            this.xrTana.StylePriority.UseBorderColor = false;
            this.xrTana.StylePriority.UseFont = false;
            this.xrTana.StylePriority.UsePadding = false;
            // 
            // xrLine1
            // 
            this.xrLine1.BorderColor = System.Drawing.Color.Transparent;
            this.xrLine1.Dpi = 254F;
            this.xrLine1.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(238.1005F, 218.8354F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(17.30818F, 23.34903F);
            this.xrLine1.StylePriority.UseBorderColor = false;
            // 
            // xrLocation
            // 
            this.xrLocation.BorderColor = System.Drawing.Color.Transparent;
            this.xrLocation.Dpi = 254F;
            this.xrLocation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLocation.LocationFloat = new DevExpress.Utils.PointFloat(63.27076F, 212.097F);
            this.xrLocation.Name = "xrLocation";
            this.xrLocation.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.xrLocation.SerializableRtfString = resources.GetString("xrLocation.SerializableRtfString");
            this.xrLocation.SizeF = new System.Drawing.SizeF(163.9156F, 31.41042F);
            this.xrLocation.StylePriority.UseBorderColor = false;
            this.xrLocation.StylePriority.UseFont = false;
            this.xrLocation.StylePriority.UsePadding = false;
            // 
            // xrJanCode
            // 
            this.xrJanCode.AutoModule = true;
            this.xrJanCode.BorderColor = System.Drawing.Color.Transparent;
            this.xrJanCode.Dpi = 254F;
            this.xrJanCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrJanCode.LocationFloat = new DevExpress.Utils.PointFloat(36.9236F, 100.4579F);
            this.xrJanCode.Module = 1F;
            this.xrJanCode.Name = "xrJanCode";
            this.xrJanCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.xrJanCode.SizeF = new System.Drawing.SizeF(333.4529F, 123.6391F);
            this.xrJanCode.StylePriority.UseBorderColor = false;
            this.xrJanCode.StylePriority.UseFont = false;
            this.xrJanCode.StylePriority.UsePadding = false;
            this.xrJanCode.StylePriority.UseTextAlignment = false;
            this.xrJanCode.Symbology = eaN13Generator1;
            // 
            // xrItemName
            // 
            this.xrItemName.BorderColor = System.Drawing.Color.Transparent;
            this.xrItemName.Dpi = 254F;
            this.xrItemName.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.xrItemName.LocationFloat = new DevExpress.Utils.PointFloat(43.9236F, 64.19084F);
            this.xrItemName.Name = "xrItemName";
            this.xrItemName.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.xrItemName.SerializableRtfString = resources.GetString("xrItemName.SerializableRtfString");
            this.xrItemName.SizeF = new System.Drawing.SizeF(357.0764F, 39.89915F);
            this.xrItemName.StylePriority.UseBorderColor = false;
            this.xrItemName.StylePriority.UseFont = false;
            this.xrItemName.StylePriority.UsePadding = false;
            // 
            // xrItemCode
            // 
            this.xrItemCode.BorderColor = System.Drawing.Color.Transparent;
            this.xrItemCode.Dpi = 254F;
            this.xrItemCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrItemCode.LocationFloat = new DevExpress.Utils.PointFloat(43.9236F, 25F);
            this.xrItemCode.Name = "xrItemCode";
            this.xrItemCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrItemCode.SerializableRtfString = resources.GetString("xrItemCode.SerializableRtfString");
            this.xrItemCode.SizeF = new System.Drawing.SizeF(169.5838F, 45.19084F);
            this.xrItemCode.StylePriority.UseBorderColor = false;
            this.xrItemCode.StylePriority.UseFont = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrTable1,
            this.xrLabel4,
            this.label4,
            this.xrPictureBox1});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 349.7351F;
            this.TopMargin.Name = "TopMargin";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.ForeColor = System.Drawing.Color.Red;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 243.6927F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(1900F, 78.48105F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "DỮ LIỆU STICKER MỸ DUNG";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 254F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(1334.877F, 24.54276F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4});
            this.xrTable1.SizeF = new System.Drawing.SizeF(565.123F, 206.9167F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrNgay});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Datetime:";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 0.64422676329253237D;
            // 
            // xrNgay
            // 
            this.xrNgay.Dpi = 254F;
            this.xrNgay.Multiline = true;
            this.xrNgay.Name = "xrNgay";
            this.xrNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrNgay.TextFormatString = "{0:dd/MM/yyyy}";
            this.xrNgay.Weight = 1.3557732367074677D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrName});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Designer:";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell3.Weight = 0.64422676329253237D;
            // 
            // xrName
            // 
            this.xrName.Dpi = 254F;
            this.xrName.Multiline = true;
            this.xrName.Name = "xrName";
            this.xrName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrName.Weight = 1.3557732367074677D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrKichThuoc});
            this.xrTableRow3.Dpi = 254F;
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Dpi = 254F;
            this.xrTableCell5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Size:";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell5.Weight = 0.64422676329253237D;
            // 
            // xrKichThuoc
            // 
            this.xrKichThuoc.Dpi = 254F;
            this.xrKichThuoc.Multiline = true;
            this.xrKichThuoc.Name = "xrKichThuoc";
            this.xrKichThuoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrKichThuoc.Text = "30*42mm";
            this.xrKichThuoc.Weight = 1.3557732367074677D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrMau});
            this.xrTableRow4.Dpi = 254F;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Dpi = 254F;
            this.xrTableCell7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Color:";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell7.Weight = 0.64422676329253237D;
            // 
            // xrMau
            // 
            this.xrMau.Dpi = 254F;
            this.xrMau.Multiline = true;
            this.xrMau.Name = "xrMau";
            this.xrMau.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrMau.Text = "Đen";
            this.xrMau.Weight = 1.3557732367074677D;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 132.0011F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(1125.41F, 99.45831F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "CÔNG TY TNHH NAVIC & KUNSHIN VIỆT NAM\r\nNX, Lot D4, Long Hau industrial zone, Can " +
    "Giuoc District, Long An Province,Vietnam\r\nTel: (84-072) 38735076\tFax: (84-072) 3" +
    "8735077";
            // 
            // label4
            // 
            this.label4.BorderColor = System.Drawing.Color.Black;
            this.label4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDot;
            this.label4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.label4.BorderWidth = 2F;
            this.label4.Dpi = 254F;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 322.1737F);
            this.label4.Name = "label4";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.label4.SizeF = new System.Drawing.SizeF(1900F, 16.10757F);
            this.label4.StylePriority.UseBorderColor = false;
            this.label4.StylePriority.UseBorderDashStyle = false;
            this.label4.StylePriority.UseBorders = false;
            this.label4.StylePriority.UseBorderWidth = false;
            this.label4.StylePriority.UseFont = false;
            this.label4.StylePriority.UseForeColor = false;
            this.label4.StylePriority.UsePadding = false;
            this.label4.StylePriority.UseTextAlignment = false;
            this.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.BorderColor = System.Drawing.Color.White;
            this.xrPictureBox1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrPictureBox1.BorderWidth = 0F;
            this.xrPictureBox1.Dpi = 254F;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 8.938583F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(399.5209F, 119.0625F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBox1.StylePriority.UseBorderColor = false;
            this.xrPictureBox1.StylePriority.UseBorderDashStyle = false;
            this.xrPictureBox1.StylePriority.UseBorderWidth = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDot;
            this.BottomMargin.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.BottomMargin.BorderWidth = 2F;
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 82.74919F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.StylePriority.UseBorderDashStyle = false;
            this.BottomMargin.StylePriority.UseBorders = false;
            this.BottomMargin.StylePriority.UseBorderWidth = false;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPageInfo1.Dpi = 254F;
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(1900F, 58.42F);
            this.xrPageInfo1.StylePriority.UseBorders = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrPageInfo1.TextFormatString = "Page {0} of {1}";
            // 
            // rpMyDungSticker
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 350, 83);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 32;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "18.2";
            this.Watermark.Font = new System.Drawing.Font("Verdana", 200F);
            this.Watermark.ForeColor = System.Drawing.Color.Gainsboro;
            this.Watermark.Text = "NKV";
            this.Watermark.TextTransparency = 200;
            ((System.ComponentModel.ISupportInitialize)(this.xrItemCode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel panel1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRRichText xrTana;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRRichText xrLocation;
        private DevExpress.XtraReports.UI.XRBarCode xrJanCode;
        private DevExpress.XtraReports.UI.XRRichText xrItemName;
        private DevExpress.XtraReports.UI.XRRichText xrItemCode;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRRichText xrItemCode2;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrNgay;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrKichThuoc;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrMau;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrSoLuong;
    }
}
