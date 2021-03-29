using Cafe.Connection;
using Npgsql;

namespace Cafe.Dao
{
    class TotalDao
    {

        public int insertTotal(int tableId,int waiterId)
        {
            string sqlQuery = "SELECT main.insert_total(:t_table_id,:t_waiter_id);";
            int returnId = 0;
            DataBase dataBase = new DataBase();
            var command = dataBase.getNpgCommandForRequest(sqlQuery);
            command.Parameters.AddWithValue("t_table_id", tableId);
            command.Parameters.AddWithValue("t_waiter_id", waiterId);

            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                returnId = reader.GetInt32(0);
            }
            return returnId;
        }
    }
}
