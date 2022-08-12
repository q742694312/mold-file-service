using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TMonitorPoint
    {
        public TMonitorPoint()
        {
            TMonitorPointSettings = new HashSet<TMonitorPointSetting>();
            TProjectAlarmPoints = new HashSet<TProjectAlarmPoint>();
        }

        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? State { get; set; }
        public byte? Deleted { get; set; }
        public long? DataTypeId { get; set; }
        public decimal? Depth { get; set; }
        public int? DisplayOrder { get; set; }
        public decimal? HoleElevation { get; set; }
        public string? HoleId { get; set; }
        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public decimal? Z { get; set; }
        public long Id { get; set; }
        public long? MonitorProjectId { get; set; }
        public long? Pid { get; set; }
        public string? Note { get; set; }
        public string? MonitorPointId { get; set; }

        public virtual ICollection<TMonitorPointSetting> TMonitorPointSettings { get; set; }
        public virtual ICollection<TProjectAlarmPoint> TProjectAlarmPoints { get; set; }
    }
}
