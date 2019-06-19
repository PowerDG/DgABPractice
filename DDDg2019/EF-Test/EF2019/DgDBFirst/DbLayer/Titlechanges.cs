using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Titlechanges
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string OldTitle { get; set; }
        public string NewTitle { get; set; }
        public DateTime ChangedTime { get; set; }
        public int CreatedMemberId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
