using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RQCore.RQEnitity
{
    public class CustomerInfo : Entity<int>, ICreationAudited, IDeletionAudited, IModificationAudited
    {   [Key]
        public int CustomerID { get; set; }

        [MaxLength(255)]
        public string CompanyAbbreviation { get; set; }
        [MaxLength(255)]
        public string InvoiceType { get; set; }
        [MaxLength(255)]
        public string CompanyName { get; set;}
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

        public long? CreatorUserId {  get; set; }
        public DateTime CreationTime {  get; set; }
        public long? DeleterUserId {  get; set; }
        public DateTime? DeletionTime {  get; set; }
        public bool IsDeleted {  get; set; }
        public long? LastModifierUserId {  get; set; }
        public DateTime? LastModificationTime {  get; set; }
    }
}
