using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Memberskills
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int MemberId { get; set; }
        public DateTime GainDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
