using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
    public interface ICargoVectorAppService : IApplicationService
    {
        void CreateMission(CargoVectorDto input);
        int CreateMissionQ(CargoVectorDto input);

        void UpdateMission(CargoVectorDto input);


        void DeleteMission(int taskId);
        //例如GetAll方法
       // Task<ListResultDto<CargoVectorDto>> GetAllCargoVector(CargoVectorDto input);
        IList<CargoVectorDto> GetAllMissions();

        //BranchInfoDto GetTruckInfoes(BranchInfoDto input);//根据查询参数 获取结果列表
        PagedResultDto<CargoVectorDto> GetPagedCargoVectors(SearchCargoVectorInput input);//根据查询参数，返回被分页的结果列表


        CargoVectorDto GetMissionById(int taskId);
        //TaskCacheItem GetTaskFromCacheById(int taskId);
        //Task<CargoVectorDto> GetMissionByIdAsync(int taskId);

    }
}
