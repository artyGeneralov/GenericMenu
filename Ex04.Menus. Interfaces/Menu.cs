using System.Collections.Generic;
using Ex02.ConsoleUtils;
using System;
namespace Ex04.Menus.Interfaces
{
    public class Menu : IMenuItem
    {
        public string Name { get; }
        private List<IMenuItem> menuItems;
        public Menu(string name)
        {
            Name = name;
            menuItems = new List<IMenuItem>();
        }

        public void AddMenuItem(IMenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        public void MenuItemActivate()
        {
            Show();
            HandleChoice();
        }
        private void Show()
        {
            Screen.Clear();
            Console.WriteLine($"{Name}");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i].Name}");
            }
        }
        private void HandleChoice()
        {
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice)
                            && choice > 0
                            && choice <= menuItems.Count)
            {
                menuItems[choice - 1].MenuItemActivate();
            }
            else
            {
                throw new FormatException("Wrong input");
            }
        }



    }
}
