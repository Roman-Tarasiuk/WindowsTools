using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class StopWatchForm : Form
    {
        #region Fields

        private System.Windows.Forms.Panel panel1;

        private DateTime m_TimeStart;
        private TimeSpan m_TimeSpanTotal = TimeSpan.Zero;

        private string m_SettingsFileName = "settings.ini";

        private string m_TimeFormat = @"hh\:mm\:ss\.ff";
        private string m_TimeZero = "00:00:00.00";

        private bool m_MousePressed = false;
        private Point m_MousePressedPointOffset;

        #endregion

        public StopWatchForm()
        {
            InitializeComponent();

            InitializePanel();

            LoadSettings();
            labelTimer.Text = m_TimeSpanTotal.ToString(m_TimeFormat);
            if (labelTimer.Text != m_TimeZero)
                buttonStartPause.Text = "Continue";
        }


        private void InitializePanel()
        {
            this.panel1 = new TransparentPanel();

            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 40);
            this.panel1.TabIndex = 6;
            this.panel1.Cursor = Cursors.SizeAll;

            this.panel1.MouseDown += panel1_MouseDown;
            this.panel1.MouseUp += panel1_MouseUp;
            this.panel1.MouseMove += panel1_MouseMove;

            this.Controls.Add(this.panel1);
            this.panel1.BringToFront();
        }

        void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m_MousePressed = true;

            Point tmp = PointToScreen(e.Location);
            m_MousePressedPointOffset = new Point(Location.X - tmp.X, Location.Y - tmp.Y);
        }

        void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m_MousePressed = false;
        }

        void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_MousePressed)
            {
                Point tmp = PointToScreen(e.Location);
                Location = new Point(tmp.X + m_MousePressedPointOffset.X, tmp.Y + m_MousePressedPointOffset.Y);
            }
        }

        private void LoadSettings()
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(m_SettingsFileName);
                string timerData = reader.ReadLine();
                m_TimeSpanTotal = TimeSpan.Parse(timerData);
            }
            catch (Exception)
            {
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void SaveSettings()
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(m_SettingsFileName);
                writer.Write(m_TimeSpanTotal.ToString(m_TimeFormat));
            }
            catch (Exception)
            {
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - m_TimeStart + m_TimeSpanTotal;
            labelTimer.Text = ts.ToString(m_TimeFormat);
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            if (buttonStartPause.Text == "Start" || buttonStartPause.Text == "Continue")
            {
                m_TimeStart = DateTime.Now;
                timer1.Start();

                buttonStartPause.Text = "Pause";
            }
            else
            // "Pause".
            {
                m_TimeSpanTotal = DateTime.Now - m_TimeStart + m_TimeSpanTotal;
                timer1.Stop();

                buttonStartPause.Text = "Continue";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            m_TimeStart = DateTime.Now;
            m_TimeSpanTotal = TimeSpan.Zero;

            if (buttonStartPause.Text == "Continue")
            {
                labelTimer.Text = m_TimeZero;
                buttonStartPause.Text = "Start";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1.Enabled)
                m_TimeSpanTotal = DateTime.Now - m_TimeStart + m_TimeSpanTotal;
            timer1.Stop();
            SaveSettings();
        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (topMostToolStripMenuItem.Checked)
            {
                TopMost = false;
                topMostToolStripMenuItem.Checked = false;
            }
            else
            {
                TopMost = true;
                topMostToolStripMenuItem.Checked = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Imported Windows Functions

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        int SW_MINIMIZE = 6;

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow(Handle, SW_MINIMIZE);
        }

        #endregion

        private void labelTimer_MouseClick(object sender, MouseEventArgs e)
        {
            labelTimer.Select();
        }
    }

    public class TransparentPanel : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }
    }
}
