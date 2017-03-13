namespace WindowsManipulations
{
    partial class RunningAppsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunningAppsForm));
            this.runningAppsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.program1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.program2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runningAppsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // runningAppsContextMenuStrip
            // 
            this.runningAppsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.program1ToolStripMenuItem,
            this.program2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.runningAppsContextMenuStrip.MaximumSize = new System.Drawing.Size(380, 0);
            this.runningAppsContextMenuStrip.Name = "runningAppsContextMenuStrip";
            this.runningAppsContextMenuStrip.Size = new System.Drawing.Size(153, 120);
            this.runningAppsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.runningAppsContextMenuStrip_Opening);
            // 
            // program1ToolStripMenuItem
            // 
            this.program1ToolStripMenuItem.Name = "program1ToolStripMenuItem";
            this.program1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.program1ToolStripMenuItem.Text = "Program 1";
            // 
            // program2ToolStripMenuItem
            // 
            this.program2ToolStripMenuItem.Name = "program2ToolStripMenuItem";
            this.program2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.program2ToolStripMenuItem.Text = "Program 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // RunningAppsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(32, 32);
            this.ContextMenuStrip = this.runningAppsContextMenuStrip;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(32, 32);
            this.MinimumSize = new System.Drawing.Size(32, 32);
            this.Name = "RunningAppsForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RunningAppsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RunningAppsForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RunningAppsForm_MouseUp);
            this.runningAppsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip runningAppsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem program1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem program2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}