

using System;

namespace Ex04.Menus.Test
{
    static class TestItems
    {
        public static void Exit()
        {
            Console.WriteLine("Bye bye");
            Program.hasQuitted = true;
        }

        public static void ShowDate()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
        }

        public static void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Current Date: {currentDate.ToShortTimeString()}");
        }

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 23.3.4.9835");
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
        }
    }
}
