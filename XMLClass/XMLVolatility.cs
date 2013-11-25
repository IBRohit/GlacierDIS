using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GlacierDIS
{

    [XmlRoot("RiskMeasures")]
    public class XMLVolatility
    {

        [XmlElement("RiskMeasuresDetail")]
        public RiskMeasuresDetail[] RiskMeasuresDetail { get; set; }

    }

    [XmlRoot("RiskMeasuresDetail")]
    public class RiskMeasuresDetail
    {

        [XmlAttribute("Type")]
        public string Type { get; set; }

        [XmlAttribute("TimePeriod")]
        public string TimePeriod { get; set; }


        [XmlElement("ArithmeticMean")]
        public string ArithmeticMean { get; set; }

        [XmlElement("StandardDeviation")]
        public string StandardDeviation { get; set; }

        [XmlElement("SharpeRatio")]
        public string SharpeRatio { get; set; }


        [XmlElement("Skewness")]
        public string Skewness { get; set; }


        [XmlElement("Kurtosis")]
        public string Kurtosis { get; set; }


        [XmlElement("SortinoRatio")]
        public string SortinoRatio { get; set; }


    }
}
