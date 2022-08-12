using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class VProjectValueByTianAn
    {
        public string DataSource { get; set; } = null!;
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? ProType { get; set; }
        public string? MonitorType { get; set; }
        public long? PointId { get; set; }
        public string? PointName { get; set; }
        public decimal? CurrentVariance { get; set; }
        public int? MonitorTimes { get; set; }
        public decimal? CurrentValue { get; set; }
        public DateTime? MonitorDate { get; set; }
        public decimal? TotalVariance { get; set; }
        public string? TotalWarningState { get; set; }
        public decimal? DailyVariance { get; set; }
        public string? DailyWarningState { get; set; }
        public decimal? Depth { get; set; }
    }
}
