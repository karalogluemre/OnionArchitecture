using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> SaveAsync(T entity);
        Task<bool> SaveAsync(List<T> entity);
        Task<bool> Remove(T entity);
        Task<bool> Remove(string id);
        Task<bool> UpdateAsync(T entity);
    }
}
