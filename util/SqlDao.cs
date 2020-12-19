using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class SqlDao
    {
        public string connString = "Data Source=年少有为;Initial Catalog=libManager;Integrated Security=TRUE";
        public SqlConnection getConn()
        {

            SqlConnection conn = null;
            conn = new SqlConnection(connString);
            return conn;
        }

    }
}
