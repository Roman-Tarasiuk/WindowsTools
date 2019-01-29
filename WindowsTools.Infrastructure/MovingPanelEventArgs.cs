using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTools.Infrastructure
{
    public class MovingPanelEventArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MovingPanelEventArgs()
        {

        }

        public MovingPanelEventArgs(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
