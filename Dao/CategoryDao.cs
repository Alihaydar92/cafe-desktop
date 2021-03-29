using Cafe.Connection;
using Cafe.POJO;
using Npgsql;
using System.Collections.Generic;

namespace Cafe.Dao
{
    public class CategoryDao
    {
        DataBase dataBase = new DataBase();
        public List<Category> getCateqogryList()
        {
            string sqlquery = "SELECT * from  main.list_category()";
            List<Category> categoryList = new List<Category>();

            dataBase = new DataBase();

            NpgsqlDataReader reader = dataBase.getDataReader(sqlquery);
            while (reader.Read())
            {
                Category category = new Category();
                category.Id = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32(reader.GetOrdinal("id"));
                category.Name = reader.IsDBNull(reader.GetOrdinal("cat_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("cat_name"));
                category.Description = reader.IsDBNull(reader.GetOrdinal("description")) ? string.Empty : reader.GetString(reader.GetOrdinal("description"));
                categoryList.Add(category);
            }

            dataBase.CloseAndDispose();

            return categoryList;

        }

        public List<ComboItem> getCategoryCombo()
        {
            List<ComboItem> getCategoryCombo = new List<ComboItem>();
            string query = "SELECT * from  main.combo_category()";
            dataBase = new DataBase();
            NpgsqlDataReader reader = dataBase.getDataReader(query);
            while (reader.Read())
            {
                Category category = new Category();
                category.Id = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32(reader.GetOrdinal("id"));
                category.Name = reader.IsDBNull(reader.GetOrdinal("cat_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("cat_name"));
                getCategoryCombo.Add(new ComboItem(category.Id, category.Name));
            }
            dataBase.CloseAndDispose();
            return getCategoryCombo;
        }
        public int insertCategory(Category category)
        {

            string insertSqlQuery = "select main.insert_category(:c_name,:c_desc)";

            dataBase = new DataBase();
            var npgComm = dataBase.getNpgCommandForRequest(insertSqlQuery);
            npgComm.Parameters.AddWithValue("c_name", category.Name);
            npgComm.Parameters.AddWithValue("c_desc", category.Description);

            int id = 0;

            NpgsqlDataReader reader = npgComm.ExecuteReader();

            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            return id;
        }

        public int updateCategory(Category category)
        {
            string query = "SELECT main.update_category(:c_id,:c_name,:c_text)";
            dataBase = new DataBase();
            var updateCommand = dataBase.getNpgCommandForRequest(query);
            updateCommand.Parameters.AddWithValue("c_id", category.Id);
            updateCommand.Parameters.AddWithValue("c_name", category.Name);
            updateCommand.Parameters.AddWithValue("c_text", category.Description);

            NpgsqlDataReader reader = updateCommand.ExecuteReader();
            int returnId = 0;
            while (reader.Read())
            {
                returnId = reader.GetInt32(0);
            }
            dataBase.CloseAndDispose();
            return returnId;
        }

        public int deleteCategory(Category category)
        {
            string query = "SELECT main.delete_category(:c_id)";
            dataBase = new DataBase();
            var deleteCommand = dataBase.getNpgCommandForRequest(query);
            deleteCommand.Parameters.AddWithValue("c_id", category.Id);

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
