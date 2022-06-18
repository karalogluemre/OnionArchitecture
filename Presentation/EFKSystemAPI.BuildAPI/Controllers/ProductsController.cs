using EFKSystemAPI.Application.Abstractions;
using EFKSystemAPI.Application.Repositories.Customers;
using EFKSystemAPI.Application.Repositories.Orders;
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
        private readonly IOrdersWriteRepository _ordersWriteRepository;
        private readonly ICustomersWriteRepository _customersWriteRepository;
        public ProductsController(IProductsWriteRepository productsWriteRepository, IProductsReadRepository productsReadRepository, IOrdersWriteRepository ordersWriteRepository, ICustomersWriteRepository customersWriteRepository)
        {
            _productsWriteRepository = productsWriteRepository;
            _productsReadRepository = productsReadRepository;
            _ordersWriteRepository = ordersWriteRepository;
            _customersWriteRepository = customersWriteRepository;
        }
        //[HttpGet]
        //public async Task Get()
        //{
        //    ////await _productsWriteRepository.SaveRangeAsync(new()
        //    ////{
        //    ////    new() { Id = Guid.NewGuid(), Name = "Product-1", Price = 200, CreateDate = DateTime.UtcNow, Stock = 30 }
        //    ////});
        //    ////var count = await _productsWriteRepository.SaveAsync();
        //    //Product p = await _productsReadRepository.GetByIdAsync("id gelecek");
        //    ////Product p = await _productsReadRepository.GetByIdAsync("id gelecek",false);// p.Name 'i değiştirildiği zaman Ahmet'i Mehmet yaparsak güncellemez. Tracking her sorguda takip edilen değeri değiştirir.False yaparsak takip edilen bu değer değişime kapalı olur.
        //    //p.Name = "Ahmet";
        //    //await _productsWriteRepository.SaveAsync();
        //    await _productsWriteRepository.AddAsync(new() { Name = "C# Project", Price = 1.500F, Stock = 10, CreateDate = DateTime.UtcNow });
        //    await _productsWriteRepository.SaveAsync();
        //}

        //[HttpGet]
        //public async Task<IActionResult> Get(string id)
        //{
        //    Product product = await _productsReadRepository.GetByIdAsync(id);
        //    return Ok(product);
        //}


        [HttpGet]
        public async Task Get()
        {
            var customerId = new Guid();
            await _customersWriteRepository.AddAsync(new() { Id = customerId, Name = "Deneme" });
            await _ordersWriteRepository.AddAsync(new() { Description = "Emre", Address = "Rize", CustomerId = customerId });
            await _ordersWriteRepository.AddAsync(new() { Description = "Feyza", Address = "Trabzon", CustomerId = customerId });
            await _ordersWriteRepository.SaveAsync();
        }
    }
}
