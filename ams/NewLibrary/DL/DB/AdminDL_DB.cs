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
    
    public class AdminDL_DB : AdminDL, IAdminDL
    {

        
        private static DbConfig db = DbConfig.GetInstance();

        
        private static AdminDL_DB AdminDBInstance;

        
        private AdminDL_DB(string connectionstring)
        {
            LoadAdmins();
        }

      
        public static AdminDL_DB AdminDBGetInstance(string connectionstring)
        {
            if (AdminDBInstance == null)
            {
                AdminDBInstance = new AdminDL_DB(connectionstring);
            }
            return AdminDBInstance;
        }


        
        public override void LoadAdmins()
        {
            string name, password, role;
            string searchquery = "Select * From Admins";
            SqlCommand command = new SqlCommand(searchquery, db.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0);
                password = reader.GetString(1);
                role = reader.GetString(2);
                Admins a = new Admins(name, password, role);
                Admins.Add(a);
            }
            reader.Close();
        }


        public override void StoreAdmins(Admins ad)
        {
            string query = string.Format("INSERT INTO Admins(AdminName,AdminPassword,Role)" + "Values ('{0}','{1}','{2}')", ad.GetName(), ad.GetPassword(), ad.GetRole());

            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.ExecuteNonQuery();
        }

    }
}
