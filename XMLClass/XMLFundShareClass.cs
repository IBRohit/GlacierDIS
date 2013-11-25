using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GlacierDIS
{
    [XmlRoot("FundShareClassList")]
    public class XMLFundShareClass
    {
        [XmlElement("ShareClass")]
        public XMLShareClass[] XMLShareClass { get; set; }
    }

    [XmlRoot("ShareClass")]
    public class XMLShareClass
    {

        [XmlElement("Id")]
        public string Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("ISIN")]
        public string ISIN { get; set; }

        [XmlElement("LastUpdated")]
        public string LastUpdated { get; set; }
       

      



    }
}

