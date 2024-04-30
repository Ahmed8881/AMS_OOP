using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.UI
{
    internal class ClientUI
    {
        public static int ClientMenu()
        {
            while (true)
            {
                DisplayClientMenu();
                string input = Console.ReadLine();
                if (!IsValidInput(input))
                {
                    AdminUI.DisplayInvalidInputMessage();
                    continue;
                }
                int option = int.Parse(input);
                Console.Clear();
                return option;
            }
        }

        private static void DisplayClientMenu()
        {
            Console.WriteLine(" \t\t\t\tClient's Menu\n\n");
            Console.WriteLine(" 1. Search Flights");
            Console.WriteLine(" 2. Book Flight");
            Console.WriteLine(" 3. View Reserved Flights");
            Console.WriteLine(" 4. Log Out");
            Console.Write(" Enter Option Number: ");
        }

        private static bool IsValidInput(string input)
        {
            return input == "1" || input == "2" || input == "3" || input == "4";
        }
        public static bool SearchFlight()
        {
            List<Flight> Flights = ObjectHandler.GetFlightDL().GetAllFlights();
            int count = 0;
            Console.WriteLine("\t\t\t Search Flights\n\n");
            Console.Write(" Enter Departure Airport: ");
            string source = Console.ReadLine();
            Console.Write(" Enter Arrival Airport: ");
            string destination = Console.ReadLine();
            Console.WriteLine("Flight ID\t\t\t Flight Name\t\t\t Depature Airport\t\t Arrival Airport\t\t Departure Date\t\t Departure Time \t\t Landing Time\t\t Price\t\t Seats\n");
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].GetSource() == source && Flights[i].GetDestination() == destination && Flights[i].GetSeats() > 0)
                {
                    Console.WriteLine(Flights[i].ViewFlight());
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(" No such Flights Available.");
                Console.WriteLine("\n\n Press any key to Continue..");
                Console.ReadKey();
                Console.Clear();
                return false;
            }

            return true;
        }
        public static void DispalyBookedFlights(int clientNo)
        {
            List<Client> clients = ObjectHandler.GetClientDL().GetAllClients();
            Console.WriteLine("\n\n\n\t\t\t View Booked Flights\n\n");
            Console.WriteLine("Flight ID\t\t\t Flight Name\t\t\t Depature Airport\t\t Arrival Airport\t\t Departure Date\t\t Departure Time \t\t Landing Time\t\t Price\t\t Seats\n");
            for (int i = 0; i < clients[clientNo].GetBookedFlights().Count; i++)
            {
                Console.WriteLine(clients[clientNo].GetBookedFlights()[i].ViewFlight());
            }
        }
        public static void BookingInput(int clientno)
        {
            int count = 0;
            List<Flight> Flights = ObjectHandler.GetFlightDL().GetAllFlights();
            Console.WriteLine("\n\n\n\t\t\t Book Flight\n\n");
            Console.Write(" Enter Flight ID: ");
            string ID = Console.ReadLine();
            Flight fl;
            List<Client> clients = ObjectHandler.GetClientDL().GetAllClients();
            foreach (Flight f in Flights)
            {
                if (f.GetFlightID() == ID && f.GetSeats() > 0)
                {

                    fl = f;
                    count++;
                    if (clients[clientno].BookFlight(fl))
                    {
                        ObjectHandler.GetFlightDL().EditFlight(f.GetFlightName(), f.GetFlightID(), f.GetSource(), f.GetDestination(), f.GetTravelDate(), f.GetTakeoffTime(), f.GetPrice(), f.GetSeats());
                        ObjectHandler.GetClientDL().StoreBookedFlights(ID, clients[clientno].GetName());
                        Console.WriteLine(" \n\nThe Flight is Sucessfully Booked.");
                        Console.WriteLine("\n\n Press any key to Continue..");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                        Console.WriteLine("\n\n The Flight is Already Booked.");
                }
            }
            if (count == 0)
            {
                Console.WriteLine(" No Such Flight Available.");
                Console.WriteLine("\n\n Press any key to Continue..");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
