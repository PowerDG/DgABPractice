using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using RQCore.Controllers;
using RQCore.RQDtos;
using RQCore.RQEnitity;

namespace RQCore.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExeclController : RQCoreControllerBase
    {
        private readonly IRepository<Plu, int> _PluserRepository;
        public readonly IRepository<TruckInfo, long> _userRepository;
        public ExeclController(IRepository<TruckInfo, long> userRepository, IRepository<Plu, int> PluserRepository)
        {
            _userRepository = userRepository;
            _PluserRepository = PluserRepository;
        }

        [HttpPost("api/Insertexecl")]

        public DataTable Insertexecl()
        {
            DataTable datatable = new DataTable();
            IFormFileCollection Files = Request.Form.Files;
            if (Files.Count == 1)
            {
                
                foreach (IFormFile File in Files)
                {
                    string name = "查价" + DateTime.Now + ".xlsx";
                    string stream_path = "../EXECL/";
                    string path = "../EXECL/" + name;
                    if(!Directory.Exists(stream_path))
                    { Directory.CreateDirectory(stream_path); }

                    using (Stream stream = new FileStream(path, FileMode.Create))
                    {
                        File.CopyTo(stream);
                    }

                    // DataTable dt = ToGetDataTable(path);  //取得datatable
                    DataTable dt = new DataTable();

                    DataColumn dc1 = new DataColumn("Id", Type.GetType("System.Int32"));
                    DataColumn dc2 = new DataColumn("Province", Type.GetType("System.String"));
                    DataColumn dc3 = new DataColumn("Destination_city", Type.GetType("System.String"));
                    DataColumn dc4 = new DataColumn("Aging", Type.GetType("System.String"));
                    DataColumn dc5 = new DataColumn("Price_Kg", Type.GetType("System.Decimal"));
                    DataColumn dc6 = new DataColumn("Price_Cu", Type.GetType("System.Decimal"));


                    dt.Columns.Add(dc1);
                    dt.Columns.Add(dc2);
                    dt.Columns.Add(dc3);
                    dt.Columns.Add(dc4);
                    dt.Columns.Add(dc5);
                    dt.Columns.Add(dc6);
                    //以上代码完成了DataTable的构架，但是里面是没有任何数据的  
                    FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);  //创建读取数据

                    IWorkbook workBook = new XSSFWorkbook(file);
                    ISheet sheet = null;
                    sheet = workBook.GetSheetAt(0);  //默认取第一页工作簿
                    IRow firstRow = sheet.GetRow(0); //取第一行
                    int cellCount = firstRow.LastCellNum;//第一行最后一个cell的编号 即总的列数
                    int rowCount = sheet.LastRowNum;  //取最后一行，即行的总数
                    for (int i = 1; i <= rowCount; i++)
                    {
                        IRow row = sheet.GetRow(i);  //当前行
                        DataRow dr = dt.NewRow();
                        dr[0] = null;
                        dr[1] = row.GetCell(1).ToString();
                        dr[2] = row.GetCell(2).ToString();
                        dr[3] = row.GetCell(3).ToString();
                        dr[4] = Convert.ToDecimal(row.GetCell(4));
                        dr[5] = Convert.ToDecimal(row.GetCell(5));

                        dt.Rows.Add(dr);
                    }
                    datatable = dt;
                    //  result = ToinsertDatabase(dt);  //insert 数据库

                    List<string> errors = new List<string>();
                    List<string> fails = new List<string>();
                    var a = dt.Rows;
                    List<PluDto> list = new List<PluDto>();

                    for (int i = 0; i < a.Count; i++)
                    {
                        list.Add(new PluDto()
                        {
                            Id = null,
                            Province = a[i][1].ToString(),
                            Destination_city = a[i][2].ToString(),
                            Aging = a[i][3].ToString(),
                            Price_Kg = Convert.ToDecimal(a[i][4].ToString()),
                            Price_Cu = Convert.ToDecimal(a[i][4].ToString()),
                        });

                    }
                    var lists = Mapper.Map<List<Plu>>(list);
                    foreach (Plu task in lists)
                    {
                        _PluserRepository.Insert(task);

                    }


                }



            }
            return datatable;

        }

    }
}