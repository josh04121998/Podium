using Podium.Data.Entities;

namespace Podium.Data.Repositories
{
    public class MortgageProposalRepository : BaseRepository<MortgageProposal>, IMortgageProposalRepository
    {
        public MortgageProposalRepository(PodiumDbContext dbContext) : base(dbContext)
        {

        }
    }
}
