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
            this.txtHwnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendCommands = new System.Windows.Forms.Button();
            this.chkTopmost = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHwnd
            // 
            this.txtHwnd.Location = new System.Drawing.Point(102, 12);
            this.txtHwnd.Name = "txtHwnd";
            this.txtHwnd.Size = new System.Drawing.Size(144, 20);
            this.txtHwnd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Window handle:";
            // 
            // txtCommands
            // 
            this.txtCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommands.Location = new System.Drawing.Point(102, 64);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommands.Size = new System.Drawing.Size(275, 103);
            this.txtCommands.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Commands:";
            // 
            // btnSendCommands
            // 
            this.btnSendCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCommands.Location = new System.Drawing.Point(275, 173);
            this.btnSendCommands.Name = "btnSendCommands";
            this.btnSendCommands.Size = new System.Drawing.Size(102, 23);
            this.btnSendCommands.TabIndex = 4;
            this.btnSendCommands.Text = "Send command(s)";
            this.btnSendCommands.UseVisualStyleBackColor = true;
            this.btnSendCommands.Click += new System.EventHandler(this.btnSendCommands_Click);
            // 
            // chkTopmost
            // 
            this.chkTopmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTopmost.AutoSize = true;
            this.chkTopmost.Checked = true;
            this.chkTopmost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopmost.Location = new System.Drawing.Point(12, 177);
            this.chkTopmost.Name = "chkTopmost";
            this.chkTopmost.Size = new System.Drawing.Size(67, 17);
            this.chkTopmost.TabIndex = 5;
            this.chkTopmost.Text = "Topmost";
            this.chkTopmost.UseVisualStyleBackColor = true;
            this.chkTopmost.CheckedChanged += new System.EventHandler(this.chkTopmost_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Window title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(102, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(275, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // SendCommandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 208);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.chkTopmost);
            this.Controls.Add(this.btnSendCommands);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHwnd);
            this.Name = "SendCommandsForm";
            this.Text = "Send Commands";
            this.Shown += new System.EventHandler(this.SendCommandsForm_Shown);
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
    }
}