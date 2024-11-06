using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class Student : Person
    {
        [Required]
        [StringLength(250)]
        public string University { get; set; }
    }
}