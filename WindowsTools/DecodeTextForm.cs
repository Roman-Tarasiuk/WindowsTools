using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

using User32Helper;
using WindowsTools.Infrastructure;
using System.Configuration;

namespace WindowsTools
{
    public partial class DecodeTextForm : Form
    {
        #region Constructors

        public DecodeTextForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Controls' event handlers

        private void btnDecode_Click(object sender, EventArgs e)
        {
            //

            var inputEncodingStr = txtInputEncoding.Text;

            Encoding inputEncoding = null;

            try
            {
                inputEncoding = Encoding.GetEncoding(inputEncodingStr);
            }
            catch
            {
                MessageBox.Show("Invalid encoding name.");
                return;
            }

            //

            var outputEncodingStr = txtOutputEncoding.Text;

            Encoding outputEncoding = null;
            try
            {
                outputEncoding = Encoding.GetEncoding(outputEncodingStr);
            }
            catch
            {
                MessageBox.Show("Invalid encoding name.");
            }

            //

            txtOutput.Text = DecodeString(txtInput.Text, inputEncoding, outputEncoding);
        }

        private void chkWordwrap_Click(object sender, EventArgs e)
        {
            this.txtInput.WordWrap = this.chkWordwrap.Checked;
            this.txtOutput.WordWrap = this.chkWordwrap.Checked;
        }

        public static string DecodeString(string input, Encoding inputEncoding, Encoding outputEncoding)
        {
                byte[] inputBytes = inputEncoding.GetBytes(input);
                Encoding.UTF8.GetString(inputBytes, 0, inputBytes.Length);

                var propEncodeString = outputEncoding.GetString(inputBytes, 0, inputBytes.Length);

                return propEncodeString;
        }
    }

    #endregion
}
