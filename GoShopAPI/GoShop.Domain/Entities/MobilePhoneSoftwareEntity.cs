using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities;

public class MobilePhoneSoftwareEntity
{
    public Guid Id { get; set; }
    public Guid MobilePhoneId { get; set; }
    public string OperatingSystem { get; set; } = default!;
    public string OSVersion { get; set; } = default!;
    public string FirmwareVersion { get; set; } = default!;
    public bool IsRootedOrJailbroken { get; set; }
    public DateTime LastSoftwareUpdate { get; set; } 

    public MobilePhoneEntity MobilePhone { get; set; } = default!;
}