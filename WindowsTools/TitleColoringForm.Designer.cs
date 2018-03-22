namespace WindowsTools
{
    partial class TitleColoringForm
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
            this.btnStartColoring = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfigs = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddConfig = new System.Windows.Forms.Button();
            this.btnColors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartColoring
            // 
            this.btnStartColoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartColoring.Location = new System.Drawing.Point(309, 109);
            this.btnStartColoring.Name = "btnStartColoring";
            this.btnStartColoring.Size = new System.Drawing.Size(80, 23);
            this.btnStartColoring.TabIndex = 5;
            this.btnStartColoring.Text = "Start coloring";
            this.btnStartColoring.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Configs*:";
            this.toolTip1.SetToolTip(this.label1, "Use one config per line");
            // 
            // txtConfigs
            // 
            this.txtConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConfigs.Location = new System.Drawing.Point(12, 21);
            this.txtConfigs.Multiline = true;
            this.txtConfigs.Name = "txtConfigs";
            this.txtConfigs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConfigs.Size = new System.Drawing.Size(377, 82);
            this.txtConfigs.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtConfigs, "Use space, new line and tab characters for split hwnds");
            this.txtConfigs.WordWrap = false;
            // 
            // btnAddConfig
            // 
            this.btnAddConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddConfig.Location = new System.Drawing.Point(228, 109);
            this.btnAddConfig.Name = "btnAddConfig";
            this.btnAddConfig.Size = new System.Drawing.Size(75, 23);
            this.btnAddConfig.TabIndex = 6;
            this.btnAddConfig.Text = "Add config";
            this.btnAddConfig.UseVisualStyleBackColor = true;
            this.btnAddConfig.Click += new System.EventHandler(this.btnAddConfig_Click);
            // 
            // btnColors
            // 
            this.btnColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColors.Location = new System.Drawing.Point(12, 109);
            this.btnColors.Name = "btnColors";
            this.btnColors.Size = new System.Drawing.Size(75, 23);
            this.btnColors.TabIndex = 7;
            this.btnColors.Text = "Colors*...";
            this.toolTip1.SetToolTip(this.btnColors, "Selected color will be copied to clipboard");
            this.btnColors.UseVisualStyleBackColor = true;
            this.btnColors.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // TitleColoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 137);
            this.Controls.Add(this.btnColors);
            this.Controls.Add(this.btnAddConfig);
            this.Controls.Add(this.btnStartColoring);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfigs);
            this.Name = "TitleColoringForm";
            this.Text = "Title coloring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartColoring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtConfigs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddConfig;
        private System.Windows.Forms.Button btnColors;
    }
}