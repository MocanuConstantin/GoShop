using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities;

public class MobilePhoneEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid MobilePhoneHardwareId { get; set; }
    public Guid MobilePhoneSoftwareId { get; set; }
    public string Brand { get; set; } = default!;
    public string Model { get; set; } = default!;
    public int Year { get; set; }
    public string Condition { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; } = 0;
    public MobilePhoneHardwareEntity MobilePhoneHardwareEntity { get; set; } = default!;
    public MobilePhoneSoftwareEntity MobilePhoneSoftwareEntity { get; set; } = default!;
    public UserEntity User { get; set; } = default!;
}
