using ECommerceApi.Application.Abstractions;
using ECommerceApi.Domain.Entities;

namespace ECommerceApi.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new() { Id = Guid.NewGuid(), Name = "A Product", Price = 100, Stock = 10, CreatedDate = DateTime.Today },
                new() { Id = Guid.NewGuid(), Name = "B Product", Price = 200, Stock = 10, CreatedDate = DateTime.Today },
                new() { Id = Guid.NewGuid(), Name = "C Product", Price = 300, Stock = 10, CreatedDate = DateTime.Today },
                new() { Id = Guid.NewGuid(), Name = "D Product", Price = 400, Stock = 10, CreatedDate = DateTime.Today },
                new() { Id = Guid.NewGuid(), Name = "E Product", Price = 500, Stock = 10, CreatedDate = DateTime.Today }
            };
    }
}