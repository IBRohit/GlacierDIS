using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GlacierDIS
{
    [XmlRoot("Holding")]
    public class XMLFundShareClassList
    {
        [XmlElement("SC")]
        public XMLFundShareClass_up[] XMLFundShareClass { get; set; }
    }

    [XmlRoot("SC")]
    public class XMLFundShareClass_up
    {

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("ISIN")]
        public string ISIN { get; set; }

        [XmlAttribute("Updated")]
        public DateTime Updated { get; set; }
       

      



    }
}

