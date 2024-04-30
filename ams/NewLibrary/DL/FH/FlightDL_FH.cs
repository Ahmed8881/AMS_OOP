using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
using NewLibrary.AbstractClasses;

namespace SkyLinesLibrary
{
    
    public class FlightDL_FH : FlightsDL,IFlightDL
    {
        

       
        private static DbConfig db = DbConfig.GetInstance();

        
        private static string filepath;

       
        private static FlightDL_FH FlightFHInstance;

        private FlightDL_FH(string FilePath)
        {
            filepath = FilePath;
            LoadFlights(); 
        }

       
        public static FlightDL_FH GetFlightDL_FHInstance(string FilePath)
        {
            if (FlightFHInstance == null)
            {
                FlightFHInstance = new FlightDL_FH(FilePath);
            }
            return FlightFHInstance;
        }
        public void AddFlight(Flight f)
        {
            Flights.Add(f);
            StoreFlights(f);
        }

        public void DeleteFlight(string name, string FlightId)
        {
            DeleteFlightFromList(name, FlightId);
            RemoveFlightFromFile(FlightId);
        }

       

        private void RemoveFlightFromFile(string FlightId)
        {
            string tempFile = Path.GetTempFileName();
            using (var sr = new StreamReader(filepath))
            using (var sw = new StreamWriter(tempFile))
            {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(FlightId))
                continue;
                sw.WriteLine(line);
            }
            }
            File.Delete(filepath);
            File.Move(tempFile, filepath);
        }
        public override void  EditFlight(string name, string flightID, string source, string destination, string date, string takeoff, double price, double seats)
        {
            for (int i = 0; i < Flights.Count; i++)

            {
                if (Flights[i].GetFlightName() == name && Flights[i].GetFlightID() == flightID)
                {
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
            string  record;
            
            if (File.Exists(filepath))
            {
                StreamReader flightfile = new StreamReader(filepath);
                while ((record = flightfile.ReadLine()) != null)
                {
                    string[] data = record.Split(';');
                   string ID = data[0];
                   string name = data[1];
                   string source = data[2];
                   string destination = data[3];
                   string date = data[4];
                   string takeoff = data[5];
                   double price = double.Parse(data[6]);


                   double seats = double.Parse(data[7]);
                    
                    Flight f = new Flight(ID, name, source, destination, date, takeoff, price, seats);
                   
                    Flights.Add(f);
                }
                flightfile.Close();
            }
            else { return; }
        }

        public override void StoreFlights(Flight fl)
        {
            StreamWriter Flightfile = new StreamWriter(filepath, true);
            Flightfile.WriteLine($"{fl.GetFlightID()}; {fl.GetFlightName()};{fl.GetSource()};{fl.GetDestination()}; {fl.GetTravelDate()}; {fl.GetTakeoffTime()}; {fl.GetPrice()}; {fl.GetSeats()};");
            Flightfile.Flush();
            Flightfile.Close();
        }
        public override void UpdateFlight(string originalID, string source, string destination, string date, string takeoff, double price, double seats)
        {
            File.WriteAllText(filepath, string.Empty);
            foreach (Flight fl in Flights)
            {
                StoreFlights(fl);
            }
        }

       
      
       
       
    }
}



