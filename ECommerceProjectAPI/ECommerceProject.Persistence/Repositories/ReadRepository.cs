using ECommerceProject.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ECommerceProject.Domain.Common;
using ECommerceProject.Persistence.Contexts;

namespace ECommerceProject.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly EcommerceDbContext _context;

        public ReadRepository(EcommerceDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool isTracking = true)
        {
            var query = Table.AsQueryable();
            if (!isTracking)
                query = query.AsNoTracking();
            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool isTracking = true)
        {
            var query = Table.Where(predicate);
            if (!isTracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, bool isTracking = true)
        {
            var query = Table.AsQueryable();
            if (!isTracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> GetByIdAsync(int id, bool isTracking = true)
        /*Table.FirstOrDefaultAsync(x => x.Id == id);*/
        {
            var query = Table.AsQueryable();
            if (!isTracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
