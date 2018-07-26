using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User32Helper;
using WindowsTools.Infrastructure;

namespace WindowsTools
{
    public partial class WindowTitleTrackingForm : Form
    {
        #region Fields

        private System.Windows.Forms.Panel panel1;

        TitleTrackingFormProperties m_Properties = new TitleTrackingFormProperties();

        IntPtr m_Hwnd;

        #endregion


        #region Constructor and Additional Settings

        public WindowTitleTrackingForm(IntPtr hwnd)
        {
            InitializeComponent();

            m_Hwnd = hwnd;

            m_Properties.BackColor = this.BackColor;
            m_Properties.ForeColor = this.ForeColor;
            m_Properties.BorderColor = Color.FromArgb(128, 255, 128);
            m_Properties.Font = this.label1.Font;
            m_Properties.Height = this.Height;
            m_Properties.Width = this.Width;
            m_Properties.BorderWidth = 1;
            m_Properties.Interval = 1;

            InitializeAdditionalComponents();
        }

        private void InitializeAdditionalComponents()
        {
            // The panel for moving the form by any point.

            this.panel1 = new TransparentDraggablePanel(this)
            {
                Name = "panel1",
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(220, 31),
                TabIndex = 1
            };

            this.Controls.Add(this.panel1);

            panel1.BringToFront();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        #endregion


        #region Event Handlers

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var propertiesForm = new WindowTitleTrackingPropertiesForm(m_Properties);
            var result = propertiesForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                m_Properties = propertiesForm.Properties;
                ApplyProperties(m_Properties);
                Invalidate();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowTitleTrackingForm_Shown(object sender, EventArgs e)
        {
            DisplayTitle();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayTitle();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTitle();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void WindowTitleTrackingForm_Paint(object sender, PaintEventArgs e)
        {
            if (m_Properties.BorderWidth == 0)
            {
                return;
            }

            e.Graphics.DrawRectangle
            (
                new Pen(m_Properties.BorderColor, m_Properties.BorderWidth),
                new Rectangle
                (
                    m_Properties.BorderWidth / 2,
                    m_Properties.BorderWidth / 2,
                    this.Size.Width - m_Properties.BorderWidth,
                    this.Size.Height - m_Properties.BorderWidth
                    )
            );
        }

        #endregion


        #region Helper Methods

        private void DisplayTitle()
        {
            var title = User32Windows.GetWindowText(m_Hwnd, 255);

            if (label1.Text != title)
            {
                label1.Text = title;
                this.Text = title;
            }
        }

        private void ApplyProperties(TitleTrackingFormProperties m_Properties)
        {
            this.ForeColor = m_Properties.ForeColor;
            this.BackColor = m_Properties.BackColor;
            this.label1.Font = m_Properties.Font;
            this.Width = m_Properties.Width;
            this.Height = m_Properties.Height;
            this.timer1.Interval = m_Properties.Interval * 1000;
            this.label1.Location = new Point(this.label1.Location.X, m_Properties.BorderWidth);
            this.label1.Height = m_Properties.Height - m_Properties.BorderWidth * 2;
            Invalidate();
        }

        #endregion
    }
}
