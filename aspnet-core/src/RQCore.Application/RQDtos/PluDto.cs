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
    [AutoMap(typeof(Plu))]
    public class PluDto
    {   public long ? Id { get; set; }
        public string Province { get; set; }
        public string Destination_city { get; set; }
        public string Aging { get; set; }

        public decimal Price_Kg { get; set; }
        public decimal Price_Cu { get; set; }
    }
    [AutoMap(typeof(Plu))]
    public class SearchPluDtoInput 
    {
      
        public string Province { get; set; }
        public string Destination_city { get; set; }
       
    }
}
