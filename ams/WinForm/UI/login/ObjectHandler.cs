using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class ObjectHandler
    {
        public static string con = "Data Source=AHMED\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;";
        static string Admin = "../../../../../Files/Admin.txt";
        static string Staff = "../../../../../Files/Emp.txt";
        static string Client = "../../../../../Files/Client.txt";
        static string Flight = "../../../../../Files/Flight.txt";
        private static IAdminDL AdminDL = AdminDL_DB.AdminDBGetInstance(con);
        private static IStaffDL StaffDL = StaffDL_DB.StaffDBGetInstance(con);
        private static IFlightDL FlightDL = FlightDL_DB.FlightDBGetInstance(con);
        private static IClientDL ClientDL = ClientDL_DB.ClientDBGetInstance(con);

       // private static IAdminDL AdminDL = AdminDL_FH.AdminFHGetInstance(Admin);
       // private static IStaffDL StaffDL = StaffDL_FH.GetStaffDL_FHInstance(Staff);
       // private static IFlightDL FlightDL = FlightDL_FH.GetFlightDL_FHInstance(Flight);
       // private static IClientDL ClientDL = ClientDL_FH.ClientFHGetInstance(Client);


        public static IAdminDL GetAdminDL()
        {
            return AdminDL;
        }
        public static IClientDL GetClientDL()
        {
            return ClientDL;
        }
        public static IStaffDL GetStaffDL()
        {
            return StaffDL;
        }
        public static IFlightDL GetFlightDL()
        {
            return FlightDL;
        }
    }
}
