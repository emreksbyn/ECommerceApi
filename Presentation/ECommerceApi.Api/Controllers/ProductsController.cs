using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            this._productReadRepository = productReadRepository;
            this._productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "A Product", Price = 100, Stock = 10, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "B Product", Price = 200, Stock = 20, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "C Product", Price = 300, Stock = 30, CreatedDate = DateTime.UtcNow }
            });
            await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}