using Podium.Data.Entities;

namespace Podium.Data.Repositories
{
    public class ApplicantRepository : BaseRepository<Applicant>, IApplicantRepository
    {
        public ApplicantRepository(PodiumDbContext dbContext) : base(dbContext)
        {

        }
    }
}
