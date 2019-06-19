using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Keyresults
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? LastUpdateMemberId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public int? ClosedMemberId { get; set; }
        public DateTime? ClosedTime { get; set; }
        public string Remark { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int? TaskId { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
