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
    [AutoMap(typeof(CargoVector))]
    public class CargoVectorDto : EntityDto
   {
     [Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CVID { get; set; }

    public int? CargoID { get; set; }
    public int? BillID { get; set; }
    }
    public class SearchCargoVectorInput : EntityDto
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CVID { get; set; }

        public int pageIndex { get; set; }

        public int pageSize { get; set; }

        public int? CargoID { get; set; }
        public int? BillID { get; set; }
    }


}
