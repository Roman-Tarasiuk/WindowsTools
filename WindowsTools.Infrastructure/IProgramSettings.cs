using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsTools.Infrastructure
{
    public interface IProgramSettings
    {
        event EventHandler SettingsChanged;
    }
}
