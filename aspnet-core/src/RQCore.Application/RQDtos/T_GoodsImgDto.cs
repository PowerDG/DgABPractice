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
    [AutoMap(typeof(T_GoodsImg))]
    public class T_GoodsImgDto :EntityDto<int>
    {
       public new int Id { get; set; }
        public int TGID { get; set; }
        [MaxLength(255)]
        public string ImgUrl { get; set; }
        [MaxLength(50)]
        public string Remark { get; set; }
    }
}
