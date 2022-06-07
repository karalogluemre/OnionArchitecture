using EFKSystemAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> SaveAsync(T entity);
        Task<bool> SaveRangeAsync(List<T> entity);
        bool Remove(T entity);
        bool RemoveRange(List<T> entity);
        Task<bool> Remove(string id);
        bool UpdateAsync(T entity);
        Task<int> SaveAsync();
    }
}
