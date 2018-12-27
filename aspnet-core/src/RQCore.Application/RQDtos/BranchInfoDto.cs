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


    [AutoMap(typeof(BranchInfo))]
    public class BranchInfoDto 
    {
        public  int? Id { get; set; }
        public  int BranchID { get; set; }

        [MaxLength(255)]
        public string BranchName { get; set; }
        [MaxLength(255)]
        public string BranchLinkMan { get; set; }
        [MaxLength(255)]
        public string BranchPhone { get; set; }
        public string BranchAddress { get; set; }
        [MaxLength(255)]
        public string BranchEmail { get; set; }
    }
    public class SearchBranchInfoInput
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int? BranchID { get; set; }

        public string BranchName { get; set; }



    }
}
