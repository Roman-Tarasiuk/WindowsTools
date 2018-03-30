using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using User32Helper;

namespace WindowsTools
{
    public partial class TrackInactiveWindowForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool IsHungAppWindow(IntPtr hWnd);

        #region Fields

        private IntPtr m_Hwnd = IntPtr.Zero;
        private bool m_Running = false;
        private bool m_WindowIsHanging;
        private DateTime m_StartTime;

        private Color m_ColorAccessible = Color.FromArgb(159, 242, 159);
        private Color m_ColorHung = Color.FromArgb(255, 71, 26);

        #endregion


        #region Public Properties

        public IntPtr Hwnd
        {
            get
            {
                return m_Hwnd;
            }
            set
            {
                if (m_Running)
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

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (m_Running)
            {
                StopTracking();

                m_Running = false;
                btnStartStop.Text = "Start";
            }
            else
            {
                StartTracking();

                m_Running = true;
                btnStartStop.Text = "Stop";
            }
        }

        private void txtHwnd_Leave(object sender, EventArgs e)
        {
            if (m_Running)
            {
                return;
            }

            var hwnd = (IntPtr)int.Parse(txtHwnd.Text);
            if (User32Windows.IsWindow(hwnd))
            {
                Hwnd = hwnd;
            }
            else
            {
                Hwnd = IntPtr.Zero;
            }

            DisplayTitle();
        }

        private void chkTopmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkTopmost.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!User32Windows.IsWindow(Hwnd))
            {
                timer1.Stop();

                m_Running = false;
                btnStartStop.Text = "Start";
            }

            string message = String.Empty;
            var now = DateTime.Now;
            var wasRunnind = now - m_StartTime;

            if (!m_Running)
            {
                message = FormatTime(now) + " the program is closed now and was in the previous state: " + FormatTime(wasRunnind) + " hours";
            }
            else
            {
                if (IsHungAppWindow(Hwnd) && !m_WindowIsHanging)
                {
                    m_WindowIsHanging = true;
                    m_StartTime = now;
                    message = FormatTime(now) + " the program is hung now and was in the previous state: " + FormatTime(wasRunnind) + " hours";
                    this.BackColor = m_ColorHung;
                }
                else if (!IsHungAppWindow(Hwnd) && m_WindowIsHanging)
                {
                    m_WindowIsHanging = false;
                    m_StartTime = now;
                    message = FormatTime(now) + " the program is accessible now and was in the previous state: " + FormatTime(wasRunnind) + " hours";
                    this.BackColor = m_ColorAccessible;
                }
            }

            if (message != String.Empty)
            {
                Log(message);
            }
        }

        private void chkWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            txtLog.WordWrap = chkWordWrap.Checked;
        }

        #endregion


        #region Helper Methods

        private void StartTracking()
        {
            if (Hwnd == IntPtr.Zero || !User32Windows.IsWindow(Hwnd))
            {
                MessageBox.Show("No window is selected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            m_StartTime = DateTime.Now;
            m_WindowIsHanging = IsHungAppWindow(m_Hwnd);

            var msg = "Start tracking"
                + " [" + Hwnd.ToString() + "] \"" + User32Windows.GetWindowText(Hwnd, 255) + "\""
                + "\r\n" + FormatTime(m_StartTime)
                + " the program is " + (m_WindowIsHanging ? "hung" : "accessible");

            var backColor = m_WindowIsHanging ? m_ColorHung : m_ColorAccessible;
            this.BackColor = backColor;

            Log(msg);

            timer1.Start();
        }

        private void StopTracking()
        {
            timer1.Stop();

            var now = DateTime.Now;
            m_WindowIsHanging = IsHungAppWindow(m_Hwnd);

            var wasRunnind = now - m_StartTime;

            var msg = FormatTime(now)
                + " the program is " + (m_WindowIsHanging ? "hung" : "accessible")
                + "\r\nStop tracking (after " + FormatTime(wasRunnind) + " hours)";

            this.BackColor = m_ColorAccessible;

            Log(msg);
        }

        private string FormatTime(DateTime t)
        {
            return t.ToLongTimeString();
        }

        private string FormatTime(TimeSpan t)
        {
            return t.ToString("hh\\:mm\\:ss");
        }

        private void Log(string str)
        {
            txtLog.Text += (txtLog.Text == String.Empty ? "" : "\r\n") + str;

            txtLog.Focus();
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.SelectionLength = 0;
            txtLog.ScrollToCaret();
            SendKeys.Send("{HOME}");
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

        #endregion
    }
}
