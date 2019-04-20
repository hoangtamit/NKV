using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

using DevExpress.Utils;

namespace QuanLySanXuat
{
    public partial class frmKhuon : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuon()
        {
            InitializeComponent();
        }
        void InitData()
        {
            treeList1.DataSource = new object();
        }

        bool loadDrives = false;

        private void treeList1_VirtualTreeGetChildNodes(object sender, DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo e)
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (!loadDrives)
            {
                string[] roots = Directory.GetLogicalDrives();
                e.Children = roots;
                loadDrives = true;
            }
            else
            {
                try
                {
                    var path = (string)e.Node;
                    if (Directory.Exists(path))
                    {
                        var dirs = Directory.GetDirectories(path);
                        var files = Directory.GetFiles(path);
                        var arr = new string[dirs.Length + files.Length];
                        dirs.CopyTo(arr, 0);
                        files.CopyTo(arr, dirs.Length);
                        e.Children = arr;
                    }
                    else e.Children = new object[] { };
                }
                catch { e.Children = new object[] { }; }
            }
            Cursor.Current = current;
        }

        private void treeList1_VirtualTreeGetCellValue(object sender, DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo e)
        {
            //var di = new DirectoryInfo((string)e.Node);
            //if (e.Column == colName) e.CellData = di.Name;
            //if (e.Column == colType)
            //{
            //    if (IsDrive((string)e.Node)) e.CellData = "Drive";
            //    else if (!IsFile(di))
            //        e.CellData = "Folder";
            //    else
            //        e.CellData = "File";
            //}
            //if (e.Column == colSize)
            //{
            //    if (IsFile(di))
            //    {
            //        e.CellData = new FileInfo((string)e.Node).Length;
            //    }
            //    else e.CellData = null;
            //}
        }


        bool IsFile(DirectoryInfo info)
        {
            try
            {
                return (info.Attributes & FileAttributes.Directory) == 0;
            }
            catch
            {
                return false;
            }
        }
        bool IsDrive(string val)
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                if (drive.Equals(val)) return true;
            }
            return false;
        }

        //public override TreeList ExportControl { get { return treeList1; } }
        //protected override string BarName { get { return "Explorer"; } }
        //protected override BarManager Manager { get { return barManager1; } }
        //protected override void InitBarInfo()
        //{
        //    this.BarInfos.Add(new BarInfo("Show Logical Drivers", new ItemClickEventHandler(ShowLogicalDriversClick), imageList3.Images[0], true, false, false));
        //    this.BarInfos.Add(new BarInfo("Assign Check", new ItemClickEventHandler(AssignCheckClick), imageList3.Images[1], true, true, false));
        //    this.BarInfos.Add(new BarInfo("Even And Odd Style Enabled", new ItemClickEventHandler(EvenOddStyleClick), imageList3.Images[2], true, true, false));
        //    this.BarInfos.Add(new BarInfo("Show Footer", new ItemClickEventHandler(ShowFooterClick), imageList3.Images[3], true, false, false));
        //    this.BarInfos.Add(new BarInfo("Show Preview", new ItemClickEventHandler(ShowPreviewClick), imageList3.Images[6], true, false, false));
        //    this.BarInfos.Add(new BarInfo("Show Grid", new ItemClickEventHandler(ShowGridClick), imageList3.Images[7], true, false, false));
        //    this.BarInfos.Add(new BarInfo("Alpha Blending", new ItemClickEventHandler(AlphaBlendingClick), imageList3.Images[8], false, false, false));
        //    this.BarInfos.Add(new BarInfo("Checked Items List", new ItemClickEventHandler(ListClick), imageList3.Images[4], false, false, true));
        //}

        //public TreeListExplorer()
        //{
        //    InitializeComponent();
        //    this.colSize.StyleName = "Style1";
        //    InitRoot();
        //    xtraTreeListBlending1.Enabled = true;
        //}

        //void ShowLogicalDriversClick(object sender, ItemClickEventArgs e)
        //{
        //    treeList1.ClearNodes();
        //    InitRoot();
        //}
        //void AssignCheckClick(object sender, ItemClickEventArgs e)
        //{
        //    if (GetBarItemPushed(1))
        //    {
        //        bar1.ItemLinks[1].Visible = true;
        //        treeList1.StateImageList = imageList2;
        //    }
        //    else
        //    {
        //        bar1.ItemLinks[1].Visible = false;
        //        treeList1.StateImageList = null;
        //    }
        //    SetBarItemEnabled(7, GetBarItemPushed(1));
        //}
        //void EvenOddStyleClick(object sender, ItemClickEventArgs e)
        //{
        //    treeList1.OptionsView.EnableAppearanceEvenRow = GetBarItemPushed(2);
        //}
        //void ShowFooterClick(object sender, ItemClickEventArgs e)
        //{
        //    treeList1.OptionsView.ShowSummaryFooter = GetBarItemPushed(3);
        //}
        //void ShowPreviewClick(object sender, ItemClickEventArgs e)
        //{
        //    treeList1.OptionsView.ShowPreview = GetBarItemPushed(4);
        //}
        //void ShowGridClick(object sender, ItemClickEventArgs e)
        //{
        //    treeList1.OptionsView.ShowHorzLines = treeList1.OptionsView.ShowVertLines = GetBarItemPushed(5);
        //}
        //void AlphaBlendingClick(object sender, ItemClickEventArgs e)
        //{
        //    xtraTreeListBlending1.ShowDialog();
        //}
        //void ListClick(object sender, ItemClickEventArgs e)
        //{
        //    DevExpress.XtraEditors.XtraForm f = new DevExpress.XtraEditors.XtraForm();
        //    TextBox tb = new TextBox();
        //    tb.Multiline = true;
        //    tb.Dock = DockStyle.Fill;
        //    tb.ScrollBars = ScrollBars.Vertical;
        //    tb.Text = CheckedItemsInfoMain();
        //    tb.SelectionLength = 0;

        //    f.Controls.Add(tb);
        //    f.Text = "CheckedItems Info";
        //    f.StartPosition = FormStartPosition.Manual;
        //    f.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        //    f.Location = DevExpress.Utils.ControlUtils.CalcLocation(Control.MousePosition, Control.MousePosition, f.Size);
        //    f.ShowDialog();
        //}

        private bool HasFiles(string path)
        {
            string[] root = Directory.GetFiles(path);
            if (root.Length > 0) return true;
            root = Directory.GetDirectories(path);
            if (root.Length > 0) return true;
            return false;
        }

        private void InitFolders(string path, TreeListNode pNode, CheckState check)
        {
            treeList1.BeginUnboundLoad();
            TreeListNode node;
            DirectoryInfo di;
            try
            {
                string[] root = Directory.GetDirectories(path);
                foreach (string s in root)
                {
                    try
                    {
                        di = new DirectoryInfo(s);
                        node = treeList1.AppendNode(new object[] { s, di.Name, "Folder", null, di.Attributes, check }, pNode);
                        node.HasChildren = HasFiles(s);
                        if (node.HasChildren)
                            node.Tag = true;
                    }
                    catch { }
                }
            }
            catch { }
            InitFiles(path, pNode, check);
            treeList1.EndUnboundLoad();
        }

        private void InitFiles(string path, TreeListNode pNode, CheckState check)
        {
            TreeListNode node;
            FileInfo fi;
            try
            {
                string[] root = Directory.GetFiles(path);
                foreach (string s in root)
                {
                    fi = new FileInfo(s);
                    node = treeList1.AppendNode(new object[] { s, fi.Name, "File", fi.Length, fi.Attributes, check }, pNode);
                    node.HasChildren = false;
                }
            }
            catch { }
        }

        private void InitDrives()
        {
            treeList1.BeginUnboundLoad();
            TreeListNode node;
            try
            {
                string[] root = Directory.GetLogicalDrives();

                foreach (string s in root)
                {
                    node = treeList1.AppendNode(new object[] { s, s, "Logical Driver", null, null, CheckState.Unchecked }, null);
                    node.HasChildren = true;
                    node.Tag = true;
                }
            }
            catch { }
            treeList1.EndUnboundLoad();
        }
        //private void InitRoot()
        //{
        //    if (!GetBarItemPushed(0))
        //        InitFolders(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory()), null, CheckState.Unchecked);
        //    else
        //        InitDrives();
        //}

        private void treeList1_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                InitFolders(e.Node.GetDisplayText("FullName"), e.Node, (CheckState)e.Node.GetValue("Check"));
                e.Node.Tag = null;
                Cursor.Current = currentCursor;
            }
        }

        private void treeList1_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e)
        {
            if (e.Node.GetDisplayText("Type") == "Folder")
                e.NodeImageIndex = e.Node.Expanded ? 1 : 0;
            else if (e.Node.GetDisplayText("Type") == "File") e.NodeImageIndex = 2;
            else e.NodeImageIndex = 3;
        }

        private void treeList1_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            CheckState check = (CheckState)e.Node.GetValue("Check");
            if (check == CheckState.Unchecked)
                e.NodeImageIndex = 0;
            else if (check == CheckState.Checked)
                e.NodeImageIndex = 1;
            else e.NodeImageIndex = 2;
        }

        private void treeList1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                SetCheckedNode(treeList1.FocusedNode);
            if (e.KeyData == Keys.Enter)
            {
                if (treeList1.FocusedNode.GetDisplayText("Type") == "File")
                {
                    try
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo.FileName = treeList1.FocusedNode.GetDisplayText("FullName");
                        process.StartInfo.Verb = "Open";
                        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                        process.Start();
                    }
                    catch { }
                }
                else
                    if (treeList1.FocusedNode.HasChildren) treeList1.FocusedNode.Expanded = !treeList1.FocusedNode.Expanded;
            }
        }

        private void SetCheckedNode(TreeListNode node)
        {
            CheckState check = (CheckState)node.GetValue("Check");
            if (check == CheckState.Indeterminate || check == CheckState.Unchecked) check = CheckState.Checked;
            else check = CheckState.Unchecked;
            treeList1.FocusedNode = node;
            treeList1.BeginUpdate();
            node["Check"] = check;
            //StatusBarDisplayText(treeList1.FocusedNode);
            SetCheckedChildNodes(node, check);
            SetCheckedParentNodes(node, check);
            treeList1.EndUpdate();
        }
        private void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i]["Check"] = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
        private void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    if (!check.Equals(node.ParentNode.Nodes[i]["Check"]))
                    {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode["Check"] = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }

        private string CheckedItemsInfoMain()
        {
            string s = "";
            CheckedItemsInfo(null, ref s);
            if (s == "") s = "No checked files...";
            return s;
        }

        private void CheckedItemsInfo(TreeListNode pnode, ref string s)
        {
            TreeListNodes nodes = pnode != null ? pnode.Nodes : treeList1.Nodes;
            foreach (TreeListNode node in nodes)
            {
                CheckState nodeChecked = (CheckState)node.GetValue("Check");
                if (nodeChecked != CheckState.Unchecked)
                {
                    if (nodeChecked == CheckState.Checked && node.GetDisplayText("Type") == "File") s += node.GetDisplayText("FullName") + "\r\n";
                    CheckedItemsInfo(node, ref s);
                }
            }
        }



        private void treeList1_CompareNodeValues(object sender, DevExpress.XtraTreeList.CompareNodeValuesEventArgs e)
        {
            string type1 = e.Node1.GetDisplayText("Type");
            string type2 = e.Node2.GetDisplayText("Type");
            if (type1 != type2)
            {
                if (type1 == "Folder")
                    e.Result = (e.SortOrder == SortOrder.Ascending) ? -1 : 1;
                else
                    e.Result = (e.SortOrder == SortOrder.Ascending) ? 1 : -1;
            }
        }

        private void treeList1_GetPreviewText(object sender, DevExpress.XtraTreeList.GetPreviewTextEventArgs e)
        {
            e.PreviewText = e.Node.GetDisplayText("FullName");
        }

        private void treeList1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeListHitInfo hInfo = treeList1.CalcHitInfo(new Point(e.X, e.Y));
                if (hInfo.HitInfoType == HitInfoType.StateImage)
                    SetCheckedNode(hInfo.Node);
            }
        }

        private void frmKhuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nKVDataSet.tbDonSanXuat' table. You can move, or remove it, as needed.
            this.tbDonSanXuatTableAdapter.Fill(this.nKVDataSet.tbDonSanXuat);

        }
    }
}