using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

public class City
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? CityAbbreviation { get; set; }
    public int RegionId { get; set; }
    public Region? Regions { get; set; }
}
