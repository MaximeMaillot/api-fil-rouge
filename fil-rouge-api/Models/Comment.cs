namespace fil_rouge_api.Models
{
    public class Comment : FilRougeBaseModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int TaskId { get; set; }
        public Task? Task { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
