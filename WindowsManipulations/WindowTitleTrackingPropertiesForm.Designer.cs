namespace WindowsManipulations
{
    partial class WindowTitleTrackingPropertiesForm
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
            this.labelSample = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnForeground = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.numBorderWidht = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBorderWidht)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSample
            // 
            this.labelSample.Location = new System.Drawing.Point(12, 9);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(115, 23);
            this.labelSample.TabIndex = 0;
            this.labelSample.Text = "Window Title Sample";
            this.labelSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWidth
            // 
            this.txtWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWidth.Location = new System.Drawing.Point(64, 53);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(82, 20);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHeight.Location = new System.Drawing.Point(64, 75);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(82, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFont.Location = new System.Drawing.Point(176, 51);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(87, 23);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "Font...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackground.Location = new System.Drawing.Point(176, 95);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(87, 23);
            this.btnBackground.TabIndex = 6;
            this.btnBackground.Text = "Background...";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // btnForeground
            // 
            this.btnForeground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForeground.Location = new System.Drawing.Point(176, 73);
            this.btnForeground.Name = "btnForeground";
            this.btnForeground.Size = new System.Drawing.Size(87, 23);
            this.btnForeground.TabIndex = 7;
            this.btnForeground.Text = "Foreground...";
            this.btnForeground.UseVisualStyleBackColor = true;
            this.btnForeground.Click += new System.EventHandler(this.btnForeground_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(297, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Location = new System.Drawing.Point(297, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Refresh, s";
            // 
            // txtInterval
            // 
            this.txtInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInterval.Location = new System.Drawing.Point(64, 97);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(82, 20);
            this.txtInterval.TabIndex = 10;
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorderColor.Location = new System.Drawing.Point(176, 117);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(87, 23);
            this.btnBorderColor.TabIndex = 12;
            this.btnBorderColor.Text = "Border color...";
            this.btnBorderColor.UseVisualStyleBackColor = true;
            this.btnBorderColor.Click += new System.EventHandler(this.btnBorderColor_Click);
            // 
            // numBorderWidht
            // 
            this.numBorderWidht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numBorderWidht.Location = new System.Drawing.Point(64, 120);
            this.numBorderWidht.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBorderWidht.Name = "numBorderWidht";
            this.numBorderWidht.Size = new System.Drawing.Size(82, 20);
            this.numBorderWidht.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Border";
            // 
            // WindowTitleTrackingPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 143);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numBorderWidht);
            this.Controls.Add(this.btnBorderColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnForeground);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.labelSample);
            this.Name = "WindowTitleTrackingPropertiesForm";
            this.Text = "Window title tracking properties";
            this.Shown += new System.EventHandler(this.WindowTitleTrackingPropertiesForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numBorderWidht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSample;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnForeground;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.NumericUpDown numBorderWidht;
        private System.Windows.Forms.Label label4;
    }
}