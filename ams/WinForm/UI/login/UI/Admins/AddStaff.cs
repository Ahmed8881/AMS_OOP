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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
            printStaff();
        }
        public void Clear()
        {
            ID.Text = "";
            Name.Text = "";
            Posst.Text = "";
            Salary.Text = "";
        }
        private void printStaff()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StaffID", typeof(string));
            dataTable.Columns.Add("StaffName", typeof(String));
            dataTable.Columns.Add("Designation", typeof(string));
            dataTable.Columns.Add("Salary", typeof(double));
            StaffShowGrid.DataSource = dataTable;
            List<Staff> staff = ObjectHandler.GetStaffDL().GetAllStaff();

            if (staff != null && staff.Count > 0)
            {
                foreach (Staff s in staff)
                {
                    dataTable.Rows.Add(s.GetStaffID(), s.GetStaffName(), s.GetStaffDesignation(), s.GetStaffSalary());
                }
            }

            StaffShowGrid.DataSource = dataTable;


        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ID.Text) && !string.IsNullOrWhiteSpace(Name.Text) && !string.IsNullOrWhiteSpace(Posst.Text) && !string.IsNullOrWhiteSpace(Salary.Text))
            {
                if (Validations.CheckCommaColon(ID.Text) && Validations.CheckCommaColon(Name.Text) && Validations.CheckCommaColon(Posst.Text))
                {
                    if (ObjectHandler.GetStaffDL().CheckValidStaffID(ID.Text))
                    {
                        if (Validations.CheckNumber(Salary.Text))
                        {
                            string id = ID.Text;
                            string name = Name.Text;
                            string Designation = Posst.Text;
                            double salary = double.Parse(Salary.Text);
                            Staff s = new Staff(name, id, Designation, salary);
                            ObjectHandler.GetStaffDL().AddStaff(s);
                            MessageBox.Show("Staff is successfully Hired.");
                            Clear();
                            printStaff();
                        }
                        else
                        {
                            MessageBox.Show("Enter Valid Number in Salary Field.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This StaffID Already Exist.Enter some other ID.");
                    }
                }
                else
                {
                    MessageBox.Show(", and ; is not allowed in any field.");
                }
            }
            else
            {
                MessageBox.Show("Please Fill In all the required Fields");
            }
        }

        private void AddStaffGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
