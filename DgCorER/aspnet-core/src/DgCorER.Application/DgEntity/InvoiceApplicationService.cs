
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
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using RQCore.RQEnitity;
using RQCore.RQEnitity.Dtos;
using RQCore.RQEnitity.DomainService;



namespace RQCore.RQEnitity
{
    /// <summary>
    /// Invoice应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class InvoiceAppService : DgCorERAppServiceBase, IInvoiceAppService
    {
        private readonly IRepository<Invoice, int> _entityRepository;

        private readonly IInvoiceManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public InvoiceAppService(
        IRepository<Invoice, int> entityRepository
        ,IInvoiceManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取Invoice的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		 
        public async Task<PagedResultDto<InvoiceListDto>> GetPaged(GetInvoicesInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<InvoiceListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<InvoiceListDto>>();

			return new PagedResultDto<InvoiceListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取InvoiceListDto信息
		/// </summary>
		 
		public async Task<InvoiceListDto> GetById(EntityDto<int> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<InvoiceListDto>();
		}

		/// <summary>
		/// 获取编辑 Invoice
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task<GetInvoiceForEditOutput> GetForEdit(NullableIdDto<int> input)
		{
			var output = new GetInvoiceForEditOutput();
InvoiceEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<InvoiceEditDto>();

				//invoiceEditDto = ObjectMapper.Map<List<invoiceEditDto>>(entity);
			}
			else
			{
				editDto = new InvoiceEditDto();
			}

			output.Invoice = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改Invoice的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task CreateOrUpdate(CreateOrUpdateInvoiceInput input)
		{

			if (input.Invoice.Id.HasValue)
			{
				await Update(input.Invoice);
			}
			else
			{
				await Create(input.Invoice);
			}
		}


		/// <summary>
		/// 新增Invoice
		/// </summary>
		
		protected virtual async Task<InvoiceEditDto> Create(InvoiceEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <Invoice>(input);
            var entity=input.MapTo<Invoice>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<InvoiceEditDto>();
		}

		/// <summary>
		/// 编辑Invoice
		/// </summary>
		
		protected virtual async Task Update(InvoiceEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除Invoice信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task Delete(EntityDto<int> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除Invoice的方法
		/// </summary>
		
		public async Task BatchDelete(List<int> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出Invoice为excel表,等待开发。
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetToExcel()
		//{
		//	var users = await UserManager.Users.ToListAsync();
		//	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
		//	await FillRoleNames(userListDtos);
		//	return _userListExcelExporter.ExportToFile(userListDtos);
		//}

    }
}


