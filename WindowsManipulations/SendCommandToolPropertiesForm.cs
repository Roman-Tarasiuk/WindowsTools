using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsManipulations
{
    public partial class SendCommandToolPropertiesForm : Form
    {
        public int ToolWidht { get; set; }
        public int ToolHeight { get; set; }

        public SendCommandToolPropertiesForm()
        {
            InitializeComponent();

            ToolWidht = 40;
            ToolHeight = 40;
        }

        private void SendCommandToolPropertiesForm_Shown(object sender, EventArgs e)
        {
            txtToolWidth.Text = ToolWidht.ToString();
            txtToolHeight.Text = ToolHeight.ToString();
        }

        private void txtToolWidth_TextChanged(object sender, EventArgs e)
        {
            int w;
            if (int.TryParse(txtToolWidth.Text, out w))
            {
                ToolWidht = w;
            }
        }

        private void txtToolHeight_TextChanged(object sender, EventArgs e)
        {
            int h;
            if (int.TryParse(txtToolHeight.Text, out h))
            {
                ToolHeight = h;
            }
        }
    }
}
