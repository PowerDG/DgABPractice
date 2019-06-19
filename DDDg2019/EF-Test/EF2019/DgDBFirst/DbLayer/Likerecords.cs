using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Likerecords
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int LikeMeMemberId { get; set; }
        public DateTime LastOperateTime { get; set; }
        public int OperateType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
