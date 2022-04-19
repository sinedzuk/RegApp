using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;


namespace RegApp.Core
{
    public class Storage
    {
        private const string UsersPath = "../../Data/Users.json";


        public List<User> Users { get; private set; }


        public Storage()
        {
            ReadData();
        }

        

        public void SaveUsers()
        {
            using (var sw = new StreamWriter(UsersPath))
            {
                using (var jsonWriter = new JsonTextWriter(sw))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    var serializer = new JsonSerializer {TypeNameHandling = TypeNameHandling.Auto};
                    serializer.Serialize(jsonWriter, Users);
                }
            }
        }

        private void ReadUsers()
        {
            using (var sr = new StreamReader(UsersPath))
            {
                using (var jsonReader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer {TypeNameHandling = TypeNameHandling.Auto};
                    Users = serializer.Deserialize<List<User>>(jsonReader);
                }
            }
            // Users = new List<User>
            // {
            //     new User("denis", "denispass"),
            //     new User("admin", "adminpass")
            // };
        }

        

      

        public void SaveData()
        {
            SaveUsers();
        }

        private void ReadData()
        {
            ReadUsers();
        }
    }
}