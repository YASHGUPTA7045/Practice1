﻿using System.ComponentModel.DataAnnotations;

namespace PracticeCrud.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

    }
}
