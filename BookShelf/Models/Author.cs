﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(1)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(35)]
        [MinLength(1)]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string PenName { get; set; }
        public string PreferredGenre { get; set; }
        public List<Book> Books { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
