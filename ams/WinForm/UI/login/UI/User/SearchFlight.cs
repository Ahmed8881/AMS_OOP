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

namespace login.UI.User
{
    public partial class SearchFlight : Form
    {
        public SearchFlight()
        {
            InitializeComponent();
        }
        private void PrintFlights()
        {

            string id = FlightId.Text;
            string name = FlightName.Text;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FlightID", typeof(string));
            dataTable.Columns.Add("FlightName", typeof(String));
            dataTable.Columns.Add("DepartureAirport", typeof(string));
            dataTable.Columns.Add("ArrivalAirport", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("TravelDate", typeof(string));
            dataTable.Columns.Add("TakeoffTime", typeof(string));
            dataTable.Columns.Add("Seats", typeof(double));
            SearchFlightGrid.DataSource = dataTable;
            List<Flight> flight = ObjectHandler.GetFlightDL().GetAllFlights();

            if (flight != null && flight.Count > 0)
            {
                foreach (Flight fl in flight)
                {
                    if (fl.GetFlightID() == id && fl.GetFlightName() == name)
                    {
                        dataTable.Rows.Add(fl.GetFlightID(), fl.GetFlightName(), fl.GetSource(), fl.GetDestination(), fl.GetPrice(), fl.GetTravelDate(), fl.GetTakeoffTime(), fl.GetSeats());
                    }
                }
            }

            SearchFlightGrid.DataSource = dataTable;


        }

        private void FillFlightNameComboBox()
        {
            //fill the combobox with flight names
            List<Flight> flight = ObjectHandler.GetFlightDL().GetAllFlights();
            if (flight != null && flight.Count > 0)
            {
                foreach (Flight fl in flight)
                {
                    FlightName.Items.Add(fl.GetFlightName());
                }
            }
        }
        private void FillFlightIDComboBox()
        {
            //fill the combobox with flight IDs
            List<Flight> flight = ObjectHandler.GetFlightDL().GetAllFlights();
            if (flight != null && flight.Count > 0)
            {
                foreach (Flight fl in flight)
                {
                    FlightId.Items.Add(fl.GetFlightID());
                }
            }
        }


        private void SearchFlight_Load(object sender, EventArgs e)
        {
            FillFlightIDComboBox();
            FillFlightNameComboBox();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            PrintFlights();
        }
    }
}
