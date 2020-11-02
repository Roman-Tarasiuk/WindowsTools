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

        public IntPtr HostHwnd { get; set; }
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
        public bool ActivateOnHover { get; set;  }

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
            colorDialog1.Color = BorderColor;
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
            colorDialog1.Color = BorderHoverColor;
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                BorderHoverColor = colorDialog1.Color;
                lblBorderHover.BackColor = BorderHoverColor;
            }
        }

        private void radioClipboard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioClipboard.Checked)
            {
                txtCommands.Text = "commands...{clipboard}commands...{ENTER}\r\n"
                                + "or clear this to use clipboard value only";
            }
        }

        #endregion


        #region Helper Methods

        private void InitializeGUI()
        {
            txtHostHwnd.Text = HostHwnd.ToString();
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

            radioCommand.Checked = (this.CommandType == SendCommandType.Command);
            radioClipboard.Checked = (this.CommandType == SendCommandType.Clipboard);
            radioActivateWindow.Checked = (this.CommandType == SendCommandType.ActivateWindow);
            radioLastN.Checked = (this.CommandType == SendCommandType.ActivateLastN);

            txtCommands.Text = Commands;

            chkSleep.Checked = Sleep;
            txtSleepTimeout.Text = SleepTimeout.ToString();

            chkRunOnAllWindowsWithSameTitle.Checked = RunOnAllWindowsWithSameTitle;
            txtTitlePattern.ReadOnly = !RunOnAllWindowsWithSameTitle;

            txtLeft.Text = ToolLeft.ToString();
            txtTop.Text = ToolTop.ToString();

            lblBorder.BackColor = BorderColor;
            lblBorderHover.BackColor = BorderHoverColor;

            chkActivateOnHover.Checked = ActivateOnHover;
        }

        private void ApplyProperties()
        {
            int hostHwnd;
            if (int.TryParse(txtHostHwnd.Text, out hostHwnd))
            {
                HostHwnd = (IntPtr)hostHwnd;
            }

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
            else if (radioActivateWindow.Checked)
            {
                this.CommandType = SendCommandType.ActivateWindow;
            }
            else
            {
                this.CommandType = SendCommandType.ActivateLastN;
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

            ActivateOnHover = chkActivateOnHover.Checked;
        }

        #endregion
    }
}
