using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Models;

public class MobilePhoneFiltersModel
{
    public int? Count { get; set; }
    public int? Offset { get; set; }
    public string? SortBy { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; } = 0;
}
