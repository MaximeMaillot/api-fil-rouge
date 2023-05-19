namespace fil_rouge_api.Models
{
    public class User : FilRougeBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
