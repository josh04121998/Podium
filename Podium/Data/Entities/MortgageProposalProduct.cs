using System;

namespace Podium.Data.Entities
{
    public class MortgageProposalProduct
    {
        public Guid Id { get; set; }

        public Guid MortgageProposalId { get; set; }
        public virtual MortgageProposal MortgageProposal { get; set; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
