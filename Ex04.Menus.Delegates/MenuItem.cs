using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public string Name { get; set; }
        private Action menuItemAction;
        public MenuItem(string name, Action menuItemAction)
        {
            Name = name;
            this.menuItemAction = menuItemAction;
        }

        public void MenuSelectedHandler()
        {
            Screen.Clear();
            menuItemAction?.Invoke();
        }

    }
}