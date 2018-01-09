using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsManipulations.Infrastructure
{
    public class CompareStringsSettings
    {
        #region Properties

        public bool Topmost { get; set; }
        public bool IgnoreCase { get; set; }

        #endregion

        public CompareStringsSettings()
        {

        }
    }
}
