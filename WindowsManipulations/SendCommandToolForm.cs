using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using User32Helper;
using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    public partial class SendCommandToolForm : Form
    {
        #region Fields

        private IntPtr m_HostWindowHwnd;
        private int m_HostWindowOffsetX;
        private int m_HostWindowOffsetY;
        private string m_Commands;

        private bool m_MouseIsDown = false;
        private bool m_MouseIsHover = false;
        private bool m_SendCommandEnabled = false;
        private bool m_AutoHide = true;

        private Pen m_PenNormal = new Pen(Color.White);
        private Pen m_PenHover = new Pen(Color.Lime);
        private Rectangle m_DrawRectangle = new Rectangle(0, 0, 19, 19);

        private int m_DX;
        private int m_DY;

        #endregion


        #region Constructors

        public SendCommandToolForm(IntPtr hwnd, string commands)
        {
            InitializeComponent();

            m_HostWindowHwnd = hwnd;
            m_Commands = commands;

            StringBuilder title = new StringBuilder(255);
            try
            {
                User32Windows.GetWindowText(m_HostWindowHwnd, title, title.Capacity + 1);
            }
            catch { }

            Text = "Send Command - " + title.ToString();

            toolTip1.SetToolTip(this, Text);
        }

        #endregion


        #region Override methods

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


        #region Properties

        public bool AutoHide
        {
            get
            {
                return m_AutoHide;
            }

            set
            {
                m_AutoHide = value;
                autoHideToolStripMenuItem.Checked = m_AutoHide;
            }
        }

        #endregion


        #region Public methods

        public void ToggleSending(Switch sw = Switch.Toggle)
        {
            if (sw == Switch.On)
            {
                m_SendCommandEnabled = false;
            }
            else if (sw == Switch.Off)
            {
                m_SendCommandEnabled = true;
            }

            if (m_SendCommandEnabled)
            {
                timer1.Stop();
                m_SendCommandEnabled = false;
                disableSendingToolStripMenuItem.Text = "Enabled sending";
            }
            else
            {
                timer1.Start();
                m_SendCommandEnabled = true;
                Rectangle r;
                User32Windows.GetWindowRect(m_HostWindowHwnd, out r);
                m_HostWindowOffsetX = this.Location.X - r.Left;
                m_HostWindowOffsetY = this.Location.Y - r.Top;
                disableSendingToolStripMenuItem.Text = "Stop tool / move";
            }
        }

        #endregion


        #region Controls' event handlers

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendCommandToolForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_MouseIsDown = true;
            Point p = PointToScreen(e.Location);
            m_DX = this.Location.X - p.X;
            m_DY = this.Location.Y - p.Y;
        }

        private void SendCommandToolForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_MouseIsDown = false;
        }

        private void SendCommandToolForm_MouseMove(object sender, MouseEventArgs e)
        {
            m_MouseIsHover = true;
            Invalidate();

            if (m_MouseIsDown && (!m_SendCommandEnabled))
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X + m_DX, p.Y + m_DY);
            }
        }

        private void toggleSendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleSending();
        }

        private void SendCommandToolForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!m_SendCommandEnabled)
            {
                return;
            }

            if (!User32Windows.SetForegroundWindow(m_HostWindowHwnd))
            {
                MessageBox.Show("Window not found. Try to refresh list.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Thread.Sleep(200);


            var commands = m_Commands.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            for (int i = 0; i < commands.Length; i++)
            {
                SendKeys.SendWait(commands[i]);
            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void selectBackgroundImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Image Files(*.PNG;*.JPG;*.BMP)|*.PNG;*.JPG;*.BMP|All files (*.*)|*.*";

            DialogResult result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackgroundImage = new Bitmap(OpenFileDialog.FileName);
            }
        }

        private void SendCommandToolForm_Paint(object sender, PaintEventArgs e)
        {
            if (m_MouseIsHover)
            {
                e.Graphics.DrawRectangle(m_PenHover, m_DrawRectangle);
            }
            else
            {
                e.Graphics.DrawRectangle(m_PenNormal, m_DrawRectangle);
            }
        }

        private void SendCommandToolForm_MouseLeave(object sender, EventArgs e)
        {
            m_MouseIsHover = false;
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!m_SendCommandEnabled)
            {
                return;
            }

            IntPtr foreWindow = User32Windows.GetForegroundWindow();

            if (((foreWindow == m_HostWindowHwnd)
                    || (foreWindow == this.Handle))
                    && (!User32Windows.IsIconic(m_HostWindowHwnd)))
            {
                if (!this.Visible)
                {
                    this.Show();
                }
                Rectangle r;
                User32Windows.GetWindowRect(m_HostWindowHwnd, out r);
                this.Location = new Point(r.Left + m_HostWindowOffsetX, r.Top + m_HostWindowOffsetY);
            }
            else
            {
                if (this.Visible && m_AutoHide)
                {
                    this.Hide();
                }
            }
        }

        private void autoHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_AutoHide = !m_AutoHide;
            autoHideToolStripMenuItem.Checked = m_AutoHide;
        }

        #endregion

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SendCommandToolPropertiesForm()
            {
                ToolWidht = this.Size.Width,
                ToolHeight = this.Size.Height
            } ;
            var result = settingsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Size = new Size(settingsForm.ToolWidht, settingsForm.ToolHeight);
                this.m_DrawRectangle = new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1);
            }
        }
    }
}
