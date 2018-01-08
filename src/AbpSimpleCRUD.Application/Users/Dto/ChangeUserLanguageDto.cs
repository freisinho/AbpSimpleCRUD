using System.ComponentModel.DataAnnotations;

namespace AbpSimpleCRUD.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}