using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProj.Data;
using MySql.Data.MySqlClient;

namespace DBFinalProj
{
    /// <summary>
    /// Maintains a connection to a MySql database, and includes several helper functions to allow for easy programmatic querying
    /// and table modification.
    /// 
    /// Called by MainMenuForm.cs to provide UI values and functionality.
    /// </summary>
    class DataWrapper
    {
        private MySqlConnection conn;

        public DataWrapper(Database database, string user, string pwd)
        {
            string connStr = database.GetConnectionString(user, pwd);
            conn = new MySqlConnection(connStr);
        }

        /// <summary>
        /// Opens the database connection
        /// </summary>
        public void Open()
        {
            Console.WriteLine($"Opening connection to {conn.Database} on {conn.DataSource}...");
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

        /// <summary>
        /// Selects a particular row using a singleton primary key.
        /// Returns a dict of attribute objects, indexed by column name.
        /// </summary>
        /// <param name="keyName">The name of the primary key attribute</param>
        /// <param name="key">The value of the primary key</param>
        /// <param name="table">The table to select from</param>
        public Dictionary<string, object> GetRow(string keyName, object key, string table)
        {
            string quote = (key.GetType() == typeof(string) ? "\"" : ""); // Set to quote if key is a string
            var cmd = CreateCommand($"SELECT * FROM {table} WHERE {keyName} = {quote}{key.ToString()}{quote};");
            var dict = new Dictionary<string, object>();
            using(MySqlDataReader rdr = cmd.ExecuteReader())
            {
                if(rdr.Read())
                {
                    var fieldCount = rdr.FieldCount;
                    var keys = new List<string>();
                    for (int i = 0; i < fieldCount; ++i)
                    {
                        keys.Add(rdr.GetName(i));
                    }

                    for (int i = 0; i < fieldCount; ++i)
                    {
                        dict.Add(keys[i], rdr.GetValue(i));
                    }
                }
            }

            return dict;
        }


        /// <summary>
        /// Inserts a given row into a given table.
        /// </summary>
        /// <param name="table"> The table to insert into </param>
        /// <param name="row"> A dictionary of attributes to be updated in the row</param>
        public void InsertRow(string table, Dictionary<string, object> row)
        {
            KeyValuePair<string, object>[] orderedRow = row.ToArray();
            string sql = $"INSERT INTO {table} (";
            foreach(KeyValuePair<string, object> kv in orderedRow)
            {
                sql += $"{kv.Key},";
            }
            sql = sql.TrimEnd(',');
            sql += ") VALUES (";
            string quote; 
            foreach (KeyValuePair<string, object> kv in orderedRow)
            {
                quote = (kv.Value.GetType() == typeof(string) ? "\"" : ""); // Set to quote if key is a string
                sql += $"{quote}{kv.Value}{quote},";
            }
            sql = sql.TrimEnd(',');
            sql += ")";
            var cmd = CreateCommand(sql);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates a table row using a singleton primary key.
        /// </summary>
        /// <param name="keyName">The name of the primary key attribute</param>
        /// <param name="key">The value of the primary key</param>
        /// <param name="table">The table to update</param>
        /// <param name="row">A dictionary of attributes to be updated in the row</param>
        public void UpdateRow(string keyName, object key, string table, Dictionary<string, object> row)
        {
            string quote = (key.GetType() == typeof(string) ? "\"" : ""); // Set to quote if key is a string
            string sql = $"UPDATE {table} ";
            sql += "SET ";
            foreach (KeyValuePair<string, object> kv in row)
            {
                string valQuote = (kv.Value.GetType() == typeof(string) ? "\"" : "");
                sql += $"{kv.Key} = {valQuote}{kv.Value.ToString()}{valQuote},";
            }
            sql = sql.TrimEnd(',');
            sql += $" WHERE {keyName} = {quote}{key.ToString()}{quote};";
            var cmd = CreateCommand(sql);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Deletes a table row using a singleton primary key
        /// </summary>
        /// <param name="keyName">The name of the primary key attribute</param>
        /// <param name="key">The value of the primary key</param>
        /// <param name="table">The table to update</param>
        public void DeleteRow(string keyName, object key, string table)
        {
            string quote = (key.GetType() == typeof(string) ? "\"" : ""); // Set to quote if key is a string
            var cmd = CreateCommand($"DELETE FROM {table} WHERE {keyName} = {quote}{key.ToString()}{quote};");
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Converts a DateTime object into an acceptable SQL representation
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GetSqlDateString(DateTime date)
        {
            return $"{date.Year.ToString("0000")}-{date.Month.ToString("00")}-{date.Day.ToString("00")}";
        }
    }
}
