using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class DirectorySizeForm : Form
    {
        public string m_Path { get; set; } = String.Empty;

        private CancellationTokenSource m_CancelationTokenSource;
        private bool m_Canceled = false;

        DateTime m_Start;


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
            m_CancelationTokenSource = new CancellationTokenSource();

            // https://docs.microsoft.com/en-us/dotnet/standard/threading/canceling-threads-cooperatively
            new Thread(new ParameterizedThreadStart(BuildDirectoryTree)).Start(m_CancelationTokenSource.Token);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_CancelationTokenSource.Cancel();

            //timer1.Stop();
        }

        private void DirectorySizeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_CancelationTokenSource != null && !m_CancelationTokenSource.IsCancellationRequested)
            {
                MessageBox.Show("The processing is still working.\n"
                    + "Click 'Cancel' button if you want to break the processing\n"
                    + "and then close the window.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var duration = DateTime.Now - m_Start;

            lblTimer.Text = duration.ToString(@"hh\:mm\:ss");
        }

        #endregion


        #region Thread Safe Control Methods

        private void ThreadSafeClearTree()
        {
            if (this.treeView1.InvokeRequired)
            {
                Action d = new Action(ThreadSafeClearTree);
                this.Invoke(d);
            }
            else
            {
                this.treeView1.Nodes.Clear();
            }
        }

        private void ThreadSafeAddNode(TreeNode node)
        {
            if (this.treeView1.InvokeRequired)
            {
                Action<TreeNode> d = new Action<TreeNode>(ThreadSafeAddNode);
                this.Invoke(d, new object[] { node });
            }
            else
            {
                this.treeView1.Nodes.Add(node);
            }
        }

        private void ThreadSafeAddChildrenNode(TreeNode node, TreeNode child)
        {
            if (this.treeView1.InvokeRequired)
            {
                Action<TreeNode, TreeNode> d = new Action<TreeNode, TreeNode>(ThreadSafeAddChildrenNode);
                this.Invoke(d, new object[] { node, child });
            }
            else
            {
                node.Nodes.Add(child);
            }
        }

        private void ThreadSafeSetNodeText(TreeNode node, string text)
        {
            if (this.treeView1.InvokeRequired)
            {
                Action<TreeNode, string> d = new Action<TreeNode, string>(ThreadSafeSetNodeText);
                this.Invoke(d, new object[] { node, text });
            }
            else
            {
                node.Text = text;
            }
        }

        private void ThreadSafeSetNodeImage(TreeNode node, int index)
        {
            if (this.treeView1.InvokeRequired)
            {
                Action<TreeNode, int> d = new Action<TreeNode, int>(ThreadSafeSetNodeImage);
                this.Invoke(d, new object[] { node, index });
            }
            else
            {
                node.ImageIndex = index;
                node.SelectedImageIndex = index;
            }
        }

        private void ThreadSafeSetButtonEnabled(Button button, bool enabled)
        {
            if (this.treeView1.InvokeRequired)
            {
                Action<Button, bool> d = new Action<Button, bool>(ThreadSafeSetButtonEnabled);
                this.Invoke(d, new object[] { button, enabled });
            }
            else
            {
                button.Enabled = enabled;
            }
        }

        private void ThreadSafeSetTreeViewBackColor(Color color)
        {
            if (this.treeView1.InvokeRequired)
            {
                Action<Color> d = new Action<Color>(ThreadSafeSetTreeViewBackColor);
                this.Invoke(d, new object[] { color });
            }
            else
            {
                treeView1.BackColor = color;
            }
        }

        private void ThreadSafeSuspendLayout()
        {
            if (this.treeView1.InvokeRequired)
            {
                Action d = new Action(ThreadSafeSuspendLayout);
                this.Invoke(d);
            }
            else
            {
                this.SuspendLayout();
            }
        }

        private void ThreadSafeResumeLayout()
        {
            if (this.treeView1.InvokeRequired)
            {
                Action d = new Action(ThreadSafeResumeLayout);
                this.Invoke(d);
            }
            else
            {
                this.ResumeLayout();
            }
        }

        private void ThreadSafeTimerStart()
        {
            if (this.treeView1.InvokeRequired)
            {
                Action d = new Action(ThreadSafeTimerStart);
                this.Invoke(d);
            }
            else
            {
                timer1.Start();
            }
        }

        private void ThreadSafeTimerStop()
        {
            if (this.treeView1.InvokeRequired)
            {
                Action d = new Action(ThreadSafeTimerStop);
                this.Invoke(d);
            }
            else
            {
                timer1.Stop();
            }
        }

        #endregion


        #region Helper Methods

        private void BuildDirectoryTree(object cancelationObject)
        {
            ThreadSafeTimerStart();

            ThreadSafeSetButtonEnabled(btnProcess, false);
            ThreadSafeSetButtonEnabled(btnCancel, true);

            ThreadSafeSetTreeViewBackColor(SystemColors.Window);
            ThreadSafeClearTree();

            ThreadSafeSuspendLayout();

            m_Canceled = false;

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
            ThreadSafeAddNode(node);

            m_Start = DateTime.Now;

            var size = EnumerateSubdirs(m_Path, node, cancelationObject);

            ThreadSafeSetNodeText(node, FormatSize(size) + " : " + node.Text);

            var end = DateTime.Now;
            var duration = end - m_Start;

            ThreadSafeSetButtonEnabled(btnProcess, true);
            ThreadSafeSetButtonEnabled(btnCancel, false);

            ThreadSafeResumeLayout();

            m_CancelationTokenSource = null;

            ThreadSafeTimerStop();

            if (m_Canceled)
            {
                ThreadSafeSetTreeViewBackColor(SystemColors.Control);
            }
            else
            {
                ThreadSafeSetTreeViewBackColor(SystemColors.Window);
                MessageBox.Show("Processed in " + String.Format("{0:N2}", duration.TotalMinutes) + "minutes.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private long EnumerateSubdirs(string path, TreeNode node, object cancelationObject)
        {
            CancellationToken ct = (CancellationToken)cancelationObject;
            long size = 0;

            try
            {
                var directories = Directory.EnumerateDirectories(path);

                foreach (var d in directories)
                {
                    if (ct.IsCancellationRequested)
                    {
                        m_Canceled = true;
                        ThreadSafeTimerStop();
                        return size;
                    }

                    var tn = new TreeNode();
                    var dirName = Path.GetFileName(d);

                    ThreadSafeSetNodeText(tn, dirName);
                    ThreadSafeAddChildrenNode(node, tn);

                    var sizeSubdir = EnumerateSubdirs(d, tn, cancelationObject);
                    size += sizeSubdir;

                    ThreadSafeSetNodeText(tn, FormatSize(sizeSubdir) + " : " + dirName);
                }

                var files = Directory.EnumerateFiles(path);

                foreach (var f in files)
                {
                    var sizeFile = new FileInfo(f).Length;
                    var n = new TreeNode();
                    ThreadSafeSetNodeText(n, FormatSize(sizeFile) + " : " + Path.GetFileName(f));
                    ThreadSafeSetNodeImage(n, 1);
                    ThreadSafeAddChildrenNode(node, n);

                    size += sizeFile;
                }
            }
            catch
            {
                ThreadSafeSetNodeImage(node, 2);
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
