using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class ContributionStandard
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
