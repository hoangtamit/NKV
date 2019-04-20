using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ZXing;
using ZXing.QrCode;
using QuanLySanXuat.Control;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using static QuanLySanXuat.PrintRibbon;
using QuanLySanXuat.Object;
using System.Drawing.Imaging;

namespace QuanLySanXuat
{
    public partial class frmBarCode : XtraForm
    {
        //BarcodeLib.Barcode b = new BarcodeLib.Barcode();
        private QrCodeEncodingOptions options;
        private BarcodeWriter writer;
        private readonly BarcodeQrCtr bqrCtr = new BarcodeQrCtr();
        public DataTable tbl;
        public frmBarCode()
        {
            InitializeComponent();
        }

        private void frmBarCode_Load(object sender, EventArgs e)
        {
            tbl = new DataTable();
            tbl = bqrCtr.BarcodeQr_LoadData();
            gridControl1.DataSource = tbl;


            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = (int)txtChieuRong.Value,
                Height = (int)txtChieuDai.Value,
            };
            writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = options
            };
        }

        private void GenerateQRCode_Click(object sender, EventArgs e)
        {
            try
            {
                var qr = new BarcodeWriter
                {
                    Options = options,
                    Format = BarcodeFormat.QR_CODE
                };
                var result = new Bitmap(qr.Write(richTextBox1.Text.Trim()));
                pictureBox1.Image = result;
            }
            catch (Exception)
            {
                // ignored
            }


            //var save = new SaveFileDialog()
            //{
            //    //CreatePrompt = true,
            //    //OverwritePrompt = true,
                
            //FileName = richTextBox1.Text,
            //    Filter = @"PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif",
            //    InitialDirectory = @"C:/"
            //};
            //if (save.ShowDialog() == DialogResult.OK)
            //pictureBox1.Image.Save(save.FileName);
            ////save.InitialDirectory = Environment.GetFolderPath
            ////    (Environment.SpecialFolder.Desktop);
            //richTextBox1.Text = String.Empty;
        }

        private void DecodeQRCode_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            var reader = new BarcodeReader { AutoRotate = true};
            //reader.TryHarder = true;
            var result = reader.Decode(bitmap);
            var decoded = result.ToString().Trim();
            richTextBox1.Text = decoded;
        }

        private void BrowseImage_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog
            {
                CreatePrompt = true,
                OverwritePrompt = true,
                FileName = richTextBox1.Text,
                Filter = @"PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif"
            };
            if (save.ShowDialog() != DialogResult.OK) return;
            pictureBox1.Image.Save(save.FileName);
            save.InitialDirectory = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var dr = gridView1.GetDataRow(i);
                var qr = new BarcodeWriter
                {
                    Options = options,
                    Format = BarcodeFormat.QR_CODE
                };
                var result = new Bitmap(qr.Write(dr["ID"].ToString()));
                pictureBox1.Image = result;
                //ImageFormat format = ImageFormat.Png;
                //var path = "Images\\" + dr["ID"].ToString();
                //pictureBox1.Image.Save(path, format);

                var save = new SaveFileDialog()
                {
                    CreatePrompt = true,
                    InitialDirectory = "Images\\",
                    OverwritePrompt = true,
                    FileName = dr["ID"].ToString().Trim(),
                    Filter = @"PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif"
                };
                if(save.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(save.FileName);
            }
            frmBarCode_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bqrCtr.BarcodeQr_Delete();
            frmBarCode_Load(sender, e);
        }

        private void btnDan_Click(object sender, EventArgs e)
        {
            var data = ClipboardData.Split('\n');
            if (data.Length < 1)
            {
                return;
            }
            foreach (string row in data)
            {
                AddRow(row);
            }
        }
        private string ClipboardData
        {
            get
            {
                var iData = Clipboard.GetDataObject();
                if (iData != null && iData.ToString() == "")
                {
                    return "";
                }

                if (iData != null && iData.GetDataPresent(DataFormats.UnicodeText))
                {
                    return (string)iData.GetData(DataFormats.UnicodeText);
                }
                return "";
            }
            set => Clipboard.SetDataObject(value);
        }

        private void AddRow(string data)
        {
            if (data == string.Empty)
            {
                return;
            }
            var rowData = data.Split(new char[] { '\n', '\t' });
            // dữ liệu đổ vào gridcontrol phải là datatable , không sử dụng linq sẽ bị báo lỗi
            var newRow = tbl.NewRow();

            var i = 0;
            while (i < rowData.Length)
            {
                if (i >= tbl.Columns.Count)
                {
                    break; // TODO: might not be correct. Was : Exit While
                }
                newRow[i] = rowData[i];
                Math.Max(System.Threading.Interlocked.Increment(ref i), i - 1);
            }
            tbl.Rows.Add(newRow);
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    //this.ForeColor = cdialog.Color;
                    this.btnForeColor.BackColor = cdialog.Color;
                }
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.btnBackColor.BackColor = cdialog.Color;
                }
            }
        }
    }

}