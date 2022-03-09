using FileInfoEx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class FileInfoForm : Form
    {
        public FileInfoForm()
        {
            InitializeComponent();
        }

        // Event handlers.

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            if (this.radioDirectory.Checked)
            {
                var dlg = new FolderBrowserDialog();
                var result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.txtPath.Text = dlg.SelectedPath;
                }
            }
            else
            {
                var fileDialog = new OpenFileDialog();
                var result = fileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.txtPath.Text = fileDialog.FileName;
                }
            }
        }

        private void btnOpenPathOutput_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.FileName = this.txtPathOutput.Text;
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtPathOutput.Text = fileDialog.FileName;
            }
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            var fi = new FileInfoDetails();

            if (chkSize.Checked)
            {
                fi |= FileInfoDetails.Size;
            }
            if (chkMD5.Checked)
            {
                fi |= FileInfoDetails.MD5;
            }
            if (chkSHA256.Checked)
            {
                fi |= FileInfoDetails.SHA256;
            }
            if (chkCreationTime.Checked)
            {
                fi |= FileInfoDetails.CreationTime;
            }
            if (chkCreationTime.Checked)
            {
                fi |= FileInfoDetails.LastAccessTime;
            }
            if (chkLastWriteTime.Checked)
            {
                fi |= FileInfoDetails.LastWriteTime;
            }

            if (this.radioDirectory.Checked)
            {
                try
                {
                    if (comboBox1.SelectedIndex == 0) // File.
                    {
                        FileInfoEx.FileInfoEx.GetDirectoryInfo(this.txtPath.Text, fi, this.txtPathOutput.Text);
                    }
                    else // Textbox.
                    {
                        txtInfo.Text = FileInfoEx.FileInfoEx.GetDirectoryInfo(this.txtPath.Text, fi);
                    }
                    MessageBox.Show("Done!");
                }
                catch (Exception ex)
                {
                    txtInfo.Text = "An error occured: " + ex.ToString();
                }
            }
            else // radioFile or radioFilesList.
            {
                try
                {
                    string info = null;
                    
                    if (this.radioFile.Checked)
                    {
                        info = FileInfoEx.FileInfoEx.GetFileInfo(this.txtPath.Text, fi);
                    }
                    else // radioFilesList
                    {
                        info = FileInfoEx.FileInfoEx.GetFilesListInfo(this.txtPath.Text, fi);
                    }

                    // Output results.

                    if (comboBox1.SelectedIndex == 0) // File.
                    {
                        using (var writer = new StreamWriter(txtPathOutput.Text))
                        {
                            writer.Write(info);
                        }
                    }
                    else // Textbox...
                    {
                        this.txtInfo.Text = info;
                    }
                }
                catch (Exception ex)
                {
                    txtInfo.Text = "An error occured: " + ex.ToString();
                }
            }
        }

        private void FileInfoForm_Shown(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 1;
        }
    }
}
