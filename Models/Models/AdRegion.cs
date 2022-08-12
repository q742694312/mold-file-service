using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class AdRegion
    {
        public int Id { get; set; }
        public string? Region { get; set; }
        public int? Sequence { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Wgs84X { get; set; }
        public double? Wgs84Y { get; set; }
    }
}
