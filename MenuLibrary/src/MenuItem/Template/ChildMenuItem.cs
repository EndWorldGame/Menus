using System;
using System.Collections.Generic;
using System.Text;
using MenuLibrary.src.Menu;

namespace MenuLibrary.src.MenuItem.Template
{
    public class ChildMenuItem : IMenuItem
    {

        private string menuItemName;
        private IMenu childMenu;
        public ChildMenuItem(string menuItemName, IMenu childMenu)
        {
            this.menuItemName = menuItemName;
            this.childMenu = childMenu;
        }

        public bool Select()
        {
            childMenu.Display();
            return true;
        }

        public string Name()
        {
            return menuItemName;
        }

    }
}
