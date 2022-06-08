using EFKSystemAPI.Application.Repositories.Products;
using EFKSystemAPI.Domain.Entities;
using EFKSystemAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Persistence.Repositories.Products
{
    public class ProductsWriteRepository : WriteRepository<Product>, IProductsWriteRepository
    {
        public ProductsWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
