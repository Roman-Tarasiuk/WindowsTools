namespace WindowsTools
{
    partial class SendCommandToolPropertiesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtToolWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToolHeight = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioTop = new System.Windows.Forms.RadioButton();
            this.radioBottom = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkClipboard = new System.Windows.Forms.CheckBox();
            this.chkSleep = new System.Windows.Forms.CheckBox();
            this.txtSleepTimeout = new System.Windows.Forms.TextBox();
            this.chkRunOnAllWindowsWithSameTitle = new System.Windows.Forms.CheckBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anchor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioLeft);
            this.panel1.Controls.Add(this.radioRight);
            this.panel1.Location = new System.Drawing.Point(6, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 45);
            this.panel1.TabIndex = 2;
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Checked = true;
            this.radioLeft.Location = new System.Drawing.Point(3, 3);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(43, 17);
            this.radioLeft.TabIndex = 3;
            this.radioLeft.TabStop = true;
            this.radioLeft.Text = "Left";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(3, 26);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(50, 17);
            this.radioRight.TabIndex = 4;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "Right";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioTop);
            this.panel2.Controls.Add(this.radioBottom);
            this.panel2.Location = new System.Drawing.Point(149, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 45);
            this.panel2.TabIndex = 5;
            // 
            // radioTop
            // 
            this.radioTop.AutoSize = true;
            this.radioTop.Checked = true;
            this.radioTop.Location = new System.Drawing.Point(3, 3);
            this.radioTop.Name = "radioTop";
            this.radioTop.Size = new System.Drawing.Size(44, 17);
            this.radioTop.TabIndex = 6;
            this.radioTop.TabStop = true;
            this.radioTop.Text = "Top";
            this.radioTop.UseVisualStyleBackColor = true;
            // 
            // radioBottom
            // 
            this.radioBottom.AutoSize = true;
            this.radioBottom.Location = new System.Drawing.Point(3, 26);
            this.radioBottom.Name = "radioBottom";
            this.radioBottom.Size = new System.Drawing.Size(58, 17);
            this.radioBottom.TabIndex = 7;
            this.radioBottom.TabStop = true;
            this.radioBottom.Text = "Bottom";
            this.radioBottom.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Left:";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(59, 88);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(63, 20);
            this.txtLeft.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Top:";
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(59, 114);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(63, 20);
            this.txtTop.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Width:";
            // 
            // txtToolWidth
            // 
            this.txtToolWidth.Location = new System.Drawing.Point(188, 88);
            this.txtToolWidth.Name = "txtToolWidth";
            this.txtToolWidth.Size = new System.Drawing.Size(63, 20);
            this.txtToolWidth.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Height:";
            // 
            // txtToolHeight
            // 
            this.txtToolHeight.Location = new System.Drawing.Point(188, 114);
            this.txtToolHeight.Name = "txtToolHeight";
            this.txtToolHeight.Size = new System.Drawing.Size(63, 20);
            this.txtToolHeight.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Commands:";
            // 
            // txtCommands
            // 
            this.txtCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCommands.Location = new System.Drawing.Point(12, 166);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommands.Size = new System.Drawing.Size(234, 119);
            this.txtCommands.TabIndex = 17;
            this.txtCommands.WordWrap = false;
            // 
            // chkClipboard
            // 
            this.chkClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkClipboard.AutoSize = true;
            this.chkClipboard.Location = new System.Drawing.Point(12, 291);
            this.chkClipboard.Name = "chkClipboard";
            this.chkClipboard.Size = new System.Drawing.Size(70, 17);
            this.chkClipboard.TabIndex = 18;
            this.chkClipboard.Text = "Clipboard";
            this.chkClipboard.UseVisualStyleBackColor = true;
            this.chkClipboard.CheckedChanged += new System.EventHandler(this.chkClipboard_CheckedChanged);
            // 
            // chkSleep
            // 
            this.chkSleep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSleep.AutoSize = true;
            this.chkSleep.Location = new System.Drawing.Point(12, 314);
            this.chkSleep.Name = "chkSleep";
            this.chkSleep.Size = new System.Drawing.Size(110, 17);
            this.chkSleep.TabIndex = 19;
            this.chkSleep.Text = "With timeout (ms):";
            this.chkSleep.UseVisualStyleBackColor = true;
            // 
            // txtSleepTimeout
            // 
            this.txtSleepTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSleepTimeout.Location = new System.Drawing.Point(128, 312);
            this.txtSleepTimeout.Name = "txtSleepTimeout";
            this.txtSleepTimeout.Size = new System.Drawing.Size(100, 20);
            this.txtSleepTimeout.TabIndex = 20;
            // 
            // chkRunOnAllWindowsWithSameTitle
            // 
            this.chkRunOnAllWindowsWithSameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRunOnAllWindowsWithSameTitle.AutoSize = true;
            this.chkRunOnAllWindowsWithSameTitle.Location = new System.Drawing.Point(12, 337);
            this.chkRunOnAllWindowsWithSameTitle.Name = "chkRunOnAllWindowsWithSameTitle";
            this.chkRunOnAllWindowsWithSameTitle.Size = new System.Drawing.Size(187, 17);
            this.chkRunOnAllWindowsWithSameTitle.TabIndex = 21;
            this.chkRunOnAllWindowsWithSameTitle.Text = "Run on all windows with same title";
            this.chkRunOnAllWindowsWithSameTitle.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(171, 370);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SendCommandToolPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 399);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkRunOnAllWindowsWithSameTitle);
            this.Controls.Add(this.txtSleepTimeout);
            this.Controls.Add(this.chkSleep);
            this.Controls.Add(this.chkClipboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtToolHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToolWidth);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SendCommandToolPropertiesForm";
            this.Text = "Tool properties";
            this.Shown += new System.EventHandler(this.SendCommandToolPropertiesForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToolWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToolHeight;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBottom;
        private System.Windows.Forms.RadioButton radioTop;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkClipboard;
        private System.Windows.Forms.CheckBox chkSleep;
        private System.Windows.Forms.TextBox txtSleepTimeout;
        private System.Windows.Forms.CheckBox chkRunOnAllWindowsWithSameTitle;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Label label5;
    }
}