using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DgCorER.DgEntity
{
     public class ABB : Entity<int>

    {  [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int? Id { get; set; }
        //public int UserID { get; set; }
        //发票批号
        public uint InvoiceserialNo { get; set; } 
        public uint InvoiceNo { get; set; } //发票编号



        public int BranchID { get; set; }

        public string BranchName { get; set; }
    }
}
