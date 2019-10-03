using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using User32Helper;

using WindowsTools.Infrastructure;

namespace WindowsTools
{
    public partial class TrackInactiveWindowForm : Form, IProgramSettings
    {
        [DllImport("user32.dll")]
        public static extern bool IsHungAppWindow(IntPtr hWnd);

        #region Fields

        private bool m_TrackModalWindow = false;

        private IntPtr m_Hwnd = IntPtr.Zero;
        private bool m_TrackingIsRunning = false;
        private bool m_TrackingIsValid = true;
        private bool m_WindowIsHung;
        private DateTime m_StartTime;
        private int m_SelectionStart = 0;

        private Color m_ColorAccessible = Color.FromArgb(159, 242, 159);
        private Color m_ColorHung = Color.FromArgb(255, 71, 26);

        private bool m_ShowOptions = true;

        private bool m_MouseIsDown = false;
        private Point m_MouseDownCoordinates;

		private bool m_BorderIsVisible = false;
		private int m_BorderOffsetX = 0;
		private int m_BorderOffsetY = 0;

        #endregion


        #region Public Properties

        public event EventHandler SettingsChanged;

        public IntPtr Hwnd
        {
            get
            {
                return m_Hwnd;
            }
            set
            {
                if (m_TrackingIsRunning)
                {
                    throw new InvalidOperationException("Cannot set the Hwnd property when tracking is running.");
                }

                m_Hwnd = value;

                txtHwnd.Text = m_Hwnd.ToString();
                DisplayTitle();
            }
        }

        #endregion


        #region Constructors

        public TrackInactiveWindowForm()
        {
            InitializeComponent();

            DisplayTitle();

            this.Size =  Properties.Settings.Default.TrackInactiveFormSize;

            //

            this.MouseDown += (sender, e) =>
            {
                m_MouseIsDown = true;
                m_MouseDownCoordinates = e.Location;
            };

            this.MouseUp += (sender, e) =>
            {
                m_MouseIsDown = false;
            };

            this.MouseMove += (sender, e) =>
            {
                if (m_MouseIsDown)
                {
                    Point LocationNew = new Point(this.Location.X + e.Location.X - m_MouseDownCoordinates.X,
                        this.Location.Y + e.Location.Y - m_MouseDownCoordinates.Y);

                    this.Location = LocationNew;
                }
            };

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

        #endregion


        #region Event Handlers

        private void OnSettingsChanged()
        {
            if (SettingsChanged != null)
            {
                SettingsChanged.Invoke(this, EventArgs.Empty);
            }
        }

        private void formSize_Changed(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                Properties.Settings.Default.TrackInactiveFormSize = this.Size;
                OnSettingsChanged();
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!m_TrackingIsValid)
            {
                this.Close();
                return;
            }

            if (m_TrackingIsRunning)
            {
                StopTracking();

                m_TrackingIsRunning = false;
                m_WindowIsHung = false;
                btnStartStop.Text = "Start";
            }
            else
            {
                StartTracking();

                m_TrackingIsRunning = true;
                btnStartStop.Text = "Stop";
            }

            WindowColors();
        }

        private void txtLog_Click(object sender, EventArgs e)
        {
            this.m_SelectionStart = txtLog.SelectionStart;
        }

        private void txtLog_DoubleClick(object sender, EventArgs e)
        {
            var sizeDelta = 34;

            if (m_ShowOptions)
            {
                this.chkShowInTaskbar.Visible = false;
                this.chkTopmost.Visible = false;
                this.chkTrackModalWindow.Visible = false;
                this.chkWordWrap.Visible = false;
                this.chkShowBorder.Visible = false;
                this.txtLog.Size = new Size(this.txtLog.Size.Width, this.txtLog.Size.Height + sizeDelta);
                m_ShowOptions = false;
            }
            else
            {
                this.chkShowInTaskbar.Visible = true;
                this.chkTopmost.Visible = true;
                this.chkTrackModalWindow.Visible = true;
                this.chkWordWrap.Visible = true;
                this.chkShowBorder.Visible = true;
                this.txtLog.Size = new Size(this.txtLog.Size.Width, this.txtLog.Size.Height - sizeDelta);
                m_ShowOptions = true;
            }

            txtLog.SelectionStart = m_SelectionStart;
            txtLog.SelectionLength = 0;
        }

        private void txtHwnd_Leave(object sender, EventArgs e)
        {
            if (m_TrackingIsRunning)
            {
                return;
            }

            var hwnd = (IntPtr)int.Parse(txtHwnd.Text);
            if (User32Windows.IsWindow(hwnd))
            {
                Hwnd = hwnd;
                btnStartStop.Enabled = true;
                btnStartStop.Text = "Start";
                chkTrackModalWindow.Enabled = true;
                m_TrackingIsValid = true;
            }
            else
            {
                Hwnd = IntPtr.Zero;
                btnStartStop.Enabled = false;
            }

            DisplayTitle();
        }

        private void chkTrackModalWindow_CheckedChanged(object sender, EventArgs e)
        {
            this.m_TrackModalWindow = chkTrackModalWindow.Checked;
        }

        private void chkTopmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkTopmost.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProcessTracking();
        }

        private void chkWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            txtLog.WordWrap = chkWordWrap.Checked;
        }

        private void chkShowBorder_CheckedChanged(object sender, EventArgs e)
        {
            // if (chkShowBorder.Checked)
            // {
            //     this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            // }
            // else
            // {
            //     this.FormBorderStyle = FormBorderStyle.None;
            // }
			ToggleBorder(chkShowBorder.Checked);
        }

		private void ToggleBorder(bool visibility)
        {
            if (m_BorderIsVisible == visibility)
            {
                return;
            }

            m_BorderIsVisible = visibility;

            if (!visibility)
            {
                this.FormBorderStyle = FormBorderStyle.None;

                this.Location = new Point(this.Location.X + m_BorderOffsetX, this.Location.Y + m_BorderOffsetY);
            }
            else
            {
                var currentLocation = this.txtLog.PointToScreen(this.txtLog.Location);
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;

                if (m_BorderOffsetX == 0 || m_BorderOffsetY == 0)
                {
                    var newLocation = this.txtLog.PointToScreen(this.txtLog.Location);
                    m_BorderOffsetX = newLocation.X - currentLocation.X;
                    m_BorderOffsetY = newLocation.Y - currentLocation.Y;
                }

                this.Location = new Point(this.Location.X - m_BorderOffsetX, this.Location.Y - m_BorderOffsetY);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowInTaskbar = chkShowInTaskbar.Checked;
        }

        #endregion


        #region Helper Methods

        private void ProcessTracking()
        {
            if (!User32Windows.IsWindow(Hwnd))
            {
                timer1.Stop();

                m_TrackingIsRunning = false;
                btnStartStop.Text = "Start";
            }

            string message = String.Empty;
            var now = DateTime.Now;
            var wasRunnind = now - m_StartTime;

            if (!m_TrackingIsRunning)
            {
                message = FormatTime(now)
                    + " the " + (m_TrackModalWindow ? "modal window" : "program")
                    + " is closed now and was in the previous state: "
                    + FormatTime(wasRunnind) + ".";
                m_WindowIsHung = false;

                this.m_TrackingIsValid = false;
                this.btnStartStop.Text = "Close";
            }
            else
            {
                if (m_TrackModalWindow)
                {
                    return;
                }
                else if (IsHungAppWindow(Hwnd) && !m_WindowIsHung)
                {
                    m_WindowIsHung = true;

                    // The Windows OS detects hung window after 5 seconds.
                    var fiveSeconds = new TimeSpan(0, 0, 5);
                    m_StartTime = now - fiveSeconds;
                    wasRunnind -= fiveSeconds;
                    message = FormatTime(now)
                        + " the program is hung now and was in the previous state: "
                        + FormatTime(wasRunnind) + ".";
                }
                else if (!IsHungAppWindow(Hwnd) && m_WindowIsHung)
                {
                    m_WindowIsHung = false;
                    m_StartTime = now;
                    message = FormatTime(now)
                        + " the program is accessible now and was in the previous state: "
                        + FormatTime(wasRunnind) + ".";
                }
            }

            if (message != String.Empty)
            {
                Log(message);
                WindowColors();

                if (!m_TrackingIsRunning)
                {
                    Log("Please close this window.");
                }
            }
        }

        private void StartTracking()
        {
            if (Hwnd == IntPtr.Zero || !User32Windows.IsWindow(Hwnd))
            {
                MessageBox.Show("No window is selected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            m_StartTime = DateTime.Now;
            m_WindowIsHung = IsHungAppWindow(m_Hwnd) || m_TrackModalWindow;

            var msg = "• Start tracking"
                + " [" + Hwnd.ToString() + "] \"" + User32Windows.GetWindowText(Hwnd, 255) + "\""
                + "\r\n" + FormatTime(m_StartTime)
                + " the program is " + (m_WindowIsHung ? "hung" : "accessible") + ".";

            Log(msg);
            WindowColors();

            chkTrackModalWindow.Enabled = false;

            timer1.Start();
        }

        private void StopTracking()
        {
            timer1.Stop();

            var now = DateTime.Now;
            m_WindowIsHung = IsHungAppWindow(m_Hwnd) || m_TrackModalWindow;

            var wasRunnind = now - m_StartTime;

            var msg = FormatTime(now)
                + " the program is " + (m_WindowIsHung ? "hung" : "accessible") + "."
                + "\r\n• Stop tracking (after " + FormatTime(wasRunnind) + " from last state).";

            Log(msg);
            WindowColors();

            chkTrackModalWindow.Enabled = true;
        }

        private string FormatTime(DateTime t)
        {
            return t.ToLongTimeString();
        }

        private string FormatTime(TimeSpan t)
        {
            var result = t.ToString((t.Days > 0 ? "d\\:" : "") + "hh\\:mm\\:ss");

            if (t.Days > 0)
            {
                result += " days";
            }
            else if (t.Hours > 0)
            {
                result += " hours";
            }
            else if (t.Minutes > 0)
            {
                result += " minutes";
            }
            else
            {
                result += " seconds";
            }

            return result;
        }

        private void Log(string str)
        {
            var start = txtLog.Text.Length + 2; // "\r\n" at the end.

            txtLog.Text += (txtLog.Text == String.Empty ? "" : "\r\n") + str;

            txtLog.Focus();
            txtLog.SelectionStart = start;
            txtLog.SelectionLength = 0;
            txtLog.ScrollToCaret();
        }

        private void DisplayTitle()
        {
            if (Hwnd != IntPtr.Zero)
            {
                lblTitle.Text = User32Windows.GetWindowText(Hwnd, 255);
            }
            else
            {
                lblTitle.Text = "-";
            }
        }

        private void WindowColors()
        {
            if (m_WindowIsHung)
            {
                this.BackColor = m_ColorHung;
                this.txtLog.BackColor = m_ColorHung;
                this.txtLog.ForeColor = Color.FromArgb(255, 255, 0);
            }
            else
            {
                this.BackColor = m_ColorAccessible;
                this.txtLog.BackColor = Color.Black;
                this.txtLog.ForeColor = Color.Green;
            }
        }

        #endregion
    }
}
