using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User32Helper;

namespace WindowsTools
{
    public partial class TransparentWindowToolForm : Form
    {

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetLayeredWindowAttributes(IntPtr hwnd, out uint crKey, out byte bAlpha, out uint dwFlags);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;

        private System.Windows.Forms.Panel panel1;


        private bool m_FirstRun = true;
        private IntPtr m_Handle;
        private byte m_Transparency = 255;

        private bool m_AltKey = false;
        private bool m_CtrlKey = false;

        public TransparentWindowToolForm(IntPtr handle)
        {
            m_Handle = handle;

            InitializeComponent();

            InitializeAdditionalComponents();
        }

        private void InitializeAdditionalComponents()
        {
            // The panel for moving the form by any point.

            this.panel1 = new TransparentDraggablePanel(this)
            {
                Name = "panel1",
                Location = new System.Drawing.Point(0, 0),
                Size = this.Size,
                TabIndex = 1
            };

            var icon = User32Windows.GetIcon(m_Handle);

            if (icon != null)
            {
                this.pictureBox1.Image = icon.ToBitmap();
            }

            this.Controls.Add(this.panel1);

            panel1.BringToFront();

            this.panel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.TransparentWindowToolForm_MouseWheel);
        }

        private void TransparentWindowToolForm_MouseWheel(object sender, MouseEventArgs e)
        {
            byte tmp = m_Transparency;
            byte tmp2 = 0;
            byte step = 10;

            if (m_AltKey)
            {
                step = 30;
            }
            else if (m_CtrlKey)
            {
                step = 1;
            }

            if (e.Delta > 0)
            {
                tmp2 = (byte)(m_Transparency + step);

                if (tmp2 >= m_Transparency)
                {
                    m_Transparency = tmp2;
                }
            }
            else if (e.Delta < 0)
            {
                tmp2 = (byte)(m_Transparency - step);

                if (tmp2 <= m_Transparency)
                {
                    m_Transparency = tmp2;
                }
            }

            if (tmp != m_Transparency)
            {
                ChangeTransparency(m_Transparency);
            }
        }

        private void ChangeTransparency(byte transparency)
        {
            uint tmp1 = 0;
            uint tmp2 = 0;
            byte currentTransparency;
            //GetLayeredWindowAttributes(m_Handle, out tmp1, out currentTransparency, out tmp2);

            // var promptForm = new PromptForm() { Description = "Enter transparency 0-255:", UserInput = currentTransparency.ToString() };
            // 
            // var result = promptForm.ShowDialog();
            //
            // if (int.TryParse(promptForm.UserInput, out transparency))

            if (m_FirstRun)
            {
                SetWindowLong(m_Handle, GWL_EXSTYLE, GetWindowLong(m_Handle, GWL_EXSTYLE).ToInt32() ^ WS_EX_LAYERED);
                m_FirstRun = false;
            }

            SetLayeredWindowAttributes(m_Handle, 0, transparency, LWA_ALPHA);
        }

        private void TransparentWindowToolForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                m_CtrlKey = true;
            }
            if (e.Alt)
            {
                m_AltKey = true;
            }
        }

        private void TransparentWindowToolForm_KeyUp(object sender, KeyEventArgs e)
        {
            m_AltKey = false;
            m_CtrlKey = false;
        }

        private void resetTransparencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.m_FirstRun = true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topmostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            this.topmostToolStripMenuItem.Checked = this.TopMost;
        }

        private void showInTaskbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = !this.ShowInTaskbar;
            this.showInTaskbarToolStripMenuItem.Checked = this.ShowInTaskbar;
        }
    }
}
