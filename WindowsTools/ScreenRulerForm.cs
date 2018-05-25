using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;

namespace WindowsTools
{
    public partial class ScreenRulerForm : Form
    {
        private bool m_Measuring = false;
        private bool m_Started = false;
        private Point m_PointStart = new Point();
        private Point m_PointCurrent = new Point(0, 0);

        public ScreenRulerForm()
        {
            InitializeComponent();
        }

        private void btnStartStopRuller_Click(object sender, EventArgs e)
        {
            if (m_Started)
            {
                timer1.Stop();
                btnStartStopRuller.Text = "Start";
                lblHelp.Visible = false;
                m_Started = false;
            }
            else
            {
                timer1.Start();
                btnStartStopRuller.Text = "Stop";
                lblHelp.Visible = true;
                m_Started = true;
            }

            btnDummuToTemporaryFocusing.Focus();
        }

        private void ScreenRulerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (m_Started && e.KeyCode == Keys.Space)
            {
                m_Measuring = !m_Measuring;

                if (m_Measuring)
                {
                    m_PointStart = Cursor.Position;
                    txtStart.Text = String.Format("{0}, {1}", m_PointStart.X, m_PointStart.Y);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_Measuring)
            {
                var pos = Cursor.Position;
                if (pos == m_PointCurrent)
                {
                    return;
                }

                m_PointCurrent = pos;
                txtCurrent.Text = String.Format("{0}, {1}", pos.X, pos.Y);

                // Add +1 because the distance between 2 adjacent pixels is 2.
                var w = Math.Abs(pos.X - m_PointStart.X) + 1;
                var h = Math.Abs(pos.Y - m_PointStart.Y) + 1;
                txtDistance.Text = String.Format("{0}, {1}", w, h);
            }
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            new ScreenRulerHelperForm().Show();
        }
    }
}
