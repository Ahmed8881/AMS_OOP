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
    public partial class CancelReservedFlight : Form
    {
        public CancelReservedFlight()
        {
            InitializeComponent();
            Print();
        }
        private void Print() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FlightID", typeof(string));
            dataTable.Columns.Add("FlightName", typeof(String));
            dataTable.Columns.Add("DepartureAirport", typeof(string));
            dataTable.Columns.Add("ArrivalAirport", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("TravelDate", typeof(string));
            dataTable.Columns.Add("TakeoffTime", typeof(string));
            dataTable.Columns.Add("Seats", typeof(double));
            CancelFlightGrid.DataSource = dataTable;
            List<Client> clients = ObjectHandler.GetClientDL().GetAllClients();
            List<Flight> flight = clients[Login.Index].GetBookedFlights();

            if (flight != null && flight.Count > 0)
            {
                foreach (Flight fl in flight)
                {
                    dataTable.Rows.Add(fl.GetFlightID(), fl.GetFlightName(), fl.GetSource(), fl.GetDestination(), fl.GetPrice(), fl.GetTravelDate(), fl.GetTakeoffTime(), fl.GetSeats());
                }
            }

            CancelFlightGrid.DataSource = dataTable;

        }
        private void Clear() { 
        FlightName.Text = "";
            FlightID.Text = "";
        }
        private void CancelBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FlightID.Text) && !string.IsNullOrWhiteSpace(FlightName.Text))
            {
                string ID = FlightID.Text;
                string Name = FlightName.Text;
                List<Client> clients = ObjectHandler.GetClientDL().GetAllClients();
                Flight f = clients[Login.Index].CancelFlight(ID);
                if (f != null)
                {
                    ObjectHandler.GetFlightDL().EditFlight(f.GetFlightName(), f.GetFlightID(), f.GetSource(), f.GetDestination(), f.GetTravelDate(), f.GetTakeoffTime(), f.GetPrice(), f.GetSeats());
                    ObjectHandler.GetClientDL().DeleteBookedFlights(ID, clients[Login.Index].GetName());

                    MessageBox.Show("Flight is successfully Cancelled.");
                    Clear();
                    Print();
                }
                else
                {
                    MessageBox.Show("No such booking you have");
                }
            }
            else
            {
                MessageBox.Show("Please Fill In all the Required Fields");
            }
        }

        private void CancelFlightGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FlightID.Text = (CancelFlightGrid.SelectedRows[0].Cells[0].Value).ToString();
          FlightName.Text = CancelFlightGrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void CancelReservedFlight_Load(object sender, EventArgs e)
        {
            Print();
        }
    }
}
