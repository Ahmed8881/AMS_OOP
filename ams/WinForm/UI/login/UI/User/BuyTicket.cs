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
    public partial class BuyTicket : Form
    {
        public BuyTicket()
        {
            InitializeComponent();
            PrintFlights();
        }
        public void Clear()
        {
            FlightId.Text = "";
            FlightName.Text = "";
        }
        private void PrintFlights()
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
            FlightBookGrid.DataSource = dataTable;
            List<Flight> flight = ObjectHandler.GetFlightDL().GetAllFlights();

            if (flight != null && flight.Count > 0)
            {
                foreach (Flight fl in flight)
                {
                    if (fl.GetSeats() > 0)
                    {
                        dataTable.Rows.Add(fl.GetFlightID(), fl.GetFlightName(), fl.GetSource(), fl.GetDestination(), fl.GetPrice(), fl.GetTravelDate(), fl.GetTakeoffTime(), fl.GetSeats());
                    }
                }
            }

            FlightBookGrid.DataSource = dataTable;


        }
        private void BookTicket_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FlightId.Text) && !string.IsNullOrWhiteSpace(FlightName.Text))
            {
                if (ObjectHandler.GetFlightDL().IsFlightExist(FlightId.Text))
                {
                    string ID = FlightId.Text;
                    string Name = FlightName.Text;
                    List<Client> clients = ObjectHandler.GetClientDL().GetAllClients();
                    Flight f = ObjectHandler.GetFlightDL().GetFlightByID(ID);
                    if (clients[Login.Index].BookFlight(f))
                    {
                        ObjectHandler.GetFlightDL().EditFlight(f.GetFlightName(), f.GetFlightID(), f.GetSource(), f.GetDestination(), f.GetTravelDate(), f.GetTakeoffTime(), f.GetPrice(), f.GetSeats());
                        ObjectHandler.GetClientDL().StoreBookedFlights(ID, clients[Login.Index].GetName());

                        MessageBox.Show("Flight is successfully Booked.");
                        Clear();

                    }
                    else
                    {
                        MessageBox.Show("You Already booked this flight.");
                    }
                }
                else
                {
                    MessageBox.Show("No such Flight Exist.");
                }
            }
            else
            {
                MessageBox.Show("Please Fill In all the Required Fields");
            }
        }

        private void FlightBookGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Fill the text boxes with the selected row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.FlightBookGrid.Rows[e.RowIndex];
                FlightId.Text = row.Cells["FlightID"].Value.ToString();
                FlightName.Text = row.Cells["FlightName"].Value.ToString();
            }
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            PrintFlights();
        }
    }
}
