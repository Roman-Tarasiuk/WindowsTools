namespace WindowsManipulations
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxIn = new System.Windows.Forms.RichTextBox();
            this.btnRemoveSpaces = new System.Windows.Forms.Button();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveSpaces);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxIn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxOut);
            this.splitContainer1.Size = new System.Drawing.Size(594, 327);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // richTextBoxIn
            // 
            this.richTextBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxIn.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxIn.Name = "richTextBoxIn";
            this.richTextBoxIn.Size = new System.Drawing.Size(489, 194);
            this.richTextBoxIn.TabIndex = 0;
            this.richTextBoxIn.Text = "";
            // 
            // btnRemoveSpaces
            // 
            this.btnRemoveSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSpaces.Location = new System.Drawing.Point(498, 93);
            this.btnRemoveSpaces.Name = "btnRemoveSpaces";
            this.btnRemoveSpaces.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveSpaces.TabIndex = 1;
            this.btnRemoveSpaces.Text = "Remove spaces";
            this.btnRemoveSpaces.UseVisualStyleBackColor = true;
            this.btnRemoveSpaces.Click += new System.EventHandler(this.btnRemoveSpaces_Click);
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOut.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.Size = new System.Drawing.Size(489, 117);
            this.richTextBoxOut.TabIndex = 0;
            this.richTextBoxOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 327);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Remove All Spaces";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRemoveSpaces;
        private System.Windows.Forms.RichTextBox richTextBoxIn;
        private System.Windows.Forms.RichTextBox richTextBoxOut;
    }
}