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
    }
}
