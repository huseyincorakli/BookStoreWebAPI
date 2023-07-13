using BookStoreAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 444, Stock = 444,CreatedDate=DateTime.UtcNow},
                new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 555, Stock = 555,CreatedDate=DateTime.UtcNow},
                new() { Id = Guid.NewGuid(), Name = "Product 6", Price = 666, Stock = 666,CreatedDate=DateTime.UtcNow},

            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
