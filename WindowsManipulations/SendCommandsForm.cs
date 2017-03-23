using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using User32Helper;

namespace WindowsManipulations
{
    public partial class SendCommandsForm : Form
    {
        #region Fields

        private IntPtr m_Hwnd;

        private string m_HelpMessage =
            "Separate commands using new line.\n\n"

            + "In keyboard shortcuts use small letters.\n\n"

            + "SHIFT :  +\n"
            + "CTRL :  ^\n"
            + "ALT :  %\n\n"

            + "BACKSPACE :  {BACKSPACE}, {BS}, or {BKSP}\n"
            + "BREAK :  {BREAK}\n"
            + "CAPS LOCK :  {CAPSLOCK}\n"
            + "DEL or DELETE :  {DELETE} or {DEL}\n"
            + "DOWN ARROW :  {DOWN}\n"
            + "END :  {END}\n"
            + "ENTER :  {ENTER}or ~\n"
            + "ESC :  {ESC}\n"
            + "HELP :  {HELP}\n"
            + "HOME :  {HOME}\n"
            + "INS or INSERT :  {INSERT} or {INS}\n"
            + "LEFT ARROW :  {LEFT}\n"
            + "NUM LOCK :  {NUMLOCK}\n"
            + "PAGE DOWN :  {PGDN}\n"
            + "PAGE UP :  {PGUP}\n"
            + "PRINT SCREEN :  {PRTSC} (reserved for future use)\n"
            + "RIGHT ARROW :  {RIGHT}\n"
            + "SCROLL LOCK :  {SCROLLLOCK}\n"
            + "TAB :  {TAB}\n"
            + "UP ARROW :  {UP}\n"
            + "F1 – F12 (F16) :  {F1}…\n"
            + "Keypad add :  {ADD}\n"
            + "Keypad subtract :  {SUBTRACT}\n"
            + "Keypad multiply :  {MULTIPLY}\n"
            + "Keypad divide :  {DIVIDE}\n\n"


            + "SHIFT, CTRL, and ALT with several other keys :   +(k1k2)\n"
            + "Repeating keys :   {key number}\n\n"

            + "For more details see SendKeys class on MSDN.";

        #endregion


        #region Constructors

        protected SendCommandsForm()
        {
            InitializeComponent();

            this.TopMost = true;
            this.Location = Properties.Settings.Default.SendCommandsFormLocation;
        }

        public SendCommandsForm(IntPtr hwnd)
            : this()
        {
            m_Hwnd = hwnd;

            StringBuilder title = new StringBuilder(255);
            User32Windows.GetWindowText(m_Hwnd, title, title.Capacity + 1);

            txtTitle.Text = title.ToString();
        }

        #endregion


        #region Controls' event handlers

        private void SendCommandsForm_Shown(object sender, EventArgs e)
        {
            txtHwnd.Text = m_Hwnd.ToString();
        }

        private void btnSendCommands_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            IntPtr hwnd = (IntPtr)int.Parse(txtHwnd.Text);

            if (!User32Windows.SetForegroundWindow(hwnd))
            {
                MessageBox.Show("Window not found. Try to refresh list.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Thread.Sleep(200);

            var commands = txtCommands.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            for (int i = 0; i < commands.Length; i++)
            {
                SendKeys.SendWait(commands[i]);
            }

            this.TopMost = true;
        }

        private void chkTopmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkTopmost.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(m_HelpMessage, "Send custom commands – help");
        }

        private void txtHwnd_TextChanged(object sender, EventArgs e)
        {
            m_Hwnd = (IntPtr)int.Parse(txtHwnd.Text);

            StringBuilder title = new StringBuilder(255);

            if (User32Windows.IsWindow(m_Hwnd))
            {
                User32Windows.GetWindowText(m_Hwnd, title, title.Capacity + 1);
            }

            txtTitle.Text = title.ToString();
        }

        private void SendCommandsForm_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SendCommandsFormLocation = this.Location;
        }

        private void SendCommandsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        #endregion

        private void btnToolItem_Click(object sender, EventArgs e)
        {
            new SendCommandToolForm(m_Hwnd, txtCommands.Text).Show();
        }
    }
}
