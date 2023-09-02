using System.Collections.Generic;
using Ex02.ConsoleUtils;
using System;
namespace Ex04.Menus.Interfaces
{
    public class Menu 
    {
        public string Name { get; }
        private readonly List<MenuItem> menuItems;
        private bool isMain;
        public Menu(string name, bool isMain = false)
        {
            Name = name;
            menuItems = new List<MenuItem>();
            this.isMain = isMain;
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

            if (isMain == true)
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

            if(choice == 0)
            {
                return;
            }
            else
            {
                menuItems[choice - 1].MenuItemActivate();
                Show();
            }

            
            
        }




    }
}
