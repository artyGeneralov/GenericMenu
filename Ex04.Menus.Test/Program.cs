using Ex04.Menus;
namespace Ex04.Menus.Test
{
    class Program
    {
        public static bool hasQuitted = false;
        public static void Main()
        {

            /*
             Part 1 - Tests for Interface menu implementation
            */
            Interfaces.Menu dateTimeMenu = new Interfaces.Menu("Show Date/Time");
            Interfaces.Menu versionCapitalsMenu = new Interfaces.Menu("Version and Capitals"); ;
            Interfaces.Menu mainMenu = new Interfaces.Menu("Main Menu");
           
            dateTimeMenu.AddMenuItem(new Interfaces.MenuAction("Show Date",
                                    () => TestItems.ShowDate()));
            dateTimeMenu.AddMenuItem(new Interfaces.MenuAction("Show Time",
                                    () => TestItems.ShowTime()));
            dateTimeMenu.AddMenuItem(new Interfaces.MenuAction("Back",
                                    () => mainMenu.MenuItemActivate()));

           
            versionCapitalsMenu.AddMenuItem(new Interfaces.MenuAction("Show Version",
                                            () => TestItems.ShowVersion()));
            versionCapitalsMenu.AddMenuItem(new Interfaces.MenuAction("Count Capitals",
                                            () => TestItems.CountCapitals()));
            versionCapitalsMenu.AddMenuItem(new Interfaces.MenuAction("Back",
                                            () => mainMenu.MenuItemActivate()));


            mainMenu.AddMenuItem(dateTimeMenu);
            mainMenu.AddMenuItem(versionCapitalsMenu);
            mainMenu.AddMenuItem(new Interfaces.MenuAction("Exit",
                                 () => TestItems.Exit()));

            while (!hasQuitted)
            {
                mainMenu.MenuItemActivate();
            }
            hasQuitted = false;

            /*
             Part 2 - Tests for Interface menu implementation
            */

        }
    }
}
