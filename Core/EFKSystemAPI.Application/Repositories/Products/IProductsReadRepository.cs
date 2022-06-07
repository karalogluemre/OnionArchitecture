using EFKSystemAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Application.Repositories.Products
{
    public interface IProductsReadRepository : IReadRepository<Product>
    {
    }
}
