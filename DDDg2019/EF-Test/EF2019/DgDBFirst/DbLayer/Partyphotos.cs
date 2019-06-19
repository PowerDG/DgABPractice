using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Partyphotos
    {
        public int Id { get; set; }
        public int? PartyId { get; set; }
        public string ImgUrl { get; set; }
        public string ImgUrlPart { get; set; }
        public string ImgDescription { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
