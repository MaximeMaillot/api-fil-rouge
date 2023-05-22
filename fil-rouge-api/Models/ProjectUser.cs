﻿namespace fil_rouge_api.Models
{
    public class ProjectUser
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public Project? Project { get; set; }
        public User? User { get; set; }
        public bool IsAdmin { get; set; } = false;
    }
}
