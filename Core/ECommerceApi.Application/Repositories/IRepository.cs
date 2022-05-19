using ECommerceApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}