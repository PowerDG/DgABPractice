

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using RQCore.RQEnitity;

namespace RQCore.RQEnitity.Dtos
{
    public class InvoiceListDto : EntityDto<int>,IFullAudited 
    {

        
		/// <summary>
		/// Id
		/// </summary>
		public int?? Id { get; set; }



		/// <summary>
		/// InvoiceserialNo
		/// </summary>
		public uint InvoiceserialNo { get; set; }



		/// <summary>
		/// InvoiceNo
		/// </summary>
		public uint InvoiceNo { get; set; }



		/// <summary>
		/// BranchID
		/// </summary>
		public int BranchID { get; set; }



		/// <summary>
		/// BranchName
		/// </summary>
		public string BranchName { get; set; }



		/// <summary>
		/// CreatorUserId
		/// </summary>
		public long? CreatorUserId { get; set; }



		/// <summary>
		/// Specifications
		/// </summary>
		public string Specifications { get; set; }



		/// <summary>
		/// TaxAmount
		/// </summary>
		public string TaxAmount { get; set; }



		/// <summary>
		/// Total
		/// </summary>
		public decimal Total { get; set; }



		/// <summary>
		/// Price_Plus_Taxes
		/// </summary>
		public string Price_Plus_Taxes { get; set; }



		/// <summary>
		/// Arabic_Numbers
		/// </summary>
		public decimal Arabic_Numbers { get; set; }



		/// <summary>
		/// CompanyName
		/// </summary>
		public string CompanyName { get; set; }




    }
}