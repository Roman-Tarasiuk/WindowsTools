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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkTopmost = new System.Windows.Forms.CheckBox();
            this.chkTrackModalWindow = new System.Windows.Forms.CheckBox();
            this.chkWordWrap = new System.Windows.Forms.CheckBox();
            this.chkShowBorder = new System.Windows.Forms.CheckBox();
            this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            //
            // txtHwnd
            //
            this.txtHwnd.Location = new System.Drawing.Point(41, 2);
            this.txtHwnd.Name = "txtHwnd";
            this.txtHwnd.Size = new System.Drawing.Size(87, 20);
            this.txtHwnd.TabIndex = 0;
            this.txtHwnd.Leave += new System.EventHandler(this.txtHwnd_Leave);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hwnd:";
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitle.Location = new System.Drawing.Point(128, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(4, 19);
            this.lblTitle.TabIndex = 2;
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
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLog.ForeColor = System.Drawing.Color.Green;
            this.txtLog.Location = new System.Drawing.Point(5, 24);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(394, 84);
            this.txtLog.TabIndex = 5;
            this.txtLog.WordWrap = false;
            this.txtLog.DoubleClick += new System.EventHandler(this.txtLog_DoubleClick);
            toolTip1.SetToolTip(this.txtLog, "Double click to toggle options");
            //
            // timer1
            //
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // chkCheckWindowIsRunning
            //
            this.chkTrackModalWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTrackModalWindow.AutoSize = true;
            this.chkTrackModalWindow.Location = new System.Drawing.Point(5, 110);
            this.chkTrackModalWindow.Name = "chkTrackModalWindow";
            this.chkTrackModalWindow.Size = new System.Drawing.Size(67, 17);
            this.chkTrackModalWindow.TabIndex = 6;
            this.chkTrackModalWindow.Text = "Track modal window";
            this.chkTrackModalWindow.UseVisualStyleBackColor = true;
            this.chkTrackModalWindow.CheckedChanged += new System.EventHandler(this.chkTrackModalWindow_CheckedChanged);
            //
            // chkTopmost
            //
            this.chkTopmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTopmost.AutoSize = true;
            this.chkTopmost.Location = new System.Drawing.Point(170, 128);
            this.chkTopmost.Name = "chkTopmost";
            this.chkTopmost.Size = new System.Drawing.Size(67, 17);
            this.chkTopmost.TabIndex = 6;
            this.chkTopmost.Text = "Topmost";
            this.chkTopmost.UseVisualStyleBackColor = true;
            this.chkTopmost.CheckedChanged += new System.EventHandler(this.chkTopmost_CheckedChanged);
            //
            // chkWordWrap
            //
            this.chkWordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkWordWrap.AutoSize = true;
            this.chkWordWrap.Location = new System.Drawing.Point(90, 128);
            this.chkWordWrap.Name = "chkWordWrap";
            this.chkWordWrap.Size = new System.Drawing.Size(78, 17);
            this.chkWordWrap.TabIndex = 7;
            this.chkWordWrap.Text = "Word wrap";
            this.chkWordWrap.UseVisualStyleBackColor = true;
            this.chkWordWrap.CheckedChanged += new System.EventHandler(this.chkWordWrap_CheckedChanged);
            //
            // chkShowBorder
            //
            this.chkShowBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowBorder.AutoSize = true;
            this.chkShowBorder.Location = new System.Drawing.Point(5, 128);
            this.chkShowBorder.Name = "chkShowBorder";
            this.chkShowBorder.Size = new System.Drawing.Size(78, 17);
            this.chkShowBorder.TabIndex = 7;
            this.chkShowBorder.Text = "Show border";
            this.chkShowBorder.UseVisualStyleBackColor = true;
            this.chkShowBorder.Checked = true;
            this.chkShowBorder.CheckedChanged += new System.EventHandler(this.chkShowBorder_CheckedChanged);
            //
            // chkShowInTaskbar
            //
            this.chkShowInTaskbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowInTaskbar.AutoSize = true;
            this.chkShowInTaskbar.Location = new System.Drawing.Point(240, 128);
            this.chkShowInTaskbar.Checked = true;
            this.chkShowInTaskbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowInTaskbar.Name = "chkShowInTaskbar";
            this.chkShowInTaskbar.Size = new System.Drawing.Size(73, 17);
            this.chkShowInTaskbar.TabIndex = 8;
            this.chkShowInTaskbar.Text = "In taskbar";
            this.chkShowInTaskbar.UseVisualStyleBackColor = true;
            this.chkShowInTaskbar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            //
            // TrackInactiveWindowForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(242)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(403, 146);
            this.Controls.Add(this.chkShowInTaskbar);
            this.Controls.Add(this.chkWordWrap);
            this.Controls.Add(this.chkShowBorder);
            this.Controls.Add(this.chkTopmost);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHwnd);
            this.Controls.Add(this.chkTrackModalWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackInactiveWindowForm";
            this.Text = "Track inactive window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHwnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkTrackModalWindow;
        private System.Windows.Forms.CheckBox chkTopmost;
        private System.Windows.Forms.CheckBox chkWordWrap;
        private System.Windows.Forms.CheckBox chkShowBorder;
        private System.Windows.Forms.CheckBox chkShowInTaskbar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}