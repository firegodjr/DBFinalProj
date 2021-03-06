﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProj.Data
{
    static class Room
    {
        /// <summary>
        /// Gets the RoomNumber attribute for each row in the ROOM table
        /// </summary>
        public static int[] GetAllRooms(DataWrapper dw)
        {
            var SSNs = new List<int>();
            var cmd = dw.CreateCommand("SELECT RoomNumber FROM ROOM");
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                var fieldCount = rdr.FieldCount;
                var keys = new List<string>();
                while (rdr.Read())
                {
                    SSNs.Add(rdr.GetInt16(0));
                }
            }

            return SSNs.ToArray();
        }

        public static void AddRoom(int roomNum, string choreSet, string roomMeetingTime, int roomLeaderSSN, string sectionName, DataWrapper dw)
        {
            var attribs = new Dictionary<string, object>();
            attribs.Add("RoomNumber", roomNum);
            attribs.Add("ChoreSet", choreSet);
            attribs.Add("RoomMeetingTime", roomMeetingTime);
            attribs.Add("RLSSN", roomLeaderSSN);
            dw.InsertRow("ROOM", attribs);

            var relationRow = new Dictionary<string, object>();
            relationRow.Add("RoomNum", roomNum);
            relationRow.Add("SectionName", sectionName);
            dw.InsertRow("BELONGS_TO", relationRow);
        }

        /// <summary>
        /// Gets room attributes given the room number
        /// </summary>
        public static Dictionary<string, object> GetRoom(int roomNum, DataWrapper dw)
        {
            return dw.GetRow("RoomNumber", roomNum, "ROOM");
        }

        public static string GetSection(int roomNum, DataWrapper dw)
        {
            var attribs = dw.GetRow("RoomNum", roomNum, "BELONGS_TO");
            if (attribs.ContainsKey("SectionName"))
            {
                return attribs["SectionName"].ToString();
            }
            else
            {
                return "N/A";
            }
        }

        public static void UpdateRoom(int roomNum, Dictionary<string, object> values, DataWrapper dw)
        {
            dw.UpdateRow("RoomNumber", roomNum, "ROOM", values);
        }

        public static void UpdateBelongingSection(int roomNum, string sectionName, DataWrapper dw)
        {
            var values = new Dictionary<string, object>();
            values.Add("SectionName", sectionName);

            dw.UpdateRow("RoomNum", roomNum, "BELONGS_TO", values);
        }

        public static void DeleteRoom(int roomNum, DataWrapper dw)
        {
            dw.DeleteRow("RoomNumber", roomNum, "ROOM");
        }
    }
}
