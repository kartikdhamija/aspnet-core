using System.ComponentModel.DataAnnotations;

namespace Assignment.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}