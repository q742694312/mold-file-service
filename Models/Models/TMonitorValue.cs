using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TMonitorValue
    {
        public int Id { get; set; }
        public int? MonitorTimes { get; set; }
        public DateTime? MonitorDate { get; set; }
        public decimal? CurrentValue { get; set; }
        public decimal? CurrentVariance { get; set; }
        public decimal? TotalVariance { get; set; }
        public string? TotalWarningState { get; set; }
        public decimal? DailyVariance { get; set; }
        public string? DailyWarningState { get; set; }
        public string? DataComponentType { get; set; }
        public string? Pid { get; set; }
        public string? MonitorProjectId { get; set; }
        public string? MonitorPointId { get; set; }
        public string? MonitorPointSettingsId { get; set; }
        public string? MonitorvalueId { get; set; }
    }
}
