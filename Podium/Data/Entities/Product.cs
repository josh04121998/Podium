using Podium.Data.Enums;
using System;

namespace Podium.Data.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Lender { get; set; }
        public decimal InterestRate { get; set; }
        public LoanType LoanType { get; set; }
        public decimal LoanToValue { get; set; }
    }
}
