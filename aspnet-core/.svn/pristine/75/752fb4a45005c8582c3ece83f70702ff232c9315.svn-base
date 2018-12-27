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

namespace RQCore.RQAppService
{
    public class TruckModelAppService :RQCoreAppServiceBase,ITruckModelAppService
    {
        private readonly IRepository<TruckModel, int> _userRepository;
        public TruckModelAppService(IRepository<TruckModel, int> userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateMission(TruckModelDto input)
        {
            Logger.Info("Creating a task for input: " + input);

            var task = Mapper.Map<TruckModel>(input);
            var result = _userRepository.Insert(task);

         
           

        }

        public int CreateMissionQ(TruckModelDto input)
        {          
            Logger.Info("Creating a task for input: " + input);

            var task = Mapper.Map<TruckModel>(input);
            int result = _userRepository.InsertAndGetId(task);
           
            return result;
           
        }
        public void UpdateMission(TruckModelDto input)
        { 
            Logger.Info("Updating a task for input: " + input);
           
            var updateTask = Mapper.Map<TruckModel>(input);
            _userRepository.Update(updateTask);
           
        }

        public void DeleteMission(int taskId)
        {
            var n = taskId;
            var task = _userRepository.GetAll().FirstOrDefault(r => r.TMID == taskId);
            if (task != null)
                 
                _userRepository.Delete(task);
            //throw new NotImplementedException();
        }
        //public async Task<ListResultDto<TruckModelDto>> GetAllTruckModel(TruckModelDto input)
        //{
        //    var TruckModels = await _userRepository.GetAll()
        //        .WhereIf(input.TMName.IsNullOrEmpty(), t => t.TMName == input.TMName)
        //        .OrderByDescending(t => t.CreationTime)
        //       .ToListAsync();

        //    return new ListResultDto<TruckModelDto>(
        //        AutoMapper.Mapper.Map<List<TruckModelDto>>(TruckModels));
        //    throw new NotImplementedException();
        //}


        public IList<TruckModelDto> GetAllMissions()
        {
            var tasks = _userRepository.GetAll().OrderByDescending(t => t.CreationTime).ToList();
            return Mapper.Map<IList<TruckModelDto>>(tasks);//因为已经定义了映射转换规则
            //throw new NotImplementedException();
        }


        public TruckModelDto GetMissionById(int taskId)
        {
            var task = _userRepository.GetAll().FirstOrDefault(t => t.TMID == taskId);

            return task.MapTo<TruckModelDto>();
            //throw new NotImplementedException();
        }

        public PagedResultDto<TruckModelDto> GetPagedTruckModels(SearchTruckModelInput input)
        {

            //初步过滤
            var query = _userRepository.GetAll()
                .WhereIf(input.TMPassenger.HasValue,t=>t.TMPassenger==input.TMPassenger.Value)
                .WhereIf(input.TMID.HasValue, t => t.TMID == input.TMID.Value)
                .WhereIf(!input.TMName.IsNullOrEmpty(), t => t.TMName.Contains(input.TMName));

            //排序
            //query = !string.IsNullOrEmpty(input.Sorting) ? query.OrderBy(input.Sorting) : query.OrderByDescending(t => t.CreationTime);
            query.OrderByDescending(t => t.CreationTime);


            //获取总数
            var tasksCount = query.Count();
            //默认的分页方式 source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            var taskList = query.Skip((input.pageIndex - 1) * input.pageSize).Take(input.pageSize).ToList();

            //ABP提供了扩展方法PageBy分页方式
            //var taskList = query.PageBy(input).ToList();

            return new PagedResultDto<TruckModelDto>(tasksCount, taskList.MapTo<List<TruckModelDto>>());
        }

        //public async Task<TruckModelDto> GetMissionByIdAsync(int taskId)
        //{       //Called specific GetAllWithPeople method of task repository.
        //    var task = await _userRepository.GetAsync(taskId);

        //    //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
        //    return task.MapTo<TruckModelDto>();
        //    //throw new NotImplementedException();
        //}

        //public Task<ListResultDto<TruckModelDto>> GetAllTruckInfo(TruckModelDto input)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
