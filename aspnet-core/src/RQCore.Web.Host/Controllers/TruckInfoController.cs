using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using RQCore.Controllers;
using RQCore.IRQAppService;
using RQCore.RQAppService;
using RQCore.RQDtos;


namespace RQCore.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckInfoController : ControllerBase
    {

        private readonly ITruckInfoAppService _truckInfoService;

        public TruckInfoController(ITruckInfoAppService userService)
        {
            _truckInfoService = userService;
        }


        //[HttpGet]
        //public string Index()
        //{
        //    return "Welcome";
        //}
        [HttpGet]
        public string CCTV()
        {
            return "WelcomeCCTV";
        }

        [HttpGet("id")]

        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        #region


        //[HttpPost("id")]
        //public string CreatemyMission(int id )s
        //{
        //    _truckInfoService.CreateMission(input);
        //}
        //[HttpPut]
        //public void UpdatemyMission(TruckInfoDto input, int id)
        //{
        //    _truckInfoService.UpdateMission(input, id);
        //}
        //[HttpDelete]
        //public void DeletemyMission(int taskId)
        //{
        //    _truckInfoService.DeleteMission(taskId);
        //}

        //[HttpGet]
        //public IList<TruckInfoDto> GetAllmyTruckInfos()
        //{
        //    var rqModel = _truckInfoService.GetAllMissions();
        //    return rqModel;

        //}


        //[HttpGet]
        //public TruckInfoDto GetmyTruckInfoById(int taskId)
        //{
        //    var rqModel = _truckInfoService.GetMissionById(taskId);
        //    return rqModel;

        //}
        #endregion


    }
}