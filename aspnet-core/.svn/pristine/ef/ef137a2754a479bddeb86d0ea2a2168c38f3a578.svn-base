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
    public class CargoVectorToCargoInfoService : RQCoreAppServiceBase, ICargoVectorToCargoInfoAppService
    {
        private readonly IRepository<CargoInfo, int> _CargoInfoRepository;
        private readonly IRepository<CargoVector, int> _CargoVectorRepository;
        public CargoVectorToCargoInfoService(IRepository<CargoInfo, int> CargoInfoRepository, IRepository<CargoVector, int> CargoVectorRepository)
        {
            _CargoInfoRepository = CargoInfoRepository;
            _CargoVectorRepository = CargoVectorRepository;
        }
        public List<CargoInfoDto> GetAllCargoVectorToCargoInfo(int taskid)
        {
            var task = (from r in _CargoInfoRepository.GetAll()
                        join t in _CargoVectorRepository.GetAll() on r.CargoID equals t.CargoID
                        select r).Distinct().ToList();
            
                return new List<CargoInfoDto>(Mapper.Map<List<CargoInfoDto>>(task));
        }
        
    }
}
