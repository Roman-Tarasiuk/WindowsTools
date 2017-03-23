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
    public partial class PinForm : Form
    {
        private string m_Pin;
        public string Pin
        {
            get { return m_Pin; }
            set { m_Pin = value; txtPin.Text = m_Pin; }
        }

        public string Prompt
        {
            get
            {
                return lblPrompt.Text;
            }
            set
            {
                lblPrompt.Text = value + ":";
            }
        }


        public PinForm()
        {
            InitializeComponent();

            Pin = "";
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            Pin = txtPin.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pin = txtPin.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
