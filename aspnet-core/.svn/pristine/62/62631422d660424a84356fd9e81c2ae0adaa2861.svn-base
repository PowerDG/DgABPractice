using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Web;
using System.IO;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories; 
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using RQCore.RQEnitity;
using RQCore.RQAppService;
using RQCore.Controllers;
using System.Data;
using RQCore.RQDtos;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using AutoMapper;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace RQCore.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : RQCoreControllerBase
    {
        private readonly IRepository<Plu, int> _PluserRepository;
        public readonly IRepository<TruckInfo, long> _userRepository;
        public ImageController(IRepository<TruckInfo, long> userRepository, IRepository<Plu, int> PluserRepository)
        {
            _userRepository = userRepository;
            _PluserRepository = PluserRepository;
        }
        // GET: api/Image
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Image/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(long id)
        {
            var TruckID = id;
            var task = _userRepository.GetAll().FirstOrDefault(t => t.TruckID == TruckID);
            task.TruckPhoto = "1234566789";
            _userRepository.Update(task);
            return "value";
        }

        [HttpPost("api/QualificationOne/Upload")]
        public string Upload(/*IFormCollection Files, int EntId, int CrtUser*/)
        {

            {

                try
                {
                    //var form = Request.Form;//直接从表单里面获取文件名不需要参数
                    // string dd = Files["File"];
                    // var form = Files;//定义接收类型的参数

                    // Hashtable hash = new Hashtable();
                   
                    IFormFileCollection cols = Request.Form.Files;
                    var TruckID_s = Request.Form["TruckID"];
                    long TruckID = Convert.ToInt64(TruckID_s);
                    long size = cols.Sum(f => f.Length);
                    if (cols == null || cols.Count == 0)
                    {
                        return "没有上传文件";
                    }
                    foreach (IFormFile file in cols)
                    {
                        //定义图片数组后缀格式
                        string[] LimitPictureType = { ".JPG", ".JPEG", ".GIF", ".PNG", ".BMP" };
                        //获取图片后缀是否存在数组中
                        string currentPictureExtension = Path.GetExtension(file.FileName).ToUpper();
                        if (LimitPictureType.Contains(currentPictureExtension))
                        {

                            //为了查看图片就不在重新生成文件名称了
                            // var new_path = DateTime.Now.ToString("yyyyMMdd")+ file.FileName;
                            var upload_path = ("../Upload/" + TruckID + "");
                            var new_path = Path.Combine("../Upload/" + TruckID + "/", file.FileName);
                            if (!Directory.Exists(upload_path))
                            {//如果不存在文件夹则创建
                                Directory.CreateDirectory(upload_path);
                            }
                            else
                            {
                                Directory.Delete(upload_path);
                                Directory.CreateDirectory(upload_path);

                            }


                            // var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", new_path);  //Directory.GetCurrentDirectory()  当前目录

                            using (var stream = new FileStream(new_path, FileMode.Create))
                            {
                                var task = _userRepository.GetAll().FirstOrDefault(t => t.TruckID == TruckID);
                                task.TruckPhoto = new_path;
                                _userRepository.Update(task);

                                //再把文件保存的文件夹中
                                file.CopyTo(stream);

                            }
                        }
                        else
                        {
                            return "请上传指定格式的图片";
                        }
                    }

                    return "上传成功";

                }
                catch (Exception)
                {

                    return "上传失败";
                }


            }
        }

        [HttpPost("api/UploadImage")]
        public void UploadImage(long TruckID, string Imagestr)
        {
            var upload_path = ("../Upload/" + TruckID + "");
            var new_path = Path.Combine("../Upload/" + TruckID + "/Abp.png");
            if (!Directory.Exists(upload_path))
            {//如果不存在文件夹则创建
                Directory.CreateDirectory(upload_path);
            }
            string base64 = Imagestr;
            byte[] bytes = Convert.FromBase64String(base64);
            MemoryStream memStream = new MemoryStream(bytes);
            BinaryFormatter binFormatter = new BinaryFormatter();
            Image img = (Image)binFormatter.Deserialize(memStream);
            img.Save(new_path);

        }
        [HttpPost("api/SaveImage")]
        public void SaveImage(long TruckID, string image)
        {
            string path = "../Upload/" + TruckID + "/Abp.png";
            string filepath = Path.GetDirectoryName(path);
            // 如果不存在就创建file文件夹
            if (!Directory.Exists(filepath))
            {
                if (filepath != null) Directory.CreateDirectory(filepath);
            }
            var match = Regex.Match(image, "data:image/png;base64,([\\w\\W]*)$");
            if (match.Success)
            {
                image = match.Groups[1].Value;
            }
            var photoBytes = Convert.FromBase64String(image);
            System.IO.File.WriteAllBytes(path, photoBytes);
        }







    }
}
