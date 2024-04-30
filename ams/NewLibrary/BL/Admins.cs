using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SkyLinesLibrary
{
    
    public class Admins : Person
    {
       
        
        public Admins(string name, string password, string role) : base(name, password, role)
        {

        }
    }
}


