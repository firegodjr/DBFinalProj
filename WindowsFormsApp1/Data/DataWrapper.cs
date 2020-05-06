﻿using System;
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
            var cmd = CreateCommand($"SELECT * FROM {table} WHERE {keyName} == {key.ToString()};");
            var dict = new Dictionary<string, object>();
            using(MySqlDataReader rdr = cmd.ExecuteReader())
            {
                var fieldCount = rdr.FieldCount;
                var keys = new List<string>();
                for(int i=0; i < fieldCount; ++i)
                {
                    keys.Add(rdr.GetName(i));
                }
                
                for(int i=0; i < fieldCount; ++i)
                {
                    dict.Add(keys[i], rdr.GetValue(i));
                }
            }

            return dict;
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
            string sql = $"UPDATE {table} ";
            sql += "SET ";
            foreach (KeyValuePair<string, object> kv in row)
            {
                sql += $"{kv.Key} = {kv.Value.ToString()},";
            }
            sql.TrimEnd(',');
            sql += $" WHERE {keyName} == {key.ToString()};";
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
            var cmd = CreateCommand($"DELETE FROM {table} WHERE {keyName} == {key.ToString()};");
            cmd.ExecuteNonQuery();
        }
    }
}
