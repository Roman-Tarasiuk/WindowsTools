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
    public partial class TitleColoringForm : Form
    {
        #region Fields

        private ColorDialog m_ColorDialog;
        private string m_Setting = "hwnd(12345) rectangle(1, 2, 3, 4) rgb(12, 34, 45)";

        #endregion


        #region Constructors

        public TitleColoringForm()
        {
            InitializeComponent();

            this.txtConfigs.Text = m_Setting;
        }

        #endregion


        #region Event handlers

        private void btnColors_Click(object sender, EventArgs e)
        {
            if (m_ColorDialog == null)
            {
                m_ColorDialog = new ColorDialog();
            }

            DialogResult result = m_ColorDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            Color c = m_ColorDialog.Color;

            string clipboardStr = string.Format("rgb({0}, {1}, {2})", c.R, c.G, c.B);

            Clipboard.SetText(clipboardStr);
        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            txtConfigs.Text =
                txtConfigs.Text != string.Empty
                ? txtConfigs.Text + "\r\n" + m_Setting
                : m_Setting;
        }

        #endregion
    }
}
