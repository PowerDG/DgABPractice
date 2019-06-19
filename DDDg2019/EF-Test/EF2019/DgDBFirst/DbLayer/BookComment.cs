using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class BookComment
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public string Comment { get; set; }
        public int Score { get; set; }
    }
}
