﻿namespace WindowsManipulations
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
            this.removeSpacesFromTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customTitleColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.passwordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstWindowsList = new System.Windows.Forms.ListBox();
            this.contextMenuStripWindowsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.copyWindowHwndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyWindowNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshWindowsList = new System.Windows.Forms.Button();
            this.chkVisibleOnly = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripSysTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsTrackingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearSystemClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.passwordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHideWindow = new System.Windows.Forms.Button();
            this.btnShowHidden = new System.Windows.Forms.Button();
            this.btnKillWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.chkPin = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sendCustomCommandsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.removeSpacesFromTextToolStripMenuItem,
            this.windowsTrackingToolStripMenuItem,
            this.customTitleColorsToolStripMenuItem,
            this.toolStripSeparator5,
            this.passwordsToolStripMenuItem,
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
            this.taskListToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.taskListToolStripMenuItem.Text = "Task list...";
            this.taskListToolStripMenuItem.Click += new System.EventHandler(this.taskListToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(212, 6);
            // 
            // moveWindowToolStripMenuItem
            // 
            this.moveWindowToolStripMenuItem.Name = "moveWindowToolStripMenuItem";
            this.moveWindowToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.moveWindowToolStripMenuItem.Text = "Move window...";
            this.moveWindowToolStripMenuItem.Click += new System.EventHandler(this.moveWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(212, 6);
            // 
            // setILDASMFontsToolStripMenuItem
            // 
            this.setILDASMFontsToolStripMenuItem.Enabled = false;
            this.setILDASMFontsToolStripMenuItem.Name = "setILDASMFontsToolStripMenuItem";
            this.setILDASMFontsToolStripMenuItem.ShowShortcutKeys = false;
            this.setILDASMFontsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.setILDASMFontsToolStripMenuItem.Text = "Set IL&DASM Fonts";
            this.setILDASMFontsToolStripMenuItem.Click += new System.EventHandler(this.setILDASMFontsToolStripMenuItem_Click);
            // 
            // setCmdTitleFullPathToolStripMenuItem
            // 
            this.setCmdTitleFullPathToolStripMenuItem.Name = "setCmdTitleFullPathToolStripMenuItem";
            this.setCmdTitleFullPathToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.setCmdTitleFullPathToolStripMenuItem.Text = "Set cmd title full path";
            this.setCmdTitleFullPathToolStripMenuItem.Click += new System.EventHandler(this.setCmdTitleFullPathToolStripMenuItem_Click);
            // 
            // setCmdTitleToolStripMenuItem
            // 
            this.setCmdTitleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.setCmdTitleToolStripMenuItem.Name = "setCmdTitleToolStripMenuItem";
            this.setCmdTitleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.setCmdTitleToolStripMenuItem.Text = "Set cmd title current dir";
            this.setCmdTitleToolStripMenuItem.Click += new System.EventHandler(this.setCmdTitleToolStripMenuItem_Click);
            // 
            // setCmdPromptToolStripMenuItem
            // 
            this.setCmdPromptToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.setCmdPromptToolStripMenuItem.Name = "setCmdPromptToolStripMenuItem";
            this.setCmdPromptToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.setCmdPromptToolStripMenuItem.Text = "Set cmd prompt";
            this.setCmdPromptToolStripMenuItem.Click += new System.EventHandler(this.setCmdPromptToolStripMenuItem_Click);
            // 
            // sendCustomCommandsToolStripMenuItem
            // 
            this.sendCustomCommandsToolStripMenuItem.Name = "sendCustomCommandsToolStripMenuItem";
            this.sendCustomCommandsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sendCustomCommandsToolStripMenuItem.Text = "Send custom commands...";
            this.sendCustomCommandsToolStripMenuItem.Click += new System.EventHandler(this.sendCustomCommandsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // textInfoToolStripMenuItem
            // 
            this.textInfoToolStripMenuItem.Name = "textInfoToolStripMenuItem";
            this.textInfoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.textInfoToolStripMenuItem.Text = "Text info...";
            this.textInfoToolStripMenuItem.Click += new System.EventHandler(this.textInfoToolStripMenuItem_Click);
            // 
            // removeSpacesFromTextToolStripMenuItem
            // 
            this.removeSpacesFromTextToolStripMenuItem.Name = "removeSpacesFromTextToolStripMenuItem";
            this.removeSpacesFromTextToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.removeSpacesFromTextToolStripMenuItem.Text = "Remove spaces from text...";
            this.removeSpacesFromTextToolStripMenuItem.Click += new System.EventHandler(this.removeSpacesFromTextToolStripMenuItem_Click);
            // 
            // windowsTrackingToolStripMenuItem
            // 
            this.windowsTrackingToolStripMenuItem.Name = "windowsTrackingToolStripMenuItem";
            this.windowsTrackingToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.windowsTrackingToolStripMenuItem.Text = "Windows tracking...";
            this.windowsTrackingToolStripMenuItem.Click += new System.EventHandler(this.windowsTrackingToolStripMenuItem_Click);
            // 
            // customTitleColorsToolStripMenuItem
            // 
            this.customTitleColorsToolStripMenuItem.Name = "customTitleColorsToolStripMenuItem";
            this.customTitleColorsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.customTitleColorsToolStripMenuItem.Text = "Custom title colors*";
            this.customTitleColorsToolStripMenuItem.ToolTipText = "@@@@@@@...";
            this.customTitleColorsToolStripMenuItem.Click += new System.EventHandler(this.customTitleColorsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(212, 6);
            // 
            // passwordsToolStripMenuItem
            // 
            this.passwordsToolStripMenuItem.Name = "passwordsToolStripMenuItem";
            this.passwordsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.passwordsToolStripMenuItem.Text = "Password Manager...";
            this.passwordsToolStripMenuItem.Click += new System.EventHandler(this.passwordsToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(212, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShowShortcutKeys = false;
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            // 
            // lstWindowsList
            // 
            this.lstWindowsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWindowsList.ContextMenuStrip = this.contextMenuStripWindowsList;
            this.lstWindowsList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstWindowsList.FormattingEnabled = true;
            this.lstWindowsList.HorizontalScrollbar = true;
            this.lstWindowsList.IntegralHeight = false;
            this.lstWindowsList.ItemHeight = 15;
            this.lstWindowsList.Location = new System.Drawing.Point(12, 43);
            this.lstWindowsList.Name = "lstWindowsList";
            this.lstWindowsList.Size = new System.Drawing.Size(443, 235);
            this.lstWindowsList.TabIndex = 1;
            this.lstWindowsList.SelectedIndexChanged += new System.EventHandler(this.lstWindowsList_SelectedIndexChanged);
            this.lstWindowsList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstWindowsList_MouseDown);
            // 
            // contextMenuStripWindowsList
            // 
            this.contextMenuStripWindowsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveWindowToolStripMenuItem1,
            this.addToTrackingToolStripMenuItem,
            this.toolStripSeparator8,
            this.copyWindowHwndToolStripMenuItem,
            this.copyWindowNameToolStripMenuItem});
            this.contextMenuStripWindowsList.Name = "contextMenuStripWindowsList";
            this.contextMenuStripWindowsList.Size = new System.Drawing.Size(181, 98);
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
            this.windowsTrackingToolStripMenuItem1,
            this.toolStripSeparator2,
            this.clearSystemClipboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendCustomCommandsToolStripMenuItem1,
            this.passwordsToolStripMenuItem1,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem1});
            this.contextMenuStripSysTray.Name = "contextMenuStrip1";
            this.contextMenuStripSysTray.Size = new System.Drawing.Size(216, 176);
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
            // windowsTrackingToolStripMenuItem1
            // 
            this.windowsTrackingToolStripMenuItem1.Name = "windowsTrackingToolStripMenuItem1";
            this.windowsTrackingToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.windowsTrackingToolStripMenuItem1.Text = "Start windows tracking";
            this.windowsTrackingToolStripMenuItem1.Click += new System.EventHandler(this.windowsTrackingToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // clearSystemClipboardToolStripMenuItem
            // 
            this.clearSystemClipboardToolStripMenuItem.Name = "clearSystemClipboardToolStripMenuItem";
            this.clearSystemClipboardToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.clearSystemClipboardToolStripMenuItem.Text = "Clear system clipboard";
            this.clearSystemClipboardToolStripMenuItem.Click += new System.EventHandler(this.clearSystemClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // passwordsToolStripMenuItem1
            // 
            this.passwordsToolStripMenuItem1.Name = "passwordsToolStripMenuItem1";
            this.passwordsToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.passwordsToolStripMenuItem1.Text = "Password Manager...";
            this.passwordsToolStripMenuItem1.Click += new System.EventHandler(this.passwordsToolStripMenuItem1_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sendCustomCommandsToolStripMenuItem1
            // 
            this.sendCustomCommandsToolStripMenuItem1.Name = "sendCustomCommandsToolStripMenuItem1";
            this.sendCustomCommandsToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.sendCustomCommandsToolStripMenuItem1.Text = "Send custom commands...";
            this.sendCustomCommandsToolStripMenuItem1.Click += new System.EventHandler(this.sendCustomCommandsToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 313);
            this.Controls.Add(this.chkPin);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnKillWindow);
            this.Controls.Add(this.btnShowHidden);
            this.Controls.Add(this.btnHideWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkVisibleOnly);
            this.Controls.Add(this.btnRefreshWindowsList);
            this.Controls.Add(this.lstWindowsList);
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
        private System.Windows.Forms.ListBox lstWindowsList;
        private System.Windows.Forms.Button btnRefreshWindowsList;
        private System.Windows.Forms.CheckBox chkVisibleOnly;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSysTray;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem moveWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSystemClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem textInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnHideWindow;
        private System.Windows.Forms.Button btnShowHidden;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWindowsList;
        private System.Windows.Forms.ToolStripMenuItem moveWindowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeSpacesFromTextToolStripMenuItem;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem sendCustomCommandsToolStripMenuItem1;
    }
}