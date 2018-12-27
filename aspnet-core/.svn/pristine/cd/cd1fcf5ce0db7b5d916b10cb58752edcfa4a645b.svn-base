using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
    public interface IBillInfoAppService : IApplicationService
    {
        string CreateMission_user(BillInfoDto input);
        string CreateMission_admin(BillInfoDto input);
        int CreateMissionQ(BillInfoDto input);

        string UpdateMission_user(BillInfoDto input);
        string UpdateMission_admin(BillInfoDto input);


        string DeleteMission_user(long taskId);
        string DeleteMission_admin(long taskId);
        //例如GetAll方法
        // Task<ListResultDto<BillInfoDto>> GetAllBillInfo(BillInfoDto input);
        IList<BillInfoDto> GetAllMissions();

        //BranchInfoDto GetTruckInfoes(BranchInfoDto input);//根据查询参数 获取结果列表
        // PagedResultDto<BillInfoDto> GetPagedBillInfos(BillInfoDto input);//根据查询参数，返回被分页的结果列表


        BillInfoDto GetMissionById(long taskId);
        //int GetKeyId();
        //TaskCacheItem GetTaskFromCacheById(int taskId);
       // Task<BillInfoDto> GetMissionByIdAsync(int taskId);

    }
}
