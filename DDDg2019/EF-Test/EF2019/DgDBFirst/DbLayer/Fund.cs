using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Fund
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime? InsertTime { get; set; }
        public string Description { get; set; }
        public decimal? OperatMoney { get; set; }
        public decimal? RemainMoney { get; set; }
        public int? MemberId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
