using ECommerceApi.Domain.Entities.Common;
using System.Linq.Expressions;
// ("bool tracking = true") Select sorgusu gelen sonuçların tracking edilmesini önlemek için tracking parametreleri ekledik. Default olarak true bıraktık yani başta tracking mekanizması aktif gelmesi için bir kolaylık sağlamak istedik. Bu değeri false çekersek değişiklikler database' e yansımaz takip edilmesi durur. Manipule etmediğimiz yani değişiklik yapmadığımız sorgularda luzumsuz olan takibi kapatmamıza yarar.
namespace ECommerceApi.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        // Select işlemi yapacağımız için IEnumerable / List yapmamamız gerekir !!
        // Çünkü IQueryable olarak sorgumuzu yollarsak şartlarımızla birlikte yollamış oluruz.
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}