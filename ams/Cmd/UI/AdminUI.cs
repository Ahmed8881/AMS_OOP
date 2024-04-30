using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.UI
{
    internal class AdminUI
    {
        public static int AdminMenu()
        {
            while (true)
            {
                DisplayAdminMenu();
                string input = Console.ReadLine();
                if (!IsValidAdminInput(input))
                {
                    DisplayInvalidInputMessage();
                    continue;
                }
                int option = int.Parse(input);
                Console.Clear();
                return option;
            }
        }

        private static void DisplayAdminMenu()
        {
            HeaderUI.MainHeader();
            HeaderUI.AdminHeader();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 1. Add Flight");
            Console.WriteLine(" 2. View Flights");
            Console.WriteLine(" 3. Delete flight");

            Console.WriteLine(" 4. Log Out");
            Console.Write(" Enter Option Number: ");
        }

        private static bool IsValidAdminInput(string input)
        {
            return input == "1" || input == "2" || input == "3" || input == "4" || input == "5";
        }
        public static void DisplayInvalidInputMessage()
        {
            Console.WriteLine(" \n\nInvalid Input..");
            Console.WriteLine(" Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
