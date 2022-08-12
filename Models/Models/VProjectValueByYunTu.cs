using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class VProjectValueByYunTu
    {
        public string DataSource { get; set; } = null!;
        public int PrjId { get; set; }
        public string Name { get; set; } = null!;
        public string? ProjectType { get; set; }
        public string? MonitorType { get; set; }
        public string? PointName { get; set; }
        public double? CurrentVariance { get; set; }
        public int? PointId { get; set; }
        public double? Value { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
