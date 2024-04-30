using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NewLibrary.AbstractClasses;
namespace SkyLinesLibrary
{
    
    public class StaffDL_DB :StaffsDL, IStaffDL
    {
       
        private static DbConfig db = DbConfig.GetInstance();

       
        private static StaffDL_DB StaffDBInstance;

       
        private StaffDL_DB(string connectionstring)
        {
           
            LoadStaff();
        }

        public static StaffDL_DB StaffDBGetInstance(string connectionstring)
        {
            if (StaffDBInstance == null)
            {
                StaffDBInstance = new StaffDL_DB(connectionstring);
            }
            return StaffDBInstance;
        }
        public void AddStaff(Staff s)
        {
            AirlineStaff.Add(s);
            StoreStaff(s);
        }
        public void RemoveStaff(string name, string staffID)
        {
            foreach (var staff in AirlineStaff)
            {
                if (staff.GetStaffName() == name && staff.GetStaffID() == staffID)
                {
                    AirlineStaff.Remove(staff);
                    break;
                }
            }
            DeleteStaff(staffID);
        }
        public void EditStaff(string staffID, string newname, string newdesignation, double newsalary)
        {
            foreach (var staff in AirlineStaff)
            {
                if (staff.GetStaffID() == staffID)
                {
                    staff.SetStaffName(newname);
                    staff.SetStaffDesignation(newdesignation);
                    staff.SetStaffSalary(newsalary);
                    break;
                }
            }
            UpdateStaff(staffID, newname, newdesignation, newsalary);
        }
        
       
        public override void LoadStaff()
        {
            string name, ID, designation;
            double salary;
            string searchquery = "Select * From Staff";
            SqlCommand command = new SqlCommand(searchquery, db.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0);
                ID = reader.GetString(1);
                designation = reader.GetString(2);
                salary = reader.GetDouble(3);
                Staff s = new Staff(name, ID, designation, salary);
                AirlineStaff.Add(s);
            }
            reader.Close();
        }
        public override void StoreStaff(Staff st)
        {
            string query = string.Format("INSERT INTO Staff(StaffName,StaffID,StaffDesignation,StaffSalary)" + "Values ('{0}','{1}','{2}','{3}')", st.GetStaffName(), st.GetStaffID(), st.GetStaffDesignation(), st.GetStaffSalary());
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public override void UpdateStaff(string originalID, string name, string designation, double salary)
        {
            string query = string.Format("UPDATE Staff SET StaffName='{0}',StaffDesignation='{1}',StaffSalary='{2}' WHERE StaffID='{3}'", name, designation, salary, originalID);
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public override void DeleteStaff(string staffID)
        {
            string query = string.Format("DELETE FROM Staff WHERE StaffID='{0}'", staffID);
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }
       
    }
}

