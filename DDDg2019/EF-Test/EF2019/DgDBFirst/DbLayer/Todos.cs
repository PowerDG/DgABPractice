using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Todos
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? CreateMemberId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public int? Executor { get; set; }
        public DateTime? ClosedTime { get; set; }
        public string Remark { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int? TaskId { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
