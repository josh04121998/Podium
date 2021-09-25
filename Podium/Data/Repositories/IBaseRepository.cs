using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Podium.Data.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);

        Task<T> CreateAsync(T entity);
    }
}
