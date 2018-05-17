namespace WindowsTools
{
    partial class CropImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropImageForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCropLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCropRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCropTop = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCropBottom = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripBtnEscapeCrop = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPaste,
            this.toolStripBtnCopy,
            this.toolStripBtnCropLeft,
            this.toolStripBtnCropRight,
            this.toolStripBtnCropTop,
            this.toolStripBtnCropBottom,
            this.toolStripBtnEscapeCrop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnPaste
            // 
            this.toolStripBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPaste.Image = global::WindowsTools.Properties.Resources.Editing_Paste_icon;
            this.toolStripBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPaste.Name = "toolStripBtnPaste";
            this.toolStripBtnPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnPaste.Text = "Paste (Ctrl+V)";
            this.toolStripBtnPaste.Click += new System.EventHandler(this.toolStripBtnPaste_Click);
            // 
            // toolStripBtnCopy
            // 
            this.toolStripBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCopy.Image")));
            this.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCopy.Name = "toolStripBtnCopy";
            this.toolStripBtnCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCopy.Text = "Copy (Ctrl+C)";
            this.toolStripBtnCopy.Click += new System.EventHandler(this.toolStripBtnCopy_Click);
            // 
            // toolStripBtnCropLeft
            // 
            this.toolStripBtnCropLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCropLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCropLeft.Image")));
            this.toolStripBtnCropLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCropLeft.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.toolStripBtnCropLeft.Name = "toolStripBtnCropLeft";
            this.toolStripBtnCropLeft.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCropLeft.Text = "Crop left";
            this.toolStripBtnCropLeft.Click += new System.EventHandler(this.toolStripBtnCropLeft_Click);
            // 
            // toolStripBtnCropRight
            // 
            this.toolStripBtnCropRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCropRight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCropRight.Image")));
            this.toolStripBtnCropRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCropRight.Name = "toolStripBtnCropRight";
            this.toolStripBtnCropRight.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCropRight.Text = "Crop right";
            this.toolStripBtnCropRight.Click += new System.EventHandler(this.toolStripBtnCropRight_Click);
            // 
            // toolStripBtnCropTop
            // 
            this.toolStripBtnCropTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCropTop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCropTop.Image")));
            this.toolStripBtnCropTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCropTop.Name = "toolStripBtnCropTop";
            this.toolStripBtnCropTop.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCropTop.Text = "Crop top";
            this.toolStripBtnCropTop.Click += new System.EventHandler(this.toolStripBtnCropTop_Click);
            // 
            // toolStripBtnCropBottom
            // 
            this.toolStripBtnCropBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCropBottom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCropBottom.Image")));
            this.toolStripBtnCropBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCropBottom.Name = "toolStripBtnCropBottom";
            this.toolStripBtnCropBottom.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCropBottom.Text = "Crop bottom";
            this.toolStripBtnCropBottom.Click += new System.EventHandler(this.toolStripBtnCropBottom_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 354);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // toolStripBtnEscapeCrop
            // 
            this.toolStripBtnEscapeCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEscapeCrop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEscapeCrop.Image")));
            this.toolStripBtnEscapeCrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEscapeCrop.Name = "toolStripBtnEscapeCrop";
            this.toolStripBtnEscapeCrop.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnEscapeCrop.Text = "Escape crop (Esc)";
            this.toolStripBtnEscapeCrop.Click += new System.EventHandler(this.toolStripBtnEscapeCrop_Click);
            // 
            // CropImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CropImageForm";
            this.Text = "Crop image";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CropImageForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnCropLeft;
        private System.Windows.Forms.ToolStripButton toolStripBtnPaste;
        private System.Windows.Forms.ToolStripButton toolStripBtnCopy;
        private System.Windows.Forms.ToolStripButton toolStripBtnCropRight;
        private System.Windows.Forms.ToolStripButton toolStripBtnCropTop;
        private System.Windows.Forms.ToolStripButton toolStripBtnCropBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripBtnEscapeCrop;
    }
}