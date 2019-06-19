using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Introductions
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? Type { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
