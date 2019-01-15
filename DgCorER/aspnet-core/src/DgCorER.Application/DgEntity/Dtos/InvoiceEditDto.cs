
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using RQCore.RQEnitity;

namespace  RQCore.RQEnitity.Dtos
{
    public class InvoiceEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
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
		/// Claime_Type
		/// </summary>
		public string Claime_Type { get; set; }



		/// <summary>
		/// Claim_Name
		/// </summary>
		public string Claim_Name { get; set; }



		/// <summary>
		/// CreatorUserId
		/// </summary>
		public long? CreatorUserId { get; set; }



		/// <summary>
		/// Goods
		/// </summary>
		public string Goods { get; set; }



		/// <summary>
		/// Specifications
		/// </summary>
		public string Specifications { get; set; }



		/// <summary>
		/// Unit
		/// </summary>
		public string Unit { get; set; }



		/// <summary>
		/// Qty
		/// </summary>
		public string Qty { get; set; }



		/// <summary>
		/// Unit_Price
		/// </summary>
		public string Unit_Price { get; set; }



		/// <summary>
		/// Amount
		/// </summary>
		public string Amount { get; set; }



		/// <summary>
		/// TaxRate
		/// </summary>
		public string TaxRate { get; set; }



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
		/// Payee
		/// </summary>
		public string Payee { get; set; }



		/// <summary>
		/// Review
		/// </summary>
		public string Review { get; set; }



		/// <summary>
		/// Drawer
		/// </summary>
		public string Drawer { get; set; }



		/// <summary>
		/// The_Seller
		/// </summary>
		public string The_Seller { get; set; }



		/// <summary>
		/// CompanyName
		/// </summary>
		public string CompanyName { get; set; }



		/// <summary>
		/// Taxpayer_identification_number
		/// </summary>
		public string Taxpayer_identification_number { get; set; }



		/// <summary>
		/// Registered_address
		/// </summary>
		public string Registered_address { get; set; }



		/// <summary>
		/// Primary_Tel
		/// </summary>
		public string Primary_Tel { get; set; }



		/// <summary>
		/// Opening_bank
		/// </summary>
		public string Opening_bank { get; set; }



		/// <summary>
		/// Bank_account_number
		/// </summary>
		public string Bank_account_number { get; set; }



		/// <summary>
		/// MyCompanyName
		/// </summary>
		public string MyCompanyName { get; set; }



		/// <summary>
		/// MyTaxpayer_identification_number
		/// </summary>
		public string MyTaxpayer_identification_number { get; set; }



		/// <summary>
		/// MyRegistered_address
		/// </summary>
		public string MyRegistered_address { get; set; }



		/// <summary>
		/// MyPrimary_Tel
		/// </summary>
		public string MyPrimary_Tel { get; set; }



		/// <summary>
		/// MyOpening_bank
		/// </summary>
		public string MyOpening_bank { get; set; }



		/// <summary>
		/// MyBank_account_number
		/// </summary>
		public string MyBank_account_number { get; set; }




    }
}