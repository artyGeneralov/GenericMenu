﻿namespace Ex04.Menus.Test
{
    class Program 
    {
        public static bool hasQuitted = false;
        public static void Main()
        {

            /*
             Part 1 - Tests for Interface menu implementation
            */
            InterfacesMenuTest interfacesTest = new InterfacesMenuTest();
            interfacesTest.LaunchMenuWithInterfaces();

            /*
             Part 2 - Tests for Delegates menu implementation
            */

            DelegatesMenuTest.LaunchMenuWithDelegates();
            
        }





    }
}
