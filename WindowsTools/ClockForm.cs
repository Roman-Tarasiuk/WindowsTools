using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using User32Helper;

using WindowsTools.Infrastructure;

namespace WindowsTools
{
    public partial class ClockForm : Form
    {
        #region Private Members

        private bool m_Minimize = false;
        private DateTime m_CurrentDate = DateTime.Now;
        private bool m_Moving = false;

        private Size m_WindowSize = new Size(82, 38);

        private TransparentDraggablePanel panel1;

        private Color m_BorderColor;
        private int m_BorderLeft;
        private int m_BorderTop;
        private int m_BorderRight;
        private int m_BorderBottom;

        const int WS_MINIMIZEBOX = 0x20000;
        const int WS_SYSMENU = 0x80000;

        #endregion


        #region Constructors

        public ClockForm()
        {
            InitializeComponent();

            InitializePanel();
            InitializeOther();

            ShowDateTime(true);
        }

        #endregion


        #region Override

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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (var Pen = new Pen(m_BorderColor))
            {
                e.Graphics.DrawRectangle(Pen, new Rectangle(m_BorderLeft, m_BorderTop, m_BorderRight, m_BorderBottom));
            }
        }

        #endregion


        #region Event Handlers

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!m_Moving)
            {
                ShowCalendar();
            }
            else
            {
                m_Moving = false;
            }
        }

        private void Panel1_Moving(object sender, MovingPanelEventArgs e)
        {
            Location = PointToScreen(new Point(e.X, e.Y));
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Size = m_WindowSize;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowDateTime(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (!m_Minimize)
                {
                    User32Windows.ShowWindow(this.Handle, User32Windows.SW_RESTORE);
                }
                else
                {
                    m_Minimize = false;
                }
            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Minimize = true;
            User32Windows.ShowWindow(this.Handle, User32Windows.SW_MINIMIZE);
        }

        private void currentDateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NowToClipblard();
        }

        private void topmostCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCalendar(true);
        }

        #endregion


        #region Helper Methods

        private void InitializePanel()
        {
            this.panel1 = new TransparentDraggablePanel(this);
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)
                System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = this.Size;
            this.panel1.TabIndex = 2;
            this.panel1.MouseClick += Panel1_MouseClick;

            this.Controls.Add(this.panel1);
            this.panel1.BringToFront();
        }

        private void InitializeOther()
        {
            var borderColorStr = ConfigurationManager.AppSettings.Get("ClockBorderColor");
            this.m_BorderColor = this.FromRgbString(borderColorStr);
            
            var backColorStr = ConfigurationManager.AppSettings.Get("ClockBackColor");
            var backColor = this.FromRgbString(backColorStr);
            this.BackColor = backColor;

            var foreColorStr = ConfigurationManager.AppSettings.Get("ClockForeColor");
            var foreColor = this.FromRgbString(foreColorStr);
            this.lblClock.ForeColor = foreColor;
            this.lblDate.ForeColor = foreColor;

            m_BorderLeft = int.Parse(ConfigurationManager.AppSettings.Get("ClockBorderLeft"));
            m_BorderTop = int.Parse(ConfigurationManager.AppSettings.Get("ClockBorderTop"));
            m_BorderRight = int.Parse(ConfigurationManager.AppSettings.Get("ClockBorderRight"));
            m_BorderBottom = int.Parse(ConfigurationManager.AppSettings.Get("ClockBorderBottom"));
               
            this.Move += (s, e) =>
            {
                m_Moving = true;
            };
        }

        private void ShowDateTime(bool start)
        {
            DateTime now = DateTime.Now;

            lblClock.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", now.Hour, now.Minute, now.Second);

            if (start || DateChanged(now))
            {
                lblDate.Text = string.Format("{0:D2}.{1:D2}.{2:D2}", now.Day, now.Month, now.Year);
                m_CurrentDate = now;
            }
        }

        private void ShowCalendar(bool topmost = false)
        {
            CalendarForm calendar = new CalendarForm();
            calendar.SetLocationAndSize(this);
            calendar.TopMost = topmost;

            calendar.Show();

            User32Windows.ShowWindow(this.Handle, User32Windows.SW_RESTORE);
        }

        private bool DateChanged(DateTime now)
        {
            if (m_CurrentDate.Day != now.Day || m_CurrentDate.Month != now.Month || m_CurrentDate.Year != now.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void NowToClipblard()
        {
            var now = DateTime.Now;
            var strDateTime = now.ToLocalTime();

            Clipboard.SetText(strDateTime.ToString("dd.MM.yyyy HH:mm:ss,fff"));
        }

        private Color FromRgbString(string str)
        {
            try
            {
                var colorRGB = str.Split(new string[] { ", ", "; ", ",", ";" }, StringSplitOptions.None);
                var result = Color.FromArgb(int.Parse(colorRGB[0]),
                    int.Parse(colorRGB[1]),
                    int.Parse(colorRGB[2]));

                return result;
            }
            catch (Exception e)
            {
                throw new ArgumentException("str", e);
            }
        }

        #endregion
    }
}
