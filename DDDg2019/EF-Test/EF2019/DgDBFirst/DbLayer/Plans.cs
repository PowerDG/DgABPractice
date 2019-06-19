using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Plans
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CreatedMemberId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public DateTime? ClosedTime { get; set; }
        public string Remark { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
