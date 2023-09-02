using System.Collections.Generic;
using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Delegates
{
    public class Menu
    {
        public string Name { get; set; }
        private readonly List<MenuItem> MenuItems;
        private readonly Menu previousMenu;
        public Menu(string name, Menu previousMenu = null)
        {
            Name = name;
            MenuItems = new List<MenuItem>();
            this.previousMenu = previousMenu;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }
        public void AddMenuItem(Menu menu)
        {
            MenuItem menuToMenuItem = new MenuItem(menu.Name, () => menu.Show());
            MenuItems.Add(menuToMenuItem);
        }

        public void Show()
        {
            Screen.Clear();
            Console.WriteLine($"{Name}");
            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1} -> {MenuItems[i].Name}");
            }

            if (previousMenu == null)
            {
                Console.WriteLine("0 -> Exit");
            }
            else
            {
                Console.WriteLine("0 -> Back");
            }

            int choice;
            while (!(int.TryParse(Console.ReadLine(), out choice) &&
                                                    choice >= 0 &&
                                                    choice <= MenuItems.Count))
            {
                Console.WriteLine("Wrong Input");
            }

            if (choice == 0 && previousMenu == null)
            {
                return;
            }
            else if (choice == 0 && previousMenu != null)
            {
                previousMenu.Show();
            }
            else
            {
                MenuItems[choice - 1].MenuSelectedHandler();
            }

        }
    }
}
