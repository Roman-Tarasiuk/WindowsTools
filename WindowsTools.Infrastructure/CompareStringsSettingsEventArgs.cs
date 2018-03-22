using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTools.Infrastructure
{
    public class CompareStringsSettingsEventArgs : EventArgs
    {
        public CompareStringsSettings Settings { get; set; }
    }
}
