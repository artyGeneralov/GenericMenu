
using System;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Interfaces
{
    public class MenuAction : IMenuItem
    {
        public string Name { get; }
        private Action action; 
        public MenuAction(string name, Action action)
        {
            Name = name;
            this.action = action;
        }
       
        public void MenuItemActivate()
        {
            Screen.Clear();
            action.Invoke();
            Console.ReadLine();
        }
    }
}
