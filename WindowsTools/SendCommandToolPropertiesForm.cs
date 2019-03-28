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
        public int ToolTop { get; set; }
        public int ToolLeft { get; set; }
        public int ToolWidht { get; set; }
        public int ToolHeight { get; set; }
        public SendCommandType CommandType { get; set; }
        public bool Sleep { get; set; }
        public int SleepTimeout { get; set; }
        public bool RunOnAllWindowsWithSameTitle { get; set; }
        public string TitlePattern { get; set; }
        public Color BorderColor { get; set; }
        public Color BorderHoverColor { get; set; }

        #endregion


        #region Constructors

        public SendCommandToolPropertiesForm()
        {
            InitializeComponent();

            ToolWidht = 40;
            ToolHeight = 40;
            AnchorH = AnchorHorizontal.Left;
            AnchorV = AnchorVertical.Top;

            TitlePattern = String.Empty;
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

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                BorderColor = colorDialog1.Color;
                lblBorder.BackColor = BorderColor;
            }
        }

        private void chkRunOnAllWindowsWithSameTitle_click(object sender, EventArgs e)
        {
            txtTitlePattern.ReadOnly = !chkRunOnAllWindowsWithSameTitle.Checked;
        }

        private void btnBorderHoverColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                BorderHoverColor = colorDialog1.Color;
                lblBorderHover.BackColor = BorderHoverColor;
            }
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtCommands.ReadOnly = radioClipboard.Checked;
        }

        private void radioClipboard_CheckedChanged(object sender, EventArgs e)
        {
            txtCommands.ReadOnly = radioClipboard.Checked;
        }

        private void radioActivateWindow_CheckedChanged(object sender, EventArgs e)
        {
            txtCommands.ReadOnly = radioClipboard.Checked;
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

            // chkClipboard.Checked = this.ClipboardCommand;
            radioCommand.Checked = (this.CommandType == SendCommandType.Command);
            radioClipboard.Checked = (this.CommandType == SendCommandType.Clipboard);
            radioActivateWindow.Checked = (this.CommandType == SendCommandType.ActivateWindow);

            txtCommands.ReadOnly = radioClipboard.Checked;

            if (this.CommandType != SendCommandType.Clipboard)
            {
                txtCommands.Text = Commands;
            }

            chkSleep.Checked = Sleep;
            txtSleepTimeout.Text = SleepTimeout.ToString();

            chkRunOnAllWindowsWithSameTitle.Checked = RunOnAllWindowsWithSameTitle;
            txtTitlePattern.ReadOnly = !RunOnAllWindowsWithSameTitle;

            txtLeft.Text = ToolLeft.ToString();
            txtTop.Text = ToolTop.ToString();

            lblBorder.BackColor = BorderColor;
            lblBorderHover.BackColor = BorderHoverColor;
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

            if (radioCommand.Checked)
            {
                this.CommandType = SendCommandType.Command;
            }
            else if (radioClipboard.Checked)
            {
                this.CommandType = SendCommandType.Clipboard;
            }
            else
            {
                this.CommandType = SendCommandType.ActivateWindow;
            }

            Sleep = chkSleep.Checked;

            int timeout;
            if (int.TryParse(txtSleepTimeout.Text, out timeout))
            {
                SleepTimeout = timeout;
            }

            RunOnAllWindowsWithSameTitle = chkRunOnAllWindowsWithSameTitle.Checked;
            if (RunOnAllWindowsWithSameTitle)
            {
                TitlePattern = txtTitlePattern.Text;
            }
            else
            {
                TitlePattern = String.Empty;
            }

            ToolTop = int.Parse(txtTop.Text);
            ToolLeft = int.Parse(txtLeft.Text);
        }

        #endregion
    }
}
