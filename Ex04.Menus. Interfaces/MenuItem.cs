
using System;
using System.Collections.Generic;
using Ex02.ConsoleUtils;
namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public string Name { get; }
        private readonly List<IMenuSelectObserver> m_MenuSelectObservers = new List<IMenuSelectObserver>();

        public MenuItem(string name)
        {
            Name = name;

        }
       
        public void AttachObserver(IMenuSelectObserver i_menuSelectObserver)
        {
            m_MenuSelectObservers.Add(i_menuSelectObserver);
        }
        public void DetachObserver(IMenuSelectObserver i_menuSelectObserver)
        {
            m_MenuSelectObservers.Remove(i_menuSelectObserver);
        }
        public void MenuItemActivate()
        {
            Screen.Clear();
            notifyMenuSelectObservers();
        }

        private void notifyMenuSelectObservers()
        {
            foreach(IMenuSelectObserver observer in m_MenuSelectObservers)
            {
                observer.MenuSelect(Name);
            }
        }
    }
}
