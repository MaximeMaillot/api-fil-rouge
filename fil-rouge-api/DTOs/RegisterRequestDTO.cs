using System.ComponentModel.DataAnnotations;

namespace fil_rouge_api.DTOs
{
    public class RegisterRequestDTO
    {
        [Required]
        //[RegularExpression(@"[\w\-_]", ErrorMessage = "Invalid name")]
        public string? Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-_]+)@([\w\-_]+)(\.)?([\w\-_]+)?(\.){1}([a-zA-Z]{2,11})$", ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
