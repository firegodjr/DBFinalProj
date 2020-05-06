using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBFinalProj.Data
{
    static class Resident
    {
        /// <summary>
        /// Gets the SSN of all residents in the RESIDENT table
        /// </summary>
        public static int[] GetAllResidents(DataWrapper dw)
        {
            var SSNs = new List<int>();
            var cmd = dw.CreateCommand("SELECT SSN FROM RESIDENT");
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                var fieldCount = rdr.FieldCount;
                var keys = new List<string>();
                while(rdr.Read())
                {
                    SSNs.Add(rdr.GetInt16(0));
                }
            }

            return SSNs.ToArray();
        }

        /// <summary>
        /// Gets resident attributes given the resident's ssn
        /// </summary>
        public static Dictionary<string, object> GetResident(int ssn, DataWrapper dw)
        {
            return dw.GetRow("SSN", ssn, "RESIDENT");
        }

        public static int GetAssignedRoom(int ssn, DataWrapper dw)
        {
            return int.Parse(dw.GetRow("ResidentSSN", ssn, "ASSIGNED_TO")["RoomNum"].ToString());
        }
    }
}
