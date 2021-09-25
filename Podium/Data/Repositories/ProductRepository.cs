using Podium.Data.Entities;

namespace Podium.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(PodiumDbContext dbContext) : base(dbContext)
        {

        }
    }
}
