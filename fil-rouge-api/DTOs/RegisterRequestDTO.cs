using System.ComponentModel.DataAnnotations;

namespace fil_rouge_api.DTOs
{
    public class RegisterRequestDTO
    {
        [Required]
        [RegularExpression(@"[a-zA-Z0-9-_]", ErrorMessage = "Invalid name")]
        public string? Name { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$", ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
