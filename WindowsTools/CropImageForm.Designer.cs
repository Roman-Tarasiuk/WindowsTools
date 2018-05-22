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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropImageForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEraseImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnCropLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCropTop = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCropRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCropBottom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnEscapeCrop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnBackground = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCropLeft = new System.Windows.Forms.Button();
            this.btnCropTop = new System.Windows.Forms.Button();
            this.btnCropBottom = new System.Windows.Forms.Button();
            this.btnCropRight = new System.Windows.Forms.Button();
            this.btnEscapeCrop = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPaste,
            this.toolStripBtnCopy,
            this.toolStripBtnEraseImage,
            this.toolStripSeparator2,
            this.toolStripBtnCropLeft,
            this.toolStripBtnCropTop,
            this.toolStripBtnCropRight,
            this.toolStripBtnCropBottom,
            this.toolStripSeparator1,
            this.toolStripBtnEscapeCrop,
            this.toolStripSeparator3,
            this.toolStripBtnBackground});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetBackgroundColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 26);
            // 
            // resetBackgroundColorToolStripMenuItem
            // 
            this.resetBackgroundColorToolStripMenuItem.Name = "resetBackgroundColorToolStripMenuItem";
            this.resetBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.resetBackgroundColorToolStripMenuItem.Text = "Reset background color";
            this.resetBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.resetBackgroundColorToolStripMenuItem_Click);
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
            // toolStripBtnEraseImage
            // 
            this.toolStripBtnEraseImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEraseImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEraseImage.Image")));
            this.toolStripBtnEraseImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEraseImage.Name = "toolStripBtnEraseImage";
            this.toolStripBtnEraseImage.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnEraseImage.Text = "Erase image (Del)";
            this.toolStripBtnEraseImage.Click += new System.EventHandler(this.toolStripBtnEraseImage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnCropLeft
            // 
            this.toolStripBtnCropLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCropLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCropLeft.Image")));
            this.toolStripBtnCropLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCropLeft.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.toolStripBtnCropLeft.Name = "toolStripBtnCropLeft";
            this.toolStripBtnCropLeft.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCropLeft.Text = "Crop left (1)";
            this.toolStripBtnCropLeft.Click += new System.EventHandler(this.toolStripBtnCropLeft_Click);
            // 
            // toolStripBtnCropTop
            // 
            this.toolStripBtnCropTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCropTop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCropTop.Image")));
            this.toolStripBtnCropTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCropTop.Name = "toolStripBtnCropTop";
            this.toolStripBtnCropTop.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCropTop.Text = "Crop top (2)";
            this.toolStripBtnCropTop.Click += new System.EventHandler(this.toolStripBtnCropTop_Click);
            // 
            // toolStripBtnCropRight
            // 
            this.toolStripBtnCropRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCropRight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCropRight.Image")));
            this.toolStripBtnCropRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCropRight.Name = "toolStripBtnCropRight";
            this.toolStripBtnCropRight.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCropRight.Text = "Crop right (3)";
            this.toolStripBtnCropRight.Click += new System.EventHandler(this.toolStripBtnCropRight_Click);
            // 
            // toolStripBtnCropBottom
            // 
            this.toolStripBtnCropBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCropBottom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCropBottom.Image")));
            this.toolStripBtnCropBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCropBottom.Name = "toolStripBtnCropBottom";
            this.toolStripBtnCropBottom.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCropBottom.Text = "Crop bottom (4)";
            this.toolStripBtnCropBottom.Click += new System.EventHandler(this.toolStripBtnCropBottom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnBackground
            // 
            this.toolStripBtnBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBackground.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBackground.Image")));
            this.toolStripBtnBackground.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBackground.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.toolStripBtnBackground.Name = "toolStripBtnBackground";
            this.toolStripBtnBackground.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBackground.Text = "Select background color";
            this.toolStripBtnBackground.Click += new System.EventHandler(this.toolStripBtnBackground_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(22, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 326);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btnCropLeft
            // 
            this.btnCropLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnCropLeft.Image")));
            this.btnCropLeft.Location = new System.Drawing.Point(-1, 255);
            this.btnCropLeft.Name = "btnCropLeft";
            this.btnCropLeft.Size = new System.Drawing.Size(22, 22);
            this.btnCropLeft.TabIndex = 3;
            this.btnCropLeft.UseVisualStyleBackColor = true;
            this.btnCropLeft.Click += new System.EventHandler(this.btnCropLeft_Click);
            // 
            // btnCropTop
            // 
            this.btnCropTop.Image = ((System.Drawing.Image)(resources.GetObject("btnCropTop.Image")));
            this.btnCropTop.Location = new System.Drawing.Point(230, 25);
            this.btnCropTop.Name = "btnCropTop";
            this.btnCropTop.Size = new System.Drawing.Size(22, 22);
            this.btnCropTop.TabIndex = 4;
            this.btnCropTop.UseVisualStyleBackColor = true;
            this.btnCropTop.Click += new System.EventHandler(this.btnCropTop_Click);
            // 
            // btnCropBottom
            // 
            this.btnCropBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCropBottom.Image = ((System.Drawing.Image)(resources.GetObject("btnCropBottom.Image")));
            this.btnCropBottom.Location = new System.Drawing.Point(420, 373);
            this.btnCropBottom.Name = "btnCropBottom";
            this.btnCropBottom.Size = new System.Drawing.Size(22, 22);
            this.btnCropBottom.TabIndex = 6;
            this.btnCropBottom.UseVisualStyleBackColor = true;
            this.btnCropBottom.Click += new System.EventHandler(this.btnCropBottom_Click);
            // 
            // btnCropRight
            // 
            this.btnCropRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCropRight.Image = ((System.Drawing.Image)(resources.GetObject("btnCropRight.Image")));
            this.btnCropRight.Location = new System.Drawing.Point(651, 142);
            this.btnCropRight.Name = "btnCropRight";
            this.btnCropRight.Size = new System.Drawing.Size(22, 22);
            this.btnCropRight.TabIndex = 5;
            this.btnCropRight.UseVisualStyleBackColor = true;
            this.btnCropRight.Click += new System.EventHandler(this.btnCropRight_Click);
            // 
            // btnEscapeCrop
            // 
            this.btnEscapeCrop.Image = ((System.Drawing.Image)(resources.GetObject("btnEscapeCrop.Image")));
            this.btnEscapeCrop.Location = new System.Drawing.Point(0, 25);
            this.btnEscapeCrop.Name = "btnEscapeCrop";
            this.btnEscapeCrop.Size = new System.Drawing.Size(22, 22);
            this.btnEscapeCrop.TabIndex = 2;
            this.btnEscapeCrop.UseVisualStyleBackColor = true;
            this.btnEscapeCrop.Click += new System.EventHandler(this.btnEscapeCrop_Click);
            // 
            // CropImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(672, 394);
            this.Controls.Add(this.btnEscapeCrop);
            this.Controls.Add(this.btnCropRight);
            this.Controls.Add(this.btnCropBottom);
            this.Controls.Add(this.btnCropTop);
            this.Controls.Add(this.btnCropLeft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CropImageForm";
            this.Text = "Crop image";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CropImageForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton toolStripBtnEraseImage;
        private System.Windows.Forms.Button btnCropLeft;
        private System.Windows.Forms.Button btnCropTop;
        private System.Windows.Forms.Button btnCropBottom;
        private System.Windows.Forms.Button btnCropRight;
        private System.Windows.Forms.Button btnEscapeCrop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBtnBackground;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}