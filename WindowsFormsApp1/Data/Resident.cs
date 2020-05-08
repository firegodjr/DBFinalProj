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
                    SSNs.Add(rdr.GetInt32(0));
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

        public static void AddResident(int ssn, string name, string startDate, string endDate, DataWrapper dw)
        {
            var attribs = new Dictionary<string, object>();
            attribs.Add("SSN", ssn);
            attribs.Add("Name", name);
            attribs.Add("ContractStartDate", startDate);
            attribs.Add("ContractEndDate", endDate);
            attribs.Add("KP", false);
            attribs.Add("FM", false);
            dw.InsertRow("RESIDENT", attribs);
        }

        public static int GetAssignedRoom(int ssn, DataWrapper dw)
        {
            var attribs = dw.GetRow("ResidentSSN", ssn, "ASSIGNED_TO");
            if (attribs.ContainsKey("RoomNum"))
            {
                return int.Parse(attribs["RoomNum"].ToString());
            }
            else
            {
                return 0;
            }
        }

        public static void UpdateResident(int ssn, Dictionary<string, object> values, DataWrapper dw)
        {
            dw.UpdateRow("SSN", ssn, "RESIDENT", values);
        }

        public static void UpdateAssignedRoom(int ssn, int assignedRoom, DataWrapper dw)
        {
            if(GetAssignedRoom(ssn, dw) == 0)
            {
                var assignedRow = new Dictionary<string, object>();
                assignedRow.Add("ResidentSSN", ssn);
                assignedRow.Add("RoomNum", assignedRoom);
                dw.InsertRow("ASSIGNED_TO", assignedRow);
            }

            var values = new Dictionary<string, object>();
            values.Add("RoomNum", assignedRoom);
            dw.UpdateRow("ResidentSSN", ssn, "ASSIGNED_TO", values);
        }

        public static void DeleteResident(int ssn, DataWrapper dw)
        {
            dw.DeleteRow("SSN", ssn, "RESIDENT");
        }
    }
}
