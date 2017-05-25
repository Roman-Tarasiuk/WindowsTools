namespace WindowsManipulations
{
    partial class SendCommandsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendCommandsForm));
            this.txtHwnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendCommands = new System.Windows.Forms.Button();
            this.chkTopmost = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnToolItem = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setAutohideToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAutohideFromAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHwnd
            // 
            this.txtHwnd.BackColor = System.Drawing.Color.DimGray;
            this.txtHwnd.ForeColor = System.Drawing.Color.White;
            this.txtHwnd.Location = new System.Drawing.Point(107, 1);
            this.txtHwnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHwnd.Name = "txtHwnd";
            this.txtHwnd.Size = new System.Drawing.Size(168, 23);
            this.txtHwnd.TabIndex = 1;
            this.txtHwnd.TextChanged += new System.EventHandler(this.txtHwnd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Window handle:";
            // 
            // txtCommands
            // 
            this.txtCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommands.BackColor = System.Drawing.Color.DimGray;
            this.txtCommands.ForeColor = System.Drawing.Color.White;
            this.txtCommands.Location = new System.Drawing.Point(107, 47);
            this.txtCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommands.Size = new System.Drawing.Size(186, 59);
            this.txtCommands.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(-1, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Commands:";
            // 
            // btnSendCommands
            // 
            this.btnSendCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCommands.BackColor = System.Drawing.Color.DimGray;
            this.btnSendCommands.Location = new System.Drawing.Point(152, 106);
            this.btnSendCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendCommands.Name = "btnSendCommands";
            this.btnSendCommands.Size = new System.Drawing.Size(46, 27);
            this.btnSendCommands.TabIndex = 6;
            this.btnSendCommands.Text = "Send";
            this.btnSendCommands.UseVisualStyleBackColor = false;
            this.btnSendCommands.Click += new System.EventHandler(this.btnSendCommands_Click);
            // 
            // chkTopmost
            // 
            this.chkTopmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTopmost.AutoSize = true;
            this.chkTopmost.BackColor = System.Drawing.Color.DimGray;
            this.chkTopmost.Checked = true;
            this.chkTopmost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopmost.Location = new System.Drawing.Point(2, 111);
            this.chkTopmost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTopmost.Name = "chkTopmost";
            this.chkTopmost.Size = new System.Drawing.Size(75, 19);
            this.chkTopmost.TabIndex = 7;
            this.chkTopmost.Text = "Topmost";
            this.chkTopmost.UseVisualStyleBackColor = false;
            this.chkTopmost.CheckedChanged += new System.EventHandler(this.chkTopmost_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(2, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Window title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.DimGray;
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(107, 24);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(186, 23);
            this.txtTitle.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(2, 82);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnToolItem
            // 
            this.btnToolItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolItem.BackColor = System.Drawing.Color.DimGray;
            this.btnToolItem.Location = new System.Drawing.Point(107, 106);
            this.btnToolItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToolItem.Name = "btnToolItem";
            this.btnToolItem.Size = new System.Drawing.Size(46, 27);
            this.btnToolItem.TabIndex = 9;
            this.btnToolItem.Text = "Tool";
            this.btnToolItem.UseVisualStyleBackColor = false;
            this.btnToolItem.Click += new System.EventHandler(this.btnToolItem_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnMenu.Location = new System.Drawing.Point(208, 106);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(85, 27);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Tools";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAllToolStripMenuItem,
            this.hideAllToolStripMenuItem,
            this.minimizeAllToolStripMenuItem,
            this.restoreAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.setAutohideToAllToolStripMenuItem,
            this.removeAutohideFromAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 142);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // setAutohideToAllToolStripMenuItem
            // 
            this.setAutohideToAllToolStripMenuItem.Name = "setAutohideToAllToolStripMenuItem";
            this.setAutohideToAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.setAutohideToAllToolStripMenuItem.Text = "Set autohide for all";
            this.setAutohideToAllToolStripMenuItem.Click += new System.EventHandler(this.setAutohideToAllToolStripMenuItem_Click);
            // 
            // removeAutohideFromAllToolStripMenuItem
            // 
            this.removeAutohideFromAllToolStripMenuItem.Name = "removeAutohideFromAllToolStripMenuItem";
            this.removeAutohideFromAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.removeAutohideFromAllToolStripMenuItem.Text = "Remove autohide from all";
            this.removeAutohideFromAllToolStripMenuItem.Click += new System.EventHandler(this.removeAutohideFromAllToolStripMenuItem_Click);
            // 
            // SendCommandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(293, 134);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnToolItem);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.chkTopmost);
            this.Controls.Add(this.btnSendCommands);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHwnd);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SendCommandsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Send Commands";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendCommandsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SendCommandsForm_Shown);
            this.LocationChanged += new System.EventHandler(this.SendCommandsForm_LocationChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHwnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendCommands;
        private System.Windows.Forms.CheckBox chkTopmost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnToolItem;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minimizeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAutohideToAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAutohideFromAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem startAllToolStripMenuItem;
    }
}