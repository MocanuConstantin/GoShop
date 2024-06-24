using GoShop.Domain.Entities;

namespace GoShop.Domain.Interfaces;

public interface IMobilePhoneSoftwareRepository
{
    Task<List<MobilePhoneSoftwareEntity>> GetAllAsync(CancellationToken cancellationToken);

    Task<int> GetCountByFiltersAsync(CancellationToken cancellationToken);
}