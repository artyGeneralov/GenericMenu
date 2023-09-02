using System.Collections.Generic;
using Ex02.ConsoleUtils;
using System;
namespace Ex04.Menus.Interfaces
{
    public class Menu 
    {
        public string Name { get; }
        private readonly List<MenuItem> menuItems;
        private Menu previousMenu;
        public Menu(string name, Menu previousMenu = null)
        {
            Name = name;
            menuItems = new List<MenuItem>();
            this.previousMenu = previousMenu;
        }

        public MenuItem AddMenuItem(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
            return menuItem;
        }


        public void Show()
        {
            Screen.Clear();
            Console.WriteLine($"{Name}");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1} -> {menuItems[i].Name}");
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
            while (!(int.TryParse(Console.ReadLine(), out choice)
                            && choice >= 0
                            && choice <= menuItems.Count))
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
                menuItems[choice - 1].MenuItemActivate();
            }
            
        }

    }
}
