using System.ComponentModel.DataAnnotations;

namespace Geor.CountriesAPI.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}