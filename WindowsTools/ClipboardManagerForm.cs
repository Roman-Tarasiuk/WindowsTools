using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class ClipboardManagerForm : Form
    {
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        IntPtr nextClipboardViewer;
        const int maxClipboarChangedCount = 10;
        int clipboarChangedCount;

        Color color1 = Color.FromArgb(153, 255, 153);
        Color color2 = Color.FromArgb(153, 204, 255);


        #region Constructors

        public ClipboardManagerForm()
        {
            InitializeComponent();

            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            const int WM_DRAWCLIPBOARD = 0x308;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    clipboarChangedCount = maxClipboarChangedCount;
                    timer1.Start();
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }


        #region Event Handlers

        private void btnClipboardDetect_Click(object sender, EventArgs e)
        {
            ShowClipboardInfo();
        }

        private void btnClipboardClear_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            ShowClipboardInfo();
        }

        private void systemClipboardManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMainWindow();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClipboardManagerForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void clearClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearClipboard();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowMainWindow();
        }

        private void clearClipboarFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = Clipboard.GetText();
            if (text != null && text != String.Empty)
            {
                Clipboard.SetText(text);
            }
        }

        private void btnGetFormats_Click(object sender, EventArgs e)
        {
            var result = new StringBuilder();
            foreach (var format in Clipboard.GetDataObject().GetFormats())
            {
                result.AppendLine(format);
            }
            richTextBox1.Text = result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clipboarChangedCount-- == maxClipboarChangedCount)
            {
                if (this.richTextBox1.BackColor == SystemColors.Window)
                {
                    this.richTextBox1.BackColor = color1;
                }
                else if (this.richTextBox1.BackColor == color1)
                {
                    this.richTextBox1.BackColor = color2;
                }
                else if (this.richTextBox1.BackColor == color2)
                {
                    this.richTextBox1.BackColor = color1;
                }
            }
            else if (clipboarChangedCount > 0)
            {
                clipboarChangedCount--;
            }
            else
            {
                StopClipboardChangeIndication();
                this.richTextBox1.BackColor = SystemColors.Window;
            }
        }

        #endregion


        #region Helper Methods

        private void ShowClipboardInfo()
        {
            StopClipboardChangeIndication();

            if (Clipboard.ContainsAudio())
            {
                richTextBox1.Text = "Audio";
                comboBox1.SelectedIndex = 0;
            }
            else if (Clipboard.ContainsFileDropList())
            {
                var filesList = Clipboard.GetFileDropList();
                var result = new StringBuilder();
                foreach (var f in filesList)
                {
                    result.AppendLine(f);
                }
                richTextBox1.Text = result.ToString();

                comboBox1.SelectedIndex = 1;
            }
            else if (Clipboard.ContainsImage())
            {
                richTextBox1.Clear();
                richTextBox1.Paste();
                comboBox1.SelectedIndex = 2;
            }
            else if (Clipboard.ContainsText())
            {
                richTextBox1.Text = Clipboard.GetText();
                comboBox1.SelectedIndex = 3;
            }
            else
            {
                richTextBox1.Text = "Data / Empty";
                comboBox1.SelectedIndex = 4;
            }
        }

        private void ClearClipboard()
        {
            Clipboard.Clear();
        }

        private void ShowMainWindow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            User32Helper.User32Windows.SetForegroundWindow(this.Handle);
        }

        private void StopClipboardChangeIndication()
        {
            this.timer1.Stop();
            this.richTextBox1.BackColor = SystemColors.Window;
        }

        #endregion
    }
}
