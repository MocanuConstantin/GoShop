using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities;

public class MobilePhoneHardwareEntity
{
    public Guid Id { get; set; }
    public Guid MobilePhoneId { get; set; }
    public string Processor { get; set; } = default!;
    public string RAM { get; set; } = default!;
    public string Storage { get; set; } = default!;
    public string Display { get; set; } = default!;
    public string Battery { get; set; } = default!;
    public string Camera { get; set; } = default!;
    public string Dimensions { get; set; } = default!;
    public string Weight { get; set; } = default!;

    public MobilePhoneEntity mobilePhoneEntity { get; set; } = default!;
}