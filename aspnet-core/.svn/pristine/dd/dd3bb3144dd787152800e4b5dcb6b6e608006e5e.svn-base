using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using RQCore.RQEnitity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RQCore.RQDtos
{
    [AutoMap(typeof(TruckInfo))]
    public class TruckInfoDto :EntityDto<long>
    {


       public new long? Id { get; set; }
        public long TruckID { get; set; }

        public string TruckNum { get; set; }
        public string TruckEngineNum { get; set; }
        public string TruckRunNum { get; set; }
        public string TruckInsuranceNum { get; set; }
        public int TMID { get; set; }
        public string TruckColor { get; set; }
        public string TruckPhoto { get; set; }
        public string TruckBuyData { get; set; }
        public int BranchID { get; set; }
        public int TruckIsVacancy { get; set; }


        //public TruckModel TruckModel { get; set; }
    }

    public class SearchTruckInfoInput
    { 
   
        public long? TruckID { get; set; }


        public int pageIndex { get; set; }

        public int pageSize { get; set; }

        public string TruckNum { get; set; }
        public string TruckEngineNum { get; set; }
        public string TruckRunNum { get; set; }
        public string TruckInsuranceNum { get; set; }
        public int? TMID { get; set; }
        public string TruckColor { get; set; }
        public string TruckPhoto { get; set; }
        public string TruckBuyData { get; set; }
        public int? BranchID { get; set; }
        public int? TruckIsVacancy { get; set; }


        //public TruckModel TruckModel { get; set; }
    }
    public class SearchTruckInfoDto
    {
        public long TruckID { get; set; }
        public string TruckNum { get; set; }
        public string TMName { get; set; }
        public string TruckColor { get; set; }
        public string TruckBuyData { get; set; }
        public string BranchName { get; set; }
        public int TruckIsVacancy { get; set; }
    }
}
