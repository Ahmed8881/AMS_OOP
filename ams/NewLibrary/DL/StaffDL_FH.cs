using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using NewLibrary.AbstractClasses;
namespace SkyLinesLibrary
{
    
    public class StaffDL_FH : StaffsDL,IStaffDL
    {
        
       

      
        private static DbConfig db = DbConfig.GetInstance();

       
        private static string filepath;

        
        private static StaffDL_FH StaffFHInstance;

       
        private StaffDL_FH(string FilePath)
        {
            filepath = FilePath;
            LoadStaff();
        }

       
        public static StaffDL_FH GetStaffDL_FHInstance(string FilePath)
        {
            if (StaffFHInstance == null)
            {
                StaffFHInstance = new StaffDL_FH(FilePath);
            }
            return StaffFHInstance;
        }
        public void AddStaff(Staff s)
        {
            AirlineStaff.Add(s);
            StoreStaff(s);
        }
        public void RemoveStaff(string name, string staffID)
        {
            foreach (Staff staff in AirlineStaff.ToList())
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
            foreach (Staff staff in AirlineStaff)
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
            string Name, ID, Designation;
            double Salary;
            string record;
            if (File.Exists(filepath))
            {
                StreamReader stafffile = new StreamReader(filepath);
                while ((record = stafffile.ReadLine()) != null)
                {
                    string[] data = record.Split(',');
                    ID = data[0];
                    Name = data[1];
                    Designation = data[2];
                    Salary = double.Parse(data[3]);
                    Staff s = new Staff(Name, ID, Designation, Salary);
                    AirlineStaff.Add(s);
                }
                stafffile.Close();
            }
            else { return; }
        }
        public override void StoreStaff(Staff st)
        {
            StreamWriter stafffile = new StreamWriter(filepath, true);
            stafffile.WriteLine($"{st.GetStaffID()},{st.GetStaffName()},{st.GetStaffDesignation()},{st.GetStaffSalary()}");
            stafffile.Flush();
            stafffile.Close();
        }
        public override void UpdateStaff(string originalID, string name, string designation, double salary)
        {
            File.WriteAllText(filepath, string.Empty);
            foreach (Staff st in AirlineStaff)
            {
                StoreStaff(st);
            }
        }
        public override void DeleteStaff(string staffID)
        {
            File.WriteAllText(filepath, string.Empty);
            foreach (Staff st in AirlineStaff)
            {
                StoreStaff(st);
            }
        }
     
    }
}


