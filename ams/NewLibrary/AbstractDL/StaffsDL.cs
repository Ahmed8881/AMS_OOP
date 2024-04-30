using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibrary.AbstractClasses
{
    public abstract class StaffsDL
    {
        protected List<Staff> AirlineStaff = new List<Staff>();
        public bool CheckValidStaffID(string ID)
        {
            foreach (var staff in AirlineStaff)
            {
                if (staff.GetStaffID() == ID)
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsStaffExist(string ID)
        {
            foreach (var staff in AirlineStaff)
            {
                if (staff.GetStaffID() == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Staff> GetAllStaff()
        {
            return AirlineStaff;
        }
        public abstract void DeleteStaff(string staffID);
        public abstract void  UpdateStaff(string originalID, string name, string designation, double salary);
        public abstract void StoreStaff(Staff st);
        public abstract void LoadStaff();

    }
}
