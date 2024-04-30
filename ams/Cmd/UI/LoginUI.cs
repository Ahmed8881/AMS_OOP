using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkyLinesLibrary;
namespace Cmd.UI
{
    internal class LoginUI
    {




        public static void SignUp()
        {
            Console.WriteLine("\t\t\t Sign Up\n\n");
            string name, password, role;
            while (true)
            {
                Console.Write(" Enter UserName: ");
                name = Console.ReadLine();
                if (!(ObjectHandler.GetClientDL().CheckValidClientName(name) && ObjectHandler.GetAdminDL().CheckValidAdminName(name)))
                {
                    Console.WriteLine(" \n\nSorry! This UserName is Already Taken..");
                    Console.WriteLine(" Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Write(" Enter Password: ");
                password = Console.ReadLine();
                Console.Write(" Enter Role (Admin/Client): ");
                role = Console.ReadLine();
                if (role.ToLower() != "user" && role.ToLower() != "admin")
                {
                    Console.WriteLine(" Invalid Input..Please Enter Valid Role!!");
                    Console.WriteLine(" Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }
            if (role.ToLower() == "user")
            {
                Client c = new Client(name, password, role);
                ObjectHandler.GetClientDL().AddClient(c);
            }
            else if (role.ToLower() == "admin")
            {
                Admins admin = new Admins(name, password, role);
                ObjectHandler.GetAdminDL().AddAdmin(admin);
            }
            Console.WriteLine($"\n\n {name}! You are sucessfully Signed Up as a {role}");
            Console.WriteLine(" Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static string Login()
        {
            
            HeaderUI.MainHeader();
            Console.ForegroundColor = ConsoleColor.White;
            string name = GetUserNameInput();
            string password = GetPasswordInput();
            string result = ValidateUser(name, password);
            DisplayLoginResult(result, name);
            return result;
        }

        private static string GetUserNameInput()
        {
            Console.Write(" Enter UserName: ");
            return Console.ReadLine();
        }

        private static string GetPasswordInput()
        {
            Console.Write(" Enter Password: ");
            return Console.ReadLine();
        }

        private static string ValidateUser(string name, string password)
        {
            int number;
            string result = " ";
            if (ObjectHandler.GetClientDL().IsClientExist(name, password))
            {
                number = ObjectHandler.GetClientDL().FindClient(name, password);
                result = number.ToString();
            }
            else if (ObjectHandler.GetAdminDL().IsAdminExist(name, password))
            {
                result = "Admin";
            }
            return result;
        }

        private static void DisplayLoginResult(string result, string name)
        {
            if (result != " ")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\n Welcome  {name} You are successfully Signed in.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \n\n No such Person Exist!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine(" Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static bool CheckNumber(string enter)
        {
            if (double.TryParse(enter, out _))
            {
                return true;
            }
            return false;
        }
        public static int MainMenu()
        {
            string enter;
            int option;
            while (true)
            {
                HeaderUI.LoginHeader();
                Console.WriteLine(" 3. Exit");
                Console.Write(" Enter Option Number: ");
                enter = Console.ReadLine();
                if (enter != "1" && enter != "2" && enter != "3")
                {
                    Console.WriteLine(" \n\nInvalid Input..");
                    Console.WriteLine(" Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                option = int.Parse(enter);
                Console.Clear();
                return option;
            }
        }


    }
}
