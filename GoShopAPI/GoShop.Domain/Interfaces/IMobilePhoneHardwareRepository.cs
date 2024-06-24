using GoShop.Domain.Entities;

namespace GoShop.Domain.Interfaces;

public interface IMobilePhoneHardwareRepository
{
    Task<List<MobilePhoneHardwareEntity>> GetAllAsync(CancellationToken cancellationToken);

    Task<int> GetCountByFiltersAsync(CancellationToken cancellationToken);
}