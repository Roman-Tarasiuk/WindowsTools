using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using User32Helper;
using WindowsTools.Infrastructure;
using NLog;
// using System.Diagnostics;

namespace WindowsTools
{
    public partial class SendCommandToolForm : Form
    {
        public event EventHandler<ToolEventArgs> Exit;

        #region Fields

        private Logger logger = LogManager.GetCurrentClassLogger();

        private IntPtr m_HostWindowHwnd;
        private string m_HostWindowTitle = String.Empty;

        private int m_HostWindowOffsetX;
        private int m_HostWindowOffsetY;

        private AnchorHorizontal m_AnchorH = AnchorHorizontal.Left;
        private AnchorVertical m_AnchorV = AnchorVertical.Top;

        private SendCommandType m_SendCommandType = SendCommandType.Command;
        private string m_Commands;

        private bool m_MouseIsDown = false;
        private bool m_MouseIsHover = false;
        private bool m_IsRunning = false;
        private bool m_AutoHide = true;
        private bool m_Sleep = false;
        private bool m_RunOnAllWindowsWithSameTitle = true;
        private string m_TitlePattern = String.Empty;
        private Regex m_TitleRegex = null;

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

            var refreshIntervalStr = ConfigurationManager.AppSettings.Get("CommandToolRefreshInterval");
            this.timer1.Interval = int.Parse(refreshIntervalStr);

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
            ProcessClick();
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
                using (var bmpTemp = new Bitmap(OpenFileDialog.FileName))
                {
                    this.BackgroundImage = new Bitmap(bmpTemp);
                }
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
            CheckToolDisplaying();
        }

        private void autoHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoHide = !AutoHide;
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SendCommandToolPropertiesForm()
            {
                HostHwnd = this.m_HostWindowHwnd,
                ToolWidht = this.Size.Width,
                ToolHeight = this.Size.Height,
                AnchorH = m_AnchorH,
                AnchorV = m_AnchorV,
                Commands = m_Commands,
                CommandType = m_SendCommandType,
                Sleep = m_Sleep,
                SleepTimeout = m_SleepTimeout,
                RunOnAllWindowsWithSameTitle = m_RunOnAllWindowsWithSameTitle,
                ToolLeft = this.Location.X,
                ToolTop = this.Location.Y,
                BorderColor = this.m_PenNormal.Color,
                BorderHoverColor = this.m_PenHover.Color,
                TitlePattern = this.m_TitlePattern
            };

            var result = settingsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.m_HostWindowHwnd = settingsForm.HostHwnd;
                this.Size = new Size(settingsForm.ToolWidht, settingsForm.ToolHeight);
                this.m_AnchorH = settingsForm.AnchorH;
                this.m_AnchorV = settingsForm.AnchorV;
                this.m_DrawRectangle = new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1);

                this.m_Commands = settingsForm.Commands;
                this.m_SendCommandType = settingsForm.CommandType;

                if (this.m_SendCommandType == SendCommandType.ActivateWindow)
                {
                    int handle;
                    if (int.TryParse(m_Commands, out handle))
                    {
                        if (User32Windows.IsWindow((IntPtr)handle))
                        {
                            var icon = User32Windows.GetIcon((IntPtr)handle);

                            if (icon != null)
                            {
                                this.BackgroundImage = icon.ToBitmap();
                            }
                        }
                    }
                }

                this.m_Sleep = settingsForm.Sleep;
                this.m_SleepTimeout = settingsForm.SleepTimeout;
                this.m_RunOnAllWindowsWithSameTitle = settingsForm.RunOnAllWindowsWithSameTitle;
                this.m_TitlePattern = settingsForm.TitlePattern;

                this.Location = new Point(settingsForm.ToolLeft, settingsForm.ToolTop);

                this.m_PenNormal.Color = settingsForm.BorderColor;
                this.m_PenHover.Color = settingsForm.BorderHoverColor;

                if (m_TitlePattern != String.Empty)
                {
                    m_TitleRegex = new Regex(m_TitlePattern);
                }
                else
                {
                    m_TitleRegex = null;
                }
            }
        }

        private void SendCommandToolForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!m_IsRunning)
            {
                var offset = 11;

                if (e.Control)
                {
                    offset = 1;
                }

                switch (e.KeyCode)
                {
                    case Keys.Left:
                        this.Location = new Point(this.Location.X - offset, this.Location.Y);
                        break;
                    case Keys.Right:
                        this.Location = new Point(this.Location.X + offset, this.Location.Y);
                        break;
                    case Keys.Up:
                        this.Location = new Point(this.Location.X, this.Location.Y - offset);
                        break;
                    case Keys.Down:
                        this.Location = new Point(this.Location.X, this.Location.Y + offset);
                        break;
                }
            }
        }

        private void SendCommandToolForm_SizeChanged(object sender, EventArgs e)
        {
            this.m_DrawRectangle = new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1);
        }

        #endregion


        #region Helper methods

        private void ProcessClick()
        {
            if (!m_IsRunning)
            {
                return;
            }

            if (!User32Windows.IsWindow(m_HostWindowHwnd))
            {
                MessageBox.Show("Hosting window not found. Close the tool or set its hosting window.",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.m_SendCommandType == SendCommandType.ActivateWindow)
            {
                int handleTmp;
                if (int.TryParse(m_Commands, out handleTmp))
                {
                    var handle = (IntPtr)handleTmp;
                    if (User32Windows.IsIconic(handle))
                    {
                        User32Windows.ShowWindow(handle, User32Windows.SW_RESTORE);
                    }
                    User32Windows.SetForegroundWindow(handle);
                }
                else
                {
                    MessageBox.Show(String.Format("Window {0} not found.", m_Commands),
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            else if (this.m_SendCommandType == SendCommandType.ActivateLastN)
            {
                int lastN;
                if (int.TryParse(m_Commands, out lastN))
                {
                    var handle = IntPtr.Zero;

                    var windows = User32Windows.GetDesktopWindows(getIcons: false);

                    var programWindows = Application.OpenForms.Cast<Form>().Select(i => i.Handle);
                    
                    if (lastN < windows.Count)
                    {
                        var i = 0;
                        for ( ; i < lastN; i++)
                        {
                            if (programWindows.Contains(windows[i].Handle))
                            {
                                lastN++;
                                if (lastN == windows.Count)
                                {
                                    return;
                                }
                            }
                        }
                        handle = windows[i - 1].Handle;
                    }
                    else
                    {
                        return;
                    }

                    if (User32Windows.IsIconic(handle))
                    {
                        User32Windows.ShowWindow(handle, User32Windows.SW_RESTORE);
                    }
                    User32Windows.SetForegroundWindow(handle);
                }
                else
                {
                    MessageBox.Show(String.Format("Window {0} not found.", m_Commands),
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            User32Windows.SetForegroundWindow(m_HostWindowHwnd);

            if (this.m_SendCommandType == SendCommandType.Clipboard)
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

            var lastWindow = User32Windows.GetLastActiveWindow(hwndExcept: this.Handle);

            User32Windows.SetForegroundWindow(lastWindow.Handle);

            //
            // Working code (using InputSimulator http://inputsimulator.codeplex.com/).
            //
            // var simulator = new InputSimulator();
            // simulator.Keyboard.TextEntry(m_Commands);
        }

        private bool RectangleContains(Rectangle outer, Rectangle inner)
        {
            // Outer rectangle is get by the User32Windows.GetWindowRect()
            // which returns rectangle that actually has
            // its width = right, height = bottom.

            return outer.Left <= inner.Left
                && outer.Top <= inner.Top
                && outer.Width >= inner.Right
                && outer.Height >= inner.Bottom;
        }

        private bool RectangleIntersects(Rectangle outer, Rectangle inner)
        {
            // See comment to the RectangleContains() method.

            Rectangle tmp = new Rectangle(outer.Left, outer.Top, outer.Width - outer.Left, outer.Height - outer.Top);

            var intersect =Rectangle.Intersect(tmp, inner);
            if (intersect != Rectangle.Empty)
            {
                return true;
            }

            return false;
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

        private void CheckToolDisplaying()
        {
            if (!m_IsRunning)
            {
                return;
            }

            IntPtr foreWindow = User32Windows.GetForegroundWindow();
            var title = User32Windows.GetWindowText(foreWindow, 255);
            bool matchesTitlePattern = false;

            if (    ((foreWindow == m_HostWindowHwnd || foreWindow == this.Handle)
                      && !User32Windows.IsIconic(m_HostWindowHwnd))
                 || (title == m_HostWindowTitle && m_RunOnAllWindowsWithSameTitle)
                 || (m_TitlePattern != String.Empty && (matchesTitlePattern = m_TitleRegex.IsMatch(title))))
            {
                // if ((foreWindow != m_HostWindowHwnd) && (foreWindow != this.Handle))
                // {
                //     int pidFore, pidThis;
                //     User32Windows.GetWindowThreadProcessId(foreWindow, out pidFore);
                //     User32Windows.GetWindowThreadProcessId(this.Handle, out pidThis);
                //     if (pidFore == pidThis)
                //     {
                //         return;
                //     }
                // 
                //     m_HostWindowHwnd = foreWindow;
                //     m_HostWindowTitle = title;
                //     if (!matchesTitlePattern)
                //     {
                //         CalculateCoordinates();
                //     }
                // }

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
                    Task.Delay(timer1.Interval).ContinueWith(t => this.Show());
                }
            }
            else if ((!m_RunOnAllWindowsWithSameTitle) && (!User32Windows.IsWindow(m_HostWindowHwnd)))
            {
                if (this.Exit != null)
                {
                    this.Exit.Invoke(this, new ToolEventArgs() { Title = m_HostWindowTitle });
                }
                this.Close();
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
                var contains = RectangleContains(rForeWindow, r)
                            || RectangleIntersects(rForeWindow, r);

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

        #endregion
    }
}
