using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using User32Helper;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsTools
{
    public partial class MainForm : Form
    {
        #region Fields

        const int ListColumnWidthDelta = 138;

        private List<DesktopWindow> m_ListedWindows = new List<DesktopWindow>();
        private List<DesktopWindow> m_HiddenByUserWindows = new List<DesktopWindow>();
        private string m_PrefixHidden = "[hidden]";
        private string m_Pin = String.Empty;

        private LocationAndSizeForm m_LocationForm;
        private PasswordForm m_PasswordForm;
        private WindowsTrackingForm m_TrackingForm;
        private PinForm m_PinForm;
        private SendCommandsForm m_SendCommandForm;
        private ClipboardManagerForm m_ClipboardManagerForm;
        private CompareStringsMainForm m_CompareStringsForm;

        private bool m_MouseTrackingStarted = false;
        private bool m_RefreshStarted = false;
        private bool m_NeedRefresh = false;
        private bool m_EnableRestore = true;
        private bool m_RebuldPasswordMenu = false;

        static readonly TimeSpan defaultWrongPassDelay = new TimeSpan(0, 0, 0, 0, 5000);
        private TimeSpan m_PinTimeSpan = MainForm.defaultWrongPassDelay;
        private DateTime m_BlockStartTime;

        private Point m_ScreenSaverRunCursorPosition;

        MyScreenSaverHooker m_Hook;

        #endregion


        #region Properties

        public bool ScreenSaverHooking { get; set; }

        #endregion


        #region Public Methods

        public void Lock()
        {
            User32Windows.LockWorkStation();
            timerScreenSaver.Stop();
            StopLocking();
        }

        #endregion


        #region Constructors

        public MainForm()
        {
            InitializeComponent();

            this.ScreenSaverHooking = false;

            m_Hook = new MyScreenSaverHooker(this);

            lstWindowsList.Columns[0].Width = this.Width - ListColumnWidthDelta;

            User32Windows.RegisterHotKey(this.Handle, 0, User32Windows.MOD_CONTROL, User32Windows.VK_OEM_3);
        }

        #endregion


        #region Overridde Form's Methods

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == User32Windows.WM_HOTKEY)
            {
                WindowsTracking();
            }
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
                m_NeedRefresh = true;
            }
            else if (this.WindowState == FormWindowState.Normal && m_NeedRefresh)
            {
                this.RefreshWindowsList();
                m_NeedRefresh = false;
            }

            lstWindowsList.Columns[0].Width = this.Width - ListColumnWidthDelta;
        }

        private void setILDASMFontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetILDASMFonts();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }

        private void moveWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveWindow();
        }

        private void textInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TextInfoForm().Show();
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            HideSelectedWindow();
        }

        private void btnShowHidden_Click(object sender, EventArgs e)
        {
            ShowHiddenWindow();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // There are hidden windows.
            if (m_HiddenByUserWindows.Count > 0)
            {
                var result = MessageBox.Show("There are hidden windows.\nAre you sure to exit program?", "Windows Manipulations",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

            // There are saved passwords.
            if (m_PasswordForm != null && !m_PasswordForm.IsDisposed)
            {
                User32Windows.ShowForm(m_PasswordForm);

                m_PasswordForm.Close();

                if (!m_PasswordForm.IsDisposed)
                {
                    e.Cancel = true;
                    return;
                }
            }

            User32Windows.CloseForm(m_ClipboardManagerForm);
            User32Windows.CloseForm(m_CompareStringsForm);
            User32Windows.CloseForm(m_LocationForm);
            User32Windows.CloseForm(m_SendCommandForm);
            User32Windows.CloseForm(m_TrackingForm);
        }

        private void moveWindowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoveWindow();
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
            SendCustomCommands();
        }

        private void copyWindowNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

            if (selected == -1)
            {
                return;
            }

            Clipboard.SetText(m_ListedWindows[selected].Title);
        }

        private void copyWindowHwndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

            if (selected == -1)
            {
                return;
            }

            Clipboard.SetText(m_ListedWindows[selected].Handle.ToString());
        }

        private void copyProcessIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

            if (selected == -1)
            {
                return;
            }

            int processId;
            User32Windows.GetWindowThreadProcessId(m_ListedWindows[selected].Handle, out processId);

            Clipboard.SetText(processId.ToString());
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

            if (selected == -1)
            {
                return;
            }

            User32Windows.PostMessage(m_ListedWindows[selected].Handle, User32Windows.WM_CLOSE, 0, 0);

            this.RefreshWindowsList();
        }

        private void btnKillWindow_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

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

        private void windowsTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckTrackingForm();

            User32Windows.ShowForm(m_TrackingForm);
        }

        private void contextMenuStripSysTray_Opened(object sender, EventArgs e)
        {
            CheckTrackingForm();

            if (m_MouseTrackingStarted)
            {
                m_TrackingForm.StopTracking();
            }

            if (ScreenSaverHooking)
            {
                StopLocking();
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
            WindowsTracking();
        }

        private void WindowsTracking()
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
            int selected = this.lstWindowsList.SelectedIndices[0];

            if (selected == -1)
            {
                return;
            }

            CheckTrackingForm();
            m_TrackingForm.AddToTracking(m_ListedWindows[selected].Handle);
        }

        private void customTitleColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int selected = this.lstWindowsList.SelectedIndex;
            //if (selected == -1)
            //{
            //    return;
            //}

            //IntPtr hwnd = m_ListedWindows[selected].Handle;

            //IntPtr hdc = User32Windows.GetWindowDC(hwnd);

            //if ((int)hdc != 0)
            //{
            //    Graphics g = Graphics.FromHdc(hdc);
            //    g.FillRectangle(Brushes.Green, new Rectangle(100, 2, 4800, 23));
            //    g.Flush();
            //    User32Windows.ReleaseDC(hwnd, hdc);
            //}


            //new TitleColoringForm().Show();


            int selected = this.lstWindowsList.SelectedIndices[0];

            if (selected == -1)
            {
                return;
            }

            IntPtr hwnd = m_ListedWindows[selected].Handle;

            string titleStr = User32Windows.GetWindowText(hwnd, 255);

            var titleForm = new CustomWindowTitleForm() { CurrentTitle = titleStr };
            var result = titleForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                User32Windows.SetWindowText(hwnd, titleForm.NewTitle);
            }
        }

        private void taskListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RunningAppsForm().Show();
        }

        private void chkPin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPin.Checked)
            {
                SetPin();
            }
            else
            {
                m_Pin = String.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerWrongPin.Stop();
            m_EnableRestore = true;
        }

        private void sendCustomCommandsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SendCustomCommands();
        }

        private void startAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_SendCommandForm != null)
            {
                m_SendCommandForm.StartAllTools(startAllToolStripMenuItem);
            }
        }

        private void hideAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_SendCommandForm != null)
            {
                m_SendCommandForm.HideAllTools();
            }
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_SendCommandForm != null)
            {
                m_SendCommandForm.MinimizeAllTools();
            }
        }

        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_SendCommandForm != null)
            {
                m_SendCommandForm.RestoreAllTools();
            }
        }

        private void setAutohideForAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_SendCommandForm != null)
            {
                m_SendCommandForm.SetAutohideForAllTools();
            }
        }

        private void removeAutohideFromAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_SendCommandForm != null)
            {
                m_SendCommandForm.RemoveAutohideFromAllTools();
            }
        }

        private void screenSaverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunScreenSaver();
        }

        private void timerScreenSaver_Tick(object sender, EventArgs e)
        {
            TrackMouseOnRunningScreenSaver();
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            ArrangeMenu();
        }

        private void screensaverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RunScreenSaver();
        }

        private void btnSendCustomCommands_Click(object sender, EventArgs e)
        {
            SendCustomCommands();
        }

        private void hideSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideSelectedWindow();
        }

        private void showHiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHiddenWindow();
        }

        private void trackTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

            if (selected != -1)
            {
                new WindowTitleTrackingForm(m_ListedWindows[selected].Handle).Show();
            }
        }

        private void trackWindowIsAccessibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

            IntPtr hwnd = IntPtr.Zero;

            if (selected != -1)
            {
                hwnd = m_ListedWindows[selected].Handle;
            }
            else
            {
                return;
            }

            new TrackInactiveWindowForm() { Hwnd = hwnd }.Show();
        }

        private void contextMenuStripSysTray1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (m_RebuldPasswordMenu)
            {
                var passMenu = passwordsToolStripMenuItem1.DropDownItems;

                if (passMenu.Count == 0 && m_PasswordForm.PasswordsRepresentation.Count > 0)
                {
                    // Only for displaying a ► sign of the Password Menu.
                    passMenu.Add(new ToolStripSeparator());
                }
                else if (m_PasswordForm.PasswordsRepresentation.Count == 0)
                {
                    passMenu.Clear();
                }
            }
        }

        private void passwordsToolStripMenuItem1_DropDownOpening(object sender, EventArgs e)
        {
            BuildPasswordsList();
        }

        // Main menu | Miscellaneous

        private void clearClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void decodeClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecodePercentageClipboard();
        }

        private void encodeToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodeDataPercentageClipboard();
        }

        private void encodeUriToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodeUriPercentageClipboard();
        }

        private void encodeUriToExceptSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodeUriPercentageExceptSpaceClipboard();
        }

        private void replacernTospaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceRNToSpace();
        }

        private void viewSystemClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunClipboardManager();
        }

        private void compareStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunCompareStrings();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunNotes();
        }

        private void currentDateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NowToClipblard();
        }

        private void powerOffDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerOffDisplay();
        }

        private void powerOffDisplayAndLockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerOffDisplayAndLock();
        }

        private void encodeSpacesToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodeSpacesToPercents();
        }

        // System tray context menu | Miscellaneous

        private void clearClipboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void decodeClipboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DecodePercentageClipboard();
        }

        private void encodeToToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EncodeDataPercentageClipboard();
        }

        private void encodeUriToToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EncodeUriPercentageClipboard();
        }

        private void encodeUriToExceptSpaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EncodeUriPercentageExceptSpaceClipboard();
        }

        private void replacernTospaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReplaceRNToSpace();
        }

        private void viewSystemClipboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RunClipboardManager();
        }

        private void compareStringsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RunCompareStrings();
        }

        private void notesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RunNotes();
        }

        private void currentDateAndTimeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NowToClipblard();
        }

        private void powerOffDisplayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PowerOffDisplay();
        }

        private void powerOffDisplayAndLockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PowerOffDisplayAndLock();
        }

        private void encodeSpacesToToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EncodeSpacesToPercents();
        }

        // Menu items other than Miscellaneous set above these last 2 groups.

        #endregion


        #region Helper methods

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
                        w.Title = w.Title.Substring(m_PrefixHidden.Length);
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

                    if (window.Title.StartsWith(m_PrefixHidden))
                    {
                        window.Title = window.Title.Substring(m_PrefixHidden.Length);
                        titleChanged = true;
                    }

                    if (m_HiddenByUserWindows.Contains(window))
                    {
                        continue;
                    }
                    else if (titleChanged)
                    {
                        window.Title = m_PrefixHidden + window.Title;
                    }
                }

                m_ListedWindows.Add(window);

                if (lstWindowsList.SmallImageList == null)
                {
                    lstWindowsList.SmallImageList = new ImageList();
                }
                if (window.Icon != null)
                {
                    lstWindowsList.SmallImageList.Images.Add(window.Handle.ToString(), window.Icon);
                }

                int processId;
                User32Windows.GetWindowThreadProcessId(window.Handle, out processId);

                lstWindowsList.Items.Insert(m_ListedWindows.Count - 1, String.Format("{0,10} : {1,6} : {2}", window.Handle, processId, window.Title), window.Handle.ToString());
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
        }

        private List<DesktopWindow> GetWindowList(bool visibleOnly)
        {
            var result = new List<DesktopWindow>();

            List<DesktopWindow> RunningWindows = User32Windows.GetDesktopWindows(visibleOnly);

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
            if (m_Pin != String.Empty)
            {
                if (!m_EnableRestore)
                {
                    MessageBox.Show("You have inputted wrong pin.\n"
                        + "Wait "
                            + ((int)((m_PinTimeSpan.TotalMilliseconds - (DateTime.Now - m_BlockStartTime).TotalMilliseconds) / 1000)).ToString()
                            + " seconds and try again...",
                        "Incorrect pin",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Hide();
                    return;
                }

                string pin = GetPin("Unlock Windows Manipulations", "Enter pin");

                if (pin == String.Empty)
                {
                    this.Hide();
                    return;
                }

                if (pin != m_Pin)
                {
                    m_PinTimeSpan += MainForm.defaultWrongPassDelay;
                    timerWrongPin.Interval = (int)m_PinTimeSpan.TotalMilliseconds;
                    m_EnableRestore = false;
                    m_BlockStartTime = DateTime.Now;

                    timerWrongPin.Start();

                    MessageBox.Show("You have inputted wrong pin.\n"
                        + "Wait " + (m_PinTimeSpan.TotalMilliseconds / 1000).ToString() + " seconds and try again.",
                        "Incorrect pin",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Hide();
                    return;
                }
                else
                {
                    m_PinTimeSpan = MainForm.defaultWrongPassDelay;
                }
            }

            this.Show();
            User32Windows.ShowWindow((IntPtr)this.Handle, User32Windows.SW_RESTORE);
            User32Windows.SetForegroundWindow((IntPtr)this.Handle);
        }

        private void SetILDASMFonts()
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

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
            int selected = -1;
            if (this.lstWindowsList.SelectedIndices.Count > 0)
            {
                selected = this.lstWindowsList.SelectedIndices[0];
            }

            if (selected == -1)
            {
                setILDASMFontsToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (selected < m_ListedWindows.Count)
                {
                    setILDASMFontsToolStripMenuItem.Enabled = m_ListedWindows[selected].Title.Contains("IL DASM");
                }
            }
        }

        private void MoveWindow()
        {
            int selected = this.lstWindowsList.SelectedIndices[0];
            if (selected == -1)
            {
                return;
            }

            m_LocationForm = (LocationAndSizeForm)User32Windows.GetForm(m_LocationForm, typeof(LocationAndSizeForm));

            m_LocationForm.SelectWindow(m_ListedWindows[selected].Handle);

            User32Windows.ShowForm(m_LocationForm);

            this.RefreshWindowsList();
        }

        private void Passwords()
        {
            var tmp = (PasswordForm)User32Windows.GetForm(m_PasswordForm, typeof(PasswordForm));

            if (m_PasswordForm != tmp)
            {
                m_PasswordForm = tmp;
                m_PasswordForm.PasswordsChanged += (object sender, EventArgs e) =>
                {
                    m_RebuldPasswordMenu = true;
                };
            }

            User32Windows.ShowForm(m_PasswordForm);
        }

        private void SendCommands(string[] commands)
        {
            int selected = this.lstWindowsList.SelectedIndices[0];

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

            m_TrackingForm = (WindowsTrackingForm)User32Windows.GetForm(m_TrackingForm, typeof(WindowsTrackingForm));

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

        private void SetPin()
        {
            string pin1 = GetPin("Windows Manipulations", "Enter pin");

            if (pin1 == "")
            {
                chkPin.Checked = false;
                MessageBox.Show("You did'n specified pin. Password was not saved.");
                return;
            }

            string pin2 = GetPin("Windows Manipulations", "Confirm pin");

            if (pin1 != pin2)
            {
                chkPin.Checked = false;
                MessageBox.Show("Pin and its confirmation do not match.\nPlease try again.");
                return;
            }

            m_Pin = pin1;
        }

        private string GetPin(string pinCaption, string pinPrompt)
        {
            m_PinForm = new PinForm();
            m_PinForm.Text = pinCaption;
            m_PinForm.Prompt = pinPrompt;
            m_PinForm.TopMost = true;

            DialogResult result = m_PinForm.ShowDialog();

            if (result != DialogResult.OK)
            {
                return "";
            }

            return m_PinForm.Pin;
        }

        private void SendCustomCommands()
        {
            var tmp = m_SendCommandForm;

            m_SendCommandForm = (SendCommandsForm)User32Windows.GetForm(m_SendCommandForm, typeof(SendCommandsForm));

            if (tmp != m_SendCommandForm)
            {
                m_SendCommandForm.ToolExit += (o, e) =>
                {
                    notifyIcon1.ShowBalloonTip(1000, String.Empty, "'" + e.Title + "' tool has exited.", ToolTipIcon.None);
                };
            }

            int selected = this.lstWindowsList.SelectedIndices[0];

            if (selected != -1)
            {
                m_SendCommandForm.HostedWindowHwnd = m_ListedWindows[selected].Handle;
            }

            User32Windows.ShowForm(m_SendCommandForm);
        }

        private void RunScreenSaver()
        {
            if (!this.ScreenSaverHooking)
            {
                m_ScreenSaverRunCursorPosition = Cursor.Position;
                timerScreenSaver.Start();

                this.ScreenSaverHooking = true;
                screenSaverToolStripMenuItem.Text = "Stop locking";
                User32Windows.ShowForm(this);

                var ssSettingsPath = Properties.Settings.Default.ScreenSaverPath;
                var path = Path.GetFullPath(Environment.ExpandEnvironmentVariables(ssSettingsPath));
                Process.Start(path);
            }
            else
            {
                StopLocking();
            }
        }

        private void StopLocking()
        {
            screenSaverToolStripMenuItem.Text = "Screen saver";
            this.ScreenSaverHooking = false;
        }

        private void TrackMouseOnRunningScreenSaver()
        {
            var CursorPosition = Cursor.Position;

            if (CursorPosition.X != m_ScreenSaverRunCursorPosition.X
                || CursorPosition.Y != m_ScreenSaverRunCursorPosition.Y)
            {
                Lock();
            }
        }

        private static void DecodePercentageClipboard()
        {
            var clipboardText = Clipboard.GetText();
            var decodedText = System.Uri.UnescapeDataString(clipboardText);
            Clipboard.SetText(decodedText);
        }

        private void EncodeDataPercentageClipboard()
        {
            var clipboardText = Clipboard.GetText();
            var encodedText = System.Uri.EscapeDataString(clipboardText);
            Clipboard.SetText(encodedText);
        }

        private void EncodeUriPercentageClipboard()
        {
            var clipboardText = Clipboard.GetText();
            var encodedText = System.Uri.EscapeUriString(clipboardText);
            Clipboard.SetText(encodedText);
        }

        private void EncodeUriPercentageExceptSpaceClipboard()
        {
            var clipboardText = Clipboard.GetText();
            var encodedText = System.Uri.EscapeUriString(clipboardText);
            Clipboard.SetText(encodedText.Replace("%20", " "));
        }

        private string TrimMenuItem(string text)
        {
            var maxLength = 50;

            return text.Length > maxLength ? text.Substring(0, maxLength - 3) + "..." : text;
        }

        private void BuildPasswordsList()
        {
            if (m_PasswordForm == null || m_PasswordForm.IsDisposed)
            {
                return;
            }

            var passMenu = passwordsToolStripMenuItem1.DropDownItems;

            if (!m_RebuldPasswordMenu)
            {
                SetFirstMenuItem(passMenu);
                return;
            }

            passMenu.Clear();

            var passwordList = m_PasswordForm.PasswordsRepresentation;

            if (passwordList.Count == 0)
            {
                return;
            }

            this.SuspendLayout();

            SetFirstMenuItem(passMenu);

            passMenu.Add(new ToolStripSeparator());

            var count = 2;
            foreach (var p in passwordList)
            {
                var index = count++;

                var menuText = this.TrimMenuItem(p);
                ToolStripMenuItem menuItem = new ToolStripMenuItem(menuText);

                passMenu.Add(menuItem);
                passMenu[index].Click += (sender, e) =>
                {
                    // index - 2 because 0th menu item is used
                    // by "Refresh windows list" item and separator.
                    m_PasswordForm.CopyPasswordToClipboard(index - 2);
                };
            }

            this.ResumeLayout();

            m_RebuldPasswordMenu = false;
        }

        private void SetFirstMenuItem(ToolStripItemCollection passMenu)
        {
            if (m_PasswordForm.PasswordsRepresentation.Count == 0)
            {
                return;
            }

            var lastWindow = User32Windows.GetLastActiveWindow(hwndExcept: this.Handle);
            var maxMenuLength = 40;
            var title = lastWindow.Title.Length >= maxMenuLength
                    ? lastWindow.Title.Substring(0, maxMenuLength - 3) + "..."
                    : lastWindow.Title;

            if (passMenu.Count == 0)
            {
                passMenu.Add(title);
            }
            else
            {
                ((ToolStripMenuItem)passMenu[0]).Text = title;
            }

            ((ToolStripMenuItem)passMenu[0]).Image = lastWindow.Icon?.ToBitmap();
            ((ToolStripMenuItem)passMenu[0]).ForeColor = Color.FromArgb(112, 112, 112);
        }

        private void ReplaceRNToSpace()
        {
            var clipboardStr = Clipboard.GetText();

            if (clipboardStr != null)
            {
                Clipboard.SetText(clipboardStr.Replace("\r\n", " "));
            }
        }

        private void RunClipboardManager()
        {
            m_ClipboardManagerForm = (ClipboardManagerForm)User32Windows.GetForm(m_ClipboardManagerForm, typeof(ClipboardManagerForm));

            User32Windows.ShowForm(m_ClipboardManagerForm);
        }

        private void RunCompareStrings()
        {
            m_CompareStringsForm = (CompareStringsMainForm)User32Windows.GetForm(m_CompareStringsForm, typeof(CompareStringsMainForm));

            User32Windows.ShowForm(m_CompareStringsForm);

        }

        private void RunNotes()
        {
            new NotesForm().Show();
        }

        private static void NowToClipblard()
        {
            var nowUtc = DateTime.UtcNow;
            var now = nowUtc.ToLocalTime();
            var format = "dd.MM.yyyy HH:mm:ss,fff";

            var strDateTime = now.ToString(format)
                + " [UTC " + nowUtc.ToString(format) + "]";

            Clipboard.SetText(strDateTime);
        }

        private void HideSelectedWindow()
        {
            if (lstWindowsList.SelectedIndices.Count < 0)
            {
                return;
            }

            var selIndex = lstWindowsList.SelectedIndices[0];

            if (selIndex >= m_ListedWindows.Count)
            {
                MessageBox.Show("The selected window is already hidden.");
                return;
            }

            var selectedWindow = m_ListedWindows.ElementAt(selIndex);

            m_ListedWindows.RemoveAt(selIndex);
            lstWindowsList.Items.RemoveAt(selIndex);

            m_HiddenByUserWindows.Add(selectedWindow);

            selectedWindow.Title = m_PrefixHidden + selectedWindow.Title;
            lstWindowsList.Items.Add(String.Format("{0,10} : {1}", selectedWindow.Handle, selectedWindow.Title), selectedWindow.Handle.ToString());

            User32Windows.ShowWindow(selectedWindow.Handle, User32Windows.SW_HIDE);
        }

        private void ShowHiddenWindow()
        {
            if (lstWindowsList.SelectedIndices.Count < 0)
            {
                return;
            }

            var selIndex = lstWindowsList.SelectedIndices[0];

            if (selIndex < m_ListedWindows.Count)
            {
                MessageBox.Show("The selected window is not hidden.");
                return;
            }

            var selectedWindow = m_HiddenByUserWindows.ElementAt(selIndex - m_ListedWindows.Count);

            m_HiddenByUserWindows.RemoveAt(selIndex - m_ListedWindows.Count);
            lstWindowsList.Items.RemoveAt(selIndex);

            selectedWindow.Title = selectedWindow.Title.Substring(m_PrefixHidden.Length);
            m_ListedWindows.Add(selectedWindow);

            lstWindowsList.Items.Insert(m_ListedWindows.Count - 1, String.Format("{0,10} : {1}", selectedWindow.Handle, selectedWindow.Title), selectedWindow.Handle.ToString());

            User32Windows.ShowWindow(selectedWindow.Handle, User32Windows.SW_SHOW);
        }

        private void PowerOffDisplay()
        {
            User32Windows.PostMessage(User32Windows.HWND_BROADCAST, User32Windows.WM_SYSCOMMAND, User32Windows.SC_MONITORPOWER, User32Windows.LParamDisplayShutOff);
        }

        private void PowerOffDisplayAndLock()
        {
            User32Windows.PostMessage(User32Windows.HWND_BROADCAST, User32Windows.WM_SYSCOMMAND, User32Windows.SC_MONITORPOWER, User32Windows.LParamDisplayShutOff);
            User32Windows.LockWorkStation();
        }

        private void ShowMenu()
        {
            MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
            mi.Invoke(notifyIcon1, null);
        }

        private void EncodeSpacesToPercents()
        {
            try
            {
                var clipText = Clipboard.GetText();
                Clipboard.SetText(clipText.Replace(" ", "%20"));
            }
            catch { }
        }

        #endregion

        private void directorySizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DirectorySizeForm().Show();
        }
    }

    public class ToolEventArgs : EventArgs
    {
        public string Title { get; set; }
    }
}
