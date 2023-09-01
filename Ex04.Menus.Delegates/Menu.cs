using System.Collections.Generic;
using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Delegates
{
    public class Menu
    {
        public string Name { get; set; }
        private readonly List<MenuItem> MenuItems;
        public Menu(string name)
        {
            Name = name;
            MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }

        public void Show()
        {
            Screen.Clear();
            Console.WriteLine($"{Name}");
            for(int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {MenuItems[i].Name}");
            }

            int choice;
            while(!(int.TryParse(Console.ReadLine(), out choice) &&
                                                    choice > 0 && 
                                                    choice <= MenuItems.Count))
            {
                Console.WriteLine("Wrong Input");
            }

                MenuItems[choice - 1].MenuSelectedHandler();

        }
    }
}
