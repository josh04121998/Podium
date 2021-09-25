using System;
using System.ComponentModel.DataAnnotations;
namespace PodiumWeb.Models
{
    public class NewApplicant
    {
            [Required]
            public string firstname { get; set; }
            [Required]
            public string lastname { get; set; }
            [Required]
            public DateTime dateOfBirth { get; set; } = DateTime.Today;
            [Required]
            public string email { get; set; }
    }
}
