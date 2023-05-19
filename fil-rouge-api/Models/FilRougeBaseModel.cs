namespace fil_rouge_api.Models
{
    public class FilRougeBaseModel
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
