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
using System.Linq.Dynamic.Core;
using System.Data;
using System.IO;
using RQCore.IRQAppService;
//Snowflake.Instance().GetId()  使用生成id

namespace RQCore.RQAppService
{ 
    public class TruckInfoService : RQCoreAppServiceBase , ITruckInfoAppService
    {
        Snowflake Snowflake = new Snowflake();


        private readonly IRepository<TruckInfo, long> _TruckInfoRepository;
        private readonly IRepository<TruckModel, int> _TruckmodelRepository;
        private readonly IRepository<BranchInfo, int> _BranchInfoRepository;
        public TruckInfoService(
            IRepository<TruckInfo, long> TruckInfoRepository,
            IRepository<TruckModel, int> TruckmodelRepository, 
            IRepository<BranchInfo, int> BranchInfoRepository
         )
        {
            _TruckInfoRepository = TruckInfoRepository;
            _TruckmodelRepository = TruckmodelRepository;
            _BranchInfoRepository = BranchInfoRepository;
        }
         

        public string CreateMission(TruckInfoDto input)
        {
            try
            {
                input.TruckID = Snowflake.Instance().GetId();
                input.Id = input.TruckID;
                var task = Mapper.Map<TruckInfo>(input);

                var result = _TruckInfoRepository.Insert(task);
            }
            catch
            { return "新增失败"; }

            return "新增成功";
            //记录日志，Logger定义在ApplicationService中
            //Logger.Info("Creating a new task with description: " + input.TruckInsuranceNum); 
            //获取本地化文本(L是LocalizationHelper.GetString(...)的简便版本, 定义在 ApplicationService类型)
            // var text = L("SampleLocalizableTextKey"); 
            //TODO: Add new task to database...
        }

        public long CreateTruckId()
        {
            var task = Snowflake.Instance().GetId();
            return task;

        }
        public long CreateMissionQ(TruckInfoDto input)
        {
            try
            {
                Logger.Info("Creating a task for input: " + input);
               // input.TruckID = Snowflake.Instance().GetId();
                input.Id = input.TruckID;
                var task = Mapper.Map<TruckInfo>(input);
                long result = _TruckInfoRepository.InsertAndGetId(task);
                return result;
            }
            catch
            { return 404; }

                    
            //throw new NotImplementedException();
        }
        public string UpdateMission(TruckInfoDto input)
        { try
            {
                Logger.Info("Updating a task for input: " + input);

                var updateTask = Mapper.Map<TruckInfo>(input);
                _TruckInfoRepository.InsertOrUpdate(updateTask);
            }
            catch
            { return "修改失败"; }
            return "修改成功";
           
        }

        public string DeleteMission(long taskId)
        {
            try
            {
                var n = taskId;
                var task = _TruckInfoRepository.FirstOrDefault(r => r.TruckID == taskId);
                if (task != null)
                    _TruckInfoRepository.Delete(task);
            }
            catch
            { return "删除失败"; }
            return "删除成功";
            
            //throw new NotImplementedException();
        }
        //public async Task<ListResultDto<TruckInfoDto>> GetAllTruckInfo(TruckInfoDto input)
        //{
        //    var truckInfos = await _userRepository.GetAll()
        //        .WhereIf(input.TMID.HasValue, t => t.TMID == input.TMID)
        //        .OrderByDescending(t => t.CreationTime)
        //        .ToListAsync();

        //    return new ListResultDto<TruckInfoDto>(
        //        AutoMapper.Mapper.Map<List<TruckInfoDto>>(truckInfos));
        //}




        public PagedResultDto<TruckInfoDto> GetPagedTasks(SearchTruckInfoInput input)
        {
            //初步过滤
            //var query = _TruckInfoRepository.GetAll()
            //    .Where(t => t.BranchID == input.BranchID).OrderByDescending(t => t.CreationTime)
            //    // .WhereIf(input.TMID.HasValue, t => t.TMID == input.TMID.Value)
            //    .WhereIf(!input.TruckNum.IsNullOrEmpty(), t => t.TruckNum.Contains(input.TruckNum))
            //   .Join(_TruckmodelRepository.GetAll(), t => t.TMID, r => r.TMID, (r, t) => new 
            //   {
            //       TruckID = r.TruckID,
            //       TruckNum = r.TruckNum,
            //       TMName = t.TMName,
            //       TruckColor = r.TruckColor,
            //       TruckBuyData = r.TruckBuyData,
            //       BranchID = r.BranchID,
            //       TruckIsVacancy = r.TruckIsVacancy
            //   })
            //   .Join(_BranchInfoRepository.GetAll(), r => r.BranchID, t => t.BranchID, (r, t) => new SearchTruckInfoDto
            //   {
            //       TruckID = r.TruckID,
            //       TruckNum = r.TruckNum,
            //       TMName = r.TMName,
            //       TruckColor = r.TruckColor,
            //       TruckBuyData = r.TruckBuyData,
            //       BranchName = t.BranchName,
            //       TruckIsVacancy = r.TruckIsVacancy
            //   }).ToList();

            var query = (from t in _TruckInfoRepository.GetAll()
                                  .WhereIf(input.TMID.HasValue, t => t.TMID == input.TMID.Value)
                                  .WhereIf(!input.TruckNum.IsNullOrEmpty(), t => t.TruckNum.Contains(input.TruckNum))
                         join r in _TruckmodelRepository.GetAll() on t.TMID equals r.TMID
                         join n in _BranchInfoRepository.GetAll() on t.BranchID equals n.BranchID
                         
                         select new SearchTruckInfoDto
                         {
                             TruckID = t.TruckID,
                             TruckNum = t.TruckNum,
                             TMName = r.TMName,
                             TruckColor = t.TruckColor,
                             TruckBuyData = t.TruckBuyData,
                             BranchName = n.BranchName,
                             TruckIsVacancy = t.TruckIsVacancy
                         }).ToList();


            //排序
            //query = !string.IsNullOrEmpty(input.Sorting) ? query.OrderBy(input.Sorting) : query.OrderByDescending(t => t.CreationTime);
            // query.OrderByDescending(t => t.CreationTime);


            //获取总数
            var tasksCount = query.Count();
            //默认的分页方式 source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            var taskList =  query.Skip((input.pageIndex-1)*input.pageSize).Take(input.pageSize).ToList();

            //ABP提供了扩展方法PageBy分页方式
            //var taskList = query.PageBy(input).ToList();

            return new PagedResultDto<TruckInfoDto>(tasksCount, taskList.MapTo<List<TruckInfoDto>>());
        }
        public IList<TruckInfoDto> GetAllMissions()
        {
            var tasks = _TruckInfoRepository.GetAll().OrderByDescending(t => t.CreationTime).ToList();
            return Mapper.Map<IList<TruckInfoDto>>(tasks);//因为已经定义了映射转换规则
            //throw new NotImplementedException();
        }
         

        public TruckInfoDto GetMissionById(long taskId)
        {
            var task = _TruckInfoRepository.GetAll().FirstOrDefault(t => t.TruckID == taskId);
           // var result = Mapper.Map<TruckInfoDto>(task);
            return task.MapTo<TruckInfoDto>();
            //throw new NotImplementedException();
        }

        //public async Task<TruckInfoDto> GetMissionByIdAsync(int taskId)
        //{       //Called specific GetAllWithPeople method of task repository.
        //    var task = await _userRepository.GetAsync(taskId);

        //    //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
        //    return task.MapTo<TruckInfoDto>();
        //    //throw new NotImplementedException();
        //}
     

        /**
        * 设置某个字段的值
        * @param key 字段名
         * @param value 字段值
        */
       
        public  List<SelectDto> GetlistOps()
        {
            // var task = _userRepository.GetAll()
            //.Join(_TruckmodelRepository.GetAll(),r=>r.TMID,t=>t.TMID,(r,t)=> new  { id = r.TMID, name = t.TMName }).ToDictionary(m=>m.id,m=>m.name);
            //  var task = _TruckmodelRepository.GetAll().ToDictionary(m => m.TMName,m => m.TMID);
            var task = (from r in _TruckmodelRepository.GetAll()
                        select new SelectDto  { Name=r.TMName, Id=r.TMID }).ToList();


            return task;

        }
        /// <summary>
        /// 列表展示信息
        /// </summary>
        /// <returns></returns>
       public IList<SearchTruckInfoDto> GetAllSearchDto()
        {
            var task = (from t in _TruckInfoRepository.GetAll()
                       join r in _TruckmodelRepository.GetAll() on t.TMID equals r.TMID
                       join n in _BranchInfoRepository.GetAll() on t.BranchID equals n.BranchID
                       
                       select new SearchTruckInfoDto
                       {
                           TruckID=t.TruckID,
                           TruckNum=t.TruckNum,
                           TMName=r.TMName,
                           TruckColor=t.TruckColor,
                           TruckBuyData=t.TruckBuyData,
                           BranchName = n.BranchName,
                           TruckIsVacancy=t.TruckIsVacancy
                       }).ToList();
            return task;
        }






    }
}
