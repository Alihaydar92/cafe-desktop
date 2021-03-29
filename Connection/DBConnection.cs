using Npgsql;
using System.Windows.Forms;

namespace Cafe.Connection
{
    public class DBConnection
    {
        string connectionString;
        //SqlConnection sqlConn;

        public NpgsqlConnection connectionPostgreSql()
        {
            connectionString = "Host=localhost;Username=postgres;Password=r00t@li;Database=postgres";

            //sqlConn = new SqlConnection(connectionString);
            var npgSqlConn = new NpgsqlConnection(connectionString);

            npgSqlConn.Open();

            //if (npgSqlConn != null && npgSqlConn.State == System.Data.ConnectionState.Open)
            //{
            //    MessageBox.Show("Connection open");
            //}
            ////npgSqlConn.Close();
            //if (npgSqlConn.State == System.Data.ConnectionState.Closed)
            //{
            //    MessageBox.Show("Connection closed");
            //}
            return npgSqlConn;
        }
    }
}
