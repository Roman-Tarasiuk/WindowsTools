﻿using System;
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
        List<DesktopWindow> m_RunningWindows;
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
            m_RunningWindows = User32Windows.GetDesktopWindows();

            var menuItemsCount = runningAppsContextMenuStrip.Items.Count;
            var exitItem = runningAppsContextMenuStrip.Items[menuItemsCount - 1];

            runningAppsContextMenuStrip.Items.Clear();
            var count = 0;

            for(int i = 0; i < m_RunningWindows.Count; i++)
            {
                if (m_RunningWindows[i].IsVisible)
                {
                    runningAppsContextMenuStrip.Items.Add(m_RunningWindows[i].Title, m_RunningWindows[i].Icon != null
                        ? m_RunningWindows[i].Icon.ToBitmap() : null);
                    var countMenu = count;
                    runningAppsContextMenuStrip.Items[count].Click += (senderMenu, eMenu) =>
                        {
                            User32Windows.SetForegroundWindow(m_RunningWindows[countMenu].Handle);
                            User32Windows.ShowWindow(m_RunningWindows[countMenu].Handle, User32Windows.SW_RESTORE);
                        };

                    count++;
                }
            }

            runningAppsContextMenuStrip.Items.Add(new ToolStripSeparator());
            runningAppsContextMenuStrip.Items.Add(exitItem);
        }

        private void RunningAppsForm_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
