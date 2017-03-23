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

namespace WindowsManipulations
{
    public partial class SendCommandToolForm : Form
    {
        private IntPtr m_Hwnd;
        private string m_Commands;

        private bool m_MouseIsDown = false;
        private bool m_MouseIsHover = false;
        private bool m_SendCommandEnabled = true;

        private Pen m_PenNormal = new Pen(Color.White);
        private Pen m_PenHover = new Pen(Color.Lime);
        private Rectangle m_DrawRectangle = new Rectangle(0, 0, 19, 19);

        private int m_DX;
        private int m_DY;

        public SendCommandToolForm(IntPtr hwnd, string commands)
        {
            InitializeComponent();

            m_Hwnd = hwnd;
            m_Commands = commands;

            StringBuilder title = new StringBuilder(255);
            try
            {
                User32Windows.GetWindowText(m_Hwnd, title, title.Capacity + 1);
            }
            catch { }

            Text = "Send Command - " + title.ToString();

            toolTip1.SetToolTip(this, Text);
        }

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

        private void disableSendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_SendCommandEnabled)
            {
                m_SendCommandEnabled = false;
                disableSendingToolStripMenuItem.Text = "Enabled sending";
            }
            else
            {
                m_SendCommandEnabled = true;
                disableSendingToolStripMenuItem.Text = "Move tool";
            }
        }

        private void SendCommandToolForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!m_SendCommandEnabled)
            {
                return;
            }

            if (!User32Windows.SetForegroundWindow(m_Hwnd))
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
    }
}
