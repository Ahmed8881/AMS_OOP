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
    
    public class AdminDL_FH : AdminDL, IAdminDL
    {
       
        private static DbConfig db = DbConfig.GetInstance();
        
        private static string filepath;
        
        private static AdminDL_FH AdminFHInstance;
        
        private AdminDL_FH(string Filepath)
        {
            filepath = Filepath;
           
            LoadAdmins();
        }
        
        public static AdminDL_FH AdminFHGetInstance(string filepath)
        {
            
            if (AdminFHInstance == null)
            {
                AdminFHInstance = new AdminDL_FH(filepath);
            }
           
            return AdminFHInstance;
        }

        
        public override void LoadAdmins()
        {
            string name, password, role;
            string record;
           
            if (File.Exists(filepath))
            {
             
                StreamReader adminfile = new StreamReader(filepath);
                
                while ((record = adminfile.ReadLine()) != null)
                {
                 
                    string[] data = record.Split(',');
                   
                    name = data[0];
                    password = data[1];
                    role = data[2];
                   
                    Admins a = new Admins(name, password, role);
                   
                    Admins.Add(a);
                }
               
                adminfile.Close();
            }
            else { return; }
        }
        
        public override void StoreAdmins(Admins ad)
        {
          
            StreamWriter adminfile = new StreamWriter(filepath, true);
        
            adminfile.WriteLine($"{ad.GetName()},{ad.GetPassword()},{ad.GetRole()}");
            
            adminfile.Flush();
            
            adminfile.Close();
        }
        
    }
}
