using EFKSystemAPI.Application.Repositories;
using EFKSystemAPI.Domain.Entities;
using EFKSystemAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Persistence.Repositories
{
    public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
