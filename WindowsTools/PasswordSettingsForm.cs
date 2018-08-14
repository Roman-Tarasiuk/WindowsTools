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
        public bool ActivateLastWindow { get; set; }
        public bool ShowSystemTrayIcon { get; set; }

        public PasswordSettingsForm()
        {
            InitializeComponent();

            ActivateLastWindow = true;
        }

        private void PasswordSettingsForm_Shown(object sender, EventArgs e)
        {
            chkActivateLastWindow.Checked = ActivateLastWindow;
            chkShowSystemTrayIcon.Checked = ShowSystemTrayIcon;
        }

        private void PasswordSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ActivateLastWindow = chkActivateLastWindow.Checked;
        }

        private void chkShowSystemTrayIcon_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowSystemTrayIcon = chkShowSystemTrayIcon.Checked;
        }
    }
}
