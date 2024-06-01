using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities;

public class MobilePhoneSoftwareEntity
{
    public int Id { get; set; }
    public string OperatingSystem { get; set; } // e.g., Android, iOS
    public string OSVersion { get; set; } // e.g., Android 11, iOS 14.4
    public string FirmwareVersion { get; set; } // Firmware version details
    public bool IsRootedOrJailbroken { get; set; } // Indicates if the device is rooted/jailbroken
    public DateTime LastSoftwareUpdate { get; set; } // Date of the last software update
}
