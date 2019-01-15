

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using DgCorER;
using RQCore.RQEnitity;


namespace RQCore.RQEnitity.DomainService
{
    /// <summary>
    /// Invoice领域层的业务管理
    ///</summary>
    public class InvoiceManager :DgCorERDomainServiceBase, IInvoiceManager
    {
		
		private readonly IRepository<Invoice,int> _repository;

		/// <summary>
		/// Invoice的构造方法
		///</summary>
		public InvoiceManager(
			IRepository<Invoice, int> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitInvoice()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
