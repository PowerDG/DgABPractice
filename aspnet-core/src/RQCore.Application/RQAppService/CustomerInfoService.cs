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
    public class CustomerInfoService : RQCoreAppServiceBase, ICustomerInfoAppService
    {
        private readonly IRepository<CustomerInfo, int> _CustomerinfoRepository;
        public CustomerInfoService(IRepository<CustomerInfo, int> CustomerinfoRepository)
        {
            _CustomerinfoRepository = CustomerinfoRepository;
        }
        public void CreateMission(CustomerInfoDto input)
        {
          
            var task = Mapper.Map<CustomerInfo>(input);
            task.Id = task.CustomerID;
            _CustomerinfoRepository.Insert(task);
        }

        public int CreateMissionQ(CustomerInfoDto input)
        {
            var task = Mapper.Map<CustomerInfo>(input);
            task.Id = task.CustomerID;
            return _CustomerinfoRepository.InsertAndGetId(task);
        }

        public void DeleteMission(int taskId)
        {
            var task = _CustomerinfoRepository.GetAll().FirstOrDefault(t=>t.CustomerID == taskId);
            _CustomerinfoRepository.Delete(task);
        }

        public IList<CustomerInfoDto> GetAllMissions()
        {
            var task = _CustomerinfoRepository.GetAll().OrderByDescending(t=>t.CustomerID).ToList();
            var result = new List<CustomerInfoDto>(Mapper.Map<List<CustomerInfoDto>>(task));
            return result;
        }

        public List<SelectDto> GetCustomerIDList()
        {
            var task = (from r in _CustomerinfoRepository.GetAll()
                       select new SelectDto { Id = r.CustomerID, Name = r.CompanyName }).ToList();
            return task;
        }

        public CustomerInfoDto GetMissionById(int taskId)
        {
            var task = _CustomerinfoRepository.GetAll().FirstOrDefault(t=>t.CustomerID==taskId);
            var result = Mapper.Map<CustomerInfoDto>(task);
            return result;
        }

        public PagedResultDto<SearchCustomerInfoDto> GetPagedCustomerInfos(SearchCustomerInfoInput input)
        {
            //条件过滤
            var query = _CustomerinfoRepository.GetAll()
                .WhereIf(!input.InvoiceType.IsNullOrEmpty(), t => t.InvoiceType == input.InvoiceType)
                .WhereIf(!input.CompanyName.IsNullOrEmpty(), t => t.CompanyName == input.CompanyName)
                .WhereIf(!input.CompanyAbbreviation.IsNullOrEmpty(), t => t.CompanyName.Contains(input.CompanyAbbreviation))
                .OrderByDescending(t=>t.CustomerID);
            //获取数据总数
            var tasksCount = query.Count();
            //默认的分页方式 source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            var taskList = query.Skip((input.pageIndex - 1) * input.pageSize).Take(input.pageSize).ToList();

            return new PagedResultDto<SearchCustomerInfoDto>(tasksCount, taskList.MapTo<List<SearchCustomerInfoDto>>());
        }

        public void UpdateMission(CustomerInfoDto input)
        {
            var task = Mapper.Map<CustomerInfo>(input);
            _CustomerinfoRepository.Update(task);
        }
        public IList<SearchCustomerInfoDto> GetAllSearchDto()
        {
            var task = _CustomerinfoRepository.GetAll().ToList();
            var result = task.MapTo<List<SearchCustomerInfoDto>>();
            return result;
        }
    }
}
