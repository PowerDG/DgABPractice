using System;
using System.Collections.Generic;

namespace DgDBFirst
{
    public partial class Members
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string PasswordKey { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string PhotoHd { get; set; }
        public string ArtPhoto { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public string Qq { get; set; }
        public string WeChat { get; set; }
        public DateTime EntryTime { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Remarks { get; set; }
        public bool? IsAdmin { get; set; }
        public int TotalIntegral { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public DateTime? LeaveTime { get; set; }
        public bool? IsLeave { get; set; }
        public string AliasName { get; set; }
        public string Motto { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
