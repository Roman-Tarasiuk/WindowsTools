namespace WindowsTools
{
    partial class NotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteWithoutFormattingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topmostWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInTaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteWithoutFormattingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topmostWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showInTaskbarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectionFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionBackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteWithoutFormattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pasteWithoutFormattingToolStripMenuItem2,
            this.clearToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem1,
            this.pasteWithoutFormattingToolStripMenuItem1,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // pasteWithoutFormattingToolStripMenuItem1
            // 
            this.pasteWithoutFormattingToolStripMenuItem1.Image = global::WindowsTools.Properties.Resources.Editing_Paste_icon;
            this.pasteWithoutFormattingToolStripMenuItem1.Name = "pasteWithoutFormattingToolStripMenuItem1";
            this.pasteWithoutFormattingToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.pasteWithoutFormattingToolStripMenuItem1.Text = "Paste without formatting";
            this.pasteWithoutFormattingToolStripMenuItem1.Click += new System.EventHandler(this.pasteWithoutFormattingToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBorderToolStripMenuItem,
            this.showMainMenuToolStripMenuItem,
            this.topmostWindowToolStripMenuItem,
            this.showInTaskbarToolStripMenuItem,
            this.toolStripSeparator3,
            this.wordWrapToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showBorderToolStripMenuItem
            // 
            this.showBorderToolStripMenuItem.Checked = true;
            this.showBorderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBorderToolStripMenuItem.Name = "showBorderToolStripMenuItem";
            this.showBorderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showBorderToolStripMenuItem.Text = "Show border";
            this.showBorderToolStripMenuItem.Click += new System.EventHandler(this.showBorderToolStripMenuItem_Click);
            // 
            // showMainMenuToolStripMenuItem
            // 
            this.showMainMenuToolStripMenuItem.Checked = true;
            this.showMainMenuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMainMenuToolStripMenuItem.Name = "showMainMenuToolStripMenuItem";
            this.showMainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showMainMenuToolStripMenuItem.Text = "Show main menu";
            this.showMainMenuToolStripMenuItem.Click += new System.EventHandler(this.showMainMenuToolStripMenuItem_Click);
            // 
            // topmostWindowToolStripMenuItem
            // 
            this.topmostWindowToolStripMenuItem.Checked = true;
            this.topmostWindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topmostWindowToolStripMenuItem.Name = "topmostWindowToolStripMenuItem";
            this.topmostWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.topmostWindowToolStripMenuItem.Text = "Topmost window";
            this.topmostWindowToolStripMenuItem.Click += new System.EventHandler(this.topmostWindowToolStripMenuItem_Click);
            // 
            // showInTaskbarToolStripMenuItem
            // 
            this.showInTaskbarToolStripMenuItem.Name = "showInTaskbarToolStripMenuItem";
            this.showInTaskbarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showInTaskbarToolStripMenuItem.Text = "Show in taskbar";
            this.showInTaskbarToolStripMenuItem.Click += new System.EventHandler(this.showInTaskbarToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordWrapToolStripMenuItem.Text = "Word wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // pasteWithoutFormattingToolStripMenuItem2
            // 
            this.pasteWithoutFormattingToolStripMenuItem2.Image = global::WindowsTools.Properties.Resources.Editing_Paste_icon;
            this.pasteWithoutFormattingToolStripMenuItem2.Name = "pasteWithoutFormattingToolStripMenuItem2";
            this.pasteWithoutFormattingToolStripMenuItem2.Size = new System.Drawing.Size(28, 20);
            this.pasteWithoutFormattingToolStripMenuItem2.ToolTipText = "Paste without formatting";
            this.pasteWithoutFormattingToolStripMenuItem2.Click += new System.EventHandler(this.pasteWithoutFormattingToolStripMenuItem2_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Image = global::WindowsTools.Properties.Resources.clear;
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.clearToolStripMenuItem1.ToolTipText = "Clear all";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 138);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideBorderToolStripMenuItem,
            this.hideMainMenuToolStripMenuItem,
            this.topmostWindowToolStripMenuItem1,
            this.showInTaskbarToolStripMenuItem1,
            this.toolStripSeparator1,
            this.selectionFontToolStripMenuItem,
            this.selectionColorToolStripMenuItem,
            this.selectionBackColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.toolStripSeparator2,
            this.pasteToolStripMenuItem,
            this.pasteWithoutFormattingToolStripMenuItem,
            this.clearToolStripMenuItem2,
            this.toolStripSeparator4,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 286);
            // 
            // hideBorderToolStripMenuItem
            // 
            this.hideBorderToolStripMenuItem.Checked = true;
            this.hideBorderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideBorderToolStripMenuItem.Name = "hideBorderToolStripMenuItem";
            this.hideBorderToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.hideBorderToolStripMenuItem.Text = "Show border";
            this.hideBorderToolStripMenuItem.Click += new System.EventHandler(this.hideBorderToolStripMenuItem_Click);
            // 
            // hideMainMenuToolStripMenuItem
            // 
            this.hideMainMenuToolStripMenuItem.Checked = true;
            this.hideMainMenuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideMainMenuToolStripMenuItem.Name = "hideMainMenuToolStripMenuItem";
            this.hideMainMenuToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.hideMainMenuToolStripMenuItem.Text = "Show main menu";
            this.hideMainMenuToolStripMenuItem.Click += new System.EventHandler(this.hideMainMenuToolStripMenuItem_Click);
            // 
            // topmostWindowToolStripMenuItem1
            // 
            this.topmostWindowToolStripMenuItem1.Checked = true;
            this.topmostWindowToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topmostWindowToolStripMenuItem1.Name = "topmostWindowToolStripMenuItem1";
            this.topmostWindowToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.topmostWindowToolStripMenuItem1.Text = "Topmost window";
            this.topmostWindowToolStripMenuItem1.Click += new System.EventHandler(this.topmostWindowToolStripMenuItem1_Click);
            // 
            // showInTaskbarToolStripMenuItem1
            // 
            this.showInTaskbarToolStripMenuItem1.Name = "showInTaskbarToolStripMenuItem1";
            this.showInTaskbarToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.showInTaskbarToolStripMenuItem1.Text = "Show in itaskbar";
            this.showInTaskbarToolStripMenuItem1.Click += new System.EventHandler(this.showInTaskbarToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // selectionFontToolStripMenuItem
            // 
            this.selectionFontToolStripMenuItem.Name = "selectionFontToolStripMenuItem";
            this.selectionFontToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.selectionFontToolStripMenuItem.Text = "Selection font...";
            this.selectionFontToolStripMenuItem.Click += new System.EventHandler(this.selectionFontToolStripMenuItem_Click);
            // 
            // selectionColorToolStripMenuItem
            // 
            this.selectionColorToolStripMenuItem.Name = "selectionColorToolStripMenuItem";
            this.selectionColorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.selectionColorToolStripMenuItem.Text = "Selection color...";
            this.selectionColorToolStripMenuItem.Click += new System.EventHandler(this.selectionColorToolStripMenuItem_Click);
            // 
            // selectionBackColorToolStripMenuItem
            // 
            this.selectionBackColorToolStripMenuItem.Name = "selectionBackColorToolStripMenuItem";
            this.selectionBackColorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.selectionBackColorToolStripMenuItem.Text = "Selection background color...";
            this.selectionBackColorToolStripMenuItem.Click += new System.EventHandler(this.selectionBackColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color...";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moveToolStripMenuItem.Image")));
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // pasteWithoutFormattingToolStripMenuItem
            // 
            this.pasteWithoutFormattingToolStripMenuItem.Image = global::WindowsTools.Properties.Resources.Editing_Paste_icon;
            this.pasteWithoutFormattingToolStripMenuItem.Name = "pasteWithoutFormattingToolStripMenuItem";
            this.pasteWithoutFormattingToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pasteWithoutFormattingToolStripMenuItem.Text = "Paste without formatting";
            this.pasteWithoutFormattingToolStripMenuItem.Click += new System.EventHandler(this.pasteWithoutFormattingToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem2
            // 
            this.clearToolStripMenuItem2.Name = "clearToolStripMenuItem2";
            this.clearToolStripMenuItem2.Size = new System.Drawing.Size(206, 22);
            this.clearToolStripMenuItem2.Text = "Clear";
            this.clearToolStripMenuItem2.Click += new System.EventHandler(this.clearToolStripMenuItem2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 164);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotesForm";
            this.ShowInTaskbar = false;
            this.Text = "Notes";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topmostWindowToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteWithoutFormattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteWithoutFormattingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteWithoutFormattingToolStripMenuItem2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem hideMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectionFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionBackColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem hideBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showInTaskbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem topmostWindowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showInTaskbarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}