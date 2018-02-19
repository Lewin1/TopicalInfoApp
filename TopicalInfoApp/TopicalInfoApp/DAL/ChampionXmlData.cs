using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using TopicalInfoApp.Models;

namespace TopicalInfoApp.DAL
{
    public class ChampionXmlData : IDisposable
    {
        public List<Champion> Read()
        {
            Champions championsObject;

            StreamReader sReader = new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/ChampionsData.xml"));
            XmlSerializer deserializer = new XmlSerializer(typeof(Champions));

            using (sReader)
            {
                object xmlObject = deserializer.Deserialize(sReader);

                championsObject = (Champions)xmlObject;
            }

            return championsObject.champions;
        }

        public void Write(List<Champion> champions)
        {
            StreamWriter sWrite = new StreamWriter(HttpContext.Current.Server.MapPath("~/App_Data/ChampionsData.xml"));
            XmlSerializer serializer = new XmlSerializer(typeof(List<Champion>), new XmlRootAttribute("Champions"));

            using (sWrite)
            {
                serializer.Serialize(sWrite, champions);
            }
        }
        public void Dispose()
        {

        }
    }

}