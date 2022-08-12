using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class VProjectValue
    {
        public string DataSource { get; set; } = null!;
        public long PrjId { get; set; }
        public string Name { get; set; } = null!;
        public string? ProType { get; set; }
        public string? MonitorType { get; set; }
        public string? PointName { get; set; }
        public double? CurrentVariance { get; set; }
        public long? PointId { get; set; }
        public int? MonitorTimes { get; set; }
        public double? Currentvalue { get; set; }
        public DateTime? MonitorDate { get; set; }
        public decimal? TotalVariance { get; set; }
        public string? TotalWarningState { get; set; }
        public decimal? DailyVariance { get; set; }
        public string? DailyWarningState { get; set; }
    }
}
