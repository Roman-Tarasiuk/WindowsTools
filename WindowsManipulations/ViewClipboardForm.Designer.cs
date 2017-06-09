namespace WindowsManipulations
{
    partial class ViewClipboardForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClipboardAutodetect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(535, 189);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Audio",
            "File drop list",
            "Image",
            "Text",
            "Data"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnClipboardAutodetect
            // 
            this.btnClipboardAutodetect.Location = new System.Drawing.Point(272, 10);
            this.btnClipboardAutodetect.Name = "btnClipboardAutodetect";
            this.btnClipboardAutodetect.Size = new System.Drawing.Size(75, 23);
            this.btnClipboardAutodetect.TabIndex = 2;
            this.btnClipboardAutodetect.Text = "Autodetect";
            this.btnClipboardAutodetect.UseVisualStyleBackColor = true;
            this.btnClipboardAutodetect.Click += new System.EventHandler(this.btnClipboardAutodetect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewClipboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClipboardAutodetect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ViewClipboardForm";
            this.Text = "View system clipboard";
            this.Shown += new System.EventHandler(this.ViewClipboardForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClipboardAutodetect;
        private System.Windows.Forms.Button button1;
    }
}