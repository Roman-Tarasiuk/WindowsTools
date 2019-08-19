using System.Windows.Forms;

namespace WindowsTools
{
    partial class DecodeTextForm
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
            this.txtInputEncoding = new System.Windows.Forms.TextBox();
            this.txtOutputEncoding = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.chkWordwrap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();

            //
            // btnDecode
            //
            this.btnDecode.Location = new System.Drawing.Point(350, 8);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 24);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);

            //
            // txtInputEncoding
            //
            this.txtInputEncoding.Location = new System.Drawing.Point(6, 10);
            this.txtInputEncoding.Size = new System.Drawing.Size(160, 24);
            this.txtInputEncoding.Text = "iso-8859-15";

            //
            // txtOutputEncoding
            //
            this.txtOutputEncoding.Location = new System.Drawing.Point(170, 10);
            this.txtOutputEncoding.Size = new System.Drawing.Size(160, 24);
            this.txtOutputEncoding.Text = "utf-8";

            //
            // txtInput
            //
            this.txtInput.Location = new System.Drawing.Point(6, 40);
            this.txtInput.Size = new System.Drawing.Size(700, 250);
            this.txtInput.Multiline = true;
            this.txtInput.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            this.txtInput.ScrollBars = ScrollBars.Both;
            this.txtInput.WordWrap = false;

            //
            // txtOutput
            //
            this.txtOutput.Location = new System.Drawing.Point(6, 300);
            this.txtOutput.Size = new System.Drawing.Size(700, 250);
            this.txtOutput.Multiline = true;
            this.txtOutput.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            this.txtOutput.ScrollBars = ScrollBars.Both;
            this.txtOutput.WordWrap = false;

            //
            // chkWordwrap
            //
            this.chkWordwrap.Location = new System.Drawing.Point(6, 551);
            this.chkWordwrap.Text = "Word wrap";
            this.chkWordwrap.Click += new System.EventHandler(this.chkWordwrap_Click);

            //
            // DecodeTextForm
            //
            this.ClientSize = new System.Drawing.Size(712, 575);
            this.Controls.Add(this.txtInputEncoding);
            this.Controls.Add(this.txtOutputEncoding);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.chkWordwrap);
            this.Name = "DecodeTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Text = "Decode text";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInputEncoding;
        private System.Windows.Forms.TextBox txtOutputEncoding;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.CheckBox chkWordwrap;
    }
}