using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BookShelf.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(25)]
        [MinLength(1)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(35)]
        [MinLength(1)]
        public string LastName { get; set; }
        // another way to write this: public string FullName => $"{FirstName} {LastName}";
        [NotMapped]
        public string FullName { 
            get
            {
                return $"{FirstName} {LastName}";
            } 
        }
    }
}