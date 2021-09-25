using Podium.Data.Entities;

namespace Podium.Data.Repositories
{
    public class MortgageRequirementRepository : BaseRepository<MortgageRequirement>, IMortgageRequirementRepository
    {
        public MortgageRequirementRepository(PodiumDbContext dbContext) : base(dbContext)
        {

        }
    }
}
