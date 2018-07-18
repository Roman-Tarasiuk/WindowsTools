using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class PromptForm : Form
    {
        public string Description { get; set; } = String.Empty;
        public string UserInput { get; set; } = String.Empty;

        public PromptForm()
        {
            InitializeComponent();

            lblDescription.Text = this.Description;
            txtUserInput.Text = this.UserInput;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Description = lblDescription.Text;
            this.UserInput = txtUserInput.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
