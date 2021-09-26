using Podium.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Podium.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
