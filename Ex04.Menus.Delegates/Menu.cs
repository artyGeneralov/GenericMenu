using System.Collections.Generic;
using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Delegates
{
    public class Menu
    {
        public string Name { get; set; }
        private readonly List<MenuItem> MenuItems;
        private bool isMain;
        public Menu(string name, bool isMain = false)
        {
            Name = name;
            MenuItems = new List<MenuItem>();
            this.isMain = isMain;
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

            if (isMain == true)
            {
                Console.WriteLine("0 -> Exit");
            }
            else
            {
                Console.WriteLine("0 -> Back");
            }

            int choice = -1;
            while (!(int.TryParse(Console.ReadLine(), out choice) &&
                                                    choice >= 0 &&
                                                    choice <= MenuItems.Count))
            {
                Console.WriteLine("Wrong Input");
            }

            if (choice == 0)
            {
                return;
            }
            else
            { 
                MenuItems[choice - 1].MenuSelectedHandler();
                Show();
            }
        }

    }
}
