

using System;

namespace Ex04.Menus.Test
{
    static class TestItems
    {

        public static void ShowDate()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
            endProgram();
        }

        public static void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Current Date: {currentDate.ToShortTimeString()}");
            endProgram();
        }

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 23.3.4.9835");
            endProgram();
        }

        public static void CountCapitals()
        {
            Console.WriteLine("Capital letter counter");
            Console.WriteLine("Please enter a string:");
            string userInput = Console.ReadLine();

            int capitalCount = 0;
            foreach (char c in userInput)
            {
                if (char.IsUpper(c))
                {
                    capitalCount++;
                }
            }

            Console.WriteLine($"Number of capitals in string: {capitalCount}");
            endProgram();
        }

        private static void endProgram()
        {
            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }
    }
}
