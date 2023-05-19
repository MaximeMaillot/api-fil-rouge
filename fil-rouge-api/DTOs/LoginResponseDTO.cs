using System.ComponentModel.DataAnnotations;

namespace fil_rouge_api.DTOs
{
    public class LoginResponseDTO
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "FirstName must start with an uppercase letter !")]
        public string? FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z\- ]*", ErrorMessage = "LastName must be in uppercase !")]
        public string? LastName { get; set; }
        public string? FullName => FirstName + " " + LastName;
        [Required]
        public bool IsAdmin { get; set; } = false;
    }
}
