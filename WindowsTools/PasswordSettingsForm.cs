using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class PasswordSettingsForm : Form
    {
        public bool ActivateLastWindow { get; set; } = true;

        public PasswordSettingsForm()
        {
            InitializeComponent();
        }

        private void PasswordSettingsForm_Shown(object sender, EventArgs e)
        {
            chkActivateLastWindow.Checked = ActivateLastWindow;
        }

        private void PasswordSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ActivateLastWindow = chkActivateLastWindow.Checked;
        }
    }
}
