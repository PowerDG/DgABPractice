using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
    public interface ITruckModelAppService : IApplicationService
    {
        void CreateMission(TruckModelDto input);
        //  int CreateMissionQ(TruckModelDto input);

        void UpdateMission(TruckModelDto input);


        void DeleteMission(int taskId);
        //例如GetAll方法
       // Task<ListResultDto<TruckModelDto>> GetAllTruckInfo(TruckModelDto input);
        IList<TruckModelDto> GetAllMissions();

        //BranchInfoDto GetTruckInfoes(BranchInfoDto input);//根据查询参数 获取结果列表
        PagedResultDto<TruckModelDto> GetPagedTruckModels(SearchTruckModelInput input);//根据查询参数，返回被分页的结果列表


        TruckModelDto GetMissionById(int taskId);
        //TaskCacheItem GetTaskFromCacheById(int taskId);
        //  Task<TruckModelDto> GetMissionByIdAsync(int taskId);

    }
}
