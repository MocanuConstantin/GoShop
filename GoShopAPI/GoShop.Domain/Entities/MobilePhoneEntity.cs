using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities;

public class MobilePhoneEntity
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Condition { get; set; } // E.g., New, Like New, Used, etc.
    public string Description { get; set; } 
    public decimal Price { get; set; } = 0;
}
