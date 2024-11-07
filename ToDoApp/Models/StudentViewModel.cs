using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class StudentViewModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(250)]
        public string University { get; set; }
    }
}