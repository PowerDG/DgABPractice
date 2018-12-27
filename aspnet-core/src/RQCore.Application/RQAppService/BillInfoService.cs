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
    public class BillInfoService : RQCoreAppServiceBase, IBillInfoAppService
    {
       // Snowflake Snowflake = new Snowflake();
        private readonly IRepository<BillInfo, int> _userRepository;
        public BillInfoService(IRepository<BillInfo, int> userRepository)
        {
            _userRepository = userRepository;
        }
        public string CreateMission_user(BillInfoDto input)
        {
            try
            { 
                input.Id = Snowflake.Instance().GetId(); //分布式ID作为主键
                var result = Mapper.Map<BillInfo>(input);
                var task = _userRepository.GetAll().Where(t => t.BillNo == input.BillNo&&t.IsCandidate==false).ToList().Count; //检查是否有同货票号且正在生效中信息

               // if (input.State == 0)//货票初次录入信息
                
                    if (task <= 0)
                    {

                        _userRepository.Insert(result); return "新增成功";
                    }
                    else
                    { return "该货票单号已存在"; }
            

            }
            catch
            { return "新增失败"; }
        }


        public string DeleteMission_user(long taskId)
        {

            var task = _userRepository.GetAll()
                .Where(t => t.Id == taskId && t.IsCandidate == false)
                .ToList().Count; //检查是否有同货票号且正在生效中信息
            if (task > 0)
            {return "提交删除审核信息成功"; }
            else
            { return "该货票信息不存在，不能提出修改"; } //原基本信息不存在，不能修删除

        }

        public string UpdateMission_user(BillInfoDto input)
        {
            input.Id = Snowflake.Instance().GetId(); //分布式ID作为主键
            var result = Mapper.Map<BillInfo>(input) ;
            result.UpVersion();                      //版本号加一
            var task = _userRepository.GetAll()
                .Where(t => t.BillNo == input.BillNo && t.IsCandidate == false)
                .ToList().Count;                     //检查是否有同货票号且正在生效中信息
           // if (input.State == 1)//审核时提出修改信息,新增同货票号新信息，未审核通过时 IsCandidate 状态为1（未审核），同时生成对应审核表内容
            
                result.IsCandidate = true;
                if (task > 0)
                { _userRepository.Insert(result); return "提出修改成功"; }
                else
                { return "该货票基本信息已被删除，不能提出修改"; } //原基本信息不存在，不能修改
            
           
        }

        public int CreateMissionQ(BillInfoDto input)
        {
         

            input.Id = Snowflake.Instance().GetId();
            var result = Mapper.Map<BillInfo>(input);
            var task = _userRepository.Insert(result);
           // GetMissionById(input.BillNo)
            return input.BillNo;
            
        }



        public string CreateMission_admin(BillInfoDto input)
        {
            try
            {
                input.Id = Snowflake.Instance().GetId(); //分布式ID作为主键
                var result = Mapper.Map<BillInfo>(input);
                result.UpVersion();                      //版本号加一
                var task = _userRepository.GetAll().Where(t => t.BillNo == input.BillNo && t.IsCandidate == false).ToList().Count; //检查是否有同货票号且正在生效中信息

                // if (input.State == 0)//货票初次录入信息

                if (task <= 0)
                {

                    _userRepository.Insert(result); return "新增成功";
                }
                else
                { return "该货票单号已存在"; }


            }
            catch
            { return "新增失败"; }
        }
        public string DeleteMission_admin(long taskId)
        {
            try
            {
                var task = _userRepository.FirstOrDefault(t => t.Id == taskId && t.IsCandidate == false);
                var result = Mapper.Map<BillInfo>(task);
               
                if (task != null)
                { _userRepository.Delete(result); return "删除成功"; }
                else
                { return "资料不存在"; }

            }
            catch
            { return "删除失败"; }

        }
        public string UpdateMission_admin(BillInfoDto input)
        {
            try
            {
                var task = _userRepository.GetAll().Where(t => t.Id == input.Id && t.IsCandidate == false);
                var result = Mapper.Map<BillInfo>(input);
                result.UpVersion();                      //版本号加一
                if (task != null)
                {
                    _userRepository.Update(result);
                    return "修改成功";
                }
                else
                { return "修改失败"; }
            }
            catch
            { return "修改失败"; }
        }

        //public async Task<ListResultDto<BillInfoDto>> GetAllBillInfo(BillInfoDto input)
        //{
        //    var task = await _userRepository.GetAll()              
        //        .OrderByDescending(t => t.BillNo)
        //        .ToListAsync();
        //    if (task != null)
        //    { return Mapper.Map<ListResultDto<BillInfoDto>>(task); }
        //    else
        //    { throw new NotImplementedException(); }

        //}

        public IList<BillInfoDto> GetAllMissions()
        {
            var task = _userRepository.GetAll().Where(t=> t.IsCandidate == false)
                .OrderByDescending(t => t.Id)
                .ToList();
            return Mapper.Map<List<BillInfoDto>>(task);

        }

        public BillInfoDto GetMissionById(long taskId)
        {
            var task = _userRepository.GetAll()
                .FirstOrDefault(t => t.Id == taskId && t.IsCandidate == false);
               
               
            if (task != null)
            { return Mapper.Map<BillInfoDto>(task); }
            else
            { return null; }
        }

        //public PagedResultDto<BillInfoDto> GetPagedBillInfos(BillInfoDto input)
        //{
        //    var task=_userRepository.GetAll()
        //        .WhereIf(input.BillNo)
        //}

        //   public int GetKeyId(int taskid)
        //{

        //    var task = (from r in _userRepository.GetAll()
        //            where (r.BillNo == taskid)
        //            select r.BillNo).Distinct();
        //    if(task!=null)
        //    { 
        //    int result = Convert.ToInt32(task);
        //        return result;
        //    }
        //    else
        //    { return 0; }

        // }

        //public async Task<BillInfoDto> GetMissionByIdAsync(int taskId)
        //{
        //    var task = await _userRepository.GetAll()
        //        .Where(t => t.BillNo == taskId)
        //       .OrderByDescending(t => t.BillNo)
        //       .ToListAsync();
        //    if (task != null)
        //    { return Mapper.Map<BillInfoDto>(task); }
        //    else
        //    { throw new NotImplementedException(); }
        //}






    }
}
