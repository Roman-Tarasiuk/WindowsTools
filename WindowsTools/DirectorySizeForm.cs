using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class DirectorySizeForm : Form
    {
        public string m_Path { get; set; } = String.Empty;

        public DirectorySizeForm()
        {
            InitializeComponent();

            treeView1.ImageList = new ImageList();
            treeView1.ImageList.Images.Add(WindowsTools.Properties.Resources.folder16x16);
            treeView1.ImageList.Images.Add(WindowsTools.Properties.Resources.file16x16);
            treeView1.ImageList.Images.Add(WindowsTools.Properties.Resources.foldererror16x16);
            treeView1.ImageList.Images.Add(WindowsTools.Properties.Resources.fileerror16x16);
        }

        #region Event Handlers

        private void btnProcess_Click(object sender, EventArgs e)
        {
            BuildDirectoryTree();
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.SelectedPath = m_Path;

            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
                m_Path = dlg.SelectedPath;
            }
        }

        #endregion


        #region Helper Methods

        private void BuildDirectoryTree()
        {
            treeView1.Nodes.Clear();

            string p = String.Empty;

            try
            {
                p = Path.GetFullPath(txtPath.Text.Replace("\"", "")) + "\\";
                p = p.Replace("\\\\", "\\");
            }
            catch { }

            if (!Directory.Exists(p))
            {
                MessageBox.Show("The specified folder does not exists.");
                return;
            }

            m_Path = p;

            var node = new TreeNode(Path.GetDirectoryName(m_Path));
            treeView1.Nodes.Add(node);

            var start = DateTime.Now;

            var size = EnumerateSubdirs(m_Path, treeView1.Nodes[0]);
            node.Text = FormatSize(size) + " : " + node.Text;

            var end = DateTime.Now;

            var duration = end - start;

            MessageBox.Show("Processed in " + duration.TotalMinutes + "minutes.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private long EnumerateSubdirs(string path, TreeNode node)
        {
            long size = 0;

            try
            {
                var directories = Directory.EnumerateDirectories(path);

                foreach (var d in directories)
                {
                    //node.Nodes.Add(d);
                    var tn = new TreeNode();
                    node.Nodes.Add(tn);

                    var sizeSubdir = EnumerateSubdirs(d, tn);
                    size += sizeSubdir;

                    //node.Nodes.Add(Path.GetFileName(d));
                    tn.Text = FormatSize(sizeSubdir) + " : " + Path.GetFileName(d);
                }

                var files = Directory.EnumerateFiles(path);

                foreach (var f in files)
                {
                    var sizeFile = new FileInfo(f).Length;
                    var n = new TreeNode(FormatSize(sizeFile) + " : " + Path.GetFileName(f));
                    n.ImageIndex = 1;
                    n.SelectedImageIndex = 1;
                    node.Nodes.Add(n);

                    size += sizeFile;
                }
            }
            catch
            {
                // var tn = new TreeNode("              ? : " + Path.GetFileName(path));
                // tn.ImageIndex = 2;
                // tn.SelectedImageIndex = 2;
                //node.Nodes.Add(tn);
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }

            return size;
        }

        private string FormatSize(long size)
        {
            return String.Format("{0:N0}", size).PadLeft(15);
        }

        #endregion
    }
}
