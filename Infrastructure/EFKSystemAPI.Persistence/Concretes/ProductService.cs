using EFKSystemAPI.Application.Abstractions;
using EFKSystemAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
         => new()
         {
             new() { Id = Guid.NewGuid(), Name = "Product Test-1", Price = 100, CreateDate = DateTime.Now, Stock = 10 },
             new() { Id = Guid.NewGuid(), Name = "Product Test-2", Price = 200, CreateDate = DateTime.Now, Stock = 20 },
             new() { Id = Guid.NewGuid(), Name = "Product Test-3", Price = 300, CreateDate = DateTime.Now, Stock = 30 },
             new() { Id = Guid.NewGuid(), Name = "Product Test-4", Price = 400, CreateDate = DateTime.Now, Stock = 40 }
         };
    }
}
