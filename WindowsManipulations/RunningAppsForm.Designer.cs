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
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runningAppsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // runningAppsContextMenuStrip
            // 
            this.runningAppsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.runningAppsContextMenuStrip.Name = "runningAppsContextMenuStrip";
            this.runningAppsContextMenuStrip.Size = new System.Drawing.Size(93, 48);
            this.runningAppsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.runningAppsContextMenuStrip_Opening);
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.qToolStripMenuItem.Text = "Q";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}