﻿using fil_rouge_api.Models;
using System.ComponentModel.DataAnnotations;

namespace fil_rouge_api.DTOs
{
    public class ProjectDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public List<UserDTO> Users { get; set; } = new List<UserDTO>();
        public List<TaskDTO> Tasks { get; set; } = new List<TaskDTO>();
    }
}
