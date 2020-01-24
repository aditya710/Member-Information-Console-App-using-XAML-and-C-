using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.IO;

namespace Club_2020_WinComm.Classes
{
    internal class MyStorage
    {
        public static void WriteXml<T>(T data, string file)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                FileStream stream;

                stream = new FileStream(file, FileMode.Create);

                serializer.Serialize(stream, data);
                stream.Close();
            }

            catch 
            {
                
            }
        }

        internal static T ReadXML<T>(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                    return (T)xmlSer.Deserialize(sr);
                }
            }

            catch //(Exception x)
            {
                return default(T);
            }
        }
    }
}
