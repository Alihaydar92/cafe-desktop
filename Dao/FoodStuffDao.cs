using Cafe.Connection;
using Cafe.POJO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace Cafe.Dao
{
    class FoodStuffDao
    {
        DataBase dataBase;
        List<DTColumn> foodDTColumns = new List<DTColumn>();

        public FoodStuffDao()
        {
            foodDTColumns.Add(new DTColumn("id", "foodId", typeof(int), false, 10, ""));
            foodDTColumns.Add(new DTColumn("categoryId", "Kateqoriya id", typeof(int), false, 10, ""));
            foodDTColumns.Add(new DTColumn("foodName", "Qida adı", typeof(string), true, 10, ""));
            foodDTColumns.Add(new DTColumn("desc", "Əlavə məlumat", typeof(string), true, 10, ""));
            foodDTColumns.Add(new DTColumn("price", "Qiymət", typeof(float), true, 10, ""));
            foodDTColumns.Add(new DTColumn("cost", "Maya dəyəri", typeof(float), true, 10, ""));
        }
        public List<FoodStuff> getFoodStuffsByCategoryId(int cateoryId)
        {
            List<FoodStuff> foodStuffs = new List<FoodStuff>();
            string sqlQuery = "SELECT * from  main.get_food_stuffs_by_category_id(:c_id)";
            try
            {
                dataBase = new DataBase();
                var npgComm = dataBase.getNpgCommandForRequest(sqlQuery);

                npgComm.Parameters.AddWithValue(":c_id", cateoryId);
                NpgsqlDataReader reader = npgComm.ExecuteReader();
                while (reader.Read())
                {
                    FoodStuff foodStuff = new FoodStuff();
                    foodStuff.Id = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32(reader.GetOrdinal("id"));
                    foodStuff.Name = reader.IsDBNull(reader.GetOrdinal("name")) ? string.Empty : reader.GetString(reader.GetOrdinal("name"));
                    foodStuff.Price = reader.IsDBNull(reader.GetOrdinal("price")) ? 0 : reader.GetFloat(reader.GetOrdinal("price"));
                    foodStuff.Cost = reader.IsDBNull(reader.GetOrdinal("food_cost")) ? 0 : reader.GetFloat(reader.GetOrdinal("food_cost"));
                    foodStuff.Category.Id = reader.IsDBNull(reader.GetOrdinal("category_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("category_id"));

                    foodStuffs.Add(foodStuff);
                }
            }
            finally
            {
                dataBase.CloseAndDispose();
            }
            return foodStuffs;
        }

        public List<FoodStuff> listFoodStuffs()
        {
            string sqlQuery = "SELECT * from  main.list_food_stuffs()";
            List<FoodStuff> foodStuffs = new List<FoodStuff>();
            try
            {

                dataBase = new DataBase();
                var npgComm = dataBase.getNpgCommandForRequest(sqlQuery);
                NpgsqlDataReader reader = npgComm.ExecuteReader();

                while (reader.Read())
                {
                    FoodStuff foodStuff = new FoodStuff();
                    foodStuff.Id = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32(reader.GetOrdinal("id"));
                    foodStuff.Name = reader.IsDBNull(reader.GetOrdinal("name")) ? string.Empty : reader.GetString(reader.GetOrdinal("name"));
                    foodStuff.Price = reader.IsDBNull(reader.GetOrdinal("price")) ? 0 : reader.GetFloat(reader.GetOrdinal("price"));
                    foodStuff.Cost = reader.IsDBNull(reader.GetOrdinal("food_cost")) ? 0 : reader.GetFloat(reader.GetOrdinal("food_cost"));
                    foodStuff.Category.Id = reader.IsDBNull(reader.GetOrdinal("category_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("category_id"));
                    foodStuff.Desc = reader.IsDBNull(reader.GetOrdinal("description")) ? string.Empty : reader.GetString(reader.GetOrdinal("description"));

                    foodStuffs.Add(foodStuff);
                }
            }
            finally
            {
                dataBase.CloseAndDispose();
            }
            return foodStuffs;
        }

        public int insertFoodStuff(FoodStuff foodStuff)
        {
            string query = "SELECT main.insert_food_stuffs(:c_name,:c_price,:c_cost,:c_category_id,:c_desc)";
            dataBase = new DataBase();
            var insertCommand = dataBase.getNpgCommandForRequest(query);
            insertCommand.Parameters.AddWithValue("c_name", foodStuff.Name);
            insertCommand.Parameters.AddWithValue("c_price", foodStuff.Price);
            insertCommand.Parameters.AddWithValue("c_cost", foodStuff.Cost);
            insertCommand.Parameters.AddWithValue("c_category_id", foodStuff.Category.Id);
            insertCommand.Parameters.AddWithValue("c_desc", foodStuff.Desc);

            NpgsqlDataReader dataReader = insertCommand.ExecuteReader();
            int returnId = 0;
            while (dataReader.Read())
            {
                returnId = dataReader.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;
        }

        public int updateFoodStuff(FoodStuff foodStuff)
        {
            string updateQuery = "SELECT main.update_food_stuffs(:food_id,:c_name,:c_price,:c_cost,:c_category_id,:c_desc)";
            dataBase = new DataBase();
            var updateCommand = dataBase.getNpgCommandForRequest(updateQuery);
            updateCommand.Parameters.AddWithValue("food_id", foodStuff.Id);
            updateCommand.Parameters.AddWithValue("c_name", foodStuff.Name);
            updateCommand.Parameters.AddWithValue("c_price", foodStuff.Price);
            updateCommand.Parameters.AddWithValue("c_cost", foodStuff.Cost);
            updateCommand.Parameters.AddWithValue("c_category_id", foodStuff.Category.Id);
            updateCommand.Parameters.AddWithValue("c_desc", foodStuff.Desc);

            NpgsqlDataReader npgsqlDataReader = updateCommand.ExecuteReader();
            int returnId = 0;

            while (npgsqlDataReader.Read())
            {
                returnId = npgsqlDataReader.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;
        }

        public int deleteFoodStuff(FoodStuff foodStuff)
        {
            string query = "SELECT main.delete_food_stuff(:f_id)";
            dataBase = new DataBase();
            var deleteCommand = dataBase.getNpgCommandForRequest(query);
            deleteCommand.Parameters.AddWithValue("f_id",foodStuff.Id);

            NpgsqlDataReader reader = deleteCommand.ExecuteReader();
            int returnId = 0;
            while (reader.Read())
            {
                returnId = reader.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;
        }

        public DataTable getFoodDT(List<FoodStuff> totals)
        {
            DataTable totalDT = new DataTable("Food");

            for (int i = 0; i < foodDTColumns.Count; i++)
            {
                totalDT.Columns.Add(foodDTColumns[i].ColumnName, foodDTColumns[i].Type);
            }
            totalDT.Rows.Clear();
            foreach (FoodStuff food in totals)
            {
                totalDT.Rows.Add
                    (
                    food.Id,
                    food.Category.Id,
                    food.Name,
                    food.Desc,
                     food.Price,
                    food.Cost
                    );
            }
            return totalDT;
        }

    }
}
