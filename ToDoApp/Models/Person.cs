using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class Person
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
    }
}