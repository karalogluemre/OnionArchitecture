using EFKSystemAPI.Application.Abstractions.Storage;
using EFKSystemAPI.Application.Abstractions.Token;
using EFKSystemAPI.Infrastructure.Enums;
using EFKSystemAPI.Infrastructure.Services.Storage;
using EFKSystemAPI.Infrastructure.Services.Storage.Azure;
using EFKSystemAPI.Infrastructure.Services.Storage.Local;
using EFKSystemAPI.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace EFKSystemAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:

                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
