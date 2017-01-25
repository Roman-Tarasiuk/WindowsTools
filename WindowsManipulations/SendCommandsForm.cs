using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using User32Helper;

namespace WindowsManipulations
{
    public partial class SendCommandsForm : Form
    {
        private IntPtr m_Hwnd;

        protected SendCommandsForm()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        public SendCommandsForm(IntPtr hwnd)
            : this()
        {
            m_Hwnd = hwnd;

            StringBuilder title = new StringBuilder(255);
            User32Windows.GetWindowText(m_Hwnd, title, title.Capacity + 1);

            txtTitle.Text = title.ToString();
        }

        private void SendCommandsForm_Shown(object sender, EventArgs e)
        {
            txtHwnd.Text = m_Hwnd.ToString();
        }

        private void btnSendCommands_Click(object sender, EventArgs e)
        {
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
        }

        private void chkTopmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkTopmost.Checked;
        }
    }
}
