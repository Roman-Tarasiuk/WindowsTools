namespace WindowsTools
{
    partial class ScreenRulerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenRulerForm));
            this.btnStartStopRuller = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDummuToTemporaryFocusing = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartStopRuller
            // 
            this.btnStartStopRuller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartStopRuller.Location = new System.Drawing.Point(12, 133);
            this.btnStartStopRuller.Name = "btnStartStopRuller";
            this.btnStartStopRuller.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopRuller.TabIndex = 0;
            this.btnStartStopRuller.Text = "Start";
            this.btnStartStopRuller.UseVisualStyleBackColor = true;
            this.btnStartStopRuller.Click += new System.EventHandler(this.btnStartStopRuller_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current mouse coordinates:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start measuring from:";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(154, 6);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 3;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(154, 32);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtCurrent.TabIndex = 4;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(154, 58);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distance:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDummuToTemporaryFocusing
            // 
            this.btnDummuToTemporaryFocusing.Location = new System.Drawing.Point(0, 0);
            this.btnDummuToTemporaryFocusing.Name = "btnDummuToTemporaryFocusing";
            this.btnDummuToTemporaryFocusing.Size = new System.Drawing.Size(1, 1);
            this.btnDummuToTemporaryFocusing.TabIndex = 7;
            this.btnDummuToTemporaryFocusing.Text = "button1";
            this.btnDummuToTemporaryFocusing.UseVisualStyleBackColor = true;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(12, 100);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(204, 13);
            this.lblHelp.TabIndex = 8;
            this.lblHelp.Text = "Press the spacebar to set start/end points";
            this.lblHelp.Visible = false;
            // 
            // btnPanel
            // 
            this.btnPanel.Location = new System.Drawing.Point(183, 133);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(75, 23);
            this.btnPanel.TabIndex = 9;
            this.btnPanel.Text = "Panel...";
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // ScreenRulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 168);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnDummuToTemporaryFocusing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartStopRuller);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ScreenRulerForm";
            this.Text = "Screen ruler";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenRulerForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStopRuller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDummuToTemporaryFocusing;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnPanel;
    }
}