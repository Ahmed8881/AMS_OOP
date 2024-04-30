using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibrary.AbstractClasses
{
    public abstract class ClientDL
    {
        protected static List<Client> Clients = new List<Client>();
        public bool IsClientExist(string name, string password)
        {
            foreach (Client client in Clients)
            {
                if (client.GetName() == name && client.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }
        public int FindClient(string name, string password)
        {
            int ClientNo = 10000;
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].GetName() == name && Clients[i].GetPassword() == password)
                {
                    ClientNo = i;
                    return ClientNo;
                }
            }
            return ClientNo;
        }
        public List<Client> GetAllClients()
        {
            return Clients;
        }
        public bool CheckValidClientName(string name)
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].GetName() == name)
                {
                    return false;
                }
            }
            return true;
        }
        public abstract void LoadClients();
        public abstract void StoreClients(Client client);
        public abstract void UpdateFeedBack(string Name, string feedback);
        public abstract List<Flight> ReturnReservedFlights(string ClientName);
        public abstract void StoreBookedFlights(string FlightID, string Name);
        public abstract void DeleteBookedFlights(string flightID, string Name);
    }
}
