using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using NewLibrary.AbstractClasses;
namespace SkyLinesLibrary
{
   
    public class FlightDL_DB :FlightsDL,IFlightDL
    {




        
        private static DbConfig db = DbConfig.GetInstance();

        
        private static FlightDL_DB FlightDBInstance;

       
        private FlightDL_DB(string connectionstring)
        {
            LoadFlights();
        }

       
        public static FlightDL_DB FlightDBGetInstance(string connectionstring)
        {
            if (FlightDBInstance == null)
            {
                FlightDBInstance = new FlightDL_DB(connectionstring);
            }
            return FlightDBInstance;
        }
        public void AddFlight(Flight f)
        {
            Flights.Add(f);
            StoreFlights(f);
        }


        public void DeleteFlightFromDatabase(string FlightId)
        {
            string query = string.Format("DELETE FROM Flights WHERE FlightID='{0}'", FlightId);
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public void DeleteFlight(string name, string FlightId)
        {
            DeleteFlightFromList(name, FlightId);
            DeleteFlightFromDatabase(FlightId);

        }
        public override void EditFlight(string name, string flightID, string source, string destination, string date, string takeoff, double price, double seats)
        {
            for (int i = 0; i < Flights.Count; i++)

            {
                if (Flights[i].GetFlightName() == name && Flights[i].GetFlightID() == flightID)
                {
                    Flights[i].SetFlightID(flightID);
                    Flights[i].SetFlightname(name);
                    Flights[i].SetSource(source);
                    Flights[i].SetDestination(destination);
                    Flights[i].SetTravelDate(date);
                    Flights[i].SetTakeoffTime(takeoff);
                    Flights[i].SetPrice(price);
                    Flights[i].SetSeats(seats);
                    break;
                }
            }
            UpdateFlight(flightID, source, destination, date, takeoff, price, seats);
        }


        public override void LoadFlights()
        {
            string name, ID, source, destination, date, takeoff;
            double price, seats, discount;
            string searchquery = "Select * From Flights";
            SqlCommand command = new SqlCommand(searchquery, db.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ID = reader.GetString(0);
                name = reader.GetString(1);
                source = reader.GetString(2);
                destination = reader.GetString(3);
                date = reader.GetString(4);
                takeoff = reader.GetString(5);
                price = reader.GetDouble(6);


                seats = reader.GetDouble(7);
                
                Flight f = new Flight(ID, name, source, destination, date, takeoff, price, seats);

                Flights.Add(f);
            }
            reader.Close();
        }

        public override void StoreFlights(Flight fl)
        {
            string query = string.Format("INSERT INTO Flights(FlightID,FlightName,Source,Destination,TravelDate,TakeoffTime,Price,Seats)" + "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", fl.GetFlightID(), fl.GetFlightName(), fl.GetSource(), fl.GetDestination(), fl.GetTravelDate(), fl.GetTakeoffTime(), fl.GetPrice(), fl.GetSeats());
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public override void UpdateFlight(string originalID, string source, string destination, string date, string takeoff, double price, double seats)
        {
            string query = string.Format("UPDATE Flights SET Source='{0}',Destination='{1}',TravelDate='{2}',TakeoffTime='{3}',Price='{4}',Seats='{5}'WHERE FlightID='{6}'", source, destination, date, takeoff, price, seats, originalID);
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }




    }
}


