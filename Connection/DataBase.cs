using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;

namespace Cafe.Connection
{
    public class DataBase
    {
        private string conString = "Host=localhost;Username=postgres;Password=postgres;Database=cafe";
        public NpgsqlConnection mainConnect;
        public NpgsqlTransaction currentTran;
        public bool existTransactions = false;

        public DataBase()
        {
            mainConnect = new NpgsqlConnection(conString);
            mainConnect.Open();
        }

        public void SetDatabase(string dbName)
        {
            mainConnect.ChangeDatabase(dbName);
        }

        public void StartTran()
        {
            currentTran = mainConnect.BeginTransaction(IsolationLevel.ReadCommitted);
            existTransactions = true;
        }

        public void CommitTran()
        {
            currentTran.Commit();
            existTransactions = false;
        }

        public void RollbackTran()
        {
            currentTran.Rollback();
            existTransactions = false;
        }

        //for witout response
        public int executeWithoutReturn(string queryText)
        {
            NpgsqlCommand commmandDB = new NpgsqlCommand(queryText, mainConnect);
            return commmandDB.ExecuteNonQuery();
        }
      
        public List<T> runQueryListOnlyOneModel<T>(string queryText)
        {
            List<T> list = new List<T>();
            T obj = default(T);

            NpgsqlCommand commmandDB = new NpgsqlCommand(queryText, mainConnect);
            DbDataReader dr = commmandDB.ExecuteReader();

            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);

                    }
                }
                list.Add(obj);
            }
            return list;
        }
        //for without param
        public NpgsqlDataReader getDataReader(string sqlQuery)
        {
            NpgsqlCommand commmandDB = new NpgsqlCommand(sqlQuery, mainConnect);
            NpgsqlDataReader reader = commmandDB.ExecuteReader();
            return reader;
        }

        //for with param
        public NpgsqlCommand getNpgCommandForRequest(string sqlQuery)
        {
            NpgsqlCommand commmandDB = new NpgsqlCommand(sqlQuery, mainConnect);
            
            return commmandDB;
        }

        public void CloseAndDispose()
        {
            mainConnect.Close();
            mainConnect.Dispose();
        }


    }
}
