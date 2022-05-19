using ECommerceApi.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ECommerceApi.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        // Select işlemi yapacağımız için IEnumerable / List yapmamamız gerekir !!
        // Çünkü IQueryable olarak sorgumuzu yollarsak şartlarımızla birlikte yollamış oluruz.
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(string id);
    }
}