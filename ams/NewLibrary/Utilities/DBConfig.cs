using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SkyLinesLibrary
{
    public class DbConfig
    {

        private static string connectionString = "Data Source=AHMED\\SQLEXPRESS;Initial Catalog=OOPProject;Integrated Security=True;";
        private SqlConnection con;
        private static DbConfig instance;
        private DbConfig()
        {
            con = new SqlConnection(connectionString);
        }
        public static DbConfig GetInstance()
        {
            if (instance == null)
            {
                instance = new DbConfig();
            }
            return instance;
        }
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public SqlConnection GetConnection()
        {
            OpenConnection();
            return con;
        }
    }
}

