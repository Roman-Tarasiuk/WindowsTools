using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

using User32Helper;
using System.Drawing;
using WindowsTools.Infrastructure;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsTools
{
    public partial class SendCommandsForm : Form, IProgramSettings
    {
        public event EventHandler<ToolEventArgs> ToolExit;
        public event EventHandler SettingsChanged;

        #region Fields

        private IntPtr m_HostedWindowHwnd;
        private List<SendCommandToolForm> m_Tools;

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


        #region Properties

        public IntPtr HostedWindowHwnd
        {
            get
            {
                return m_HostedWindowHwnd;
            }

            set
            {
                m_HostedWindowHwnd = value;
                txtHwnd.Text = m_HostedWindowHwnd.ToString();
                GetWindowInfo();
            }
        }

        #endregion


        #region Constructors

        public SendCommandsForm()
        {
            InitializeComponent();

            this.TopMost = true;
            this.Location = Properties.Settings.Default.SendCommandsForm_Location;
        }

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

        public SendCommandsForm(IntPtr hwnd)
            : this()
        {
            m_HostedWindowHwnd = hwnd;

            txtTitle.Text = User32Windows.GetWindowText(m_HostedWindowHwnd, 255);
        }

        #endregion


        #region Controls' event handlers

        private void SendCommandsForm_Shown(object sender, EventArgs e)
        {
            txtHwnd.Text = m_HostedWindowHwnd.ToString();
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
                Thread.Sleep(200);
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
            GetWindowInfo();
        }

        private void SendCommandsForm_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                Properties.Settings.Default.SendCommandsForm_Location = this.Location;

                if (SettingsChanged != null)
                {
                    SettingsChanged.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void SendCommandsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnNewToolItem_Click(object sender, EventArgs e)
        {
            // var tool = new SendCommandToolForm(m_HostedWindowHwnd, txtCommands.Text) { Owner = this };
            var tool = new SendCommandToolForm(m_HostedWindowHwnd, txtCommands.Text);
            tool.Location = new Point(this.Location.X + 125, this.Location.Y + 85);

            if (m_Tools == null)
            {
                m_Tools = new List<SendCommandToolForm>();
            }

            tool.Exit += OnToolExit;

            m_Tools.Add(tool);

            tool.Show();
        }

        private void OnToolExit(object sender, ToolEventArgs e)
        {
            m_Tools.Remove((SendCommandToolForm)sender);
            if (ToolExit != null)
            {
                ToolExit.Invoke(this, e);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private void hideAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllTools();
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinimizeAllTools();
        }

        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreAllTools();
        }

        private void setAutohideToAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAutohideForAllTools();
        }

        private void removeAutohideFromAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAutohideFromAllTools();
        }

        private void startAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartAllTools(startAllToolStripMenuItem);
        }

        private void saveAllToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAllTools();
        }

        private void loadToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTools();
        }

        private void activateToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                activateToolsToolStripMenuItem.Text = "Activate tools...";
            }
            else
            {
                var prompt = new PromptForm() { Description = "Activate tools every N seconds", UserInput = "10" };

                var result = prompt.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }

                int interval;
                if (int.TryParse(prompt.UserInput, out interval))
                {
                    timer1.Interval = interval * 1000;
                    timer1.Start();
                    activateToolsToolStripMenuItem.Text = "Stop activating";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowToolsOverOtherWindows();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTools();
        }

        #endregion


        #region Helper methods

        private void GetWindowInfo()
        {
            m_HostedWindowHwnd = (IntPtr)int.Parse(txtHwnd.Text);

            StringBuilder title = new StringBuilder(255);

            if (User32Windows.IsWindow(m_HostedWindowHwnd))
            {
                User32Windows.GetWindowText(m_HostedWindowHwnd, title, title.Capacity + 1);
            }

            txtTitle.Text = title.ToString();
        }

        private void CheckInactiveTools()
        {
            m_Tools.RemoveAll(t => t == null || t.IsDisposed);
        }

        private void SaveAllTools()
        {
            var fileDialog = new SaveFileDialog();
            var result = fileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            using (var writer = new StreamWriter(fileDialog.FileName, false))
            {
                foreach (var t in m_Tools)
                {
                    writer.WriteLine(t.Location.ToString());
                    writer.WriteLine(t.Size.ToString());
                    writer.WriteLine(t.BackgroundImagePath);
                }
            }
        }

        private void LoadTools()
        {
            var fileDialog = new OpenFileDialog();
            var result = fileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            if (m_Tools == null)
            {
                m_Tools = new List<SendCommandToolForm>();
            }
            else if (m_Tools.Count > 0)
            {
                var result2 = MessageBox.Show("There are tools, keep them?", "Load tools...", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.No)
                {
                    CloseAllTools();
                }
            }
            

            using (var reader = new StreamReader(fileDialog.FileName))
            {
                string str;
                while ((str = reader.ReadLine()) != null) // Location
                {
                    var tool = new SendCommandToolForm(m_HostedWindowHwnd, String.Empty);
                    
                    var g = Regex.Replace(str, @"[\{\}a-zA-Z=]", "").Split(',');
                    tool.Location = new Point(
                        int.Parse(g[0]),
                        int.Parse(g[1]));

                    str = reader.ReadLine(); // Size
                    g = Regex.Replace(str, @"[\{\}a-zA-Z=]", "").Split(',');
                    tool.Size = new Size(
                        int.Parse(g[0]),
                        int.Parse(g[1]));

                    str = reader.ReadLine(); // BackgroundImagePath
                    tool.BackgroundImagePath = str;

                    m_Tools.Add(tool);
                    tool.Show();
                }
            }
        }

        private void ShowToolsOverOtherWindows()
        {
            // We need activate some window of our program,
            // otherwise tools cannot be activated and showed over other windows.

            var foreground = User32Windows.GetForegroundWindow();
            User32Windows.SetForegroundWindow(this.Handle);

            //

            foreach (var t in m_Tools)
            {
                User32Windows.SetForegroundWindow(t.Handle);
            }

            //

            User32Windows.SetForegroundWindow(foreground);
        }

        #endregion


        #region Public Methods

        public void StartAllTools(ToolStripMenuItem item)
        {
            CheckInactiveTools();

            if (item.Text == "Start all")
            {
                foreach (var t in m_Tools)
                {
                    t.ToggleSending(Switch.On);
                }

                item.Text = "Stop all";
            }
            else
            {
                foreach (var t in m_Tools)
                {
                    t.ToggleSending(Switch.Off);
                }

                item.Text = "Start all";
            }
        }

        public void HideAllTools()
        {
            CheckInactiveTools();

            foreach (var t in m_Tools)
            {
                t.Hide();
            }
        }

        public void MinimizeAllTools()
        {
            CheckInactiveTools();

            foreach (var t in m_Tools)
            {
                t.WindowState = FormWindowState.Minimized;
            }
        }

        public void RestoreAllTools()
        {
            CheckInactiveTools();

            foreach (var t in m_Tools)
            {
                t.Show();
                t.WindowState = FormWindowState.Normal;
            }
        }

        public void SetAutohideForAllTools()
        {
            CheckInactiveTools();

            foreach (var t in m_Tools)
            {
                t.AutoHide = true;
            }
        }

        public void RemoveAutohideFromAllTools()
        {
            CheckInactiveTools();

            foreach (var t in m_Tools)
            {
                t.AutoHide = false;
            }
        }

        private void CloseAllTools()
        {
            foreach (var t in m_Tools)
                t.Close();

            m_Tools.Clear();
        }

        #endregion
    }
}
