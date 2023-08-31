using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public string Name { get; set; }
        public event Action m_menuSelected;

        public MenuItem(string name)
        {
            Name = name;
        }

        public void OnMenuSelected()
        {
            Screen.Clear();
            m_menuSelected?.Invoke();
        }

    }
}
