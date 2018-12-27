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
{/// <summary>
/// 所有下拉框选项key ,value 统一DTO模型
/// </summary>
   public class SelectDto : EntityDto
    {
        public new int Id { get; set; }
        public string Name { get; set; }
    }
    public class SelectLongDto : EntityDto<long>
    {
        public new long Id { get; set; }
        public string Name { get; set; }
    }
    public class SelectStringDto : EntityDto<string>
    {
        public new string Id { get; set; }
        public string Name { get; set; }
    }
}
