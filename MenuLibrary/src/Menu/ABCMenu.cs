using System.Collections.Generic;
using System;
using MenuLibrary.src.MenuItem;

namespace MenuLibrary.src.Menu
{
    public abstract class ABCMenu : IMenu
    {
        public List<IMenuItem> menuItems { get; set; }
        public string header { get; set; }

        public ABCMenu(string header, List<IMenuItem> menuItems)
        {
            this.header = header;
            this.menuItems = menuItems;
        }
        
        bool continueCycle = true;

        public void Display()
        {
            do
            {
                if (!String.IsNullOrEmpty(header))
                {
                    Console.WriteLine(header);
                }
                var iterator = 1;
                foreach (var item in menuItems)
                {
                    Console.WriteLine(String.Format("{0}. {1}", iterator, item.Name()));
                    iterator++;
                }

                continueCycle = menuItems[GetUserInput(menuItems.Count)].Select();
            } while (continueCycle);
        }

        private int GetUserInput(int max)
        {
            var isInt = false;
            int userInput;
            var valid = false;
            do
            {
                Console.WriteLine(String.Format("Please choose a number between {0} and {1}", 1, max));
                isInt = int.TryParse(Console.ReadLine(), out userInput);
                valid = (isInt && (userInput >= 1 && userInput <= menuItems.Count));
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (!valid);

            return userInput - 1;
        }
    }
}
