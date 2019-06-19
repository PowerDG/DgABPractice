using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Medals
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public bool? IsDiscard { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? DiscardTime { get; set; }
        public int Grade { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
