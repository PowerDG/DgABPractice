using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
    public interface ICargoInfoAppService : IApplicationService
    {
        void CreateMission(CargoInfoDto input);
        int CreateMissionQ(CargoInfoDto input);

        void UpdateMission(CargoInfoDto input);


        void DeleteMission(int taskId);
        //例如GetAll方法
      //  Task<ListResultDto<CargoInfoDto>> GetAllCargoInfo(CargoInfoDto input);
        IList<CargoInfoDto> GetAllMissions();

        //BranchInfoDto GetTruckInfoes(BranchInfoDto input);//根据查询参数 获取结果列表
        PagedResultDto<CargoInfoDto> GetPagedCargoInfos(SearchCargoInfoInput input);//根据查询参数，返回被分页的结果列表


        CargoInfoDto GetMissionById(int taskId);
        //TaskCacheItem GetTaskFromCacheById(int taskId);
        // Task<CargoInfoDto> GetMissionByIdAsync(int taskId);

    }
}
