using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Riverlocation
    {
        public int Id { get; set; }
        public int? Riverintervalid { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Wgs84x { get; set; }
        public double? Wgs84y { get; set; }
        public int? Order { get; set; }
    }
}
