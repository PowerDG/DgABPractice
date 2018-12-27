using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
  
    public interface IPluAppService : IApplicationService
    {
        //  IList<PluDto> GetAllMissions();

        List<SelectStringDto> GetProvince();  //省份选择
        List<SelectStringDto> GetCity(string taskId);    //城市选择

        PluDto GetPlu(SearchPluDtoInput input);

        void CreatePlu(PluDto input);

    }
}
