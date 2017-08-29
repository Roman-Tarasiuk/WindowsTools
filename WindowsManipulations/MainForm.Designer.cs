namespace WindowsManipulations
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.moveWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.setILDASMFontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCmdTitleFullPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCmdTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCmdPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendCustomCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.textInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customTitleColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.screensaverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellaneousToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeToToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeUriToToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeUriToExceptSpaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSystemClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.replacernTospaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripWindowsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.copyWindowHwndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyWindowNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyProcessIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshWindowsList = new System.Windows.Forms.Button();
            this.chkVisibleOnly = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripSysTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendCustomCommandsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.setAutohideForAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAutohideFromAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsTrackingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.screenSaverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellaneousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeUriToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeUriToExceptSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSystemClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacernTospaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHideWindow = new System.Windows.Forms.Button();
            this.btnShowHidden = new System.Windows.Forms.Button();
            this.btnKillWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.chkPin = new System.Windows.Forms.CheckBox();
            this.timerWrongPin = new System.Windows.Forms.Timer(this.components);
            this.timerScreenSaver = new System.Windows.Forms.Timer(this.components);
            this.lstWindowsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripWindowsList.SuspendLayout();
            this.contextMenuStripSysTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.menuStrip1_MenuActivate);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShowShortcutKeys = false;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskListToolStripMenuItem,
            this.toolStripSeparator9,
            this.moveWindowToolStripMenuItem,
            this.toolStripSeparator6,
            this.setILDASMFontsToolStripMenuItem,
            this.setCmdTitleFullPathToolStripMenuItem,
            this.setCmdTitleToolStripMenuItem,
            this.setCmdPromptToolStripMenuItem,
            this.sendCustomCommandsToolStripMenuItem,
            this.toolStripSeparator3,
            this.textInfoToolStripMenuItem,
            this.windowsTrackingToolStripMenuItem,
            this.customTitleColorsToolStripMenuItem,
            this.toolStripSeparator5,
            this.screensaverToolStripMenuItem1,
            this.passwordsToolStripMenuItem,
            this.miscellaneousToolStripMenuItem1,
            this.toolStripSeparator7,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShowShortcutKeys = false;
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // taskListToolStripMenuItem
            // 
            this.taskListToolStripMenuItem.Name = "taskListToolStripMenuItem";
            this.taskListToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.taskListToolStripMenuItem.Text = "Task list...";
            this.taskListToolStripMenuItem.Click += new System.EventHandler(this.taskListToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(220, 6);
            // 
            // moveWindowToolStripMenuItem
            // 
            this.moveWindowToolStripMenuItem.Name = "moveWindowToolStripMenuItem";
            this.moveWindowToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.moveWindowToolStripMenuItem.Text = "Move window...";
            this.moveWindowToolStripMenuItem.Click += new System.EventHandler(this.moveWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(220, 6);
            // 
            // setILDASMFontsToolStripMenuItem
            // 
            this.setILDASMFontsToolStripMenuItem.Enabled = false;
            this.setILDASMFontsToolStripMenuItem.Name = "setILDASMFontsToolStripMenuItem";
            this.setILDASMFontsToolStripMenuItem.ShowShortcutKeys = false;
            this.setILDASMFontsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.setILDASMFontsToolStripMenuItem.Text = "Set IL&DASM Fonts";
            this.setILDASMFontsToolStripMenuItem.Click += new System.EventHandler(this.setILDASMFontsToolStripMenuItem_Click);
            // 
            // setCmdTitleFullPathToolStripMenuItem
            // 
            this.setCmdTitleFullPathToolStripMenuItem.Name = "setCmdTitleFullPathToolStripMenuItem";
            this.setCmdTitleFullPathToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.setCmdTitleFullPathToolStripMenuItem.Text = "Set cmd title as full path";
            this.setCmdTitleFullPathToolStripMenuItem.Click += new System.EventHandler(this.setCmdTitleFullPathToolStripMenuItem_Click);
            // 
            // setCmdTitleToolStripMenuItem
            // 
            this.setCmdTitleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.setCmdTitleToolStripMenuItem.Name = "setCmdTitleToolStripMenuItem";
            this.setCmdTitleToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.setCmdTitleToolStripMenuItem.Text = "Set cmd title as current dir";
            this.setCmdTitleToolStripMenuItem.Click += new System.EventHandler(this.setCmdTitleToolStripMenuItem_Click);
            // 
            // setCmdPromptToolStripMenuItem
            // 
            this.setCmdPromptToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.setCmdPromptToolStripMenuItem.Name = "setCmdPromptToolStripMenuItem";
            this.setCmdPromptToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.setCmdPromptToolStripMenuItem.Text = "Set cmd prompt and pwd";
            this.setCmdPromptToolStripMenuItem.Click += new System.EventHandler(this.setCmdPromptToolStripMenuItem_Click);
            // 
            // sendCustomCommandsToolStripMenuItem
            // 
            this.sendCustomCommandsToolStripMenuItem.Name = "sendCustomCommandsToolStripMenuItem";
            this.sendCustomCommandsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.sendCustomCommandsToolStripMenuItem.Text = "Send custom commands...";
            this.sendCustomCommandsToolStripMenuItem.Click += new System.EventHandler(this.sendCustomCommandsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // textInfoToolStripMenuItem
            // 
            this.textInfoToolStripMenuItem.Name = "textInfoToolStripMenuItem";
            this.textInfoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.textInfoToolStripMenuItem.Text = "Text info...";
            this.textInfoToolStripMenuItem.Click += new System.EventHandler(this.textInfoToolStripMenuItem_Click);
            // 
            // windowsTrackingToolStripMenuItem
            // 
            this.windowsTrackingToolStripMenuItem.Name = "windowsTrackingToolStripMenuItem";
            this.windowsTrackingToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.windowsTrackingToolStripMenuItem.Text = "Windows tracking...";
            this.windowsTrackingToolStripMenuItem.Click += new System.EventHandler(this.windowsTrackingToolStripMenuItem_Click);
            // 
            // customTitleColorsToolStripMenuItem
            // 
            this.customTitleColorsToolStripMenuItem.Name = "customTitleColorsToolStripMenuItem";
            this.customTitleColorsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.customTitleColorsToolStripMenuItem.Text = "Custom title colors*";
            this.customTitleColorsToolStripMenuItem.ToolTipText = "@@@@@@@...";
            this.customTitleColorsToolStripMenuItem.Click += new System.EventHandler(this.customTitleColorsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(220, 6);
            // 
            // screensaverToolStripMenuItem1
            // 
            this.screensaverToolStripMenuItem1.Name = "screensaverToolStripMenuItem1";
            this.screensaverToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.screensaverToolStripMenuItem1.Text = "Screen saver";
            this.screensaverToolStripMenuItem1.Click += new System.EventHandler(this.screensaverToolStripMenuItem1_Click);
            // 
            // passwordsToolStripMenuItem
            // 
            this.passwordsToolStripMenuItem.Name = "passwordsToolStripMenuItem";
            this.passwordsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.passwordsToolStripMenuItem.Text = "Password Manager...";
            this.passwordsToolStripMenuItem.Click += new System.EventHandler(this.passwordsToolStripMenuItem_Click);
            // 
            // miscellaneousToolStripMenuItem1
            // 
            this.miscellaneousToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decodeClipboardToolStripMenuItem,
            this.encodeToToolStripMenuItem1,
            this.encodeUriToToolStripMenuItem1,
            this.encodeUriToExceptSpaceToolStripMenuItem1,
            this.viewSystemClipboardToolStripMenuItem1,
            this.replacernTospaceToolStripMenuItem1});
            this.miscellaneousToolStripMenuItem1.Name = "miscellaneousToolStripMenuItem1";
            this.miscellaneousToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.miscellaneousToolStripMenuItem1.Text = "Miscellaneous";
            // 
            // decodeClipboardToolStripMenuItem
            // 
            this.decodeClipboardToolStripMenuItem.Name = "decodeClipboardToolStripMenuItem";
            this.decodeClipboardToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.decodeClipboardToolStripMenuItem.Text = "Decode % clipboard";
            this.decodeClipboardToolStripMenuItem.Click += new System.EventHandler(this.decodeClipboardToolStripMenuItem_Click);
            // 
            // encodeToToolStripMenuItem1
            // 
            this.encodeToToolStripMenuItem1.Name = "encodeToToolStripMenuItem1";
            this.encodeToToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.encodeToToolStripMenuItem1.Text = "Encode data to %";
            this.encodeToToolStripMenuItem1.Click += new System.EventHandler(this.encodeToToolStripMenuItem1_Click);
            // 
            // encodeUriToToolStripMenuItem1
            // 
            this.encodeUriToToolStripMenuItem1.Name = "encodeUriToToolStripMenuItem1";
            this.encodeUriToToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.encodeUriToToolStripMenuItem1.Text = "Encode Uri to %";
            this.encodeUriToToolStripMenuItem1.Click += new System.EventHandler(this.encodeUriToToolStripMenuItem1_Click);
            // 
            // encodeUriToExceptSpaceToolStripMenuItem1
            // 
            this.encodeUriToExceptSpaceToolStripMenuItem1.Name = "encodeUriToExceptSpaceToolStripMenuItem1";
            this.encodeUriToExceptSpaceToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.encodeUriToExceptSpaceToolStripMenuItem1.Text = "Encode Uri to % except spaces";
            this.encodeUriToExceptSpaceToolStripMenuItem1.Click += new System.EventHandler(this.encodeUriToExceptSpaceToolStripMenuItem1_Click);
            // 
            // viewSystemClipboardToolStripMenuItem1
            // 
            this.viewSystemClipboardToolStripMenuItem1.Name = "viewSystemClipboardToolStripMenuItem1";
            this.viewSystemClipboardToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.viewSystemClipboardToolStripMenuItem1.Text = "System clipboard manager...";
            this.viewSystemClipboardToolStripMenuItem1.Click += new System.EventHandler(this.viewSystemClipboardToolStripMenuItem1_Click);
            // 
            // replacernTospaceToolStripMenuItem1
            // 
            this.replacernTospaceToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("replacernTospaceToolStripMenuItem1.Image")));
            this.replacernTospaceToolStripMenuItem1.Name = "replacernTospaceToolStripMenuItem1";
            this.replacernTospaceToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.replacernTospaceToolStripMenuItem1.Text = "Replace \\r\\n to <space>";
            this.replacernTospaceToolStripMenuItem1.Click += new System.EventHandler(this.replacernTospaceToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(220, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShowShortcutKeys = false;
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            // 
            // contextMenuStripWindowsList
            // 
            this.contextMenuStripWindowsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveWindowToolStripMenuItem1,
            this.addToTrackingToolStripMenuItem,
            this.toolStripSeparator8,
            this.copyWindowHwndToolStripMenuItem,
            this.copyWindowNameToolStripMenuItem,
            this.copyProcessIdToolStripMenuItem});
            this.contextMenuStripWindowsList.Name = "contextMenuStripWindowsList";
            this.contextMenuStripWindowsList.Size = new System.Drawing.Size(181, 120);
            // 
            // moveWindowToolStripMenuItem1
            // 
            this.moveWindowToolStripMenuItem1.Name = "moveWindowToolStripMenuItem1";
            this.moveWindowToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.moveWindowToolStripMenuItem1.Text = "Move window...";
            this.moveWindowToolStripMenuItem1.Click += new System.EventHandler(this.moveWindowToolStripMenuItem1_Click);
            // 
            // addToTrackingToolStripMenuItem
            // 
            this.addToTrackingToolStripMenuItem.Name = "addToTrackingToolStripMenuItem";
            this.addToTrackingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToTrackingToolStripMenuItem.Text = "Add to tracking";
            this.addToTrackingToolStripMenuItem.Click += new System.EventHandler(this.addToTrackingToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // copyWindowHwndToolStripMenuItem
            // 
            this.copyWindowHwndToolStripMenuItem.Name = "copyWindowHwndToolStripMenuItem";
            this.copyWindowHwndToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyWindowHwndToolStripMenuItem.Text = "Copy window hwnd";
            this.copyWindowHwndToolStripMenuItem.Click += new System.EventHandler(this.copyWindowHwndToolStripMenuItem_Click);
            // 
            // copyWindowNameToolStripMenuItem
            // 
            this.copyWindowNameToolStripMenuItem.Name = "copyWindowNameToolStripMenuItem";
            this.copyWindowNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyWindowNameToolStripMenuItem.Text = "Copy window name";
            this.copyWindowNameToolStripMenuItem.Click += new System.EventHandler(this.copyWindowNameToolStripMenuItem_Click);
            // 
            // copyProcessIdToolStripMenuItem
            // 
            this.copyProcessIdToolStripMenuItem.Name = "copyProcessIdToolStripMenuItem";
            this.copyProcessIdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyProcessIdToolStripMenuItem.Text = "Copy process Id";
            this.copyProcessIdToolStripMenuItem.Click += new System.EventHandler(this.copyProcessIdToolStripMenuItem_Click);
            // 
            // btnRefreshWindowsList
            // 
            this.btnRefreshWindowsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshWindowsList.Location = new System.Drawing.Point(461, 43);
            this.btnRefreshWindowsList.Name = "btnRefreshWindowsList";
            this.btnRefreshWindowsList.Size = new System.Drawing.Size(88, 23);
            this.btnRefreshWindowsList.TabIndex = 2;
            this.btnRefreshWindowsList.Text = "Refresh";
            this.btnRefreshWindowsList.UseVisualStyleBackColor = true;
            this.btnRefreshWindowsList.Click += new System.EventHandler(this.btnRefreshWindowsList_Click);
            // 
            // chkVisibleOnly
            // 
            this.chkVisibleOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkVisibleOnly.AutoSize = true;
            this.chkVisibleOnly.Checked = true;
            this.chkVisibleOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisibleOnly.Location = new System.Drawing.Point(12, 284);
            this.chkVisibleOnly.Name = "chkVisibleOnly";
            this.chkVisibleOnly.Size = new System.Drawing.Size(78, 17);
            this.chkVisibleOnly.TabIndex = 5;
            this.chkVisibleOnly.Text = "Visible only";
            this.chkVisibleOnly.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripSysTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Windows Manipulations";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStripSysTray
            // 
            this.contextMenuStripSysTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.sendCustomCommandsToolStripMenuItem1,
            this.windowsTrackingToolStripMenuItem1,
            this.toolStripSeparator2,
            this.screenSaverToolStripMenuItem,
            this.passwordsToolStripMenuItem1,
            this.miscellaneousToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem1});
            this.contextMenuStripSysTray.Name = "contextMenuStrip1";
            this.contextMenuStripSysTray.Size = new System.Drawing.Size(216, 170);
            this.contextMenuStripSysTray.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripSysTray_Opening);
            this.contextMenuStripSysTray.Opened += new System.EventHandler(this.contextMenuStripSysTray_Opened);
            this.contextMenuStripSysTray.MouseLeave += new System.EventHandler(this.contextMenuStripSysTray_MouseLeave);
            this.contextMenuStripSysTray.MouseHover += new System.EventHandler(this.contextMenuStripSysTray_MouseHover);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.showToolStripMenuItem.Text = "Windows Manipulations";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // sendCustomCommandsToolStripMenuItem1
            // 
            this.sendCustomCommandsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAllToolStripMenuItem,
            this.hideAllToolStripMenuItem,
            this.minimizeAllToolStripMenuItem,
            this.restoreAllToolStripMenuItem,
            this.toolStripSeparator10,
            this.setAutohideForAllToolStripMenuItem,
            this.removeAutohideFromAllToolStripMenuItem});
            this.sendCustomCommandsToolStripMenuItem1.Name = "sendCustomCommandsToolStripMenuItem1";
            this.sendCustomCommandsToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.sendCustomCommandsToolStripMenuItem1.Text = "Send custom commands...";
            this.sendCustomCommandsToolStripMenuItem1.Click += new System.EventHandler(this.sendCustomCommandsToolStripMenuItem1_Click);
            // 
            // startAllToolStripMenuItem
            // 
            this.startAllToolStripMenuItem.Name = "startAllToolStripMenuItem";
            this.startAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.startAllToolStripMenuItem.Text = "Start all";
            this.startAllToolStripMenuItem.Click += new System.EventHandler(this.startAllToolStripMenuItem_Click);
            // 
            // hideAllToolStripMenuItem
            // 
            this.hideAllToolStripMenuItem.Name = "hideAllToolStripMenuItem";
            this.hideAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.hideAllToolStripMenuItem.Text = "Hide all";
            this.hideAllToolStripMenuItem.Click += new System.EventHandler(this.hideAllToolStripMenuItem_Click);
            // 
            // minimizeAllToolStripMenuItem
            // 
            this.minimizeAllToolStripMenuItem.Name = "minimizeAllToolStripMenuItem";
            this.minimizeAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.minimizeAllToolStripMenuItem.Text = "Minimize all";
            this.minimizeAllToolStripMenuItem.Click += new System.EventHandler(this.minimizeAllToolStripMenuItem_Click);
            // 
            // restoreAllToolStripMenuItem
            // 
            this.restoreAllToolStripMenuItem.Name = "restoreAllToolStripMenuItem";
            this.restoreAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.restoreAllToolStripMenuItem.Text = "Restore all";
            this.restoreAllToolStripMenuItem.Click += new System.EventHandler(this.restoreAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(208, 6);
            // 
            // setAutohideForAllToolStripMenuItem
            // 
            this.setAutohideForAllToolStripMenuItem.Name = "setAutohideForAllToolStripMenuItem";
            this.setAutohideForAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.setAutohideForAllToolStripMenuItem.Text = "Set autohide for all";
            this.setAutohideForAllToolStripMenuItem.Click += new System.EventHandler(this.setAutohideForAllToolStripMenuItem_Click);
            // 
            // removeAutohideFromAllToolStripMenuItem
            // 
            this.removeAutohideFromAllToolStripMenuItem.Name = "removeAutohideFromAllToolStripMenuItem";
            this.removeAutohideFromAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.removeAutohideFromAllToolStripMenuItem.Text = "Remove autohide from all";
            this.removeAutohideFromAllToolStripMenuItem.Click += new System.EventHandler(this.removeAutohideFromAllToolStripMenuItem_Click);
            // 
            // windowsTrackingToolStripMenuItem1
            // 
            this.windowsTrackingToolStripMenuItem1.Name = "windowsTrackingToolStripMenuItem1";
            this.windowsTrackingToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.windowsTrackingToolStripMenuItem1.Text = "Start windows tracking";
            this.windowsTrackingToolStripMenuItem1.ToolTipText = "Press Ctrl + ~ to start/stop";
            this.windowsTrackingToolStripMenuItem1.Click += new System.EventHandler(this.windowsTrackingToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // screenSaverToolStripMenuItem
            // 
            this.screenSaverToolStripMenuItem.Name = "screenSaverToolStripMenuItem";
            this.screenSaverToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.screenSaverToolStripMenuItem.Text = "Screen saver";
            this.screenSaverToolStripMenuItem.Click += new System.EventHandler(this.screenSaverToolStripMenuItem_Click);
            // 
            // passwordsToolStripMenuItem1
            // 
            this.passwordsToolStripMenuItem1.Image = global::WindowsManipulations.Properties.Resources.password;
            this.passwordsToolStripMenuItem1.Name = "passwordsToolStripMenuItem1";
            this.passwordsToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.passwordsToolStripMenuItem1.Text = "Password Manager...";
            this.passwordsToolStripMenuItem1.Click += new System.EventHandler(this.passwordsToolStripMenuItem1_Click);
            // 
            // miscellaneousToolStripMenuItem
            // 
            this.miscellaneousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decodeToolStripMenuItem,
            this.encodeToToolStripMenuItem,
            this.encodeUriToToolStripMenuItem,
            this.encodeUriToExceptSpaceToolStripMenuItem,
            this.replacernTospaceToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewSystemClipboardToolStripMenuItem});
            this.miscellaneousToolStripMenuItem.Image = global::WindowsManipulations.Properties.Resources.miscellaneous_icon1;
            this.miscellaneousToolStripMenuItem.Name = "miscellaneousToolStripMenuItem";
            this.miscellaneousToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.miscellaneousToolStripMenuItem.Text = "Miscellaneous";
            // 
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.decodeToolStripMenuItem.Text = "Decode % clipboard";
            this.decodeToolStripMenuItem.Click += new System.EventHandler(this.decodeToolStripMenuItem_Click);
            // 
            // encodeToToolStripMenuItem
            // 
            this.encodeToToolStripMenuItem.Name = "encodeToToolStripMenuItem";
            this.encodeToToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.encodeToToolStripMenuItem.Text = "Encode data to %";
            this.encodeToToolStripMenuItem.Click += new System.EventHandler(this.encodeToToolStripMenuItem_Click);
            // 
            // encodeUriToToolStripMenuItem
            // 
            this.encodeUriToToolStripMenuItem.Name = "encodeUriToToolStripMenuItem";
            this.encodeUriToToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.encodeUriToToolStripMenuItem.Text = "Encode Uri to %";
            this.encodeUriToToolStripMenuItem.Click += new System.EventHandler(this.encodeUriToToolStripMenuItem_Click);
            // 
            // encodeUriToExceptSpaceToolStripMenuItem
            // 
            this.encodeUriToExceptSpaceToolStripMenuItem.Name = "encodeUriToExceptSpaceToolStripMenuItem";
            this.encodeUriToExceptSpaceToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.encodeUriToExceptSpaceToolStripMenuItem.Text = "Encode Uri to % except spaces";
            this.encodeUriToExceptSpaceToolStripMenuItem.Click += new System.EventHandler(this.encodeUriToExceptSpaceToolStripMenuItem_Click);
            // 
            // viewSystemClipboardToolStripMenuItem
            // 
            this.viewSystemClipboardToolStripMenuItem.Name = "viewSystemClipboardToolStripMenuItem";
            this.viewSystemClipboardToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.viewSystemClipboardToolStripMenuItem.Text = "System clipboard manager...";
            this.viewSystemClipboardToolStripMenuItem.Click += new System.EventHandler(this.viewSystemClipboardToolStripMenuItem_Click);
            // 
            // replacernTospaceToolStripMenuItem
            // 
            this.replacernTospaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("replacernTospaceToolStripMenuItem.Image")));
            this.replacernTospaceToolStripMenuItem.Name = "replacernTospaceToolStripMenuItem";
            this.replacernTospaceToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.replacernTospaceToolStripMenuItem.Text = "Replace \\r\\n to <space>";
            this.replacernTospaceToolStripMenuItem.Click += new System.EventHandler(this.replacernTospaceToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Running windows:";
            // 
            // btnHideWindow
            // 
            this.btnHideWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHideWindow.Location = new System.Drawing.Point(461, 72);
            this.btnHideWindow.Name = "btnHideWindow";
            this.btnHideWindow.Size = new System.Drawing.Size(88, 23);
            this.btnHideWindow.TabIndex = 3;
            this.btnHideWindow.Text = "Hide selected";
            this.btnHideWindow.UseVisualStyleBackColor = true;
            this.btnHideWindow.Click += new System.EventHandler(this.btnHideWindow_Click);
            // 
            // btnShowHidden
            // 
            this.btnShowHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHidden.Location = new System.Drawing.Point(461, 101);
            this.btnShowHidden.Name = "btnShowHidden";
            this.btnShowHidden.Size = new System.Drawing.Size(88, 23);
            this.btnShowHidden.TabIndex = 4;
            this.btnShowHidden.Text = "Show hidden";
            this.btnShowHidden.UseVisualStyleBackColor = true;
            this.btnShowHidden.Click += new System.EventHandler(this.btnShowHidden_Click);
            // 
            // btnKillWindow
            // 
            this.btnKillWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKillWindow.Location = new System.Drawing.Point(461, 183);
            this.btnKillWindow.Name = "btnKillWindow";
            this.btnKillWindow.Size = new System.Drawing.Size(88, 23);
            this.btnKillWindow.TabIndex = 6;
            this.btnKillWindow.Text = "Kill selected";
            this.btnKillWindow.UseVisualStyleBackColor = true;
            this.btnKillWindow.Click += new System.EventHandler(this.btnKillWindow_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.Enabled = false;
            this.btnCloseWindow.Location = new System.Drawing.Point(461, 154);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(88, 23);
            this.btnCloseWindow.TabIndex = 7;
            this.btnCloseWindow.Text = "Close selected";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // chkPin
            // 
            this.chkPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPin.AutoSize = true;
            this.chkPin.Location = new System.Drawing.Point(458, 284);
            this.chkPin.Name = "chkPin";
            this.chkPin.Size = new System.Drawing.Size(91, 17);
            this.chkPin.TabIndex = 8;
            this.chkPin.Text = "Protect by pin";
            this.chkPin.UseVisualStyleBackColor = true;
            this.chkPin.CheckedChanged += new System.EventHandler(this.chkPin_CheckedChanged);
            // 
            // timerWrongPin
            // 
            this.timerWrongPin.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerScreenSaver
            // 
            this.timerScreenSaver.Tick += new System.EventHandler(this.timerScreenSaver_Tick);
            // 
            // lstWindowsList
            // 
            this.lstWindowsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWindowsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstWindowsList.ContextMenuStrip = this.contextMenuStripWindowsList;
            this.lstWindowsList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstWindowsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstWindowsList.HideSelection = false;
            this.lstWindowsList.Location = new System.Drawing.Point(12, 43);
            this.lstWindowsList.MultiSelect = false;
            this.lstWindowsList.Name = "lstWindowsList";
            this.lstWindowsList.Size = new System.Drawing.Size(443, 235);
            this.lstWindowsList.TabIndex = 9;
            this.lstWindowsList.UseCompatibleStateImageBehavior = false;
            this.lstWindowsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 600;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 313);
            this.Controls.Add(this.lstWindowsList);
            this.Controls.Add(this.chkPin);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnKillWindow);
            this.Controls.Add(this.btnShowHidden);
            this.Controls.Add(this.btnHideWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkVisibleOnly);
            this.Controls.Add(this.btnRefreshWindowsList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Windows Manipulations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripWindowsList.ResumeLayout(false);
            this.contextMenuStripSysTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setILDASMFontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button btnRefreshWindowsList;
        private System.Windows.Forms.CheckBox chkVisibleOnly;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSysTray;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem moveWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem textInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnHideWindow;
        private System.Windows.Forms.Button btnShowHidden;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWindowsList;
        private System.Windows.Forms.ToolStripMenuItem moveWindowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem passwordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem setCmdTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCmdPromptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCmdTitleFullPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem sendCustomCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyWindowNameToolStripMenuItem;
        private System.Windows.Forms.Button btnKillWindow;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.ToolStripMenuItem copyWindowHwndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsTrackingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem customTitleColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.CheckBox chkPin;
        private System.Windows.Forms.Timer timerWrongPin;
        private System.Windows.Forms.ToolStripMenuItem sendCustomCommandsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem setAutohideForAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAutohideFromAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenSaverToolStripMenuItem;
        private System.Windows.Forms.Timer timerScreenSaver;
        private System.Windows.Forms.ToolStripMenuItem screensaverToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miscellaneousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscellaneousToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decodeClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeToToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encodeUriToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeUriToToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encodeUriToExceptSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeUriToExceptSpaceToolStripMenuItem1;
        private System.Windows.Forms.ListView lstWindowsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem viewSystemClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSystemClipboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem replacernTospaceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem replacernTospaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyProcessIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}