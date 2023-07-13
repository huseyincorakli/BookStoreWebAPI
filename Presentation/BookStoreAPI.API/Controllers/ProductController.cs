using BookStoreAPI.Application.Repositories;
using BookStoreAPI.Domain.Entities;
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
            Product product =await _productReadRepository.GetByIdAsync("338719b2-286c-4b52-a82c-05ae76254228",false);
            product.Name = "Product 7";
            await _productWriteRepository.SaveAsync();
        }
    }
}
