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

        private bool m_FirstRun = true;
        private IntPtr m_Handle;

        public TransparentWindowToolForm(IntPtr handle)
        {
            m_Handle = handle;

            InitializeComponent();
        }

        private void RunTransparencyForm(IntPtr handle)
        {
            uint tmp1 = 0;
            uint tmp2 = 0;
            byte currentTransparency;
            GetLayeredWindowAttributes(handle, out tmp1, out currentTransparency, out tmp2);

            var promptForm = new PromptForm() { Description = "Enter transparency 0-255:", UserInput = currentTransparency.ToString() };

            var result = promptForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int transparency;
                if (int.TryParse(promptForm.UserInput, out transparency))
                {
                    if (m_FirstRun)
                    {
                        SetWindowLong(handle, GWL_EXSTYLE, GetWindowLong(handle, GWL_EXSTYLE).ToInt32() ^ WS_EX_LAYERED);
                        m_FirstRun = false;
                    }
                    SetLayeredWindowAttributes(handle, 0, (byte)transparency, LWA_ALPHA);
                }
            }
        }
    }
}
