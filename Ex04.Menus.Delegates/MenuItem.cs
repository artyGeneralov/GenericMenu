using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public string Name { get; set; }
        public event Action MenuSelected;

        public MenuItem(string name)
        {
            Name = name;
        }

        public void MenuSelectedHandler()
        {
            Screen.Clear();
            MenuSelected?.Invoke();
        }

    }
}
