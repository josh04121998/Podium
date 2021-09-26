using System;
using System.Collections.Generic;

namespace PodiumWeb.Dtos
{
    public class MortgageProposalDto
    {
        public Guid Id { get; set; }

        public Guid MortgageRequirementId { get; set; }
        public MortgageRequirementDto MortgageRequirement { get; set; }

        public IEnumerable<MortgageProposalProductDto> Products { get; set; }
    }
}
