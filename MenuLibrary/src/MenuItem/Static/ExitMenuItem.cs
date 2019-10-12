using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary.src.MenuItem.Static
{
    public class ExitMenuItem : IMenuItem
    {
        public bool Select()
        {
            return false;
        }

        public string Name()
        {
            return "Exit";
        }
    }
}
