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
    public class CargoVectorService : RQCoreAppServiceBase, ICargoVectorAppService

    {
        private readonly IRepository<CargoVector, int> _userRepository;
        public CargoVectorService(IRepository<CargoVector, int> userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateMission(CargoVectorDto input)
        {
            var result = Mapper.Map<CargoVector>(input);
            var task = _userRepository.Insert(result);
        }

        public int CreateMissionQ(CargoVectorDto input)
        {

            var result = Mapper.Map<CargoVector>(input);
            var task = _userRepository.InsertAndGetId(result);
            return task;
        }

        public void DeleteMission(int taskId)
        {
            var task = _userRepository.FirstOrDefault(t => t.CVID == taskId);
            var result = Mapper.Map<CargoVector>(task);
            if (task != null)
            { _userRepository.Delete(result); }
            
        }

        //public async Task<ListResultDto<CargoVectorDto>> GetAllCargoVector(CargoVectorDto input)
        //{
        //    var task = await _userRepository.GetAll()
                
        //        .WhereIf(input.CargoID.HasValue, t => t.CargoID == input.CargoID)
        //        .WhereIf(input.BillID.HasValue, t => t.BillID == input.BillID)
        //        .OrderByDescending(t => t.CVID)
        //        .ToListAsync();
        //    if (task != null)
        //    { return new ListResultDto<CargoVectorDto>(Mapper.Map<List<CargoVectorDto>>(task)); }
        //    else
        //    { throw new NotImplementedException(); }

        //}

        public IList<CargoVectorDto> GetAllMissions()
        {
            var task = _userRepository.GetAll()
                .OrderByDescending(t => t.CVID)
                .ToList();
            return Mapper.Map<List<CargoVectorDto>>(task);

        }

        public CargoVectorDto GetMissionById(int taskId)
        {
            var task = _userRepository.GetAll()
                .Where(t=>t.CVID==taskId)
               .OrderByDescending(t => t.CVID)
               .ToList();
            if (task != null)
            { return Mapper.Map<CargoVectorDto>(task); }
            else
            { throw new NotImplementedException(); }
        }

        public PagedResultDto<CargoVectorDto> GetPagedCargoVectors(SearchCargoVectorInput input)
        {
            //初步过滤
            var query = _userRepository.GetAll()
                .WhereIf(input.CVID.HasValue, t => t.CVID == input.CVID.Value)
                .WhereIf(input.CargoID.HasValue, t => t.CargoID==input.CargoID.Value)
                .WhereIf(input.BillID.HasValue,t=>t.BillID==input.BillID.Value);

            //排序
            //query = !string.IsNullOrEmpty(input.Sorting) ? query.OrderBy(input.Sorting) : query.OrderByDescending(t => t.CreationTime);
            query.OrderByDescending(t => t.CreationTime);


            //获取总数
            var tasksCount = query.Count();
            //默认的分页方式 source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            var taskList = query.Skip((input.pageIndex - 1) * input.pageSize).Take(input.pageSize).ToList();

            //ABP提供了扩展方法PageBy分页方式
            //var taskList = query.PageBy(input).ToList();

            return new PagedResultDto<CargoVectorDto>(tasksCount, taskList.MapTo<List<CargoVectorDto>>());
        }

        //public async Task<CargoVectorDto> GetMissionByIdAsync(int taskId)
        //{
        //    var task = await _userRepository.GetAll()
        //        .Where(t => t.CVID == taskId)
        //       .OrderByDescending(t => t.CVID)
        //       .ToListAsync();
        //    if (task != null)
        //    { return Mapper.Map<CargoVectorDto>(task); }
        //    else
        //    { throw new NotImplementedException(); }
        //}

        public void UpdateMission(CargoVectorDto input)
        {
            var task = _userRepository.GetAll().Where(t => t.CVID == input.CVID);
            var result = Mapper.Map<CargoVector>(input);
            if (task != null)
            { _userRepository.Update(result); } 
            else
            { throw new NotImplementedException(); }
        }
    }
}
