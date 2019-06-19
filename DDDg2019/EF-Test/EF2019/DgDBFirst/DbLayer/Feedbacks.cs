using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Feedbacks
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? MemberId { get; set; }
        public int? ProviderId { get; set; }
        public DateTime CreatedTime { get; set; }
        public string ProviderName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
