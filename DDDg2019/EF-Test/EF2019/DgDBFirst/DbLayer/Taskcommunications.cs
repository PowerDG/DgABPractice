using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Taskcommunications
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Content { get; set; }
        public int? MemberId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string Type { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
