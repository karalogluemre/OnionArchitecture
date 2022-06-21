using F = EFKSystemAPI.Domain.Entities;

namespace EFKSystemAPI.Application.Repositories
{
    public interface IFileWriteRepository : IWriteRepository<F::File>
    {
    }
}
