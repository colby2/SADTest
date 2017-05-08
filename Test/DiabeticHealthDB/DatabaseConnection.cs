using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows;


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
            string passPhrase = "Pas5pr@se";        // can be any string
            string saltValue = "s@1tValue";        // can be any string
            string hashAlgorithm = "SHA1";             // can be "MD5"
            int passwordIterations = 2;                // can be any number
            string initVector = "@1B2c3D4e5F6g7H8"; // must be 16 bytes
            int keySize = 256;                // can be 192 or 128
            string fileName = "C:\\DBBackup\\stored.dat";
            String password = RijndaelSimple.Decrypt(File.ReadAllText(fileName), passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);

            connectionString = "SERVER=localhost; DATABASE =dhrp; USERNAME=nomawkellner; Password="+password;
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

    }
}
