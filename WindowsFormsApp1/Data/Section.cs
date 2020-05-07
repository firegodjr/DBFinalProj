using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProj.Data
{
    static class Section
    {
        /// <summary>
        /// Gets the RoomNumber attribute for each row in the ROOM table
        /// </summary>
        public static string[] GetAllSections(DataWrapper dw)
        {
            var names = new List<string>();
            var cmd = dw.CreateCommand("SELECT Name FROM HOUSE_SECTION");
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                var fieldCount = rdr.FieldCount;
                var keys = new List<string>();
                while (rdr.Read())
                {
                    names.Add(rdr.GetString(0));
                }
            }

            return names.ToArray();
        }

        /// <summary>
        /// Gets room attributes given the room number
        /// </summary>
        public static Dictionary<string, object> GetSection(string sectionName, DataWrapper dw)
        {
            return dw.GetRow("Name", sectionName, "HOUSE_SECTION");
        }

        public static void DeleteSection(string sectionName, DataWrapper dw)
        {
            dw.DeleteRow("Name", sectionName, "HOUSE_SECTION");
        }
    }
}
