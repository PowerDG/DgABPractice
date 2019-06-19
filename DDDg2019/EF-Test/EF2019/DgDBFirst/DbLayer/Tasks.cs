using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Score { get; set; }
        public string Status { get; set; }
        public int? MemberId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? DeadLineTime { get; set; }
        public string Description { get; set; }
        public int? CreatedMemberId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? ScoreApportioned { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int? PlanId { get; set; }
        public int Priority { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
