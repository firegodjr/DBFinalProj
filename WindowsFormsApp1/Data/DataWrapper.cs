using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProj.Objects;
using MySql.Data.MySqlClient;

namespace DBFinalProj
{
    /// <summary>
    /// Maintains a connection to the database
    /// </summary>
    class DataWrapper
    {
        private MySqlConnection conn;

        public DataWrapper(string server, string database, int port, string user, string pwd)
        {
            string connStr = $"server={server};user={user};database={database};port={port};password={pwd}";
            conn = new MySqlConnection(connStr);
        }

        /// <summary>
        /// Opens the database connection
        /// </summary>
        public void Open()
        {
            Console.WriteLine("Opening database connection...");
            conn.Open();
            Console.WriteLine($"Database connection is: {conn.State}");
        }

        /// <summary>
        /// Closes the database connection
        /// </summary>
        public void Close()
        {
            Console.WriteLine("Closing database connection...");
            conn.Close();
        }

        /// <summary>
        /// Creates a MySqlCommand using given sql and the ongoing MySQL connection
        /// </summary>
        public MySqlCommand CreateCommand(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            return cmd;
        }
    }
}
