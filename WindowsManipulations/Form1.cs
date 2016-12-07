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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemoveSpaces_Click(object sender, EventArgs e)
        {
            StringBuilder input = new StringBuilder(richTextBoxIn.Text);

            input.Replace(" ", "");
            input.Replace("\t", "");
            input.Replace("\r\n", "");
            input.Replace("\r", "");
            input.Replace("\n", "");

            richTextBoxOut.Text = input.ToString();
        }
    }
}
