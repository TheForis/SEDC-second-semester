﻿using System.ComponentModel.DataAnnotations;

namespace Qinshift.Movies.DomainModels
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}