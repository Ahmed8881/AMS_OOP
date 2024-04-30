using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NewLibrary.AbstractClasses;

namespace SkyLinesLibrary
{
    
    public class ClientDL_DB : ClientDL,IClientDL
    {
        

        
        private static DbConfig db = DbConfig.GetInstance();

       
        private static ClientDL_DB ClientDBInstance;

        
        private ClientDL_DB(string connectionstring)
        {
            LoadClients();
        }
        public static ClientDL_DB ClientDBGetInstance(string connectionstring)
        {
            if (ClientDBInstance == null)
            {
                ClientDBInstance = new ClientDL_DB(connectionstring);
            }
            return ClientDBInstance;
        }
        public void AddClient(Client client)
        {
            Clients.Add(client);
            StoreClients(client);
        }
      
     
    
        public  override void LoadClients()
        {
            string name, password, role;
            string searchquery = "Select * From Clients";
            SqlCommand command = new SqlCommand(searchquery, db.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                name = dt.Rows[i]["ClientName"].ToString();
                password = dt.Rows[i]["ClientPassword"].ToString();
                role = dt.Rows[i]["Role"].ToString();
                Client client = new Client(name, password, role);
                client.SetBookedFlights(ReturnReservedFlights(name));

                string feedback = dt.Rows[i]["FeedBack"].ToString();
                client.SetFeedBack(feedback);

                Clients.Add(client);
            }
        }
        public override void StoreClients(Client cl)
        {
            string query = string.Format("INSERT INTO Clients(ClientName,ClientPassword,Role,FeedBack)" + "Values ('{0}','{1}','{2}','{3}')", cl.GetName(), cl.GetPassword(), cl.GetRole(), cl.GetFeedBack());
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public override void UpdateFeedBack(string Name, string feedback)
        {

            string query = string.Format("UPDATE Clients SET FeedBack='{0}'WHERE ClientName='{1}'", feedback, Name);
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }

        public override List<Flight> ReturnReservedFlights(string ClientName)
        {
            string FlightID;
            string searchquery = String.Format("Select * From ReservedFlights Where ClientName='{0}'", ClientName);
            SqlCommand command = new SqlCommand(searchquery, db.GetConnection());
            List<Flight> reservedflights = new List<Flight>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FlightID = reader.GetString(0);
                for (int i = 0; i < FlightDL_DB.Flights.Count; i++)
                {
                    if (FlightDL_DB.Flights[i].GetFlightID() == FlightID)
                    {
                        reservedflights.Add(FlightDL_DB.Flights[i]);
                    }
                }

            }
            reader.Close();
            return reservedflights;
        }
        public override void StoreBookedFlights(string FlightID, string Name)
        {
            string query = string.Format("INSERT INTO ReservedFlights(FlightID,ClientName)" + "Values ('{0}','{1}')", FlightID, Name);
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public override void DeleteBookedFlights(string flightID, string Name)
        {
            string query = string.Format("DELETE FROM ReservedFlights WHERE FlightID='{0}' AND ClientName='{1}'", flightID, Name);
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }
    }
}
