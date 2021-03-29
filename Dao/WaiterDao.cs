using Cafe.Connection;
using Cafe.POJO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Dao
{
    public class WaiterDao
    {
        DataBase dataBase;

        public List<Waiter> GetWaiters()
        {
            string query = "SELECT * from main.list_waiters()";
            List<Waiter> waiters = new List<Waiter>();
            dataBase = new DataBase();
            NpgsqlDataReader npgsqlDataReader = dataBase.getDataReader(query);
            while (npgsqlDataReader.Read())
            {
                Waiter waiter = new Waiter();
                waiter.Id = npgsqlDataReader.IsDBNull(npgsqlDataReader.GetOrdinal("id")) ? 0 : npgsqlDataReader.GetInt32(npgsqlDataReader.GetOrdinal("id"));
                waiter.Name = npgsqlDataReader.IsDBNull(npgsqlDataReader.GetOrdinal("waiter_name")) ? string.Empty : npgsqlDataReader.GetString(npgsqlDataReader.GetOrdinal("waiter_name"));
                waiters.Add(waiter);
            }
            dataBase.CloseAndDispose();
            return waiters;
        }
    }
}
