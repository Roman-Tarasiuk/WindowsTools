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

namespace WindowsManipulations
{
    public partial class RunningAppsForm : Form
    {
        private bool m_MouseIsDown = false;
        private int m_DX;
        private int m_DY;

        public RunningAppsForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunningAppsForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_MouseIsDown = true;
            Point p = PointToScreen(e.Location);
            m_DX = this.Location.X - p.X;
            m_DY = this.Location.Y - p.Y;
        }

        private void RunningAppsForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_MouseIsDown = false;
        }

        private void RunningAppsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_MouseIsDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X + m_DX, p.Y + m_DY);
            }
        }

        private void runningAppsContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var windows = User32Windows.GetDesktopWindows();

            var menuItemsCount = runningAppsContextMenuStrip.Items.Count;
            var exitItem = runningAppsContextMenuStrip.Items[menuItemsCount - 1];

            runningAppsContextMenuStrip.Items.Clear();

            for(int i = 0; i < windows.Count; i++)
            {
                if (windows[i].IsVisible)
                {
                    runningAppsContextMenuStrip.Items.Add(windows[i].Title, windows[i].Icon != null ? windows[i].Icon.ToBitmap() : null);
                }
            }

            runningAppsContextMenuStrip.Items.Add(exitItem);
        }
    }
}
