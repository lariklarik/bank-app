using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;

namespace Project_University
{
    static class DataBase
    {
        static private void CreateConnection()
        {
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "127.0.0.1";
            mysqlCSB.Database = "world";
            mysqlCSB.UserID = "root";
            mysqlCSB.Password = "123456";
        }
    }
}
