using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities.Common;
using ECommerceApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ECommerceApi.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ECommerceApiDbContext _dbContext;
        public WriteRepository(ECommerceApiDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public DbSet<T> Table => _dbContext.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }
        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }
        public bool Remove(T model)
        {
            EntityEntry entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }
        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }
        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(model);
        }
        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
            => await _dbContext.SaveChangesAsync();
    }
}