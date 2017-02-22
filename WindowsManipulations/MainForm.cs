using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using User32Helper;

namespace WindowsManipulations
{
    public partial class MainForm : Form
    {
        #region Fields

        private List<DesktopWindow> m_ListedWindows = new List<DesktopWindow>();
        private List<DesktopWindow> m_HiddenByUserWindows = new List<DesktopWindow>();
        private string m_HiddenPrefix = "[hidden]";

        private LocationAndSizeForm m_LocationForm = new LocationAndSizeForm();
        private PasswordForm m_PasswordForm = new PasswordForm();
        private WindowsTrackingForm m_TrackingForm = new WindowsTrackingForm();

        private bool m_MouseTrackingStarted = false;
        private bool m_RefreshStarted = false;

        #endregion


        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Controls Events Handlers

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.RefreshWindowsList();
        }

        private void btnRefreshWindowsList_Click(object sender, EventArgs e)
        {
            this.RefreshWindowsList();

            ArrangeMenu();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DoExit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.DoExit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.DoRestoreFormWindow();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DoRestoreFormWindow();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.RefreshWindowsList();
            }
        }

        private void setILDASMFontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetILDASMFonts();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
            mi.Invoke(notifyIcon1, null);
        }

        private void lstWindowsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrangeMenu();
        }

        private void moveWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveWindow();
        }

        private void clearSystemClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void textInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TextInfoForm().Show();
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            if (lstWindowsList.SelectedIndex < 0)
            {
                return;
            }

            var selIndex = lstWindowsList.SelectedIndex;

            if (selIndex >= m_ListedWindows.Count)
            {
                MessageBox.Show("The selected window is already hidden.");
                return;
            }

            var selectedWindow = m_ListedWindows.ElementAt(selIndex);

            m_ListedWindows.RemoveAt(selIndex);
            lstWindowsList.Items.RemoveAt(selIndex);

            m_HiddenByUserWindows.Add(selectedWindow);

            selectedWindow.Title = m_HiddenPrefix + selectedWindow.Title;
            lstWindowsList.Items.Add(String.Format("{0,10} : {1}", selectedWindow.Handle, selectedWindow.Title));

            User32Windows.ShowWindow(selectedWindow.Handle, User32Windows.SW_HIDE);
        }

        private void btnShowHidden_Click(object sender, EventArgs e)
        {
            if (lstWindowsList.SelectedIndex < 0)
            {
                return;
            }

            var selIndex = lstWindowsList.SelectedIndex;

            if (selIndex < m_ListedWindows.Count)
            {
                MessageBox.Show("The selected window is not hidden.");
                return;
            }

            var selectedWindow = m_HiddenByUserWindows.ElementAt(selIndex - m_ListedWindows.Count);

            m_HiddenByUserWindows.RemoveAt(selIndex - m_ListedWindows.Count);
            lstWindowsList.Items.RemoveAt(selIndex);

            selectedWindow.Title = selectedWindow.Title.Substring(m_HiddenPrefix.Length);
            m_ListedWindows.Add(selectedWindow);

            lstWindowsList.Items.Insert(m_ListedWindows.Count - 1, String.Format("{0,10} : {1}", selectedWindow.Handle, selectedWindow.Title));

            User32Windows.ShowWindow(selectedWindow.Handle, User32Windows.SW_SHOW);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_HiddenByUserWindows.Count > 0)
            {
                var result = MessageBox.Show("There are hidden windows.\nAre you sure to exit program?", "Windows Manipulations",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            if (m_PasswordForm != null && !m_PasswordForm.IsDisposed)
            {
                m_PasswordForm.Close();

                if (!m_PasswordForm.IsDisposed)
                {
                    e.Cancel = true;
                }
            }
        }

        private void moveWindowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoveWindow();
        }

        private void removeSpacesFromTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoveSpacesForm().ShowDialog();
        }

        private void passwordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Passwords();
        }

        private void passwordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Passwords();
        }

        private void setCmdTitleFullPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendCommands(new string[] {
                "%title {%}cd{%}%",
                "{ENTER}"
            });
        }

        private void setCmdTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendCommands(new string[] {
                "%for {%}* in {(}.{)} do echo {%}{~}nx* > tmp.tmp & set /P var1=<tmp.tmp%",
                "{ENTER}",
                "%title {%}var1{%} & del tmp.tmp & set \"var1=\"%",
                "{ENTER}"});
        }

        private void setCmdPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendCommands(new string[] {
                "%prompt -$G$S%",
                "{ENTER}",
                "%doskey pwd=echo {^}{%}cd{^}{%}%",
                "{ENTER}" });
        }

        private void sendCustomCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if (selected == -1)
            {
                return;
            }

            new SendCommandsForm(m_ListedWindows[selected].Handle).Show();
        }

        private void copyWindowNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if (selected == -1)
            {
                return;
            }

            Clipboard.SetText(m_ListedWindows[selected].Title);
        }

        private void copyWindowHwndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if (selected == -1)
            {
                return;
            }

            Clipboard.SetText(m_ListedWindows[selected].Handle.ToString());
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if (selected == -1)
            {
                return;
            }

            User32Windows.SendMessage(m_ListedWindows[selected].Handle, User32Windows.WM_CLOSE, 0, null);

            this.RefreshWindowsList();
        }

        private void btnKillWindow_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if (selected == -1)
            {
                return;
            }

            int hwnd;
            User32Windows.GetWindowThreadProcessId(m_ListedWindows[selected].Handle, out hwnd);

            System.Diagnostics.Process installProcess = new System.Diagnostics.Process();
            installProcess.StartInfo.FileName = "taskkill";
            installProcess.StartInfo.Arguments = @"/f /pid " + hwnd.ToString();

            installProcess.Start();
            installProcess.WaitForExit();

            this.RefreshWindowsList();
        }

        // http://stackoverflow.com/questions/9220501/right-click-to-select-items-in-a-listbox

        private void lstWindowsList_MouseDown(object sender, MouseEventArgs e)
        {
            lstWindowsList.SelectedIndex = lstWindowsList.IndexFromPoint(e.X, e.Y);
        }

        private void windowsTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckTrackingForm();

            ShowForm(m_TrackingForm);
        }

        private void contextMenuStripSysTray_Opened(object sender, EventArgs e)
        {
            CheckTrackingForm();

            if (m_MouseTrackingStarted)
            {
                m_TrackingForm.StopTracking();
            }
        }

        private void contextMenuStripSysTray_MouseHover(object sender, EventArgs e)
        {
            if (m_MouseTrackingStarted)
            {
                m_TrackingForm.StopTracking();
            }
        }

        private void contextMenuStripSysTray_MouseLeave(object sender, EventArgs e)
        {
            if (m_MouseTrackingStarted)
            {
                m_TrackingForm.StartTracking();
            }
        }

        private void windowsTrackingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (windowsTrackingToolStripMenuItem1.Text == "Start windows tracking")
            {
                m_TrackingForm.StartTracking();
                windowsTrackingToolStripMenuItem1.Text = "Stop windows tracking";
                m_MouseTrackingStarted = true;
            }
            else
            {
                m_TrackingForm.StopTracking();
                windowsTrackingToolStripMenuItem1.Text = "Start windows tracking";
                m_MouseTrackingStarted = false;
            }
        }

        private void addToTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if (selected == -1)
            {
                return;
            }

            CheckTrackingForm();
            m_TrackingForm.AddToTracking(m_ListedWindows[selected].Handle);
        }

        #endregion


        #region Helper functions

        private void RefreshWindowsList()
        {
            if (m_RefreshStarted)
            {
                return;
            }

            m_RefreshStarted = true;

            var runningWindows = GetWindowList(this.chkVisibleOnly.Checked);

            bool match = WindowsMatch(runningWindows);

            if (!match)
            {
                UpdateWindowsLists(runningWindows);
            }

            m_RefreshStarted = false;
        }

        private bool WindowsMatch(List<DesktopWindow> runningWindows)
        {
            bool match = true;

            if ((m_ListedWindows.Count + m_HiddenByUserWindows.Count) == runningWindows.Count)
            {
                foreach (var w in m_ListedWindows)
                {
                    if (!runningWindows.Contains(w))
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    foreach (var w in m_HiddenByUserWindows)
                    {
                        w.Title = w.Title.Substring(m_HiddenPrefix.Length);
                        if (!runningWindows.Contains(w))
                        {
                            match = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                match = false;
            }

            return match;
        }

        private void UpdateWindowsLists(List<DesktopWindow> runningWindows)
        {
            lstWindowsList.BeginUpdate();

            foreach (var window in runningWindows)
            {
                if (m_ListedWindows.Contains(window))
                {
                    continue;
                }
                else
                {
                    bool titleChanged = false;

                    if (window.Title.StartsWith(m_HiddenPrefix))
                    {
                        window.Title = window.Title.Substring(m_HiddenPrefix.Length);
                        titleChanged = true;
                    }

                    if (m_HiddenByUserWindows.Contains(window))
                    {
                        continue;
                    }
                    else if (titleChanged)
                    {
                        window.Title = m_HiddenPrefix + window.Title;
                    }
                }

                m_ListedWindows.Add(window);
                lstWindowsList.Items.Insert(m_ListedWindows.Count - 1, String.Format("{0,10} : {1}", window.Handle, window.Title));
            }

            for (int i = 0; i < m_ListedWindows.Count; i++)
            {
                var window = m_ListedWindows[i];
                if (!runningWindows.Contains(window))
                {
                    m_ListedWindows.RemoveAt(i);
                    lstWindowsList.Items.RemoveAt(i);
                    i--;
                }
            }

            lstWindowsList.EndUpdate();

            // ** Need to improve - hidden by user windows are not listed in runningWindows
            //
            //for (int i = 0; i < m_HiddenByUserWindows.Count; i++)
            //{
            //    var window = m_ListedWindows[i];
            //    window.Title = window.Title.Substring(m_HiddenPrefix.Length);

            //    if (!runningWindows.Contains(window))
            //    {
            //        window.Title = m_HiddenPrefix + window.Title;
            //        m_HiddenByUserWindows.RemoveAt(i);
            //        lstWindowsList.Items.RemoveAt(m_ListedWindows.Count + i);
            //    }
            //}
        }

        private List<DesktopWindow> GetWindowList(bool visibleOnly)
        {
            var result = new List<DesktopWindow>();

            List<DesktopWindow> RunningWindows = User32Windows.GetDesktopWindows();

            foreach (var window in RunningWindows)
            {
                if ((!visibleOnly) || (visibleOnly && window.IsVisible))
                {
                    result.Add(window);
                }
            }

            return result;
        }

        private void DoExit()
        {
            this.Close();
        }

        private void DoRestoreFormWindow()
        {
            this.Show();
            User32Windows.ShowWindow((IntPtr)this.Handle, User32Windows.SW_RESTORE);
            User32Windows.SetForegroundWindow((IntPtr)this.Handle);
        }

        private void SetILDASMFonts()
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if ((selected == -1) || (!m_ListedWindows[selected].Title.Contains("IL DASM")))
            {
                MessageBox.Show("No IL DASM window selected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!User32Windows.SetForegroundWindow(m_ListedWindows[selected].Handle))
            {
                MessageBox.Show("IL DASM window not found. Try to refresh list.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Thread.Sleep(100);

            SendCommands(new string[] {
                "%V",       // View
                "F",        // Fonts
                "T",        // Tree view
                "Consolas",
                "{TAB}",
                "{TAB}",
                "10",       // Font size
                "{ENTER}",

                "%V",       // View
                "F",        // Fonts
                "D",        // Disassembly
                "Consolas",
                "{TAB}",
                "{TAB}",
                "11",       // Font size
                "{ENTER}"
            });
        }

        private void ArrangeMenu()
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if (selected == -1)
            {
                setILDASMFontsToolStripMenuItem.Enabled = false;
                return;
            }

            if (selected < m_ListedWindows.Count)
            {
                setILDASMFontsToolStripMenuItem.Enabled = m_ListedWindows[selected].Title.Contains("IL DASM");
            }
        }

        private Form CheckFormExists(Form f)
        {
            if (f == null || f.IsDisposed)
            {
                Type t = f.GetType();
                f = (Form)Activator.CreateInstance(t);
            }

            return f;
        }

        private void ShowForm(Form form)
        {
            Console.WriteLine(form.GetType().Name);

            if (!form.Visible)
            {
                form.Show();
                User32Windows.ShowWindow(form.Handle, User32Windows.SW_RESTORE);
                User32Windows.SetForegroundWindow(form.Handle);
            }
        }

        private void MoveWindow()
        {
            int selected = this.lstWindowsList.SelectedIndex;
            if (selected == -1)
            {
                return;
            }

            m_LocationForm = (LocationAndSizeForm)CheckFormExists(m_LocationForm);

            m_LocationForm.SelectWindow(m_ListedWindows[selected].Handle);

            ShowForm(m_LocationForm);

            this.RefreshWindowsList();
        }

        private void Passwords()
        {
            m_PasswordForm = (PasswordForm)CheckFormExists(m_PasswordForm);

            ShowForm(m_PasswordForm);
        }

        private void SendCommands(string[] commands)
        {
            int selected = this.lstWindowsList.SelectedIndex;

            if (selected == -1)
            {
                return;
            }

            if (!User32Windows.SetForegroundWindow(m_ListedWindows[selected].Handle))
            {
                MessageBox.Show("Window not found. Try to refresh list.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Thread.Sleep(200);

            for (int i = 0; i < commands.Length; i++)
            {
                SendKeys.Send(commands[i]);
            }
        }

        private void CheckTrackingForm()
        {
            Form tmp = m_TrackingForm;

            m_TrackingForm = (WindowsTrackingForm)CheckFormExists(m_TrackingForm);

            if (m_TrackingForm != tmp)
            {
                windowsTrackingToolStripMenuItem1.Text = "Start windows tracking";
                m_MouseTrackingStarted = false;

                return;
            }

            if (m_TrackingForm.IsTracking)
            {
                windowsTrackingToolStripMenuItem1.Text = "Stop windows tracking";
                m_MouseTrackingStarted = true;
            }
            else
            {
                windowsTrackingToolStripMenuItem1.Text = "Start windows tracking";
                m_MouseTrackingStarted = false;
            }
        }

        #endregion
    }
}
