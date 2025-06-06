using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Country
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Region>? Regions { get; set; }
}
