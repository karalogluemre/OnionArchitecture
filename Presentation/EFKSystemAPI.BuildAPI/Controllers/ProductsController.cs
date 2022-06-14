using EFKSystemAPI.Application.Abstractions;
using EFKSystemAPI.Application.Repositories.Products;
using EFKSystemAPI.Domain.Entities;
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
        public async Task Get()
        {
            //await _productsWriteRepository.SaveRangeAsync(new()
            //{
            //    new() { Id = Guid.NewGuid(), Name = "Product-1", Price = 200, CreateDate = DateTime.UtcNow, Stock = 30 }
            //});
            //var count = await _productsWriteRepository.SaveAsync();
            Product p = await _productsReadRepository.GetByIdAsync("id gelecek");
            //Product p = await _productsReadRepository.GetByIdAsync("id gelecek",false);// p.Name 'i değiştirildiği zaman Ahmet'i Mehmet yaparsak güncellemez. Tracking her sorguda takip edilen değeri değiştirir.False yaparsak takip edilen bu değer değişime kapalı olur.
            p.Name = "Ahmet";
            await _productsWriteRepository.SaveAsync();
        }

        [HttpGet]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productsReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
