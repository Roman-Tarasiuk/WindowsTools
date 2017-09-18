namespace WindowsManipulations
{
    partial class CompareStringsSettingsForm
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
            this.btnAply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.chkTopmost = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAply
            // 
            this.btnAply.Location = new System.Drawing.Point(93, 106);
            this.btnAply.Name = "btnAply";
            this.btnAply.Size = new System.Drawing.Size(75, 23);
            this.btnAply.TabIndex = 1;
            this.btnAply.Text = "Apply";
            this.btnAply.UseVisualStyleBackColor = true;
            this.btnAply.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(175, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(256, 106);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // chkTopmost
            // 
            this.chkTopmost.AutoSize = true;
            this.chkTopmost.Location = new System.Drawing.Point(12, 12);
            this.chkTopmost.Name = "chkTopmost";
            this.chkTopmost.Size = new System.Drawing.Size(106, 17);
            this.chkTopmost.TabIndex = 4;
            this.chkTopmost.Text = "Topmost window";
            this.chkTopmost.UseVisualStyleBackColor = true;
            this.chkTopmost.CheckedChanged += new System.EventHandler(this.chkTopmost_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 106);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 141);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkTopmost);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Compare Strings Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAply;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox chkTopmost;
        private System.Windows.Forms.Button btnOK;
    }
}