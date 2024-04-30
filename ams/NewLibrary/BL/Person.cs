using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLinesLibrary
{
   
    public class Person
    {
        
        protected string Name;
        protected string Password;
        protected string Role;

       
        public Person(string name, string password, string role)
        {
            this.Name = name;
            this.Password = password;
            this.Role = role;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public string GetRole()
        {
            return Role;
        }
        public void SetRole(string role)
        {
            this.Role = role;
        }
    }
}
