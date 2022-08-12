using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TMonitorPointSetting
    {
        public decimal? TotalAlertUpLimit { get; set; }
        public decimal? TotalAlertLowerLimit { get; set; }
        public decimal? TotalWarningUpLimit { get; set; }
        public decimal? TotalWarningLowerLimit { get; set; }
        public decimal? DailyAlertUpLimit { get; set; }
        public decimal? DailyAlertLowerLimit { get; set; }
        public decimal? DailyWarningUpLimit { get; set; }
        public decimal? DailyWarningLowerLimit { get; set; }
        public decimal? InitialValue { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalUpdateTime { get; set; }
        public string? AlarmConfig { get; set; }
        public long Id { get; set; }
        public long? MonitorPointId { get; set; }
        public long? Pid { get; set; }
        public string? MonitorPointSettingsId { get; set; }

        public virtual TMonitorPoint? MonitorPoint { get; set; }
    }
}
