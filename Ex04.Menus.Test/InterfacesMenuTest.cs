using Ex04.Menus.Interfaces;
using System.Collections.Generic;

namespace Ex04.Menus.Test
{
    class InterfacesMenuTest : IMenuSelectObserver
    {

       

        private Menu dateTimeMenu, versionCapitalsMenu, mainMenu;
        private readonly List<MenuItem> listOfMenuItems = new List<MenuItem>();

        public void LaunchMenuWithInterfaces()
        {
            mainMenu = new Menu("Main Menu");
            dateTimeMenu = new Menu("Show Date/Time" , mainMenu);
            versionCapitalsMenu =new Menu("Version and Capitals", mainMenu);
            
            listOfMenuItems.Add(mainMenu.AddMenuItem(new MenuItem("Show Date/Time")));
            listOfMenuItems.Add(mainMenu.AddMenuItem(new MenuItem("Version and Capitals")));

            listOfMenuItems.Add(dateTimeMenu.AddMenuItem(new MenuItem("Show Date")));
            listOfMenuItems.Add(dateTimeMenu.AddMenuItem(new MenuItem("Show Time")));

            listOfMenuItems.Add(versionCapitalsMenu.AddMenuItem(new MenuItem("Show Version")));
            listOfMenuItems.Add(versionCapitalsMenu.AddMenuItem(new MenuItem("Count Capitals")));

            foreach (MenuItem item in listOfMenuItems)
            {
                item.AttachObserver(this);
            }

            mainMenu.Show();

        }

        public void MenuSelect(string name)
        {
            switch (name)
            {
                case "Show Date/Time":
                    dateTimeMenu.Show();
                    break;
                case "Version and Capitals":
                    versionCapitalsMenu.Show();
                    break;

                case "Show Date":
                    TestItems.ShowDate();
                    break;
                case "Show Time":
                    TestItems.ShowTime();
                    break;

                case "Show Version":
                    TestItems.ShowVersion();
                    break;
                case "Count Capitals":
                    TestItems.CountCapitals();
                    break;

            }
        }



    }
}
