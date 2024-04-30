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
    public partial class RemoveStaff : Form
    {
        public RemoveStaff()
        {
            InitializeComponent();
            printStaff();
        }
        private void printStaff()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StaffID", typeof(string));
            dataTable.Columns.Add("StaffName", typeof(String));
            dataTable.Columns.Add("Designation", typeof(string));
            dataTable.Columns.Add("Salary", typeof(double));
            RemoveStaffGrid.DataSource = dataTable;
            List<Staff> staff = ObjectHandler.GetStaffDL().GetAllStaff();

            if (staff != null && staff.Count > 0)
            {
                foreach (Staff s in staff)
                {
                    dataTable.Rows.Add(s.GetStaffID(), s.GetStaffName(), s.GetStaffDesignation(), s.GetStaffSalary());
                }
            }

            RemoveStaffGrid.DataSource = dataTable;


        }
        public void Clear()
        {
            ID.Text = "";
            Name.Text = "";
            
        }
        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ID.Text) && !string.IsNullOrWhiteSpace(Name.Text))
            {
                string id = ID.Text;
                string name = Name.Text;
                ObjectHandler.GetStaffDL().RemoveStaff(name, id);
                MessageBox.Show("Staff Removed Successfully");
                Clear();
                printStaff();
            }
            else
            {
                MessageBox.Show("Please Fill In all the Required Fields");
            }
        }

        private void RemoveStaffGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Fill the text boxes with the selected row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RemoveStaffGrid.Rows[e.RowIndex];
                ID.Text = row.Cells["StaffID"].Value.ToString();
                Name.Text = row.Cells["StaffName"].Value.ToString();
               
            }

        }
    }
    }

