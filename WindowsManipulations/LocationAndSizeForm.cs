using System;
using System.Drawing;
using System.Windows.Forms;

using User32Helper;

namespace WindowsManipulations
{
    public partial class LocationAndSizeForm : Form, IShowForm
    {
        #region Fields

        private IntPtr m_Hwnd;
        private Rectangle m_WindowRect;

        private int m_CurrentScreen = 0;

        #endregion


        #region Implemented interfaces

        public bool IsShown { get; protected set; }

        #endregion


        #region Constructors

        public LocationAndSizeForm()
        {
            InitializeComponent();

            IsShown = false;
        }

        public LocationAndSizeForm(IntPtr hwnd)
            : this()
        {
            m_Hwnd = hwnd;
        }

        #endregion


        #region Controls Events Handlers

        private void LocationAndSizeForm_Shown(object sender, EventArgs e)
        {
            GetCharacteristics();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            SetLocation();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            IsShown = true;
        }

        private void lblResolution_Click(object sender, EventArgs e)
        {
            m_CurrentScreen++;
            if (m_CurrentScreen >= Screen.AllScreens.Length)
            {
                m_CurrentScreen = 0;
            }

            Screen screen = Screen.AllScreens[m_CurrentScreen];
            ShowScreenResolution(screen);
        }

        private void txtNewLeft_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeydown(e);
        }

        private void txtNewTop_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeydown(e);
        }

        private void txtNewWidth_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeydown(e);
        }

        private void txtNewHeight_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeydown(e);
        }

        #endregion


        #region Helper functions

        private void GetCharacteristics()
        {
            User32Windows.GetWindowRect(m_Hwnd, out m_WindowRect);

            txtCurrentLeft.Text = m_WindowRect.Left.ToString();
            txtCurrentTop.Text = m_WindowRect.Top.ToString();
            txtCurrentWidth.Text = (m_WindowRect.Width - m_WindowRect.Left).ToString();
            txtCurrentHeight.Text = (m_WindowRect.Height - m_WindowRect.Top).ToString();

            ShowScreenResolution(Screen.PrimaryScreen);
        }

        private void ShowScreenResolution(Screen screen)
        {
            Rectangle rect = screen.WorkingArea;
            lblResolution.Text = "Screen resolution: " + rect.Width + "x" + rect.Height;
        }

        private void SetLocation()
        {
            int left = txtNewLeft.Text != "" ? int.Parse(txtNewLeft.Text) : m_WindowRect.Left;
            int top = txtNewTop.Text != "" ? int.Parse(txtNewTop.Text) : m_WindowRect.Top;
            int width = txtNewWidth.Text != "" ? int.Parse(txtNewWidth.Text) : m_WindowRect.Width - m_WindowRect.Left;
            int height = txtNewHeight.Text != "" ? int.Parse(txtNewHeight.Text) : m_WindowRect.Height - m_WindowRect.Top;

            User32Windows.SetWindowPos(m_Hwnd, User32Windows.HWND_TOP, left, top, width, height, User32Windows.SWP_NOZORDER);
            GetCharacteristics();
        }

        private void HandleKeydown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetLocation();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        #endregion


        #region Methods

        public void SelectWindow(IntPtr hwnd)
        {
            m_Hwnd = hwnd;
            GetCharacteristics();
        }

        #endregion
    }
}
