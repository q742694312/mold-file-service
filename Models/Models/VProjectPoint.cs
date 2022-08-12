using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class VProjectPoint
    {
        public string DataSource { get; set; } = null!;
        public long PrjId { get; set; }
        public string? Name { get; set; }
        public string? ProjectType { get; set; }
        public string? MonitorType { get; set; }
        public string? PointName { get; set; }
        public string? Location { get; set; }
        public string? RingNumber { get; set; }
        public double? Mileage { get; set; }
        public double? Depth { get; set; }
    }
}
