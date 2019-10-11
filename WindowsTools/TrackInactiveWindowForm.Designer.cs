namespace WindowsTools
{
    partial class TrackInactiveWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackInactiveWindowForm));
            this.txtHwnd = new System.Windows.Forms.TextBox();
            this.lblLabelPlusClock = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkTopmost = new System.Windows.Forms.CheckBox();
            this.chkTrackModalWindow = new System.Windows.Forms.CheckBox();
            this.chkWordWrap = new System.Windows.Forms.CheckBox();
            this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnToggleBorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // txtHwnd
            //
            this.txtHwnd.Location = new System.Drawing.Point(56, 3);
            this.txtHwnd.Name = "txtHwnd";
            this.txtHwnd.Size = new System.Drawing.Size(69, 20);
            this.txtHwnd.TabIndex = 0;
            this.txtHwnd.Leave += new System.EventHandler(this.txtHwnd_Leave);
            //
            // lblLabelPlusClock
            //
            this.lblLabelPlusClock.AutoSize = true;
            this.lblLabelPlusClock.Location = new System.Drawing.Point(2, 7);
            this.lblLabelPlusClock.Name = "lblLabelPlusClock";
            this.lblLabelPlusClock.Size = new System.Drawing.Size(38, 13);
            this.lblLabelPlusClock.TabIndex = 1;
            this.lblLabelPlusClock.Text = "Hwnd:";
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitle.Location = new System.Drawing.Point(2, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(16, 15);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "...";
            //
            // btnStartStop
            //
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(325, 1);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            //
            // txtLog
            //
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.Green;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(5, 44);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(394, 64);
            this.txtLog.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtLog, "Double click to toggle options");
            this.txtLog.DoubleClick += new System.EventHandler(this.txtLog_DoubleClick);
            //
            // timer1
            //
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // chkTopmost
            //
            this.chkTopmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTopmost.AutoSize = true;
            this.chkTopmost.Checked = true;
            this.chkTopmost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopmost.Location = new System.Drawing.Point(85, 128);
            this.chkTopmost.Name = "chkTopmost";
            this.chkTopmost.Size = new System.Drawing.Size(67, 17);
            this.chkTopmost.TabIndex = 6;
            this.chkTopmost.Text = "Topmost";
            this.chkTopmost.UseVisualStyleBackColor = true;
            this.chkTopmost.CheckedChanged += new System.EventHandler(this.chkTopmost_CheckedChanged);
            //
            // chkTrackModalWindow
            //
            this.chkTrackModalWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTrackModalWindow.AutoSize = true;
            this.chkTrackModalWindow.Location = new System.Drawing.Point(5, 110);
            this.chkTrackModalWindow.Name = "chkTrackModalWindow";
            this.chkTrackModalWindow.Size = new System.Drawing.Size(124, 17);
            this.chkTrackModalWindow.TabIndex = 6;
            this.chkTrackModalWindow.Text = "Track modal window";
            this.chkTrackModalWindow.UseVisualStyleBackColor = true;
            this.chkTrackModalWindow.CheckedChanged += new System.EventHandler(this.chkTrackModalWindow_CheckedChanged);
            //
            // chkWordWrap
            //
            this.chkWordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkWordWrap.AutoSize = true;
            this.chkWordWrap.Checked = true;
            this.chkWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWordWrap.Location = new System.Drawing.Point(5, 128);
            this.chkWordWrap.Name = "chkWordWrap";
            this.chkWordWrap.Size = new System.Drawing.Size(78, 17);
            this.chkWordWrap.TabIndex = 7;
            this.chkWordWrap.Text = "Word wrap";
            this.chkWordWrap.UseVisualStyleBackColor = true;
            this.chkWordWrap.CheckedChanged += new System.EventHandler(this.chkWordWrap_CheckedChanged);
            //
            // chkShowInTaskbar
            //
            this.chkShowInTaskbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowInTaskbar.AutoSize = true;
            this.chkShowInTaskbar.Checked = true;
            this.chkShowInTaskbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowInTaskbar.Location = new System.Drawing.Point(155, 128);
            this.chkShowInTaskbar.Name = "chkShowInTaskbar";
            this.chkShowInTaskbar.Size = new System.Drawing.Size(73, 17);
            this.chkShowInTaskbar.TabIndex = 8;
            this.chkShowInTaskbar.Text = "In taskbar";
            this.chkShowInTaskbar.UseVisualStyleBackColor = true;
            this.chkShowInTaskbar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            //
            // btnClose
            //
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(380, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // btnToggleBorder
            //
            this.btnToggleBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleBorder.Location = new System.Drawing.Point(361, 23);
            this.btnToggleBorder.Name = "btnToggleBorder";
            this.btnToggleBorder.Size = new System.Drawing.Size(20, 20);
            this.btnToggleBorder.TabIndex = 9;
            this.btnToggleBorder.Text = "∧";
            this.btnToggleBorder.UseVisualStyleBackColor = true;
            this.btnToggleBorder.Click += new System.EventHandler(this.btnToggleBorder_Click);
            //
            // TrackInactiveWindowForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(242)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(403, 146);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnToggleBorder);
            this.Controls.Add(this.chkShowInTaskbar);
            this.Controls.Add(this.chkWordWrap);
            this.Controls.Add(this.chkTopmost);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLabelPlusClock);
            this.Controls.Add(this.txtHwnd);
            this.Controls.Add(this.chkTrackModalWindow);
            this.SizeChanged += new System.EventHandler(this.formSize_Changed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackInactiveWindowForm";
            this.Text = "Track inactive window";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHwnd;
        private System.Windows.Forms.Label lblLabelPlusClock;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkTrackModalWindow;
        private System.Windows.Forms.CheckBox chkTopmost;
        private System.Windows.Forms.CheckBox chkWordWrap;
        private System.Windows.Forms.CheckBox chkShowInTaskbar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnToggleBorder;
    }
}