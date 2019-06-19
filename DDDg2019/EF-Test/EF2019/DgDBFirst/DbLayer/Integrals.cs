using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Integrals
    {
        public int Id { get; set; }
        public int? MemberId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? Integral { get; set; }
        public string Description { get; set; }
        public int? SourceId { get; set; }
        public string SourceType { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
