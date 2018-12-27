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

    [AutoMap(typeof(TruckModel))]
    public class TruckModelDto :EntityDto
    {
     
        public int TMID { get; set; }

        public string TMName { get; set; }
   
        public string TMWeight { get; set; }

        public string UTMCubage { get; set; }
        public int TMPassenger { get; set; }


        //public ICollection<TruckInfo> TruckInfo { get; set; }o
    }

    public class SearchTruckModelInput : EntityDto
    {


        public int? TMID { get; set; }

        public int pageIndex { get; set; }

        public int pageSize { get; set; }

        public string TMName { get; set; }


        public string TMWeight { get; set; }


        public string UTMCubage { get; set; }
        public int? TMPassenger { get; set; }


        //public ICollection<TruckInfo> TruckInfo { get; set; }o
    }



}
