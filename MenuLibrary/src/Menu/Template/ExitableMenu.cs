using System;
using System.Linq;
using System.Collections.Generic;
using MenuLibrary.src.MenuItem;
using MenuLibrary.src.MenuItem.Static;

namespace MenuLibrary.src.Menu.Template
{
    public class ExitableMenu : ABCMenu
    {
        public ExitableMenu(string header, List<IMenuItem> menuItems) : base(header, menuItems)
        {
            this.header = header;
            this.menuItems = menuItems;
            this.menuItems.Add(new ExitMenuItem());
        }

    }
}
