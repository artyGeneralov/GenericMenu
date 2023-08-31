using System.Collections.Generic;
using Ex02.ConsoleUtils;
using System;
namespace Ex04.Menus.Interfaces
{
    public class Menu 
    {
        public string Name { get; }
        private List<MenuItem> menuItems;
        public Menu(string name)
        {
            Name = name;
            menuItems = new List<MenuItem>();
        }

        public MenuItem AddMenuItem(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
            return menuItem;
        }

        public void ShowMenu()
        {
            show();
            handleChoice();
        }
        private void show()
        {
            Screen.Clear();
            Console.WriteLine($"{Name}");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i].Name}");
            }
        }
        private void handleChoice()
        {
            int choice;
            while (!(int.TryParse(Console.ReadLine(), out choice)
                            && choice > 0
                            && choice <= menuItems.Count))
            {
                Console.WriteLine("Wrong Input");
            }
                menuItems[choice - 1].MenuItemActivate();

        }



    }
}
