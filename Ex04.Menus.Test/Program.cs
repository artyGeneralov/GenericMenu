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
            Interfaces.Menu dateTimeMenu_i = new Interfaces.Menu("Show Date/Time");
            Interfaces.Menu versionCapitalsMenu_i = new Interfaces.Menu("Version and Capitals"); ;
            Interfaces.Menu mainMenu_i = new Interfaces.Menu("Main Menu");
           
            dateTimeMenu_i.AddMenuItem(new Interfaces.MenuAction("Show Date",
                                    () => TestItems.ShowDate()));
            dateTimeMenu_i.AddMenuItem(new Interfaces.MenuAction("Show Time",
                                    () => TestItems.ShowTime()));
            dateTimeMenu_i.AddMenuItem(new Interfaces.MenuAction("Back",
                                    () => mainMenu_i.MenuItemActivate()));


           
            versionCapitalsMenu_i.AddMenuItem(new Interfaces.MenuAction("Show Version",
                                            () => TestItems.ShowVersion()));
            versionCapitalsMenu_i.AddMenuItem(new Interfaces.MenuAction("Count Capitals",
                                            () => TestItems.CountCapitals()));
            versionCapitalsMenu_i.AddMenuItem(new Interfaces.MenuAction("Back",
                                            () => mainMenu_i.MenuItemActivate()));


            mainMenu_i.AddMenuItem(dateTimeMenu_i);
            mainMenu_i.AddMenuItem(versionCapitalsMenu_i);
            mainMenu_i.AddMenuItem(new Interfaces.MenuAction("Exit",
                                 () => TestItems.Exit()));

            while (!hasQuitted)
            {
                mainMenu_i.MenuItemActivate();
            }
            hasQuitted = false;

            /*
             Part 2 - Tests for Interface menu implementation
            */

            Delegates.Menu mainMenu_d = new Delegates.Menu("Main Menu");
            Delegates.Menu dateTimeMenu_d = new Delegates.Menu("Show Date/Time");
            Delegates.Menu versionCapitalsMenu_d = new Delegates.Menu("Version and Capitals");

            Delegates.MenuItem showDate = new Delegates.MenuItem("Show Date");
            Delegates.MenuItem showTime = new Delegates.MenuItem("Show Time");
            Delegates.MenuItem showVersion = new Delegates.MenuItem("Show Version");
            Delegates.MenuItem countCaps = new Delegates.MenuItem("Count Capitals");
            Delegates.MenuItem back = new Delegates.MenuItem("Back");
            Delegates.MenuItem exit = new Delegates.MenuItem("Exit");

            showDate.OnMenuSelected += () => TestItems.ShowDate();
            showTime.OnMenuSelected += () => TestItems.ShowTime();
            showVersion.OnMenuSelected += () => TestItems.ShowVersion();
            countCaps.OnMenuSelected += () => TestItems.CountCapitals();
            back.OnMenuSelected += () => mainMenu_d.Show();
            exit.OnMenuSelected += () => TestItems.Exit();

            Delegates.MenuItem showDateTimeMenu = new Delegates.MenuItem("Show Date/Time");
            Delegates.MenuItem showVersionCapsMenu = new Delegates.MenuItem("Version and Capitals");

            showDateTimeMenu.OnMenuSelected += () => dateTimeMenu_d.Show();
            showVersionCapsMenu.OnMenuSelected += () => versionCapitalsMenu_d.Show();

            dateTimeMenu_d.AddMenuItem(showDate);
            dateTimeMenu_d.AddMenuItem(showTime);
            dateTimeMenu_d.AddMenuItem(back);

            versionCapitalsMenu_d.AddMenuItem(showVersion);
            versionCapitalsMenu_d.AddMenuItem(countCaps);
            versionCapitalsMenu_d.AddMenuItem(back);

            mainMenu_d.AddMenuItem(showDateTimeMenu);
            mainMenu_d.AddMenuItem(showVersionCapsMenu);
            mainMenu_d.AddMenuItem(exit);

            while (!hasQuitted)
            {
                mainMenu_d.Show();
            }
        }
    }
}
