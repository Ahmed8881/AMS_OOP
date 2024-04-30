
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyLinesLibrary;

namespace login.UI.Admin
{
    public partial class RemoveFlight : Form
    {
        
        public RemoveFlight()
        {
            InitializeComponent();
            FillGrid();
        }
        public void FillGrid()
        {
            //load grid with flight details
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
                    dataTable.Rows.Add(fl.GetFlightID(), fl.GetFlightName(), fl.GetSource(), fl.GetDestination(), fl.GetPrice(),  fl.GetTravelDate(), fl.GetTakeoffTime(), fl.GetSeats());
                }
            }
            RemoveFlightGrid.DataSource = dataTable;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FLIGHTID.Text) && !string.IsNullOrWhiteSpace(FLIGHTNAME.Text))
            {

                string id = FLIGHTID.Text;
                string name = FLIGHTNAME.Text;
                ObjectHandler.GetFlightDL().DeleteFlight(name, id);
                MessageBox.Show("Flight Deleted Successfully");
                Clear();
                FillGrid();
            }
            else
                MessageBox.Show("First Fill All the Fields correctly");


            }
            
            
            
            
            




        private void Clear()
        {
            FLIGHTNAME.Text = "";
            FLIGHTID.Text = "";
        }

        private void RemoveFlightGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //fill textt boxes on click
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RemoveFlightGrid.Rows[e.RowIndex];
                FLIGHTID.Text = row.Cells["FlightID"].Value.ToString();
                FLIGHTNAME.Text = row.Cells["FlightName"].Value.ToString();
               
            }


        }
    }
}
