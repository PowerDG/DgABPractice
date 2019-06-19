using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Memberlabels
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Label { get; set; }
        public int Count { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
