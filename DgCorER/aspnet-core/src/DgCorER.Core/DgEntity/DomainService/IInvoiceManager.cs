

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using RQCore.RQEnitity;


namespace RQCore.RQEnitity.DomainService
{
    public interface IInvoiceManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitInvoice();



		 
      
         

    }
}
