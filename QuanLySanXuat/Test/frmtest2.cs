using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLySanXuat.Control;

namespace QuanLySanXuat
{
    public partial class frmtest2 : DevExpress.XtraEditors.XtraForm
    {
        private int iFiles;
        private int iDirectories;
        //private Panel panel1;
        //private StatusBar statusBar1;
        private readonly DonSanXuatCtr dsxCtr = new DonSanXuatCtr();
        //private System.Windows.Forms.TreeView treeView1;
        //private System.Windows.Forms.Splitter splitter1;
        //private System.Windows.Forms.ListView listView1;
        //private System.Windows.Forms.ImageList imageList1;
        //private System.Windows.Forms.ColumnHeader columnHeader1;
        //private System.Windows.Forms.ColumnHeader columnHeader2;
        //private System.Windows.Forms.ColumnHeader columnHeader3;
        //private System.Windows.Forms.ColumnHeader columnHeader4;
        //private System.ComponentModel.IContainer components;
        public frmtest2()
        {
            InitializeComponent();
        }

        private void frmtest2_Load(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            gridControl1.DataSource = dsxCtr.alldata();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            MessageBox.Show("RunTime " + elapsedTime);

            var aDrives = Environment.GetLogicalDrives();
            treeView1.BeginUpdate();
            foreach (var strDrive in aDrives)
            {
                var dnMyDrives = new TreeNode(strDrive.Remove(2, 1));

                switch (strDrive)
                {
                    case "A:":
                        dnMyDrives.SelectedImageIndex = 0;
                        dnMyDrives.ImageIndex = 0;
                        break;
                    case "C:":
                        treeView1.SelectedNode = dnMyDrives;
                        dnMyDrives.SelectedImageIndex = 1;
                        dnMyDrives.ImageIndex = 1;

                        break;
                    case "D:":
                        dnMyDrives.SelectedImageIndex = 2;
                        dnMyDrives.ImageIndex = 2;
                        break;
                    default:
                        dnMyDrives.SelectedImageIndex = 3;
                        dnMyDrives.ImageIndex = 3;
                        break;
                }
                treeView1.Nodes.Add(dnMyDrives);
            }
            treeView1.EndUpdate();
            //var db = new MyDBContextDataContext();
            //treeList1.DataSource = db.tbKhoNLVs.ToList();
            //treeList1.ParentFieldName = treeList1.Columns["NhapXuat"].ToString();
            //treeList1.KeyFieldName = treeList1.Columns["IDKhoNVL"].ToString();
            //treeList2.DataSource = db.tbKhoNLVs.ToList();
            //treeList2.ParentFieldName = treeList2.Columns["NhapXuat"].ToString();
            //treeList2.KeyFieldName = treeList2.Columns["IDKhoNVL"].ToString();
        }

        private void AddDirectories(TreeNode tnSubNode)
        {
            treeView1.BeginUpdate();
            iDirectories = 0;
            try
            {
                DirectoryInfo diRoot;
                // Nếu là ổ đĩa thì lấy thư mục từ ổ đỉa
                if (tnSubNode.SelectedImageIndex < 11)
                {
                    diRoot = new DirectoryInfo(tnSubNode.FullPath + "");
                }
                //  Ngược lại lấy thư mục từ thư mục
                else
                {
                    diRoot = new DirectoryInfo(tnSubNode.FullPath);
                }
                DirectoryInfo[] dirs = diRoot.GetDirectories();

                tnSubNode.Nodes.Clear();

                // Add thư mục con vào tree
                foreach (DirectoryInfo dir in dirs)
                {
                    iDirectories++;
                    TreeNode subNode = new TreeNode(dir.Name);
                    subNode.ImageIndex = 11;
                    subNode.SelectedImageIndex = 12;
                    tnSubNode.Nodes.Add(subNode);
                }
            }
            catch {; }
            treeView1.EndUpdate();
        }
        private void AddFiles(string strPath)
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            iFiles = 0;
            try
            {
                DirectoryInfo di = new DirectoryInfo(strPath + "");
                FileInfo[] theFiles = di.GetFiles();
                string _Size = string.Empty;
                foreach (FileInfo theFile in theFiles)
                {
                    iFiles++;
                    if (theFile.Length >= 1024)
                        _Size = string.Format("{0:### ### ###} KB", theFile.Length / 1024);
                    else _Size = string.Format("{0} Bytes", theFile.Length);

                    var lvItem = new ListViewItem(theFile.Name);
                    lvItem.SubItems.Add(_Size);
                    lvItem.SubItems.Add(theFile.LastWriteTime.ToString("dd/MM/yyyy"));
                    lvItem.SubItems.Add(theFile.LastWriteTime.ToShortTimeString());
                    listView1.Items.Add(lvItem);
                }
            }
            catch (Exception) { //statusBar1.Text = Exc.ToString();
            }
            listView1.EndUpdate();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var sFileName = listView1.FocusedItem.Text;
            try
            {
                var sPath = treeView1.SelectedNode.FullPath;
                Process.Start(sPath + "" + sFileName);
            }
            catch (Exception Exc) { MessageBox.Show(Exc.ToString()); }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Thêm thư mục con từ ổ đĩa vào tree
            AddDirectories(e.Node);

            treeView1.SelectedNode.Expand();

            // Thêm file vào listview
            AddFiles(e.Node.FullPath.ToString());
            //statusBar1.Text = iDirectories.ToString() + " Thư mục(s)  " + iFiles.ToString() + " Tệp(s)";
        }
    }
}