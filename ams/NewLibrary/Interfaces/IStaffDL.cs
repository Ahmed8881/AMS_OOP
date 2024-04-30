using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLinesLibrary
{
    public interface IStaffDL
    {
        void AddStaff(Staff s);
        void RemoveStaff(string name, string staffID);
        void EditStaff(string staffID, string newname, string newdesignation, double newsalary);
        bool CheckValidStaffID(string ID);
        bool IsStaffExist(string ID);
        void LoadStaff();
        void StoreStaff(Staff st);
        void UpdateStaff(string originalID, string name, string designation, double salary);
        void DeleteStaff(string staffID);
        List<Staff> GetAllStaff();
    }
}

