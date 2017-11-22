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
using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    public partial class WindowTitleTrackingForm : Form
    {
        TitleTrackingFormProperties m_Properties = new TitleTrackingFormProperties();

        IntPtr m_Hwnd;

        private bool m_MouseIsDown = false;
        private Point m_MouseDownCoordinates;

        public WindowTitleTrackingForm(IntPtr hwnd)
        {
            InitializeComponent();

            m_Hwnd = hwnd;

            m_Properties.BackColor = this.BackColor;
            m_Properties.ForeColor = this.ForeColor;
            m_Properties.Font = this.label1.Font;
            m_Properties.Height = this.Height;
            m_Properties.Width = this.Width;
            m_Properties.Interval = 2;
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

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var propertiesForm = new WindowTitleTrackingPropertiesForm(m_Properties);
            var result = propertiesForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                m_Properties = propertiesForm.Properties;
                ApplyProperties(m_Properties);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowTitleTrackingForm_Shown(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(256);
            User32Windows.GetWindowText(m_Hwnd, sb, sb.Capacity + 1);

            var title = sb.ToString();

            if (label1.Text != title)
            {
                label1.Text = title;
            }
        }

        private void WindowTitleTrackingForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_MouseIsDown = true;
            m_MouseDownCoordinates = e.Location;
        }

        private void WindowTitleTrackingForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_MouseIsDown = false;
        }

        private void WindowTitleTrackingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_MouseIsDown)
            {
                Point LocationNew = new Point(this.Location.X + e.Location.X - m_MouseDownCoordinates.X,
                    this.Location.Y + e.Location.Y - m_MouseDownCoordinates.Y);

                this.Location = LocationNew;
            }
        }

        private void ApplyProperties(TitleTrackingFormProperties m_Properties)
        {
            this.ForeColor = m_Properties.ForeColor;
            this.BackColor = m_Properties.BackColor;
            this.Font = m_Properties.Font;
            this.Width = m_Properties.Width;
            this.Height = m_Properties.Height;
            this.timer1.Interval = m_Properties.Interval * 1000;
        }
    }
}
