using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
    public interface IBranchInfoAppService : IApplicationService
    {
        void CreateMission(BranchInfoDto input);
        int? CreateMissionQ(BranchInfoDto input);

        void UpdateMission(BranchInfoDto input);


        void DeleteMission(int taskId);
        //例如GetAll方法
      //  Task<ListResultDto<BranchInfoDto>> GetAllBranchInfo(BranchInfoDto input);
        IList<BranchInfoDto> GetAllMissions();

        //BranchInfoDto GetTruckInfoes(BranchInfoDto input);//根据查询参数 获取结果列表
        PagedResultDto<BranchInfoDto> GetPagedBranchInfos(SearchBranchInfoInput input);//根据查询参数，返回被分页的结果列表


        BranchInfoDto GetMissionById(int taskId);
        //TaskCacheItem GetTaskFromCacheById(int taskId);
      //  Task<BranchInfoDto> GetMissionByIdAsync(int taskId);

    }
}
