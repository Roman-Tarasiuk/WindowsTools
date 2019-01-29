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
    public partial class CalendarForm : Form
    {
        private Size m_WindowSize = new Size(186, 207);
        private int m_OffsetX = 8; // I don't know, why without this value, calendar window displays to left
        private int m_OffsetY = 2; // Pixels between clock and calendars windows

        public CalendarForm()
        {
            InitializeComponent();
        }


        public void SetLocationAndSize(Form form)
        {
            int X = 0, Y = 0;

            int tmpX = form.Location.X + form.Size.Width - m_WindowSize.Width + m_OffsetX;
            if (tmpX >= 0)
            {
                X = tmpX;
            }
            else
            {
                X = form.Location.X - m_OffsetX;
            }

            int tmpY = form.Location.Y + form.Size.Height + m_OffsetY;
            if (tmpY + m_WindowSize.Height + m_OffsetY <= Screen.PrimaryScreen.WorkingArea.Height)
            {
                Y = tmpY;
            }
            else
            {
                Y = form.Location.Y - m_WindowSize.Height + m_OffsetY;
            }

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(X, Y);
        }
    }
}
