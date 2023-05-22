using fil_rouge_api.Models;

namespace fil_rouge_api.DTOs
{
    public class ProjectDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<UserDTO> Users { get; set; } = new List<UserDTO>();
        public List<TaskDTO> Tasks { get; set; } = new List<TaskDTO>();
        public bool isAdmin = false;
    }
}
