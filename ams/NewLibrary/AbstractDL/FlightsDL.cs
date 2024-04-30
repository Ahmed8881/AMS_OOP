using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibrary.AbstractClasses
{
    public abstract class FlightsDL
    {
        public static List<Flight>Flights = new List<Flight>();
        public void DeleteFlightFromList(string name, string FlightId)
        {
            foreach (var flight in Flights)
            {
                if (flight.GetFlightName() == name && flight.GetFlightID() == FlightId)
                {
                    Flights.Remove(flight);
                    break;
                }
            }
        }
        
        public List<Flight> GetAllFlights()
        {
            return Flights;
        }
        public bool CheckValidFlightID(string ID)
        {
            foreach (var flight in Flights)
            {
                if (flight.GetFlightID() == ID)
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsFlightExist(string ID)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].GetFlightID() == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public Flight GetFlightByID(string FlightID)
        {
            foreach (Flight f in Flights)
            {
                if (f.GetFlightID() == FlightID)
                {
                    return f;
                }
            }
            return null;
        }
       
        public abstract void EditFlight(string name, string flightID, string source, string destination, string date, string takeoff, double price, double seats);
        public abstract void LoadFlights();
        public abstract void StoreFlights(Flight f);
        public abstract void UpdateFlight(string flightID, string source, string destination, string date, string takeoff, double price, double seats);
        
    }
}
