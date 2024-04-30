
using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.UI.Admin
{
    public partial class Add_Flight : Form
    {
            
        public Add_Flight()
        {
            InitializeComponent();
            GridView();
        }
        public void Clear() {
            FlightID.Text = "";
            FlightName.Text = "";
            StartPlace.Text = "";
            Destination.Text = "";
            TakeOffTime.Text = "";
            Price.Text = "";
            Seats.Text = "";

        }

       

      
        
       

       
        private void GridView()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FlightID", typeof(string));
            dataTable.Columns.Add("FlightName", typeof(String));
            dataTable.Columns.Add("DepartureAirport", typeof(string));
            dataTable.Columns.Add("ArrivalAirport", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("TravelDate", typeof(string));
            dataTable.Columns.Add("TakeoffTime", typeof(string));
            dataTable.Columns.Add("Seats", typeof(double));
           
            List<Flight> flight = ObjectHandler.GetFlightDL().GetAllFlights();

            if (flight != null && flight.Count > 0)
            {
                foreach (Flight fl in flight)
                {
                    dataTable.Rows.Add(fl.GetFlightID(), fl.GetFlightName(), fl.GetSource(), fl.GetDestination(), fl.GetPrice(), fl.GetTravelDate(), fl.GetTakeoffTime(), fl.GetSeats());
                }
            }

            AddFlightGrid.DataSource = dataTable;


        }
        private void AddFlight_Click(object sender, EventArgs e)
        {
            if (AreFieldsNotEmpty() && AreFieldsValid())
            {
                if (IsFlightIdValid())
                {
                    if (IsTakeOffTimeValid())
                    {
                        if (IsPriceValid())
                        {
                            if (IsSeatsValid())
                            {
                                AddNewFlight();
                            }
                            else
                            {
                                MessageBox.Show("Enter Valid Integer in Seats Field.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Valid Number in Price Field.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Time Format.Enter Valid Time in Takeoff Time Field.");
                    }
                }
                else
                {
                    MessageBox.Show("This FlightID Already Exist.Enter some other ID.");
                }
            }
            else
            {
                MessageBox.Show(", and ; is not allowed in any field.");
            }
        }

        private bool AreFieldsNotEmpty()
        {
            return !string.IsNullOrWhiteSpace(FlightID.Text) && !string.IsNullOrWhiteSpace(FlightName.Text) && !string.IsNullOrWhiteSpace(StartPlace.Text) && !string.IsNullOrWhiteSpace(Destination.Text) && !string.IsNullOrWhiteSpace(TakeOffTime.Text) && !string.IsNullOrWhiteSpace(date.Text) && !string.IsNullOrWhiteSpace(Price.Text) && !string.IsNullOrWhiteSpace(Seats.Text);
        }

        private bool AreFieldsValid()
        {
            return Validations.CheckCommaColon(FlightID.Text) && Validations.CheckCommaColon(FlightName.Text) && Validations.CheckCommaColon(StartPlace.Text) && Validations.CheckCommaColon(Destination.Text) && Validations.CheckSemicolon(date.Text);
        }

        private bool IsFlightIdValid()
        {
            return ObjectHandler.GetFlightDL().CheckValidFlightID(FlightID.Text);
        }

        private bool IsTakeOffTimeValid()
        {
            return Validations.CheckValidTime(TakeOffTime.Text);
        }

        private bool IsPriceValid()
        {
            return Validations.CheckNumber(Price.Text);
        }

        private bool IsSeatsValid()
        {
            return Validations.CheckInteger(Seats.Text);
        }

        private void AddNewFlight()
        {
            string ID = FlightID.Text;
            string Name = FlightName.Text;
            string Departure = StartPlace.Text;
            string Arrival = Destination.Text;
            string Date = date.Text;
            string Takeoff = TakeOffTime.Text;
            double price = double.Parse(Price.Text);
            double seats = double.Parse(Seats.Text);
            
            Flight f = new Flight(ID, Name, Departure, Arrival, Date, Takeoff, price, seats);
            ObjectHandler.GetFlightDL().AddFlight(f);
            MessageBox.Show("Flight is successfully Added.");
            Clear();
            GridView();
        }
        
        
    }
}
