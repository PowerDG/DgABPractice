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
    [AutoMap(typeof(CargoInfo))]
    public class CargoInfoDto : EntityDto
    {
        [Key]

        public int CargoID { get; set; }

     

        [MaxLength(255)]
        [Required]
        public string CargoName { get; set; }
        [MaxLength(255)]
        [Required]
        public string CargoWeight { get; set; }
        [MaxLength(255)]
        [Required]
        public string CargoBulk { get; set; }
        [MaxLength(255)]
        [Required]
        public string CargoNum { get; set; }
        [MaxLength(255)]
        public string CargoUnit { get; set; }
        [MaxLength(255)]
        public string CargoValue { get; set; }
        [MaxLength(255)]
        public string CargoFreight { get; set; }
        [MaxLength(255)]
        public string CargoAmends { get; set; }
        [MaxLength(255)]
        public string CargoMemo { get; set; }
    
        public int CargoState { get; set; }

        public int BranchID { get; set; }
        public DateTime? CargoStartData { get; set; }
        public DateTime? CargoEndData { get; set; }

    }
    [AutoMap(typeof(CargoInfo))]
    public class SearchCargoInfoInput : EntityDto
    {
        [Key]

 
        public int? CargoID { get; set; }

        public int pageIndex { get; set; }

        public int pageSize { get; set; }

        [MaxLength(255)]

        public string CargoName { get; set; }
        [MaxLength(255)]

        public string CargoWeight { get; set; }
        [MaxLength(255)]

        public string CargoBulk { get; set; }
        [MaxLength(255)]

        public string CargoNum { get; set; }
        [MaxLength(255)]
        public string CargoUnit { get; set; }
        [MaxLength(255)]
        public string CargoValue { get; set; }
        [MaxLength(255)]
        public string CargoFreight { get; set; }
        [MaxLength(255)]
        public string CargoAmends { get; set; }
        [MaxLength(255)]
        public string CargoMemo { get; set; }
        [DefaultValue(0)]
        public int? CargoState { get; set; }
        [MaxLength(255)]
        public int? BranchID { get; set; }
        public DateTime? CargoStartData { get; set; }    
        public DateTime? CargoEndData { get; set; }

    }


}
