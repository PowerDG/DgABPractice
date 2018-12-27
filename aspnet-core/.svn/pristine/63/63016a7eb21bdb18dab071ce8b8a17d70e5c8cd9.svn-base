using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RQCore.RQEnitity
{
    public class BillInfo : Entity, ICreationAudited, IDeletionAudited, IModificationAudited
    {
      
        [Key]
        public new long Id { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillNo { get; set; }

 




        public bool IsCandidate { get; set; }
        public int Version { get; set; }
        public string SendBranchID { get; set; }

        public bool BillCheck { get; set; }
        public int BillStateID { get; set; }
        public int? ExpressBillNo { get; set; }
        public string ExpressNo { get; set; }
        public string Secondary_contact { get; set; }
        public int Secondary_Tel { get; set; }
        public string MerchandiserName { get; set; }
        public string CompanyAbbreviation { get; set; }

        public string ShipperCompanyName { get; set; }
        public string ShipperAccount_No { get; set; }
        public string ShipperName { get; set; }
        public string ShipperTel { get; set; }
        public string ShipperPostCode { get; set; }
        public string ShipperCity { get; set; }
        public string ShipperProvince { get; set; }
        public string ShipperAddress { get; set; }

        public string ReceiversCompanyName { get; set; }
        public string ReceiversAccount_No { get; set; }
        public string ReceiversName { get; set; }
        public string ReceivingTel { get; set; }
        public string ReceivingPostCode { get; set; }
        public string ReceivingCity { get; set; }
        public string ReceivingProvince { get; set; }
        public string ReceivingAddress { get; set; }
        public string Totalnumberofpackages { get; set; }
        public string Totalweight { get; set; }
        public string Volume { get; set; }
        public string Measurementrules { get; set; }

        public string Volume_weight { get; set; }
        public string Chargeableweight { get; set; }

        public bool Has_return { get; set; }
        public string SERVICELEVEL { get; set; }
        public string TransportationMode { get; set; }
        public string Receivingdates  { get; set; }
        public string CONTENT { get; set; }

        public string Value { get; set; }
        public bool HasInsured { get; set; }
        public string PaymentType { get; set; }
        public string CHARGES { get; set; }
        public string TRANSPORTATION { get; set; }

        public string OTHER { get; set; }
        public bool Tax_point { get; set; }
        public string Distribution { get; set; }
        public string Delivery { get; set; }
        public string Transfer { get; set; }
        public string Packing { get; set; }
        public string Pallet { get; set; }

        public string Upstairs { get; set; }
        public bool Other_fees { get; set; }
        public string Remark { get; set; }
        public string TOTAL_CHARGES { get; set; }
        public string The_cost { get; set; }
        public string BillImgUrl { get; set; }


        public long? CreatorUserId { get;set; }
        public DateTime CreationTime { get;set; }
        public long? DeleterUserId { get;set; }
        public DateTime? DeletionTime { get;set; }
        public bool IsDeleted { get;set; }
        public long? LastModifierUserId { get;set; }
        public DateTime? LastModificationTime { get;set; }



        public void UpBillCheckToTrue()
        {
            BillCheck = true;           
        }
        public void UpVersion()
        {
            Version = Version + 1;
        }

    }

}
