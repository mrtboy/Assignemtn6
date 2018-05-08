using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment6.Data
{
    static class XMLReadWrite
    {
        public static string WriteXML<T>(T type, string filePathName)
        {
            if (type == null)
                return "Invalid data type!";
            XmlSerializer serializer = new XmlSerializer(type.GetType());
            XmlWriter xmlWriter = XmlWriter.Create(filePathName, new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Auto,
                Indent = true

            });
            serializer.Serialize(xmlWriter, type);
            xmlWriter.Close();
            return "Successed save into " + new
           FileInfo(filePathName).Name;
        }
        public static T ReadXML<T>(string FileName)
        {
            List<string> lists = new List<string>();

            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }

        }
    }
}
