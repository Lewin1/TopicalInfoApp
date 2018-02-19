using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace TopicalInfoApp.Models
{
    [XmlRoot("Champions")]
    public class Champions
    {
        [XmlElement("Champion")]
        public List<Champion> champions;
    }
}