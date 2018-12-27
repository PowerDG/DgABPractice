using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.RQDtos;

namespace RQCore.IRQAppService
{
    public interface IT_GoodsImgAppService : IApplicationService
    {
        void CreateMission(T_GoodsImgDto input);
        int? CreateMissionQ(T_GoodsImgDto input);

      //  void UpdateMission(T_GoodsImgDto input);


        void DeleteMissionAll(int taskId); //批量删除
        void DeleteMissionById(int taskId);  //单个删除
        //例如GetAll方法
        //  Task<ListResultDto<T_GoodsImgDto>> GetAllT_GoodsImg(T_GoodsImgDto input);
        IList<T_GoodsImgDto> GetAllMissions();
        IList<string> GetImageUrl(int taskId);

        //BranchInfoDto GetTruckInfoes(BranchInfoDto input);//根据查询参数 获取结果列表
        //PagedResultDto<BranchInfoDto> GetPagedTruckInfoes(BranchInfoDto input);//根据查询参数，返回被分页的结果列表


        T_GoodsImgDto GetMissionById(int taskId);
        //TaskCacheItem GetTaskFromCacheById(int taskId);
       // Task<T_GoodsImgDto> GetMissionByIdAsync(int taskId);

    }
}
