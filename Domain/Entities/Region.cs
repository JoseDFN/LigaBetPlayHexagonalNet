using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Region
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Abbreviation { get; set; }
    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public ICollection<City>? Cities { get; set; }
}
