using System;

namespace PodiumWeb.Dtos
{
    public class MortgageProposalProductDto
    {
        public Guid Id { get; set; }

        public Guid MortgageProposalId { get; set; }

        public Guid ProductId { get; set; }
        public ProductDto Product { get; set; }
    }
}
