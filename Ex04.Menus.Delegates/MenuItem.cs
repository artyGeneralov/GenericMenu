using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Delegates
{
    public delegate void MenuAction ();
    public class MenuItem
    {
        public string Name { get; set; }
        public event Action OnMenuSelected;

        public MenuItem(string name)
        {
            Name = name;
        }

        public void MenuSelected()
        {
            Screen.Clear();
            OnMenuSelected?.Invoke();
            Console.ReadLine();
        }

    }
}
