﻿using System.ComponentModel.DataAnnotations;

namespace fil_rouge_api.DTOs
{
    public class UserDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}