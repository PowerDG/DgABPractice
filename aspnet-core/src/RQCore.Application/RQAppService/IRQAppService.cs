using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos; 

namespace RQCore.RQAppService
{
    public interface IRQAppService : IApplicationService
    {
        //例如GetAll方法
        //Task<ListResultDto<RQStaffDto>> GetAllRQStaff(RQStaffDto input);

    }




 



    public interface IDepartmentInfoAppService : IApplicationService
    {
        void CreateMission(DepartmentInfoDto input);
        int CreateMissionQ(DepartmentInfoDto input);

        void UpdateMission(DepartmentInfoDto input, int id);


        void DeleteMission(int taskId);
        //例如GetAll方法
        Task<ListResultDto<DepartmentInfoDto>> GetAllDepartmentInfo(DepartmentInfoDto input);
        IList<DepartmentInfoDto> GetAllMissions();

        //BranchInfoDto GetTruckInfoes(BranchInfoDto input);//根据查询参数 获取结果列表
        //PagedResultDto<BranchInfoDto> GetPagedTruckInfoes(BranchInfoDto input);//根据查询参数，返回被分页的结果列表


        DepartmentInfoDto GetMissionById(int taskId);
        //TaskCacheItem GetTaskFromCacheById(int taskId);
        Task<DepartmentInfoDto> GetMissionByIdAsync(int taskId);

    }

    
}

