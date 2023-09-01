using Ex04.Menus.Delegates;
namespace Ex04.Menus.Test
{
    static class DelegatesMenuTest
    {


        public static void LaunchMenuWithDelegates()
        {
            Menu mainMenu_d = new Menu("Main Menu");
            Menu dateTimeMenu_d = new Menu("Show Date/Time");
            Menu versionCapitalsMenu_d = new Menu("Version and Capitals");

            MenuItem showDate = new MenuItem("Show Date");
            MenuItem showTime = new MenuItem("Show Time");
            MenuItem showVersion = new MenuItem("Show Version");
            MenuItem countCaps = new MenuItem("Count Capitals");
            MenuItem back = new MenuItem("Back");
            MenuItem exit = new MenuItem("Exit");

            showDate.MenuSelected += () => TestItems.ShowDate();
            showTime.MenuSelected += () => TestItems.ShowTime();
            showVersion.MenuSelected += () => TestItems.ShowVersion();
            countCaps.MenuSelected += () => TestItems.CountCapitals();
            back.MenuSelected += () => mainMenu_d.Show();
            exit.MenuSelected += () => TestItems.Exit();

            MenuItem showDateTimeMenu = new MenuItem("Show Date/Time");
            MenuItem showVersionCapsMenu = new MenuItem("Version and Capitals");

            showDateTimeMenu.MenuSelected += () => dateTimeMenu_d.Show();
            showVersionCapsMenu.MenuSelected += () => versionCapitalsMenu_d.Show();

            dateTimeMenu_d.AddMenuItem(showDate);
            dateTimeMenu_d.AddMenuItem(showTime);
            dateTimeMenu_d.AddMenuItem(back);

            versionCapitalsMenu_d.AddMenuItem(showVersion);
            versionCapitalsMenu_d.AddMenuItem(countCaps);
            versionCapitalsMenu_d.AddMenuItem(back);

            mainMenu_d.AddMenuItem(showDateTimeMenu);
            mainMenu_d.AddMenuItem(showVersionCapsMenu);
            mainMenu_d.AddMenuItem(exit);

            while (!Program.hasQuitted)
            {
                mainMenu_d.Show();
            }
            Program.hasQuitted = false;
        }
    }
}
