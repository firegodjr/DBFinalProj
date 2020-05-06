using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBFinalProj.Data
{
    class Resident
    {
        public int SSN;
        public string Name;
        public int PhoneNumber;
        public string ContractStartDate;
        public string ContractEndDate;
        public string MealPlan;
        public int AssignedRoom;
        public string GraduationDate;
        public string NextSemesterPlan;
        public int ChoresMissed;
        public int OutstandingBalance;
        public string SmallGroup;
        public bool IsKP;
        public bool IsFM;

        public Resident()
        {

        }

        /// <summary>
        /// Gets the SSN of all residents in the RESIDENT table
        /// </summary>
        /// <returns></returns>
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
    }
}
