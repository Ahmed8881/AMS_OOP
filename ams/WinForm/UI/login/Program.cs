using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            ObjectHandler.GetAdminDL().LoadAdmins();
            ObjectHandler.GetClientDL().LoadClients();
            ObjectHandler.GetStaffDL().LoadStaff();
            ObjectHandler.GetFlightDL().LoadFlights();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
           
            
        }
    }
}
