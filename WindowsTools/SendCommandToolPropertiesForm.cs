using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsTools.Infrastructure;

namespace WindowsTools
{
    public partial class SendCommandToolPropertiesForm : Form
    {
        #region Properties

        public string Commands { get; set; }
        public AnchorHorizontal AnchorH { get; set; }
        public AnchorVertical AnchorV { get; set; }
        public int ToolWidht { get; set; }
        public int ToolHeight { get; set; }
        public bool ClipboardCommand { get; set; }
        public bool Sleep { get; set; }
        public int SleepTimeout { get; set; }
        public bool RunOnAllWindowsWithSameTitle { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }

        #endregion


        #region Constructors

        public SendCommandToolPropertiesForm()
        {
            InitializeComponent();

            ToolWidht = 40;
            ToolHeight = 40;
            AnchorH = AnchorHorizontal.Left;
            AnchorV = AnchorVertical.Top;
        }

        #endregion


        #region Event Handlers

        private void SendCommandToolPropertiesForm_Shown(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ApplyProperties();
        }

        private void chkClipboard_CheckedChanged(object sender, EventArgs e)
        {
            txtCommands.Enabled = !chkClipboard.Checked;
        }

        #endregion


        #region Helper Methods

        private void InitializeGUI()
        {
            txtToolWidth.Text = ToolWidht.ToString();
            txtToolHeight.Text = ToolHeight.ToString();

            if (AnchorH == AnchorHorizontal.Left)
            {
                radioLeft.Checked = true;
            }
            else
            {
                radioRight.Checked = true;
            }

            if (AnchorV == AnchorVertical.Top)
            {
                radioTop.Checked = true;
            }
            else
            {
                radioBottom.Checked = true;
            }

            chkClipboard.Checked = this.ClipboardCommand;
            txtCommands.Enabled = !this.ClipboardCommand;

            if (!this.ClipboardCommand)
            {
                txtCommands.Text = Commands;
            }

            chkSleep.Checked = Sleep;
            txtSleepTimeout.Text = SleepTimeout.ToString();

            chkRunOnAllWindowsWithSameTitle.Checked = RunOnAllWindowsWithSameTitle;

            txtLeft.Text = Left.ToString();
            txtTop.Text = Top.ToString();
        }

        private void ApplyProperties()
        {
            Commands = txtCommands.Text;

            int w;
            if (int.TryParse(txtToolWidth.Text, out w))
            {
                ToolWidht = w;
            }

            int h;
            if (int.TryParse(txtToolHeight.Text, out h))
            {
                ToolHeight = h;
            }

            if (radioLeft.Checked)
            {
                AnchorH = AnchorHorizontal.Left;
            }
            else
            {
                AnchorH = AnchorHorizontal.Right;
            }

            if (radioTop.Checked)
            {
                AnchorV = AnchorVertical.Top;
            }
            else
            {
                AnchorV = AnchorVertical.Bottom;
            }

            this.ClipboardCommand = chkClipboard.Checked;

            if (!this.ClipboardCommand)
            {
                Commands = txtCommands.Text;
            }

            Sleep = chkSleep.Checked;

            int timeout;
            if (int.TryParse(txtSleepTimeout.Text, out timeout))
            {
                SleepTimeout = timeout;
            }

            RunOnAllWindowsWithSameTitle = chkRunOnAllWindowsWithSameTitle.Checked;

            Top = int.Parse(txtTop.Text);
            Left = int.Parse(txtLeft.Text);
        }

        #endregion
    }
}
