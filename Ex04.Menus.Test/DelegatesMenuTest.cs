using Ex04.Menus.Delegates;
namespace Ex04.Menus.Test
{
    static class DelegatesMenuTest
    {


        public static void LaunchMenuWithDelegates()
        {
            Menu mainMenu = new Menu("Main Menu", true);
            Menu dateTimeMenu = new Menu("Show Date/Time");
            Menu versionCapitalsMenu = new Menu("Version and Capitals");

            dateTimeMenu.AddMenuItem(new MenuItem("Show Date",
                                    () => TestItems.ShowDate()));
            dateTimeMenu.AddMenuItem(new MenuItem("Show Time",
                                    () => TestItems.ShowTime()));

            versionCapitalsMenu.AddMenuItem(new MenuItem("Show Version",
                                            () => TestItems.ShowVersion()));
            versionCapitalsMenu.AddMenuItem(new MenuItem("Count Capitals",
                                            () => TestItems.CountCapitals()));

            mainMenu.AddMenuItem(dateTimeMenu);
            mainMenu.AddMenuItem(versionCapitalsMenu);

            mainMenu.Show();

        }
    }
}
