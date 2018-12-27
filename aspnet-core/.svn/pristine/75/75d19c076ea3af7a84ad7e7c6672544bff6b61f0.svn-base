using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using RQCore.RQEnitity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RQCore.RQDtos

{
    [AutoMap(typeof(CustomerInfo))]
    public class CustomerInfoDto : EntityDto
    {
        public int CustomerID { get; set; }

        [MaxLength(255)]
        public string CompanyAbbreviation { get; set; }
        [MaxLength(255)]
        public string InvoiceType { get; set; }
        [MaxLength(255)]
        public string CompanyName { get; set; }
        [MaxLength(255)]
        public string Taxpayer_identification_number { get; set; }
        [MaxLength(255)]
        public string Registered_address { get; set; }
        [MaxLength(255)]
        public string Actual_Operating { get; set; }
        [MaxLength(255)]
        public string Opening_bank { get; set; }
        [MaxLength(255)]
        public string Bank_account_number { get; set; }
        [MaxLength(100)]
        public string Primary_contact { get; set; }
        [MaxLength(100)]
        public string Primary_Tel { get; set; }
        [MaxLength(100)]
        public string CustomerSex { get; set; }
        [MaxLength(100)]
        public string CustomerFax { get; set; }
        [MaxLength(100)]
        public string CustomerPostID { get; set; }
        [MaxLength(255)]
        public string CustomerEmail { get; set; }
        [MaxLength(100)]
        public string Secondary_contact { get; set; }
        [MaxLength(255)]
        public string Secondary_Tel { get; set; }
        [MaxLength(100)]
        public string CustomerRegData { get; set; }
        [MaxLength(255)]
        public string Monthly_statement_of_time { get; set; }
        public int BranchID { get; set; }
    }
    public class SearchCustomerInfoInput 
    {
        public int? CustomerID { get; set; }


        public int pageIndex { get; set; }

        public int pageSize { get; set; }

        public string CompanyAbbreviation { get; set; }
      
        public string InvoiceType { get; set; }
     
        public string CompanyName { get; set; }
     
        public string Taxpayer_identification_number { get; set; }
      
        public string Registered_address { get; set; }
      
        public string Actual_Operating { get; set; }
       
        public string Opening_bank { get; set; }
      
        public string Bank_account_number { get; set; }
    
        public string Primary_contact { get; set; }
   
        public string Primary_Tel { get; set; }
   
        public string CustomerSex { get; set; }
    
        public string CustomerFax { get; set; }
 
        public string CustomerPostID { get; set; }

        public string CustomerEmail { get; set; }
  
        public string Secondary_contact { get; set; }
       
        public string Secondary_Tel { get; set; }
     
        public string CustomerRegData { get; set; }
        
        public string Monthly_statement_of_time { get; set; }
        public int BranchID { get; set; }
    }

    public class SearchCustomerInfoDto
    {
        public int CustomerID { get; set; }
    
        public string CompanyAbbreviation { get; set; }
        public string CompanyName { get; set; }
        public string Primary_contact { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerRegData { get; set; }
        public string Actual_Operating { get; set; }
    }

}
