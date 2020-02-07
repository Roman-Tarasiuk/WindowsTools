using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WindowsTools.Infrastructure;
using User32Helper;

namespace WindowsTools
{
    public partial class DownloaderForm : Form, IProgramSettings
    {
        private Color m_ErrorBackground = Color.FromArgb(255, 192, 192);

        public DownloaderForm()
        {
            InitializeComponent();

            txtProxy.Text = Properties.Settings.Default.DownloaderForm_Proxy;
            txtLogin.Text = Properties.Settings.Default.DownloaderForm_Username;
            txtLocalPath.Text = Properties.Settings.Default.DownloaderForm_LocalPath;

            lblDownloadPercentage.Parent = progressBar1;
            lblDownloadPercentage.Location = new Point(5, 3);
        }

        public event EventHandler SettingsChanged;

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            ToggleDownloadProgress(true);

            var finishedSuccessfully = true;

            var list = txtUrl.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            var proxy = txtProxy.Text;
            var login = txtLogin.Text;
            var password = txtPassword.Text;

            using (WebClient wc = new WebClient())
            {
                if (chkUseProxy.Checked)
                {
                    WebProxy p = new WebProxy(proxy, true);
                    p.Credentials = new NetworkCredential(login, password);
                    WebRequest.DefaultWebProxy = p;
                    wc.Proxy = p;
                }
                else
                {
                    WebRequest.DefaultWebProxy = null;
                    wc.UseDefaultCredentials = true;
                }

                if (txtSiteLogin.Text != String.Empty)
                {
                    wc.Credentials = new NetworkCredential(txtSiteLogin.Text, txtSitePassword.Text);
                }

                var filename = "";

                DownloadProgressChangedEventHandler progressTracker = (senderTracker, progressChangesArgs) =>
                {
                    var percent = progressChangesArgs.ProgressPercentage;

                    progressBar1.Value = percent;
                    lblDownloadPercentage.Text = percent.ToString() + "% - " + filename;
                };

                wc.DownloadProgressChanged += progressTracker;

                foreach (var f in list)
                {
                    filename = Path.GetFileName(f);

                    try
                    {
                        await wc.DownloadFileTaskAsync(new Uri(f), Path.Combine(txtLocalPath.Text, filename));
                    }
                    catch (WebException exception)
                    {
                        txtUrl.Text += "\r\n\r\n** Error:\r\n" + exception.Message
                            + "\r\n** Stack trace:\r\n" + exception.StackTrace
                            + "\r\n** Response:\r\n" + exception.Response
                            + (exception.InnerException != null ? "\r\n** Inner exception:\r\n" + exception.InnerException.ToString()
                                + (exception.InnerException.InnerException != null ? "\r\n** Inner exception > Inner exception:\r\n" + exception.InnerException.InnerException.ToString() : "") : "")
                            + "\r\n";

                        finishedSuccessfully = false;
                    }
                    catch (Exception exception)
                    {
                        txtUrl.Text += "\r\n\r\n** Error Other:\r\n" + exception.Message
                            + "\r\n";

                        finishedSuccessfully = false;
                    }
                }
            }

            if (finishedSuccessfully)
            {
                if (User32Windows.IsIconic(this.Handle))
                {
                    User32Windows.ShowWindow(this.Handle, User32Windows.SW_RESTORE);
                }
                else
                {
                    User32Windows.ShowWindow(this.Handle, User32Windows.SW_SHOW);
                }
                User32Windows.SetForegroundWindow(this.Handle);

                MessageBox.Show("Successfully finished.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Finished with error(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ToggleDownloadProgress(false);
        }

        private void ToggleDownloadProgress(bool on)
        {
            if (on)
            {
                progressBar1.Visible = true;
                lblDownloadPercentage.Visible = true;
            }
            else
            {
                progressBar1.Visible = false;
                lblDownloadPercentage.Visible = false;
            }
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtLocalPath.Text;

            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtLocalPath.Text = folderBrowserDialog1.SelectedPath;

                Properties.Settings.Default.DownloaderForm_LocalPath = txtLocalPath.Text;

                if (SettingsChanged != null)
                {
                    SettingsChanged.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void chkUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseProxy.Checked)
            {
                txtProxy.Enabled = true;
                txtLogin.Enabled = true;
                txtPassword.Enabled = true;

                lblProxy.Enabled = true;
                lblLogin.Enabled = true;
                lblPassword.Enabled = true;

                SetPasswordBackground(true);
            }
            else
            {
                txtProxy.Enabled = false;
                txtLogin.Enabled = false;
                txtPassword.Enabled = false;

                lblProxy.Enabled = false;
                lblLogin.Enabled = false;
                lblPassword.Enabled = false;

                SetPasswordBackground(false);
            }
        }

        private void txtProxy_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DownloaderForm_Proxy = txtProxy.Text;

            if (SettingsChanged != null)
            {
                SettingsChanged.Invoke(this, EventArgs.Empty);
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DownloaderForm_Username = txtLogin.Text;

            if (SettingsChanged != null)
            {
                SettingsChanged.Invoke(this, EventArgs.Empty);
            }
        }

        private void txtLocalPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DownloaderForm_LocalPath = txtLocalPath.Text;

            if (SettingsChanged != null)
            {
                SettingsChanged.Invoke(this, EventArgs.Empty);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            SetPasswordBackground();
        }


        private void SetPasswordBackground(bool editEnabled = true)
        {
            if (txtPassword.Text != String.Empty || !editEnabled)
            {
                txtPassword.BackColor = SystemColors.Window;
            }
            else
            {
                txtPassword.BackColor = m_ErrorBackground;
            }
        }
    }

    public class TransparentLabel : Label
    {
        public TransparentLabel()
        {
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ExStyle |= 0x20;  // Turn on WS_EX_TRANSPARENT
                return parms;
            }
        }
    }
}
