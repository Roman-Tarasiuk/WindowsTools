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
    public partial class PinForPasswordsForm : Form
    {
        public string Password { get; private set; }

        public PinForPasswordsForm()
        {
            InitializeComponent();

            Password = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Password = txtPassword.Text;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password = txtPassword.Text;
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
