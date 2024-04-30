using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLinesLibrary
{
   
    public class Flight
    {
       
        private string FlightID;
        private string FlightName;
        private string Source;
        private string Destination;
        private double Price;
        private string TravelDate;
        private string TakeoffTime;
        private double Seats;
       

        
        public Flight(string FlightID, string FlightName, string Source, string Destination, string TravelDate, string TakeoffTime, double Price, double Seats)
        {
            this.FlightID = FlightID;
            this.FlightName = FlightName;
            this.Source = Source;
            this.Destination = Destination;
            this.TravelDate = TravelDate;
            this.TakeoffTime = TakeoffTime;
            this.Price = Price;
            this.Seats = Seats;
        }

        public string ViewFlight()
        {
            return ($" {FlightID}\n {FlightName}\n {Source}\n {Destination}\n {TravelDate}\n {TakeoffTime}\n {Price}\n {Seats}");
        }
        public string GetFlightName()
        {
            return FlightName;
        }
        public void SetFlightname(string name)
        {
            this.FlightName = name;
        }
        public string GetFlightID()
        {
            return FlightID;
        }
        public void SetFlightID(string ID)
        {
            this.FlightID = ID;
        }
        public string GetSource()
        {
            return Source;
        }
        public void SetSource(string source)
        {
            this.Source = source;
        }
        public string GetDestination()
        {
            return Destination;
        }
        public void SetDestination(string destination)
        {
            this.Destination = destination;
        }
        public string GetTravelDate()
        {
            return TravelDate;
        }
        public void SetTravelDate(string TravelDate)
        {
            this.TravelDate = TravelDate;
        }
        public string GetTakeoffTime()
        {
            return TakeoffTime;
        }
        public void SetTakeoffTime(string time)
        {
            this.TakeoffTime = time;
        }

        public double GetPrice()
        {
            return Price;
        }
        public void SetPrice(double price)
        {
            this.Price = price;
        }
        public double GetSeats()
        {
            return Seats;
        }
        public void SetSeats(double seats)
        {
            this.Seats = seats;
        }


      
        
    }
}

