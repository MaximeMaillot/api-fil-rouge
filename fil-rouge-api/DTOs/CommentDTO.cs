using System.ComponentModel.DataAnnotations;

namespace fil_rouge_api.DTOs
{
    public class CommentDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Message { get; set; }
        public UserDTO? User { get; set; }
    }
}
