using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using System.Data;

using User32Helper;
using System.Text.RegularExpressions;
using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    public partial class LocationAndSizeForm : Form
    {
        #region Fields

        private IntPtr m_Hwnd;
        private Rectangle m_WindowRect;

        private int m_CurrentScreen = 0;

        enum FieldSet
        {
            Old,
            New
        }

        private FieldSet m_CurrentFieldSet;

        #endregion


        #region Constructors

        public LocationAndSizeForm()
        {
            InitializeComponent();

            this.Location = Properties.Settings.Default.LocationAndSizeFormLocation;

            this.toolTip1.SetToolTip(this.groupBoxCurrent,
                "It is possible to copy and paste sets of values:"
                + Environment.NewLine
                + "left; top; width; height");

            this.toolTip1.SetToolTip(this.groupBoxNew,
                "It is possible to use calculation expressions."
                + Environment.NewLine
                + "If skip values, it will be used current");
        }

        public LocationAndSizeForm(IntPtr hwnd)
            : this()
        {
            m_Hwnd = hwnd;
        }

        #endregion


        #region Controls' Events Handlers

        private void LocationAndSizeForm_Shown(object sender, EventArgs e)
        {
            GetCharacteristics();

            ShowScreenResolution(Screen.PrimaryScreen);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            SetLocation();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"screen.png");
        }

        private void LocationAndSizeForm_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocationAndSizeFormLocation = this.Location;
        }

        private void LocationAndSizeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                Properties.Settings.Default.Save();
            }
        }

        private void groupBoxCurrent_Enter(object sender, EventArgs e)
        {
            SetCurrentFieldSetCurrent();
        }

        private void groupBoxNew_Enter(object sender, EventArgs e)
        {
            SetCurrentFieldSetNew();
        }

        private void groupBoxCurrent_MouseHover(object sender, EventArgs e)
        {
            SetCurrentFieldSetCurrent();
        }

        private void groupBoxNew_MouseHover(object sender, EventArgs e)
        {
            SetCurrentFieldSetNew();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (m_CurrentFieldSet)
            {
                case FieldSet.Old:
                    FieldsCopyToClipboard(txtCurrentLeft, txtCurrentTop, txtCurrentWidth, txtCurrentHeight);
                    break;
                case FieldSet.New:
                    FieldsCopyToClipboard(txtNewLeft, txtNewTop, txtNewWidth, txtNewHeight);
                    break;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (m_CurrentFieldSet)
            {
                case FieldSet.Old:
                    FieldsPasteFromClipboard(txtCurrentLeft, txtCurrentTop, txtCurrentWidth, txtCurrentHeight);
                    break;
                case FieldSet.New:
                    FieldsPasteFromClipboard(txtNewLeft, txtNewTop, txtNewWidth, txtNewHeight);
                    break;
            }
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
        }

        private void ShowScreenResolution(Screen screen)
        {
            Rectangle rect = screen.Bounds;
            lblResolution.Text = "Screen resolution: " + rect.Width + "x" + rect.Height
                + " (" + screen.DeviceName + ")*";
        }

        private void SetLocation()
        {
            DataTable dt = new DataTable();

            int left = txtNewLeft.Text != "" ? (int)dt.Compute(txtNewLeft.Text, "") : m_WindowRect.Left;
            int top = txtNewTop.Text != "" ? (int)dt.Compute(txtNewTop.Text, "") : m_WindowRect.Top;
            int width = txtNewWidth.Text != "" ? (int)dt.Compute(txtNewWidth.Text, "") : m_WindowRect.Width - m_WindowRect.Left;
            int height = txtNewHeight.Text != "" ? (int)dt.Compute(txtNewHeight.Text, "") : m_WindowRect.Height - m_WindowRect.Top;

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

        private void FieldsCopyToClipboard(TextBox tL, TextBox tT, TextBox tW, TextBox tH)
        {
            Clipboard.SetText(String.Format("{0}; {1}; {2}; {3}", tL.Text, tT.Text, tW.Text, tH.Text));
        }

        private void FieldsPasteFromClipboard(TextBox tL, TextBox tT, TextBox tW, TextBox tH)
        {
            string clipboard = Clipboard.GetText();

            Regex re = new Regex(@"(-?\d+)(?:(?:; )*)");
            var matches = re.Matches(clipboard);

            if (matches.Count != 4)
            {
                MessageBox.Show("Your data must be in format:\n"
                    + "left; top; width; height",
                    "Location And Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tL.Text = matches[0].Groups[1].Value;
            tT.Text = matches[1].Groups[1].Value;
            tW.Text = matches[2].Groups[1].Value;
            tH.Text = matches[3].Groups[1].Value;
        }

        private void SetCurrentFieldSetCurrent()
        {
            m_CurrentFieldSet = FieldSet.Old;

            ((myGroupBox)groupBoxCurrent).BorderColor = Color.DarkGreen;
            ((myGroupBox)groupBoxNew).BorderColor = SystemColors.ActiveBorder;

            groupBoxCurrent.Invalidate();
            groupBoxNew.Invalidate();
        }

        private void SetCurrentFieldSetNew()
        {
            m_CurrentFieldSet = FieldSet.New;

            ((myGroupBox)groupBoxNew).BorderColor = Color.DarkGreen;
            ((myGroupBox)groupBoxCurrent).BorderColor = SystemColors.ActiveBorder;

            groupBoxNew.Invalidate();
            groupBoxCurrent.Invalidate();
        }

        #endregion


        #region Public methods

        public void SelectWindow(IntPtr hwnd)
        {
            m_Hwnd = hwnd;
            GetCharacteristics();
        }

        #endregion
    }
}
