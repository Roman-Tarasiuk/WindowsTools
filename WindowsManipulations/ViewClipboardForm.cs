using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsManipulations
{
    public partial class ViewClipboardForm : Form
    {
        public ViewClipboardForm()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void ViewClipboardForm_Shown(object sender, EventArgs e)
        {
            ShowClipboardInfo();
        }

        private void btnClipboardAutodetect_Click(object sender, EventArgs e)
        {
            ShowClipboardInfo();
        }

        private void ShowClipboardInfo()
        {
            if (Clipboard.ContainsAudio())
            {
                //Clipboard.GetData()
                richTextBox1.Text = "Audio";
                comboBox1.SelectedIndex = 0;
            }
            else if (Clipboard.ContainsFileDropList())
            {
                richTextBox1.Text = "File drop list";
                comboBox1.SelectedIndex = 1;
            }
            else if (Clipboard.ContainsImage())
            {
                richTextBox1.Text = "Image";
                comboBox1.SelectedIndex = 2;
            }
            else if (Clipboard.ContainsText())
            {
                richTextBox1.Text = "Text";
                comboBox1.SelectedIndex = 3;
            }
            else
            {
                richTextBox1.Text = "Data";
                comboBox1.SelectedIndex = 4;
            }
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
    }
}
