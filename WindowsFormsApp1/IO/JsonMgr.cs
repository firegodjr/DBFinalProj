using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProj.Data;
using Newtonsoft.Json;
using WindowsFormsApp1;

namespace DBFinalProj.IO
{
    class JsonMgr
    {
        public static readonly string MY_DOCUMENTS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static readonly string DATABASE_DEFS_FOLDER = Path.Combine(MY_DOCUMENTS, "/databases");

        public static Dictionary<string, Database> LoadDatabases()
        {
            if(!Directory.Exists(DATABASE_DEFS_FOLDER))
                Directory.CreateDirectory(DATABASE_DEFS_FOLDER);

            var dict = new Dictionary<string, Database>();
            foreach(string file in Directory.GetFiles(DATABASE_DEFS_FOLDER))
            {
                try
                {
                    var json = JsonSerializer.Create();
                    var fileStream = File.OpenText(file);
                    using (JsonReader reader = new JsonTextReader(fileStream))
                    {
                        Database db = (Database)json.Deserialize(reader, typeof(Database));
                        dict.Add(db.Name, db);
                    }
                    fileStream.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"######## Exception caught while attempting to deserialize {file}.\n{ex.GetType().Name}:\n{ex.Message}\n{ex.StackTrace}");
                }
            }

            return dict;
        }

        public static void SaveDatabase(Database db)
        {
            if (!Directory.Exists(DATABASE_DEFS_FOLDER))
                Directory.CreateDirectory(DATABASE_DEFS_FOLDER);

            using (StreamWriter file = File.CreateText(Path.Combine(DATABASE_DEFS_FOLDER, $"{db.Name}.json")))
            {
                var json = JsonSerializer.Create();
                json.Serialize(file, db);
            }
        }
    }
}
