using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantStudio
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; }
        public DateTime LastUpdated { get; private set; }

        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }

        public MenuItem AddMenuItem()
        {
            Console.WriteLine("Please enter the name of the new item:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the price for {0}:", name);
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a description of {0}:", name);
            string info = Console.ReadLine();
            Console.WriteLine("Is {0} an appetizer, main course or dessert?", name);
            string type = Console.ReadLine();

            MenuItem newFood = new MenuItem(name, price, info, type, true);
            Console.WriteLine("New menu item added.  Press 'Enter' to continue...");
            Console.ReadLine();

            //prevent adding duplicate menuItems
            if (!this.MenuItems.Contains(newFood))
            {
                this.MenuItems.Add(newFood);
                // Update LastUpdated anytime we add a new menuItem
                this.LastUpdated = DateTime.Now;
            }
            return newFood;
        }

        public void RemoveMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Remove(menuItem);
            // Update LastUpdated anytime we remove a menuItem
            this.LastUpdated = DateTime.Now;
        }

    }
}
