namespace WindowsManipulations
{
    partial class CompareStringsMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCompare = new System.Windows.Forms.TextBox();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.txtText1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLengthDown = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnPaste2 = new System.Windows.Forms.Button();
            this.btnPaste1 = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnLengthUp = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtCompare);
            this.panel1.Controls.Add(this.txtText2);
            this.panel1.Controls.Add(this.txtText1);
            this.panel1.Location = new System.Drawing.Point(61, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 105);
            this.panel1.TabIndex = 100;
            // 
            // txtCompare
            // 
            this.txtCompare.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompare.Location = new System.Drawing.Point(3, 61);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(711, 26);
            this.txtCompare.TabIndex = 8;
            // 
            // txtText2
            // 
            this.txtText2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtText2.Location = new System.Drawing.Point(3, 32);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(711, 26);
            this.txtText2.TabIndex = 5;
            // 
            // txtText1
            // 
            this.txtText1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtText1.Location = new System.Drawing.Point(3, 3);
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(711, 26);
            this.txtText1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 26);
            // 
            // clearClipboardToolStripMenuItem
            // 
            this.clearClipboardToolStripMenuItem.Name = "clearClipboardToolStripMenuItem";
            this.clearClipboardToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clearClipboardToolStripMenuItem.Text = "Clear clipboard";
            this.clearClipboardToolStripMenuItem.Click += new System.EventHandler(this.clearClipboardToolStripMenuItem_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = global::WindowsManipulations.Properties.Resources.if_Streamline_75_185095;
            this.btnSettings.Location = new System.Drawing.Point(778, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 32);
            this.btnSettings.TabIndex = 101;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLengthDown
            // 
            this.btnLengthDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLengthDown.Image = global::WindowsManipulations.Properties.Resources.if_icon_arrow_down_b_211614;
            this.btnLengthDown.Location = new System.Drawing.Point(780, 67);
            this.btnLengthDown.Name = "btnLengthDown";
            this.btnLengthDown.Size = new System.Drawing.Size(28, 20);
            this.btnLengthDown.TabIndex = 10;
            this.btnLengthDown.UseVisualStyleBackColor = true;
            this.btnLengthDown.Click += new System.EventHandler(this.btnLengthDown_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Image = global::WindowsManipulations.Properties.Resources.clear;
            this.btnClearAll.Location = new System.Drawing.Point(0, 60);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(28, 28);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnPaste2
            // 
            this.btnPaste2.ContextMenuStrip = this.contextMenuStrip1;
            this.btnPaste2.Image = global::WindowsManipulations.Properties.Resources.Actions_edit_paste_icon;
            this.btnPaste2.Location = new System.Drawing.Point(34, 31);
            this.btnPaste2.Name = "btnPaste2";
            this.btnPaste2.Size = new System.Drawing.Size(28, 28);
            this.btnPaste2.TabIndex = 4;
            this.btnPaste2.UseVisualStyleBackColor = true;
            this.btnPaste2.Click += new System.EventHandler(this.btnPaste2_Click);
            // 
            // btnPaste1
            // 
            this.btnPaste1.ContextMenuStrip = this.contextMenuStrip1;
            this.btnPaste1.Image = global::WindowsManipulations.Properties.Resources.Actions_edit_paste_icon;
            this.btnPaste1.Location = new System.Drawing.Point(34, 2);
            this.btnPaste1.Name = "btnPaste1";
            this.btnPaste1.Size = new System.Drawing.Size(28, 28);
            this.btnPaste1.TabIndex = 1;
            this.btnPaste1.UseVisualStyleBackColor = true;
            this.btnPaste1.Click += new System.EventHandler(this.btnPaste1_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Image = global::WindowsManipulations.Properties.Resources.compare;
            this.btnCompare.Location = new System.Drawing.Point(34, 60);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(28, 28);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.FlatAppearance.BorderSize = 0;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Image = global::WindowsManipulations.Properties.Resources.clear;
            this.btnClear2.Location = new System.Drawing.Point(0, 31);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(28, 28);
            this.btnClear2.TabIndex = 3;
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnLengthUp
            // 
            this.btnLengthUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLengthUp.Image = global::WindowsManipulations.Properties.Resources.if_icon_arrow_up_b_211623;
            this.btnLengthUp.Location = new System.Drawing.Point(780, 46);
            this.btnLengthUp.Name = "btnLengthUp";
            this.btnLengthUp.Size = new System.Drawing.Size(28, 20);
            this.btnLengthUp.TabIndex = 9;
            this.btnLengthUp.UseVisualStyleBackColor = true;
            this.btnLengthUp.Click += new System.EventHandler(this.btnLengthUp_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.FlatAppearance.BorderSize = 0;
            this.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear1.Image = global::WindowsManipulations.Properties.Resources.clear;
            this.btnClear1.Location = new System.Drawing.Point(0, 2);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(28, 28);
            this.btnClear1.TabIndex = 0;
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 105);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLengthDown);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnPaste2);
            this.Controls.Add(this.btnPaste1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnLengthUp);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Compare Strings";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtText1;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnLengthUp;
        private System.Windows.Forms.TextBox txtCompare;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnPaste1;
        private System.Windows.Forms.Button btnPaste2;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnLengthDown;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearClipboardToolStripMenuItem;
    }
}