using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Gifts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Hyperlink { get; set; }
        public int MemberId { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedMemberId { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
