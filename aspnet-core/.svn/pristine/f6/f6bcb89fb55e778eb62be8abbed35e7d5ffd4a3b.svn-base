using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;
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

namespace RQCore.RQLibrary
{
    public class ImageSendService
    {
        private readonly IRepository<TruckInfo, long> _userRepository;
        public string SendImage(IFormFileCollection files, int task)
        {
            {

                try
                {

                    IFormFileCollection cols = files;
                    var TruckID = task;
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
                            var new_path = Path.Combine("~/Upload/", file.FileName);
                            // var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", new_path);  //Directory.GetCurrentDirectory()  当前目录

                            using (var stream = new FileStream(new_path, FileMode.Create))
                            {
                                var result = _userRepository.GetAll().Where(t => t.TMID == TruckID).First(p => p.TruckPhoto == new_path);
                                _userRepository.Update(result);
                                // _userRepository.GetAll().

                                //图片路径保存到数据库里面去
                                //bool flage = QcnApplyDetm.FinancialCreditQcnApplyDetmAdd(EntId, CrtUser, new_path);
                                //if (flage == true)
                                //{
                                //再把文件保存的文件夹中
                                file.CopyTo(stream);
                                //hash.Add("file", "/" + new_path);
                                // }
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
    }
}
