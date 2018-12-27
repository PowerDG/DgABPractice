using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
    public interface ITruckInfoAppService : IApplicationService
    {



        string CreateMission(TruckInfoDto input);
        long CreateMissionQ(TruckInfoDto input);

        string UpdateMission(TruckInfoDto input);


        string DeleteMission(long taskId);
        //例如GetAll方法
       // Task<ListResultDto<TruckInfoDto>> GetAllTruckInfo(TruckInfoDto input);
        IList<TruckInfoDto> GetAllMissions();

        //BranchInfoDto GetTruckInfoes(BranchInfoDto input);//根据查询参数 获取结果列表
        PagedResultDto<TruckInfoDto> GetPagedTasks(SearchTruckInfoInput input);//根据查询参数，返回被分页的结果列表


        TruckInfoDto GetMissionById(long taskId);

        IList<SearchTruckInfoDto> GetAllSearchDto();
        //TaskCacheItem GetTaskFromCacheById(int taskId);
        //  Task<TruckInfoDto> GetMissionByIdAsync(int taskId);






    }
}
