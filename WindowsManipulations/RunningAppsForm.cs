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
        #region Fields

        List<DesktopWindow> m_RunningWindows = new List<DesktopWindow>();
        private bool m_MouseIsDown = false;
        private int m_DX;
        private int m_DY;
        private bool m_RefreshFull = false;

        #endregion


        #region Constructors

        public RunningAppsForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Constrols' event handlers

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
            var runningWindows = User32Windows.GetDesktopWindows();
            RefreshWindowsLists(runningWindows);

            var backupMenuItems = BackupMenuItems();

            runningAppsContextMenuStrip.Items.Clear();
            var count = 0;

            for (int i = 0; i < m_RunningWindows.Count; i++)
            {
                if (m_RunningWindows[i].IsVisible)
                {
                    var title = m_RunningWindows[i].Title;
                    if (title == "Пуск"
                        || title == "Program Manager"
                        || title == "Windows Shell Experience Host")
                    {
                        m_RunningWindows.RemoveAt(i);
                        i--;
                        continue;
                    }

                    runningAppsContextMenuStrip.Items.Add(title, m_RunningWindows[i].Icon != null
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

            RestoreMenuItems(backupMenuItems);
        }

        private void RunningAppsForm_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void refreshFullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetContextMenu();

            refreshFullToolStripMenuItem.Checked = true;
            refreshToolStripMenuItem.Checked = false;

            m_RefreshFull = true;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetContextMenu();

            refreshFullToolStripMenuItem.Checked = false;
            refreshToolStripMenuItem.Checked = true;

            m_RefreshFull = false;
        }

        #endregion


        #region Helper methods

        private void RefreshWindowsLists(List<DesktopWindow> runningWindows)
        {
            List<IntPtr> hwnds = null;
            List<IntPtr> hwndsParam = null;

            if (!m_RefreshFull)
            {
                hwnds = (from w in m_RunningWindows
                         select w.Handle).ToList();
                hwndsParam = (from w in runningWindows
                              select w.Handle).ToList();
            }

            foreach (var window in runningWindows)
            {
                if (m_RefreshFull)
                {
                    if (m_RunningWindows.Contains(window))
                    {
                        continue;
                    }
                }
                else
                {
                    if (hwnds.Contains(window.Handle))
                    {
                        continue;
                    }
                }

                m_RunningWindows.Add(window);
            }

            for (int i = 0; i < m_RunningWindows.Count; i++)
            {
                var window = m_RunningWindows[i];
                if (m_RefreshFull)
                {
                    if (!runningWindows.Contains(window))
                    {
                        m_RunningWindows.RemoveAt(i);
                        i--;
                    }
                }
                else
                {
                    if (!hwndsParam.Contains(window.Handle))
                    {
                        m_RunningWindows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void ResetContextMenu()
        {
            var backupMenuItems = BackupMenuItems();

            m_RunningWindows.Clear();
            runningAppsContextMenuStrip.Items.Clear();

            RestoreMenuItems(backupMenuItems);
        }

        private List<ToolStripItem> BackupMenuItems()
        {
            List<ToolStripItem> backup = new List<ToolStripItem>();

            var menuItemsCount = runningAppsContextMenuStrip.Items.Count;

            backup.Add(runningAppsContextMenuStrip.Items[menuItemsCount - 4]);
            backup.Add(runningAppsContextMenuStrip.Items[menuItemsCount - 3]);
            backup.Add(runningAppsContextMenuStrip.Items[menuItemsCount - 2]);
            backup.Add(runningAppsContextMenuStrip.Items[menuItemsCount - 1]);

            return backup;
        }

        private void RestoreMenuItems(List<ToolStripItem> items)
        {
            foreach (var i in items)
            {
                runningAppsContextMenuStrip.Items.Add(i);
            }
        }

        #endregion
    }
}
