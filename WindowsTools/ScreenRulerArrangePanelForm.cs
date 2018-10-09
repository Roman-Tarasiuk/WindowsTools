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
        int m_HandlerX = 0, m_HandlerY = 0;

        public event EventHandler OpacityChanged;

        public string Info
        {
            get
            {
                return this.lblInfo.Text;
            }
            set
            {
                this.lblInfo.Visible = true;
                this.lblInfo.Text = value;
            }
        }

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
                else
                {
                    m_HandlerX = 0;
                    m_HandlerY = 0;
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

        private void lblInfo_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void handleMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HandleMove == null || HandleMove.IsDisposed)
            {
                HandleMove = new ScreenRulerArrangePanelForm();
                HandleMove.ClientSize = new System.Drawing.Size(28, 20);
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

                this.OpacityChanged += (handleSender, handleE) =>
                {
                    HandleMove.Info = this.Opacity.ToString();
                };
            }
        }

        private void ScreenRulerHelperForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m_MousePressed = true;
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
            var opacityChanged = false;

            if (e.Delta > 0 && this.Opacity < 1)
            {
                if (this.Opacity >= 0.1)
                {
                    this.Opacity += 0.1;
                    opacityChanged = true;
                }
                else
                {
                    this.Opacity += 0.01;
                    opacityChanged = true;
                }
            }
            else if (e.Delta < 0 && this.Opacity > 0.01)
            {
                if (this.Opacity >= 0.2)
                {
                    this.Opacity -= 0.1;
                    opacityChanged = true;
                }
                else if (this.Opacity >= 0.02)
                {
                    this.Opacity -= 0.01;
                    opacityChanged = true;
                }
            }

            if (opacityChanged)
            {
                OnOpacityChanged();
            }
        }

        protected void OnOpacityChanged()
        {
            if (this.OpacityChanged != null)
            {
                this.OpacityChanged(this, EventArgs.Empty);
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.BackColor;

            var result = this.colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.BackColor = this.colorDialog1.Color;

                ChangeTaskbarIcon(this.BackColor);
            }
        }

        private void ChangeTaskbarIcon(Color color)
        {
            var width = 20;
            var height = 20;

            var bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(new SolidBrush(color), 0, 0, width, height);
            }

            this.Icon = Icon.FromHandle(bmp.GetHicon());
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
            const int minHeight = 1;
            const int minWidth = 1;

            var offset = 10;
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
