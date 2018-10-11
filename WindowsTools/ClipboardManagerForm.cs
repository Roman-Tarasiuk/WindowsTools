using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class ClipboardManagerForm : Form
    {
        #region Constructors

        public ClipboardManagerForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        private void ViewClipboardForm_Shown(object sender, EventArgs e)
        {
            this.timerStart.Start();
        }

        private void btnClipboardDetect_Click(object sender, EventArgs e)
        {
            ShowClipboardInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder resultStr = new StringBuilder();
            resultStr.AppendLine(DataFormats.Bitmap);
            resultStr.AppendLine(DataFormats.CommaSeparatedValue);
            resultStr.AppendLine(DataFormats.Dib);
            resultStr.AppendLine(DataFormats.Dif);

            MessageBox.Show(resultStr.ToString());
        }

        private void systemClipboardManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
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

        private void timerStart_Tick(object sender, EventArgs e)
        {
            this.timerStart.Stop();
            this.WindowState = FormWindowState.Minimized;
        }

        private void clearClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearClipboard();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ClearClipboard();
        }

        #endregion


        #region Helper Methods

        private void ShowClipboardInfo()
        {
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

        #endregion
    }
}
