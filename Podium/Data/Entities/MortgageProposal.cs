using System;
using System.Collections.Generic;

namespace Podium.Data.Entities
{
    public class MortgageProposal
    {
        public Guid Id { get; set; }

        public Guid MortgageRequirementId { get; set; }
        public virtual MortgageRequirement MortgageRequirement { get; set; }

        public IEnumerable<MortgageProposalProduct> Products { get; set; } = new List<MortgageProposalProduct>();

    }
}
