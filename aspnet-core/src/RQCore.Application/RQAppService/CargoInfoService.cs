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
    public class CargoInfoService : RQCoreAppServiceBase, ICargoInfoAppService
    {
        private readonly IRepository<CargoInfo, int> _userRepository;
        public CargoInfoService(IRepository<CargoInfo, int> userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateMission(CargoInfoDto input)
        {
            var task = Mapper.Map<CargoInfo>(input);
            if (task != null)
            { var result=_userRepository.Insert(task); }
        }

        public int CreateMissionQ(CargoInfoDto input)
        {
            var task = Mapper.Map<CargoInfo>(input);
            if (task != null)
            {
                int result = _userRepository.InsertAndGetId(task);
                return result;
            }
            else
            { return 0; }
        }
        public void UpdateMission(CargoInfoDto input)
            {
           // var task = _userRepository.GetAll().FirstOrDefault(t => t.CargoID == input.CargoID);
            var result = Mapper.Map<CargoInfo>(input);
            if (result != null)
            { _userRepository.Update(result); }

        }
        public void DeleteMission(int taskId)
        {
            var task = _userRepository.FirstOrDefault(t => t.CargoID == taskId);
            if (task != null)
            { _userRepository.Delete(task); }
        }
        public PagedResultDto<CargoInfoDto> GetPagedCargoInfos(SearchCargoInfoInput input)
        {
            //初步过滤
            var query = _userRepository.GetAll()
                .WhereIf(input.BranchID.HasValue,t=>t.BranchID==input.BranchID.Value )          
                .WhereIf(!input.CargoName.IsNullOrEmpty(), t => t.CargoName.Contains(input.CargoName));

            //排序
            //query = !string.IsNullOrEmpty(input.Sorting) ? query.OrderBy(input.Sorting) : query.OrderByDescending(t => t.CreationTime);
            query.OrderByDescending(t => t.CreationTime);


            //获取总数
            var tasksCount = query.Count();
            //默认的分页方式 source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            var taskList = query.Skip((input.pageIndex - 1) * input.pageSize).Take(input.pageSize).ToList();

            //ABP提供了扩展方法PageBy分页方式
            //var taskList = query.PageBy(input).ToList();

            return new PagedResultDto<CargoInfoDto>(tasksCount, taskList.MapTo<List<CargoInfoDto>>());
        }

        public IList<CargoInfoDto> GetAllMissions()
        {
            var task = _userRepository.GetAll().OrderByDescending(t => t.CargoID);
            return Mapper.Map<List<CargoInfoDto>>(task);
        }

        //public async Task<ListResultDto<CargoInfoDto>> GetAllCargoInfo(CargoInfoDto input)
        //{
        //    var task = await _userRepository.GetAll().OrderByDescending(t => t.CargoID).ToListAsync();
        //    return new ListResultDto<CargoInfoDto>(
        //       AutoMapper.Mapper.Map<List<CargoInfoDto>>(task));
        //}

        public CargoInfoDto GetMissionById(int taskId)
        {
            var task = _userRepository.GetAll().First(t => t.CargoID == taskId);
            var result = Mapper.Map<CargoInfoDto>(task);
            if (task != null)
            { return result; }
            else
            { throw new NotImplementedException(); }
        }



        //public async Task<CargoInfoDto> GetMissionByIdAsync(int taskId)
        //{
        //    var task = await _userRepository.GetAll().Where(t => t.CargoID == taskId).ToListAsync();
        //    var result = Mapper.Map<CargoInfoDto>(task);
        //    if (task != null)
        //    { return result; }
        //    else
        //    { throw new NotImplementedException(); }
        //}
    }
}
