using GoShop.Domain.Entities;

namespace GoShop.Domain.Interfaces;

public interface IUserRepository
{
    Task<List<UserEntity>> GetAllAsync(CancellationToken cancellationToken);

    Task<int> GetCountByFiltersAsync(CancellationToken cancellationToken);
}