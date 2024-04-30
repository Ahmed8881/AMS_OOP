
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
    public partial class ViewFlights : Form
    {
        DataTable dataTable = new DataTable();
        private static DbConfig db = DbConfig.GetInstance();
        List<Flight> flightdata;
        public ViewFlights()
        {
            InitializeComponent();
            FillGrid();


        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            
       
           
           

        }

        public void FillGrid() {
           
            dataTable.Columns.Add("FlightID", typeof(string));
            dataTable.Columns.Add("FlightName", typeof(String));
            dataTable.Columns.Add("DepartureAirport", typeof(string));
            dataTable.Columns.Add("ArrivalAirport", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("TravelDate", typeof(string));
            dataTable.Columns.Add("TakeoffTime", typeof(string));
            dataTable.Columns.Add("Seats", typeof(double));
            ViewFliGrid.DataSource = dataTable;
            List<Flight> flight = ObjectHandler.GetFlightDL().GetAllFlights();

            if (flight != null && flight.Count > 0)
            {
                foreach (Flight fl in flight)
                {
                    dataTable.Rows.Add(fl.GetFlightID(), fl.GetFlightName(), fl.GetSource(), fl.GetDestination(), fl.GetPrice(), fl.GetTravelDate(), fl.GetTakeoffTime(), fl.GetSeats());
                   
                }
            }

            ViewFliGrid.DataSource = dataTable;

        }

        private void ViewFlights_Load_1(object sender, EventArgs e)
        {

        }

        private void ViewFliGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
