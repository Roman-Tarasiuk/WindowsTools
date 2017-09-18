﻿using System;
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
    public partial class CompareStringsSettingsForm : Form
    {
        public CompareStringsSettings Settings { get; set; }

        public delegate void SettingsEventHandler(object sender, CompareStringsSettingsEventArgs e);

        public event SettingsEventHandler SettingsChanged;

        public CompareStringsSettingsForm(CompareStringsSettings settings)
        {
            Settings = settings;

            InitializeComponent();

            chkTopmost.Checked = Settings.Topmost;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use context menu on paste buttonts to clear clipboard.", "Settings",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SettingsChanged != null)
            {
                SettingsChanged(this, new CompareStringsSettingsEventArgs() { Settings = Settings });
            }
        }

        private void chkTopmost_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Topmost = chkTopmost.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
