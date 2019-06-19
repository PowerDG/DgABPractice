using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Annualintegrals
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int Years { get; set; }
        public int AnnualIntegral { get; set; }
        public DateTime UpdatedTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
