using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    public partial class SendCommandToolPropertiesForm : Form
    {
        public AnchorHorizontal AnchorH { get; set; }
        public AnchorVertical AnchorV { get; set; }
        public int ToolWidht { get; set; }
        public int ToolHeight { get; set; }

        public SendCommandToolPropertiesForm()
        {
            InitializeComponent();

            ToolWidht = 40;
            ToolHeight = 40;
            AnchorH = AnchorHorizontal.Left;
            AnchorV = AnchorVertical.Top;
        }

        private void SendCommandToolPropertiesForm_Shown(object sender, EventArgs e)
        {
            txtToolWidth.Text = ToolWidht.ToString();
            txtToolHeight.Text = ToolHeight.ToString();

            if (AnchorH == AnchorHorizontal.Left)
            {
                radioLeft.Checked = true;
            }
            else
            {
                radioRight.Checked = true;
            }

            if (AnchorV == AnchorVertical.Top)
            {
                radioTop.Checked = true;
            }
            else
            {
                radioBottom.Checked = true;
            }
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
