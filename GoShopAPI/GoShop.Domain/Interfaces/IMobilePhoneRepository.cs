using GoShop.Domain.Entities;

namespace GoShop.Domain.Interfaces;

public interface IMobilePhoneRepository
{
    Task<List<MobilePhoneEntity>> GetAllAsync(CancellationToken cancellationToken);

    Task<int> GetCountByFiltersAsync(CancellationToken cancellationToken);
}