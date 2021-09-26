using System;

namespace PodiumWeb.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Lender { get; set; }
        public decimal InterestRate { get; set; }
        public string LoanType { get; set; }
        public decimal LoanToValue { get; set; }
    }
}
