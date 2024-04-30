using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkyLinesLibrary
{
    // The Client class inherits from the Person class, demonstrating the OOP concept of inheritance.
    public class Client : Person
    {
        
        private string FeedBack;
        private List<Flight> BookedFlights;

       
        public Client(string name, string password, string role) : base(name, password, role)
        {
           
            BookedFlights = new List<Flight>();
        }
        public void SubmitFeedBack(string feedback)
        {



            this.FeedBack = feedback;


        }
        public string ViewFeedBack()
        {
            return ($" FeedBack By {Name}:  {FeedBack}");
        }
        public bool BookFlight(Flight f)
        {
            for (int i = 0; i < BookedFlights.Count; i++)
            {
                if (BookedFlights[i].GetFlightID() == f.GetFlightID())
                {
                    return false;
                }
            }
            double Seats = f.GetSeats() - 1;
            f.SetSeats(Seats);
            BookedFlights.Add(f);
            return true;
        }
        public Flight CancelFlight(string ID)
        {

            for (int i = 0; i < BookedFlights.Count; i++)
            {
                if (BookedFlights[i].GetFlightID() == ID)
                {
                    double Seats = BookedFlights[i].GetSeats() + 1;
                    BookedFlights[i].SetSeats(Seats);
                    Flight f = BookedFlights[i];
                    BookedFlights.RemoveAt(i);
                    return f;
                }
            }
            return null;
        }
        public string GetFeedBack()
        {
            return FeedBack;
        }
        public void SetFeedBack(string FeedBack)
        {
            this.FeedBack = FeedBack;
        }
        public List<Flight> GetBookedFlights()
        {
            return BookedFlights;
        }
        public void SetBookedFlights(List<Flight> BookedFlights)
        {
            this.BookedFlights = BookedFlights;
        }
    }
}
