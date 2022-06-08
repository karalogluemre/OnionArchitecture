using EFKSystemAPI.Application.Abstractions;
using EFKSystemAPI.Application.Repositories.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFKSystemAPI.BuildAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsWriteRepository _productsWriteRepository;
        private readonly IProductsReadRepository _productsReadRepository;
        public ProductsController(IProductsWriteRepository productsWriteRepository, IProductsReadRepository productsReadRepository)
        {
            _productsWriteRepository = productsWriteRepository;
            _productsReadRepository = productsReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productsWriteRepository.SaveRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product-1", Price = 200, CreateDate = DateTime.UtcNow, Stock = 30 }
            });
            var count = await _productsWriteRepository.SaveAsync();
        }
    }
}
