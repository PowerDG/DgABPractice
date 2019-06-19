using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Photo { get; set; }
        public string PhotoHd { get; set; }
        public int? MemberId { get; set; }
        public int AverageScore { get; set; }
        public string Resource { get; set; }
        public byte State { get; set; }
        public string LastComment { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
