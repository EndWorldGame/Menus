using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary.src.MenuItem
{
    public interface IMenuItem
    {
        bool Select();
        string Name();
    }
}
