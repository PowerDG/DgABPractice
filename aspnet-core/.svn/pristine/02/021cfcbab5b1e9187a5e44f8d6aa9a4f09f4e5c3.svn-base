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

namespace RQCore.RQAppService
{
    public class DepartmentInfoService : IRQAppService, IDepartmentInfoAppService
    {
         public readonly IRepository<DepartmentInfo, int> _userRepository;
        public DepartmentInfoService(IRepository<DepartmentInfo, int> userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateMission(DepartmentInfoDto input)
        {
            var task = Mapper.Map<DepartmentInfo>(input);
            if (task != null)
            {
                _userRepository.InsertOrUpdate(task);
            }
        }

            public int CreateMissionQ(DepartmentInfoDto input)
        {
            var task = Mapper.Map<DepartmentInfo>(input);
            if (task != null)
            {
                int result = _userRepository.InsertAndGetId(task);
                return result;
            }
            else
            { return 0; }
        }

        public void DeleteMission(int taskId)
        {
            var task = _userRepository.FirstOrDefault(t => t.DepartmentID == taskId);
            if (task != null)
            { _userRepository.Delete(task); }
        }

        public async Task<ListResultDto<DepartmentInfoDto>> GetAllDepartmentInfo(DepartmentInfoDto input)
        {
            var task = await _userRepository.GetAll().OrderByDescending(t => t.DepartmentID).ToListAsync();
            return new ListResultDto<DepartmentInfoDto>(
               AutoMapper.Mapper.Map<List<DepartmentInfoDto>>(task));
        }

        public IList<DepartmentInfoDto> GetAllMissions()
        {
            var task = _userRepository.GetAll().OrderByDescending(t => t.DepartmentID);
            return Mapper.Map<List<DepartmentInfoDto>>(task);
        }

        public DepartmentInfoDto GetMissionById(int taskId)
        {
            var task = _userRepository.GetAll().Where(t => t.DepartmentID == taskId);
            var result = Mapper.Map<DepartmentInfoDto>(task);
            if (task != null)
            { return result; }
            else
            { throw new NotImplementedException(); }
        }

        public async Task<DepartmentInfoDto> GetMissionByIdAsync(int taskId)
        {
            var task = await _userRepository.GetAll().Where(t => t.DepartmentID == taskId).ToListAsync();
            var result = Mapper.Map<DepartmentInfoDto>(task);
            if (task != null)
            { return result; }
            else
            { throw new NotImplementedException(); }
        }

        public void UpdateMission(DepartmentInfoDto input, int id)
        {
            var task = _userRepository.GetAll().Where(t => t.DepartmentID == input.DepartmentID);
            var result = Mapper.Map<DepartmentInfo>(task);
            if (task != null)
            { _userRepository.Update(result); }
        }
    }
}
