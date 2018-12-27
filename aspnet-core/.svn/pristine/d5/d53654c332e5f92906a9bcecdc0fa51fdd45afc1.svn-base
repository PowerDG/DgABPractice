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
using Abp.Collections.Extensions;
using RQCore.EntityFrameworkCore;
using Abp.Domain.Uow;

namespace RQCore.RQAppService
{
    public class BranchInfoService : RQCoreAppServiceBase, IBranchInfoAppService
    {
       
        public readonly IRepository<BranchInfo, int> _userRepository;
        public BranchInfoService(IRepository<BranchInfo, int> userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateMission(BranchInfoDto input)
        {
            var task = Mapper.Map<BranchInfo>(input);
            task.Id = null;  //自增列
            if (task != null)
            { _userRepository.Insert(task); }
        }

        [UnitOfWork]
        public int? CreateMissionQ(BranchInfoDto input)
        {
            var task = Mapper.Map<BranchInfo>(input);
            task.Id = null;  //自增列
           // var sdd = ShortSnowflake.Instance().GetId();
            if (task != null)
            {
                var result= _userRepository.Insert(task);
                CurrentUnitOfWork.SaveChanges();          
                return task.Id;
            }
            else
            { return 0; }
        }
        public void UpdateMission(BranchInfoDto input)
        {
            var task = _userRepository.GetAll().Where(t=>t.Id==input.Id);
            var result = Mapper.Map<BranchInfo>(task);
            if (task != null)
            { _userRepository.Update(result); }

        }
        public void DeleteMission(int taskId)
        {
            var task = _userRepository.FirstOrDefault(t => t.Id == taskId);
            if (task!=null)
            { _userRepository.Delete(t=> t.BranchID == taskId); }
        }

        public IList<BranchInfoDto> GetAllMissions()
        {
            var task = _userRepository.GetAll().OrderByDescending(t => t.Id);
            return Mapper.Map<List<BranchInfoDto>>(task);
        }

        //public async Task<ListResultDto<BranchInfoDto>> GetAllBranchInfo(BranchInfoDto input)
        //{
        //    var task =await _userRepository.GetAll().OrderByDescending(t => t.Id).ToListAsync();
        //    return new ListResultDto<BranchInfoDto>(
        //       AutoMapper.Mapper.Map<List<BranchInfoDto>>(task));
        //}

        public BranchInfoDto GetMissionById(int taskId)
        {
            var task = _userRepository.GetAll().FirstOrDefault(t => t.Id == taskId);
            var result = Mapper.Map<BranchInfoDto>(task);
            if (task != null)
            { return result; }
            else
            { throw new NotImplementedException(); }
        }

        //public async Task<BranchInfoDto> GetMissionByIdAsync(int taskId)
        //{
        //    var task = await _userRepository.GetAll().Where(t => t.Id == taskId).ToListAsync();
        //    var result = Mapper.Map<BranchInfoDto>(task);
        //    if (task != null)
        //    { return result; }
        //    else
        //    { throw new NotImplementedException(); }
        //}

        public PagedResultDto<BranchInfoDto> GetPagedBranchInfos(SearchBranchInfoInput input)
        {
            var task = _userRepository.GetAll()                   //根据条件过滤
                 .WhereIf(input.BranchID.HasValue, t => t.BranchID == input.BranchID)
                 .WhereIf(!input.BranchName.IsNullOrEmpty(), t => t.BranchName.Contains(input.BranchName))
                 .OrderByDescending(t => t.CreationTime).ToList();
          
            var taskcount = task.Count();  //数据量

            var tasklist = task.Skip((input.PageIndex-1)*input.PageSize).Take(input.PageSize).ToList();
            var result = new PagedResultDto<BranchInfoDto>(taskcount, Mapper.Map<List<BranchInfoDto>>(tasklist));
            return result;

        }
    }
}
