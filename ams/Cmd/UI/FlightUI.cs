using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cmd.UI
{
    internal class FlightUI
    {
        public static void AddNewFlight()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t Add Flight\n\n");
            while (true)
            {
                string ID = GetFlightID();
                if (!(ObjectHandler.GetFlightDL().CheckValidFlightID(ID)))
                {
                    Console.WriteLine(" This FlightID Already Exist.Kindly Enter any other ID.");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
               string name = GetFlightName();
               string source = GetDepartureAirport();
               string destination = GetArrivalAirport();
               string date = GetDepartureDate();
                if (!(Validations.CheckValidDate(date)))
            
                {
                    Console.WriteLine(" Invalid Date!!!");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
               string takeoff = GetDepartureTime();
                if (!(Validations.CheckValidTime(takeoff)))
                {
                    Console.WriteLine(" Invalid Departure Time!!!");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
               double price = GetTicketPrice();//validation add
              
               double seats = GetNumberOfSeats();
                Flight f = new Flight(ID, name, source, destination, date, takeoff, price, seats);
                ObjectHandler.GetFlightDL().AddFlight(f);
                break;
            }
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine(" \nThe Desired Flight is Sucessfully Added.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" \n\nPress any key to continue!!!");
            Console.ReadKey();
        }

        private static string GetFlightID()
        {
            Console.Write(" Enter Flight ID: ");
            return Console.ReadLine();
        }

        private static string GetFlightName()
        {
            Console.Write(" Enter Flight Name: ");
            return Console.ReadLine();
        }

        private static string GetDepartureAirport()
        {
            Console.Write(" Enter Departure Airport: ");
            return Console.ReadLine();
        }

        private static string GetArrivalAirport()
        {
            Console.Write(" Enter Arrival Airport: ");
            return Console.ReadLine();
        }

        private static string GetDepartureDate()
        {
            Console.Write(" Enter Departure Date (DD-MM-YYYY): ");
            return Console.ReadLine();
        }

        private static string GetDepartureTime()
        {
            Console.Write(" Enter Departure Time i.e (12:00 AM,05:30 PM): ");
            return Console.ReadLine();
        }

        private static double GetTicketPrice()
        {
            start:
            string checkprice;
            Console.Write(" Enter Ticket Price: ");
            checkprice = Console.ReadLine();
            if (!(LoginUI.CheckNumber(checkprice)))
            {
                Console.WriteLine(" Invalid Price!!!");
                Console.WriteLine(" Press any key to continue!!!");
                Console.ReadKey();
                goto start;
               
            }
            return double.Parse(checkprice);
        }

        private static double GetNumberOfSeats()
        {
           start:
            string checkseats;
            Console.Write(" Enter Number of Seats: ");
            checkseats = Console.ReadLine();
            if (!(LoginUI.CheckNumber(checkseats)))
            {
                Console.WriteLine(" Invalid Input!!!");
                Console.WriteLine(" Press any key to continue!!!");
                Console.ReadKey();
                goto start;
               
            }
            return double.Parse(checkseats);
        }
        public static void ViewAllFlights()
        {
            Console.Clear();
            List<Flight> Flights = ObjectHandler.GetFlightDL().GetAllFlights();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("......................... View Flights............................\n");
           // Console.WriteLine("Flight ID\n Flight Name\n Depature Airport\n Arrival Airport\n Departure Date\n Departure Time \n Price\n Seats");
            for (int i = 0; i < Flights.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Flight Number {i}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Flights[i].ViewFlight());
            }
            Console.WriteLine("\n\n\n Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
      public static void DeleteFlight()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t Delete Flight\n\n");
            Console.Write(" Enter Flight ID: ");
            string ID = Console.ReadLine();
            Console.Write ("Enter flight name: ");
            string name=Console.ReadLine();
            if (ObjectHandler.GetFlightDL().CheckValidFlightID(ID) )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" No such Flight Exist.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Press any key to continue!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                ObjectHandler.GetFlightDL().DeleteFlight(name,ID);
                Console.WriteLine(" The Desired Flight is Sucessfully Deleted.");
                Console.WriteLine(" Press any key to continue!!!");
                Console.ReadKey();
                Console.Clear();
            }
        }
      
        
    }
}
