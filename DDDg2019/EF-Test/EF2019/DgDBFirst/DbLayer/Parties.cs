using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Parties
    {
        public int Id { get; set; }
        public int? MemberId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string PartyName { get; set; }
        public string PartyPlace { get; set; }
        public decimal? Money { get; set; }
        public int? MoneyResource { get; set; }
        public int? Number { get; set; }
        public int? LikeLevel { get; set; }
        public int? ReviewTimes { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
