
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Authorization;
using Abp.Linq.Extensions;
using Abp.Domain.Repositories;
using Abp.Application.Services;
using Abp.Application.Services.Dto;


using RQCore.RQEnitity.Dtos;
using RQCore.RQEnitity;

namespace RQCore.RQEnitity
{
    /// <summary>
    /// Invoice应用层服务的接口方法
    ///</summary>
    public interface IInvoiceAppService : IApplicationService
    {
        /// <summary>
		/// 获取Invoice的分页列表信息
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<InvoiceListDto>> GetPaged(GetInvoicesInput input);


		/// <summary>
		/// 通过指定id获取InvoiceListDto信息
		/// </summary>
		Task<InvoiceListDto> GetById(EntityDto<int> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetInvoiceForEditOutput> GetForEdit(NullableIdDto<int> input);


        /// <summary>
        /// 添加或者修改Invoice的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateInvoiceInput input);


        /// <summary>
        /// 删除Invoice信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<int> input);


        /// <summary>
        /// 批量删除Invoice
        /// </summary>
        Task BatchDelete(List<int> input);


		/// <summary>
        /// 导出Invoice为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetToExcel();

    }
}
