using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProj.Objects
{
    public class Database
    {
        public string Name;
        public string Server;
        public int Port;
        public string Schema;

        public Database(string name, string server, int port, string schema)
        {
            Name = name;
            Server = server;
            Port = port;
            Schema = schema;
        }

        public string GetConnectionString(string user, string pwd)
        {
            return $"server={Server};user={user};database={Schema};port={Port};password={pwd}";
        }
    }
}
