using System;
using MenuLibrary.src.Menu.Template;
using MenuLibrary.src.MenuItem.Template;
using MenuLibrary.src.MenuItem;
using System.Collections.Generic;

namespace MenuSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            ExitableMenu childMenu = new ExitableMenu("Child Menu",
                new List<IMenuItem>()
                {
                    new MessageMenuItem("Test", "Yo"),
                    new ServiceMenuItem("Secret Service Option", new TestRunService())
                }
                );

            ExitableMenu mainMenu = new ExitableMenu("Main Menu",
                new List<IMenuItem>()
                {
                    new MessageMenuItem("Test Message", "EndWorld is going to be fun"),
                    new ChildMenuItem("Second Menu", childMenu)
                }
                );

            mainMenu.Display();
        }
    }
}
