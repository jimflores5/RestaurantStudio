using System;

namespace RestaurantStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Blake's tasty menu!");
            var menu = new Menu();
            menu.AddMenuItem(new MenuItem("Hot Dogs", .99, "Mystery meat in link form.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Hot Dogs", .99, "Mystery meat in link form.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Mac n Cheese", 1.99, "Macoroni and cheese powder.", "Side", false));
            menu.AddMenuItem(new MenuItem("Humus and Pita", 3, "Freshly made humus with pita.", "Appetizer", true));

            foreach(var menuItem in menu.MenuItems)
            {
                Console.WriteLine(menuItem);
            }

            Console.ReadKey();
        }
    }
}
