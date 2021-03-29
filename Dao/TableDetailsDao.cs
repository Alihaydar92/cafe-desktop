using Cafe.Connection;
using Cafe.POJO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace Cafe.Dao
{
    class TableDetailsDao
    {
        List<DTColumn> totalGridColumns = new List<DTColumn>();
        public TableDetailsDao()
        {
            totalGridColumns.Add(new DTColumn("id", "totalID", typeof(int), false, 10, ""));
            totalGridColumns.Add(new DTColumn("tableName", "Stol no.", typeof(string), true, 10, ""));
            totalGridColumns.Add(new DTColumn("foodName", "Qida adı", typeof(string), true, 10, ""));
            totalGridColumns.Add(new DTColumn("count", "Say", typeof(int), true, 10, ""));
            totalGridColumns.Add(new DTColumn("price", "Qiymət", typeof(float), true, 10, ""));
            totalGridColumns.Add(new DTColumn("total", "Cəm", typeof(float), true, 10, "[price] * [count]"));
        }
        DataBase dataBase = new DataBase();
        public int insertTableDetails(TableDetails total)
        {
            Console.WriteLine("inseert method: ");
            string insertTotalQuery = "SELECT main.insert_table_details(:t_table_id,:t_food_stuff_id,:t_food_price,:t_cost,:t_food_qty,:t_food_sum)";
            dataBase = new DataBase();
            var insertCommand = dataBase.getNpgCommandForRequest(insertTotalQuery);
            insertCommand.Parameters.AddWithValue("t_table_id", total.Table.Id);
            insertCommand.Parameters.AddWithValue("t_food_stuff_id", total.FoodStuff.Id);
            insertCommand.Parameters.AddWithValue("t_food_price", total.FoodStuff.Price);
            insertCommand.Parameters.AddWithValue("t_cost", total.FoodStuff.Cost);
            insertCommand.Parameters.AddWithValue("t_food_qty", total.FoodQty);
            insertCommand.Parameters.AddWithValue("t_food_sum", total.Sum);
            NpgsqlDataReader dr = insertCommand.ExecuteReader();
            int returnId = 0;
            while (dr.Read())
            {
                //returnId = dr.IsDBNull(dr.GetOrdinal("t_id")) ? 0 : dr.GetInt32(dr.GetOrdinal("t_id"));
                returnId = dr.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;
        }

        public int updateTableDetails(TableDetails tableDetails)
        {
            Console.WriteLine("update method: ");
            string updateQuery = "SELECT main.update_table_details(:t_price,:t_food_qty,:t_cost,:t_sum,:t_id)";
            dataBase = new DataBase();
            var updateCommand = dataBase.getNpgCommandForRequest(updateQuery);
            updateCommand.Parameters.AddWithValue("t_price", tableDetails.FoodStuff.Price);
            updateCommand.Parameters.AddWithValue("t_food_qty", tableDetails.FoodQty);
            updateCommand.Parameters.AddWithValue("t_cost", tableDetails.FoodStuff.Cost);
            updateCommand.Parameters.AddWithValue("t_sum", tableDetails.Sum);
            updateCommand.Parameters.AddWithValue("t_id", tableDetails.Id);
            //System.Windows.Forms.MessageBox.Show("total.FoodQty  total.Sum total.Id    " + total.FoodQty + "/" + total.Sum + "/" + total.Id);
            NpgsqlDataReader reader = updateCommand.ExecuteReader();
            int returnId = 0;
            while (reader.Read())
            {
                returnId = reader.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;
        }
        public int updateStatusTotal(Total total)
        {
            string updateStatusQuery = "SELECT main.update_total_status(:t_table_id,:t_status)";
            dataBase = new DataBase();
            var updateStatusCommand = dataBase.getNpgCommandForRequest(updateStatusQuery);
            updateStatusCommand.Parameters.AddWithValue("t_table_id", total.TableId);
            updateStatusCommand.Parameters.AddWithValue("t_status", total.Status);
            NpgsqlDataReader dr = updateStatusCommand.ExecuteReader();
            int returnId = 0;
            while (dr.Read())
            {
                returnId = dr.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;
        }
        public int deleteTableDetails(int detailsId)
        {
            string query = "SELECT main.delete_table_details(:td_id)";
            dataBase = new DataBase();
            var deleteCommand = dataBase.getNpgCommandForRequest(query);
            deleteCommand.Parameters.AddWithValue("td_id", detailsId);

            NpgsqlDataReader reader = deleteCommand.ExecuteReader();
            int returnId = 0;
            while (reader.Read())
            {
                returnId = reader.GetInt32(0);
            }

            dataBase.CloseAndDispose();
            return returnId;
        }
        public List<TableDetails> getTableDetailsByTableId(int tableId)
        {
            List<TableDetails> totalListByTableId = new List<TableDetails>();
            string totalQuery = "SELECT * from  main.get_table_details_by_table_id(:t_id)";
            dataBase = new DataBase();
            var npgCommand = dataBase.getNpgCommandForRequest(totalQuery);
            npgCommand.Parameters.AddWithValue("t_id", tableId);
            NpgsqlDataReader reader = npgCommand.ExecuteReader();
            while (reader.Read())
            {
                TableDetails total = new TableDetails();
                total.Id = reader.IsDBNull(reader.GetOrdinal("td_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("td_id"));
                total.Table.Id = reader.IsDBNull(reader.GetOrdinal("table_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("table_id"));
                total.FoodStuff.Id = reader.IsDBNull(reader.GetOrdinal("food_stuff_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("food_stuff_id"));
                total.FoodQty = reader.IsDBNull(reader.GetOrdinal("food_qty")) ? 0 : reader.GetInt32(reader.GetOrdinal("food_qty"));
                total.Sum = reader.IsDBNull(reader.GetOrdinal("summary")) ? 0 : reader.GetFloat(reader.GetOrdinal("summary"));
                total.Table.Name = reader.IsDBNull(reader.GetOrdinal("table_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("table_name"));
                total.FoodStuff.Price = reader.IsDBNull(reader.GetOrdinal("price")) ? 0 : reader.GetFloat(reader.GetOrdinal("price"));
                total.FoodStuff.Name = reader.IsDBNull(reader.GetOrdinal("food_stuff_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("food_stuff_name"));

                totalListByTableId.Add(total);
            }
            dataBase.CloseAndDispose();
            return totalListByTableId;
        }


        public DataTable getTotalData(List<TableDetails> totals)
        {
            DataTable totalDT = new DataTable("Total");

            for (int i = 0; i < totalGridColumns.Count; i++)
            {
                totalDT.Columns.Add(totalGridColumns[i].ColumnName, totalGridColumns[i].Type, totalGridColumns[i].Expression);
            }
            totalDT.Rows.Clear();
            foreach (TableDetails total in totals)
            {
                totalDT.Rows.Add
                    (
                    total.Id,
                    total.Table.Name,
                    total.FoodStuff.Name,
                    total.FoodQty,
                     total.FoodStuff.Price,
                    total.Sum
                    );
            }
            return totalDT;
        }
    }
}
