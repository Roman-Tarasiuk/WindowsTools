using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsManipulations
{
    public partial class PasswordForm : Form, IShowForm
    {
        private List<PasswordInfo> m_Passwords = new List<PasswordInfo>();
        private string m_Pin = "";
        private TimeSpan m_PinTimeSpan = new TimeSpan(0, 0, 0, 0, 5000);
        private bool m_EnablePasswordCopy = true;
        private DateTime m_BlockStartTime;
        private Color m_BackColor;

        public PasswordForm()
        {
            InitializeComponent();

            IsShown = false;
        }

        public bool IsShown { get; protected set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("You must specify description and password.");
                return;
            }

            if (m_Pin == "")
            {
                PinForPasswordsForm pinForm = new PinForPasswordsForm();
                pinForm.StartPosition = FormStartPosition.Manual;
                pinForm.DesktopLocation = this.DesktopLocation;

                DialogResult result = pinForm.ShowDialog();

                if (result != DialogResult.OK)
                {
                    return;
                }

                if (pinForm.Password == "")
                {
                    MessageBox.Show("You did'n specified pin. Password was not saved.");
                    return;
                }

                m_Pin = pinForm.Password;
            }

            listBox1.Items.Add(txtDescription.Text + (chkShowPassword.Checked ? " : " + txtPassword.Text : " : *******"));
            m_Passwords.Add(new PasswordInfo { Description = txtDescription.Text, Password = txtPassword.Text, Public = chkShowPassword.Checked });

            txtDescription.Clear();
            txtPassword.Clear();
        }



        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyPasswordToClipboard();
        }

        private void CopyPasswordToClipboard()
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }

            if (m_Passwords[listBox1.SelectedIndex].Public)
            {
                Clipboard.SetText(m_Passwords[listBox1.SelectedIndex].Password);
                FlashWindow();
                return;
            }

            if (!m_EnablePasswordCopy)
            {
                MessageBox.Show("You have inputted wrong pin.\n"
                    + "Wait " + ((int)((m_PinTimeSpan.TotalMilliseconds - (DateTime.Now - m_BlockStartTime).TotalMilliseconds) / 1000)).ToString() + " seconds and try again...");

                return;
            }

            PinForPasswordsForm pinForm = new PinForPasswordsForm();
            pinForm.StartPosition = FormStartPosition.Manual;
            pinForm.DesktopLocation = this.DesktopLocation;

            DialogResult result = pinForm.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            if (pinForm.Password != m_Pin)
            {
                m_PinTimeSpan += m_PinTimeSpan;
                timer1.Interval = (int)m_PinTimeSpan.TotalMilliseconds;
                m_EnablePasswordCopy = false;
                m_BlockStartTime = DateTime.Now;

                timer1.Start();

                MessageBox.Show("You have inputted wrong pin.\n"
                    + "Wait " + (m_PinTimeSpan.TotalMilliseconds / 1000).ToString() + " seconds and try again.");

                return;
            }

            Clipboard.SetText(m_Passwords[listBox1.SelectedIndex].Password);
        }

        private void FlashWindow()
        {
            m_BackColor = this.BackColor;
            this.BackColor = Color.DarkGray;
            timerFlash.Enabled = true;
            timerFlash.Start();
        }

        private void PasswordForm_Shown(object sender, EventArgs e)
        {
            IsShown = true;
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
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CopyPasswordToClipboard();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }

            m_Passwords.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void timerFlash_Tick(object sender, EventArgs e)
        {
            timerFlash.Stop();
            timerFlash.Enabled = false;
            this.BackColor = m_BackColor;
        }

        private void PasswordForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
    }
}
