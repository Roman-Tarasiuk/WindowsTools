namespace WindowsTools
{
    partial class ScreenRulerArrangePanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ScreenRulerArrangePanelForm HandleMove = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenRulerArrangePanelForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.handleMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInTaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handleMoveToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.formBorderToolStripMenuItem,
            this.topmostToolStripMenuItem,
            this.showInTaskbarToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 136);
            //
            // handleMoveToolStripMenuItem
            //
            this.handleMoveToolStripMenuItem.Name = "handleMoveToolStripMenuItem";
            this.handleMoveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.handleMoveToolStripMenuItem.Text = "Handle";
            this.handleMoveToolStripMenuItem.Click += new System.EventHandler(this.handleMoveToolStripMenuItem_Click);
            //
            // backgroundColorToolStripMenuItem
            //
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color...";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            //
            // formBorderToolStripMenuItem
            //
            this.formBorderToolStripMenuItem.Name = "formBorderToolStripMenuItem";
            this.formBorderToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.formBorderToolStripMenuItem.Text = "Form border";
            this.formBorderToolStripMenuItem.Click += new System.EventHandler(this.formBorderToolStripMenuItem_Click);
            //
            // topmostToolStripMenuItem
            //
            this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
            this.topmostToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.topmostToolStripMenuItem.Text = "Topmost";
            this.topmostToolStripMenuItem.Click += new System.EventHandler(this.topmostToolStripMenuItem_Click);
            //
            // showInTaskbarToolStripMenuItem
            //
            this.showInTaskbarToolStripMenuItem.Checked = true;
            this.showInTaskbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showInTaskbarToolStripMenuItem.Name = "showInTaskbarToolStripMenuItem";
            this.showInTaskbarToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showInTaskbarToolStripMenuItem.Text = "Show in taskbar";
            this.showInTaskbarToolStripMenuItem.Click += new System.EventHandler(this.showInTaskbarToolStripMenuItem_Click);
            //
            // closeToolStripMenuItem
            //
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            //
            // ScreenRulerArrangePanelForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenRulerArrangePanelForm_KeyDown);
            this.Name = "ScreenRulerArrangePanelForm";
            this.Text = "Screen ruler arrange";
            this.Shown += new System.EventHandler(this.ScreenRulerArrangePanelForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenRulerHelperForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenRulerHelperForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenRulerHelperForm_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInTaskbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handleMoveToolStripMenuItem;
    }
}