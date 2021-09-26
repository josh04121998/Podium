using System;
using System.ComponentModel.DataAnnotations;
namespace PodiumWeb.Models
{
    public class NewApplicant
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; } = DateTime.Today;
        [Required]
        public string Email { get; set; }
    }
}
