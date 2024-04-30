using Cmd.UI;
using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Cmd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ObjectHandler.GetAdminDL().LoadAdmins();
            ObjectHandler.GetFlightDL().LoadFlights();
            ObjectHandler.GetClientDL().LoadClients();
            string loginStatus; 
            int clientID;
            int loginChoice, userChoice;
            while (true)
            {
            HeaderUI.MainHeader();
            loginChoice = LoginUI.MainMenu();
            if (loginChoice == 2)
            {
                loginStatus = LoginUI.Login();
                if (loginStatus == " ")
                {
                continue;
                }
                else if (loginStatus.ToLower() != "admin")
                {
                clientID = int.Parse(loginStatus);
                while (true)
                {
                    Console.Clear();
                    userChoice = ClientUI.ClientMenu();
                    if (userChoice == 1)
                    {
                    ClientUI.SearchFlight();
                    Console.WriteLine("\n\n Press any key to Continue..");
                    Console.ReadKey();
                    Console.Clear();
                    }
                    else if (userChoice == 2)
                    {
                     ClientUI.BookingInput(clientID);
                    }
                    else if (userChoice == 3)
                    {
                    ClientUI.DispalyBookedFlights(clientID);
                    Console.WriteLine("\n\n Press any key to Continue..");
                    Console.ReadKey();
                    Console.Clear();
                    }
                    else if (userChoice == 4)
                    {
                    break;
                    }

                }
                }
                else if (loginStatus.ToLower() == "admin")
                {
                while (true)
                {
                    Console.Clear();
                    userChoice = AdminUI.AdminMenu();
                    if (userChoice == 1)
                    {
                    FlightUI.AddNewFlight();
                    }
                    if (userChoice == 2)
                    {
                    FlightUI.ViewAllFlights();
                    Console.WriteLine("\n\n Press any key to Continue..");
                    Console.ReadKey();
                    Console.Clear();
                    }
                    if (userChoice == 3)
                    {
                    FlightUI.DeleteFlight();
                    }
                    if (userChoice == 4)
                    {
                    break;
                    }
                }
                }
            }
                else if (loginChoice == 1)
                {
                    LoginUI.SignUp();
                }
                else if (loginChoice == 3)
            {
                Console.Clear();
                break;
            }

            }

        }
    }
}

