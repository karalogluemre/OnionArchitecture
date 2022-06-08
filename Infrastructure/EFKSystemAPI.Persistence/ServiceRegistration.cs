﻿using Microsoft.EntityFrameworkCore;
using EFKSystemAPI.Application.Abstractions;
using EFKSystemAPI.Persistence.Concretes;
using EFKSystemAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFKSystemAPI.Application.Repositories.Customers;
using EFKSystemAPI.Persistence.Repositories.Customers;
using EFKSystemAPI.Application.Repositories.Orders;
using EFKSystemAPI.Persistence.Repositories.Orders;
using EFKSystemAPI.Application.Repositories.Products;
using EFKSystemAPI.Persistence.Repositories.Products;

namespace EFKSystemAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(Configuration.Configurations.ConnectionString),ServiceLifetime.Singleton);
            services.AddSingleton<ICustomersReadRepository, CustomersReadRepository>();
            services.AddSingleton<ICustomersWriteRepository, CustomersWriteRepository>();
            services.AddSingleton<IOrdersReadRepository, OrdersReadRepository>();
            services.AddSingleton<IOrdersWriteRepository, OrdersWriteRepository>();
            services.AddSingleton<IProductsReadRepository, ProductsReadRepository>();
            services.AddSingleton<IProductsWriteRepository, ProductsWriteRepository>();

        }
    }
}
