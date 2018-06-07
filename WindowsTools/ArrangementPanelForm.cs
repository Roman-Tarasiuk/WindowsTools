using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class ArrangementPanelForm : Form
    {
        private FormBorderStyle m_FormBorderStyle = FormBorderStyle.None;

        private bool m_MousePressed = false;
        int m_X, m_Y;

        public ArrangementPanelForm()
        {
            InitializeComponent();
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

        private void ScreenRulerHelperForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_MousePressed = true;

            if (e.Button == MouseButtons.Left)
            {
                m_X = e.X;
                m_Y = e.Y;
            }
        }

        private void ScreenRulerHelperForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_MousePressed = false;
        }

        private void ScreenRulerHelperForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_MousePressed)
            {
                this.Location = new Point(e.X + this.Location.X - m_X, e.Y + this.Location.Y - m_Y);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.BackColor;

            var result = this.colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.BackColor = this.colorDialog1.Color;
            }
        }

        private void topmostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                topmostToolStripMenuItem.Checked = false;
            }
            else
            {
                this.TopMost = true;
                topmostToolStripMenuItem.Checked = true;
            }
        }

        private void showInTaskbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ShowInTaskbar)
            {
                this.ShowInTaskbar = false;
                showInTaskbarToolStripMenuItem.Checked = false;
            }
            else
            {
                this.ShowInTaskbar = true;
                showInTaskbarToolStripMenuItem.Checked = true;
            }
        }

        private void formBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.m_FormBorderStyle = FormBorderStyle.Sizable;
                this.formBorderToolStripMenuItem.Checked = true;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.m_FormBorderStyle = FormBorderStyle.None;
                this.formBorderToolStripMenuItem.Checked = false;
            }
        }
    }
}
