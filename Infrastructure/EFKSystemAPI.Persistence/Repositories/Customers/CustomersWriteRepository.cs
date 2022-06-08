using EFKSystemAPI.Application.Repositories.Customers;
using EFKSystemAPI.Domain.Entities;
using EFKSystemAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Persistence.Repositories.Customers
{
    public class CustomersWriteRepository : WriteRepository<Customer>, ICustomersWriteRepository
    {
        public CustomersWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
