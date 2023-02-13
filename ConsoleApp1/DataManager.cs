using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class DataManager
    {
        private static readonly object _connectionLock = new object();
        private int _counter = 0;
        public static SqlConnection Connection { get; set; }

        private DataManager()
        {
            Connection = new SqlConnection();
            _counter++;
        }

        public static SqlConnection GetConnection()
        {
            if (Connection == null)
            {
                lock (_connectionLock)
                {
                    return new SqlConnection();
                }
            }
            return Connection;
        }
    }
}
