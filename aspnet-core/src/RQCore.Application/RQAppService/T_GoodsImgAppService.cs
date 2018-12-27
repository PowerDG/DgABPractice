using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RQCore.RQDtos;
using RQCore.RQEnitity;
using Abp.Extensions;
using RQCore.IRQAppService;
using Abp.Domain.Uow;

namespace RQCore.RQAppService
{
    public class T_GoodsImgAppService : RQCoreAppServiceBase, IT_GoodsImgAppService
    {
        private readonly IRepository<T_GoodsImg, int> _T_GoodsImgrepository;
        public T_GoodsImgAppService (IRepository<T_GoodsImg,int> T_GoodsImgrepository)
        {
            _T_GoodsImgrepository = T_GoodsImgrepository;
        }
        public void CreateMission(T_GoodsImgDto input)
        {
            var task = Mapper.Map<T_GoodsImg>(input);
            task.Id = null;
            _T_GoodsImgrepository.Insert(task);
        }
        [UnitOfWork]
        public int? CreateMissionQ(T_GoodsImgDto input)
        {
            var task = Mapper.Map<T_GoodsImg>(input);
            task.Id = null;
          //  long NO = ShortSnowflake.Instance().GetId();
          var result= _T_GoodsImgrepository.Insert(task);
            CurrentUnitOfWork.SaveChanges();
            return result.Id;
        }

        public void DeleteMissionAll(int taskId)
        {
            var tasklist = _T_GoodsImgrepository.GetAll()
                .Where(t => t.TGID == taskId).ToList();
            foreach(T_GoodsImg task in tasklist)
            {
                _T_GoodsImgrepository.Delete(task);
            }
            
        }

        public void DeleteMissionById(int taskId)
        {
            _T_GoodsImgrepository.Delete(taskId);
        }

        public IList<T_GoodsImgDto> GetAllMissions()
        {
            var task = _T_GoodsImgrepository.GetAllList();
            var result = Mapper.Map<List<T_GoodsImgDto>>(task);
            return result;
        }
         
        public IList<string> GetImageUrl(int taskId)
        {
            var task = (from r in _T_GoodsImgrepository.GetAll()
                        where r.TGID == taskId
                        select  r.ImgUrl ).ToList();
            return task;
        }

        public T_GoodsImgDto GetMissionById(int taskId)
        {
            var task = _T_GoodsImgrepository.FirstOrDefault(t => t.Id == taskId);
            var result = Mapper.Map<T_GoodsImgDto>(task);
            return result;
        }
    }
}
