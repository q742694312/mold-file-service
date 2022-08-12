using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TMonitorProjectSetting
    {
        public long Id { get; set; }
        public int? LastestMonitorTime { get; set; }
        public DateTime? LastestMonitorDate { get; set; }
        public decimal? TotalAlertUpLimit { get; set; }
        public decimal? TotalAlertLowerLimit { get; set; }
        public decimal? TotalWarningUpLimit { get; set; }
        public decimal? TotalWarningLowerLimit { get; set; }
        public decimal? DailyAlertUpLimit { get; set; }
        public decimal? DailyAlertLowerLimit { get; set; }
        public decimal? DailyWarningUpLimit { get; set; }
        public decimal? DailyWarningLowerLimit { get; set; }
        public long? MoniotorProjectId { get; set; }
        public long? Pid { get; set; }
        public string? MonitorProjectSettingId { get; set; }

        public virtual TMonitorProject? MoniotorProject { get; set; }
    }
}
