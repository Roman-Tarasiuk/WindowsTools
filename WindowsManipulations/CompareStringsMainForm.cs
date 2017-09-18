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
    public partial class CompareStringsMainForm : Form
    {
        #region Fields

        private int m_TextBoxWidhtDifference;
        private CompareStringsSettings m_Settings = new CompareStringsSettings();

        #endregion

        #region Constructors

        public CompareStringsMainForm()
        {
            InitializeComponent();

            m_TextBoxWidhtDifference = this.Width - txtText1.Width;
        }

        #endregion


        #region Overridden

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        #endregion


        #region Event Handlers

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtText1.Text = String.Empty;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtText2.Text = String.Empty;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtCompare.Text = String.Empty;
            txtCompare.BackColor = SystemColors.Window;
        }

        private void btnPaste1_Click(object sender, EventArgs e)
        {
            var clipboardText = Clipboard.GetText();
            if (clipboardText != String.Empty)
            {
                txtText1.Text = clipboardText;
            }
        }

        private void btnPaste2_Click(object sender, EventArgs e)
        {
            var clipboardText = Clipboard.GetText();
            if (clipboardText != String.Empty)
            {
                txtText2.Text = clipboardText;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            CompareResults();
        }

        private void btnLengthUp_Click(object sender, EventArgs e)
        {
            txtText1.Width += 200;
            txtText2.Width = txtText1.Width;
            txtCompare.Width = txtText1.Width;
        }

        private void btnLengthDown_Click(object sender, EventArgs e)
        {
            txtText1.Width -= 200;
            txtText2.Width = txtText1.Width;
            txtCompare.Width = txtText1.Width;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            txtText1.Width = this.Width - m_TextBoxWidhtDifference;
            txtText2.Width = txtText1.Width;
            txtCompare.Width = txtText1.Width;
        }

        private void clearClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settings = new CompareStringsSettingsForm(m_Settings);
            settings.SettingsChanged += (ss, ee) =>
            {
                ApplySettings(ee.Settings);
            };

            var result = settings.ShowDialog();
            if (result == DialogResult.OK)
            {
                ApplySettings(settings.Settings);
            }
        }

        private void ApplySettings(CompareStringsSettings settings)
        {
            this.TopMost = settings.Topmost;
        }

        #endregion


        #region Helper Methods

        private void CompareResults()
        {
            var str1 = txtText1.Text;
            var str2 = txtText2.Text;

            if (str1 == String.Empty && str2 == String.Empty)
            {
                MessageBox.Show("The both strings are empty.", "Compare Strings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (str1 == str2)
            {
                txtCompare.Text = String.Empty;
                txtCompare.BackColor = Color.LimeGreen;
                return;
            }

            var minLength = (str1.Length < str2.Length) ? str1.Length : str2.Length;

            StringBuilder sb = new StringBuilder();

            for (var i = 0; i < minLength; i++)
            {
                if (str1[i] != str2[i])
                {
                    sb.Append("x");
                }
                else
                {
                    sb.Append(" ");
                }
            }

            string biggerString = null;
            if (minLength < str1.Length)
            {
                biggerString = str1;
            }
            else if (minLength < str2.Length)
            {
                biggerString = str2;
            }

            if (biggerString != null)
            {
                for (var i = 0; i < (biggerString.Length - minLength); i++)
                {
                    sb.Append("x");
                }
            }

            txtCompare.Text = sb.ToString();
            txtCompare.BackColor = Color.FromArgb(240, 62, 70);
        }

        #endregion
    }
}
