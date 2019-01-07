using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UEditor
{
    public class DictController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public void d()
        {
            SortedDictionary<string, object> DgDict = new SortedDictionary<string, object>();

            // InspectionState	int	default 0	审批状态,0-已申请,1-通过,2-驳回
            // trafficLog
            // 括0在途中、1已揽收、2疑难、3已签收、4退签、5同城派送中、6退回、7转单等7个状态，其中4-7需要另外开通才有效
            //  StatuesNo  displayName   description  

            TrafficLog[] trafficLogs = {
            new TrafficLog(0,"在途中",""),
            new TrafficLog(1,"已揽收",""),
            new TrafficLog(2,"疑难",""),
            new TrafficLog(3,"已签收",""),
            new TrafficLog(4,"退签",""),
            new TrafficLog(5,"同城派送中",""),
            new TrafficLog(6,"退回",""),
            new TrafficLog(7,"转单","")
            };
            DgDict.Add("trafficLogDict", trafficLogs);


        }
    }


    public class DgDict
    {
        //private new TrafficLog() { 1,"",""};   
        TrafficLog[] trafficLogs = {
            new TrafficLog(1,"",""),
            new TrafficLog(2,"","")

        };

    }

    public struct TrafficLog
    {
        //    public string Status ;
      
        public int StatueNo;
        public string displayName;
        public string description;
        public TrafficLog(int No, string Name, string Des)
        {
            StatueNo = No; displayName = Name; description = Des;                   
        }
    };

    public class DgDictionary
    {
        //    public string Status ;

        public int StatueNo;

        public string Subject;

        public string Claim_Name;
        public string DisplayName;
        public string Description;
        public string Claim_Value;

        public string Issuer;
        public string Claim_Type;
        public string Super_Type;
        public string Sub_Type;

        public int Sorting;
        public bool isDisplay;

         

        //public TrafficLog(int No, string Name, string Des)
        //{
        //    StatueNo = No; displayName = Name; description = Des;
        //}
    };

  
    //Domain_type
}
