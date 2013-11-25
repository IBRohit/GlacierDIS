using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GlacierDIS
{
        
    [XmlRoot("Holding")]
    public class XMLHolding
    {

        [XmlElement("HoldingDetail")]
        public HoldingDetail[] HoldingDetail { get; set; }
    }


    [XmlRoot("Currency")]
    public class HoldingDetailCurrency
    {

        [XmlAttribute("_Id")]
        public string _Id { get; set; }

        [XmlText()]
        public string Value { get; set; }

    }

    [XmlRoot("Country")]
    public class HoldingDetailCountry
     {

        [XmlAttribute("_Id")]
        public string _Id { get; set; }

        [XmlText()]
        public string Value { get; set; }

    }

    [XmlRoot("HoldingDetail")]
    public class HoldingDetail
    {

        [XmlAttribute("_Id")]
        public string HoldingMorningStarid { get; set; }

        [XmlAttribute("DetailHoldingTypeId")]
        public string _DetailHoldingTypeId { get; set; }



        [XmlElement("Country")]
        public HoldingDetailCountry[] HoldingDetailCountry { get; set; }


        [XmlElement("Currency")]
        public HoldingDetailCurrency[] HoldingDetailCurrency { get; set; }
 
        
  //<Currency _Id="EUR">Euro</Currency> 
 
 
  //<>0</ShareChange> 
  //<>0</Coupon> 
  //<>30845099</IndustryId> 
  //<>30845099</GlobalIndustryId> 
  //<>308</GlobalSector> 
  //<>ZAR</LocalCurrencyCode> 
  //<>DEP</ZAFAssetType> 
  //<>2005-03-31</FirstBoughtDate> 
  //<>0P0000ST9P</PerformanceId> 


        [XmlElement("CUSIP")]
        public string CUSIP { get; set; }

        [XmlElement("ISIN")]
        public string ISIN { get; set; }


        [XmlElement("SecurityName")]
        public string SecurityName { get; set; }


        [XmlElement("Weighting")]
        public string Weighting { get; set; }


        [XmlElement("NumberOfShare")]
        public string NumberOfShare { get; set; }


        [XmlElement("MarketValue")]
        public string MarketValue { get; set; }


        [XmlElement("ShareChange")]
        public string ShareChange { get; set; }


        [XmlElement("Coupon")]
        public string Coupon { get; set; }


        [XmlElement("IndustryId")]
        public string IndustryId { get; set; }

        
        [XmlElement("GlobalIndustryId")]
        public string GlobalIndustryId { get; set; }


        [XmlElement("GlobalSector")]
        public string GlobalSector { get; set; }

        [XmlElement("LocalCurrencyCode")]
        public string LocalCurrencyCode { get; set; }


        [XmlElement("ZAFAssetType")]
        public string ZAFAssetType { get; set; }


        [XmlElement("FirstBoughtDate")]
        public string FirstBoughtDate { get; set; }

        [XmlElement("PerformanceId")]
        public string PerformanceId { get; set; }




    }
}
