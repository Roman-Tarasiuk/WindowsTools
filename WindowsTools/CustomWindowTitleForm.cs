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
    public partial class CustomWindowTitleForm : Form
    {
        public string CurrentTitle { get; set; }
        public string NewTitle { get; set; }

        public CustomWindowTitleForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NewTitle = txtNewTitle.Text;
        }

        private void CustomWindowTitleForm_Shown(object sender, EventArgs e)
        {
            txtCurrentTitle.Text = CurrentTitle;
        }
    }
}
