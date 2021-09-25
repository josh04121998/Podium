namespace Podium.Data.Dtos
{
    public class RequestedMortgageRequirementDto
    {
        public string ApplicantId { get; set; }
        public decimal PropertyValue { get; set; }
        public decimal DepositAmount { get; set; }
    }
}
