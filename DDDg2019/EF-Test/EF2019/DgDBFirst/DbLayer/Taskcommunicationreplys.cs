using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Taskcommunicationreplys
    {
        public int Id { get; set; }
        public int CommunicationId { get; set; }
        public int MemberId { get; set; }
        public string Content { get; set; }
        public int? ReplyMemberId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
