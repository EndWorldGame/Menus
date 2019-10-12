using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary.src.MenuItem.Template
{
    public class MessageMenuItem : IMenuItem
    {
        private string menuItemName;
        private string menuItemMessage;

        public MessageMenuItem(string menuItemName, string menuItemMessage)
        {
            this.menuItemName = menuItemName;
            this.menuItemMessage = menuItemMessage;
        }

        public bool Select()
        {
            Console.WriteLine("\n" + menuItemMessage + "\n");
            return true;
        }

        public string Name()
        {
            return this.menuItemName;
        }

    }
}
