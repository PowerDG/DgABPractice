using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Partiesreviews
    {
        public int Id { get; set; }
        public int? PartyId { get; set; }
        public int? MemberId { get; set; }
        public string Review { get; set; }
        public DateTime? ReviewTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
