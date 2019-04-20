using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace QuanLySanXuat
{
    public partial class frmCongDoanSanXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmCongDoanSanXuat()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(new object[] { 1, "TONA Dinh" });
            dt.Rows.Add(new object[] { 2, "Thảo Meo" });
            dt.Rows.Add(new object[] { 3, "Cái Trí Minh" });
            dt.Rows.Add(new object[] { 4, "Trịnh Quốc Khang" });
            dt.Rows.Add(new object[] { 5, "Mr.Cùi Bắp" });
            dt.Rows.Add(new object[] { 6, "Hoàng Thảo" });

            //gridControl1.DataSource = dt;
            //DataTable dt3 = new DataTable();
            //dt3.Columns.Add("ID", typeof(int));
            //gridControl2.DataSource = dt.Clone();//sẽ copy cấu trúc của Datable nhưng không có dữ liệu
            
        }
        GridHitInfo downHitInfor = null; //biến lưu cái dòng mình nhấn chuột


        private void gridControl1_DragDrop(object sender, DragEventArgs e)
        {
            var grid = sender as GridControl;
            var table = grid.DataSource as DataTable;
            var row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if (row == null || table == null || row.Table == table) return;
            table.ImportRow(row);
            row.Delete();
        }

        private void gridControl1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var view = sender as GridView;
            downHitInfor = null;
            var hitInfor = view.CalcHitInfo(new Point(e.X, e.Y));
            //if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfor.RowHandle >= 0)
            {
                downHitInfor = hitInfor;
            }
        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfor != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfor.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfor = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void check1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            //for (int i = 0; i < check1.CheckedItemsCount; i++)
            //{
            //    var a = check1.GetItemValue;
            //}
            textBox1.Text = string.Empty;
            StringBuilder sb = new StringBuilder();
            var tong = 0;
            foreach (var item in check1.CheckedItems)
            {
                tong = tong + 1;
                var max = check1.CheckedItemsCount;
                if (tong < max)
                    sb.Append(item + "  =>  ");
                else
                    sb.Append(item);
                //MessageBox.Show(sb.ToString());
            }
            textBox1.Text = sb.ToString();
        }

        private void frmCongDoanSanXuat_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nKVDataSet.tbDonSanXuat' table. You can move, or remove it, as needed.
            //real real = new realTimeSource1();

            textBox1.Text = string.Empty;
            StringBuilder sb = new StringBuilder();
            var tong = 0;
            foreach (var item in check1.CheckedItems)
            {
                tong = tong + 1;
                var max = check1.CheckedItemsCount;
                if (tong < max)
                    sb.Append(item + "  =>  ");
                else
                    sb.Append(item);
                //MessageBox.Show(sb.ToString());
            }
            textBox1.Text = sb.ToString();
        }

        private void check1_Leave(object sender, EventArgs e)
        {

        }

        private void check1_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {

        }

        private void check1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void check1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}