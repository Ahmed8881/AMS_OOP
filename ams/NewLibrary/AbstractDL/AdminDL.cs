using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibrary.AbstractClasses
{
    public abstract class AdminDL
    {
         public abstract void LoadAdmins();
        public abstract void StoreAdmins(Admins ad);
        protected List<Admins> Admins = new List<Admins>();
        public void AddAdmin(Admins ad)
        {
            Admins.Add(ad);
            StoreAdmins(ad);
        }
        public bool IsAdminExist(string name, string password)
        {
            foreach (Admins admin in Admins)
            {
                if (admin.GetName() == name && admin.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }

           public int FindAdmin(string name, string password)
        {
            int AdminNo = 1000;
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].GetName() == name && Admins[i].GetPassword() == password)
                {
                    AdminNo = i;
                    return AdminNo;
                }
            }
            return AdminNo;
        }

        
        public bool CheckValidAdminName(string name)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].GetName() == name)
                {
                    return false;
                }
            }
            return true;
        }
        public List<Admins> GetAllAdmins()
        {
            return Admins;
        }
       
    }
}
