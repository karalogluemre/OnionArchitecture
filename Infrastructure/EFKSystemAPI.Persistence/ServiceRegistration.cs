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
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql("User ID=emre;Password=1e2m3r4e++;Host=localhost;Port=5432;Database=EFKSysytem;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;"));

        }
    }
}
