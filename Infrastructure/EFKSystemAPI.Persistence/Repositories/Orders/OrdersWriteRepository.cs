using EFKSystemAPI.Application.Repositories.Orders;
using EFKSystemAPI.Domain.Entities;
using EFKSystemAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Persistence.Repositories.Orders
{
    public class OrdersWriteRepository : WriteRepository<Order>, IOrdersWriteRepository
    {
        public OrdersWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
