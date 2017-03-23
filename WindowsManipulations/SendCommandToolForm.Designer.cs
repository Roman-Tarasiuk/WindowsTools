namespace WindowsManipulations
{
    partial class SendCommandToolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendCommandToolForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableSendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableSendingToolStripMenuItem,
            this.selectBackgroundImageToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 98);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // disableSendingToolStripMenuItem
            // 
            this.disableSendingToolStripMenuItem.Name = "disableSendingToolStripMenuItem";
            this.disableSendingToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.disableSendingToolStripMenuItem.Text = "Move tool";
            this.disableSendingToolStripMenuItem.Click += new System.EventHandler(this.disableSendingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // selectBackgroundImageToolStripMenuItem
            // 
            this.selectBackgroundImageToolStripMenuItem.Name = "selectBackgroundImageToolStripMenuItem";
            this.selectBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.selectBackgroundImageToolStripMenuItem.Text = "Select background image....";
            this.selectBackgroundImageToolStripMenuItem.Click += new System.EventHandler(this.selectBackgroundImageToolStripMenuItem_Click);
            // 
            // SendCommandToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsManipulations.Properties.Resources.wrench_flat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(20, 20);
            this.MinimumSize = new System.Drawing.Size(20, 20);
            this.Name = "SendCommandToolForm";
            this.Text = "SendCommandToolForm";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SendCommandToolForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SendCommandToolForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SendCommandToolForm_MouseDown);
            this.MouseLeave += new System.EventHandler(this.SendCommandToolForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SendCommandToolForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SendCommandToolForm_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableSendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundImageToolStripMenuItem;
    }
}