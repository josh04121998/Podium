using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Podium.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly PodiumDbContext _dbContext;
        private DbSet<T> _dbSet;

        public BaseRepository(PodiumDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> CreateAsync(T entity)
        {
            var result = await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
