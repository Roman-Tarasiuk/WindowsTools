using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    partial class LocationAndSizeForm
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
            this.groupBoxCurrent = new WindowsManipulations.Infrastructure.myGroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCurrentHeight = new System.Windows.Forms.TextBox();
            this.txtCurrentWidth = new System.Windows.Forms.TextBox();
            this.txtCurrentTop = new System.Windows.Forms.TextBox();
            this.txtCurrentLeft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNew = new WindowsManipulations.Infrastructure.myGroupBox();
            this.txtNewHeight = new System.Windows.Forms.TextBox();
            this.txtNewWidth = new System.Windows.Forms.TextBox();
            this.txtNewTop = new System.Windows.Forms.TextBox();
            this.txtNewLeft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblResolution = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBoxCurrent.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCurrent
            // 
            this.groupBoxCurrent.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxCurrent.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBoxCurrent.Controls.Add(this.txtCurrentHeight);
            this.groupBoxCurrent.Controls.Add(this.txtCurrentWidth);
            this.groupBoxCurrent.Controls.Add(this.txtCurrentTop);
            this.groupBoxCurrent.Controls.Add(this.txtCurrentLeft);
            this.groupBoxCurrent.Controls.Add(this.label4);
            this.groupBoxCurrent.Controls.Add(this.label3);
            this.groupBoxCurrent.Controls.Add(this.label2);
            this.groupBoxCurrent.Controls.Add(this.label1);
            this.groupBoxCurrent.Location = new System.Drawing.Point(11, 12);
            this.groupBoxCurrent.Name = "groupBoxCurrent";
            this.groupBoxCurrent.Size = new System.Drawing.Size(175, 133);
            this.groupBoxCurrent.TabIndex = 0;
            this.groupBoxCurrent.TabStop = false;
            this.groupBoxCurrent.Text = "Current*";
            this.groupBoxCurrent.Enter += new System.EventHandler(this.groupBoxCurrent_Enter);
            this.groupBoxCurrent.MouseHover += new System.EventHandler(this.groupBoxCurrent_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // txtCurrentHeight
            // 
            this.txtCurrentHeight.Location = new System.Drawing.Point(58, 103);
            this.txtCurrentHeight.Name = "txtCurrentHeight";
            this.txtCurrentHeight.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentHeight.TabIndex = 7;
            // 
            // txtCurrentWidth
            // 
            this.txtCurrentWidth.Location = new System.Drawing.Point(58, 77);
            this.txtCurrentWidth.Name = "txtCurrentWidth";
            this.txtCurrentWidth.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentWidth.TabIndex = 6;
            // 
            // txtCurrentTop
            // 
            this.txtCurrentTop.Location = new System.Drawing.Point(58, 51);
            this.txtCurrentTop.Name = "txtCurrentTop";
            this.txtCurrentTop.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentTop.TabIndex = 5;
            // 
            // txtCurrentLeft
            // 
            this.txtCurrentLeft.Location = new System.Drawing.Point(58, 25);
            this.txtCurrentLeft.Name = "txtCurrentLeft";
            this.txtCurrentLeft.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentLeft.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Top:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left:";
            // 
            // groupBoxNew
            // 
            this.groupBoxNew.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxNew.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBoxNew.Controls.Add(this.txtNewHeight);
            this.groupBoxNew.Controls.Add(this.txtNewWidth);
            this.groupBoxNew.Controls.Add(this.txtNewTop);
            this.groupBoxNew.Controls.Add(this.txtNewLeft);
            this.groupBoxNew.Controls.Add(this.label5);
            this.groupBoxNew.Controls.Add(this.label6);
            this.groupBoxNew.Controls.Add(this.label7);
            this.groupBoxNew.Controls.Add(this.label8);
            this.groupBoxNew.Location = new System.Drawing.Point(194, 12);
            this.groupBoxNew.Name = "groupBoxNew";
            this.groupBoxNew.Size = new System.Drawing.Size(175, 133);
            this.groupBoxNew.TabIndex = 1;
            this.groupBoxNew.TabStop = false;
            this.groupBoxNew.Text = "New *";
            this.groupBoxNew.Enter += new System.EventHandler(this.groupBoxNew_Enter);
            this.groupBoxNew.MouseHover += new System.EventHandler(this.groupBoxNew_MouseHover);
            // 
            // txtNewHeight
            // 
            this.txtNewHeight.Location = new System.Drawing.Point(58, 103);
            this.txtNewHeight.Name = "txtNewHeight";
            this.txtNewHeight.Size = new System.Drawing.Size(100, 20);
            this.txtNewHeight.TabIndex = 7;
            this.txtNewHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewHeight_KeyDown);
            // 
            // txtNewWidth
            // 
            this.txtNewWidth.Location = new System.Drawing.Point(58, 77);
            this.txtNewWidth.Name = "txtNewWidth";
            this.txtNewWidth.Size = new System.Drawing.Size(100, 20);
            this.txtNewWidth.TabIndex = 6;
            this.txtNewWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewWidth_KeyDown);
            // 
            // txtNewTop
            // 
            this.txtNewTop.Location = new System.Drawing.Point(58, 51);
            this.txtNewTop.Name = "txtNewTop";
            this.txtNewTop.Size = new System.Drawing.Size(100, 20);
            this.txtNewTop.TabIndex = 5;
            this.txtNewTop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewTop_KeyDown);
            // 
            // txtNewLeft
            // 
            this.txtNewLeft.Location = new System.Drawing.Point(58, 25);
            this.txtNewLeft.Name = "txtNewLeft";
            this.txtNewLeft.Size = new System.Drawing.Size(100, 20);
            this.txtNewLeft.TabIndex = 4;
            this.txtNewLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewLeft_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Width:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Top:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Left:";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(294, 156);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(9, 161);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(60, 13);
            this.lblResolution.TabIndex = 4;
            this.lblResolution.Text = "Resolution:";
            this.toolTip1.SetToolTip(this.lblResolution, "Click to see other screens\' resolutions");
            this.lblResolution.Click += new System.EventHandler(this.lblResolution_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(259, 161);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LocationAndSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 187);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBoxNew);
            this.Controls.Add(this.groupBoxCurrent);
            this.Name = "LocationAndSizeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Location And Size - Windows Manipulations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocationAndSizeForm_FormClosing);
            this.Shown += new System.EventHandler(this.LocationAndSizeForm_Shown);
            this.LocationChanged += new System.EventHandler(this.LocationAndSizeForm_LocationChanged);
            this.groupBoxCurrent.ResumeLayout(false);
            this.groupBoxCurrent.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCurrentHeight;
        private System.Windows.Forms.TextBox txtCurrentWidth;
        private System.Windows.Forms.TextBox txtCurrentTop;
        private System.Windows.Forms.TextBox txtCurrentLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewHeight;
        private System.Windows.Forms.TextBox txtNewWidth;
        private System.Windows.Forms.TextBox txtNewTop;
        private System.Windows.Forms.TextBox txtNewLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private myGroupBox groupBoxCurrent;
        private myGroupBox groupBoxNew;
    }
}