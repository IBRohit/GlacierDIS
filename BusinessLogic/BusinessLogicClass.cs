using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GlacierDIS
{
    public class BusinessLogicClass
    {

        public bool LoadClientId(ref string _ClientID)
        {
            try
            {

                String _cookieHeader = string.Empty;
                HttpWebResponse webResponse = null;
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://edw.morningstar.com/login.aspx?email=andre.schutte@glacier.co.za&password=g43wegdvfd");
                webRequest.Timeout = 50000;
                webRequest.PreAuthenticate = true;
                //webRequest.Credentials = new NetworkCredential(ds.Username, ds.Password);
                webRequest.AllowAutoRedirect = false;
                webRequest.CookieContainer = new CookieContainer();
                webResponse = (HttpWebResponse)webRequest.GetResponse();
                _cookieHeader = webResponse.Headers.Get("Set-Cookie");

                _ClientID = ParseCookie(_cookieHeader, "CLIENTID");
                 if (webResponse != null)
                    webResponse.Close();

                return true;

            }
            catch
            {

                return false;

            }




        }

        private String ParseCookie(String cookieHeader, String key)
        {
            String val = "";

            if (!String.IsNullOrEmpty(cookieHeader))
            {
                int pos = cookieHeader.IndexOf(key);
                if (pos >= 0)
                {
                    int startpos = -1;
                    int endpos = -1;

                    while (pos < cookieHeader.Length)
                    {
                        if (cookieHeader[pos] == '=')
                        {
                            startpos = pos + 1;
                        }
                        else if (cookieHeader[pos] == ';')
                        {
                            endpos = pos;
                            break;
                        }

                        ++pos;
                    }

                    if (startpos != -1 && endpos != -1)
                    {
                        val = cookieHeader.Substring(startpos, endpos - startpos);
                        val = val.Trim();
                    }
                }
            }

            return val;
        }
        public bool LoadFundDetailObjectFromXml(string _ClientID, String _FundShareClassId, ref XMLHolding _ObjXmlHolding, ref XMLVolatility _ObjXMLVolatilityTrailing, ref XMLVolatility _ObjXMLVolatilityQtrTrailing, ref XMLTrailingReturns _ObjXMLTrailingReturns)
        {

            try
            {
                //-------------Load Complete DataOut [Start]---------------------------------------

                HttpWebResponse webResponse = null;
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://edw.morningstar.com/DataOutput.aspx?Package=EDW&ClientId=" + _ClientID + "&Id=" + _FundShareClassId + "&IDTYpe=FundShareClassId&Content=7");
                webRequest.PreAuthenticate = true;
                webRequest.AllowAutoRedirect = false;
                webResponse = (HttpWebResponse)webRequest.GetResponse();
                var encoding = ASCIIEncoding.ASCII;
                string responseText = String.Empty;

                using (var reader = new System.IO.StreamReader(webResponse.GetResponseStream(), encoding))
                {
                    responseText = reader.ReadToEnd();
                }

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(responseText);
                XmlNode root = doc.SelectSingleNode("//FundShareClass");

                //-------------Load Complete DataOut [End]---------------------------------------


                //-------------Load XmlHolding [Start]---------------------------------------

                XmlNodeList HoldingnodeList = root.SelectNodes("Fund/PortfolioList/Portfolio/Holding");

                foreach (XmlNode n in HoldingnodeList)
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(XMLHolding));
                    XDocument document = XDocument.Parse(n.OuterXml.ToString());//XDocument.Parse(e.Result);
                    _ObjXmlHolding = (XMLHolding)serializer.Deserialize(document.CreateReader());
                 }

                //-------------Load XmlTrailing [Start]---------------------------------------




                //-------------Load XMLVolatility(TrailingPerformance) [Start]---------------------------------------

                XmlNodeList VolatilityNodeList = root.SelectNodes("ClassPerformance/Performance/TrailingPerformance/RiskAndRating/RiskAnalysis/RiskMeasures");

                foreach (XmlNode n in VolatilityNodeList)
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(XMLVolatility));
                    XDocument document = XDocument.Parse(n.OuterXml.ToString());//XDocument.Parse(e.Result);
                    _ObjXMLVolatilityTrailing = (XMLVolatility)serializer.Deserialize(document.CreateReader());
                }

                //-------------Load XMLVolatility(TrailingPerformance) [End]---------------------------------------



                //-------------Load XMLVolatility(QTRTrailingPerformance) [Start]---------------------------------------

                XmlNodeList VolatilityNodeListQtr = root.SelectNodes("ClassPerformance/Performance/QuarterlyTrailingPerformance/RiskAndRating/RiskAnalysis/RiskMeasures");

                foreach (XmlNode n in VolatilityNodeListQtr)
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(XMLVolatility));
                    XDocument document = XDocument.Parse(n.OuterXml.ToString());//XDocument.Parse(e.Result);
                    _ObjXMLVolatilityQtrTrailing = (XMLVolatility)serializer.Deserialize(document.CreateReader());
                }

                //-------------Load XMLVolatility(QTRTrailingPerformance) [End]---------------------------------------


                //-------------Load XMLTrailingReturn [Start]---------------------------------------

                XmlNodeList TrailingNodeList = root.SelectNodes("ClassPerformance/Performance/TrailingPerformance/TrailingReturn");

                foreach (XmlNode n in TrailingNodeList)
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(XMLTrailingReturns));
                    XDocument document = XDocument.Parse(n.OuterXml.ToString());//XDocument.Parse(e.Result);
                    _ObjXMLTrailingReturns = (XMLTrailingReturns)serializer.Deserialize(document.CreateReader());
                }

                //-------------Load XMLTrailingReturn [End]---------------------------------------


                return true;

            }
            catch
            {
                return false;

            }









        }


        public bool LoadFundObjectsFromXml(string _ClientID, ref XMLFundShareClass _ObjXMLFundShareClass)
        {

            try
            {

            
            HttpWebResponse webResponse = null;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://edw.morningstar.com/GetUniverseXML.aspx?ClientId=" + _ClientID + "&CountryId=ZAF&OutputVersion=0");
            webRequest.PreAuthenticate = true;
            webRequest.AllowAutoRedirect = false;
            webResponse = (HttpWebResponse)webRequest.GetResponse();
            var encoding = ASCIIEncoding.ASCII;
            string responseText = String.Empty;
            using (var reader = new System.IO.StreamReader(webResponse.GetResponseStream(), encoding))
            {
                responseText = reader.ReadToEnd();
            }



            XmlSerializer serializer = new XmlSerializer(typeof(XMLFundShareClass));
            XDocument document = XDocument.Parse(responseText);//XDocument.Parse(e.Result);
            _ObjXMLFundShareClass = (XMLFundShareClass)serializer.Deserialize(document.CreateReader());


            return true;

            }
            catch
            {

                return false;

            }




        }
    }
}
