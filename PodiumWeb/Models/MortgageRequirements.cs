using System.ComponentModel.DataAnnotations;

namespace PodiumWeb.Models
{
    public class MortgageRequirements
    {
        [Required]
        public string ApplicantId { get; set; }
        [Required]
        public int PropertyValue { get; set; }
        [Required]
        public int DepositAmount { get; set; }
    }
}
