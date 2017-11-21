using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace RestaurantStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.WriteLine("Our tasty menu!");
            Console.WriteLine("Please choose an option: \n 1) Add a menu item. \n 2) Remove a menu item. \n 3) See menu.");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                menu.AddMenuItem();
            }
            else if (choice == "2")
            {
                //remove menu item
            }

            foreach(MenuItem entry in menu.MenuItems)
            {
                Console.WriteLine(entry);
                    
            }

            /*var menu = new Menu();
            menu.AddMenuItem(new MenuItem("Hot Dogs", .99, "Mystery meat in link form.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Hot Dogs", .99, "Mystery meat in link form.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Mac n Cheese", 1.99, "Macoroni and cheese powder.", "Side", false));
            menu.AddMenuItem(new MenuItem("Humus and Pita", 3.00, "Freshly made humus with pita.", "Appetizer", true));
            */

            Console.ReadKey();
        }
    }
}
