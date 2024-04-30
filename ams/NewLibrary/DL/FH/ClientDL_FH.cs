using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using NewLibrary.AbstractClasses;

namespace SkyLinesLibrary
{
    
    public class ClientDL_FH :ClientDL ,IClientDL
    {
       
        private static DbConfig db = DbConfig.GetInstance();

        
        public static string filepath;

      
        private static ClientDL_FH ClientFHInstance;

        private ClientDL_FH(string Filepath)
        {
            filepath = Filepath;
            LoadClients(); 
        }

      
        public static ClientDL_FH ClientFHGetInstance(string filepath)
        {
            if (ClientFHInstance == null)
            {
                ClientFHInstance = new ClientDL_FH(filepath);
            }
            return ClientFHInstance;
        }
        public void AddClient(Client client)
        {
            Clients.Add(client);
            StoreClients(client);
        }
        
        public override void LoadClients()
        {
            string record;
            string name, password, role, feedback;
            if (File.Exists(filepath))
            {
                StreamReader Clientfile = new StreamReader(filepath);
                while ((record = Clientfile.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    name = splittedrecord[0];
                    password = splittedrecord[1];
                    role = splittedrecord[2];
                    feedback = splittedrecord[3];
                    Client cl = new Client(name, password, role);
                    Clients.Add(cl);
                    cl.SetFeedBack(feedback);
                    string splittedflights = splittedrecord[4];
                    cl.SetBookedFlights(ReturnReservedFlights(splittedflights));
                }
                Clientfile.Close();
            }
            else
            {
                Console.Write("File Not Found");
            }
        }
        public override void StoreClients(Client cl)
        {
            StreamWriter Clientfile = new StreamWriter(filepath, true);
            Clientfile.Write($"{cl.GetName()},{cl.GetPassword()},{cl.GetRole()},{cl.GetFeedBack()},");
            List<Flight> flights = cl.GetBookedFlights();
            //if count is 0 then write new line
            if (flights.Count == 0)
            {
                Clientfile.Write("\n");
                Clientfile.Flush();
                Clientfile.Close();
                return;
            }
         
            foreach (Flight flight in flights)
            {
                Clientfile.Write(flight.GetFlightID());
                if (flight != flights.Last())
                {
                    Clientfile.Write(";");
                }
                else
                {
                    Clientfile.Write("\n");
                }
            }
            Clientfile.Flush();
            Clientfile.Close();
        }
        public override void UpdateFeedBack(string Name, string feedback)
        {
            File.WriteAllText(filepath, string.Empty);
            foreach (Client cl in Clients)
            {
                StoreClients(cl);
            }

        }
       
        public override List<Flight> ReturnReservedFlights(string ClientName)
        {
            List<Flight> reservedflights = new List<Flight>();
            string FlightID;
            string[] splittedflights = ClientName.Split(';');
            for (int i = 0; i < splittedflights.Length; i++)
            {
                FlightID = splittedflights[i];
                for (int x = 0; x < FlightDL_FH.Flights.Count; x++)
                {
                    if (FlightID == FlightDL_FH.Flights[x].GetFlightID())
                    {
                        Flight fl = FlightDL_FH.Flights[x];
                        reservedflights.Add(fl);
                    }
                }
            }
            return reservedflights;
        }
        public override void StoreBookedFlights(string FlightID, string Name)
        {
            string clfilepath = ClientDL_FH.filepath;
            File.WriteAllText(clfilepath, string.Empty);
            foreach (Client cl in ClientDL_FH.Clients)
            {
                StoreClients(cl);
            }
        }
        public override void DeleteBookedFlights(string flightID, string Name)
        {
            string clfilepath = ClientDL_FH.filepath;
            File.WriteAllText(clfilepath, string.Empty);
            foreach (Client cl in ClientDL_FH.Clients)
            {
                StoreClients(cl);
            }
        }
    }
}


