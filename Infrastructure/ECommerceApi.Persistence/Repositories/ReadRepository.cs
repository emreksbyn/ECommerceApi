using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities.Common;
using ECommerceApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerceApi.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceApiDbContext _dbContext;
        public ReadRepository(ECommerceApiDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public DbSet<T> Table => _dbContext.Set<T>();

        public IQueryable<T> GetAll()
            => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);
        public async Task<T> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }
}