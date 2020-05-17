using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UserAPI.Model
{
    public class DataContext : IDisposable
    {
        public SqlConnection Connection { get; }



        public DataContext(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
        }

        public void Dispose() => Connection.Dispose();
    }
}
