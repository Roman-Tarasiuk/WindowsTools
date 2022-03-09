
namespace WindowsTools
{
    partial class FileInfoForm
    {
////        /// <summary>
////        /// Required designer variable.
////        /// </summary>
////        private System.ComponentModel.IContainer components = null;
////
////        /// <summary>
////        /// Clean up any resources being used.
////        /// </summary>
////        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
////        protected override void Dispose(bool disposing)
////        {
////            if (disposing && (components != null))
////            {
////                components.Dispose();
////            }
////            base.Dispose(disposing);
////        }
////
////        #region Windows Form Designer generated code
////
////        /// <summary>
////        /// Required method for Designer support - do not modify
////        /// the contents of this method with the code editor.
////        /// </summary>
////        private void InitializeComponent()
////        {
////            this.SuspendLayout();
////            // 
////            // FileInfoForm
////            // 
////            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
////            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
////            this.ClientSize = new System.Drawing.Size(494, 251);
////            this.Name = "FileInfoForm";
////            this.Text = "FileInfoForm";
////            this.ResumeLayout(false);
////
////        }
////
////        #endregion
///

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
            this.radioDirectory = new System.Windows.Forms.RadioButton();
            this.radioFilesList = new System.Windows.Forms.RadioButton();
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathOutput = new System.Windows.Forms.TextBox();
            this.btnOpenPathOutput = new System.Windows.Forms.Button();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.chkMD5 = new System.Windows.Forms.CheckBox();
            this.chkSHA256 = new System.Windows.Forms.CheckBox();
            this.chkCreationTime = new System.Windows.Forms.CheckBox();
            this.chkLastAccessTime = new System.Windows.Forms.CheckBox();
            this.chkLastWriteTime = new System.Windows.Forms.CheckBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // radioDirectory
            // 
            this.radioDirectory.AutoSize = true;
            this.radioDirectory.Checked = true;
            this.radioDirectory.Location = new System.Drawing.Point(145, 5);
            this.radioDirectory.Name = "radioDirectory";
            this.radioDirectory.Size = new System.Drawing.Size(67, 17);
            this.radioDirectory.TabIndex = 4;
            this.radioDirectory.TabStop = true;
            this.radioDirectory.Text = "Directory";
            this.radioDirectory.UseVisualStyleBackColor = true;
            // 
            // radioFilesList
            // 
            this.radioFilesList.AutoSize = true;
            this.radioFilesList.Location = new System.Drawing.Point(275, 5);
            this.radioFilesList.Name = "radioFilesList";
            this.radioFilesList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioFilesList.Size = new System.Drawing.Size(71, 17);
            this.radioFilesList.TabIndex = 6;
            this.radioFilesList.Text = "Files list";
            this.radioFilesList.UseVisualStyleBackColor = true;
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Location = new System.Drawing.Point(218, 5);
            this.radioFile.Name = "radioFile";
            this.radioFile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioFile.Size = new System.Drawing.Size(51, 17);
            this.radioFile.TabIndex = 5;
            this.radioFile.Text = "File";
            this.radioFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory / File(s):";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(12, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(448, 20);
            this.txtPath.TabIndex = 7;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPath.Location = new System.Drawing.Point(466, 23);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(32, 23);
            this.btnOpenPath.TabIndex = 8;
            this.btnOpenPath.Text = "...";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result:";
            // 
            // txtPathOutput
            // 
            this.txtPathOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathOutput.Location = new System.Drawing.Point(12, 65);
            this.txtPathOutput.Name = "txtPathOutput";
            this.txtPathOutput.Size = new System.Drawing.Size(448, 20);
            this.txtPathOutput.TabIndex = 9;
            this.txtPathOutput.Text = ".\\result.txt";
            // 
            // btnOpenPathOutput
            // 
            this.btnOpenPathOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPathOutput.Location = new System.Drawing.Point(466, 63);
            this.btnOpenPathOutput.Name = "btnOpenPathOutput";
            this.btnOpenPathOutput.Size = new System.Drawing.Size(32, 23);
            this.btnOpenPathOutput.TabIndex = 10;
            this.btnOpenPathOutput.Text = "...";
            this.btnOpenPathOutput.UseVisualStyleBackColor = true;
            this.btnOpenPathOutput.Click += new System.EventHandler(this.btnOpenPathOutput_Click);
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Checked = true;
            this.chkSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSize.Location = new System.Drawing.Point(12, 90);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(46, 17);
            this.chkSize.TabIndex = 11;
            this.chkSize.Text = "Size";
            this.chkSize.UseVisualStyleBackColor = true;
            // 
            // chkMD5
            // 
            this.chkMD5.AutoSize = true;
            this.chkMD5.Checked = true;
            this.chkMD5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMD5.Location = new System.Drawing.Point(92, 90);
            this.chkMD5.Name = "chkMD5";
            this.chkMD5.Size = new System.Drawing.Size(49, 17);
            this.chkMD5.TabIndex = 12;
            this.chkMD5.Text = "MD5";
            this.chkMD5.UseVisualStyleBackColor = true;
            // 
            // chkSHA256
            // 
            this.chkSHA256.AutoSize = true;
            this.chkSHA256.Location = new System.Drawing.Point(172, 90);
            this.chkSHA256.Name = "chkSHA256";
            this.chkSHA256.Size = new System.Drawing.Size(66, 17);
            this.chkSHA256.TabIndex = 13;
            this.chkSHA256.Text = "SHA256";
            this.chkSHA256.UseVisualStyleBackColor = true;
            // 
            // chkCreationTime
            // 
            this.chkCreationTime.AutoSize = true;
            this.chkCreationTime.Location = new System.Drawing.Point(12, 110);
            this.chkCreationTime.Name = "chkCreationTime";
            this.chkCreationTime.Size = new System.Drawing.Size(87, 17);
            this.chkCreationTime.TabIndex = 14;
            this.chkCreationTime.Text = "Creation time";
            this.chkCreationTime.UseVisualStyleBackColor = true;
            // 
            // chkLastAccessTime
            // 
            this.chkLastAccessTime.AutoSize = true;
            this.chkLastAccessTime.Location = new System.Drawing.Point(112, 110);
            this.chkLastAccessTime.Name = "chkLastAccessTime";
            this.chkLastAccessTime.Size = new System.Drawing.Size(83, 17);
            this.chkLastAccessTime.TabIndex = 15;
            this.chkLastAccessTime.Text = "Last access";
            this.chkLastAccessTime.UseVisualStyleBackColor = true;
            // 
            // chkLastWriteTime
            // 
            this.chkLastWriteTime.AutoSize = true;
            this.chkLastWriteTime.Location = new System.Drawing.Point(212, 110);
            this.chkLastWriteTime.Name = "chkLastWriteTime";
            this.chkLastWriteTime.Size = new System.Drawing.Size(105, 17);
            this.chkLastWriteTime.TabIndex = 16;
            this.chkLastWriteTime.Text = "Last modification";
            this.chkLastWriteTime.UseVisualStyleBackColor = true;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(12, 133);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 17;
            this.btnGetInfo.Text = "Get info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(12, 165);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(486, 43);
            this.txtInfo.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Output: File",
            "Output: Textbox"});
            this.comboBox1.Location = new System.Drawing.Point(112, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // FileInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 220);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.radioDirectory);
            this.Controls.Add(this.radioFilesList);
            this.Controls.Add(this.radioFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathOutput);
            this.Controls.Add(this.btnOpenPathOutput);
            this.Controls.Add(this.chkSize);
            this.Controls.Add(this.chkMD5);
            this.Controls.Add(this.chkSHA256);
            this.Controls.Add(this.chkCreationTime);
            this.Controls.Add(this.chkLastAccessTime);
            this.Controls.Add(this.chkLastWriteTime);
            this.Controls.Add(this.btnGetInfo);
            this.Name = "FileInfoForm";
            this.Text = "File Info";
            this.Shown += new System.EventHandler(this.FileInfoForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioDirectory;
        private System.Windows.Forms.RadioButton radioFilesList;
        private System.Windows.Forms.RadioButton radioFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathOutput;
        private System.Windows.Forms.Button btnOpenPathOutput;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.CheckBox chkMD5;
        private System.Windows.Forms.CheckBox chkSHA256;
        private System.Windows.Forms.CheckBox chkCreationTime;
        private System.Windows.Forms.CheckBox chkLastAccessTime;
        private System.Windows.Forms.CheckBox chkLastWriteTime;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}