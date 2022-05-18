using ECommerceApi.Domain.Entities;

namespace ECommerceApi.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}