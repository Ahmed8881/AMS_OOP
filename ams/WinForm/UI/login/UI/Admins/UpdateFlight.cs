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
using System.Xml.Linq;

namespace login.UI.Admin
{
    public partial class UpdateFlight : Form
    {
        // Constructor
        public UpdateFlight()
        {
            InitializeComponent();
            FillGrid();
        }

        // Method to clear all text fields
        public void Clear()
        {
            ID.Text = "";
            FlightName.Text = "";
            StartPlace.Text = "";
            date.Text = "";
            Destination.Text = "";
            TakeOffTime.Text = "";
            Price.Text = "";
            Seats.Text = "";
        }

        // Method to fill the data grid with flight details
        private void FillGrid()
        {
            // Create a new DataTable and define its columns
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FlightID", typeof(string));
            dataTable.Columns.Add("FlightName", typeof(String));
            dataTable.Columns.Add("DepartureAirport", typeof(string));
            dataTable.Columns.Add("ArrivalAirport", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("TravelDate", typeof(string));
            dataTable.Columns.Add("TakeoffTime", typeof(string));
            dataTable.Columns.Add("Seats", typeof(double));

            // Get all flights and add them to the DataTable
            List<Flight> flight = ObjectHandler.GetFlightDL().GetAllFlights();
            if (flight != null && flight.Count > 0)
            {
                foreach (Flight fl in flight)
                {
                    dataTable.Rows.Add(fl.GetFlightID(), fl.GetFlightName(), fl.GetSource(), fl.GetDestination(), fl.GetPrice(), fl.GetTravelDate(), fl.GetTakeoffTime(), fl.GetSeats());
                }
            }

            // Set the DataTable as the data source for the grid
            UpdateFlightGrid.DataSource = dataTable;
        }

        // Event handler for cell click in the data grid
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Fill text boxes with the data of the selected row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.UpdateFlightGrid.Rows[e.RowIndex];
                ID.Text = row.Cells["FlightID"].Value.ToString();
                FlightName.Text = row.Cells["FlightName"].Value.ToString();
                StartPlace.Text = row.Cells["DepartureAirport"].Value.ToString();
                Destination.Text = row.Cells["ArrivalAirport"].Value.ToString();
                Price.Text = row.Cells["Price"].Value.ToString();
                date.Text = row.Cells["TravelDate"].Value.ToString();
                TakeOffTime.Text = row.Cells["TakeoffTime"].Value.ToString();
                Seats.Text = row.Cells["Seats"].Value.ToString();
            }
        }

        // Event handler for the Update button click
        private void Update_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled and valid, and if the flight exists
            if (AreFieldsFilled())
            {
                if (AreFieldsValid())
                {
                    if (IsFlightExist())
                    {
                        if (IsTimeValid())
                        {
                            if (IsPriceValid())
                            {
                                if (IsSeatsValid())
                                {
                                    // If all checks pass, update the flight details
                                    UpdateFlightDetails();
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
                        MessageBox.Show("No Such Flight Exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect syntax");
                }
            }
            else
            {
                MessageBox.Show("Please Fill In all the required Fields");
            }
        }

        // Check if all fields are filled
        private bool AreFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(ID.Text) && !string.IsNullOrWhiteSpace(FlightName.Text) && !string.IsNullOrWhiteSpace(StartPlace.Text) && !string.IsNullOrWhiteSpace(Destination.Text) && !string.IsNullOrWhiteSpace(TakeOffTime.Text) && !string.IsNullOrWhiteSpace(date.Text) && !string.IsNullOrWhiteSpace(Price.Text) && !string.IsNullOrWhiteSpace(Seats.Text);
        }

        // Check if all fields are valid
        private bool AreFieldsValid()
        {
            return Validations.CheckCommaColon(StartPlace.Text) && Validations.CheckCommaColon(Destination.Text) && Validations.CheckSemicolon(date.Text);
        }

        // Check if the flight exists
        private bool IsFlightExist()
        {
            return ObjectHandler.GetFlightDL().IsFlightExist(ID.Text);
        }

        // Check if the time is valid
        private bool IsTimeValid()
        {
            return Validations.CheckValidTime(TakeOffTime.Text);
        }

        // Check if the price is valid
        private bool IsPriceValid()
        {
            return Validations.CheckNumber(Price.Text);
        }

        // Check if the seats number is valid
        private bool IsSeatsValid()
        {
            return Validations.CheckInteger(Seats.Text);
        }

        // Update the flight details
        private void UpdateFlightDetails()
        {
            string id= ID.Text;
            string flightName = FlightName.Text;
            string Departure = StartPlace.Text;
            string Arrival = Destination.Text;
            double price = double.Parse(Price.Text);
            string Date = date.Text;
            string Takeoff = TakeOffTime.Text;
            double seats = double.Parse(Seats.Text);
            ObjectHandler.GetFlightDL().EditFlight(flightName, id, Departure, Arrival, Date, Takeoff, price, seats);
            MessageBox.Show("Flight is successfully Updated.");
            Clear();
            FillGrid();
        }

        private void UpdateFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
