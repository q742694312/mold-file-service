using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class BimGispoint
    {
        public string Projectid { get; set; } = null!;
        public string? Pitname { get; set; }
        public double? Wgs84X { get; set; }
        public double? Wgs84Y { get; set; }
        public string? Camera { get; set; }
    }
}
