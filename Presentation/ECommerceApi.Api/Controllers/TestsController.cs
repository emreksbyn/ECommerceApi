using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public TestsController(
            IProductReadRepository productReadRepository,
            IProductWriteRepository productWriteRepository,
            IOrderWriteRepository orderWriteRepository,
            ICustomerWriteRepository customerWriteRepository,
            IOrderReadRepository orderReadRepository)
        {
            this._productReadRepository = productReadRepository;
            this._productWriteRepository = productWriteRepository;
            this._orderWriteRepository = orderWriteRepository;
            this._customerWriteRepository = customerWriteRepository;
            this._orderReadRepository = orderReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Id = Guid.NewGuid(), Name = "A Product", Price = 100, Stock = 10, CreatedDate = DateTime.UtcNow },
            //    new() { Id = Guid.NewGuid(), Name = "B Product", Price = 200, Stock = 20, CreatedDate = DateTime.UtcNow },
            //    new() { Id = Guid.NewGuid(), Name = "C Product", Price = 300, Stock = 30, CreatedDate = DateTime.UtcNow }
            //});
            //await _productWriteRepository.SaveAsync();

            //Product product = await _productReadRepository.GetByIdAsync("fe7ad531-d5c7-431b-a576-4bb8b7b1a1de", false);
            //product.Name = "ABC Product";
            //await _productWriteRepository.SaveAsync();

            //await _productWriteRepository.AddAsync(new() { Name = "Tt Prodcut", Price = 1.000F, Stock = 10, CreatedDate = DateTime.UtcNow });
            //await _productWriteRepository.SaveAsync();

            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "Emre" });

            //await _orderWriteRepository.AddAsync(new() { Description = "deneme1", Address = "Gongul", CustomerId = customerId });
            //await _orderWriteRepository.AddAsync(new() { Description = "deneme2", Address = "Zong.", CustomerId = customerId });
            //await _orderWriteRepository.SaveAsync();
            Order order = await _orderReadRepository.GetByIdAsync("60588f50-72a4-48c1-9a22-cd79182a345d");
            order.Address = "İstanbul";
            order.Description = "deneme 12345";
            await _orderWriteRepository.SaveAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(string id)
        //{
        //    Product product = await _productReadRepository.GetByIdAsync(id);
        //    return Ok(product);
        //}
    }
}