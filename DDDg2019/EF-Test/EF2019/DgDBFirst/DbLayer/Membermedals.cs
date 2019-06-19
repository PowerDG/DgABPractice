using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Membermedals
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int MedalId { get; set; }
        public string Reason { get; set; }
        public DateTime GainDate { get; set; }
        public int? TaskId { get; set; }
        public int? GainType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
