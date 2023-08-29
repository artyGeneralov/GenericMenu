using System.Collections.Generic;
using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Delegates
{
    public class Menu
    {
        public string Name { get; set; }
        public List<MenuItem> MenuItems { get; set; }
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
            if(int.TryParse(Console.ReadLine(), out choice) &&
                                                    choice > 0 && 
                                                    choice <= MenuItems.Count)
            {
                MenuItems[choice - 1].MenuSelected();
            }
            else
            {
                throw new FormatException("Wrong Input");
            }
        }
    }
}
