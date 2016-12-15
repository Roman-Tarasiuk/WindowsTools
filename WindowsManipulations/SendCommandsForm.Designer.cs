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
            this.txtCommands.Location = new System.Drawing.Point(102, 38);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommands.Size = new System.Drawing.Size(275, 69);
            this.txtCommands.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Commands:";
            // 
            // btnSendCommands
            // 
            this.btnSendCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCommands.Location = new System.Drawing.Point(275, 113);
            this.btnSendCommands.Name = "btnSendCommands";
            this.btnSendCommands.Size = new System.Drawing.Size(102, 23);
            this.btnSendCommands.TabIndex = 4;
            this.btnSendCommands.Text = "Send command(s)";
            this.btnSendCommands.UseVisualStyleBackColor = true;
            this.btnSendCommands.Click += new System.EventHandler(this.btnSendCommands_Click);
            // 
            // SendCommandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 148);
            this.Controls.Add(this.btnSendCommands);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHwnd);
            this.Name = "SendCommandsForm";
            this.Text = "SendCommandsForm";
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
    }
}