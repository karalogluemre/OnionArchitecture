using Microsoft.EntityFrameworkCore;
using EFKSystemAPI.Application.Abstractions;
using EFKSystemAPI.Persistence.Concretes;
using EFKSystemAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(Configuration.Configurations.ConnectionString));

        }
    }
}
