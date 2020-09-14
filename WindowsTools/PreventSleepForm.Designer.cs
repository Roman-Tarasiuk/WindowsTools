namespace WindowsTools
{
    partial class PreventSleepForm
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
            this.chkES_SYSTEM_REQUIRED = new System.Windows.Forms.CheckBox();
            this.chkES_DISPLAY_REQUIRED = new System.Windows.Forms.CheckBox();
            this.chkES_AWAYMODE_REQUIRED = new System.Windows.Forms.CheckBox();
            this.radioES_CONTINUOUS = new System.Windows.Forms.RadioButton();
            this.radioSleepAfterTime = new System.Windows.Forms.RadioButton();
            this.txtSleepAfterTime = new System.Windows.Forms.TextBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkES_SYSTEM_REQUIRED
            // 
            this.chkES_SYSTEM_REQUIRED.AutoSize = true;
            this.chkES_SYSTEM_REQUIRED.Location = new System.Drawing.Point(12, 12);
            this.chkES_SYSTEM_REQUIRED.Name = "chkES_SYSTEM_REQUIRED";
            this.chkES_SYSTEM_REQUIRED.Size = new System.Drawing.Size(153, 17);
            this.chkES_SYSTEM_REQUIRED.TabIndex = 1;
            this.chkES_SYSTEM_REQUIRED.Text = "ES_SYSTEM_REQUIRED";
            this.chkES_SYSTEM_REQUIRED.UseVisualStyleBackColor = true;
            // 
            // chkES_DISPLAY_REQUIRED
            // 
            this.chkES_DISPLAY_REQUIRED.AutoSize = true;
            this.chkES_DISPLAY_REQUIRED.Location = new System.Drawing.Point(12, 35);
            this.chkES_DISPLAY_REQUIRED.Name = "chkES_DISPLAY_REQUIRED";
            this.chkES_DISPLAY_REQUIRED.Size = new System.Drawing.Size(154, 17);
            this.chkES_DISPLAY_REQUIRED.TabIndex = 2;
            this.chkES_DISPLAY_REQUIRED.Text = "ES_DISPLAY_REQUIRED";
            this.chkES_DISPLAY_REQUIRED.UseVisualStyleBackColor = true;
            // 
            // chkES_AWAYMODE_REQUIRED
            // 
            this.chkES_AWAYMODE_REQUIRED.AutoSize = true;
            this.chkES_AWAYMODE_REQUIRED.Location = new System.Drawing.Point(12, 58);
            this.chkES_AWAYMODE_REQUIRED.Name = "chkES_AWAYMODE_REQUIRED";
            this.chkES_AWAYMODE_REQUIRED.Size = new System.Drawing.Size(173, 17);
            this.chkES_AWAYMODE_REQUIRED.TabIndex = 3;
            this.chkES_AWAYMODE_REQUIRED.Text = "ES_AWAYMODE_REQUIRED";
            this.chkES_AWAYMODE_REQUIRED.UseVisualStyleBackColor = true;
            // 
            // radioES_CONTINUOUS
            // 
            this.radioES_CONTINUOUS.AutoSize = true;
            this.radioES_CONTINUOUS.Checked = true;
            this.radioES_CONTINUOUS.Location = new System.Drawing.Point(12, 81);
            this.radioES_CONTINUOUS.Name = "radioES_CONTINUOUS";
            this.radioES_CONTINUOUS.Size = new System.Drawing.Size(117, 17);
            this.radioES_CONTINUOUS.TabIndex = 4;
            this.radioES_CONTINUOUS.TabStop = true;
            this.radioES_CONTINUOUS.Text = "ES_CONTINUOUS";
            this.radioES_CONTINUOUS.UseVisualStyleBackColor = true;
            this.radioES_CONTINUOUS.CheckedChanged += new System.EventHandler(this.radioES_CONTINUOUS_CheckedChanged);
            // 
            // radioSleepAfterTime
            // 
            this.radioSleepAfterTime.AutoSize = true;
            this.radioSleepAfterTime.Location = new System.Drawing.Point(12, 104);
            this.radioSleepAfterTime.Name = "radioSleepAfterTime";
            this.radioSleepAfterTime.Size = new System.Drawing.Size(87, 17);
            this.radioSleepAfterTime.TabIndex = 5;
            this.radioSleepAfterTime.Text = "During a time";
            this.radioSleepAfterTime.UseVisualStyleBackColor = true;
            // 
            // txtSleepAfterTime
            // 
            this.txtSleepAfterTime.Enabled = false;
            this.txtSleepAfterTime.Location = new System.Drawing.Point(29, 127);
            this.txtSleepAfterTime.Name = "txtSleepAfterTime";
            this.txtSleepAfterTime.Size = new System.Drawing.Size(100, 20);
            this.txtSleepAfterTime.TabIndex = 6;
            this.txtSleepAfterTime.Text = "2:30:00";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(220, 12);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 7;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // PreventSleepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 160);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.txtSleepAfterTime);
            this.Controls.Add(this.radioSleepAfterTime);
            this.Controls.Add(this.radioES_CONTINUOUS);
            this.Controls.Add(this.chkES_AWAYMODE_REQUIRED);
            this.Controls.Add(this.chkES_DISPLAY_REQUIRED);
            this.Controls.Add(this.chkES_SYSTEM_REQUIRED);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PreventSleepForm";
            this.Text = "Prevent Sleep";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreventSleepForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkES_SYSTEM_REQUIRED;
        private System.Windows.Forms.CheckBox chkES_DISPLAY_REQUIRED;
        private System.Windows.Forms.CheckBox chkES_AWAYMODE_REQUIRED;
        private System.Windows.Forms.RadioButton radioES_CONTINUOUS;
        private System.Windows.Forms.RadioButton radioSleepAfterTime;
        private System.Windows.Forms.TextBox txtSleepAfterTime;
        private System.Windows.Forms.Button btnStartStop;
    }
}