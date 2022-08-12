using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Road
    {
        public int Id { get; set; }
        public int? Sequence { get; set; }
        public string? Name { get; set; }
        public double? Wgs84x { get; set; }
        public double? Wgs84Y { get; set; }
        public int? ProjectId { get; set; }
    }
}
