using GoShop.Domain.Entities;
using GoShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Interfaces;

public interface IUserService
{
    Task<List<UserEntity>> GetAllAsync(UserFiltersModel model, CancellationToken cancellationToken);

    Task<int> GetCountByFiltersAsync(UserFiltersModel model, CancellationToken cancellationToken);
}