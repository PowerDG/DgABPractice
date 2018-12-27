using System.ComponentModel.DataAnnotations;

namespace RQCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}