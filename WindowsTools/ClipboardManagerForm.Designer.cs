namespace WindowsTools
{
    partial class ClipboardManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardManagerForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClipboardDetect = new System.Windows.Forms.Button();
            this.btnClipboardClear = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.systemClipboardManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearClipboarFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetFormats = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(337, 109);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Audio",
            "File drop list",
            "Image",
            "Text",
            "Data"});
            this.comboBox1.Location = new System.Drawing.Point(4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnClipboardDetect
            // 
            this.btnClipboardDetect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipboardDetect.Location = new System.Drawing.Point(133, 3);
            this.btnClipboardDetect.Name = "btnClipboardDetect";
            this.btnClipboardDetect.Size = new System.Drawing.Size(60, 23);
            this.btnClipboardDetect.TabIndex = 2;
            this.btnClipboardDetect.Text = "Detect";
            this.btnClipboardDetect.UseVisualStyleBackColor = true;
            this.btnClipboardDetect.Click += new System.EventHandler(this.btnClipboardDetect_Click);
            // 
            // btnClipboardClear
            // 
            this.btnClipboardClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipboardClear.Location = new System.Drawing.Point(271, 3);
            this.btnClipboardClear.Name = "btnClipboardClear";
            this.btnClipboardClear.Size = new System.Drawing.Size(70, 23);
            this.btnClipboardClear.TabIndex = 2;
            this.btnClipboardClear.Text = "Clear";
            this.btnClipboardClear.UseVisualStyleBackColor = true;
            this.btnClipboardClear.Click += new System.EventHandler(this.btnClipboardClear_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "System Clipboard Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemClipboardManagerToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearClipboardToolStripMenuItem,
            this.clearClipboarFormatToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 104);
            // 
            // systemClipboardManagerToolStripMenuItem
            // 
            this.systemClipboardManagerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.systemClipboardManagerToolStripMenuItem.Name = "systemClipboardManagerToolStripMenuItem";
            this.systemClipboardManagerToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.systemClipboardManagerToolStripMenuItem.Text = "System Clipboard Manager";
            this.systemClipboardManagerToolStripMenuItem.Click += new System.EventHandler(this.systemClipboardManagerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // clearClipboardToolStripMenuItem
            // 
            this.clearClipboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearClipboardToolStripMenuItem.Image = global::WindowsTools.Properties.Resources.clear_clipboard_20;
            this.clearClipboardToolStripMenuItem.Name = "clearClipboardToolStripMenuItem";
            this.clearClipboardToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clearClipboardToolStripMenuItem.Text = "Clear clipboard";
            this.clearClipboardToolStripMenuItem.Click += new System.EventHandler(this.clearClipboardToolStripMenuItem_Click);
            // 
            // clearClipboarFormatToolStripMenuItem
            // 
            this.clearClipboarFormatToolStripMenuItem.Name = "clearClipboarFormatToolStripMenuItem";
            this.clearClipboarFormatToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clearClipboarFormatToolStripMenuItem.Text = "Clear clipboard text format";
            this.clearClipboarFormatToolStripMenuItem.Click += new System.EventHandler(this.clearClipboarFormatToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btnGetFormats
            // 
            this.btnGetFormats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFormats.Location = new System.Drawing.Point(197, 3);
            this.btnGetFormats.Name = "btnGetFormats";
            this.btnGetFormats.Size = new System.Drawing.Size(70, 23);
            this.btnGetFormats.TabIndex = 3;
            this.btnGetFormats.Text = "Get formats";
            this.btnGetFormats.UseVisualStyleBackColor = true;
            this.btnGetFormats.Click += new System.EventHandler(this.btnGetFormats_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnColor1
            // 
            this.btnColor1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor1.Location = new System.Drawing.Point(119, 4);
            this.btnColor1.Margin = new System.Windows.Forms.Padding(0);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(10, 10);
            this.btnColor1.TabIndex = 4;
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor2.Location = new System.Drawing.Point(119, 15);
            this.btnColor2.Margin = new System.Windows.Forms.Padding(0);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(10, 10);
            this.btnColor2.TabIndex = 5;
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // ClipboardManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.btnGetFormats);
            this.Controls.Add(this.btnClipboardDetect);
            this.Controls.Add(this.btnClipboardClear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClipboardManagerForm";
            this.Text = "System Clipboard Manager";
            this.Resize += new System.EventHandler(this.ClipboardManagerForm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClipboardDetect;
        private System.Windows.Forms.Button btnClipboardClear;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemClipboardManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearClipboarFormatToolStripMenuItem;
        private System.Windows.Forms.Button btnGetFormats;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}