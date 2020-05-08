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

        public static void AddSection(string sectionName, int RASSN, DataWrapper dw)
        {
            var attribs = new Dictionary<string, object>();
            attribs.Add("Name", sectionName);
            attribs.Add("Points", 0);
            attribs.Add("RASSN", RASSN);
            dw.InsertRow("HOUSE_SECTION", attribs);
        }

        /// <summary>
        /// Gets room attributes given the room number
        /// </summary>
        public static Dictionary<string, object> GetSection(string sectionName, DataWrapper dw)
        {
            return dw.GetRow("Name", sectionName, "HOUSE_SECTION");
        }

        public static void UpdateSection(string sectionName, Dictionary<string, object> values, DataWrapper dw)
        {
            dw.UpdateRow("Name", sectionName, "HOUSE_SECTION", values);
        }

        public static void DeleteSection(string sectionName, DataWrapper dw)
        {
            dw.DeleteRow("Name", sectionName, "HOUSE_SECTION");
        }
    }
}
