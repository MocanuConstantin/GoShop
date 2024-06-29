﻿using GoShop.Domain.Entities;
using GoShop.Domain.Models;


namespace GoShop.Domain.Interfaces;

public interface IMobilePhoneRepository
{
    Task<List<MobilePhoneEntity>> GetAllAsync(MobilePhoneFiltersModel model, CancellationToken cancellationToken);

    Task<int> GetCountByFiltersAsync(MobilePhoneFiltersModel model, CancellationToken cancellationToken);
}