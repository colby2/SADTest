using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DiabeticHealthDB
{
    public static class DatabaseConnection
    {
        public static MySqlConnection GetConnection()
        {
            //conn is an object of the "MySqlConnection" class. It will be returned to other C# classes 
            // it can be referenced in other classes to provide a connection to the database where needed
            //For example, a function containing a query on the DB
            string connectionString;
            connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE =sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

    }
}
