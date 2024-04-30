using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLinesLibrary
{
    public interface IFlightDL
    {
        void AddFlight(Flight f);
        void EditFlight(string name, string flightID, string source, string destination, string date, string takeoff, double price, double seats);
        bool CheckValidFlightID(string ID);
        bool IsFlightExist(string ID);
        void LoadFlights();
     
        void StoreFlights(Flight fl);
        void UpdateFlight(string originalID, string source, string destination, string date, string takeoff, double price, double seats);
       
       
        List<Flight> GetAllFlights();
        void DeleteFlight(string name, string FlightId);
        Flight GetFlightByID(string FlightID);
    }
}

