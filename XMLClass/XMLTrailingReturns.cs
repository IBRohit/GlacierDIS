using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GlacierDIS
{

    [XmlRoot("TrailingReturn")]
    public class XMLTrailingReturns
    {
        [XmlElement("Return")]
        public Return[] Return { get; set; }


    }

    [XmlRoot("Return")]
    public class Return
    {

        [XmlAttribute("Type")]
        public string Type { get; set; }

        [XmlAttribute("StoreDate")]
        public string StoreDate { get; set; }


        [XmlElement("EndDate")]
        public string EndDate { get; set; }

        [XmlElement("ClosePrice")]
        public string ClosePrice { get; set; }

        [XmlElement("PriceDate")]
        public string PriceDate { get; set; }


        [XmlElement("ReturnDetail")]
        public ReturnDetail[] ReturnDetail { get; set; }
      
        
    }

    [XmlRoot("ReturnDetail")]
    public class ReturnDetail
    {

        [XmlAttribute("TimePeriod")]
        public string TimePeriod { get; set; }

        [XmlElement("Value")]
        public string Value { get; set; }


    }
}
