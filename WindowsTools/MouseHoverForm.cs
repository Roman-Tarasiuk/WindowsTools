using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using User32Helper;

namespace WindowsTools
{
    public partial class MouseHoverForm : Form
    {
        #region ** Fields

        List<IntPtr> m_TrackedWindows = new List<IntPtr>();

        #endregion


        #region ** Constructors

        public MouseHoverForm()
        {
            InitializeComponent();

            IsTracking = false;
            this.Location = Properties.Settings.Default.WindowsTrackingFormLocation;
        }

        #endregion


        #region ** Event handlers

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProcessWindows();
        }

        private void btnStartTracking_Click(object sender, EventArgs e)
        {
            if (btnStartTracking.Text == "Start tracking")
            {
                StartTracking();
            }
            else
            {
                StopTracking();
            }
        }

        private void WindowsTrackingForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void WindowsTrackingForm_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.WindowsTrackingFormLocation = this.Location;
        }

        private void WindowsTrackingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                Properties.Settings.Default.Save();
            }
        }

        #endregion


        #region ** Helper methods

        private void InitTracking()
        {
            m_TrackedWindows.Clear();
            string[] hwndList = txtHwndList.Text.Split(new string[] { " ", "\r\n", "\n", "\t" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var h in hwndList)
            {
                m_TrackedWindows.Add((IntPtr)int.Parse(h));
            }
        }

        private void ProcessWindows()
        {
            Point p = Cursor.Position;

            foreach (var h in m_TrackedWindows)
            {
                Rectangle r;
                User32Windows.GetWindowRect(h, out r);

                if (p.X >= r.X && p.X <= r.Width
                    && p.Y >= r.Y && p.Y <= r.Height)
                {
                    var hCurrent = User32Windows.GetForegroundWindow();
                    if (hCurrent != h)
                    {
                        User32Windows.SetForegroundWindow(h);
                    }

                    break;
                }
            }
        }

        #endregion


        #region ** Public methods and properties

        public bool IsTracking { get; protected set; }

        public void StartTracking()
        {
            InitTracking();

            if (m_TrackedWindows.Count > 0)
            {
                timer1.Start();
                btnStartTracking.Text = "Stop tracking";
                IsTracking = true;
            }
        }

        public void StopTracking()
        {
            timer1.Stop();
            btnStartTracking.Text = "Start tracking";
            IsTracking = false;
        }

        public void AddToTracking(IntPtr hwnd)
        {
            m_TrackedWindows.Add(hwnd);

            if (txtHwndList.Text == "")
            {
                txtHwndList.Text = hwnd.ToString();
            }
            else
            {
                txtHwndList.Text += "\r\n" + hwnd.ToString();
            }
        }

        #endregion
    }
}
