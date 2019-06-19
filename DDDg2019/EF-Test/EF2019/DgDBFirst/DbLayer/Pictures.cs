using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Pictures
    {
        public long Id { get; set; }
        public string Url { get; set; }
        public string PartialPictureUrl { get; set; }
        public string Description { get; set; }
        public int? MemberId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
