using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Models;

namespace Assignment6.Data
{
    public class UserData : IUserData
    {
        public List<User> GetUser()
        {
            User user = new User();
            return readJson<User>(user);
        }

        public string AddNewUser(User user)
        {
            string path = String.Format(@".\{0}.json", "User");
            try
            {
                var serializingSettings = new DataContractJsonSerializerSettings();
                serializingSettings.UseSimpleDictionaryFormat = true;
                serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");

                DataContractJsonSerializer ser = new DataContractJsonSerializer(user.GetType());

                FileStream fileWriter = new FileStream(path, FileMode.OpenOrCreate);
                ser.WriteObject(fileWriter, user);
                fileWriter.Close();

                return "Welcome";
            }
            catch (IOException e)
            {
                return e.Message;
            }
        }
        private List<T> readJson<T>(T type)
        {
            string path = String.Format(@".\{0}.json", "User");
            StreamReader reader = new StreamReader(path);
            string jsonData = reader.ReadToEnd();
            reader.Close();
            List<T> lists = new List<T>();
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonData)))
            {
                // Deserialization from JSON  
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(type.GetType());
                T user = (T)deserializer.ReadObject(ms);
                lists.Add(user);
                return lists;
            }
        }
    }
}
