using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Appraisals
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public decimal? ValueScore { get; set; }
        public decimal? PerformanceScore { get; set; }
        public string Level { get; set; }
        public int MemberId { get; set; }
        public int CreatedMemberId { get; set; }
        public DateTime CreatedTime { get; set; }
        public decimal? TotalScore { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
