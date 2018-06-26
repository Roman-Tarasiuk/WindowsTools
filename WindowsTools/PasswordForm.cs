using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using User32Helper;
using WindowsTools.Infrastructure;

namespace WindowsTools
{
    public partial class PasswordForm : Form, IProgramSettings
    {
        #region Fields

        static readonly TimeSpan defaultWrongPassDelay = new TimeSpan(0, 0, 0, 0, 5000);

        private List<PasswordInfo> m_Passwords = new List<PasswordInfo>();
        private string m_Pin = String.Empty;

        private TimeSpan m_PinTimeSpan = PasswordForm.defaultWrongPassDelay;
        private DateTime m_BlockStartTime;
        private bool m_EnablePasswordCopy = true;

        private Color m_BackColor;

        private PinForm m_PinForm;

        private List<String> m_PasswordRepresentation = new List<string>();

        private bool m_ActivateLastActiveWindow = true;

        #endregion


        #region Public Properties and Methods

        public event EventHandler PasswordsChanged;
        public event EventHandler SettingsChanged;

        public List<String> PasswordsRepresentation
        {
            get
            {
                bool refresh = false;

                if (m_PasswordRepresentation.Count != m_Passwords.Count || m_Passwords.Count == 0)
                {
                    refresh = true;
                }

                if (refresh)
                {
                    m_PasswordRepresentation.Clear();

                    foreach (var p in m_Passwords)
                    {
                        m_PasswordRepresentation.Add(p.Description + (p.Public ? " : " + p.Password : " : *******"));
                    }
                }

                return m_PasswordRepresentation;
            }
        }

        public void CopyPasswordToClipboard(int index = -1)
        {
            if (listBox1.SelectedIndex == -1 && index == -1)
            {
                return;
            }

            if (index == -1)
            {
                index = listBox1.SelectedIndex;
            }
            else if (index < 0 || index >= listBox1.Items.Count)
            {
                return;
            }


            if (m_Passwords[index].Public)
            {
                FlashWindow();
            }
            else
            {

                if (!m_EnablePasswordCopy)
                {
                    MessageBox.Show("You have inputted wrong pin.\n"
                        + "Wait "
                            + ((int)((m_PinTimeSpan.TotalMilliseconds - (DateTime.Now - m_BlockStartTime).TotalMilliseconds) / 1000)).ToString()
                            + " seconds and try again...",
                        "Incorrect pin",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    return;
                }

                string pin = GetPin("Pin for password", "Enter pin");

                if (pin == String.Empty)
                {
                    return;
                }

                if (pin != m_Pin)
                {
                    m_PinTimeSpan += PasswordForm.defaultWrongPassDelay;
                    timer1.Interval = (int)m_PinTimeSpan.TotalMilliseconds;
                    m_EnablePasswordCopy = false;
                    m_BlockStartTime = DateTime.Now;

                    timer1.Start();

                    MessageBox.Show("You have inputted wrong pin.\n"
                        + "Wait " + (m_PinTimeSpan.TotalMilliseconds / 1000).ToString() + " seconds and try again.",
                        "Incorrect pin",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    m_PinTimeSpan = PasswordForm.defaultWrongPassDelay;
                }
            }

            Clipboard.SetText(m_Passwords[index].Password);

            if (m_ActivateLastActiveWindow)
            {
                ActivatePreviousWindow();
            }
        }

        #endregion


        #region Protected Methods

        protected void OnPasswordsChanged()
        {
            if (PasswordsChanged != null)
            {
                PasswordsChanged.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion


        #region Constructors

        public PasswordForm()
        {
            InitializeComponent();

            this.Location = Properties.Settings.Default.PasswordsForm_Location;
        }

        #endregion


        #region Controls' event handlers

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPasswordEntry();
        }

        private void PasswordForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            m_EnablePasswordCopy = true;
        }

        private void PasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_Passwords.Count > 0)
            {
                DialogResult result = MessageBox.Show("You have saved passwords. Are you sure to exit?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

            txtPassword.Focus();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CopyPasswordToClipboard();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemovePasswordEntry();
        }

        private void timerFlash_Tick(object sender, EventArgs e)
        {
            timerFlash.Stop();
            timerFlash.Enabled = false;
            this.BackColor = m_BackColor;
        }

        private void PasswordForm_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                Properties.Settings.Default.PasswordsForm_Location = this.Location;

                if (SettingsChanged != null)
                {
                    SettingsChanged.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void PasswordForm_Shown(object sender, EventArgs e)
        {
            txtDescription.Focus();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                CopyPasswordToClipboard();
            }
        }

        private void copyDescriptionToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyDescriptionToClipboard();
        }

        private void PasswordForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.ActiveControl == listBox1)
                {
                    CopyPasswordToClipboard();
                }
                else
                {
                    AddPasswordEntry();
                }
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }

            MoveUp(listBox1.SelectedIndex);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }

            MoveDown(listBox1.SelectedIndex);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var passwordSettingsForm = new PasswordSettingsForm { ActivateLastWindow = m_ActivateLastActiveWindow };

            var result = passwordSettingsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_ActivateLastActiveWindow = passwordSettingsForm.ActivateLastWindow;
            }
        }

        #endregion


        #region Helper methods

        private void FlashWindow()
        {
            m_BackColor = this.BackColor;
            this.BackColor = Color.DarkGray;
            timerFlash.Enabled = true;
            timerFlash.Start();
        }

        private void CopyDescriptionToClipboard()
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }

            Clipboard.SetText(m_Passwords[listBox1.SelectedIndex].Description);
            FlashWindow();
        }

        private string GetPin(string pinCaption, string pinPrompt)
        {
            m_PinForm = (PinForm)User32Windows.GetForm(m_PinForm, typeof(PinForm));
            m_PinForm.StartPosition = FormStartPosition.Manual;
            if (this.Visible)
            {
                m_PinForm.DesktopLocation = this.DesktopLocation;
            }
            m_PinForm.Text = pinCaption;
            m_PinForm.Prompt = pinPrompt;
            m_PinForm.Pin = "";

            DialogResult result = m_PinForm.ShowDialog();

            if (result != DialogResult.OK)
            {
                return "";
            }

            return m_PinForm.Pin;
        }

        private void AddPasswordEntry()
        {
            if (txtDescription.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("You must specify description and password.");
                return;
            }

            if (m_Pin == String.Empty && !chkShowPassword.Checked)
            {
                string pin1 = GetPin("Pin for password", "Enter pin");

                if (pin1 == "")
                {
                    return;
                }

                string pin2 = GetPin("Pin for password", "Confirm pin");

                if (pin1 != pin2)
                {
                    MessageBox.Show("Pin and its confirmation do not match.\nPlease try again.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                m_Pin = pin1;
            }

            listBox1.Items.Add(txtDescription.Text + (chkShowPassword.Checked ? " : " + txtPassword.Text : " : *******"));
            m_Passwords.Add(new PasswordInfo { Description = txtDescription.Text, Password = txtPassword.Text, Public = chkShowPassword.Checked });

            txtDescription.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            txtDescription.Focus();

            m_PasswordRepresentation.Clear();

            OnPasswordsChanged();
        }

        private void RemovePasswordEntry()
        {
            var selIndex = listBox1.SelectedIndex;

            if (selIndex == -1)
            {
                return;
            }

            m_Passwords.RemoveAt(selIndex);
            listBox1.Items.RemoveAt(selIndex);

            m_PasswordRepresentation.Clear();

            OnPasswordsChanged();
        }

        private void MoveUp(int selectedIndex)
        {
            if (selectedIndex == 0)
            {
                return;
            }

            var tmp = m_Passwords[selectedIndex];
            m_Passwords.RemoveAt(selectedIndex);
            m_Passwords.Insert(selectedIndex - 1, tmp);

            listBox1.Items.RemoveAt(selectedIndex);
            listBox1.Items.Insert(selectedIndex - 1, tmp.Description + (tmp.Public ? " : " + tmp.Password : " : *******"));
            listBox1.SelectedIndex = selectedIndex - 1;
        }

        private void MoveDown(int selectedIndex)
        {
            if (selectedIndex == (m_Passwords.Count - 1))
            {
                return;
            }

            var tmp = m_Passwords[selectedIndex];
            m_Passwords.RemoveAt(selectedIndex);
            m_Passwords.Insert(selectedIndex + 1, tmp);

            listBox1.Items.RemoveAt(selectedIndex);
            listBox1.Items.Insert(selectedIndex + 1, tmp.Description + (tmp.Public ? " : " + tmp.Password : " : *******"));
            listBox1.SelectedIndex = selectedIndex + 1;
        }

        private void ActivatePreviousWindow(IntPtr hwnd = default(IntPtr))
        {
            if (hwnd == IntPtr.Zero)
            {
                hwnd = User32Windows.GetLastActiveWindow(hwndExcept: this.Handle).Handle;
            }

            User32Windows.SetForegroundWindow(hwnd);
        }
    }

    #endregion
}
