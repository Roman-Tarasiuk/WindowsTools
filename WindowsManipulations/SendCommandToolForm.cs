using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using User32Helper;
using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    public partial class SendCommandToolForm : Form
    {
        #region Fields

        private IntPtr m_HostWindowHwnd;
        private string m_HostWindowTitle = String.Empty;

        private int m_HostWindowOffsetX;
        private int m_HostWindowOffsetY;

        private AnchorHorizontal m_AnchorH = AnchorHorizontal.Left;
        private AnchorVertical m_AnchorV = AnchorVertical.Top;

        private bool m_Clipboard = false;
        private string m_Commands;

        private bool m_MouseIsDown = false;
        private bool m_MouseIsHover = false;
        private bool m_IsRunning = false;
        private bool m_AutoHide = true;
        private bool m_Sleep = false;

        private int m_SleepTimeout = 0;

        private Pen m_PenNormal = new Pen(Color.White);
        private Pen m_PenHover = new Pen(Color.Lime);
        private Rectangle m_DrawRectangle = new Rectangle(0, 0, 19, 19);

        private int m_DX;
        private int m_DY;

        #endregion


        #region Constructors

        public SendCommandToolForm(IntPtr hwnd, string commands)
        {
            InitializeComponent();

            m_HostWindowHwnd = hwnd;
            m_Commands = commands;

            StringBuilder title = new StringBuilder(255);
            try
            {
                User32Windows.GetWindowText(m_HostWindowHwnd, title, title.Capacity + 1);
                m_HostWindowTitle = title.ToString();
            }
            catch { }

            Text = "Send Command - " + title.ToString();

            toolTip1.SetToolTip(this, Text);
        }

        #endregion


        #region Override methods

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

        #endregion


        #region Properties

        public bool AutoHide
        {
            get
            {
                return m_AutoHide;
            }

            set
            {
                m_AutoHide = value;
                autoHideToolStripMenuItem.Checked = m_AutoHide;
            }
        }

        #endregion


        #region Public methods

        public void ToggleSending(Switch sw = Switch.Toggle)
        {
            // Preparing.
            if (sw == Switch.On)
            {
                m_IsRunning = false;
            }
            else if (sw == Switch.Off)
            {
                m_IsRunning = true;
            }

            // Toggling.
            if (m_IsRunning)
            {
                timer1.Stop();
                m_IsRunning = false;
                toggleSendingToolStripMenuItem.Text = "Run";
            }
            else
            {
                timer1.Start();
                m_IsRunning = true;

                CalculateCoordinates();

                toggleSendingToolStripMenuItem.Text = "Stop tool / move";
            }

            propertiesToolStripMenuItem.Enabled = !m_IsRunning;
        }

        #endregion


        #region Controls' event handlers

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendCommandToolForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_MouseIsDown = true;
            Point p = PointToScreen(e.Location);
            m_DX = this.Location.X - p.X;
            m_DY = this.Location.Y - p.Y;
        }

        private void SendCommandToolForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_MouseIsDown = false;
        }

        private void SendCommandToolForm_MouseMove(object sender, MouseEventArgs e)
        {
            m_MouseIsHover = true;
            Invalidate();

            if (m_MouseIsDown && (!m_IsRunning))
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X + m_DX, p.Y + m_DY);
            }
        }

        private void toggleSendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleSending();
        }

        private void SendCommandToolForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!m_IsRunning)
            {
                return;
            }

            if (!User32Windows.SetForegroundWindow(m_HostWindowHwnd))
            {
                MessageBox.Show("Window not found. Try to refresh list.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.m_Clipboard)
            {
                m_Commands = Clipboard.GetText();
            }

            if (m_Commands == String.Empty)
            {
                return;
            }

            if (this.m_Sleep)
            {
                Thread.Sleep(m_SleepTimeout);
            }

            //
            // Working code (using SendKeys class).
            //
            var commands = m_Commands.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            for (int i = 0; i < commands.Length; i++)
            {
                if (this.m_Sleep)
                {
                    Thread.Sleep(m_SleepTimeout);
                }

                SendKeys.SendWait(commands[i]);
            }


            //
            // Working code (using InputSimulator http://inputsimulator.codeplex.com/).
            //
            // var simulator = new InputSimulator();
            // simulator.Keyboard.TextEntry(m_Commands);
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void selectBackgroundImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Image Files(*.PNG;*.JPG;*.BMP)|*.PNG;*.JPG;*.BMP|All files (*.*)|*.*";

            DialogResult result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackgroundImage = new Bitmap(OpenFileDialog.FileName);
            }
        }

        private void SendCommandToolForm_Paint(object sender, PaintEventArgs e)
        {
            if (m_MouseIsHover)
            {
                e.Graphics.DrawRectangle(m_PenHover, m_DrawRectangle);
            }
            else
            {
                e.Graphics.DrawRectangle(m_PenNormal, m_DrawRectangle);
            }
        }

        private void SendCommandToolForm_MouseLeave(object sender, EventArgs e)
        {
            m_MouseIsHover = false;
            Invalidate();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!m_IsRunning)
            {
                return;
            }

            IntPtr foreWindow = User32Windows.GetForegroundWindow();

            var title = User32Windows.GetWindowText(foreWindow, 255);

            if (((foreWindow == m_HostWindowHwnd)
                    || (foreWindow == this.Handle))
                   && (!User32Windows.IsIconic(m_HostWindowHwnd))
                 || (title == m_HostWindowTitle))
            {
                if ((foreWindow != m_HostWindowHwnd) && (foreWindow != this.Handle))
                {
                    m_HostWindowHwnd = foreWindow;
                    CalculateCoordinates();
                }

                Rectangle rHost;
                User32Windows.GetWindowRect(m_HostWindowHwnd, out rHost);

                int newX = 0,
                    newY = 0;

                if (m_AnchorH == AnchorHorizontal.Left)
                {
                    newX = rHost.Left + m_HostWindowOffsetX;
                }
                else
                {
                    newX = rHost.Width + m_HostWindowOffsetX;
                }

                if (m_AnchorV == AnchorVertical.Top)
                {
                    newY = rHost.Top + m_HostWindowOffsetY;
                }
                else
                {
                    newY = rHost.Height + m_HostWindowOffsetY;
                }

                if ((this.Location.X != newX) || (this.Location.Y != newY))
                {
                    this.Location = new Point(newX, newY);
                }

                if (!this.Visible)
                {
                    this.Show();
                }
            }
            else if (User32Windows.IsIconic(m_HostWindowHwnd))
            {
                this.Hide();
            }
            else
            {
                Rectangle rForeWindow;
                User32Windows.GetWindowRect(foreWindow, out rForeWindow);

                var r = this.RectangleToScreen(this.DisplayRectangle);
                var contains = RectangleContains(rForeWindow, r);

                int processId,
                    ptocessIdThis;
                User32Windows.GetWindowThreadProcessId(foreWindow, out processId);
                User32Windows.GetWindowThreadProcessId(this.Handle, out ptocessIdThis);

                if (this.Visible && m_AutoHide && contains && (processId != ptocessIdThis))
                {
                    this.Hide();
                }
            }
        }

        private void autoHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_AutoHide = !m_AutoHide;
            autoHideToolStripMenuItem.Checked = m_AutoHide;
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SendCommandToolPropertiesForm()
            {
                ToolWidht = this.Size.Width,
                ToolHeight = this.Size.Height,
                AnchorH = m_AnchorH,
                AnchorV = m_AnchorV,
                Commands = m_Commands,
                ClipboardCommand = m_Clipboard,
                Sleep = m_Sleep,
                SleepTimeout = m_SleepTimeout
            };
            var result = settingsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Size = new Size(settingsForm.ToolWidht, settingsForm.ToolHeight);
                this.m_AnchorH = settingsForm.AnchorH;
                this.m_AnchorV = settingsForm.AnchorV;
                this.m_DrawRectangle = new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1);

                this.m_Commands = settingsForm.Commands;
                this.m_Clipboard = settingsForm.ClipboardCommand;

                this.m_Sleep = settingsForm.Sleep;
                this.m_SleepTimeout = settingsForm.SleepTimeout;
            }
        }

        #endregion


        #region Helper methods

        private bool RectangleContains(Rectangle r1, Rectangle r2)
        {
            return r1.Left <= r2.Left
                && r1.Top <= r2.Top
                && r1.Width >= r2.Right
                && r1.Height >= r2.Bottom;
        }

        private void CalculateCoordinates()
        {
            Rectangle rHost;
            User32Windows.GetWindowRect(m_HostWindowHwnd, out rHost);

            if (m_AnchorH == AnchorHorizontal.Left)
            {
                m_HostWindowOffsetX = this.Location.X - rHost.Left;
            }
            else
            {
                m_HostWindowOffsetX = this.Location.X - rHost.Width;
            }

            if (m_AnchorV == AnchorVertical.Top)
            {
                m_HostWindowOffsetY = this.Location.Y - rHost.Top;
            }
            else
            {
                m_HostWindowOffsetY = this.Location.Y - rHost.Height;
            }
        }

        #endregion
    }
}
