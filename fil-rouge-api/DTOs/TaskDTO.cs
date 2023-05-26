using fil_rouge_api.Models;
using System.ComponentModel.DataAnnotations;

namespace fil_rouge_api.DTOs
{
    public class TaskDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public Models.TaskStatus Status { get; set; }
        public List<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
    }
}
