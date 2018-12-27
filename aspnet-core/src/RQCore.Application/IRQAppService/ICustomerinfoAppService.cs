using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
    public interface ICustomerInfoAppService : IApplicationService
    {
        void CreateMission(CustomerInfoDto input);
        int CreateMissionQ(CustomerInfoDto input);

        void UpdateMission(CustomerInfoDto input);


        void DeleteMission(int taskId);
        //例如GetAll方法
       // Task<ListResultDto<CustomerInfoDto>> GetAllCustomerInfo(CustomerInfoDto input);
        IList<CustomerInfoDto> GetAllMissions();

 
        PagedResultDto<SearchCustomerInfoDto> GetPagedCustomerInfos(SearchCustomerInfoInput input);//根据查询参数，返回被分页的结果列表


        CustomerInfoDto GetMissionById(int taskId);
        List<SelectDto> GetCustomerIDList();

        IList<SearchCustomerInfoDto> GetAllSearchDto();
        //TaskCacheItem GetTaskFromCacheById(int taskId);
        //  Task<CustomerInfoDto> GetMissionByIdAsync(int taskId);

    }
}
