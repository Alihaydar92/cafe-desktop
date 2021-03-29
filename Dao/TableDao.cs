using Cafe.Connection;
using Cafe.POJO;
using Npgsql;
using System.Collections.Generic;

namespace Cafe.Dao
{
    public class TableDao
    {
        DataBase dataBase;
        public List<Table> getTableList()
        {
            string sqlQuery = "select * from  main.list_cafe_tables()";
            List<Table> tables;

            tables = new List<Table>();
            dataBase = new DataBase();

            NpgsqlDataReader dr = dataBase.getDataReader(sqlQuery);
            while (dr.Read())
            {
                Table table = new Table();
                table.Id = dr.IsDBNull(dr.GetOrdinal("table_id")) ? 0 : dr.GetInt32(dr.GetOrdinal("table_id"));
                table.Name = dr.IsDBNull(dr.GetOrdinal("table_name")) ? string.Empty : dr.GetString(dr.GetOrdinal("table_name"));
                table.Description = dr.IsDBNull(dr.GetOrdinal("table_desc")) ? string.Empty : dr.GetString(dr.GetOrdinal("table_desc"));
                table.Total.Id = dr.IsDBNull(dr.GetOrdinal("total_id")) ? 0 : dr.GetInt32(dr.GetOrdinal("total_id"));
                table.Total.Status = dr.IsDBNull(dr.GetOrdinal("total_status")) ? false : dr.GetBoolean(dr.GetOrdinal("total_status"));
                table.Waiter.Id = dr.IsDBNull(dr.GetOrdinal("waiter_id")) ? 0 : dr.GetInt32(dr.GetOrdinal("waiter_id"));
                table.Waiter.Name = dr.IsDBNull(dr.GetOrdinal("waiter_name")) ? string.Empty : dr.GetString(dr.GetOrdinal("waiter_name"));
                tables.Add(table);
            }

            dataBase.CloseAndDispose();

            return tables;
        }
        public int insertTable(Table table)
        {
            string insertQuery = "SELECT main.insert_cafe_table(:c_name,:c_desc)";


            dataBase = new DataBase();
            var insertComm = dataBase.getNpgCommandForRequest(insertQuery);
            insertComm.Parameters.AddWithValue("c_name", table.Name);
            insertComm.Parameters.AddWithValue("c_desc", table.Description);

            NpgsqlDataReader reader = insertComm.ExecuteReader();
            int returnId = 0;
            while (reader.Read())
            {
                returnId = reader.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;



        }

        public int updateTable(Table table)
        {
            string updateQuery = "SELECT main.update_cafe_table(:c_name,:c_desc,:c_id)";
            dataBase = new DataBase();
            var updateCommand = dataBase.getNpgCommandForRequest(updateQuery);
            updateCommand.Parameters.AddWithValue("c_name", table.Name);
            updateCommand.Parameters.AddWithValue("c_desc", table.Description);
            updateCommand.Parameters.AddWithValue("c_id", table.Id);

            NpgsqlDataReader reader = updateCommand.ExecuteReader();
            int retId = 0;
            while (reader.Read())
            {
                retId = reader.GetInt32(0);
            }
            return retId;
        }
        public int deleteTable(Table table)
        {
            string sqlQuery = "SELECT main.delete_cafe_table(:t_id)";
            dataBase = new DataBase();
            var deleteCommand = dataBase.getNpgCommandForRequest(sqlQuery);
            deleteCommand.Parameters.AddWithValue("t_id", table.Id);

            NpgsqlDataReader reader = deleteCommand.ExecuteReader();
            int returnId = 0;
            while (reader.Read())
            {
                returnId = reader.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;
        }
    }
}
