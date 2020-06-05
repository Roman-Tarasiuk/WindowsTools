using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    class MyApplicationContext : ApplicationContext
    {
        public static MyApplicationContext CurrentContext;

        public MyApplicationContext(Form mainForm) : base(mainForm)
        {
            CurrentContext = this;
        }
    }
}
