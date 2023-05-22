using fil_rouge_api.Models;

namespace fil_rouge_api.DTOs
{
    public class TaskDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Models.TaskStatus Status { get; set; }
        public List<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
    }
}
