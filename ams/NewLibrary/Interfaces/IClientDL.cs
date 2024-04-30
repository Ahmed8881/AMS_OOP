using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLinesLibrary
{
    public interface IClientDL
    {
        void AddClient(Client client);
        bool IsClientExist(string name, string password);
        int FindClient(string name, string password);
        bool CheckValidClientName(string name);
        void LoadClients();
        void StoreClients(Client cl);
        void UpdateFeedBack(string Name, string feedback);
        List<Client> GetAllClients();
        List<Flight> ReturnReservedFlights(string ClientName);
        void StoreBookedFlights(string FlightID, string Name);
        void DeleteBookedFlights(string flightID, string Name);
    }
}
