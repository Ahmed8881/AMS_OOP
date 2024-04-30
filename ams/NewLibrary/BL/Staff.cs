using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLinesLibrary
{
   
    public class Staff
    {
        
        private string StaffName;
        private string StaffID;
        private string StaffDesignation;
        private double StaffSalary;

        
        public Staff(string name, string ID, string designation, double salary)
        {
            this.StaffName = name;
            this.StaffID = ID;
            this.StaffDesignation = designation;
            this.StaffSalary = salary;
        }
        public string GetStaffName()
        {
            return StaffName;
        }
        public void SetStaffName(string name)
        {
            this.StaffName = name;
        }
        public string GetStaffID()
        {
            return StaffID;
        }
        public void SetStaffID(string ID)
        {
            this.StaffID = ID;
        }
        public string GetStaffDesignation()
        {
            return StaffDesignation;
        }
        public void SetStaffDesignation(string designation)
        {
            this.StaffDesignation = designation;
        }
        public double GetStaffSalary()
        {
            return StaffSalary;
        }
        public void SetStaffSalary(double salary)
        {
            this.StaffSalary = salary;
        }
    }
}

