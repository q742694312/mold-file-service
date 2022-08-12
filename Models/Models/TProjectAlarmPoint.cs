using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TProjectAlarmPoint
    {
        public long Id { get; set; }
        public string? SummaryTableId { get; set; }
        public long? Pid { get; set; }
        public int? MonitorTime { get; set; }
        public string? PointName { get; set; }
        public long? PointId { get; set; }
        public string? ProjectAlarmPointId { get; set; }

        public virtual TMonitorPoint? Point { get; set; }
    }
}
