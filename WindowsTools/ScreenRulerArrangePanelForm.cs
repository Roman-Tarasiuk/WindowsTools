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
    public partial class ScreenRulerArrangePanelForm : Form
    {
        private FormBorderStyle m_FormBorderStyle = FormBorderStyle.None;

        private bool m_MousePressed = false;
        int m_X, m_Y;
        int m_HandlerX, m_HandlerY;

        public ScreenRulerArrangePanelForm()
        {
            InitializeComponent();

            this.LocationChanged += (handleSender, handleE) =>
            {
                if (HandleMove != null && !HandleMove.IsDisposed)
                {
                    m_HandlerX = HandleMove.Location.X - this.Location.X;
                    m_HandlerY = HandleMove.Location.Y - this.Location.Y;
                }
            };
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

        private void handleMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HandleMove == null || HandleMove.IsDisposed)
            {
                HandleMove = new ScreenRulerArrangePanelForm();
                HandleMove.ClientSize = new System.Drawing.Size(20, 20);
                HandleMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                HandleMove.Location = this.Location;
                HandleMove.StartPosition = FormStartPosition.Manual;
                HandleMove.TopMost = true;
                HandleMove.Text = "Screen ruler handle";
                HandleMove.Show();

                HandleMove.LocationChanged += (handleSender, handleE) =>
                {
                    this.Location = new Point(HandleMove.Location.X - m_HandlerX, HandleMove.Location.Y - m_HandlerY);
                };
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

        private void ScreenRulerHelperForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            else if (e.Delta < 0 && this.Opacity >= 0.2)
            {
                this.Opacity -= 0.1;
            }
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

        private void ScreenRulerArrangePanelForm_Shown(object sender, EventArgs e)
        {
            this.topmostToolStripMenuItem.Checked = this.TopMost;
            this.showInTaskbarToolStripMenuItem.Checked = this.ShowInTaskbar;
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

        private void ScreenRulerArrangePanelForm_KeyDown(object sender, KeyEventArgs e)
        {
            var offset = 10;
            const int minHeight = 1;
            const int minWidth = 1;

            if (e.Control)
            {
                offset = 1;
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (e.Alt)
                    {
                        if (this.Width - offset >= minWidth)
                        {
                            this.Width -= offset;
                        }
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X - offset, this.Location.Y);
                    }
                    break;
                case Keys.Right:
                    if (e.Alt)
                    {
                        this.Width += offset;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + offset, this.Location.Y);
                    }
                    break;
                case Keys.Up:
                    if (e.Alt)
                    {
                        if (this.Height - offset >= minHeight)
                        {
                            this.Height -= offset;
                        }
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y - offset);
                    }
                    break;
                case Keys.Down:
                    if (e.Alt)
                    {
                        this.Height += offset;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + offset);
                    }
                    break;
            }
        }
    }
}
