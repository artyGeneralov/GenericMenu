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
            dateTimeMenu = new Menu("Show Date/Time");
            versionCapitalsMenu =new Menu("Version and Capitals");
            mainMenu = new Menu("Main Menu");

            listOfMenuItems.Add(mainMenu.AddMenuItem(new MenuItem("Show Date/Time")));
            listOfMenuItems.Add(mainMenu.AddMenuItem(new MenuItem("Version and Capitals")));
            listOfMenuItems.Add(mainMenu.AddMenuItem(new MenuItem("Exit")));

            listOfMenuItems.Add(dateTimeMenu.AddMenuItem(new MenuItem("Show Date")));
            listOfMenuItems.Add(dateTimeMenu.AddMenuItem(new MenuItem("Show Time")));
            listOfMenuItems.Add(dateTimeMenu.AddMenuItem(new MenuItem("Back")));

            listOfMenuItems.Add(versionCapitalsMenu.AddMenuItem(new MenuItem("Show Version")));
            listOfMenuItems.Add(versionCapitalsMenu.AddMenuItem(new MenuItem("Count Capitals")));
            listOfMenuItems.Add(versionCapitalsMenu.AddMenuItem(new MenuItem("Back")));

            foreach (MenuItem item in listOfMenuItems)
            {
                item.AttachObserver(this);
            }

            while (!Program.hasQuitted)
            {
                mainMenu.ShowMenu();
            }
            Program.hasQuitted = false;
        }

        public void MenuSelect(string name)
        {
            switch (name)
            {
                case "Show Date/Time":
                    dateTimeMenu.ShowMenu();
                    break;
                case "Version and Capitals":
                    versionCapitalsMenu.ShowMenu();
                    break;
                case "Exit":
                    TestItems.Exit();
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

                case "Back":
                    mainMenu.ShowMenu();
                    break;

            }
        }



    }
}
