using SkyLinesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLinesLibrary
{
    public interface IAdminDL
    {
        void AddAdmin(Admins admin);
        bool IsAdminExist(string name, string password);
        int FindAdmin(string name, string password);
        bool CheckValidAdminName(string name);
        void LoadAdmins();
        void StoreAdmins(Admins ad);
        List<Admins> GetAllAdmins();
    }
}
