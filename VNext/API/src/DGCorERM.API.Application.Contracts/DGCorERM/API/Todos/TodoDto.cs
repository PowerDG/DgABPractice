using System;
using Volo.Abp.Application.Dtos;

namespace DGCorERM.API.Todos
{
    public class TodoDto : EntityDto<Guid>
    {
        public string Text { get; set; }
    }
}