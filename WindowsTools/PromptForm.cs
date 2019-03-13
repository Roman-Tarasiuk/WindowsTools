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
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserInput { get; set; }

        public PromptForm()
        {
            InitializeComponent();

            Description = String.Empty;
            UserInput = String.Empty;
            Title = "Prompt";

            lblDescription.Text = this.Description;
            txtUserInput.Text = this.UserInput;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.UserInput = txtUserInput.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PromptForm_Shown(object sender, EventArgs e)
        {
            lblDescription.Text = this.Description;
            txtUserInput.Text = this.UserInput;
            this.Text = this.Title;
        }
    }
}
