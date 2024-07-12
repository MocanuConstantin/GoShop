using GoShop.Domain.Entities;
using GoShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Interfaces;

public interface IMobilePhoneService
{
    Task<List<MobilePhoneEntity>> GetAllAsync(MobilePhoneFiltersModel model, CancellationToken cancellationToken);

    Task<int> GetCountByFiltersAsync(MobilePhoneFiltersModel model, CancellationToken cancellationToken);

    Task<MobilePhoneEntity> CreateAsync(MobilePhoneEntity mobilePhoneEntity, CancellationToken cancellationToken);
}