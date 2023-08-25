using System.Data.SqlClient;

namespace StudentApp.WinForm.Helpers
{
    public class DbConnectionHelper
    {
        public SqlConnection Connection => GetConnection();
        private SqlConnection GetConnection()
        {
            return new SqlConnection("server=.\\SQLExpress; database=StudentDb; integrated security=true;");
        }

    }

}
