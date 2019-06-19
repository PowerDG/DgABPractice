using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Taskreviews
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string PerfectFunction { get; set; }
        public string TroubleFunction { get; set; }
        public string StrongAspect { get; set; }
        public string WeaknessAspect { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
