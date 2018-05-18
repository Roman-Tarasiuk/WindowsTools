using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class ScreenRulerForm : Form
    {
        public ScreenRulerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("CursorScreenRuller.cur");
        }
    }
}
