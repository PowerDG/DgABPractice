using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Tasktrackings
    {
        public int Id { get; set; }
        public int? FollowerId { get; set; }
        public int? TaskId { get; set; }
        public DateTime? FollowTime { get; set; }
        public string FollowDescription { get; set; }
        public string FollowType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
