using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using GlacierDIS.Models;

namespace GlacierDIS
{
    class Program
    {
        static void Main(string[] args)
        {

           // MorningStarLogin();
            StartProcessing();
        }



        static void StartProcessing()
        {
            BusinessLogicClass _Objbusiness = new BusinessLogicClass();
            XMLFundShareClass _ObjXMLFundShareClass = new XMLFundShareClass();
            XMLVolatility _ObjXMLVolatilityTrailing = new XMLVolatility();
            XMLVolatility _ObjXMLVolatilityQTRTrailing = new XMLVolatility();
            XMLTrailingReturns _ObjXMLTrailingReturns = new XMLTrailingReturns();


            String _ClientId = string.Empty;
            bool _BlnclientIdOutPut = false;
            bool _BlnFundShareClassOutPut = false;
            bool BlnFundDetailOutput = false;


             _BlnclientIdOutPut = _Objbusiness.LoadClientId(ref _ClientId);

             if (_BlnclientIdOutPut == false)
             {

                 return;
             }

             _BlnFundShareClassOutPut = _Objbusiness.LoadFundObjectsFromXml(_ClientId, ref _ObjXMLFundShareClass);

             for (int _CntFundShareClass = 0; _CntFundShareClass < _ObjXMLFundShareClass.XMLShareClass.Count(); _CntFundShareClass++)
            {
                XMLHolding _ObjXMLHolding = new XMLHolding();
                string _ShareClassId = _ObjXMLFundShareClass.XMLShareClass[_CntFundShareClass].Id;
                BlnFundDetailOutput = _Objbusiness.LoadFundDetailObjectFromXml(_ClientId, _ShareClassId, ref _ObjXMLHolding, ref _ObjXMLVolatilityTrailing, ref _ObjXMLVolatilityQTRTrailing, ref _ObjXMLTrailingReturns);



                 using(GlacierDISContext _Ctx=new GlacierDISContext())
                 {
                                    
                 ImportHeader _ObjImportHeader=new ImportHeader();
                 _ObjImportHeader.ProcessingStatus = 0;
                 _ObjImportHeader.ProcessingMonth = System.DateTime.Now;




                 FundShare _objFundShare = new FundShare();
                 _objFundShare.FundShareClassId = _ShareClassId;




                 FundShareIndex _ObjFundShareIndex = new FundShareIndex();
                 _ObjFundShareIndex.ImportHeaderId = _ObjImportHeader.Id;
                 _ObjFundShareIndex.FundShareId = _objFundShare.Id;


                 _Ctx.FundShareIndexes.Add(_ObjFundShareIndex);
                 _Ctx.FundShares.Add(_objFundShare);
                 _Ctx.ImportHeaders.Add(_ObjImportHeader);


                 _Ctx.SaveChanges();
                 }


                break;


            }




        
        }


        static bool SaveFundData()
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }


        }






    }
}
