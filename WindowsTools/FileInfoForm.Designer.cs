
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.radioDirectory = new System.Windows.Forms.RadioButton();
            this.radioFilesList = new System.Windows.Forms.RadioButton();
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathOutput = new System.Windows.Forms.TextBox();
            this.btnOpenPathOutput = new System.Windows.Forms.Button();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.chkMD5 = new System.Windows.Forms.CheckBox();
            this.chkSHA256 = new System.Windows.Forms.CheckBox();
            this.chkCreationTime = new System.Windows.Forms.CheckBox();
            this.chkLastAccessTime = new System.Windows.Forms.CheckBox();
            this.chkLastWriteTime = new System.Windows.Forms.CheckBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.radioFileList2 = new System.Windows.Forms.RadioButton();
            this.chkShowAttribNames = new System.Windows.Forms.CheckBox();
            this.chkFullNames = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radioFileList2);
            this.splitContainer1.Panel1.Controls.Add(this.radioDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.radioFilesList);
            this.splitContainer1.Panel1.Controls.Add(this.radioFile);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtPath);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnOptions);
            this.splitContainer1.Panel2.Controls.Add(this.txtInfo);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetInfo);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(510, 237);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 20;
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(12, 133);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(488, 45);
            this.txtInfo.TabIndex = 30;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(11, 104);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 29;
            this.btnGetInfo.Text = "Get info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // radioDirectory
            // 
            this.radioDirectory.AutoSize = true;
            this.radioDirectory.Checked = true;
            this.radioDirectory.Location = new System.Drawing.Point(145, 4);
            this.radioDirectory.Name = "radioDirectory";
            this.radioDirectory.Size = new System.Drawing.Size(67, 17);
            this.radioDirectory.TabIndex = 10;
            this.radioDirectory.TabStop = true;
            this.radioDirectory.Text = "Directory";
            this.radioDirectory.UseVisualStyleBackColor = true;
            // 
            // radioFilesList
            // 
            this.radioFilesList.AutoSize = true;
            this.radioFilesList.Location = new System.Drawing.Point(275, 4);
            this.radioFilesList.Name = "radioFilesList";
            this.radioFilesList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioFilesList.Size = new System.Drawing.Size(88, 17);
            this.radioFilesList.TabIndex = 12;
            this.radioFilesList.Text = "File list (file)";
            this.radioFilesList.UseVisualStyleBackColor = true;
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Location = new System.Drawing.Point(218, 4);
            this.radioFile.Name = "radioFile";
            this.radioFile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioFile.Size = new System.Drawing.Size(51, 17);
            this.radioFile.TabIndex = 11;
            this.radioFile.Text = "File";
            this.radioFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Directory / File(s):";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(12, 24);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(450, 20);
            this.txtPath.TabIndex = 13;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPath.Location = new System.Drawing.Point(468, 22);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(32, 23);
            this.btnOpenPath.TabIndex = 14;
            this.btnOpenPath.Text = "...";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chkFullNames);
            this.panel1.Controls.Add(this.chkShowAttribNames);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPathOutput);
            this.panel1.Controls.Add(this.btnOpenPathOutput);
            this.panel1.Controls.Add(this.chkSize);
            this.panel1.Controls.Add(this.chkMD5);
            this.panel1.Controls.Add(this.chkSHA256);
            this.panel1.Controls.Add(this.chkCreationTime);
            this.panel1.Controls.Add(this.chkLastAccessTime);
            this.panel1.Controls.Add(this.chkLastWriteTime);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 101);
            this.panel1.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Output: File",
            "Output: Textbox"});
            this.comboBox1.Location = new System.Drawing.Point(12, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Result:";
            // 
            // txtPathOutput
            // 
            this.txtPathOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathOutput.Location = new System.Drawing.Point(12, 15);
            this.txtPathOutput.Name = "txtPathOutput";
            this.txtPathOutput.Size = new System.Drawing.Size(450, 20);
            this.txtPathOutput.TabIndex = 33;
            this.txtPathOutput.Text = ".\\result.txt";
            // 
            // btnOpenPathOutput
            // 
            this.btnOpenPathOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPathOutput.Location = new System.Drawing.Point(468, 13);
            this.btnOpenPathOutput.Name = "btnOpenPathOutput";
            this.btnOpenPathOutput.Size = new System.Drawing.Size(32, 23);
            this.btnOpenPathOutput.TabIndex = 34;
            this.btnOpenPathOutput.Text = "...";
            this.btnOpenPathOutput.UseVisualStyleBackColor = true;
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(12, 40);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(46, 17);
            this.chkSize.TabIndex = 35;
            this.chkSize.Text = "Size";
            this.chkSize.UseVisualStyleBackColor = true;
            // 
            // chkMD5
            // 
            this.chkMD5.AutoSize = true;
            this.chkMD5.Checked = true;
            this.chkMD5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMD5.Location = new System.Drawing.Point(92, 40);
            this.chkMD5.Name = "chkMD5";
            this.chkMD5.Size = new System.Drawing.Size(49, 17);
            this.chkMD5.TabIndex = 36;
            this.chkMD5.Text = "MD5";
            this.chkMD5.UseVisualStyleBackColor = true;
            // 
            // chkSHA256
            // 
            this.chkSHA256.AutoSize = true;
            this.chkSHA256.Location = new System.Drawing.Point(172, 40);
            this.chkSHA256.Name = "chkSHA256";
            this.chkSHA256.Size = new System.Drawing.Size(66, 17);
            this.chkSHA256.TabIndex = 37;
            this.chkSHA256.Text = "SHA256";
            this.chkSHA256.UseVisualStyleBackColor = true;
            // 
            // chkCreationTime
            // 
            this.chkCreationTime.AutoSize = true;
            this.chkCreationTime.Location = new System.Drawing.Point(12, 60);
            this.chkCreationTime.Name = "chkCreationTime";
            this.chkCreationTime.Size = new System.Drawing.Size(87, 17);
            this.chkCreationTime.TabIndex = 38;
            this.chkCreationTime.Text = "Creation time";
            this.chkCreationTime.UseVisualStyleBackColor = true;
            // 
            // chkLastAccessTime
            // 
            this.chkLastAccessTime.AutoSize = true;
            this.chkLastAccessTime.Location = new System.Drawing.Point(112, 60);
            this.chkLastAccessTime.Name = "chkLastAccessTime";
            this.chkLastAccessTime.Size = new System.Drawing.Size(83, 17);
            this.chkLastAccessTime.TabIndex = 39;
            this.chkLastAccessTime.Text = "Last access";
            this.chkLastAccessTime.UseVisualStyleBackColor = true;
            // 
            // chkLastWriteTime
            // 
            this.chkLastWriteTime.AutoSize = true;
            this.chkLastWriteTime.Location = new System.Drawing.Point(212, 60);
            this.chkLastWriteTime.Name = "chkLastWriteTime";
            this.chkLastWriteTime.Size = new System.Drawing.Size(105, 17);
            this.chkLastWriteTime.TabIndex = 40;
            this.chkLastWriteTime.Text = "Last modification";
            this.chkLastWriteTime.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(112, 104);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 33;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // radioFileList2
            // 
            this.radioFileList2.AutoSize = true;
            this.radioFileList2.Location = new System.Drawing.Point(356, 4);
            this.radioFileList2.Name = "radioFileList2";
            this.radioFileList2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioFileList2.Size = new System.Drawing.Size(66, 17);
            this.radioFileList2.TabIndex = 15;
            this.radioFileList2.Text = "File list";
            this.radioFileList2.UseVisualStyleBackColor = true;
            // 
            // chkShowAttribNames
            // 
            this.chkShowAttribNames.AutoSize = true;
            this.chkShowAttribNames.Location = new System.Drawing.Point(139, 81);
            this.chkShowAttribNames.Name = "chkShowAttribNames";
            this.chkShowAttribNames.Size = new System.Drawing.Size(133, 17);
            this.chkShowAttribNames.TabIndex = 42;
            this.chkShowAttribNames.Text = "Output attribute names";
            this.chkShowAttribNames.UseVisualStyleBackColor = true;
            // 
            // chkFullNames
            // 
            this.chkFullNames.AutoSize = true;
            this.chkFullNames.Location = new System.Drawing.Point(275, 82);
            this.chkFullNames.Name = "chkFullNames";
            this.chkFullNames.Size = new System.Drawing.Size(76, 17);
            this.chkFullNames.TabIndex = 43;
            this.chkFullNames.Text = "Full names";
            this.chkFullNames.UseVisualStyleBackColor = true;
            // 
            // FileInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 237);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FileInfoForm";
            this.Text = "File Info";
            this.Load += new System.EventHandler(this.FileInfoForm_Load);
            this.Shown += new System.EventHandler(this.FileInfoForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton radioDirectory;
        private System.Windows.Forms.RadioButton radioFilesList;
        private System.Windows.Forms.RadioButton radioFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathOutput;
        private System.Windows.Forms.Button btnOpenPathOutput;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.CheckBox chkMD5;
        private System.Windows.Forms.CheckBox chkSHA256;
        private System.Windows.Forms.CheckBox chkCreationTime;
        private System.Windows.Forms.CheckBox chkLastAccessTime;
        private System.Windows.Forms.CheckBox chkLastWriteTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.RadioButton radioFileList2;
        private System.Windows.Forms.CheckBox chkFullNames;
        private System.Windows.Forms.CheckBox chkShowAttribNames;
    }
}