using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsTools
{
    public partial class Base64Form : Form
    {
        public Base64Form()
        {
            InitializeComponent();
        }

        private void btnInputFileSelect_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtInputFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnOutputFileSelect_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputFilePath.Text = saveFileDialog1.FileName;
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string resultStr = String.Empty;

            byte[] bytes = null;

            if (radioInputFile.Checked)
            {
                try
                {
                    bytes = File.ReadAllBytes(txtInputFilePath.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Cannot read the file\n\"" + txtInputFilePath.Text + "\"");
                    return;
                }
            }
            else
            {
                bytes = Encoding.UTF8.GetBytes(txtInput.Text);
            }

            resultStr = Convert.ToBase64String(bytes);

            if (radioOutputFile.Checked)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(txtOutputFilePath.Text))
                    {
                        writer.Write(resultStr);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Cannot write to the file\n\"" + txtOutputFilePath.Text + "\"");
                }
            }
            else
            {
                txtOutput.Text = resultStr;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string base64 = null;

            if (radioInputFile.Checked)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(txtInputFilePath.Text))
                    {
                        base64 = reader.ReadToEnd();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Cannot read the file\n\"" + txtInputFilePath.Text + "\"");
                }
            }
            else
            {
                base64 = txtInput.Text;
            }

            byte[] bytes = Convert.FromBase64String(base64);

            if (radioOutputFile.Checked)
            {
                try
                {
                    File.WriteAllBytes(txtOutputFilePath.Text, bytes);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Cannot write to the file\n\"" + txtOutputFilePath.Text + "\"");
                }
            }
            else
            {
                txtOutput.Text = Encoding.UTF8.GetString(bytes);
            }
        }
    }
}
