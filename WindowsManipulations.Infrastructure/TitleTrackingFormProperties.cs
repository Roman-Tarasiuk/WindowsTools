using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsManipulations.Infrastructure
{
    public class TitleTrackingFormProperties
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Interval { get; set; }
        public Font Font { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public Color BorderColor { get; set; }
    }
}
