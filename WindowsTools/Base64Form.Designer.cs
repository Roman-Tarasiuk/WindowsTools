
namespace WindowsTools
{
    partial class Base64Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInputFileSelect = new System.Windows.Forms.Button();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.radioInputFile = new System.Windows.Forms.RadioButton();
            this.radioInputText = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutputFileSelect = new System.Windows.Forms.Button();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.radioOutputFile = new System.Windows.Forms.RadioButton();
            this.radioOutputText = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEncode);
            this.groupBox1.Controls.Add(this.btnDecode);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.btnInputFileSelect);
            this.groupBox1.Controls.Add(this.txtInputFilePath);
            this.groupBox1.Controls.Add(this.radioInputFile);
            this.groupBox1.Controls.Add(this.radioInputText);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEncode.Location = new System.Drawing.Point(90, 190);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecode.Location = new System.Drawing.Point(9, 190);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(9, 52);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(776, 132);
            this.txtInput.TabIndex = 4;
            // 
            // btnInputFileSelect
            // 
            this.btnInputFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputFileSelect.Location = new System.Drawing.Point(713, 16);
            this.btnInputFileSelect.Name = "btnInputFileSelect";
            this.btnInputFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnInputFileSelect.TabIndex = 3;
            this.btnInputFileSelect.Text = "Open...";
            this.btnInputFileSelect.UseVisualStyleBackColor = true;
            this.btnInputFileSelect.Click += new System.EventHandler(this.btnInputFileSelect_Click);
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputFilePath.Location = new System.Drawing.Point(114, 18);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.Size = new System.Drawing.Size(593, 20);
            this.txtInputFilePath.TabIndex = 2;
            // 
            // radioInputFile
            // 
            this.radioInputFile.AutoSize = true;
            this.radioInputFile.Location = new System.Drawing.Point(67, 19);
            this.radioInputFile.Name = "radioInputFile";
            this.radioInputFile.Size = new System.Drawing.Size(41, 17);
            this.radioInputFile.TabIndex = 1;
            this.radioInputFile.Text = "File";
            this.radioInputFile.UseVisualStyleBackColor = true;
            // 
            // radioInputText
            // 
            this.radioInputText.AutoSize = true;
            this.radioInputText.Checked = true;
            this.radioInputText.Location = new System.Drawing.Point(15, 19);
            this.radioInputText.Name = "radioInputText";
            this.radioInputText.Size = new System.Drawing.Size(46, 17);
            this.radioInputText.TabIndex = 0;
            this.radioInputText.TabStop = true;
            this.radioInputText.Text = "Text";
            this.radioInputText.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Controls.Add(this.btnOutputFileSelect);
            this.groupBox2.Controls.Add(this.txtOutputFilePath);
            this.groupBox2.Controls.Add(this.radioOutputFile);
            this.groupBox2.Controls.Add(this.radioOutputText);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 215);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(9, 52);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(776, 157);
            this.txtOutput.TabIndex = 9;
            // 
            // btnOutputFileSelect
            // 
            this.btnOutputFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputFileSelect.Location = new System.Drawing.Point(713, 16);
            this.btnOutputFileSelect.Name = "btnOutputFileSelect";
            this.btnOutputFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnOutputFileSelect.TabIndex = 8;
            this.btnOutputFileSelect.Text = "Open...";
            this.btnOutputFileSelect.UseVisualStyleBackColor = true;
            this.btnOutputFileSelect.Click += new System.EventHandler(this.btnOutputFileSelect_Click);
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFilePath.Location = new System.Drawing.Point(114, 18);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(593, 20);
            this.txtOutputFilePath.TabIndex = 7;
            // 
            // radioOutputFile
            // 
            this.radioOutputFile.AutoSize = true;
            this.radioOutputFile.Location = new System.Drawing.Point(67, 19);
            this.radioOutputFile.Name = "radioOutputFile";
            this.radioOutputFile.Size = new System.Drawing.Size(41, 17);
            this.radioOutputFile.TabIndex = 6;
            this.radioOutputFile.Text = "File";
            this.radioOutputFile.UseVisualStyleBackColor = true;
            // 
            // radioOutputText
            // 
            this.radioOutputText.AutoSize = true;
            this.radioOutputText.Checked = true;
            this.radioOutputText.Location = new System.Drawing.Point(15, 19);
            this.radioOutputText.Name = "radioOutputText";
            this.radioOutputText.Size = new System.Drawing.Size(46, 17);
            this.radioOutputText.TabIndex = 5;
            this.radioOutputText.TabStop = true;
            this.radioOutputText.Text = "Text";
            this.radioOutputText.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Base64Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Base64Form";
            this.Text = "Base64";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInputFileSelect;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.RadioButton radioInputFile;
        private System.Windows.Forms.RadioButton radioInputText;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutputFileSelect;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.RadioButton radioOutputFile;
        private System.Windows.Forms.RadioButton radioOutputText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}