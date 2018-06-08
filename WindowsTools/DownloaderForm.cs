﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class DownloaderForm : Form
    {
        public DownloaderForm()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
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

                foreach (var f in list)
                {
                    var filename = Path.GetFileName(f);

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
                MessageBox.Show("Successfully finished.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Finished with error(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtLocalPath.Text;

            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtLocalPath.Text = folderBrowserDialog1.SelectedPath;
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
            }
            else
            {
                txtProxy.Enabled = false;
                txtLogin.Enabled = false;
                txtPassword.Enabled = false;

                lblProxy.Enabled = false;
                lblLogin.Enabled = false;
                lblPassword.Enabled = false;
            }
        }

        private void DownloaderForm_Shown(object sender, EventArgs e)
        {
            txtLocalPath.Text = AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
