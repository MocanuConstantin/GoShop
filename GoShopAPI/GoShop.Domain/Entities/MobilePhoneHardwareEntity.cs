using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities;

public class MobilePhoneHardwareEntity
{
    public int Id { get; set; }
    public string Processor { get; set; } // e.g., Snapdragon 888, A14 Bionic
    public string RAM { get; set; } // e.g., 4GB, 8GB
    public string Storage { get; set; } // e.g., 64GB, 128GB
    public string Display { get; set; } // e.g., 6.5-inch OLED, 1080x2400 pixels
    public string Battery { get; set; } // e.g., 4000mAh, Li-Ion
    public string Camera { get; set; } // e.g., 12MP rear, 8MP front
    public string Dimensions { get; set; } // e.g., 146.7 x 71.5 x 7.4 mm
    public string Weight { get; set; } // e.g., 189 grams 
}
