using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

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
    }
}
