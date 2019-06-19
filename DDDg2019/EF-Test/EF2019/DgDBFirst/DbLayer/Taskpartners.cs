using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Taskpartners
    {
        public int Id { get; set; }
        public int? MemberId { get; set; }
        public int? TaskId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
