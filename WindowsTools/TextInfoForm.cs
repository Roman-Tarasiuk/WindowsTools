using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace WindowsTools
{
    public partial class TextInfoForm : Form
    {
        public TextInfoForm()
        {
            InitializeComponent();
        }

        private void Tests()
        {
            //Thread t = new Thread(null);
            //t.
        }

        private void btnShowUnique_Click(object sender, EventArgs e)
        {
            Hashtable hash = new Hashtable();

            foreach (var s in txtInfo.Text)
            {
                if (!hash.Contains(s))
                {
                    hash.Add(s, s);
                }
            }

            var unique = hash.Values.OfType<char>().Distinct().OrderBy(s => s);

            string result = new string(unique.ToArray<char>());

            textBox1.Text = result;
        }
    }
}
