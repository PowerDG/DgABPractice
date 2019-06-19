using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class TaskFeedback
    {
        public uint Id { get; set; }
        public int TaskId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? MemberId { get; set; }
        public byte? Type { get; set; }
        public string Description { get; set; }
    }
}
