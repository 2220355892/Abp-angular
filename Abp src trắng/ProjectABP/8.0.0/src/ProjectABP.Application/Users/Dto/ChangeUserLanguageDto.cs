using System.ComponentModel.DataAnnotations;

namespace ProjectABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}