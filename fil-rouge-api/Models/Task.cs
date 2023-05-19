namespace fil_rouge_api.Models
{
    public class Task : FilRougeBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public int ProjectId { get; set; }
        public Project? Project { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
    public enum TaskStatus
    {
        Pending,
        Ongoing,
        Completed
    }
}
